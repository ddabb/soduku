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
            Random rm = new Random();
            List<List<int>> tempquestion;
     
            do
            {
                tempquestion =
                    JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(validInitList));
                List<int> list1;
                do
                {
                    list1 = RandomHelper.GetRandom(0, true, 80, true,noticeValue, rm, false);
         

                } while (!ValidNoticeList(list1));

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                 
                        if (!list1.Contains(i * 9 + j))
                        {
                            tempquestion[i ][ j] = 0;
                        }
           
                    }
            
                }



          
            
            } while (!isVaildQuestion(tempquestion));

            ;
            return tempquestion;
        }


        public static bool ValidNoticeList(List<int> noticeValue)
        {
            List<bool> row = new List<bool> {false, false, false, false, false, false, false, false, false,};
            List<bool> column = new List<bool> {false, false, false, false, false, false, false, false, false,};
            foreach (var value in noticeValue)
            {
                row[value / 9] =true;
                column[value % 9] =true;
            }
            return (row[0] ? 1 : 0) + (row[1] ? 1 : 0) + (row[2] ? 1 : 0) >= 2
                   && (row[3] ? 1 : 0) + (row[4] ? 1 : 0) + (row[5] ? 1 : 0) >= 2
                   && (row[6] ? 1 : 0) + (row[7] ? 1 : 0) + (row[8] ? 1 : 0) >= 2
                   && (column[0] ? 1 : 0) + (column[1] ? 1 : 0) + (column[2] ? 1 : 0) >= 2
                   && (column[3] ? 1 : 0) + (column[4] ? 1 : 0) + (column[5] ? 1 : 0) >= 2
                   && (column[6] ? 1 : 0) + (column[7] ? 1 : 0) + (column[8] ? 1 : 0) >= 2
                ;
        }


        public static bool isVaildQuestion(List<List<int>> param)
        {
            List<List<int>> pu = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(param));
            _resultCount = 0;
            GetAnswer(0, pu);
            return _resultCount == 1;
        }


        /// <summary>
        /// 验证函数
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        static bool IsValid(int i, int j, List<List<int>> pu)

        {
            int n = pu[i][j];

            int[] query = new int[9] {0, 0, 0, 3, 3, 3, 6, 6, 6};


            int t, u;

            //每一行每一列是否重复

            for (t = 0; t < 9; t++)

            {
                if (t != i && pu[t][j] == n || t != j && pu[i][t] == n)

                    return false;
            }

            //每个九宫格是否重复

            for (t = query[i]; t < query[i] + 3; t++)

            {
                for (u = query[j]; u < query[j] + 3; u++)

                {
                    if ((t != i || u != j) && pu[t][u] == n)

                        return false;
                }
            }

            return true;
        }

        static string _result = "";
        private static bool AllValue = false;

        private static int _resultCount = 0;

        /// <summary>
        /// 显示函数
        /// </summary>
        static void Show(List<List<int>> pu)

        {
            _result = "";
            for (var i = 0; i < 9; i++)

            {
                for (var j = 0; j < 9; j++)

                {
                    _result += pu[i][j];
                }
            }


            _resultCount += 1;
        }

        /// <summary>
        /// 使用回溯算法求解
        /// </summary>
        /// <param name="n"></param>
        static void GetAnswer(int n, List<List<int>> pu)

        {
            if (n == 81)

            {
                //是否已经是最后一个格子

                Show(pu);

                return;
            }

            if (!AllValue)
            {
                if (_resultCount > 1)
                {
                    return;
                }
            }

            int i = n / 9, j = n % 9;


            if (pu[i][j] != 0)

            {
                //如果当前格子不需要填数字，就跳到下一个格子

                GetAnswer(n + 1, pu);

                return;
            }


            for (int k = 0; k < 9; k++)

            {
                var value = k + 1;


                pu[i][j] = value; //当前格子进行尝试所有解

                if (IsValid(i, j, pu))

                    GetAnswer(n + 1, pu); //验证通过，就继续下一个
            }


            pu[i][j] = 0; //如果上面的单元无解，还原，就回溯

            return;
        }
    }
}