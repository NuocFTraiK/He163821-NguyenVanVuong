using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest2
{   

    class Fraction
    {
        double tuSo, mauSo;


        public Fraction()
        {

        }
        public Fraction(double tuSo, double mauSo)
        {
            this.TuSo = tuSo;
            this.MauSo = mauSo;
        }

        public double TuSo { get => tuSo; set => tuSo = value; }
        public double MauSo { get => mauSo; set => mauSo = value; }

        public void nhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            this.tuSo = Validation.checkInputDouble();
            Console.Write("Nhap mau so: ");
            this.mauSo = Validation.checkInputDoubleLonHon0();
        }

        public void hienThiPhanSo()
        {
            Console.WriteLine($"{tuSo}/{mauSo}");
        }

        public void rutGonPhanSo()
        {
            double n = ucln(tuSo, mauSo);
            tuSo /= n;
            mauSo /= n;
            Console.WriteLine($"{tuSo}/{mauSo}");
        }

        double ucln(double tuSo, double mauSo)
        {
            if (mauSo == 0) return tuSo;
            return ucln(mauSo, tuSo % mauSo);
        }

        public void nghichDaoPhanSo()
        {
            double temp = tuSo;
            tuSo = mauSo;
            mauSo = temp;
            Console.WriteLine($"{tuSo}/{mauSo}");
        }

        public void add()
        {
            Fraction f = new Fraction();
            f.nhapPhanSo();
            Console.WriteLine($"{this.tuSo}/{this.mauSo} + {f.tuSo}/{f.mauSo} = {this.tuSo * f.mauSo + f.tuSo * this.mauSo}/{this.mauSo * f.mauSo}");
        }

        public void sub()
        {
            Fraction f = new Fraction();
            f.nhapPhanSo();
            Console.WriteLine($"{this.tuSo}/{this.mauSo} - {f.tuSo}/{f.mauSo} = {this.tuSo * f.mauSo - f.tuSo * this.mauSo}/{this.mauSo * f.mauSo}");
        }

        public void mul()
        {
            Fraction f = new Fraction();
            f.nhapPhanSo();
            Console.WriteLine($"{this.tuSo}/{this.mauSo} * {f.tuSo}/{f.mauSo} = {this.tuSo * f.tuSo}/{this.mauSo * f.mauSo}");
        }

        public void div()
        {
            Fraction f = new Fraction();
            f.nhapPhanSo();
            Console.WriteLine($"{this.tuSo}/{this.mauSo} / {f.tuSo}/{f.mauSo} = {this.tuSo * f.mauSo}/{this.mauSo * f.tuSo}");
        }
    }
    internal class Program2_Bai8
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction();
            f.nhapPhanSo();
            f.hienThiPhanSo();
            //f.rutGonPhanSo();
            //f.nghichDaoPhanSo();
            f.add();
            f.sub();
            f.mul();
            f.div();
        }
    }
}
