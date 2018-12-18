using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuFactory
{
    public class SodukuSets
    {
        public Dictionary<int,List<SodukuMarket>> marketList;

        public int minValue=100;

        /// <summary>
        /// 具有多解的初盘的一维数组的集合
        /// </summary>
        public List<List<int>> uselessList;

        /// <summary>
        /// 添加无效初盘
        /// </summary>
        /// <param name="useless"></param>
        public void AddUseless(List<int> useless)
        {
            var newList = new List<int>();
            foreach (var i in useless)
            {
                newList.Add(i);
            }
            this.uselessList.Add(newList);
        }

        /// <summary>
        /// 是否任意初盘包含该出牌的所有元素
        /// </summary>
        /// <param name="smallList"></param>
        /// <returns></returns>
        public bool InUseLessList(List<int> smallList)
        {
            var result = false;
            foreach (var onelist in uselessList.Where(c=>c.Count> smallList.Count))
            {
                result |= ALlContains(onelist, smallList);
                if (result)
                {
                    break;
                }
            }
          
            return result;
        }

        public bool ALlContains(List<int> big, List<int> small)
        {
            var result = true;
            foreach (var item in small)
            {
                if (!big.Contains(item))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public SodukuSets()
        {
            marketList=new Dictionary<int, List<SodukuMarket>>();

            uselessList=new List<List<int>>();
        }

        public void AddMarket(SodukuMarket market, int newNoticeCount)
        {
            if (marketList.ContainsKey(newNoticeCount))
            {
                marketList[newNoticeCount].Add(market);
            }
            else
            {
                marketList.Add(newNoticeCount,new List<SodukuMarket>{ market });
            }
     

            minValue = Math.Min(minValue,newNoticeCount);
        }

  


      
    }

    public class SodukuMarket
    {
        public List<List<int>> market;

        public SodukuMarket(List<List<int>> market)
        {
            this.market = market;
        }
    }
}