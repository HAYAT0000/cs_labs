using System;

namespace Lab2_7
{
    class Massiv
    {

        int[] mass = new int[5];
        public int this[int index]
        {
            get { return mass[index]; }
            set { mass[index] = value; }
        }
        public int maximalni;
        public int minimalni;
        public int min {get{ return minimalni; }}
        public int max {get{ return maximalni; }}

        public void Sortir()
        {
            Array.Sort(mass);
            Array.Reverse(mass);
            minimalni = mass[4];
            maximalni = mass[0];
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Massiv mam = new Massiv();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите элементы массива №{i+1}: ");
                mam[i] = int.Parse(Console.ReadLine());
            }
            mam.Sortir();
            Console.WriteLine("Отсортированный по возрастанию массив:");
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(mam[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Minimal of mass = {mam.min}");
            Console.WriteLine($"Max of mass = {mam.max}");
        }
    }
}