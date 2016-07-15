using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.InnerControllers
{
    public abstract class MicrowaveBase : IMicrowaveBase
    {
        private string color;
        private string model;


        public string Color { get; set; }
        public string Model { get; set; }

        public MicrowaveBase(string Model, string color)
        {
            Model = model;
            Color = color;
            Console.WriteLine("Microwave Constructor");
        }

        public int SetTime(int sec)
        {
            int time = 30;
            if (sec != 0)
            {
                time = sec;
            }
            Console.WriteLine("Time is set to {0}", time);
            return time;
        }

        public int SetPower(int _power)
        {
            int power = 200;
            if (_power != 0)
            {
                power = _power;
            }
            Console.WriteLine("Power is set to {0}", power);
            return power;
        }

        public void RayWaves(int power)
        {
            SetPower(power);
            Console.WriteLine("Raying microwaves...");
        }

        public void Spin(int speed)
        {
            Console.WriteLine("Spinning");
        }

        public void Stop()
        {
            Console.WriteLine("Stop...");
        }

        public void Cook(int time, int power)
        {
            SetTime(time);
            SetPower(power);
            Spin(8);
            Console.WriteLine("Cooking...");
            Stop();
        }

    }
}
