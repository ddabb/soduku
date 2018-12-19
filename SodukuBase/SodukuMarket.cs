using System.Collections.Generic;
using System.Linq;

namespace SodukuBase
{
    public class SodukuMarket
    {
        public List<List<int>> market;

        private double _difficult;

        private List<int> _emptyLists;
        /// <summary>
        /// 空余链表位置
        /// </summary>
        public List<int> emptyLists => _emptyLists ?? (_emptyLists = StaticInfos.allLocations.Except(this.initLists).ToList());

        /// <summary>
        /// 初始化链表位置
        /// </summary>
        public List<int> initLists;

        /// <summary>
        /// 数独难度
        /// </summary>
        public double difficult
        {
            get
            {
                if (_difficult==0)
                {
                    _difficult = GetDifficult();
                }

                return _difficult;
            }
        }

        /// <summary>
        /// 获取数独的相关难度
        /// </summary>
        /// <returns></returns>
        private double GetDifficult()
        {
            double allcount = 0;
            var ListCount = emptyLists.Count;
            foreach (var emptyLocation1 in emptyLists)
            {
                foreach (var emptyLocation2 in emptyLists)
                {
                    allcount += GetRelated(emptyLocation1, emptyLocation2);
                }
            }

            return allcount / (ListCount * 18);
        }

        /// <summary>
        /// 获取两个元素的相关性
        /// </summary>
        /// <param name="location1"></param>
        /// <param name="location2"></param>
        /// <returns></returns>
        private int GetRelated(int location1,int location2)
        {
      
            var x1 = location1 / 9;
            var y1= location1 % 9;

            var x2 = location2 / 9;
            var y2 = location2 % 9;
            return x1 == x2 || y1 == y2 || CellInfo.GetBlock(x1, y1) == CellInfo.GetBlock(x2, y2) ? 1 : 0;
          
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="market">数独初盘</param>
        /// <param name="initLists">剩余的有数据的位置</param>
        public SodukuMarket(List<List<int>> market,List<int> initLists)
        {
            this.market = market;
            this.initLists = initLists;
        }
    }
}