// using System;
// namespace HOTEL
// {
//     class room
//     {
//         private string tenkhach;
//         private string cmnd;
//         private int songaythue;
//         private int price;
//         public int pay;
//         public string TenKhach
//         {
//             get {return tenkhach;}
//             set {tenkhach = value;}
//         }
//         public string CMND
//         {
//             get {return cmnd;}
//             set {cmnd = value;}
//         }
//         public int SoNgayThue
//         {
//             get {return songaythue;}
//             set {songaythue = value;}
//         }
//         public int Price
//         {
//             get {return price;}
//             set {price = value;}
//         }
//         public int Pay
//         {
//             get {return pay;}
//             set {pay = value;}
//         }
//         public void Nhap()
//         {
//             Console.Write("Ten khach hang: ");
//             TenKhach = Console.ReadLine();
//             Console.Write("So CMND: ");
//             CMND = Console.ReadLine();
//             Console.Write("So ngay thue: ");
//             SoNgayThue = int.Parse(Console.ReadLine());
//         }
//         public virtual void Xuat()
//         {
//             Console.WriteLine("*** IN HOA DON ***");
//             Console.WriteLine("Don gia: "+Price);
//             Console.WriteLine("Thanh tien: "+Pay);
//         }
//     }
//     class Standard:room
//     {
//         public static int dem;
//         private static int s_standard;
//         public int sStandard
//         {
//             get {return s_standard;}
//             set { s_standard = value;}
//         }
//         public new void Nhap()
//         {
//             dem++;
//             Console.WriteLine("Nhap thong tin khach thue phong Standard thu "+dem);
//             base.Nhap();
//             if (SoNgayThue<5)
//             {
//                 Price = 500;
//             }
//             else
//             {
//                 Price = 400;
//             }
//             Pay = SoNgayThue*Price;
//             sStandard += Pay;
//         }
//         public override void Xuat()
//         {
//             base.Xuat();
//         }
//     }
//     class VIP:room
//     {
//         public static int dem;
//         private static int s_vip;
//         public int sVIP
//         {
//             get {return s_vip;}
//             set { s_vip = value;}
//         }
//         private string loaiphong;
//         public string LoaiPhong
//         {
//             get {return loaiphong;}
//             set {loaiphong = value;}
//         }
//         public new void Nhap()
//         {
//             dem++;
//             Console.WriteLine("Nhap thong tin khach thue phong VIP thu "+dem);
//             base.Nhap();
//             Console.Write("Loai phong: ");
//             LoaiPhong = Console.ReadLine();
//             if (SoNgayThue<5)
//             {
//                 if (LoaiPhong == "Luxury")
//                 {
//                     Price = 1100;
//                 }
//                 else if (LoaiPhong == "President")
//                 {
//                     Price = 1300;
//                 }
//             }
//             else
//             {
//                 Price = 1000;
//             }
//             Pay = SoNgayThue*Price;
//             sVIP += Pay;
//         }
//         public override void Xuat()
//         {
//             base.Xuat();
//             Console.WriteLine("Loai phong: "+LoaiPhong);
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] name = new string[10];
//             Standard Sroom1 = new Standard();
//             name[0] = Sroom1.TenKhach;
//             Standard Sroom2 = new Standard();
//             name[1] = Sroom2.TenKhach;
//             VIP Vroom1 = new VIP();
//             name[2] = Vroom1.TenKhach;
//             VIP Vroom2 = new VIP();
//             name[3] = Vroom2.TenKhach;
//             VIP Vroom3 = new VIP();
//             name[4] = Vroom3.TenKhach;
//             Console.WriteLine("*** STANDARD ROOM ***");
//             Sroom1.Nhap();
//             Sroom1.Xuat();
//             Console.WriteLine("-------------------------------");
//             Sroom2.Nhap();
//             Sroom2.Xuat();
//             Console.WriteLine("-------------------------------");
//             Console.WriteLine("Doanh thu phong Standard: "+Sroom2.sStandard);
//             Console.WriteLine("===============================");
//             Console.WriteLine("*** VIP ROOM ***");
//             Vroom1.Nhap();
//             Vroom1.Xuat();
//             Console.WriteLine("-------------------------------");
//             Vroom2.Nhap();
//             Vroom2.Xuat();
//             Console.WriteLine("-------------------------------");
//             Vroom3.Nhap();
//             Vroom3.Xuat();
//             Console.WriteLine("-------------------------------");
//             Console.WriteLine("Doanh thu phong VIP: "+Vroom3.sVIP);
//             Console.WriteLine("===============================");
//             Console.WriteLine("Doanh thu khach san: "+(Sroom2.sStandard+Vroom3.sVIP));
//             Console.WriteLine("*** SAP XEP DANH SACH THEO TEN ***");
//             Array.Sort(name);
            
//         }
//     }
// }