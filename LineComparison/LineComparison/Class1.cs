using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Line1
    {
        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program on Master Branch");

            Line1.GetCordinates();
        }

        public static void GetCordinates()
        {
            Console.WriteLine("Enter x1 cordinate");
            int x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2 cordinate");
            int x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1 cordinate");
            int y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2 cordinate");
            int y2 = Int32.Parse(Console.ReadLine());

            Line1.CalculateLength(x1, x2, y1, y2);


        }

        public static void CalculateLength(int x1,int x2,int y1,int y2)
        {
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            int length = Math.Sqrt(z);

            Console.WriteLine("Length of line is " + length);
        }
    }
}
