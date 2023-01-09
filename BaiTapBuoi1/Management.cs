using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi1
{
    internal class Management
    {
        private static char[] charHexadecimal = {
        '0', '1', '2', '3', '4', '5', '6', '7',
        '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
        };

        //convertBinary
        public static String convertBinaryToDecimal(String binary)
        {
            int numdecimal = 0;
            int count = 0;
            int bina = int.Parse(binary);
            while (bina != 0)
            {
                int r = bina % 10;
                numdecimal += r * 2^count;
                bina /= 10;
                count++;
            }
            return Convert.ToString(numdecimal);
        }

        public static String convertBinaryToHexa(String binary)
        {
            String numdecimal = convertBinaryToDecimal(binary);
            String hexa = convertDecimalToHexa(numdecimal);
            return hexa;
        }

        //convertDecimal   
        public static String convertDecimalToBinary(String numdecimal)
        {
            int deci = int.Parse(numdecimal);
            String binary = "";

            while (deci != 0)
            {
                int r = deci % 2;
                binary = r + binary;
                deci /= 2;
            }
            return binary;
        }

        public static String convertDecimalToOct(String numdecimal)
        {
            int deci = int.Parse(numdecimal);
            String oct = "";

            while (deci != 0)
            {
                int r = deci % 8;
                oct = r + oct;
                deci /= 8;
            }
            return oct;
        }

        public static String convertDecimalToHexa(String numdecimal)
        {
            String hexa = "";
            int deci = int.Parse(numdecimal);
            while (deci != 0)
            {
                int r = deci % 16;
                hexa = charHexadecimal[r] + hexa;
                deci /= 16;
            }
            return hexa;
        }

        //convertHexadecimal    
        public static String convertHexaToBinary(String hexadecimal)
        {
            String numdecimal = convertHexaToDecimal(hexadecimal);
            String binary = convertDecimalToBinary(numdecimal);
            return binary;
        }


        public static String convertHexaToDecimal(String hexadecimal)
        {
            String hexdigits = "0123456789ABCDEF";
            int deci = 0;
            int count = 0;
            for (int i = hexadecimal.Length - 1; i >= 0; i--)
            {
                char c = hexadecimal[i];
                int d = hexdigits.IndexOf(c);
                deci += d * 16^count;
                count++;
            }
            return deci.ToString();
        }

        public static double checkInput()
        {
            while (true)
            {
                try
                {
                    double number =double.Parse(Console.ReadLine());
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                    Console.WriteLine("Please enter the positive number :");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter the positive number :");
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
                    if (number > 0)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Please enter the positive number :");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter the positive number :");
                }
            }
        }
    }
}
