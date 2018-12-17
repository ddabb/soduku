using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SodukuTest
{
    class Program
    {
        //出题，采用静态数组

        static int[,] param  = new int[9, 9]

        {
            {0, 4, 2, 1, 9, 7, 5, 8, 0},

            {0, 8, 0, 4, 5, 2, 0, 9, 0},

            {5, 9, 0, 3, 8, 6, 0, 4, 2},

            {7, 1, 9, 2, 4, 5, 6, 3, 8},

            {2, 5, 3, 6, 1, 8, 9, 7, 4},

            {4, 6, 8, 7, 3, 9, 2, 5, 1},

            {1, 2, 5, 8, 7, 3, 4, 6, 9},

            {8, 7, 4, 9, 6, 1, 3, 2, 5},

            {9, 3, 6, 5, 2, 4, 8, 1, 7}
        };
        static int[,] pu  = (int[,])param.Clone();

        private static int[,] pu1 = new int[9, 9]
        {
            {0, 8, 0, 0, 0, 0, 6, 0, 0},
            {0, 0, 0, 4, 0, 0, 0, 0, 9},
            {0, 7, 0, 0, 0, 0, 8, 0, 5},
            {4, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 3, 0, 0, 6, 0, 0, 9, 0},
            {0, 0, 0, 7, 2, 0, 1, 0, 0},
            {0, 9, 3, 2, 0, 0, 0, 6, 4},
            {8, 1, 0, 3, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 5, 0, 0, 0}
        };


        static string _result = "";
        private static int _resultCount = 0;

        private static bool AllValue = false;

        static void Main(string[] args)

        {
            Console.WriteLine(JsonConvert.SerializeObject(param));
            GetAnswer(0);
            Console.WriteLine(_resultCount);
            Console.WriteLine(JsonConvert.SerializeObject(param));
          
            Console.ReadLine();
        }

        /// <summary>
        /// 验证函数
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        static bool IsValid(int i, int j)

        {
            int n = pu[i, j];

            int[] query = new int[9] {0, 0, 0, 3, 3, 3, 6, 6, 6};


            int t, u;

            //每一行每一列是否重复

            for (t = 0; t < 9; t++)

            {
                if ((t != i && pu[t, j] == n) || (t != j && pu[i, t] == n))

                    return false;
            }

            //每个九宫格是否重复

            for (t = query[i]; t < query[i] + 3; t++)

            {
                for (u = query[j]; u < query[j] + 3; u++)

                {
                    if ((t != i || u != j) && pu[t, u] == n)

                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 显示函数
        /// </summary>
        static void Show()

        {
            _result = "";
            for (var i = 0; i < 9; i++)

            {
                for (var j = 0; j < 9; j++)

                {
                    _result += pu[i, j];
                    Console.Write(pu[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------");
            _resultCount += 1;

            Console.WriteLine(_result);
        }


        /// <summary>
        /// 使用回溯算法求解
        /// </summary>
        /// <param name="n"></param>
        static void GetAnswer(int n)

        {
            if (n == 81)

            {
                //是否已经是最后一个格子

                Show();

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


            if (pu[i, j] != 0)

            {
                //如果当前格子不需要填数字，就跳到下一个格子

                GetAnswer(n + 1);

                return;
            }


            for (int k = 0; k < 9; k++)

            {
                var value = k + 1;


                pu[i, j] = value; //当前格子进行尝试所有解

                if (IsValid(i, j))

                    GetAnswer(n + 1); //验证通过，就继续下一个
            }


            pu[i, j] = 0; //如果上面的单元无解，还原，就回溯

            return;
        }
    }
}