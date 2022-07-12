using System;

namespace UC3LineComparasion
{
    public class LineComparasion
    {
        public static void Main(string[] args)
        {

            //comparing two lines L1 and L2
            //1st part line no 1 : L1

            Console.WriteLine("Enter values for Line no 1: ");
            Console.WriteLine("Enter Value of : X1");
            //string value converted to integer

            int X1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Value of : X2");
            int X2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Value of : Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Value of : Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());


            //2st part line no 2 : L2

            Console.WriteLine("Enter values for Line no 2: ");
            Console.WriteLine("Enter Value of : X3");
            int X3 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Value of : X4");
            int X4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Value of : Y3");
            int Y3 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enter Value of : Y4");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            //using double to get square root value in double decimal points

            //to compare two lines we need 2 lengths as L1 and L2
            double L1 = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            Console.WriteLine("Length of the line is :" + L1);

            double L2 = Math.Sqrt((Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2)));
            Console.WriteLine("Length of the line is :" + L2);
            Console.ReadLine();

            //using sequence selection to check lines are equal or not 
            if (L1 == L2)
            {
                Console.WriteLine("BOTH LINES ARE EQUAL");
            }

            else if (L1 > L2)
            {
                Console.WriteLine("L1 IS GREATER THAN L2");
            }
            else
            {
                Console.WriteLine("L1 IS LESS THAN L2");
            }
        }
    }
}

