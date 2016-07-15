using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen.Interface;

namespace Kitchen.Models
{
    class Saturn : BasicPanel, IExtraPrograms
    {
        public Saturn() : base("Saturn Simple", "Purple")
        {
            Console.WriteLine("Moulinex constructor");
        }

        public void Defrost(int time)
        {
            Spin(5);
            SetTime(time);
            RayWaves(100);
            Console.WriteLine("Defrosted\n");
        }
    }
}
