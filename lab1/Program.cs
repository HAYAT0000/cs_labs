using System;
using System.Text.RegularExpressions;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int grad = 0; grad <= 180; grad += 10)
            {
                double radian = grad * Math.PI / 180;
                double form = Math.Sin(radian);
                Console.WriteLine("{0,4} {1,6:F2} {2,12:F4}", grad, radian, form);
            }
        }
    }
}