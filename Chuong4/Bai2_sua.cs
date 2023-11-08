// namespace bai2_chuong4
// {
//     class SoPhuc
//     {
//         private int sothuc;
//         private int soao;
//         public int SoThuc
//         { 
//             get {return sothuc;}
//             set {sothuc = value;}
//         }
//         public int SoAo
//         {
//             get {return soao;}
//             set {soao = value;}
//         }
//         public string Cong(int ThucA, int AoA, int ThucB, int AoB)
//         {
//             string thuc,ao,kq,dau;
//             thuc=Convert.ToString(ThucA+ThucB);
//             if (AoA+AoB>=0) {dau="+";}
//             else {dau="";}
//             ao=Convert.ToString(AoA+AoB);
//             kq=thuc+" "+dau+ao+"i";
//             return kq;
//         }
//         public string Tru(int ThucA, int AoA, int ThucB, int AoB)
//         {
//             string thuc,ao,kq,dau;
//             thuc=Convert.ToString(ThucA-ThucB);
//             if (AoA-AoB>=0) {dau="+";}
//             else {dau="";}
//             ao=Convert.ToString(AoA-AoB);
//             kq=thuc+" "+dau+ao+"i";
//             return kq;
//         }
//         public string Nhan(int ThucA, int AoA, int ThucB, int AoB)
//         {
//             string thuc,ao,kq,dau;
//             thuc=Convert.ToString(ThucA*ThucB-AoA*AoB);
//             if (ThucA*AoB+ThucB*AoA>=0) {dau="+";}
//             else {dau="";}
//             ao=Convert.ToString(ThucA*AoB+ThucB*AoA);
//             kq=thuc+" "+dau+ao+"i";
//             return kq;
//         }
//         public string Chia(int ThucA, int AoA, int ThucB, int AoB)
//         {
//             string thuc,ao,kq,dau;
//             double th=(ThucA*ThucB+AoA*AoB)/(Math.Pow(ThucB,2)+Math.Pow(AoB,2));
//             double ao_i=(ThucB*AoA-ThucA*AoB)/(Math.Pow(ThucB,2)+Math.Pow(AoB,2));
//             if (th!=(int) th)
//             {
//                 int tu1=(ThucA*ThucB+AoA*AoB);
//                 double mau=Math.Pow(ThucB,2)+Math.Pow(AoB,2);
//                 int mau1=(int)mau;
//                 if(tu1<mau1)
//                 {
//                     for (int i=1;i<tu1;i++)
//                     {
//                         if (tu1%i==0 & mau1%i==0)
//                         {
//                             tu1=tu1/i;
//                             mau1=mau1/i;
//                         }
//                     }
//                 }
//                 else if(tu1>mau1)
//                 {
//                     for (int i=1;i<mau1;i++)
//                     {
//                         if (tu1%i==0 & mau1%i==0)
//                         {
//                             tu1=tu1/i;
//                             mau1=mau1/i;
//                         }
//                     }
//                 }
//                 else {tu1=mau1=1;}
//                 string tu1_str=Convert.ToString(tu1);
//                 string mau1_str=Convert.ToString(mau1);
//                 thuc=tu1_str+"/"+mau1_str;
//             }
//             else {thuc=Convert.ToString((ThucA*ThucB+AoA*AoB)/(Math.Pow(ThucB,2)+Math.Pow(AoB,2)));}
//             if (ao_i!=(int) ao_i)
//             {
//                 int tu2=ThucB*AoA-ThucA*AoB;
//                 double mau=Math.Pow(ThucB,2)+Math.Pow(AoB,2);
//                 int mau2=(int)mau;
//                 if(tu2<mau2)
//                 {
//                     for (int i=1;i<tu2;i++)
//                     {
//                         if (tu2%i==0 & mau2%i==0)
//                         {
//                             tu2=tu2/i;
//                             mau2=mau2/i;
//                         }
//                     }
//                 }
//                 else if(tu2>mau2)
//                 {
//                     for (int i=1;i<mau2;i++)
//                     {
//                         if (tu2%i==0 & mau2%i==0)
//                         {
//                             tu2=tu2/i;
//                             mau2=mau2/i;
//                         }
//                     }
//                 }
//                 else {tu2=mau2=1;}
//                 string tu2_str=Convert.ToString(tu2);
//                 string mau2_str=Convert.ToString(mau2);
//                 string d="";
//                 if (tu2*mau2>=0) {d="+";}
//                 ao=d+tu2_str+"/"+mau2_str;
//             }
//             else {ao=Convert.ToString((ThucB*AoA-ThucA*AoB)/(Math.Pow(ThucB,2)+Math.Pow(AoB,2)));}
//             if ((ThucA*ThucB+AoA*AoB)>=0) {dau="+";}
//             else {dau="";}
//             kq=thuc+" "+dau+ao+"i";
//             return kq;
//         }
//         public void Nhap(int i)
//         {
//             Console.Write("So phuc thu "+i+": ");
//             var A=Console.ReadLine();
//             var a_bi=A.Split(" ");
//             sothuc=int.Parse(a_bi[0]);
//             var bi=a_bi[1];
//             var b_i=bi.Split("i");
//             SoAo=int.Parse(b_i[0]);
//         }
//         public void Xuat(int ThucA, int AoA, int ThucB, int AoB)
//         {
//             Console.WriteLine("**** IN KET QUA ****");
//             string dau1="",dau2="";
//             if (AoA>=0) dau1="+";
//             if (AoB>=0) dau2="+";
//             Console.WriteLine("({0} {1}{2}i) + ({3} {4}{5}i) = ({6})",ThucA,dau1,AoA,ThucB,dau2,AoB,Cong(ThucA, AoA, ThucB, AoB));
//             Console.WriteLine("({0} {1}{2}i) - ({3} {4}{5}i) = ({6})",ThucA,dau1,AoA,ThucB,dau2,AoB,Tru(ThucA, AoA, ThucB, AoB));
//             Console.WriteLine("({0} {1}{2}i) * ({3} {4}{5}i) = ({6})",ThucA,dau1,AoA,ThucB,dau2,AoB,Nhan(ThucA, AoA, ThucB, AoB));
//             if (ThucA==0 & ThucB==0) {Console.WriteLine("Khong the thuc hien phep chia.");}
//             else {Console.WriteLine("({0} {1}{2}i) / ({3} {4}{5}i) = ({6})",ThucA,dau1,AoA,ThucB,dau2,AoB,Chia(ThucA, AoA, ThucB, AoB));}
//         }
//         // ((a+bi)/(c+di)=((ca+db)/(c^2+d^2))+((cb-da)/(c^2+d^2))i
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             SoPhuc sp1=new SoPhuc();
//             SoPhuc sp2=new SoPhuc();
//             sp1.Nhap(1);
//             sp2.Nhap(2);
//             sp1.Xuat(sp1.SoThuc,sp1.SoAo,sp2.SoThuc,sp2.SoAo);
//         }
//     }
// }