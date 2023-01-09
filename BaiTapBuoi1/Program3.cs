using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi1
{
    internal class Program3
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Choose your option from 1 to 16 :");
                int option = int.Parse(Console.ReadLine());
                if (option == -1)
                {
                    break;
                }
                switch (option)
                {
                    case 1:
                        {
                            for (int i = 1; i <= 100; i++)
                            {
                                Console.Write(i+" ");
                            }
                            break;
                        }
                    case 2:
                        {
                            for (int i =100; i > 0; i--)
                            {
                                Console.Write(i + " ");
                            }
                            break;
                        }
                    case 3:
                        {
                            for (int i = 1; i <= 100; i++)
                            {
                                if (i%3==0)
                                {
                                    Console.Write(i + " ");
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            for (int i = 99; i > 0; i--)
                            {
                                if (i % 7 == 0)
                                {
                                    Console.Write(i + " ");
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            int sum = 0;
                           
                            for (int i = 1; i <= 50; i++)
                            {
                               sum += i;
                            }
                            Console.Write("Tong cua 50 so tu 1 den 50: "+sum);
                            break;

                        }
                    case 6:
                        {
                            int sum = 0;

                            for (int i = 50; i >0; i--)
                            {
                                sum += i;
                            }
                            Console.Write("Tong cua 50 so tu 50 den 1: " + sum);
                            break;


                        }
                    case 7:
                        {
                            int sum = 0;
                            for (int i = 2; i <= 100 ; i=i+2)
                            {
                                sum += i;
                            }
                            Console.Write("Tong cua 50 so chan bat dau tu 2: " + sum);
                            break;

                        }
                    case 8:
                        {

                            int sum = 0;
                            for (int i = 5; i <= 100; i = i + 5)
                            {
                                sum += i;
                            }
                            Console.Write("Tong cua 20 so 5,10,15,...,100: " + sum);
                            break;

                        }
                    case 9:
                        {
                            Console.Write("Nhap n :");
                            int n = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{n}! = "+tinhGiaiThua(n));
                            break;

                        }
                    case 10:
                        {
                            Console.Write("Nhap n :");
                            int n = int.Parse(Console.ReadLine());
                            if (kiemTraSNT(n) == true)
                            {
                                Console.WriteLine($"{n} la so nguyen to");
                            }
                            else
                            {
                                Console.WriteLine($"{n} khong phai la so nguyen to");
                            }
                            break;

                        }
                    case 11:
                        {
                            Console.Write("Nhap n :");
                            int n = int.Parse(Console.ReadLine());
                            if (kiemTraSoHoanHao(n) == true)
                            {
                                Console.WriteLine($"{n} la so hoan hao");
                            }
                            else
                            {
                                Console.WriteLine($"{n} khong phai la so hoan hao");
                            }
                            break;

                        }
                    case 12:
                        {
                            Console.Write("10 so dau tien cua day fibonacci: ");
                            for (int i = 1; i <= 10; i++)
                            {
                                Console.Write(fibonacci(i) + ", ");
                                if (i==10)
                                {
                                    Console.Write(fibonacci(i));
                                }
                            }
                            Console.WriteLine();
                            Console.Write("So fibonacci thu 13 : "+fibonacci(13));
                            Console.WriteLine();
                            break;

                        }
                    case 13:
                        {
                            Console.Write("Nhap n :");
                            int n = Management.checkInputInt();
                            int a = n;
                            int count = 0;
                            int sum = 0;
                            int max = 0;
                            while (n!= 0)
                            {
                                int r = n % 10;
                                sum += r;
                                if (r > max)
                                {
                                    max = r;
                                }
                                    n /= 10;
                                ++count;
                            }
                            Console.WriteLine($"So nguyen duong {a} co {count} chu so");
                            Console.WriteLine("Tong cac chu so = "+sum);
                            Console.WriteLine("Chu so lon nhat la :"+max);
                            break;

                        }
                    case 14:
                        {

                            break;

                        }
                    case 15:
                        {
                            Console.Write("Nhap n :");
                            int n = Management.checkInputInt();
                            phanTichSoNguyen(n);
                            Console.WriteLine();
                            break;

                        }
                    case 16:
                        {
                            Console.Write("Nhap a :");
                            int a = Management.checkInputInt();
                            Console.Write("Nhap b :");
                            int b = Management.checkInputInt();
                            for (int i=a; i<b ; i++)
                            {
                                if (kiemTraSNT(i) == true)
                                {
                                    Console.Write(i+",");
                                }
                            }
                            Console.WriteLine();
                            Console.Write("UCLN cua {0} va {1} la: {2} \n", a, b, UCLN(a, b));
                            break;

                        }
                }
            }
        }

        static int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        static void phanTichSoNguyen(int n)
        {
            int i = 2;
            int dem = 0;
            int[] a = new int[100];
            // phan tich
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    a[dem++] = i;
                }
                else
                {
                    i++;
                }
            }
            // neu dem = 0 thi n la nguyen to
            if (dem == 0)
            {
                a[dem++] = n;
            }
            // in ket qua
            for (i = 0; i < dem - 1; i++)
            {
                Console.Write("{0} x ", a[i]);
            }
            Console.Write("{0}", a[dem - 1]);
        }
        static int fibonacci(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        static int tinhGiaiThua(int n)
        {
            if (n == 0) return 1;

            int giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }

            return giaithua;
        }

        static bool kiemTraSNT(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool kiemTraSoHoanHao(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n) { return true; }
            return false;
        }
    }
}
