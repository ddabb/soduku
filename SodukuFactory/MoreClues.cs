using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SudokuBase;

namespace SudokuFactory
{
    public class MoreClues
    {

        public string GetMoreNotice(string sodukuString,int noticeCount)
        {
    
            if (!StaticTools.IsPearl(sodukuString))
            {
                throw new Exception("输入数独应是应该珍珠题");
            }

            var result= sodukuString;
            var isbreak = false;
            do
            {
                var tempresult = EasySearch(result);
                if (!string.IsNullOrEmpty(tempresult))
                {
                    result = tempresult;
                }
                else
                {
                    isbreak = true;
                }
       ;
            } while (!isbreak && StaticTools.GetLocations(result).Count<noticeCount);

            if (isbreak)
            {
                Console.WriteLine("暴力搜索开始\r\n");
                do
                {
                    result = ForceSearch(result);
                } while (!string.IsNullOrEmpty(result) && StaticTools.GetLocations(result).Count < noticeCount);

                return result;
            }
            else
            {
                return result;
            }
        }

        /// <summary>
        /// 简单随机搜索
        /// </summary>
        /// <param name="sodukuString"></param>
        /// <returns></returns>
        private string EasySearch(string sodukuString)
        {
            var matrix = StaticTools.StringToList(sodukuString);
            var locations = StaticTools.GetLocations(matrix);
            var otherLocations = StaticTools.allLocations.Except(locations).ToList();
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
                //Console.WriteLine("进展：   " +"处理了"+ index+"条，总数是  "+ sodukumap.Count);
                index += 1;
                tempResult = newClues(newGene.Key, otherLocations);

            }


            Console.WriteLine("最终提示数表达式为\r\n" + tempResult);


            return tempResult;
        }

        /// <summary>
        /// 暴力搜索
        /// </summary>
        /// <param name="sodukuString"></param>
        /// <returns></returns>
        private string ForceSearch(string sodukuString)
        {
            var list = StaticTools.GetSubString(sodukuString);

            var index = 1;
            foreach (var subString in list)
            {
                Console.WriteLine("处理字符串   " + index + "  "+ subString);
                index += 1;
                var market=new SudokuMarket(subString);
                var result = market.GetCellInfos().Where(c=>c.Value.Value==0).
                    
                    Select(c1 => c1.Value).ToList();
                Dictionary<int, List<int>> locationRest = new Dictionary<int, List<int>>();
                foreach (var cell in result)
                {
                    locationRest.Add(cell.location,cell.initrest);
                }

                var locationcombine = PermutationAndCombination<int>.GetCombination(locationRest.Keys.ToArray(), 2);
                foreach (var combine in locationcombine)
                {
                    var location1 = combine[0];
                    var location2 = combine[1];
                    var rest1 = locationRest[location1];
                    var rest2= locationRest[location2];

                    foreach (var value1 in rest1)
                    {
                        Dictionary<int, string> one = new Dictionary<int, string> {{location1, "" + value1}};
                        if (new DanceLink().solution_count(StaticTools.SetValues(sodukuString, one))>0)
                        {
                            foreach (var value2 in rest2)
                            {
                                Dictionary<int, string> two = new Dictionary<int, string> { { location1, "" + value1 } , { location2, "" + value2 } };
                                var result1 = StaticTools.SetValues(sodukuString, two);
                                if (StaticTools.IsPearl(result1))
                                {

                                    string dir = AppDomain.CurrentDomain.BaseDirectory;
                                    var noticeCount = StaticTools.GetLocations(result1).Count;
                                    string configName = Path.Combine(dir, "提示数个数"+ noticeCount + "生成于"+DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt");
                                    File.WriteAllText(configName, result1);

                                    Console.WriteLine("当前表达式为:" + result1+"提示数个数为："+ noticeCount);
                                    return result1;
                                }

                            }

                        }

                    }
                }

            }

            return "";
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