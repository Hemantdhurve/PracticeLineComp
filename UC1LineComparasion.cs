using System;

namespace UC1LineComparasion
{
    public class LineComparasion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Value of : X1");
            //string value converted to integer

            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : X2");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine()); 
            //using double to get square root value in double decimal points

            double length = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            Console.WriteLine("Length of the line is :" + length);
            Console.ReadLine();
        }
    }
}
