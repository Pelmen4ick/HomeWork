using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Иерпрхии_классов
{
    abstract class Transport
    {
        public string Brand { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }

        public Transport(string brand, string number, int speed)
        {
            Brand = brand;
            Number = number;
            Speed = speed;
        }

        public abstract void DisplayInfo();
        public abstract int GetLoadCapacity();
    }

    class Car : Transport
    {
        public int LoadCapacity { get; set; }

        public Car(string brand, string number, int speed, int loadCapacity)
            : base(brand, number, speed)
        {
            LoadCapacity = loadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Легковая машина: Марка - {Brand}, Номер - {Number}, Скорость - {Speed} км/ч, Грузоподъемность - {LoadCapacity} кг");
        }

        public override int GetLoadCapacity()
        {
            return LoadCapacity;
        }
    }

    class Motorcycle : Transport
    {
        public int LoadCapacity { get; set; }
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, string number, int speed, int loadCapacity, bool hasSidecar)
            : base(brand, number, speed)
        {
            LoadCapacity = hasSidecar ? loadCapacity : 0;
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Мотоцикл: Марка - {Brand}, Номер - {Number}, Скорость - {Speed} км/ч, Грузоподъемность - {LoadCapacity} кг, Коляска - {(HasSidecar ? "есть" : "нет")}");
        }

        public override int GetLoadCapacity()
        {
            return LoadCapacity;
        }
    }

    class Truck : Transport
    {
        public int LoadCapacity { get; set; }
        public bool HasTrailer { get; set; }

        public Truck(string brand, string number, int speed, int loadCapacity, bool hasTrailer)
            : base(brand, number, speed)
        {
            LoadCapacity = hasTrailer ? loadCapacity * 2 : loadCapacity;
            HasTrailer = hasTrailer;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Грузовик: Марка - {Brand}, Номер - {Number}, Скорость - {Speed} км/ч, Грузоподъемность - {LoadCapacity} кг, Прицеп - {(HasTrailer ? "есть" : "нет")}");
        }

        public override int GetLoadCapacity()
        {
            return LoadCapacity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Transport> vehicles = new List<Transport>
        {
            new Car("Toyota", "A123BC", 180, 500),
            new Motorcycle("Harley-Davidson", "M456DE", 120, 200, true),
            new Truck("Volvo", "T789FG", 90, 3000, true),
            new Car("BMW", "X321YZ", 220, 400),
            new Motorcycle("Yamaha", "M654PO", 150, 150, false)
        };

            Console.WriteLine("Информация о всех транспортных средствах:");
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }

            Console.WriteLine("\nВведите минимальную грузоподъемность для поиска:");
            int minCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Транспортные средства с грузоподъемностью не менее {minCapacity} кг:");
            foreach (var vehicle in vehicles)
            {
                if (vehicle.GetLoadCapacity() >= minCapacity)
                {
                    vehicle.DisplayInfo();
                }
            }
            Console.ReadKey();
        }
    }
}
