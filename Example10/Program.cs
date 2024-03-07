using System;


namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("МАССИВ ТИПА CelestialBody (базовый) С 20 ОБЪЕКТАМИ РАЗНЫХ КЛАССОВ ИЕРАРХИИ");
            CelestialBody[] array1 = new CelestialBody[20];
            // финура Shape
            for (int i = 0; i < 5; i++)
            {
                CelestialBody c = new CelestialBody();
                c.RandomInit();
                array1[i] = c;
            }
            // окружности
            for (int i = 5; i < 10; i++)
            {
                Star s = new Star();
                s.RandomInit();
                array1[i] = s;
            }
            // прямоугольники
            for (int i = 10; i < 15; i++)
            {
                Planet p = new Planet();
                p.RandomInit();
                array1[i] = p;
            }
            // параллелепипеды
            for (int i = 15; i < 20; i++)
            {
                GasGigant g = new GasGigant();
                g.RandomInit();
                array1[i] = g;
            }

            Console.WriteLine("Просмотр элементов массива с использованием virtual методов:");
            foreach (CelestialBody item in array1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}