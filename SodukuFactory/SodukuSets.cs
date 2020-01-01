using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SudokuBase;

namespace SudokuFactory
{
    public class SudokuSets
    {
        public Dictionary<int,List<SudokuMarket>> marketList;

        public int minValue=100;

        /// <summary>
        /// 不能移除的元素的集合的集合
        /// </summary>
        public List<List<int>> CanNotRemoveItemsList;

        /// <summary>
        /// 添加无效初盘
        /// </summary>
        /// <param name="unRemovebleItems"></param>
        public void AddUnRemoveableList(List<int> unRemovebleItems)
        {
            var items = new List<int>();
            foreach (var i in unRemovebleItems)
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

        private bool ALlContains(List<int> big, List<int> small)
        {
            return !small.Except(big).Any();
        }

        public SudokuSets()
        {
            marketList=new Dictionary<int, List<SudokuMarket>>();

            CanNotRemoveItemsList=new List<List<int>>();
        }

        public void AddMarket(SudokuMarket market, int newNoticeCount)
        {
            if (marketList.ContainsKey(newNoticeCount))
            {
                marketList[newNoticeCount].Add(market);
            }
            else
            {
                marketList.Add(newNoticeCount,new List<SudokuMarket>{ market });
            }
     

            minValue = Math.Min(minValue,newNoticeCount);
        }

  


      
    }
}