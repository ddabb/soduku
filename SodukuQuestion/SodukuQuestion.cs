using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
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

        /// <summary>
        /// 生成初盘提示数个数为noticeValue的具有唯一解的初盘
        /// </summary>
        /// <param name="wholeSoduku">完整数独</param>
        /// <param name="noticeCounts">提示数个数</param>
        /// <returns></returns>
        public SodukuMarket AutoQuestion(List<List<int>> wholeSoduku, int noticeCounts)
        {
            var tempValue = 0;
            bool flag = true;
            var RandomValue = 30;
            if (noticeCounts >= 81)
            {
                noticeCounts = 80;
            }

            if (noticeCounts < 17)
            {
                noticeCounts = 17;
            }

            List<int> locations = new List<int>();
            List<List<int>> result;
            if (noticeCounts >= RandomValue)
            {
                #region 多余30个提示数 直接采取随机数生成。
                return SubAutoQuestion(wholeSoduku, noticeCounts, ref locations);
                #endregion
            }
            else
            {
       
                bool flag1 = true;
                int trytimes = 0;
                SodukuMarket market = null;
                List < SodukuMarket > markets=new List<SodukuMarket>();
                while (flag1)
                {
               
                    market = SubAutoQuestion(wholeSoduku, RandomValue, ref locations);
                    markets.Add(market);
                    result = market.initValues;
                    var needlist = GetAllNeedList(result, locations);
                    if (needlist.Count > noticeCounts)
                    {
                        
                    }
                    else if(needlist.Count == noticeCounts)
                    {
                        var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(result));
                        StaticTools.InitQuestion(needlist, valueCopy);
                        if (StaticTools.IsVaildSoduku(valueCopy))
                        {
                            return new SodukuMarket(valueCopy);
                        }
                    }
                    else
                    {
                        var chooseValue = noticeCounts - needlist.Count;
                        var values = locations.Except(needlist).ToArray();
                        List<int[]> listCombination = PermutationAndCombination<int>.GetCombination(values, chooseValue);
                        int index = 0;
                        foreach (var items in listCombination)
                        {
                            var c = items.ToList();
                            var location1 = needlist.Union(c).ToList();
                            var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(result));
                            StaticTools.InitQuestion(location1, valueCopy);
                            if (StaticTools.ValidNoticeList(location1))
                            {
                                if (StaticTools.IsVaildSoduku(valueCopy))
                                {

                                    return new SodukuMarket(valueCopy);
                                }
                            
                            }

                            index += 1;
                        }


                    }
                    trytimes += 1;
                    if (trytimes==3)
                    {
                        flag1 = false;
                    }
                }

                return markets.OrderBy(c=>c.difficult).Last();

            }

         

        }



        private List<int> GetAllNeedList(List<List<int>> tempSoduku, List<int> locations)
        {

            List<int> needList=new List<int>();
            foreach (var location in locations)
            {
                var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(tempSoduku));

                valueCopy[location / 9][location % 9] = 0;


                var validthis = StaticTools.ValidNoticeList(locations.Except(new List<int> { location }).ToList());
                if (!validthis|| !StaticTools.IsVaildSoduku(valueCopy))
                {
                    needList.Add(location);
                }


            }


            return needList;
        }

 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="wholeSoduku">完整数独</param>
        /// <param name="noticeValue">提示数个数</param>
        /// <param name="list1">提示数位置</param>
        /// <returns></returns>
        public  SodukuMarket SubAutoQuestion(List<List<int>> wholeSoduku, int noticeValue,ref List<int> list1)
        {
            Random rm = new Random();
            List<List<int>> tempquestion;
            do
            {
                tempquestion =
                    JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(wholeSoduku));

                do
                {
                    list1 = RandomHelper.GetRandom(0, true, 80, true, noticeValue, rm, false);
                } while (!StaticTools.ValidNoticeList(list1));

                StaticTools.InitQuestion(list1, tempquestion);
            } while (!StaticTools.IsVaildSoduku(tempquestion));

            return new SodukuMarket(tempquestion, list1);
        }
    }
}