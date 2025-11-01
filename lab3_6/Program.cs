using System;
namespace Lab3_6
{
    class Myclass
    {
        int[] mass = new int[10];
        public int this[int index]
        {
            get { return mass[index]; }
            set { mass[index] = value; }
        }

        public Myclass()
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i;
            }
        }
        public Myclass(int value) : this()
        {
            for (int i = 0; i < mass.Length; i++) mass[i] += value;
        }
        public void Print()
        {
            for (int i = 0; i < mass.Length; i++) Console.Write($"{mass[i]} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Индексы элемментов массива: ");
            Myclass ind = new Myclass();
            ind.Print();
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Введите элементы массива: ");
            int nums = int.Parse(Console.ReadLine());
            Myclass mam = new Myclass(nums);
            Console.WriteLine("Введите число для прибавления к элементам массива: ");
            mam.Print();
            Console.WriteLine("\n------------------------------");
        }

    }
}