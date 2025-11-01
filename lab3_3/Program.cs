using System;
namespace Lab3_3 {
    class Myclass
    {
        public int i;
        public int j;

        public Myclass(int value)
        {
            if (value < 0) { j = 0; i = 0; }
            else if (value > 100) { j = 2; i = 100; }
            else { j = 1; i = value; }
        }
        public void Proverka()
        {
            if (j == 0) Console.WriteLine($"Ваше число меньше допустимого предела. А = {i}");
            else if (j == 2) Console.WriteLine($"Ваше число больше допустимого предела. А = {i}");
            else Console.WriteLine($"Ваше число находится в допустимом диапозоне. А = {i}");
        }
    }
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А: ");
            int chislo = int.Parse(Console.ReadLine());
            Myclass mam = new Myclass(chislo);
            mam.Proverka();
        }
    }
}