using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.Microwave.Characteristics
{
    public interface IMicrowaveBase
    {
        void Start();
        void Stop();
    }

    public interface IDefrost
    {
        void Defrost(int time);
    }

    public interface ICookChicken
    {
        void CookChicken(int weight);
    }

    public interface IGrill
    {
        void Grill(int time);
    }

    public interface IBake
    {
        void Bake(int weight);
    }
}
