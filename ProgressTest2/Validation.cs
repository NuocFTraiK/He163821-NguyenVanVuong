using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2
{
    internal class Validation
    {
        public static int checkInputIntLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine().Trim());
                    if (result < min || result > max)
                    {
                        throw new Exception();
                    }
                    return result;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input number in rage [" + min + ", " + max + "]");
                    Console.WriteLine("Enter again: ");
                }
            }
        }

        public static double checkInputDouble()
        {
            while (true)
            {
                try
                {
                    double number = double.Parse(Console.ReadLine());
                    return number;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        public static double checkInputDoubleLonHon0()
        {
            while (true)
            {
                try
                {   
                    double number = double.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public static int checkInputInt()
        {
            while (true)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }


    }
}
