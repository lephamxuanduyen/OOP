namespace bai2C5
{
    class People
    {
        private string id;
        private string hoten;
        private string tuoi;
        private string diachi;
        public string ID
        {
                get {return id;}
                set {id = value;}
        }
        public string Hoten
        {
                get {return hoten;}
                set {hoten = value;}
        }
        public string Tuoi
        {
                get {return tuoi;}
                set {tuoi = value;}
        }
        public string DiaChi
        {
                get {return diachi;}
                set {diachi = value;}
        }
        public void Nhap()
        {
            Console.Write("ID: ");
            this.ID=Console.ReadLine();
            Console.Write("Ho ten : ");
            this.Hoten=Console.ReadLine();
            Console.Write("Tuoi : ");
            this.Tuoi=Console.ReadLine();
            Console.Write("Dia chi : ");
            this.DiaChi=Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("ID: "+ID);
            Console.WriteLine("Ho ten: "+Hoten);
            Console.WriteLine("Tuoi: "+Tuoi);
            Console.WriteLine("Dia chi: "+DiaChi);
        }
    }
    class Student: People
    {
        public string Term;
        public float TP1;
        public float TP2;
        public float TP3;
        public double tb;
        public double GPA(float a, float b, float c)
        {
            return Math.Round((a+b+c)/3,2);
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Ten hoc phan: ");
            Term=Console.ReadLine();
            Console.Write("TP1: ");
            TP1=float.Parse(Console.ReadLine());
            Console.Write("TP2: ");
            TP2=float.Parse(Console.ReadLine());
            Console.Write("TP3: ");
            TP3=float.Parse(Console.ReadLine());
        }
        public new void Xuat(double tb)
        {
            base.Xuat();
            Console.WriteLine("TP1: "+TP1);
            Console.WriteLine("TP2: "+TP2);
            Console.WriteLine("TP3: "+TP3);
            Console.WriteLine("Diem TB: "+tb);
        }
    }
    class Lecture: People
    {
        public int KinhNghiem;
        public string HocVi;
        public string ChucVu;
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("Nam kinh nghiem: ");
            KinhNghiem=int.Parse(Console.ReadLine());
            Console.Write("Hoc vi: ");
            HocVi=Console.ReadLine();
            Console.Write("Chuc vu: ");
            ChucVu=Console.ReadLine();
        }
        public new void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Kinh nghiem: "+KinhNghiem);
            Console.WriteLine("Hoc vi: "+HocVi);
            Console.WriteLine("Chuc vu: "+ChucVu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("So luong sinh vien can nhap: ");
            int n=int.Parse(Console.ReadLine());
            Student[] dsSV=new Student[n];
            for (int i=0;i<n;i++)
            {
                Student sv=new Student();
                sv.Nhap();
                dsSV[i]=sv;
            }
            Console.WriteLine("*** IN DANH SACH SINH VIEN ***");
            for (int i=0;i<n;i++)
            {
                double tb=dsSV[i].GPA(dsSV[i].TP1,dsSV[i].TP2,dsSV[i].TP3);
                dsSV[i].Xuat(tb);
            }
            Console.Write("So luong giang vien can nhap: ");
            int m=int.Parse(Console.ReadLine());
            Lecture[] dsGV=new Lecture[m];
            for (int i=0;i<m;i++)
            {
                Lecture gv=new Lecture();
                gv.Nhap();
                dsGV[i]=gv;
            }
            Console.WriteLine("*** IN DANH SACH GIANG VIEN DA SAP XEP THEO NAM KINH NGHIEM ***");
            int[] kn=new int[m];
            for (int i=0;i<m;i++)
            {
                kn[i]=dsGV[i].KinhNghiem;
            }
            Array.Sort(kn);
            Array.Reverse(kn);
            for (int i=0;i<m;i++)
            {
                for (int j=0;j<m;j++)
                    if (dsGV[j].KinhNghiem==kn[i])
                    {
                        dsGV[j].Xuat();
                    }
            }
        }
    } 
}