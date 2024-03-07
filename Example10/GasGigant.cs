using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class GasGigant : Planet
    {
        //наличие колец
        protected int rings;

        public bool Rings { get; set; }

        // конструктор без параметров
        public GasGigant() : base("Газовый гигант", 10, 10, 1)
        {
            Rings = true;
        }

        // конструктор с параметрами
        public GasGigant(double weight, double radius, int satellites, bool rings) : base("Газовый гигант", weight, radius, satellites)
         {
            Rings = rings;
        }

        // переопределение ToString
        public override string ToString()
        {
            return base.ToString() + $" ;Наличие колец - {Rings}";
        }

        // рандомная инициализация
        public override void RandomInit()
        {
            base.RandomInit();
            if (rnd.Next(0, 1) == 0)
                Rings = false;
            else Rings = true;
            Name = "Газовый гигант";
        }
    }
}