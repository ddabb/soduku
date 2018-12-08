using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    public class CellInfo
    {
        /// <summary>
        /// 行
        /// </summary>
        private int row;

        /// <summary>
        /// 列
        /// </summary>
        private int column;

        /// <summary>
        /// 剩余可选项
        /// </summary>
        private List<int> rests;

        /// <summary>
        /// 是否初始化数据
        /// </summary>
        public bool isInit;

        /// <summary>
        /// 单元格的值
        /// </summary>
        public int Value;

        /// <summary>
        /// 是否确认
        /// </summary>
        public bool isComfirm;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        /// <param name="isInit"></param>
        public CellInfo(int x, int y, int value, bool isInit = false) : this(x, y)
        {
            this.isInit = isInit;
            this.Value = value;
            this.rests.Clear();
        }


        public CellInfo(int x, int y)
        {
            this.row = x;
            this.column = y;
            this.rests = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }
    }
}