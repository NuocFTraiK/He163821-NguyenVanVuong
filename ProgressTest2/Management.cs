using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2
{
    internal class Management
    {
        public static double[] nhapDuLieuMang(int n)
        {
            Console.Write("Enter data for array: ");
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Validation.checkInputDouble();
            }
            return arr;
        }

        public static double timMax(double[] arr)
        {
            double max = arr.Max();
            return max;
        }

        public static double timMin(double[] arr)
        {
            double min = arr.Min();
            return min;
        }

        public static double timSoDuongChan(double[] a)
        {
            double max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0 && a[i] > 0)
                {
                    if (a[i] > max)
                        max = a[i];
                }
            }
            return max;
        }

        public static double timSoAmLe(double[] a)
        {
            double min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0 && a[i] < 0)
                {
                    if (a[i] < min)
                        min = a[i];
                }
            }
            return min;
        }

        public static bool checkSCP(double n)
        {
            if (n > 0 && Math.Sqrt(n) == (int)Math.Sqrt(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double tinhTrungBinhCongPhanTu0Am(double[] a)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0)
                {
                    sum += a[i];
                    count++;
                }
            }
            return sum / count;
        }
    }
}
