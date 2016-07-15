using System;
using Kitchen.Microwave.Models;

namespace Kitchen.Microwave
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Vesna v = new Vesna();
            v.Time = 30;
            v.Power = 300;
            v.Start();
            v.Stop();

            Saturn s = new Saturn();
            s.Defrost(40);            

            Moulinex m = new Moulinex();
            m.CookChicken(10);

            Console.ReadKey();
        }
    }



}
