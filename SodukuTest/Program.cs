using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using Newtonsoft.Json;
using SodukuBase;
using SodukuGenerator;
using SodukuFactory;
using SodukuSolver;

namespace SodukuTest
{
    class Program
    {
        //出题，采用静态数组

       
        static List<List<int>> param = new List<List<int>>()

        {
            new List<int> {0, 4, 2, 1, 9, 7, 5, 8, 0},
            new List<int> {0, 8, 0, 4, 5, 2, 0, 9, 0},
            new List<int> {5, 9, 0, 3, 8, 6, 0, 4, 2},
            new List<int> {7, 1, 9, 2, 4, 5, 6, 3, 8},
            new List<int> {2, 5, 3, 6, 1, 8, 9, 7, 4},
            new List<int> {4, 6, 8, 7, 3, 9, 2, 5, 1},
            new List<int> {1, 2, 5, 8, 7, 3, 4, 6, 9},
            new List<int> {8, 7, 4, 9, 6, 1, 3, 2, 5},
            new List<int> {9, 3, 6, 5, 2, 4, 8, 1, 7}
        };


        static List<List<int>> pu1 = new List<List<int>>()
        {
            new List<int> {0, 8, 0, 0, 0, 0, 6, 0, 0},
            new List<int> {0, 0, 0, 4, 0, 0, 0, 0, 9},
            new List<int> {0, 7, 0, 0, 0, 0, 8, 0, 5},
            new List<int> {4, 0, 0, 0, 0, 0, 0, 0, 0},
            new List<int> {0, 3, 0, 0, 6, 0, 0, 9, 0},
            new List<int> {0, 0, 0, 7, 2, 0, 1, 0, 0},
            new List<int> {0, 9, 3, 2, 0, 0, 0, 6, 4},
            new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0}
        };


        static List<List<int>> pu2 = new List<List<int>>()
        {
            new List<int> {0, 8, 0, 0, 0, 0, 6, 0, 0},
            new List<int> {0, 0, 0, 4, 0, 0, 0, 0, 9},
            new List<int> {0, 7, 0, 0, 0, 0, 8, 0, 5},
            new List<int> {4, 0, 0, 0, 0, 0, 0, 0, 0},
            new List<int> {0, 3, 0, 0, 6, 0, 0, 9, 0},
            new List<int> {0, 0, 0, 7, 2, 0, 1, 0, 0},
            new List<int> {0, 9, 3, 2, 0, 0, 7, 6, 4},
            new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0}
        };


        static void Main(string[] args)

        {


         
            List<int> locations = new List<int> {0, 10, 20, 30, 40, 50, 60, 70, 80, 8, 16, 24, 32, 48, 56, 64, 72
                //,4,12,14,28,36,46,34,44,52,66,68,76

            };
            Dictionary<string, List<int>> dic=new Dictionary<string, List<int>>();
            dic.Add("快", new List<int> { 10, 14, 19, 21, 22, 23, 24, 25, 28, 32, 34, 36, 37, 38, 39, 40, 41, 42, 43, 44, 46, 50, 51, 55, 64, 65, 57, 60, 70  });
            dic.Add("旦", new List<int> { 72,80,11, 12, 13, 14, 15, 20, 24, 29, 33, 38, 39, 40, 41, 42, 47, 51, 56, 60, 73, 74, 75, 76, 77, 78, 79 });
            dic.Add("元",new List<int>{ 27,35,11, 12, 13, 14, 15, 24, 28, 29, 30, 31, 32, 33, 34, 39, 41,48, 50, 57, 59, 64, 65, 61, 68, 69, 70 });


            dic.Add("乐", new List<int> { 6, 14, 20, 21, 22, 29, 31, 38, 39, 40, 41, 42, 43, 49, 56, 64, 58, 67, 76, 66, 60, 70 });

            foreach (var kv in dic)
            {
                Console.WriteLine("现在生成"+kv.Key+"开始");
                List<List<int>> tempquestion;
                int count = 0;
                int outputCount = 0;
                do
                {
                    var validSoduku = new SodukuBuilder().MakeSoduku();
                    tempquestion =
                        JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(validSoduku));
                    count += 1;
                    if (count==10000)
                    {
                        outputCount += 1;
                        Console.WriteLine("计算次数(万)"+ outputCount);
                        count = 0;
                    }

                    SodukuQuestion.InitQuestion(kv.Value, tempquestion);

                } while (new DanceLink().do_solve(listtostring(tempquestion)).Length<81);

    

                foreach (var list in tempquestion)
                {
                    foreach (var value in list)
                    {
                     
                        Console.Write(" " + value);
                    }
                    Console.WriteLine();
                }
           
                Console.WriteLine("现在生成" + kv.Key + "结束");

            }






            Console.ReadLine();
        }

        public static string listtostring(List<List<int>> tempquestion)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var list in tempquestion)
            {
                foreach (var value in list)
                {
                    sb.Append(value);

                }

            }

            return sb.ToString();
        }

    }
}