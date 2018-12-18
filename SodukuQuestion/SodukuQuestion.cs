using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SodukuBase;

namespace SodukuFactory
{
    /// <summary>
    /// 数独出题类
    /// </summary>
    public class SodukuQuestion
    {
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
                var list7 = new List<int> {0, 9, 3, 2, 0, 0, 0, 6, 4};
                var list8 = new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0};
                var list9 = new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0};
                return new List<List<int>> {list1, list2, list3, list4, list5, list6, list7, list8, list9};
            }
        }

        public List<List<int>> AutoQuestion(List<List<int>> validInitList, int noticeValue)
        {
          
            var tempValue = 0;
            bool flag = true;
            var tempvalue = 28;
            List<int> list1=new List<int>();
            if (noticeValue >= tempvalue)
            {
                #region 多余28个提示数 直接采取随机数生成。

                return SubAutoQuestion(validInitList, noticeValue, list1);

                #endregion
            }
            else
            {
                #region 少于28个提示数，在合法的28个提示数中减少提示数，看是否依旧构成唯一解。

                return SubAutoQuestion(validInitList, tempvalue, list1);

                #endregion
            }
        }

        private static List<List<int>> SubAutoQuestion(List<List<int>> validInitList, int noticeValue,List<int> list1)
        {
            Random rm = new Random();
            List<List<int>> tempquestion;
            do
            {
                tempquestion =
                    JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(validInitList));
             
                do
                {
                    list1 = RandomHelper.GetRandom(0, true, 80, true, noticeValue, rm, false);
                } while (!ValidNoticeList(list1));

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!list1.Contains(i * 9 + j))
                        {
                            tempquestion[i][j] = 0;
                        }
                    }
                }
            } while (!new SodukuValid(tempquestion).IsVaildQuestion());

            return tempquestion;
        }


        public static bool ValidNoticeList(List<int> noticeValue)
        {
            List<bool> row = new List<bool> {false, false, false, false, false, false, false, false, false,};
            List<bool> column = new List<bool> {false, false, false, false, false, false, false, false, false,};
            foreach (var value in noticeValue)
            {
                row[value / 9] = true;
                column[value % 9] = true;
            }

            return (row[0] ? 1 : 0) + (row[1] ? 1 : 0) + (row[2] ? 1 : 0) >= 2
                   && (row[3] ? 1 : 0) + (row[4] ? 1 : 0) + (row[5] ? 1 : 0) >= 2
                   && (row[6] ? 1 : 0) + (row[7] ? 1 : 0) + (row[8] ? 1 : 0) >= 2
                   && (column[0] ? 1 : 0) + (column[1] ? 1 : 0) + (column[2] ? 1 : 0) >= 2
                   && (column[3] ? 1 : 0) + (column[4] ? 1 : 0) + (column[5] ? 1 : 0) >= 2
                   && (column[6] ? 1 : 0) + (column[7] ? 1 : 0) + (column[8] ? 1 : 0) >= 2
                ;
        }






  



    }
}