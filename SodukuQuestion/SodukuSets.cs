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

        public SodukuSets()
        {
            marketList=new Dictionary<int, List<SodukuMarket>>();


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