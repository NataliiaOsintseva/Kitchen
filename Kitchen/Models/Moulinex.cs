using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen.Interface;
using Kitchen.InnerControllers;

namespace Kitchen.Models
{
    public class Moulinex : MicrowaveBase, IDefrost, IGrill, ICookChicken, IBake
    {
        public Moulinex() : base("Moulinex Multi Shef", "Grey")
        {
            Console.WriteLine("Moulinex constructor");
        }

        public void Bake(int weight)
        {
            Cook(Convert.ToInt32(weight * 0.3), 350);
            Console.WriteLine("Bakery is ready\n");
        }

        public void CookChicken(int weight)
        {
            Console.WriteLine("Cooking Chicken");

            int cookTime = Convert.ToInt32(weight * 0.47);
            int grillTime = Convert.ToInt32(weight * 0.1);

            Cook(weight * 2, 300);
            Grill(grillTime);
            Console.WriteLine("Chicken is ready\n");
        }

        public void Defrost(int time)
        {
            Spin(5);
            SetTime(time);
            RayWaves(150);
            Console.WriteLine("Defrosted\n");
        }

        public void Grill(int time)
        {
            SetTime(time);
            RayWaves(800);
            Spin(30);
            Stop();
            Console.WriteLine("Grilled\n");
        }
    }
}
