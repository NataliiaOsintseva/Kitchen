using System;
using Kitchen.Microwave.Characteristics;

namespace Kitchen.Microwave.Models
{
    public class Moulinex : MicrowaveBase, IDefrost, IGrill, ICookChicken, IBake
    {
        private const int maxPower = 1200;
        private const int maxSpeed = 10;

        public Moulinex() : base("Moulinex Multi Shef", "Grey")
        {
            Console.WriteLine("Moulinex constructor");
        }

        public override int Power
        {
            get
            {
                return base.Power;
            }

            set
            {
                if (value > maxPower)
                {
                    throw new ArgumentOutOfRangeException("Invalid power value");
                }
                base.Power = value;
            }
        }

        protected override int SpinningSpeed
        {
            get
            {
                return base.SpinningSpeed;
            }

            set
            {
                if (value > maxSpeed)
                {
                    throw new ArgumentOutOfRangeException("Invalid speed value, maximun is 10");
                }
                base.SpinningSpeed = value;
            }
        }
       
        public void Bake(int weight)
        {
            Time = (int)(weight * 0.3);
            Power = 200;
            SpinningSpeed = 2;

            Start();
            Console.WriteLine("Bakery is ready\n");
        }

        public void CookChicken(int weight)
        {
            Console.WriteLine("Cooking Chicken\n");

            Time = (int)(weight * 0.47);
            Power = 450;
            SpinningSpeed = 3;

            Start();
            Grill((int)(weight * 0.1));

            Console.WriteLine("Chicken is ready\n");
        }

        public void Defrost(int time)
        {
            Time = time;
            Power = 150;
            SpinningSpeed = 5;

            Start();
            Console.WriteLine("Defrosting\n");
        }

        public void Grill(int time)
        {
            Time = time;
            Power = 800;
            SpinningSpeed = 8;

            Start();
            Console.WriteLine("Grilling\n");
        }
    }
}
