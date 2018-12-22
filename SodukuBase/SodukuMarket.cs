using System;
using System.Collections.Generic;
using System.Linq;

namespace SodukuBase
{
    public class SodukuMarket
    {
        /// <summary>
        /// 初始化链表个数
        /// </summary>
        public List<List<int>> initValues;

        public List<SetValueStep> setSteps;

        public List<RemoveValueStep> removeValueSteps;

        /// <summary>
        /// 坐标与单元格的信息
        /// </summary>
        private Dictionary<string, CellInfo> cellInfos=new Dictionary<string, CellInfo>();


        public Dictionary<string, CellInfo> GetCellInfos()
        {
            return cellInfos;
        }
        private double _difficult;

        private List<int> _emptyLists;

        /// <summary>
        /// 横向9个链表
        /// 纵向9个链表
        /// 九宫格9个链表
        /// </summary>
        /// <returns></returns>
        public List<List<int>> FilledDatas()
        {
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < 9; i++)
            {
                result.Add(new List<int>());
            }

            return result;
        }


        /// <summary>
        /// 行已填充数据
        /// </summary>
        public List<List<int>> rowDatas;

        /// <summary>
        /// 列已填充数据
        /// </summary>
        public List<List<int>> columnDatas;


        /// <summary>
        /// 宫已填充数据
        /// </summary>
        public List<List<int>> blockDatas;

        /// <summary>
        /// 每一个宫对应的单元格信息
        /// </summary>
        private Dictionary<int, List<CellInfo>> blockCells = new Dictionary<int, List<CellInfo>>
        {
            {0, new List<CellInfo>()},
            {1, new List<CellInfo>()},
            {2, new List<CellInfo>()},
            {3, new List<CellInfo>()},
            {4, new List<CellInfo>()},
            {5, new List<CellInfo>()},
            {6, new List<CellInfo>()},
            {7, new List<CellInfo>()},
            {8, new List<CellInfo>()}
        };


        /// <summary>
        /// 每一行对应的单元格信息
        /// </summary>
        private Dictionary<int, List<CellInfo>> rowCells = new Dictionary<int, List<CellInfo>>
        {
            {0, new List<CellInfo>()},
            {1, new List<CellInfo>()},
            {2, new List<CellInfo>()},
            {3, new List<CellInfo>()},
            {4, new List<CellInfo>()},
            {5, new List<CellInfo>()},
            {6, new List<CellInfo>()},
            {7, new List<CellInfo>()},
            {8, new List<CellInfo>()}
        };


        /// <summary>
        /// 每一列对应的单元格信息
        /// </summary>
        private Dictionary<int, List<CellInfo>> columnCells = new Dictionary<int, List<CellInfo>>
        {
            {0, new List<CellInfo>()},
            {1, new List<CellInfo>()},
            {2, new List<CellInfo>()},
            {3, new List<CellInfo>()},
            {4, new List<CellInfo>()},
            {5, new List<CellInfo>()},
            {6, new List<CellInfo>()},
            {7, new List<CellInfo>()},
            {8, new List<CellInfo>()}
        };

        private Dictionary<int, CellInfo> locationCellDic = new Dictionary<int, CellInfo>();


        /// <summary>
        /// 空余链表位置
        /// </summary>
        public List<int> emptyLists =>
            _emptyLists ?? (_emptyLists = StaticInfos.allLocations.Except(this.initLists).ToList());

        /// <summary>
        /// 初始化链表位置
        /// </summary>
        public List<int> initLists;

        /// <summary>
        /// 数独难度
        /// </summary>
        public double difficult
        {
            get
            {
                if (_difficult == 0)
                {
                    _difficult = GetDifficult();
                }

                return _difficult;
            }
        }

        public void InitCells()
        {
            int x = 0;
            int location = 0;
            foreach (var lists in initValues)
            {
                int y = 0;
                foreach (var value in lists)
                {
                    CellInfo cell = new CellInfo(x, y);
                    cell.currentMarket = this;
                    cell.InitValue(value);
                    cellInfos.Add("postion_" + x + "_" + y, cell);

                    blockCells[cell.block].Add(cell);
                    columnCells[cell.column].Add(cell);
                    rowCells[cell.row].Add(cell);
                    locationCellDic.Add(location, cell);
                    location += 1;
                    y += 1;
                }

                x += 1;
            }
        }


        /// <summary>
        /// 获取数独的每个空格的平均候选数个数
        /// </summary>
        /// <returns></returns>
        private double GetDifficult()
        {
            List<int> allCount = new List<int>();

            foreach (var kv in locationCellDic)
            {
                var cell = kv.Value;
                if (!cell.isInit)
                {
                    allCount.Add(
                        StaticInfos.baseFillList.Except(
                            columnCells[cell.column].Select(c => c.Value).ToList()
                                .Union(
                                    rowCells[cell.row].Select(c => c.Value).ToList())
                                .Union(
                                    blockCells[cell.block].Select(c => c.Value).ToList())).Count());
                }
            }

            return 1.0 * allCount.Sum(c => c) / allCount.Count;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="initValues">数独初盘</param>
        /// <param name="initLists">剩余的有数据的位置</param>
        public SodukuMarket(List<List<int>> initValues, List<int> initLists) 
        {
            this.initValues = initValues;
            this.initLists = initLists;
            rowDatas = FilledDatas();
            columnDatas = FilledDatas();
            blockDatas = FilledDatas();
            InitCells();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="initValues">数独初盘</param>
        /// <param name="initLists">剩余的有数据的位置</param>
        public SodukuMarket(List<List<int>> initValues) 
        {
            this.initValues = initValues;
            int location = 0;
            this.initLists = new List<int>();
            foreach (var lists in initValues)
            {
                foreach (var value in lists)
                {
                    if (value != 0)
                    {
                        initLists.Add(location);
                    }

                    location += 1;
                }
            }
            rowDatas = FilledDatas();
            columnDatas = FilledDatas();
            blockDatas = FilledDatas();
            InitCells();
        }
    }
}