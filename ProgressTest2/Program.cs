namespace ProgressTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double[] arr = new double[n];
            while (true)
            {
                Console.WriteLine("1.Nhap 1 so nguyen(0<n<50)");
                Console.WriteLine("2.Nhap 1 mang gom n so thuc.");
                Console.WriteLine("3.Tim so lon nhat trong mang");
                Console.WriteLine("4.Tim so nho nhat trong mang");
                Console.WriteLine("5.Tim so duong chan lon nhat trong mang");
                Console.WriteLine("6.Tim so am le nho nhat trong mang");
                Console.WriteLine("7.Tim cac so chinh phuong trong mang");
                Console.WriteLine("8.Tinh tong mang");
                Console.WriteLine("9.Tinh trung binh cong cac phan tu trong mang");
                Console.WriteLine("10.Tim nhung phan tu lon hon trung binh cong");
                Console.WriteLine("11.Sap xep mang theo trat tu tang dan)");
                Console.WriteLine("12.Sap xep mang theo trat tu giam dan)");
                Console.WriteLine("13.In ra trung binh cong cac phan tu khong am cua day");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Choose your option: ");
                int option = Validation.checkInputIntLimit(0, 13);
                if (option == 0)
                {
                    break;
                }
                
                switch (option)
                {
                    case 1:
                        {
                            Console.Write($"Nhap n = ");
                            n = Validation.checkInputIntLimit(0, 50);
                            
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"So phan tu cua mang la : {n}");
                            arr = Management.nhapDuLieuMang(n);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("So lon nhat trong mang la "+arr.Max());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("So nho nhat trong mang la " + arr.Min());
                            break;
                        }
                    case 5:
                        {
                            if (Management.timSoDuongChan(arr) % 2 == 0 && Management.timSoDuongChan(arr) > 0)
                                Console.WriteLine($"Duong chan max: {Management.timSoDuongChan(arr)}");
                            else
                                Console.WriteLine("Don't have negative even number");
                            break;
                        }
                    case 6:
                        {
                            if (Management.timSoAmLe(arr) % 2 != 0 && Management.timSoAmLe(arr) < 0)
                                Console.WriteLine($"Positive odd min: {Management.timSoAmLe(arr)}");
                            else
                                Console.WriteLine("Don't have positive odd number");
                            break;
                        }
                    case 7:
                        {
                            Console.Write("So chinh phuong: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (Management.checkSCP(arr[i]) == true)
                                    Console.Write(arr[i] + " ");
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Tong number trong mang la " + arr.Sum());
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Trung binh cong cac phan tu mang la " + arr.Sum()/arr.Length);
                            break;
                        }
                    case 10:
                        {
                            double a = arr.Sum() / arr.Length;
                            Console.Write("Values greater than average of array: ");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] > a)
                                    Console.Write(arr[i] + " ");
                            }
                            break;
                        }
                    case 11:
                        {
                            Array.Sort(arr);
                            Console.Write("Sap xep mang tang dan :");
                            foreach(int i in arr)
                            {
                                Console.Write(i);
                            }
                            break;
                        }
                    case 12:
                        {
                            Array.Reverse(arr);
                            Console.Write("Sap xep mang giam dan :");
                            foreach (int i in arr)
                            {
                                Console.Write(i);
                            }
                            break;
                        }
                    case 13:
                        {
                            Console.Write("Trung binh cong cac phan tu 0 am :"+Management.tinhTrungBinhCongPhanTu0Am(arr));
                            break;
                        }
                   
                }
            }
        }
    }
}