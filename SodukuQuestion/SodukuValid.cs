using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodukuFactory
{
    /// <summary>
    /// 数独校验类
    /// </summary>
    public class SodukuValid
    {
        private List<List<int>> resultList;

        public SodukuValid(List<List<int>> param)
        {
            this.resultList = JsonConvert.DeserializeObject<List<List<int>>>(JsonConvert.SerializeObject(param)); ;
        }

        public bool IsVaildQuestion()
        {
           
            _resultCount = 0;
            GetAnswer(0);
            return _resultCount == 1;
        }

        private int _resultCount;
        private bool AllValue = false;
        private string _result = "";

        /// <summary>
        /// 显示函数
        /// </summary>
        private void GetResult()

        {
            _result = "";
            for (var i = 0; i < 9; i++)

            {
                for (var j = 0; j < 9; j++)

                {
                    _result += resultList[i][j];
                }
            }


            _resultCount += 1;
        }

        /// <summary>
        /// 使用回溯算法求解
        /// </summary>
        /// <param name="n"></param>
        private void GetAnswer(int n)

        {
            if (n == 81)

            {
                //是否已经是最后一个格子

                GetResult();

                return;
            }

            if (!AllValue)
            {
                if (_resultCount > 1)
                {
                    return;
                }
            }

            int i = n / 9, j = n % 9;


            if (resultList[i][j] != 0)

            {
                //如果当前格子不需要填数字，就跳到下一个格子

                GetAnswer(n + 1);

                return;
            }


            for (int k = 0; k < 9; k++)

            {
                var value = k + 1;


                resultList[i][j] = value; //当前格子进行尝试所有解

                if (IsValid(i, j))

                    GetAnswer(n + 1); //验证通过，就继续下一个
            }


            resultList[i][j] = 0; //如果上面的单元无解，还原，就回溯

            return;
        }


        /// <summary>
        /// 验证函数
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool IsValid(int i, int j)

        {
            int n = resultList[i][j];

            int[] query = new int[9] {0, 0, 0, 3, 3, 3, 6, 6, 6};


            int t, u;

            //每一行每一列是否重复

            for (t = 0; t < 9; t++)

            {
                if (t != i && resultList[t][j] == n || t != j && resultList[i][t] == n)

                    return false;
            }

            //每个九宫格是否重复

            for (t = query[i]; t < query[i] + 3; t++)

            {
                for (u = query[j]; u < query[j] + 3; u++)

                {
                    if ((t != i || u != j) && resultList[t][u] == n)

                        return false;
                }
            }

            return true;
        }
    }
}