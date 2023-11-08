namespace batdongsan
{
    class BatDongSan
    {
        public string MaBDS {get;set;}
        public string TenBDS { get; set; }
        public string Huong { get; set; }
        public string Dchi { get; set; }
        public string Dtich { get; set; }
        public string GiaBan { get; set; }
    }
    class DanhSachBDS
    {
        public BatDongSan[] lBDS = new BatDongSan[100];
        public DanhSachBDS()
        {
            for (int i=0;i<100;i++)
            {
                lBDS[i].MaBDS="None";
                lBDS[i].TenBDS="None";
                lBDS[i].Huong="None";
                lBDS[i].Dchi="None";
                lBDS[i].Dtich="None";
                lBDS[i].GiaBan="None";
            }
        }
        public BatDongSan this[int i]
        {
            get
            {
                if (i>=0 & i<lBDS.Length)
                {
                    return lBDS[i];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                lBDS[i]=value;
            }
        }
        public void Nhap()
        {
            string input = File.ReadAllText(@"bds.txt");
            string [,] res = new string[100,10];
            int i=0;
            foreach (var row in input.Split("\n"))
            {
                int j=0;
                foreach (var col in row.Trim().Split(";"))
                {
                    res[i,j]=(col.Trim());
                    j++;
                }
                i++;
            }
            for (int a=0;a<i;a++)
            {
                lBDS[a].MaBDS=res[a,0];
                lBDS[a].TenBDS=res[a,1];
                lBDS[a].Huong=res[a,2];
                lBDS[a].Dchi=res[a,3];
                lBDS[a].Dtich=res[a,4];
                lBDS[a].GiaBan=res[a,5];
            }
        }
        public void Them()
        {
            Console.Write("So sinh vien can them: ");
            int n=int.Parse(Console.ReadLine());
            for (int sv=0;sv<n;sv++)
            {
                int row=lBDS.Length;
                Console.Write("Ma BDS: ");
                lBDS[sv+row].MaBDS=Console.ReadLine();
                Console.Write("Ten BDS: ");
                lBDS[sv+row].TenBDS=Console.ReadLine();
                Console.Write("Huong: ");
                lBDS[sv+row].Huong=Console.ReadLine();
                Console.Write("Dia chi: ");
                lBDS[sv+row].Dchi=Console.ReadLine();
                Console.Write("Dien tich: ");
                lBDS[sv+row].Dtich=Console.ReadLine();
                Console.Write("Gia ban: ");
                lBDS[sv+row].GiaBan=Console.ReadLine();
            }
        }
        public void Sua()
        {
            Console.Write("Nhap Ma BDS can sua: ");
            string id = Console.ReadLine();
            // for (int i=0;i<lBDS.Length;i++)
            // {
            //     if (id == lBDS[i].MaBDS)
            //     {
            //         Console.write(" Vui long nhap thong tin BDS");
            //         Console.write("Ten BDS: ");
            //         lBDS[i].TenBDS = Console.Readline();
            //         Console.write("Huong: ");
            //         lBDS[i].Huong = Console.Readline();
            //         Console.write("Dia chi: ");
            //         lBDS[i].Dchi = Console.Readline();
            //         Console.write("Dien tich: ");
            //         lBDS[i].Dtich = Console.Readline();
            //         Console.write("Gia ban: ");
            //         lBDS[i].GiaBan = Console.Readline();
            //         break;
            //     }
            // }
            for (int i=0;i<lBDS.Length;i++)
            {
                if(id==lBDS[i].MaBDS)
                {
                    Console.Write(" Vui long nhap thong tin BDS");
                    Console.Write("Ten BDS: ");
                    string name= Console.ReadLine();
                    if (name.Length > 0)
                    {
                        lBDS[i].TenBDS = name;
                    }
                    Console.Write("Huong: ");
                    string huong = Console.ReadLine();
                    if (huong != null && huong.Length > 0)
                    {
                        lBDS[i].Huong = huong;
                    }
                    Console.Write("Dia chi: ");
                    string dchi = Console.ReadLine();
                    if (dchi != null && dchi.Length > 0)
                    {
                        lBDS[i].Dchi = dchi;
                    }
                    Console.Write("Dien tich: ");
                    string s = Console.ReadLine();
                    if (s != null && s.Length > 0)
                    {
                        lBDS[i].Dtich = s;
                    }
                    Console.Write("Gia ban: ");
                    string gia = Console.ReadLine();
                    if (gia != null && gia.Length > 0)
                    {
                        lBDS[i].GiaBan = gia;
                    }
                }
            }
        }
        public void Xoa()
        {
            Console.Write("Nhap Ma BDS can xoa: ");
            string id = Console.ReadLine();
            for (int i=0;i<lBDS.Length;i++)
            {
                if(id==lBDS[i].MaBDS)
                {
                    lBDS[i].MaBDS=null;
                    lBDS[i].TenBDS=null;
                    lBDS[i].Huong=null;
                    lBDS[i].Dchi=null;
                    lBDS[i].Dtich=null;
                    lBDS[i].GiaBan=null;
                }
            }
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-8}| {1,-9}| {2,-10}| {3,-20}| {4,10}| {5,10}","Ma BDS","Ten BDS","Huong","Dia chi","Dien tich","Gia ban");
            foreach (BatDongSan bds in lBDS)
            {
                Console.WriteLine("{0,-8}| {1,-9}| {2,-10}| {3,-20}| {4,10}| {5,10}",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Dchi,bds.Dtich,bds.GiaBan);
            }
        }
        public void FindName()
        {
            Console.Write("Ten BDS can tim: ");
            string name = Console.ReadLine();
            Console.WriteLine("{0,-8}| {1,-9}| {2,-10}| {3,-20}| {4,10}| {5,10}","Ma BDS","Ten BDS","Huong","Dia chi","Dien tich","Gia ban");
            foreach (BatDongSan bds in lBDS)
            {
                if (name == bds.TenBDS)
                {
                    Console.WriteLine("{0,-8}| {1,-9}| {2,-10}| {3,-20}| {4,10}| {5,10}",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Dchi,bds.Dtich,bds.GiaBan);
                }
            }
        }
        public void Find_Huong()
        {
            Console.Write("Huong: ");
            string huong = Console.ReadLine();
            Console.WriteLine("{0,-8}| {1,-9}| {2,-10}| {3,-20}| {4,10}| {5,10}","Ma BDS","Ten BDS","Huong","Dia chi","Dien tich","Gia ban");
            foreach (BatDongSan bds in lBDS)
            {
                if (huong == bds.Huong)
                {
                    Console.WriteLine("{0,-8}| {1,-9}| {2,-10}| {3,-20}| {4,10}| {5,10}",bds.MaBDS,bds.TenBDS,bds.Huong,bds.Dchi,bds.Dtich,bds.GiaBan);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachBDS ds=new DanhSachBDS();
            ds.Nhap();
            while (true)
            {
                Console.WriteLine(" ________________________________");
                Console.WriteLine("|             MENU               |");
                Console.WriteLine("|________________________________|");
                Console.WriteLine("|    Bam 1: Them moi danh sach   |");
                Console.WriteLine("|    Bam 2: Sua thong tinh       |");
                Console.WriteLine("|    Bam 3: Xoa thong tin        |");
                Console.WriteLine("|    Bam 4: Xuat danh sach       |");
                Console.WriteLine("|    Bam 5: Tim theo Ten         |");
                Console.WriteLine("|    Bam 6: Tim theo Huong       |");
                Console.WriteLine("|    Bam 7: Tim theo Gia         |");
                Console.WriteLine("|    Bam 0: Exit                 |");
                Console.WriteLine("|________________________________|");
                Console.Write("Moi ban chon chuc nang: ");
                int cn=int.Parse(Console.ReadLine());
                if (cn==1)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("| THEM MOI BAT DONG SAN |");
                    Console.WriteLine("|_______________________|");
                    ds.Them();
                }
                else if (cn==2)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|     SUA THONG TIN     |");
                    Console.WriteLine("|_______________________|");
                    ds.Sua();
                }
                else if (cn==3)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|     XOA THONG TIN     |");
                    Console.WriteLine("|_______________________|");
                    ds.Xoa();
                }
                else if (cn==4)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|     XUAT DANH SACH    |");
                    Console.WriteLine("|_______________________|");
                    ds.Xuat();
                }
                else if (cn==5)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|     TIM THEO TEN      |");
                    Console.WriteLine("|_______________________|");
                    ds.FindName();
                }
                else if (cn==6)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|    TIM THEO HUONG     |");
                    Console.WriteLine("|_______________________|");
                    ds.Find_Huong();
                }
                // else if (cn==7)
                // {
                //     Console.WriteLine(" _______________________");
                //     Console.WriteLine("|     TIM THEO GIA      |");
                //     Console.WriteLine("|_______________________|");
                //     ds.FindPrice();
                // }
                else if (cn==0)
                {
                    Console.WriteLine(" _______________________");
                    Console.WriteLine("|         EXIT          |");
                    Console.WriteLine("|_______________________|");
                    break;
                }
            }
        }
    }
}