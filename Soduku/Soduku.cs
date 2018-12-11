﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Soduku
{
    /// <summary>
    /// 数独类
    /// </summary>
    public class Soduku
    {
        /// <summary>
        /// 制作完整的数独
        /// </summary>
        /// <returns></returns>
        public List<List<int>> MakeSoduku()
        {
            Random rm = new Random();
            var list1 = Soduku.GetRandom(1, true, 9, true, 9, rm, false);
            var list2 = moveToTail(list1, 3);
            var list3 = moveToTail(list1, 6);
            var list4 = moveToTail(list1, 1);
            var list5 = moveToTail(list1, 4);
            var list6 = moveToTail(list1, 7);
            var list7 = moveToTail(list1, 2);
            var list8 = moveToTail(list1, 5);
            var list9 = moveToTail(list1, 8);
            return new List<List<int>> {list1, list2, list3, list4, list5, list6, list7, list8, list9};
        }

        private List<int> moveToTail(List<int> list, int size)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i < size)
                {
                    a.Add(list[i]);
                }
                else
                {
                    b.Add(list[i]);
                }
            }

            b.AddRange(a);
            return b;
        }

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
        public static List<List<int>> rowDatas;

        /// <summary>
        /// 列已填充数据
        /// </summary>
        public static List<List<int>> columnDatas;


        /// <summary>
        /// 宫已填充数据
        /// </summary>
        public static List<List<int>> blockDatas;

        /// <summary>
        /// 坐标与单元格的信息
        /// </summary>
        private static Dictionary<string, CellInfo> cellInfos;


        /// <summary>
        /// 每一个宫对应的单元格信息
        /// </summary>
        private static Dictionary<int, List<CellInfo>> blockCells = new Dictionary<int, List<CellInfo>>
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
        private static Dictionary<int, List<CellInfo>> rowCells = new Dictionary<int, List<CellInfo>>
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
        private static Dictionary<int, List<CellInfo>> columnCells = new Dictionary<int, List<CellInfo>>
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
        /// 出题
        /// </summary>
        /// <returns></returns>
        public List<List<int>> Question()
        {
            if (false)
            {
                //该难度 唯余法 宮摒除 行摒除 列摒除 xwing就足够了。
                var list1 = new List<int> {0, 5, 0, 0, 0, 0, 0, 2, 0};
                var list2 = new List<int> {4, 0, 0, 2, 0, 6, 0, 0, 7};
                var list3 = new List<int> {0, 0, 8, 0, 3, 0, 1, 0, 0};
                var list4 = new List<int> {0, 1, 0, 0, 0, 0, 0, 6, 0};
                var list5 = new List<int> {0, 0, 9, 0, 0, 0, 5, 0, 0};
                var list6 = new List<int> {0, 7, 0, 0, 0, 0, 0, 9, 0};
                var list7 = new List<int> {0, 0, 5, 0, 8, 0, 3, 0, 0};
                var list8 = new List<int> {7, 0, 0, 9, 0, 1, 0, 0, 4};
                var list9 = new List<int> {0, 2, 0, 0, 0, 0, 0, 7, 0};
                return new List<List<int>> {list1, list2, list3, list4, list5, list6, list7, list8, list9};
            }
            else
            {
                var list1 = new List<int> {0, 8, 0, 0, 0, 0, 6, 0, 0};
                var list2 = new List<int> {0, 0, 0, 4, 0, 0, 0, 0, 9};
                var list3 = new List<int> {0, 7, 0, 0, 0, 0, 8, 0, 5};
                var list4 = new List<int> {4, 0, 0, 0, 0, 0, 0, 0, 0};
                var list5 = new List<int> {0, 3, 0, 0, 6, 0, 0, 9, 0};
                var list6 = new List<int> {0, 0, 0, 7, 2, 0, 1, 0, 0};
                //var list7 = new List<int> {0, 9, 3, 2, 0, 0, 0, 6, 4};
                var list7 = new List<int> { 0, 9, 3, 2, 0, 0, 0, 6, 4 };
                var list8 = new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0};
                var list9 = new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0};
                return new List<List<int>> {list1, list2, list3, list4, list5, list6, list7, list8, list9};
            }
        }

        public CellInfo GetCellInfo(string location)
        {
            return cellInfos[location];
        }

        public bool IsQuestion => cellInfos != null && cellInfos.Count != 0;


        /// <summary>
        /// 解题
        /// </summary>
        /// <returns></returns>
        public void Solve(List<List<int>> values, bool firsttime)

        {
            if (firsttime)
            {
                rowDatas = FilledDatas();
                columnDatas = FilledDatas();
                blockDatas = FilledDatas();
                cellInfos = new Dictionary<string, CellInfo>();

                int row = 0;
                foreach (var list in values)
                {
                    int column = 0;
                    foreach (var value in list)
                    {
                        CellInfo cell = new CellInfo(row, column);
                        if (value != 0)
                        {
                            cell.InitValue(value);
                        }

                        cellInfos.Add("postion_" + row + "_" + column, cell);
                        blockCells[cell.block].Add(cell);
                        rowCells[cell.row].Add(cell);
                        columnCells[cell.column].Add(cell);
                        column += 1;
                    }

                    row += 1;
                }
            }

            bool fillflag = true;

            int round = 1;
            while (fillflag)
            {
                fillflag = false;
                var weiyu = cellInfos.Values.Where(c => c.Value == 0 && c.GetRest().Count == 1).ToList();
                foreach (var cell in weiyu)
                {
                    var value = cell.GetRest()[0];
                    SolveMessage += "\r\n第" + round + "轮唯余法：" + (cell.row + 1) + "行" + (cell.column + 1) + "列的值为" +
                                    value +
                                    "\r\n";
                    cell.SetValue(value);
                    fillflag = true;
                }

                SolveMessage += "\r\n";
                foreach (var blockCell in blockCells)
                {
                    fillflag |= GetSingleValue(round, blockCells, blockCell.Key, "宫摒除");
                }

                foreach (var blockCell in columnCells)
                {
                    fillflag |= GetSingleValue(round, columnCells, blockCell.Key, "列摒除");
                }

                foreach (var blockCell in rowCells)
                {
                    fillflag |= GetSingleValue(round, rowCells, blockCell.Key, "行摒除");
                }

                for (int i = 1; i < 9; i++)
                {
                    //针对行的xwing
                    var result = GetXwing(i, GetCellsDic(MethodDiction.Row));
                    GetRowXwing(result, round, i);
                    //针对列的xwing
                    var result1 = GetXwing(i, GetCellsDic(MethodDiction.Column));
                    GetColumnXwing(result1, round, i);
                }


                for (int index = 0; index < 9; index++)
                {
                    HiddenTriplet(MethodDiction.Row, index);
                    HiddenTriplet(MethodDiction.Column, index);
                    HiddenTriplet(MethodDiction.Block, index);

                    blockSingleRow(MethodDiction.Block, index);

                    blockSingleColomn(MethodDiction.Block, index);
                }

      

                round = round + 1;
            }

            foreach (var kv in rowCells)
            {
                var temp = kv.Value.Where(c => c.Value == 0);
                foreach (var cellInfo in temp)
                {
                    SolveMessage += cellInfo.ProgramPostion + JsonConvert.SerializeObject(cellInfo.GetRest())+"\r\n";
                }

                SolveMessage += "\r\n";
            }
        }

        private void GetRowXwing(Dictionary<int, CellInfo> result, int round, int i)
        {
            bool fillflag;
            if (result.Count == 4 && result[0].column == result[2].column &&
                result[1].column == result[3].column)
            {
                SolveMessage += "\r\n第" + round + "轮\r\n" + result[0].showPostion + " 和 " + result[1].showPostion +
                                "\r\n" + result[2].showPostion + " 和 " + result[3].showPostion + "\r\n构成" + i +
                                "的行xwing\r\n";

                SolveMessage += "可以移除除了" + (result[0].row + 1) + "," +
                                (result[2].row + 1) + "行的第" + +(result[0].column + 1) + "列的待选项值" + i + "\r\n";

                SolveMessage += "可以移除除了" + (result[0].row + 1) + "," +
                                (result[2].row + 1) + "行的第" + +(result[1].column + 1) + "列的待选项值" + i + "\r\n";
                fillflag = true;
                MoveColumnValue(result[0].column, i, result[0].row, result[2].row);
                MoveColumnValue(result[1].column, i, result[0].row, result[2].row);
            }
        }


        private void GetColumnXwing(Dictionary<int, CellInfo> result, int round, int i)
        {
            bool fillflag;
            if (result.Count == 4 && result[0].row == result[2].row &&
                result[1].row == result[3].row)
            {
                SolveMessage += "\r\n第" + round + "轮\r\n" + result[0].showPostion + " 和 " + result[1].showPostion +
                                "\r\n" + result[2].showPostion + " 和 " + result[3].showPostion + "\r\n构成" + i +
                                "的列xwing\r\n";

                SolveMessage += "可以移除除了" + (result[0].column + 1) + "," +
                                (result[2].column + 1) + "列的第" + +(result[0].row + 1) + "行的待选项值" + i + "\r\n";

                SolveMessage += "可以移除除了" + (result[0].row + 1) + "," +
                                (result[2].column + 1) + "列的第" + +(result[1].row + 1) + "行的待选项值" + i + "\r\n";
                fillflag = true;
                MoveRowValue(result[0].row, i, result[0].column, result[2].column);
                MoveRowValue(result[1].row, i, result[0].column, result[2].column);
            }
        }


        //todo 待补充以宫为遍历条件 1.xywing 2.数对 3.ur的判断逻辑


        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <param name="column1"></param>
        /// <param name="column2"></param>
        private void MoveRowValue(int row, int value, int column1, int column2)
        {
            for (int column = 0; column < 9; column++)
            {
                if (column == column1 || column == column2)
                {
                    continue;
                }

                cellInfos["postion_" + row + "_" + column].xwing.Add(value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="column">待移除列</param>
        /// <param name="value">待移除项</param>
        /// <param name="row1">排除行1</param>
        /// <param name="row2">排除行2</param>
        private void MoveColumnValue(int column, int value, int row1, int row2)
        {
            for (int row = 0; row < 9; row++)
            {
                if (row == row1 || row == row2)
                {
                    continue;
                }

                cellInfos["postion_" + row + "_" + column].xwing.Add(value);
            }
        }

        /// <summary>
        /// 方法方向
        /// </summary>
        enum MethodDiction
        {
            [Description("行")] Row,
            [Description("列")] Column,
            [Description("宫")] Block
        }


        private void blockSingleRow(MethodDiction method, int index)
        {
            var cellsDic = GetCellsDic(method);
            var listcells = cellsDic[index].Where(c => c.Value == 0).ToList();
            var allRest = new List<int>();
            foreach (var cell in listcells)
            {
                allRest.AddRange(cell.GetRest());
            }

            var distinct = allRest.Distinct().ToList();

            Dictionary<int, List<int>> temp = new Dictionary<int, List<int>>();

            foreach (var value in distinct)
            {
                temp.Add(value, new List<int>());
            }

            foreach (var cellInfo in listcells)
            {
                foreach (var value in distinct)
                {
                    if (cellInfo.GetRest().Contains(value))
                    {
                        temp[value].Add(cellInfo.row);
                    }
                }
            }


            foreach (var keyValuePair in temp)
            {
                if (keyValuePair.Value.Distinct().Count() == 1)
                {
                    var block = index;
                    var SignleValue = keyValuePair.Key;
                    var row = keyValuePair.Value.First();

                    foreach (var cellInfo in rowCells[row])
                    {
                        if (cellInfo.block != block)
                        {
                            cellInfo.blockList.Add(SignleValue);
                        }
                    }
                }
            }
        }


        private void blockSingleColomn(MethodDiction method, int index)
        {
            var cellsDic = GetCellsDic(method);
            var listcells = cellsDic[index].Where(c => c.Value == 0).ToList();
            var allRest = new List<int>();
            foreach (var cell in listcells)
            {
                allRest.AddRange(cell.GetRest());
            }

            var distinct = allRest.Distinct().ToList();

            Dictionary<int, List<int>> temp = new Dictionary<int, List<int>>();

            foreach (var value in distinct)
            {
                temp.Add(value, new List<int>());
            }

            foreach (var cellInfo in listcells)
            {
                foreach (var value in distinct)
                {
                    if (cellInfo.GetRest().Contains(value))
                    {
                        temp[value].Add(cellInfo.column);
                    }
                }
            }


            foreach (var keyValuePair in temp)
            {
                if (keyValuePair.Value.Distinct().Count() == 1)
                {
                    var block = index;
                    var SignleValue = keyValuePair.Key;
                    var column = keyValuePair.Value.First();

                    foreach (var cellInfo in columnCells[column])
                    {
                        if (cellInfo.block != block)
                        {
                            cellInfo.blockList.Add(SignleValue);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 三链数 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="index"></param>
        private void HiddenTriplet(MethodDiction method, int index)
        {
            var cellsDic = GetCellsDic(method);
            var listcells = cellsDic[index].Where(c => c.Value == 0).ToList();
            var celllist = listcells;
            var list = celllist.Where(c => c.GetRest().Count <= 3).ToList();
            List<int> listcount = new List<int>();
            if (celllist.Count != 3 && list.Count == 3)
            {
                foreach (var cell in list)
                {
                    listcount.AddRange(cell.GetRest());
                }

                var hiddenTripletList = listcount.Distinct().ToList();
                if (hiddenTripletList.Count == 3)
                {
                    var hiddenTripletstring = JsonConvert.SerializeObject(hiddenTripletList);
                    SolveMessage += "\r\n" + string.Join(",", list.Select(c => c.showPostion).ToList()) + "的取值只可能是" +
                                    hiddenTripletstring + ",\r\n所以第" + (index + 1) + GetDescription(method) +
                                    "的其余位置的备选项需要移除掉" + hiddenTripletstring + "等数据\r\n";
                    var keys = list.Select(c => c.ProgramPostion).ToList();
                    foreach (var VARIABLE in listcells)
                    {
                        if (!keys.Contains(VARIABLE.ProgramPostion))
                        {
                            VARIABLE.hiddenTripletList = hiddenTripletList;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获取枚举的描述
        /// </summary>
        /// <param name="en">枚举</param>
        /// <returns>返回枚举的描述</returns>
        public static string GetDescription(Enum en)
        {
            Type type = en.GetType(); //获取类型
            MemberInfo[] memberInfos = type.GetMember(en.ToString()); //获取成员
            if (memberInfos != null && memberInfos.Length > 0)
            {
                DescriptionAttribute[] attrs =
                    memberInfos[0]
                        .GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[]; //获取描述特性

                if (attrs != null && attrs.Length > 0)
                {
                    return attrs[0].Description; //返回当前描述
                }
            }

            return en.ToString();
        }


        private static Dictionary<int, List<CellInfo>> GetCellsDic(MethodDiction method)
        {
            Dictionary<int, List<CellInfo>> cellsDic = null;
            switch (method)
            {
                case MethodDiction.Row:
                    cellsDic = rowCells;
                    break;
                case MethodDiction.Column:
                    cellsDic = columnCells;
                    break;
                case MethodDiction.Block:
                    cellsDic = blockCells;
                    break;
            }


            return cellsDic;
        }


        private Dictionary<int, CellInfo> GetXwing(int Value, Dictionary<int, List<CellInfo>> Cells)
        {
            int count = 0;
            Dictionary<int, CellInfo> dic = new Dictionary<int, CellInfo>();
            int index = 0;
            foreach (var rowRests in Cells)
            {
                var cells = rowRests.Value;
                var innerCount = 0;
                List<CellInfo> tempCellInfos = new List<CellInfo>();
                foreach (var cellInfo in cells)
                {
                    if (cellInfo.GetRest().Contains(Value))
                    {
                        tempCellInfos.Add(cellInfo);
                        innerCount += 1;
                    }
                }

                if (innerCount == 2)
                {
                    dic.Add(index, tempCellInfos[0]);
                    count += 1;
                    index += 1;
                    dic.Add(index, tempCellInfos[1]);
                    index += 1;
                }
            }

            return dic;
        }


        /// <summary>
        /// 宫摒除
        /// </summary>
        /// <param name="round"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool GetSingleValue(int round, Dictionary<int, List<CellInfo>> celldic, int i, string methodName)
        {
            var c = celldic[i].Where(x => x.Value == 0);
            var result = "";
            var fillflag = false;
            List<int> temp = new List<int>();
            foreach (var cellInfo in c)
            {
                temp.AddRange(cellInfo.GetRest());
            }

            var r = temp.GroupBy(x => x).Where(j => j.Count() == 1);
            var key = r.Select(group => group.Key).ToList();
            foreach (var singleValue in key)
            {
                foreach (var cellInfo in c)
                {
                    if (cellInfo.GetRest().Contains(singleValue))
                    {
                        SolveMessage += "第" + round + "轮" + methodName + "：" + (cellInfo.row + 1) + "行" +
                                        (cellInfo.column + 1) +
                                        "列的值为" + singleValue +
                                        "\r\n";
                        cellInfo.SetValue(singleValue);
                        fillflag = true;
                        break;
                    }
                }
            }

            return fillflag;
        }

        public string SolveMessage = "";

        /// <summary>
        /// 是否正确
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return true;
        }


        /// <summary>
        /// 根据随机数范围获取一定数量的随机数
        /// </summary>
        /// <param name="minNum">随机数最小值</param>
        /// <param name="minNum">是否包含最小值</param>
        /// <param name="maxNum">随机数最大值</param>
        /// <param name="minNum">是否包含最大值</param>
        /// <param name="ResultCount">随机结果数量</param>
        /// <param name="rm">随机数对象</param>
        /// <param name="isSame">结果是否重复</param>
        /// <returns></returns>
        public static List<int> GetRandom(int minNum, bool isIncludeMinNum, int maxNum, bool isIncludeMaxNum,
            int ResultCount, Random rm, bool isSame)
        {
            List<int> randomList = new List<int>();
            int nValue = 0;

            #region 是否包含最大最小值，默认包含最小值，不包含最大值

            if (!isIncludeMinNum)
            {
                minNum = minNum + 1;
            }

            if (isIncludeMaxNum)
            {
                maxNum = maxNum + 1;
            }

            #endregion

            if (isSame)
            {
                for (int i = 0; randomList.Count < ResultCount; i++)
                {
                    nValue = rm.Next(minNum, maxNum);
                    randomList.Add(nValue);
                }
            }
            else
            {
                for (int i = 0; randomList.Count < ResultCount; i++)
                {
                    nValue = rm.Next(minNum, maxNum);
                    //重复判断
                    if (!randomList.Contains(nValue))
                    {
                        randomList.Add(nValue);
                    }
                }
            }

            return randomList;
        }
    }
}