namespace Bai4
{
    class Info
    {
        private string id;
        private string name;
        private string lop;
        public string ID
        {
            get {return id;}
            set {id=value;}
        }
        public string HoTen
        {
            get {return name;}
            set {name=value;}
        }
        public string Group
        {
            get {return lop;}
            set {lop=value;}
        }
        public string[,] l=new string[100,3];
        public Info()
        {
            for (int i=0;i<100;i++)
            {
                for (int j=0;j<3;j++)
                {
                    l[i,j]="NONE";
                }
            }
        }
        public string this[int i, int j]
        {
            get
            {
                string tg;
                if (i>=0 &i<100 & j>=0 & j<3)
                {
                    tg=l[i,j];
                }
                else
                {
                    tg="";
                }
                return tg;
            }
            set
            {
                if (i>=0 & i<100 & j>=0 & j<3)
                {
                    l[i,j]=value;
                }
            }
        }
        static public int row;
        static public int column;
        // static int dem=0;
        public void Nhap(ref int dem)
        {
            string[] lines=File.ReadAllLines(@"Info.txt");
            row=lines.Length;
            column=lines[0].Split(";").Length;
            for (int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    l[i,j]=lines[i].Trim().Split(";")[j];
                    dem++;
                }
            }
        }
    }
    class DiemTP
    {
        private float d1;
        private float d2;
        private float d3;
        public float TP1
        {
            get {return d1;}
            set {d1=value;}
        }
        public float TP2
        {
            get {return d2;}
            set {d2=value;}
        }
        public float TP3
        {
            get {return d3;}
            set {d3=value;}
        }
        public float[,] d=new float[100,3];
        public DiemTP()
        {
            for (int i=0;i<100;i++)
            {
                for (int j=0;j<3;j++)
                {
                    d[i,j]=0;
                }
            }
        }
        public float this[int i, int j]
        {
            get
            {
                float tg;
                if (i>=0 & i<100 & j>=0 & j<3)
                {
                    tg=d[i,j];
                }
                else
                {
                    tg=-1;
                }
                return tg;
            }
            set
            {
                if (i>=0 & i<100 & j>=0 & j<3)
                {
                    d[i,j]=value;
                }
            }
        }
        public int row;
        public int column;
        public void Nhap()
        {
            string[]lines=File.ReadAllLines(@"DiemTP.txt");
            row=lines.Length;
            column=lines[0].Split(";").Length;
            for (int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    d[i,j]=float.Parse(lines[i].Trim().Split(";")[j]);
                }
            }
        }
        public double TB(float a, float b, float c)
        {
            double tb=Math.Round(a*0.1+b*0.3+c*0.6,2);
            return tb;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Info sv=new Info();
            DiemTP diem=new DiemTP();
            int dem=0;
            sv.Nhap(ref dem);
            Console.WriteLine("So luong sinh vien trong lop hoc phan OOP: ",dem);
            diem.Nhap();
            for (int i=0;i<100;i++)
            {
                if (sv[i,0]=="NONE") break;
                Console.Write((i+1)+". ");
                for (int j=0;j<3;j++)
                {
                    Console.Write(sv[i,j]+"; ");
                }
                Console.WriteLine("\n    Diem trung binh: "+diem.TB(diem[i,0],diem[i,1],diem[i,2]));
            }
        }
    }
}