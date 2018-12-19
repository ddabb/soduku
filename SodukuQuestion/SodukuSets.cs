using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SodukuBase;

namespace SodukuFactory
{
    public class SodukuSets
    {
        public Dictionary<int,List<SodukuMarket>> marketList;

        public int minValue=100;

        /// <summary>
        /// 不能移除的元素的集合的集合
        /// </summary>
        public List<List<int>> CanNotRemoveItemsList;

        /// <summary>
        /// 添加无效初盘
        /// </summary>
        /// <param name="UnRemovebleItems"></param>
        public void AddUseless(List<int> UnRemovebleItems)
        {
            var items = new List<int>();
            foreach (var i in UnRemovebleItems)
            {
                items.Add(i);
            }
            this.CanNotRemoveItemsList.Add(items);
        }

        /// <summary>
        /// 是否存在待删除元素集合A包含任意不能删除的集合B中的所有元素
        /// </summary>
        /// <param name="moreDeleteItemList"></param>
        /// <returns></returns>
        public bool ContainsAnyUnRemovebleList(List<int> moreDeleteItemList)
        {
            if (CanNotRemoveItemsList.Count==0)
            {
                return false;
            }
            var result = false;
            foreach (var onelist in CanNotRemoveItemsList.Where(c=>c.Count< moreDeleteItemList.Count))
            {
                result |= ALlContains(moreDeleteItemList, onelist);
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

            CanNotRemoveItemsList=new List<List<int>>();
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
}