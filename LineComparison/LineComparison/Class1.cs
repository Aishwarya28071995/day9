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

            Console.WriteLine("Enter x3 cordinate");
            int x3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter x4 cordinate");
            int x4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y3 cordinate");
            int y3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y4 cordinate");
            int y4 = Int32.Parse(Console.ReadLine());

            Line1.CalculateLength(x1, x2, y1, y2,x3,x4,y3,y4);


        }

        public static void CalculateLength(int x1,int x2,int y1,int y2,int x3,int x4,int y3,int y4)
        {
            int x = (x2 - x1) * (x2 - x1);
            int y = (y2 - y1) * (y2 - y1);
            int z = x + y;
            double length1 = Math.Sqrt(z);

            int a = (x4 - x3) * (x4 - x3);
            int b = (y4 - y3) * (y4 - y3);
            int c = a + b;
            double length2 = Math.Sqrt(c);

            Line1.CompareLengthOfTwoLines(length1,length2);
        }

        public static void CompareLengthOfTwoLines(double length1,double length2)
        {
            if(length1==length2)
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }
        }
    }
}
