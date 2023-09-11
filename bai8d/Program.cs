using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace bai8d
{
    internal class Program
    {
      
        
        public static void timkiemtg(List<BOOK> ds)
        {
            string tg;
            Console.WriteLine("nhap ten tg can tim: ");
            tg = Console.ReadLine();
            foreach (BOOK bk in ds)
            {
                if (bk.Tacgia.ToUpper().Contains(tg.ToUpper()))
                {
                    bk.output();
                }
            }
            
        }
        public static void cnsach(List<BOOK> ds)
        {
            {
                string ten;
                Console.WriteLine("Nhap ten sach: ");
                ten = Console.ReadLine();
                foreach (BOOK bk in ds)
                {
                    if (bk.Tensach.ToUpper().Contains(ten.ToUpper()))
                    {
                        Console.WriteLine("Nhap ma thay doi: ");
                        string matd = Console.ReadLine();
                        if (matd != null)
                        {
                            matd = bk.Masach.ToString();
                            bk.Masach = int.Parse(matd);
                        }

                        Console.WriteLine("Nhap ten thay doi: ");
                        string tentd = Console.ReadLine();
                        if (tentd != null && tentd.Length > 0)
                        {
                            bk.Tensach = tentd;
                        }

                        Console.WriteLine("Nhap ten tac gia: ");
                        string tgtd = Console.ReadLine();
                        if (tgtd != null && tgtd.Length > 0)
                        {
                            bk.Tacgia = tgtd;
                        }

                        Console.WriteLine("Nhap don gia: ");
                        double dgtd = double.Parse(Console.ReadLine());
                        if (dgtd != null)
                        {
                            bk.Dongia = dgtd;
                        }

                        bk.output();

                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<BOOK> ds = new List<BOOK>();
            BOOK bk;
            ds.Add( new BOOK(1,"English","Nguyen Van A",10));
            ds.Add(new BOOK(2, "Lap trinh", "Nguyen Van j", 5));
            ds.Add(new BOOK(3, "Tieng viet", "Nguyen Van c", 25));
            ds.Add(new BOOK(4, "toan", "Nguyen Van d", 7));
            ds.Add(new BOOK(5, "Sinh hoc", "Nguyen Van b", 20));
            int chon;
            do
            { 
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Them mot cuon sach");
                Console.WriteLine("2. Xoa mot cuon sach");
                Console.WriteLine("3. Thay doi thong tin mot cuon sach");
                Console.WriteLine("4. Xuat thong tin tat ca cuon sach");
                Console.WriteLine("5. Tim ten sach");
                Console.WriteLine("6. Sach va gia");
                Console.WriteLine("7. Danh sach tac gia");

                chon = int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        bk = new BOOK();
                        bk.input();
                        ds.Add(bk);
                        break;
                    case 2:
                        string Ten;
                        Console.WriteLine("Nhap ten: ");
                        Ten = Console.ReadLine();
                        int n = ds.Count - 1;
                        while (n >= 0)
                        {
                            if (ds[n].Tensach.Equals(Ten, StringComparison.OrdinalIgnoreCase))
                            {
                                break;
                            }
                            n--;
                        }
                        ds.RemoveAt(n);

                        break;
                    case 3:
                        cnsach(ds);
                        break;
                    case 4:
                        ds.ForEach(s=>s.output());  
                        break;
                    case 5:
                        List<BOOK> kq = ds.Where(s => s.Tensach.Equals("Lap trinh",StringComparison.OrdinalIgnoreCase)).ToList();
                        kq.ForEach(s=> s.output());
                        break;
                    case 6:
                        int k,p;
                        Console.WriteLine("Nhap k: ");
                        k = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap p: ");
                        p = int.Parse(Console.ReadLine());
                        List<BOOK> list = new List<BOOK>();                     
                        foreach(BOOK sach in ds)
                        {
                            if (sach.Dongia <= p)
                            {
                                list.Add(sach);
                            }  
                                                     
                        }
                        
                        for(int i =0;i < k; i++) 
                        {
                            list[i].output();
                        }    
                        break;
                        case 7:
                        timkiemtg(ds);
                        break;
                    default:
                        break;
                        Console.WriteLine();
                }
                
            } while(chon!=0);
        }
    }
}
