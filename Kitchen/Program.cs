using System;
using Kitchen.Models;

namespace Kitchen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Moulinex m = new Moulinex();
            m.CookChicken(10);
            m.Cook(30, 450);
            Console.ReadKey();
        }
    }



}
