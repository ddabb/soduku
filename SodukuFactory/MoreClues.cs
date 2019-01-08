using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SodukuBase;

namespace SodukuFactory
{
    public class MoreClues
    {
        public string GenSoduku(string sodukuString)
        {
            var matrix = StaticTools.StringToList(sodukuString);
            if (!StaticTools.IsPearl(sodukuString))
            {
                throw new Exception("输入数独应是应该珍珠题");
            }

            var locations = StaticTools.GetLocations(matrix);
            var otherLocations = StaticTools.allLocations.Except(locations);
            Dictionary<string, int> sodukumap = new Dictionary<string, int>();
            foreach (var loc in locations)
            {
                var newstr = StaticTools.SetZero(sodukuString, loc);
                var answerCount = new DanceLink().solution_count(newstr);
                sodukumap.Add(newstr, answerCount);
            }

            var tempResult="";
            var index = 1;
            foreach (var newGene in sodukumap)
            {
                //Console.WriteLine("存在多解的提示数  \r\n" + newGene);
                Console.WriteLine("进展：  \r\n" +"处理了"+ index+"条，总数是  "+ sodukumap.Count);
                index += 1;
                tempResult = newClues(newGene.Key, otherLocations);
                if (!string.IsNullOrEmpty(tempResult))
                {
                    var cluesCount = tempResult.ToCharArray().Count(c => c != '0');
                    Console.WriteLine("提示数个数为" + cluesCount);
                    if (cluesCount < 39)
                    {
                        Console.WriteLine("新提示表达式\r\n" + tempResult);
                        GenSoduku(tempResult);
                    }

                }

            }


            Console.WriteLine("最终提示数表达式为\r\n" + tempResult);


            return tempResult;
        }

        private string newClues(string clues, IEnumerable<int> otherLocations)
        {
            var oneAnswer = new DanceLink().GetOneAnswer(clues);

            //Console.WriteLine("局部结果   " + oneAnswer);
            var locations = StaticTools.GetLocations(clues);

            var otherLocationList
                = otherLocations.ToList();
            //Console.WriteLine("剩余元素个数   " + otherLocations.Count());
            var exceptList = ExceptOtherPearlGene(otherLocationList, locations, oneAnswer);
            //Console.WriteLine("不能填数据的位置为   " +JsonConvert.SerializeObject(exceptList));
            var pure = otherLocations.Except(exceptList);

            var result = GetPureGene(oneAnswer, clues, pure);


            return result;
        }

        private string GetPureGene(string oneAnswer, string clues, IEnumerable<int> pure)
        {
            var choose = 2;

        
                var ints = PermutationAndCombination<int>.GetCombination(pure.ToArray(), choose);
                //Console.WriteLine("组合元素个数   " + pure.Count());
                //Console.WriteLine("choose   " + choose);
                //Console.WriteLine("组合个数   " + ints.Count);
                var locations = StaticTools.GetLocations(clues);

                int computedCount = 0;
                int index = 0;
                foreach (var t in ints)
                {
                    var newClues = StaticTools.SetZero(oneAnswer,
                        StaticTools.allLocations.Except(t.Union(locations)));
                    computedCount += 1;
                    if (computedCount==10000)
                    {
                        index += 1;
                        computedCount = 0;
                        Console.WriteLine("已处理   " + index+"万条数据" +DateTime.Now);
                    }

                    if (StaticTools.IsPearl(newClues))
                    {
                        var result = newClues;

                        return result;
                    }
                }
            return "";

        }

        private static List<int> ExceptOtherPearlGene(IEnumerable<int> otherLocations, List<int> locations,
            string oneAnswer)
        {
            var exceptList = new List<int>();
            foreach (var loc in otherLocations)
            {
                var newlocations = StaticTools.allLocations.Except(locations.Union(new List<int> {loc}));
                var newGens = StaticTools.SetZero(oneAnswer, newlocations);
                if (StaticTools.IsPearl(newGens))
                {
                    exceptList.Add(loc);
                }
            }

            return exceptList;
        }
    }
}