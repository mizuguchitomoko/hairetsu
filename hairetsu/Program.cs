using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairetsu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 87, 41, 34, 64, 10, 52, 19, 71, 95, 26 };
            Console.WriteLine(score[0]);
            Console.WriteLine(score[1]);
            Console.WriteLine(score[2]);
            foreach (int num in score)
            {
                // 画面に出力
                Console.WriteLine("{0}", num);
            }

        }
    }
}
