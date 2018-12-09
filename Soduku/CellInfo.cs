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
        public int block;


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

        public string ProgramPostion;

        public string showPostion;
        public static int GetBlock(int x, int y)
        {
            return (x / 3) * 3 + (y / 3);
        }

        public CellInfo(int x, int y)
        {
            this.row = x;
            this.column = y;
            this.ProgramPostion = "postion_" + x + "_" + y;
            this.showPostion = "postion_" + (x + 1) + "_" + (y + 1);
            this.block = GetBlock(row, column);
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
            Soduku.blockDatas[this.block].Add(value);
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

            foreach (var gongExists in Soduku.blockDatas[block])
            {
                rests.Remove(gongExists);
            }
            return rests;
        }
    }
}