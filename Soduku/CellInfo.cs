using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    public class CellInfo
    {
        private int row;
        private int column;

        private List<int> rest;
        public bool isInit;
        public int Value;

        public CellInfo(int x, int y, int value) : this(x, y)
        {
            this.isInit = true;
            this.Value = value;
            this.rest.Clear();
        }

        public CellInfo(int x, int y)
        {
            this.row = x;
            this.column = y;
            this.rest = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        }
    }
}