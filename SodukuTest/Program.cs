using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SodukuBase;
using SodukuGenerator;
using Console = System.Console;

namespace SodukuTest
{
    class Program
    {
        //出题，采用静态数组


        static List<List<int>> twoAnswerList = new List<List<int>>()

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


        static List<List<int>> Standard = new List<List<int>>()
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
            new List<int> {0, 9, 3, 2, 0, 0, 0, 6, 4},
            new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0}
        };


        static List<List<int>> soduku18 = new List<List<int>>()
        {
            new List<int> {0, 0, 1, 0, 0, 0, 0, 0, 9},
            new List<int> {0, 0, 0, 2, 0, 0, 0, 4, 6},
            new List<int> {0, 0, 7, 0, 8, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 1, 0, 0, 0},
            new List<int> {0, 0, 3, 0, 0, 0, 2, 0, 0},
            new List<int> {0, 0, 0, 5, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 3, 0, 8, 0, 0},
            new List<int> {9, 6, 0, 0, 0, 7, 0, 0, 0},
            new List<int> {2, 0, 0, 0, 0, 0, 5, 0, 0}
        };


        static void Main(string[] args)

        {
            string a = "helloword";


            string strsoduku18 = StaticTools.ListToString(soduku18);

            strsoduku18 = "001000009000200086007060000000001000003000200000500000000040700820009000500000300";

            //string strsoduku18 = "001000009000200067008060000000001000003000200000500000000090700280004000500000300";


            Console.WriteLine(strsoduku18);
            var list = StaticTools.GetLocations(soduku18);

            Console.WriteLine(JsonConvert.SerializeObject(list));


            var switchList = PermutationAndCombination<int>.GetCombination(list.ToArray(), 2);
            //switchList.Reverse();
            Console.WriteLine("list" + list.Count);
            Console.WriteLine("switchList" + switchList.Count);
            Dictionary<string, int> expressCount = new Dictionary<string, int>();
            string beginstr = strsoduku18;
            List<string> tryedList = new List<string> {strsoduku18};
            var min = GetMinCount(strsoduku18, expressCount, switchList);

            var maxMin = 0;
            while (min != 1)
            {
                var result = (from item1 in expressCount
                    where
                        !(tryedList.Any(item2 => item2 == item1.Key))
                    select item1).Where(c => c.Value != 0).ToList();
                var newSeed = result.OrderBy(c => c.Value).Last();
                var newMin = result.OrderBy(c => c.Value).First();


                if (true)
                {
                    Console.WriteLine(newSeed.Key + "   最多的解  " + newSeed.Value + "最少的解 " + newMin.Value);
                }

                min = GetMinCount(newSeed.Key, expressCount, switchList);
                tryedList.Add(newSeed.Key);
            }


            Console.WriteLine("result" + expressCount.Where(c => c.Value == 1).Select(c => c.Key).First());


            Console.ReadKey();
            return;
        }

        private static int GetMinCount(string strsoduku18, Dictionary<string, int> expressCount, List<int[]> switchList)
        {
            int min = 0;

            if (!expressCount.ContainsKey(strsoduku18))
            {
                min = new DanceLink().solution_count(strsoduku18);
                expressCount.Add(strsoduku18, min);
            }
            else
            {
                min = expressCount[strsoduku18];
            }

            int start = 0;
            int end = 0;

            do
            {
                start = min;


                foreach (var switchListCouple in switchList)
                {
                    var newStr = ReplaceString(strsoduku18, switchListCouple[0], switchListCouple[1]);

                    if (!expressCount.ContainsKey(newStr))
                    {
                        var count = new DanceLink().solution_count(newStr);

                        //Console.WriteLine("newStr  " + newStr + "  " + count);
                        expressCount.Add(newStr, count);
                        if (count != 0 && count < min)
                        {
                            strsoduku18 = newStr;
                            min = count;
                            break;
                        }
                    }
                }

                end = min;
            } while (start != end);

            return min;
        }

        public static string ReplaceString(string str, int a, int b)
        {
            char[] newStr = str.ToCharArray();
            var c1 = newStr[a];
            var c2 = newStr[b];
            newStr[a] = c2;
            newStr[b] = c1;
            return new string(newStr);
        }
    }
}