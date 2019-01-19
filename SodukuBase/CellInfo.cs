using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SodukuBase
{
    public class CellInfo
    {
        /// <summary>
        /// 当前初盘
        /// </summary>
        public SodukuMarket currentMarket;
        /// <summary>
        /// 行
        /// </summary>
        public int row;

        /// <summary>
        /// 列
        /// </summary>
        public int column;


        /// <summary>
        /// 初始化初盘之后,该单元格可填数据
        /// </summary>
        public List<int> initrest
        {
            get
            {
                return StaticTools.baseFillList.Except(currentMarket.rowDatas[row]
                    .Union(currentMarket.columnDatas[column]).Union(currentMarket.blockDatas[block])).ToList();
            }
        }

        /// <summary>
        /// 宫格
        /// </summary>
        public int block;


        /// <summary>
        /// 求解过程中,剩余可选项
        /// </summary>
        private List<int> solveRests;


        /// <summary>
        /// xwing排除项
        /// </summary>
        public List<int> xwing;


        /// <summary>
        /// 是否初始化数据
        /// </summary>
        public bool isInit;

        /// <summary>
        /// 单元格的值
        /// </summary>
        public int Value;

        /// <summary>
        /// 是否确认
        /// </summary>
        public bool isComfirm;

        public string ProgramPostion;

        public string showPostion;
        /// <summary>
        /// 3链数
        /// </summary>
        public List<int> hiddenTripletList;


        /// <summary>
        /// 3链数
        /// </summary>
        public List<int> UrList;

        /// <summary>
        /// 冲突练
        /// </summary>
        public List<int> Conflict;


        /// <summary>
        /// 其余宮的单行值或者单列值
        /// </summary>
        public List<int> blockList;

        /// <summary>
        /// 单元格的剩余可选项组成的串
        /// </summary>
        public string RestInfo => JsonConvert.SerializeObject(GetRest());

        /// <summary>
        /// 是否只有两个可选项
        /// </summary>
        public bool isTwoValue => GetRest().Count == 2;

        public static int GetBlock(int x, int y)
        {
            return (x / 3) * 3 + (y / 3);
        }
        public string variablename;
        
        public int location;
        public bool Equals(CellInfo x)
        {
            return ProgramPostion == x.ProgramPostion;
        }

        public CellInfo(int x, int y)
        {
            row = x;
            column = y;
            location = x * 9 + y;
            variablename = "x" + ("" + (location + 100)).Substring(1, 2);
            ProgramPostion = "postion_" + x + "_" + y;
            showPostion =  (x + 1) + "行" + (y + 1)+ "列" ;
            block = GetBlock(row, column);
            hiddenTripletList=new List<int>();
            xwing=new List<int>();
            blockList = new List<int>();
            UrList=new List<int>();
            Conflict=new List<int>();
            solveRests = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //solveRests = GetRest();
        }

        /// <summary>
        /// hangRest 0~8表示行
        /// </summary>
        /// <param name="value"></param>
        public void InitValue(int value)
        {
            SetValue(value);
            if (value != 0)
            {
                isInit = true;
            }
        }

        /// <summary>
        /// hangRest 0~8表示行
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(int value)
        {
            Value = value;

            currentMarket.rowDatas[row].Add(value);
            currentMarket.columnDatas[column].Add(value);
            currentMarket.blockDatas[block].Add(value);
            //if (value != 0)
            //{
            //    solveRests.Clear();
            //}
            //else
            //{
            //    solveRests = GetRest();
            //}
        }

        public List<int> GetRest()
        {
            foreach (var rowExists in currentMarket.rowDatas[row])
            {
                solveRests.Remove(rowExists);
            }

            foreach (var columnExists in currentMarket.columnDatas[column])
            {
                solveRests.Remove(columnExists);
            }

            foreach (var gongExists in currentMarket.blockDatas[block])
            {
                solveRests.Remove(gongExists);
            }

            foreach (var xwingexists in xwing)
            {
                solveRests.Remove(xwingexists);
            }
            foreach (var xwingexists in hiddenTripletList)
            {
                solveRests.Remove(xwingexists);
            }
            foreach (var xwingexists in blockList)
            {
                solveRests.Remove(xwingexists);
            }

            foreach (var xwingexists in UrList)
            {
                solveRests.Remove(xwingexists);
            }

            foreach (var xwingexists in Conflict)
            {
                solveRests.Remove(xwingexists);
            }
            solveRests.Sort();
            return solveRests;
        }
    }
}