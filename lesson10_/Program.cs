using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10_
{
    class Vehicle
    {
        public string model;
        public double tonnage;
        public int distance;

        public string Model { get => model; set => model = value; }
        public double Tonnage { get => tonnage; set => tonnage = value > 0 ? value : 1; }
        public int Distance { get => distance; set => distance = value > 0 ? value : 1; }

        public Vehicle(string model, double tonnage, int distance)
        {
            Model = model;
            Tonnage = tonnage;
            Distance = distance;
        }
        public Vehicle()
        {
            Model = "AA";
            Tonnage = -1;
            Distance = 0;
        }
        public override string ToString()
        {
            return $"Транспорт:\n модель:{model},грузовместимость: {tonnage} тонн, растояние:{distance} км.";
        }

        class Jet : Vehicle
        {
            private double height;
            public Jet(string model, double tonnage, int distance, double height)
            {
                this.Model = model;
                this.Tonnage = tonnage;
                this.Distance = distance;
                Height = height;
            }

            public Jet()
            {
                Tonnage = 0.5;
            }

            protected double Height { get => height; set => height = value; }

            public override string ToString()
            {
                return $"Самолет: {base.ToString()},высота {height} м.";                   
            }
        }
        class Bas : Vehicle
        {
            public Bas (string model, double tonnage, int distance)
            {
                this.Model = model;
                this.Tonnage = tonnage;
                this.Distance = distance;
                
            }
            public Bas()
            {
                this.Model = model;
                
            }

            public override string ToString()
            {
                return $"Автобус: {base.ToString()}";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Vehicle vehicle = new Vehicle("MAN", 25, 15000);
                Jet jet = new Jet("АН-418", 18, 10000, 5000);

                Console.WriteLine(vehicle);
                Console.WriteLine(jet);

                Jet jet1 = new Jet();
                Console.WriteLine(jet1);

                Bas bas = new Bas();
                Console.WriteLine(bas);
                Bas bas1 = new Bas("Эталон", 3, 100);
                Console.WriteLine(bas1);
            }
        }
    }
}
