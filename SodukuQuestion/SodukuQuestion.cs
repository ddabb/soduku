using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
                        InitQuestion(needlist, valueCopy);
                        if (new SodukuValid(valueCopy).IsVaildQuestion())
                        {
                            return new SodukuMarket(valueCopy);
                        }
                    }
                    else
                    {
                        var chooseValue = noticeCounts - needlist.Count;
                        var values = locations.Except(needlist).ToArray();
                        List<int[]> ListCombination = PermutationAndCombination<int>.GetCombination(values, chooseValue);
                        int index = 0;
                        foreach (var items in ListCombination)
                        {
                            var c = items.ToList();
                            var location1 = needlist.Union(c).ToList();
                            var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(result));
                            InitQuestion(location1, valueCopy);
                            if (ValidNoticeList(location1))
                            {
                                if (new SodukuValid(valueCopy).IsVaildQuestion())
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


        /// <summary>
        /// 广度搜索
        /// </summary>
        /// <param name="tempSoduku"></param>
        /// <param name="locations"></param>
        /// <param name="sets"></param>
        private void BFS(List<List<int>> tempSoduku, List<int> locations, ref SodukuSets sets)
        {

            foreach (var location in locations)
            {
                var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(tempSoduku));

                valueCopy[location / 9][location % 9] = 0;


                var validthis = ValidNoticeList(locations.Except(new List<int> { location }).ToList());
                if (!validthis)
                {
                    sets.AddUnRemoveableList(new List<int> { location });
                }

                if (!new SodukuValid(valueCopy).IsVaildQuestion())
                {
                    var c = new List<int> { location };
                    sets.AddUnRemoveableList(c);
                }


            }
        }

        /// <summary>
        /// 深度搜索
        /// </summary>
        /// <param name="tempSoduku"></param>
        /// <param name="inits"></param>
        /// <param name="locations"></param>
        /// <param name="noticeCount"></param>
        /// <param name="sets"></param>
        private void DFS(List<List<int>> tempSoduku, List<int> inits, List<int> locations, int noticeCount, ref SodukuSets sets)
        {
            if (sets.marketList.ContainsKey(noticeCount))
            {
                return;
            }



            foreach (var location in locations)
            {
                if (sets.minValue <= noticeCount)
                {
                    break;
                }

                if (locations.Count < noticeCount)
                {
                    break;
                }
                var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(tempSoduku));

                valueCopy[location / 9][location % 9] = 0;
                var leftValues = locations.Except(new List<int> { location }).ToList();


                var deleteList = inits.Except(leftValues).ToList();
                var vaildlist = ValidNoticeList(leftValues);
                if (!vaildlist)
                {
                    var b = 0;
                }
                if (vaildlist && (!sets.ContainsAnyUnRemovebleList(deleteList)) && new SodukuValid(valueCopy).IsVaildQuestion())
                {

                    SodukuMarket market = new SodukuMarket(valueCopy, leftValues);

                    sets.AddMarket(market, locations.Count - 1);
                    DFS(valueCopy, inits, locations.Except(new List<int> { location }).ToList(), noticeCount, ref sets);


                }
                else
                {
                    sets.AddUnRemoveableList(deleteList);
                }

            }
        }

        private List<int> GetAllNeedList(List<List<int>> tempSoduku, List<int> locations)
        {

            List<int> needList=new List<int>();
            foreach (var location in locations)
            {
                var valueCopy = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(tempSoduku));

                valueCopy[location / 9][location % 9] = 0;


                var validthis = ValidNoticeList(locations.Except(new List<int> { location }).ToList());
                if (!validthis)
                {
                    needList.Add(location);
                }

                if (!new SodukuValid(valueCopy).IsVaildQuestion())
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
                } while (!ValidNoticeList(list1));

                InitQuestion(list1, tempquestion);
            } while (!new SodukuValid(tempquestion).IsVaildQuestion());

            return new SodukuMarket(tempquestion, list1);
        }

        public static void InitQuestion(List<int> list1, List<List<int>> tempquestion)
        {
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