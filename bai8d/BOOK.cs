using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8d
{
    internal class BOOK
    {
        private int masach;
        private string tensach;
        private string tacgia;
        private double dongia;

        public BOOK()
        { 

        }

        public BOOK(int masach, string tensach, string tacgia, double dongia)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.dongia = dongia;
        }


        public double Dongia { get => dongia; set => dongia = value; }
        public string Tacgia { get => tacgia; set => tacgia = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public int Masach { get => masach; set => masach = value; }

        public void input()
        {
            Console.WriteLine("Nhap ma sach: ");
            Masach = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten sach: ");
            Tensach = Console.ReadLine();
            Console.WriteLine("Nhap tac gia: ");
            Tacgia = Console.ReadLine();
            Console.WriteLine("Nhap don gia: ");
            Dongia = double.Parse(Console.ReadLine());

        }

        public void output()
        {
          
            Console.WriteLine("  {0}      {1}       {2}        {3}",Masach,Tensach,Tacgia,Dongia);

        }
    }
}
