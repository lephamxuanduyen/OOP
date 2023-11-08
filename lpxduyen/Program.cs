using System;
namespace LePhamXuanDuyen
{
    abstract class Shape
    {
        abstract public void ChuVi();
        abstract public void DienTich();
    }
    class HinhChuNhat: Shape
    {
        private float dai;
        private float rong;
        public HinhChuNhat(float dai, float rong)
        {
            this.dai=dai;
            this.rong=rong;
        }
        public override void ChuVi()
        {
            Console.WriteLine("Chu vi: "+(dai+rong)*2 );
        }
        public override void DienTich()
        {
            Console.Write("Dien tich: "+dai*rong);
        }
    }
    class HinhTron: Shape
    {
        private float BanKinh;
        public HinhTron(float BanKinh)
        {
            this.BanKinh=BanKinh;
        }
        public override void ChuVi()
        {
            Console.WriteLine("Chu vi: "+(Math.Round(2*BanKinh*Math.PI,2)));
        }
        public override void DienTich()
        {
            Console.WriteLine("Dien tich: "+(Math.Round(2*Math.Pow(BanKinh,2)*Math.PI,2)));
        }
    }
    class HinhTamGiac: Shape
    {
        private float a;
        private float b;
        private float c;
        public HinhTamGiac(float a,float b,float c)
        {
            this.a=a;
            this.b=b;
            this.c=c;
        }
        public override void ChuVi()
        {
            if (a<b+c & b<a+c & c<a+b)
            {
                Console.WriteLine("Chu vi: "+(Math.Round(a+b+c,2)));
            }
            else
            {
                Console.WriteLine("Day khong phai tam giac");
            }
        }
        public override void DienTich()
        {
            if (a<b+c & b<a+c & c<a+b)
            {
                float p=(a+b+c)/2;
                double s=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("Dien tich: "+(Math.Round(s,2)));
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** HINH CHU NHAT ***");
            Console.Write("    Dai: ");
            float dai=float.Parse(Console.ReadLine());
            Console.Write("    Rong: ");
            float rong=float.Parse(Console.ReadLine());
            HinhChuNhat hcn=new HinhChuNhat(dai,rong);
            hcn.ChuVi();
            hcn.DienTich();
            Console.WriteLine("*** HINH TRON ***");
            Console.Write("    Ban kinh: ");
            float r=float.Parse(Console.ReadLine());
            HinhTron ht=new HinhTron(r);
            ht.ChuVi();
            ht.DienTich();
            Console.WriteLine("*** HINH TAM GIAC ***");
            Console.Write("    Canh thu 1: ");
            float a=float.Parse(Console.ReadLine());
            Console.Write("    Canh thu 2: ");
            float b=float.Parse(Console.ReadLine());
            Console.Write("    Canh thu 3: ");
            float c=float.Parse(Console.ReadLine());
            HinhTamGiac htg=new HinhTamGiac(a,b,c);
            htg.ChuVi();
            htg.DienTich();
        }
    }
}