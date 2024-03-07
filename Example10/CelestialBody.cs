using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    public class CelestialBody
    {
        protected Random rnd = new Random();

        protected string name;
        protected double weight;
        protected double radius;

        static string[] Names = { "Звезда", "Планета", "Газовый гигант", "Земля", "Марс", "Венера", "Юпитер",
"Меркурий", "Комета Галея", "Луна" };

        public double Radius
        {
            get { return radius; }
            set
            {
                if (value >= 0)
                    radius = value;
                else
                {
                    radius = 1;
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value >= 0)
                    weight = value;
                else
                {
                    weight = 1;
                }
            }
        }
        public string Name { get; set; } // свойство для названия

        //конструктор без параметров
        public CelestialBody()
        {
            Name = "NoName";
            Weight = 10;
            Radius = 10;
        }

        //конструктор c параметрами
        public CelestialBody(string name, double weight, double radius)
        {
            Name = name;
            Weight = weight;
            Radius = radius;
        }

        public override string ToString()
        {
            return $"Небесное тело:\nИмя = {Name};  Вес = {Weight}; Радиус = {Radius}";
        }


        // рандомная инициализация
        public virtual void RandomInit()
        {
            Name = Names[rnd.Next(Names.Length)];
            Weight = rnd.Next(0, 10000) + Math.Round(rnd.NextDouble(), 2);
            Radius = rnd.Next(0, 10000) + Math.Round(rnd.NextDouble(), 2);
        }

        // переопределение Equals
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is CelestialBody p)
                return this.Name == p.Name;
            return false;
        }
    }
}