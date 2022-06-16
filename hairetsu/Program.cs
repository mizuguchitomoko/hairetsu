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
            int[] rank = new int[10];
            
            Console.WriteLine("得点\t 順位");

            for(int i=0; i<score.Length; i++)//score.lengthでscoreの中の要素数
            {
                rank[i] = 1;//順位は1から
                for(int j=0; j<score.Length; j++)//scoreの中の要素をランク１から順に比較していく
                {
                    if (score[i] < score[j])
                    {
                        rank[i]++;
                    }
                }
                Console.WriteLine(score[i] + "\t" + rank[i]);
            }
            ////foreach (int n in score)
            ////{
            ////    // 画面に出力
            ////    Console.WriteLine("{0}", n);
                
                //for (int i=0;i<score.Length; i++)
                //{

                //}
            //}

        }
    }
}
