using System;
using System.Collections.Generic;
using System.IO;
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

        static List<List<int>> soduku39 = new List<List<int>>()
        {
            new List<int> {7, 0, 5, 6, 0, 0, 8, 0, 4},
            new List<int> {6, 4, 0, 0, 0, 0, 0, 2, 7},
            new List<int> {1, 2, 8, 4, 7, 0, 0, 5, 6},
            new List<int> {2, 5, 1, 0, 6, 0, 0, 0, 8},
            new List<int> {0, 0, 0, 0, 0, 0, 0, 0, 0},
            new List<int> {8, 0, 0, 0, 5, 0, 2, 6, 0},
            new List<int> {0, 8, 0, 0, 3, 0, 0, 7, 0},
            new List<int> {5, 0, 2, 7, 4, 0, 0, 8, 3},
            new List<int> {3, 0, 7, 5, 0, 0, 4, 0, 2}
        };

        static void Main(string[] args)

        {
            if (1>0)
            {

                //Dictionary<string, string> dic111 = new Dictionary<string, string>();
                //dic111.Add("元", "000000000001234500000000020134659782000308000000402000000703004009006007070001358");
                //dic111.Add("旦", "002156400001000500005000600006829700008000900009000800007912340000000000914783265");
                //dic111.Add("快", "080007000010005000020634180030002090040589213952003000060050800070300050094000001");
                //dic111.Add("乐", "000000100085712000200030000800040000547891230000050000004060800050370040300020001");
                //foreach (var kv in dic111)
                //{
                //    new ComfirmedPostion().GenSoduku(kv.Value, kv.Key);
                //}


                Console.WriteLine(new DanceLink().solution_count("000000000001234500000000020134659782000308000000402000000703004009006007070001358"));
                Console.WriteLine(new DanceLink().solution_count("000000000002134500000000020134659782000308000000402000000703004009006007070001358"));
                Console.WriteLine(new DanceLink().solution_count("002156400001000500005000600006829700008000900009000800007912340000000000914783265"));
                Console.WriteLine(new DanceLink().solution_count("080007000010005000020634180030002090040589213952003000060050800070300050094000001"));
                Console.WriteLine(new DanceLink().solution_count("000000100085712000200030000800040000547891230000050000004060800050370040300020001"));
                string str1 = "705602000640305100100000300200000000000000000000004269000000000010040980000098412";
                Console.WriteLine("IsPearl"  + StaticTools.IsPearl(str1));
               var temp=new SodukuMarket(str1).Pearl.StrExpress;
                Console.WriteLine("this Pearl" + temp);
                Console.WriteLine("this temp count" +   StaticTools.GetLocations(temp).Count);
                var result=new DanceLink().do_solve(StaticTools.ListToString(soduku39));
                var locations = new SodukuMarket(result).Pearl.StrExpress;
                //var lists = PermutationAndCombination<int>.GetCombination(locations.ToArray(), 2);
                //var AllStr=new List<String>();
                //foreach (var item in lists)
                //{
                //    AllStr.Add(StaticTools.SwitchLocation(str1,item[0],item[1]));
                //}

                //AllStr = AllStr.Distinct().ToList();
                //Console.WriteLine(" 待检测表达式个数"+ AllStr.Count);
                //AllStr = AllStr.Where(c => new DanceLink().solution_count(c) > 1).ToList();
                //AllStr.Sort();
                //Console.WriteLine(" 有效表达式个数" + AllStr.Count);
                //foreach (var express in AllStr)
                //{
               

                //    using (StreamWriter sw = new StreamWriter(@"E:\soduku\Soduku\bin\Debug\text.txt", true))
                //    {
                //        sw.WriteLine(" 当前表达式是" + express + "结果个数是" + new DanceLink().solution_count(express));
                //    }

                //    var item =new SodukuMarket(express);
                //    var cells = item.GetCellInfos().Values.Where(cell => cell.Value == 0).ToList();
                //    Dictionary<int,List<int>> dic1=new Dictionary<int, List<int>>();
                //    foreach (var cell in cells)
                //    {
                //        dic1.Add(cell.location,cell.initrest);
                //    }

                //    foreach (var kv in dic1)
                //    {
                //        foreach (var value in kv.Value)
                //        {
                //            var newString = StaticTools.SetValue(express, kv.Key, "" + value);
                //            if (StaticTools.IsPearl(newString))
                //            {
                //                Console.WriteLine("newString" + newString + "  提示数个数为" + StaticTools.GetLocations(newString).Count);
                //            }
                //        }
                //    }
                //}

                return;
                Dictionary<string, string> dic = new Dictionary<string, string>
                {
                    {"快", "080007000010005000020634180030002090040589213952003000060050800070300050094000001"},
                    {"旦", "002156400001000500005000600006829700008000900009000800007912340000000000914783265"},
                    {"乐", "000000100085712000200030000800040000547891230000050000004060800050370040300020001"},
                    {"元", "000000000001234500000000020134659782000308000000402000000703004009006007070001358"},
                    {"对称之一", "100000007020000080003000500000406000000907000000503000006000400080000020900000001"},
                    {"对称之二", "100040007020000080003000500000406000504000106000503000006000400080000020900080001"}
                };



                foreach (var kv in dic)
                {
                    new ComfirmedPostion().GenSoduku( kv.Value, kv.Key);
                }
            }
            else
            {

                var c1111=new SodukuMarket(new SodukuBuilder().MakeSoduku()).Pearl.StrExpress;
            
   
                var testString = "705602000640305100100000300200000000000000000000004269000000000010040980000098412";//29个提示数的珍珠盘
                //testString = c1111;
                var test = StaticTools.IsPearl(testString);
                Console.WriteLine("    当前表达式是\r\n" + testString + "\r\n" + StaticTools.GetLocations(testString).Count);
                Console.WriteLine("输入数据的提示数个数为" + StaticTools.GetLocations(testString).Count);
                var c = new MoreClues().GetMoreNotice(testString, 39
                 ); //26个提示数

                Console.WriteLine(c);
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadKey();
                Console.ReadKey();
            }





   
            


            Console.ReadKey();
            return;
        }

        private static bool GetNewClues()
        {
            var validString = "300000000000090032095300100200010009060003000050000840030007908600009450980150020";

            Console.WriteLine( "输入数据的提示数个数为" + StaticTools.GetLocations(validString).Count);
            var newtest =
                StaticTools.IsPearl(validString);
            var result1 = new SodukuMarket(StaticTools.StringToList(validString)).SubMarkets;

            foreach (var c1 in result1)
            {

                if (StaticTools.IsPearl(c1.StrExpress))
                {
                    Console.WriteLine(c1.StrExpress+"已知数个数为"+StaticTools.GetLocations(c1.StrExpress).Count);
                }
            }

  
            return newtest;
        }
    }
}