using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi1
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Write("Choose your option from -4 to 7 :");
                int option = int.Parse(Console.ReadLine());
                if (option == 9)
                {
                    break;
                }
                switch (option)
                {
                    case -4:
                        {
                            Console.Write("Nhap tuoi cua 1 nguoi: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n > 0 && n <= 2)
                            {
                                Console.WriteLine("Tre so sinh");
                            }
                            else if (n > 2 && n <= 10)
                            {
                                Console.WriteLine("Nhi dong");
                            }
                            else if (n > 10 && n <= 17)
                            {
                                Console.WriteLine("Vi thanh nien");
                            }
                            else if (n > 17 && n <= 39)
                            {
                                Console.WriteLine("Thanh nien");
                            }
                            else if (n > 39 && n <= 50)
                            {
                                Console.WriteLine("Trung nien");
                            }
                            else if (n > 50)
                            {
                                Console.WriteLine("Cao nien");
                            }

                            break;
                        }
                    case -3:
                        {
                            Console.Write("Nhap nam san xuat cua may tinh: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n > 15)
                            {
                                Console.WriteLine("Thay the");
                            }
                            else if (n > 10 && n <= 15)
                            {
                                Console.WriteLine("Bao tri");
                            }
                            else
                            {
                                Console.WriteLine("Khong co de xuat");
                            }
                            break;
                        }
                    case -2:
                        {
                            Console.Write("Nhap diem trung binh: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n >= 9)
                            {
                                Console.WriteLine("Hoc bong la 5000000");
                            }
                            else if (n >= 8 && n < 9)
                            {
                                Console.WriteLine("Hoc bong la 3000000");
                            }
                            else if (n >= 7 && n < 8)
                            {
                                Console.WriteLine("Hoc bong la 1000000");
                            }
                            else
                            {
                                Console.WriteLine("Khong co thuong");
                            }
                            break;
                        }
                    case -1:
                        {
                            Console.Write("Nhap luong cua nhan vien: ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("Nhap so gio lam viec trong thang: ");
                            int n = int.Parse(Console.ReadLine());
                            if (n >= 200)
                            {
                                Console.WriteLine("Thuong :" + 0.2 * a);
                            }
                            else if (n >= 100 && n < 200)
                            {
                                Console.WriteLine("Thuong :" + 0.1 * a);
                            }
                            else
                            {
                                Console.WriteLine("Khong co thuong");
                            }
                            break;
                        }
                    case 0:
                        {
                            Console.Write("Nhap diem trung binh: ");
                            float n = float.Parse(Console.ReadLine());
                            if (n >= 9 && n <= 10)
                            {
                                Console.WriteLine("Xuat sac");
                            }
                            else if (n >= 8 && n < 9)
                            {
                                Console.WriteLine("Gioi");
                            }
                            else if (n >= 6.5 && n < 8)
                            {
                                Console.WriteLine("Kha");
                            }
                            else if (n >= 5 && n < 6.5)
                            {
                                Console.WriteLine("Trung binh");
                            }
                            else if (n >= 0 && n < 5)
                            {
                                Console.WriteLine("Thi lai");
                            }
                            else
                            {
                                Console.WriteLine("Diem khong hop le");
                            }
                            break;
                        }
                    case 1:
                        {
                            Console.Write("Nhap 1 so n tu ban phim: ");
                            float n = float.Parse(Console.ReadLine());
                            if (kiemTraSoNguyen(n) == 1)
                            {
                                Console.WriteLine("n la so nguyen");
                            }
                            else
                            {
                                Console.WriteLine("n la so thuc");
                            }
                            kiemTraChanLe(n);
                            kiemTraLeAm(n);
                            kiemTraChanDuong(n);
                            kiemTraChinhPhuong(n);
                            kiemTraDacBiet(n);
                            break;
                        }
                    case 2:
                        {
                            int a = 5, b = 10;
                            Console.WriteLine("a = " + a);
                            Console.WriteLine("b = " + b);
                            Console.WriteLine("Hoan vi a va b:");
                            int temp = a;
                            a = b; b = temp;
                            Console.WriteLine("Gia tri cua a va b sau khi hoan vi lan luot la:" + a + "," + b);
                            break;
                        }
                    case 3:
                        {
                            int a = 3, b = 5, c = 2, d = 4;
                            int[] num = new int[4];
                            num[0] = a; num[1] = b; num[2] = c; num[3] = d;
                            Console.WriteLine("Gia tri lon nhat trong  2,5,2,4 la:" + timMax(num));
                            Console.WriteLine("Gia tri nho nhat trong  2,5,2,4 la:" + timMin(num));
                            Console.Write("Sap xep theo thu tu tang dan:");
                            sort(num);
                            for (int i = 0; i < num.Length; i++)
                            {
                                if (i == num.Length - 1)
                                    Console.Write(num[i]);
                                else
                                    Console.Write(num[i] + ", ");
                            }
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            char ch;
                            Console.Write("Nhap vao 1 ki tu bat ki: ");
                            ch = char.Parse(Console.ReadLine());
                            kiemTraKyTu(ch);
                            break;
                        }
                    case 5:
                        {
                            int thang;
                            while (true)
                            {
                                Console.Write("Nhap vao 1 thang bat ki: ");
                                thang = int.Parse(Console.ReadLine());
                                if(thang < 1 || thang > 12)
                                {
                                    Console.WriteLine("Wrong input");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.Write("Thang "+thang+" ");
                            kiemTraNgayTrongThang(thang);
                            break;
                        }
                    case 6:
                        {
                            giaiPhuongTrinhBacNhat();
                            giaiPhuongTrinhBacHai();
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Nhap canh A: ");
                            double a = Management.checkInput();
                            Console.Write("Nhap canh B: ");
                            double b = Management.checkInput();
                            Console.Write("Nhap canh C: ");
                            double c = Management.checkInput();
                            if (kiemTraTamGiac(a,b,c) == 1)
                            {
                                Console.WriteLine("3 canh A,B,C thoa man tao thanh tam giac");
                            }
                            if (kiemTraTamGiacCan(a,b,c) == 1)
                            {
                                Console.WriteLine("Tam giac ABC la tam giac can");
                            }
                            kiemTraTamGiacDeu(a, b, c);
                            kiemTraTamGiacVuong(a, b, c);
                            kiemTraTamGiacVuongCan(a, b, c);
                            break;
                        }
                }
            }
        }

        static double kiemTraTamGiac(double sideA,double sideB,double sideC)
        {
            while (true)
            {
                if (sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine("Wrong!Reinput");
                }
            }
            return 0;
        }

        static double kiemTraTamGiacCan(double a, double b, double c)
        {
            if (kiemTraTamGiac(a,b,c)==1)
            {
                if (a == b || b==c ||c==a)
                {
                    return 1;
                }
            }
            return 0;
        }

        static void kiemTraTamGiacDeu(double a, double b, double c)
        {
            if (kiemTraTamGiac(a,b,c) == 1 && a==b && b==c)
            {
                Console.WriteLine("Tam giac ABC la tam giac deu");
            }
        }

        static void kiemTraTamGiacVuong(double a, double b, double c)
        {
            if (kiemTraTamGiac(a,b,c) == 1)
            {
                if (Math.Pow(a,2)+ Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Tam giac ABC la tam giac vuong");
                }
            }
        }

        static void kiemTraTamGiacVuongCan(double a, double b, double c)
        {
            if (kiemTraTamGiac(a, b, c) == 1 && kiemTraTamGiacCan(a,b,c) == 1)
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Tam giac ABC la tam giac vuong can");
                }
            }
        }


        static void giaiPhuongTrinhBacNhat()
        {
            float a, b;
            Console.Write("Nhap vao a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine("Phuong trinh co nghiem x = " + -b / a);
            }
        }

        static void giaiPhuongTrinhBacHai()
        {
            float a, b,c;
            Console.Write("Nhap vao a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao c: ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                   if(c==0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem x = "+-c/b);
                }
            }
            else
            {
                float delta = b * b - 4 * c * a;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }else if(delta == 0)
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem kep x1 = x2 = " + -b /(2*a));
                }
                else
                {
                    double x1 = (-b+Math.Sqrt(delta))/(2*a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1 = "+x1+", " +"x2 = "+x2);
                }
            }
        }
        static void kiemTraNgayTrongThang(int n)
        {
            switch (n)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("co 30 ngay");
                    break;
                case 2:
                    {
                        Console.Write("Nhap vao nam :");
                        int nam = int.Parse(Console.ReadLine());
                        if ((n%4==0 && n%100!=0) || n%400==0)
                        {
                            Console.WriteLine("co 29 ngay");
                        }
                        else
                        {
                            Console.WriteLine("co 28 ngay");
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        static void kiemTraKyTu(char ch)
        {
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    switch (ch)
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'u':
                        case 'U':
                        case 'o':
                        case 'O':
                            Console.WriteLine("la nguyen am");
                            break;
                        default:
                            Console.WriteLine("la phu am");
                            break;
                    }

                }
                else if (ch >= '0' && ch <= '9')
                {
                    Console.WriteLine("la ky tu so");
                }
                else
                {
                    Console.WriteLine("khong phai nguyen am ,phu am,hay ky tu so");
                }
            }
        
        private static void sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int minPos = i;                    
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[minPos] > a[j])
                    {
                        minPos = j;
                    }
                }
                if (minPos != i)
                {        
                    int temp = a[minPos];
                    a[minPos] = a[i];
                    a[i] = temp;
                }
            }
        }
        static int timMin(int[] num)
        {
            int min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (min >= num[i])
                {
                    min = num[i];
                }
            }
            return min;
        }
        static int timMax(int[] num)
        {
            int max = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (max <= num[i])
                {
                    max = num[i];
                }
            }
            return max;
        }
        static int kiemTraSoNguyen(float n)
        {
            if (n == (int)n)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void kiemTraChanLe(float n)
        {
            if (kiemTraSoNguyen(n) == 1 && (int)n % 2 == 0)
            {
                Console.WriteLine("n la so chan");
            }
            else if((kiemTraSoNguyen(n) == 1 && (int)n % 2 != 0))
            {
                Console.WriteLine("n la so le");
            }
        }

        static void kiemTraChanDuong(float n)
        {
            if (kiemTraSoNguyen(n) == 1 && (int)n % 2 == 0 && n> 0 )
            {
                Console.WriteLine("n la so chan duong");
            }
            else
            {
                Console.WriteLine("n khong phai la so chan duong");
            }
        }
        static void kiemTraLeAm(float n)
        {
            if (kiemTraSoNguyen(n) == 1 && (int)n % 2 != 0 && n<0)
            {
                Console.WriteLine("n la so le am");
            }
            else
            {
                Console.WriteLine("n khong la so le");
            }
        }

        static void kiemTraChinhPhuong(float n)
        {
            if (n>0 && Math.Sqrt(n)==(int)Math.Sqrt(n))
            {
                Console.WriteLine("n la so chinh phuong");
            }
            else
            {
                Console.WriteLine("n khong la so chinh phuong");
            }
        }
        static void kiemTraDacBiet(float n)
        {
            int donvi, chuc, tram;
            if (n > 0 && n<1000 && kiemTraSoNguyen(n)==1 )
            {
               donvi = (int)n%10;
                chuc = (int)n/10%10;
                tram= (int)n/100%10;
                if (Math.Pow(donvi, 3) + Math.Pow(chuc, 3) + Math.Pow(tram, 3) == n)
                {
                    Console.WriteLine("n la so dac biet");
                }
                else
                {
                    Console.WriteLine("n khong phai la so dac biet");
                }
            }
            else
            {
                Console.WriteLine("n khong la so chinh phuong");
            }
        }
    }
}

