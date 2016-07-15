using System;
using Kitchen.Microwave.Characteristics;

namespace Kitchen.Microwave.Models
{
    public class Vesna : MicrowaveBase
    {
        private const int maxPower = 750;        

        public Vesna() : base("Vesna Oven 3000-I500", "Metallic")
        {
            Console.WriteLine("Vesna model . Only basic functions");
            SpinningSpeed = 2;
        }

    }
}
