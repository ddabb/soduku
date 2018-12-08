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
        /// 宫格
        /// </summary>
        private int gong;


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

        public static int GetGong(int x, int y)
        {
            return (x / 3) * 3 + (y / 3);
        }

        public CellInfo(int x, int y)
        {
            this.row = x;
            this.column = y;
            this.gong = GetGong(row, column);
        }

        /// <summary>
        /// hangRest 0~8表示行
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(int value)
        {
            this.Value = value;
            Soduku.columnDatas[this.column].Add(value);
            Soduku.rowDatas[this.row].Add(value);
            Soduku.gongDatas[this.gong].Add(value);
        }

        public List<int> GetRest()
        {
            List<int> all=new List<int>{1,2,3,4,5,6,7,8,9};
        
            foreach (var rowExists in Soduku.rowDatas[row])
            {
                all.Remove(rowExists);
            }
            foreach (var columnExists in Soduku.columnDatas[column])
            {
                all.Remove(columnExists);
            }
            foreach (var gongExists in Soduku.gongDatas[gong])
            {
                all.Remove(gongExists);
            }

            return all;
        }
    }
}