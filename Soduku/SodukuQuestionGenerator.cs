using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soduku
{
    /// <summary>
    /// 数独出题类
    /// </summary>
   public class SodukuQuestionGenerator
    {


        /// <summary>
        /// 出题
        /// </summary>
        /// <returns></returns>
        public List<List<int>> Question()
        {
            if (false)
            {
                //该难度 唯余法 宮摒除 行摒除 列摒除 xwing就足够了。
                var list1 = new List<int> { 0, 5, 0, 0, 0, 0, 0, 2, 0 };
                var list2 = new List<int> { 4, 0, 0, 2, 0, 6, 0, 0, 7 };
                var list3 = new List<int> { 0, 0, 8, 0, 3, 0, 1, 0, 0 };
                var list4 = new List<int> { 0, 1, 0, 0, 0, 0, 0, 6, 0 };
                var list5 = new List<int> { 0, 0, 9, 0, 0, 0, 5, 0, 0 };
                var list6 = new List<int> { 0, 7, 0, 0, 0, 0, 0, 9, 0 };
                var list7 = new List<int> { 0, 0, 5, 0, 8, 0, 3, 0, 0 };
                var list8 = new List<int> { 7, 0, 0, 9, 0, 1, 0, 0, 4 };
                var list9 = new List<int> { 0, 2, 0, 0, 0, 0, 0, 7, 0 };
                return new List<List<int>> { list1, list2, list3, list4, list5, list6, list7, list8, list9 };
            }
            else
            {
                var list1 = new List<int> { 0, 8, 0, 0, 0, 0, 6, 0, 0 };
                var list2 = new List<int> { 0, 0, 0, 4, 0, 0, 0, 0, 9 };
                var list3 = new List<int> { 0, 7, 0, 0, 0, 0, 8, 0, 5 };
                var list4 = new List<int> { 4, 0, 0, 0, 0, 0, 0, 0, 0 };
                var list5 = new List<int> { 0, 3, 0, 0, 6, 0, 0, 9, 0 };
                var list6 = new List<int> { 0, 0, 0, 7, 2, 0, 1, 0, 0 };
                var list7 = new List<int> { 0, 9, 3, 2, 0, 0, 5, 6, 4 };
                var list8 = new List<int> { 8, 1, 0, 3, 0, 0, 0, 0, 0 };
                var list9 = new List<int> { 0, 0, 0, 0, 0, 5, 0, 0, 0 };
                return new List<List<int>> { list1, list2, list3, list4, list5, list6, list7, list8, list9 };
            }
        }




   
    }
}
