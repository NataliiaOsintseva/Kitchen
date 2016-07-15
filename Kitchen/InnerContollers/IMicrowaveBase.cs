using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen.InnerControllers
{
    public interface IMicrowaveBase
    {
        void RayWaves(int power);
        void Cook(int time, int power);
        void Spin(int speed);
        void Stop();
    }

    public interface IDefrost : IMicrowaveBase
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
