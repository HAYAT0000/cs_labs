using System;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime.CompilerServices;
namespace Lab6
{
    class ChangeEventArgs : EventArgs
    {
        string name;
        public string Name { get { return name; } }
        DateTime goTime;
        public DateTime GoTime { get { return goTime; } }
        int number;
        public int Number { get { return number; } }
        int place;
        public int Place { get { return place; } }
        public ChangeEventArgs(string name, DateTime goTime, int number, int place)
        {
            this.name = name;
            this.goTime = goTime;
            this.number = number;
            this.place = place;
        }
    }
    class GenEvent
    {
        public delegate void Subscribing(object source, ChangeEventArgs e);
        public event Subscribing? subscribe;
        public void DataCreating(string name, DateTime goTime, int number, int place)
        {
            ChangeEventArgs e = new ChangeEventArgs(name, goTime, number, place);
            if (subscribe != null) subscribe(this, e);
        }
    }
    class Subscriber
    {
        public void TrainEvent(object source, ChangeEventArgs e)
        {
            Console.WriteLine($" Название поезда - {e.Name}, время прибытия - {e.GoTime}, номер вагона - {e.Number}, номер места прибытия - {e.Place}");
        }
        public Subscriber(GenEvent GE)
        {
            GE.subscribe += TrainEvent;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenEvent GE = new GenEvent();
            Subscriber s = new Subscriber(GE);
            Console.WriteLine();
            GE.DataCreating("Поток", new DateTime(2025, 09, 30, 20, 31, 0), 13, 7);
            Console.WriteLine();
        }
    }
}