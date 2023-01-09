using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2
{
    //Bai2
   class NhanVien
    {
        private String name;
        private int age;
        private String address;
        private double salary;
        private int worktime;

        public NhanVien(string name, int age, string address, double salary, int worktime)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
            this.Salary = salary;
            this.Worktime = worktime;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Address { get => address; set => address = value; }
        public double Salary { get => salary; set => salary = value; }
        public int Worktime { get => worktime; set => worktime = value; }

        void inputInfo()
        {
            Console.Write("Enter name: ");
            this.name = Console.ReadLine();
            Console.Write("Enter age: ");
            this.age = int.Parse(Console.ReadLine());
            Console.Write("Enter address: ");
            this.address = Console.ReadLine();
        }

        void printInfo()
        {
            Console.WriteLine("Name :"+this.name);
            Console.WriteLine("Age :" + this.age);
            Console.WriteLine("Address :" + this.address);
        }

        double tinhThuong()
        {
            double thuong;
            if (this.worktime >200) {
                thuong = this.salary * 0.2;
            }
            else if (this.worktime<200 & this.worktime>=100)
            {
                thuong = this.salary * 0.1;
            }
            else
            {
                thuong = 0;
            }
            return this.salary;
        }
    }
    //Bai 5
    class SoNguyenTo
    {
        int a;

        public SoNguyenTo()
        {

        }
        public SoNguyenTo(int x)
        {
            if (kiemTraSNT(x) == true)
            {
                this.a = x;
            }
            else
            {
                Console.WriteLine($"{x} khong phai la SNT ,khong luu tru :)) ");
            }
        }

        public int A { get { return a; }
            set {

                if (kiemTraSNT(value) == true)
                {
                    a = value;
                }
                else
                {
                    Console.WriteLine("Khong set");
                }


            }
        }

        public  bool kiemTraSNT(int n)
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

        public int timSNTAfter(int a)
        {
            while (!kiemTraSNT(++a)) {
            }
            return a;
        }




    }
internal class Program2
    {

    static void Main(string[] args)
    {
            SoNguyenTo snt = new SoNguyenTo(5);
            Console.WriteLine(snt.A);
            snt.A = 4;
            Console.WriteLine(snt.timSNTAfter(snt.A));
         
    }

    }
}
