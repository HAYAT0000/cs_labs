using System;

namespace Lab2
{
    class Myclass
    {
        int i = 20;
        public int a
        {
            get
            {
                return i;
            }
            set
            {
                if (value < 1) i = i;
                else i = value;
            }
        }
        int j = 10;
        public int b
        {
            get
            {
                return j;
            }
            set
            {
                if (value < 1) j = j;
                else j = value;
            }
        }
        public static void Oborot(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass p = new Myclass();
            p.a = int.Parse(Console.ReadLine());
            p.b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A={p.a} B={p.b}");
            Console.WriteLine("Теперь меняем A и B значениями:");
            int m = p.a;
            int n = p.b;
            Myclass.Oborot(ref m, ref n);
            Console.WriteLine($"A={m}  B={n}");

        }
    }
}
