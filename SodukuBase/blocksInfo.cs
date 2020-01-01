using System;
using System.Collections.Generic;
using System.Linq;

namespace SudokuBase
{
    public class BlocksInfo
    {
        public static List<string> blocklists = new List<string>
        {
            "0,1,2",
            "3,4,5",
            "6,7,8",
            "0,3,6",
            "1,4,7",
            "2,5,8"
        };

        public static int GetLeftBlock(int block1, int block2)
        {
            var block1str1 = block1 + "";
            var block1str2 = block2 + "";
            var result = blocklists.First(c => c.Contains(block1str1) && c.Contains(block1str2)).Split(',')
                .ToList();
            return Convert.ToInt32(result.First(c => c != block1str1 && c != block1str2));
        }
    }
}