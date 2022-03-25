using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

// Elia Angga - 1302204005

namespace TP_Modul5_1302204005
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo saya = new SayaTubeVideo("Tutorial Design By Contract - Elia Angga");
            saya.IncreasePlayCount(0);
            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo("Elia Angga");
            saya1.IncreasePlayCount(1000000000);
            saya1.PrintVideoDetails();
        }
    }

    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            var a = this.title.Substring(0, Math.Min(100, this.title.Length));
            Contract.Requires(this.title != null);
            String number = "";
            Random rnd = new Random();
            id = rnd.Next(1, 100000);
            number += id.ToString("D5");
            playCount = 0;

        }

        public void IncreasePlayCount(int n)
        {
            if (n <= 10000000)
            {
                for (playCount = 0; playCount <= n; playCount++)
                {

                }
                int z = 0;
                try
                {
                    z = checked(n + 10);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("Check : " + e.ToString());
                    Console.WriteLine("Melebihi batas input");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}
