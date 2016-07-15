using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen.InnerControllers;

namespace Kitchen.Interface
{
    abstract class BasicPanel : MicrowaveBase
    {
        public BasicPanel(string model, string color) : base(model, color)
        {
            Console.WriteLine("Moulinex constructor");
        }

        public void StartCooking(int time, int power)
        {
            Cook(time, power);
        }

        public void PressStop()
        {
            //CancellationToken
        }
    }
}
