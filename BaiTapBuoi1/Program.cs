namespace BaiTapBuoi1
{
    internal class Program
    {


       


        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Choose your option from 1 to 8 :");
                int option = int.Parse(Console.ReadLine());
                if (option == -1)
                {
                    break;
                }
                switch (option)
                {
                    case 0:
                        {
                            Console.WriteLine("Convert 2021 from base 10 to base 2: " + Management.convertDecimalToBinary("2021"));
                            Console.WriteLine("Convert 2021 from base 10 to base 8: " + Management.convertDecimalToOct("2021"));
                            Console.WriteLine("Convert 2021 from base 10 to base 16: " + Management.convertDecimalToHexa("2021"));
                            Console.WriteLine();
                            Console.WriteLine("Convert 101110 from base 2 to base 10:"+Management.convertBinaryToDecimal("101110"));
                            Console.WriteLine("Convert 101110 from base 2 to base 16:" + Management.convertBinaryToHexa("101110"));
                            Console.WriteLine();
                            Console.WriteLine("Convert 6DA3F9 from base 16 to base 2 :"+Management.convertHexaToBinary("6DA3F9"));
                            Console.WriteLine("Convert 6DA3F9 from base 16 to base 10 :"+Management.convertHexaToBinary("6DA3F9"));
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Ngon ngu lap tringh C# - C Sharp");
                            break;
                        }
                    case 2:
                        {
                            int n = 100;
                            Console.WriteLine("n = "+n);
                            Console.WriteLine("n + 200 = "+(n+200));
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhap so dong: ");
                            int soDong = int.Parse(Console.ReadLine());
                            Console.WriteLine("Hinh 1:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 2:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = soDong; j >= i; j--)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 3:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = soDong; j > i; j--)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 1; j <= i; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 4:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = 1; j < i; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = i; j <= soDong; j++)
                                {
                                    Console.Write("*");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 5:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = i; j < soDong; j++)
                                    Console.Write(" ");

                                for (int j = 1; j <= i; j++)
                                    Console.Write("* ");
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 6:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = 1; j < i; j++)
                                    Console.Write(" ");

                                for (int j = i; j <= soDong; j++)
                                    Console.Write("* ");
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 7:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = 1; j < i; j++)
                                    Console.Write(" ");

                                for (int j = i; j <= soDong; j++)
                                    Console.Write("* ");
                                Console.WriteLine();
                            }
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = i; j < soDong; j++)
                                    Console.Write(" ");

                                for (int j = 1; j <= i; j++)
                                    Console.Write("* ");
                                Console.WriteLine();
                            }
                            Console.WriteLine("Hinh 8:");
                            for (int i = 1; i <= soDong; i++)
                            {
                                for (int j = 1; j <= soDong; j++)
                                {
                                    if (j==1 || j == soDong)
                                    {
                                        Console.Write("* ");
                                    }
                                    Console.Write(" ");
                                }
                                    Console.WriteLine();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter the number from 1 to 1000: ");
                            int n = int.Parse(Console.ReadLine());
                            int a = n;
                            int[] num = new int[3];
                            for (int i = 0; i < num.Length; i++)
                            {
                                num[i] = n % 10;
                                n = n / 10;
                            }
                            Console.Write($"{a} co {num.Length} ki tu so la :");
                            for (int i = num.Length-1; i >=0; i--)
                            {
                                Console.Write(num[i]+",");
                                if (i==0)
                                {
                                    Console.Write(num[i]);
                                }
                            }
                            

                            break;
                        }
                    case 5:
                        {
                            Console.Write("Nhap diem thi lan 1: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Nhap diem thi online: ");
                            float b = float.Parse(Console.ReadLine());
                            Console.Write("Nhap diem thi cuoi ki: ");
                            float c = float.Parse(Console.ReadLine());
                            float dtk = a * 0.25f + b * 0.25f + c * 0.5f;
                            Console.WriteLine("Diem tong ket: "+dtk);
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Nhap canh goc vuong thu nhat: ");
                            float a = float.Parse(Console.ReadLine());
                            Console.Write("Nhap canh goc vuong thu hai: ");
                            float b = float.Parse(Console.ReadLine());
                            float c =(float) Math.Sqrt(a * a + b * b);
                            Console.WriteLine("Chu vi tam giac la: "+a+b+c);
                            Console.WriteLine("Dien tich tam giac la: " + a*b);
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Nhap canh A: ");
                            double sideA = Management.checkInput();
                            Console.Write("Nhap canh B: ");
                            double sideB = Management.checkInput();
                            Console.Write("Nhap canh C: ");
                            double sideC = Management.checkInput();
                            if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB)
                            {
                                Console.WriteLine("Chu vi tam giac la: " + sideA + sideB + sideC);
                                double p = (sideA + sideB + sideC) / 2;
                                 Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                                Console.WriteLine("Dien tich tam giac la: " + p);
                            }
                            else
                            {
                                Console.WriteLine("Wrong!Reinput");
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("%-15s%-15s%-15s%-15s","Stt","Ma hoc sinh", "Ho va ten", "Diem he so");
                          
                            break;
                        }
                    default:
                        {

                            break;
                        }
                }
            }
          
        }
    }
}