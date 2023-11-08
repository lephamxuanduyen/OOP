// namespace Bai1_Chuong4
// {
//     class PhanSo
//     {
//         private int tu;
//         private int mau;
//         public int Tu
//         {
//             get{return tu;}
//             set{tu=value;}
//         }
//         public int Mau
//         {
//             get{return mau;}
//             set{mau=value;}
//         }
//         public void Nhap(int i)
//         {
//             Console.Write("Phan so thu "+i+": ");
//             var ps=Console.ReadLine();
//             var tach=ps.Split("/");
//             Tu=int.Parse(tach[0]);
//             Mau=int.Parse(tach[1]);
//         }
//         public string Cong(int TuA,int MauA, int TuB, int MauB)
//         {
//             int tu=0, mau=0;
//             string kq;
//             if (MauA==MauB)
//             {
//                 tu=TuA+TuB;
//                 mau=MauA;
//             }
//             else
//             {
//                 tu=TuA*MauB+TuB*MauA;
//                 mau=MauA*MauB;
//             }
//             if (Math.Abs(tu)==Math.Abs(mau))
//             {
//                 int KQ=tu/mau;
//                 kq=Convert.ToString(KQ);
//             }
//             else
//             {
//                 if (Math.Abs(tu)<Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(tu);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                         // 4/12
//                     }
//                 }
//                 else if (Math.Abs(tu)>Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(mau);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 string tu_str= Convert.ToString(tu);
//                 string mau_str= Convert.ToString(mau);
//                 kq=tu_str+"/"+mau_str;
//             }
//             return kq;
//         }
//         public string Tru(int TuA,int MauA, int TuB, int MauB)
//         {
//             int tu=0, mau=0;
//             string kq;
//             if (MauA==MauB)
//             {
//                 tu=TuA-TuB;
//                 mau=MauA;
//             }
//             else
//             {
//                 tu=TuA*MauB-TuB*MauA;
//                 mau=MauA*MauB;
//             }
//             if (Math.Abs(tu)==Math.Abs(mau))
//             {
//                 int KQ=tu/mau;
//                 kq=Convert.ToString(KQ);
//             }
//             else
//             {
//                 if (Math.Abs(tu)<Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(tu);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 else if (Math.Abs(tu)>Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(mau);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 string tu_str= Convert.ToString(tu);
//                 string mau_str= Convert.ToString(mau);
//                 kq=tu_str+"/"+mau_str;
//             }
//             return kq;
//         }
//         public string Nhan(int TuA,int MauA, int TuB, int MauB)
//         {
//             int tu=0, mau=0;
//             string kq;
//             tu=TuA*TuB;
//             mau=MauA*MauB;
//             if (Math.Abs(tu)==Math.Abs(mau))
//             {
//                 int KQ=tu/mau;
//                 kq=Convert.ToString(KQ);
//             }
//             else
//             {
//                 if (Math.Abs(tu)<Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(tu);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 else if (Math.Abs(tu)>Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(mau);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 // 4/12
//                 string tu_str= Convert.ToString(tu);
//                 string mau_str= Convert.ToString(mau);
//                 kq=tu_str+"/"+mau_str;
//             }
//             return kq;
//         }
//         public string Chia(int TuA,int MauA, int TuB, int MauB)
//         {
//             int tu=0, mau=0;
//             string kq;
//             tu=TuA*MauB;
//             mau=MauA*TuB;
//             if (Math.Abs(tu)==Math.Abs(mau))
//             {
//                 int KQ=tu/mau;
//                 kq=Convert.ToString(KQ);
//             }
//             else
//             {
//                 if (Math.Abs(tu)<Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(tu);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 else if (Math.Abs(tu)>Math.Abs(mau))
//                 {
//                     for (int i=Math.Abs(mau);i>1;i--)
//                     {
//                         if (tu%i==0 & mau%i==0)
//                         {
//                             tu=tu/i;
//                             mau=mau/i;
//                         }
//                     }
//                 }
//                 string tu_str= Convert.ToString(tu);
//                 string mau_str= Convert.ToString(mau);
//                 kq=tu_str+"/"+mau_str;
//             }
//             return kq;
//         }
//         public void Xuat(int TuA,int MauA, int TuB, int MauB)
//         {
//             if (MauA!=0 & MauB!=0)
//             {
//                 Console.WriteLine("*** IN KET QUA ***");
//                 Console.WriteLine("{0}/{1} + {2}/{3} = {4}",TuA,MauA,TuB,MauB,Cong(TuA,MauA,TuB,MauB));
//                 Console.WriteLine("{0}/{1} - {2}/{3} = {4}",TuA,MauA,TuB,MauB,Tru(TuA,MauA,TuB,MauB));
//                 Console.WriteLine("{0}/{1} * {2}/{3} = {4}",TuA,MauA,TuB,MauB,Nhan(TuA,MauA,TuB,MauB));
//                 if (TuB!=0)
//                 {
//                     Console.WriteLine("{0}/{1} / {2}/{3} = {4}",TuA,MauA,TuB,MauB,Chia(TuA,MauA,TuB,MauB));
//                 }
//                 else { Console.WriteLine("Khong the chia mot so cho 0.");}
//             }
//             else {Console.WriteLine("Mau so bat buoc phai khac 0.");}
//         }
//     }
//     class Program
//     {
//         static void Main()
//         {
//             PhanSo PhSA = new PhanSo();
//             PhanSo PhSB = new PhanSo();
//             PhSA.Nhap(1);
//             PhSB.Nhap(2);
//             PhSA.Xuat(PhSA.Tu,PhSA.Mau,PhSB.Tu,PhSB.Mau);
//         }
//     }
// }