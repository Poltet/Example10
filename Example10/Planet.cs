using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class Planet : CelestialBody
    {
        //количество спутников
        protected int satellites;

        public int Satellites
        {
            get { return satellites; }
            set
            {
                if (value < 0)
                    satellites = 1;
                else satellites = value;
            }
        }

        //конструктор без параметров
        public Planet() : base("Планета", 10, 10)
        {
            Satellites = 1;
        }

        //конструктор с параметрами
        public Planet(double weight, double radius, int satellites) : base("Планета", weight, radius)
        {
            Satellites = satellites;
        }

        // конструктор для конструкторов GasGigant
        public Planet(string name, double weight, double radius, int satellites) : base(name, weight, radius)
        {
            Satellites = satellites;
        }

        // переопределение ToString
        public override string ToString()
        {
            return base.ToString() + $"; Кол -во спутников = {Satellites}";
        }

        // рандомная инициализация
        public override void RandomInit()
        {
            base.RandomInit();
            Satellites = rnd.Next(0, 1000);
            Name = "Планета";
        }
    }
}