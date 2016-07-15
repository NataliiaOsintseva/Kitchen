using System;
using Kitchen.Microwave.Characteristics;

namespace Kitchen.Microwave.Models
{
    class Saturn : MicrowaveBase
    {
        private const int maxPower = 800;
        private const int maxSpeed = 10;
        private const int minSpeed = 2;

        public Saturn() : base("Saturn Simple", "Purple")
        {
            Console.WriteLine("Saturn constructor");
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
                if (value < minSpeed || value > maxSpeed)
                {
                    throw new ArgumentOutOfRangeException("Invalid speed value, maximun is 10");
                }
                base.SpinningSpeed = value;
            }
        }

        public void Defrost(int time)
        {
            Time = time;
            Power = 100;

            Start();
            Console.WriteLine("Defrosting\n");

        }
    }
}
