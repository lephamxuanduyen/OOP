namespace Bai1
{
    class HinhTron
    {
        public float BanKinh;
        public float DuongKinh;
        public double DienTich;
        public HinhTron(float r)
        {
            BanKinh=r;
            DuongKinh=2*r;
            DienTich=Math.PI*(Math.Pow(r,2));
        }
        public void Xuat()
        {
            Console.Write("Hinh tron co ban kinh {0} cm, duong kinh {1} cm",BanKinh,DuongKinh);
        }
        public void XuatS()
        {
            Console.WriteLine(", dien tich {0} cm2.",Math.Round(DienTich,2));
        }
    }
    class HinhCau: HinhTron
    {
        double sHinhCau;
        double TheTichHinhCau;
        public HinhCau(float r): base(r)
        {
            sHinhCau = 4*DienTich;
            TheTichHinhCau = (4/3)*DienTich*r;
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine(", dien tich mat cau {0} cm2, the tich hinh cau {1} cm3",Math.Round(sHinhCau,2),Math.Round(TheTichHinhCau,2));
        }
    }
    class HinhTru: HinhTron
    {
        double cvDay;
        double sDay;
        double Sxq;
        double Stp;
        double ttHinhTru;
        public HinhTru(float r, float h):base(r)
        {
            cvDay = 2*r*Math.PI;
            sDay = DienTich;
            Sxq  = 2*r*h*Math.PI;
            Stp  = 2*sDay+Sxq;
            ttHinhTru = sDay*h;
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine(", chu vi mat day {0} cm, dien tich mat day {1} cm2, dien tich xung quanh {2} cm2, dien tich toan phan {3} cm2, the tich {4} cm3",Math.Round(cvDay,2),Math.Round(sDay,2),Math.Round(Sxq,2),Math.Round(Stp,2),Math.Round(ttHinhTru,2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ban kinh hinh tron (cm): ");
            float r_tron = float.Parse(Console.ReadLine());
            HinhTron htron = new HinhTron(r_tron);
            htron.Xuat();
            htron.XuatS();
            Console.Write("Ban kinh hinh cau (cm): ");
            float r_cau = float.Parse(Console.ReadLine());
            HinhCau hcau = new HinhCau(r_cau);
            hcau.Xuat();
            Console.Write("Ban kinh hinh tru (cm): ");
            float r_tru = float.Parse(Console.ReadLine());
            Console.Write("Chieu cao (cm): ");
            float h = float.Parse(Console.ReadLine());
            HinhTru htru = new HinhTru(r_tru,h);
            htru.Xuat();
        }
    }
}