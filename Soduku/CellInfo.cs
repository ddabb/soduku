using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        /// xwing排除项
        /// </summary>
        public List<int> xwing;


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
        /// <summary>
        /// 3链数
        /// </summary>
        public List<int> hiddenTripletList;


        /// <summary>
        /// 3链数
        /// </summary>
        public List<int> UrList;

        /// <summary>
        /// 冲突练
        /// </summary>
        public List<int> Conflict;


        /// <summary>
        /// 其余宮的单行值或者单列值
        /// </summary>
        public List<int> blockList;

        /// <summary>
        /// 单元格的剩余可选项组成的串
        /// </summary>
        public string RestInfo => JsonConvert.SerializeObject(GetRest());

        /// <summary>
        /// 是否只有两个可选项
        /// </summary>
        public bool isTwoValue => GetRest().Count == 2;

        public static int GetBlock(int x, int y)
        {
            return (x / 3) * 3 + (y / 3);
        }

        public bool Equals(CellInfo x)
        {
            return this.ProgramPostion == x.ProgramPostion;
        }

        public CellInfo(int x, int y)
        {
            this.row = x;
            this.column = y;
            this.ProgramPostion = "postion_" + x + "_" + y;
            this.showPostion =  (x + 1) + "行" + (y + 1)+ "列" ;
            this.block = GetBlock(row, column);
            this.hiddenTripletList=new List<int>();
            this.xwing=new List<int>();
            this.blockList = new List<int>();
            this.UrList=new List<int>();
            this.Conflict=new List<int>();
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
            if (value != 0)
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
            if (value != 0)
            {
                rests.Clear();
            }
            else
            {
                this.rests = GetRest();
            }
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

            foreach (var xwingexists in xwing)
            {
                rests.Remove(xwingexists);
            }
            foreach (var xwingexists in hiddenTripletList)
            {
                rests.Remove(xwingexists);
            }
            foreach (var xwingexists in blockList)
            {
                rests.Remove(xwingexists);
            }

            foreach (var xwingexists in UrList)
            {
                rests.Remove(xwingexists);
            }

            foreach (var xwingexists in Conflict)
            {
                rests.Remove(xwingexists);
            }
            rests.Sort();
            return rests;
        }
    }
}