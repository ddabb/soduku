﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static List<List<int>> gongDatas;


        private static Dictionary<string, CellInfo> cellInfos;


        /// <summary>
        /// 出题
        /// </summary>
        /// <returns></returns>
        public List<List<int>> Question()
        {
            //var list1 = new List<int> {0, 5, 0, 0, 0, 0, 0, 2, 0};
            var list1 = new List<int> { 1, 5, 7, 4, 9, 8, 6, 2, 0 };
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

        public CellInfo GetCellInfo(string location)
        {
            return cellInfos[location];
        }

        public bool IsQuestion=> cellInfos!=null&&cellInfos.Count != 0;
  

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
                gongDatas = FilledDatas();
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

                        column += 1;
                    }

                    row += 1;
                }
            }

            var weiyu = cellInfos.Values.Where(c => c.Value==0&& c.rests.Count == 1).ToList();
            foreach (var cell in weiyu)
            {
                cell.SetValue(cell.rests[0]);
            }
        }

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