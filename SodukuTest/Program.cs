using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SodukuBase;
using SodukuFactory;
using SodukuGenerator;
using Console = System.Console;

namespace SodukuTest
{
    class Program
    {
        //出题，采用静态数组


        static List<List<int>> twoAnswerList = new List<List<int>>()

        {
            new List<int> {0, 4, 2, 1, 9, 7, 5, 8, 0},
            new List<int> {0, 8, 0, 4, 5, 2, 0, 9, 0},
            new List<int> {5, 9, 0, 3, 8, 6, 0, 4, 2},
            new List<int> {7, 1, 9, 2, 4, 5, 6, 3, 8},
            new List<int> {2, 5, 3, 6, 1, 8, 9, 7, 4},
            new List<int> {4, 6, 8, 7, 3, 9, 2, 5, 1},
            new List<int> {1, 2, 5, 8, 7, 3, 4, 6, 9},
            new List<int> {8, 7, 4, 9, 6, 1, 3, 2, 5},
            new List<int> {9, 3, 6, 5, 2, 4, 8, 1, 7}
        };


        static List<List<int>> Standard = new List<List<int>>()
        {
            new List<int> {0, 8, 0, 0, 0, 0, 6, 0, 0},
            new List<int> {0, 0, 0, 4, 0, 0, 0, 0, 9},
            new List<int> {0, 7, 0, 0, 0, 0, 8, 0, 5},
            new List<int> {4, 0, 0, 0, 0, 0, 0, 0, 0},
            new List<int> {0, 3, 0, 0, 6, 0, 0, 9, 0},
            new List<int> {0, 0, 0, 7, 2, 0, 1, 0, 0},
            new List<int> {0, 9, 3, 2, 0, 0, 0, 6, 4},
            new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0}
        };


        static List<List<int>> pu2 = new List<List<int>>()
        {
            new List<int> {0, 8, 0, 0, 0, 0, 6, 0, 0},
            new List<int> {0, 0, 0, 4, 0, 0, 0, 0, 9},
            new List<int> {0, 7, 0, 0, 0, 0, 8, 0, 5},
            new List<int> {4, 0, 0, 0, 0, 0, 0, 0, 0},
            new List<int> {0, 3, 0, 0, 6, 0, 0, 9, 0},
            new List<int> {0, 0, 0, 7, 2, 0, 1, 0, 0},
            new List<int> {0, 9, 3, 2, 0, 0, 0, 6, 4},
            new List<int> {8, 1, 0, 3, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 5, 0, 0, 0}
        };


        static List<List<int>> soduku18 = new List<List<int>>()
        {
            new List<int> {0, 0, 1, 0, 0, 0, 0, 0, 9},
            new List<int> {0, 0, 0, 2, 0, 0, 0, 4, 6},
            new List<int> {0, 0, 7, 0, 8, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 0, 1, 0, 0, 0},
            new List<int> {0, 0, 3, 0, 0, 0, 2, 0, 0},
            new List<int> {0, 0, 0, 5, 0, 0, 0, 0, 0},
            new List<int> {0, 0, 0, 0, 3, 0, 8, 0, 0},
            new List<int> {9, 6, 0, 0, 0, 7, 0, 0, 0},
            new List<int> {2, 0, 0, 0, 0, 0, 5, 0, 0}
        };


        static void Main(string[] args)

        {
            string a = "helloword";


          new ComfirmedPostion().GenConfirmedPosition(StaticTools.ListToString(soduku18));


            Console.ReadKey();
            return;
        }
    }
}