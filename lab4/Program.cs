using System;
namespace Lab4
{
    class Transport
    {
        public string name = "нет";
        public int capacity = 0;
        public int speed = 0;
        public Transport(string name, int capacity, int speed)
        {
            this.name = name;
            this.capacity = capacity;
            this.speed = speed;
        }
        public void PrintInfo()
        {
            Console.Write($"Название транспорта - {name}; Вместимость - {capacity}; скорость - {speed} км/ч");
        }
    }
    class Car : Transport
    {
        public string fuel = "неизвестно";
        public Car(string name, int capacity, int speed, string fuel) : base(name, capacity, speed)
        {
            this.fuel = fuel;
        }
        public void CarInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"; в роли топлив используется {fuel}");
        }
        
    }
    class Train : Transport
    {
        public int wagonNumber = 0;
        public Train(string name, int capacity, int speed, int wagons) : base(name, capacity, speed)
        {
            wagonNumber = wagons;
        }
        public void TrainInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"; количество вагонов - {wagonNumber}");
        }
    }
    class Express : Train
    {
        public string route = "none";
        public Express(string name, int capacity, int speed, int wagons, string route) : base(name, capacity, speed, wagons)
        {
            this.route = route;
        }
        public void ExpressInfo()
        {
            base.TrainInfo();
            Console.WriteLine($"Данное транспортное средство типа EXPRESS движется по маршруту '{route}'");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transport tr = new Transport("танк", 4, 80);
            Car cr = new Car("porsche 911 gt3 rs", 2, 296, "бензин");
            Train tn = new Train("Сапсан", 600, 250, 10);
            Express ex = new Express("Allegro", 350, 220, 7, "Санкт-Петербург — Хельсинки");
            tr.PrintInfo();
            Console.WriteLine();
            cr.CarInfo();
            tn.TrainInfo();
            ex.ExpressInfo();
        }
    }
}