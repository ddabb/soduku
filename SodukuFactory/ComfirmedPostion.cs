using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SodukuBase;

namespace SodukuFactory
{
   public class ComfirmedPostion
    {
        /// <summary>
        /// 将数独指定位置的数进行交换构成标准数独。
        /// </summary>
        /// <param name="sodukuString"></param>
        public  string GenConfirmedPosition(string sodukuString)
        {
          
       
            var matrix = StaticTools.StringToList(sodukuString);
            Console.WriteLine(sodukuString);
            var list = StaticTools.GetLocations(matrix);

            Console.WriteLine(JsonConvert.SerializeObject(list));


            var switchList = PermutationAndCombination<int>.GetCombination(list.ToArray(), 2);
            //switchList.Reverse();
            Console.WriteLine("list" + list.Count);
            Console.WriteLine("switchList" + switchList.Count);
            Dictionary<string, int> expressCount = new Dictionary<string, int>();
            string beginstr = sodukuString;
            List<string> tryedList = new List<string> { sodukuString };
            var min = GetMinCount(sodukuString, expressCount, switchList);

            while (min != 1)
            {
                var result = (from item1 in expressCount
                              where
                                  !(tryedList.Any(item2 => item2 == item1.Key))
                              select item1).Where(c => c.Value != 0).ToList();
                if (result.Count==0)
                {
                    //所有该尝试的组合都已经尝试过了
                    //表明已知提示数在固定位置的确无法构成唯一解。
                    return null;
                }
                var newSeed = result.OrderBy(c => c.Value).Last();
                var newMin = result.OrderBy(c => c.Value).First();


                if (true)
                {
                    Console.WriteLine("最少的终盘个数: "+newMin.Value);
                }

                min = GetMinCount(newSeed.Key, expressCount, switchList);
                tryedList.Add(newSeed.Key);
            }

            return expressCount.Where(c => c.Value == 1).Select(c => c.Key).First();
        }


        private  int GetMinCount(string strsoduku18, Dictionary<string, int> expressCount, List<int[]> switchList)
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
                    var newStr = StaticTools.ReplaceString(strsoduku18, switchListCouple[0], switchListCouple[1]);

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

    }
}
