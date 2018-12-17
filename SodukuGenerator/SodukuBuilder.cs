using System;
using System.Collections.Generic;
using SodukuBase;

namespace SodukuGenerator
{
    /// <summary>
    /// 数独生成类
    /// </summary>
   public class SodukuBuilder
    {
        /// <summary>
        /// 制作完整的数独
        /// </summary>
        /// <returns></returns>
        public List<List<int>> MakeSoduku()
        {
            Random rm = new Random();
            var list1 = RandomHelper.GetRandom(1, true, 9, true, 9, rm, false);
            var list2 = moveToTail(list1, 3);
            var list3 = moveToTail(list1, 6);
            var list4 = moveToTail(list1, 1);
            var list5 = moveToTail(list1, 4);
            var list6 = moveToTail(list1, 7);
            var list7 = moveToTail(list1, 2);
            var list8 = moveToTail(list1, 5);
            var list9 = moveToTail(list1, 8);
            return new List<List<int>> { list1, list2, list3, list4, list5, list6, list7, list8, list9 };
        }

        /// <summary>
        /// 交换两行
        /// </summary>
        /// <param name="lists"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <returns></returns>
        private List<List<int>> switchTwoRows(List<List<int>> lists, int row1, int row2)
        {
            return new List<List<int>>();
        }

        /// <summary>
        /// 交换两列
        /// </summary>
        /// <param name="lists"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <returns></returns>
        private List<List<int>> switchTwoColumn(List<List<int>> lists, int column1, int column2)
        {
            return new List<List<int>>();
        }

        /// <summary>
        /// 交换两列块
        /// </summary>
        /// <param name="lists"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <returns></returns>
        private List<List<int>> switchTwoColumnBlocks(List<List<int>> lists, int block1, int block2)
        {
            return new List<List<int>>();
        }


        /// <summary>
        /// 交换两行块
        /// </summary>
        /// <param name="lists"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <returns></returns>
        private List<List<int>> switchTwoRowsBlocks(List<List<int>> lists, int block1, int block2)
        {
            return new List<List<int>>();
        }

        /// <summary>
        /// 交换两个值
        /// </summary>
        /// <param name="lists"></param>
        /// <param name="row1"></param>
        /// <param name="row2"></param>
        /// <returns></returns>
        private List<List<int>> switchTwoValue(List<List<int>> lists, int value1, int value2)
        {
            return new List<List<int>>();
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
    }
}
