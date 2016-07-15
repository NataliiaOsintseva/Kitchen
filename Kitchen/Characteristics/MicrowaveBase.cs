using System;

namespace Kitchen.Microwave.Characteristics
{
    public abstract class MicrowaveBase : IMicrowaveBase
    {

        private int time;
        private int power;
        private int spinningSpeed;

        public string Color { get; private set; }
        public string Model { get; private set; }

        public int Time
        {
            get
            {
                return time;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid time");
                }
                time = value;
                Console.WriteLine("Time is set to {0}", time);
            }
        }

        public virtual int Power
        {
            get
            {
                return power;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid power, min 50");
                }
                power = value;
                Console.WriteLine("Power is set to {0}", power);
            }
        }

        protected virtual int SpinningSpeed
        {
            get
            {
                return spinningSpeed;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid speed, min 1");
                }
                spinningSpeed = value;
                Console.WriteLine("Speed is set to {0}", spinningSpeed);
            }
        }

        public MicrowaveBase(string model, string color)
        {
            this.Model = model;
            this.Color = color;
            Console.WriteLine("Microwave Constructor");
        }

        protected void RayWaves()
        {
            Console.WriteLine("Raying microwaves...");
        }

        protected void Spin()
        {
            Console.WriteLine("Spinning with a speed of {0}", SpinningSpeed);
        }

        public void Stop()
        {
            Console.WriteLine("Stop...\n");
        }

        public void Start()
        {
            RayWaves();
            Spin();
            Console.WriteLine("Started cooking...");
        }

    }
}
