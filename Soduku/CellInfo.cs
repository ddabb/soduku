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
        public int row;

        /// <summary>
        /// 列
        /// </summary>
        public int column;


        /// <summary>
        /// 宫格
        /// </summary>
        public int gong;


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
            rests = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            rests = GetRest();
        }

        /// <summary>
        /// hangRest 0~8表示行
        /// </summary>
        /// <param name="value"></param>
        public void InitValue(int value)
        {
            SetValue(value);
            if (value!=0)
            {
                isInit = true;
            }
          
        }

        /// <summary>
        /// hangRest 0~8表示行
        /// </summary>
        /// <param name="value"></param>
        public void SetValue(int value)
        {
            this.Value = value;

            Soduku.rowDatas[this.row].Add(value);
            Soduku.columnDatas[this.column].Add(value);
            Soduku.gongDatas[this.gong].Add(value);
            this.rests = GetRest();
        }

        public List<int> GetRest()
        {
            foreach (var rowExists in Soduku.rowDatas[row])
            {
                rests.Remove(rowExists);
            }

            foreach (var columnExists in Soduku.columnDatas[column])
            {
                rests.Remove(columnExists);
            }

            foreach (var gongExists in Soduku.gongDatas[gong])
            {
                rests.Remove(gongExists);
            }

            this.rests = rests;
            return rests;
        }
    }
}