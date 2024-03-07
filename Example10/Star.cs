using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Star : CelestialBody
    {
        protected double temperature;
        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value >= 0)
                    temperature = value;
                else
                {
                    temperature = 1;
                }
            }
        }

        //конструктор без парамеров 
        public Star() : base("Звезда", 10, 10)
        {
            Temperature = 10;
        }

        // конструктор с параметрами
        public Star(double weight, double radius, double temperature) : base("Звезда", weight, radius)
        {
            Temperature = temperature;
        }

        // переопределение ToString
        public override string ToString()
        {
            return base.ToString() + $" ;Температура = {Temperature}";
        }

        // рандомная инициализация
        public override void RandomInit()
        {
            base.RandomInit();
            Temperature = rnd.Next(0, 10000) + Math.Round(rnd.NextDouble(), 2);
            Name = "Звезда";
        }
    }
}