using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    /// <summary>
    /// 数独类
    /// </summary>
    public  class Soduku
    {

        /// <summary>
        /// 制作完整的数独
        /// </summary>
        /// <returns></returns>
        public int[][] MakeSoduku()
        {
            return new int[9][];
        }

        /// <summary>
        /// 出题
        /// </summary>
        /// <returns></returns>
        public int[][] Question()
        {
            return new int[9][];
        }
        /// <summary>
        /// 解题
        /// </summary>
        /// <returns></returns>
        public int[][] Solve()
        {
            return new int[9][];
        }

        /// <summary>
        /// 是否正确
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
        {
            return true;
        }
    }
}
