using System.Collections.Generic;

namespace SodukuBase
{
    public class SodukuMarket
    {
        public List<List<int>> market;
        /// <summary>
        /// 空余链表位置
        /// </summary>
        public List<int> emptyLists;
        /// <summary>
        /// 初始化链表位置
        /// </summary>
        public List<int> initLists;
        /// <summary>
        /// 数独难度
        /// </summary>
        public double difficult;

        public SodukuMarket(List<List<int>> market)
        {
            this.market = market;
        }
    }
}