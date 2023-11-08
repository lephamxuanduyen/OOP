// using System;
// namespace Bai1_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string HoTen;
//             int a,b,c,max;
//             Console.Write("Ho ten: ");
//             HoTen=Console.ReadLine();
//             Console.Write("a=");
//             a=Convert.ToInt32(Console.ReadLine());
//             Console.Write("b=");
//             b=Convert.ToInt32(Console.ReadLine());
//             Console.Write("c=");
//             c=Convert.ToInt32(Console.ReadLine());

//             max=a;
//             if (max<b) max=b;
//             if (max<c) max=c;
//             Console.Write("Chao ban "+HoTen+", So lon nhat la: "+max);
//             Console.ReadLine();
//         }
//     }
// }

// ---------------------------------------------------------------

// using System;
// namespace Bai2_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float GiaNiemYet, ChietKhau;
//             Console.Write("Nhap Gia  niem yet: ");
//             GiaNiemYet=float.Parse(Console.ReadLine());
//             Console.Write("Nhap Chiet khau: ");
//             ChietKhau=float.Parse(Console.ReadLine());
//             float VAT = (GiaNiemYet - ChietKhau)/100;
//             float GiaBan = GiaNiemYet - ChietKhau + VAT;
//             Console.Write("Gia ban: "+GiaBan);
//             Console.ReadLine();
//         }
//     }
// }

// ------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int P,n;
//             Console.Write("Tien dau tu ban dau: ");
//             P=int.Parse(Console.ReadLine());
//             Console.Write("So thang gui: ");
//             n=int.Parse(Console.ReadLine());
//             Console.Write("Lai suat moi thang: ");
//             float r = float.Parse(Console.ReadLine());
//             float TienLanh = (P*(1+r*n));
//             Console.Write("Tien lanh cuoi ky: "+TienLanh);
//             Console.ReadLine();
//         }
//     }
// }

// -------------------------------------------------------------------
// using System;
// namespace Bai4_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a,b,c;
//             Console.Write("a=");
//             a=int.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=int.Parse(Console.ReadLine());
//             Console.Write("c=");
//             c=int.Parse(Console.ReadLine());
//             float s=(a+b+c)/2;
//             double DienTich=Math.Sqrt(s*(s-a)*(s-b)*(s-c));
//             Console.Write("Dien tich: "+DienTich);
//             Console.ReadLine();
//         }
//     }
// }

// -----------------------------------------------------------------

// using System;
// namespace Bai1_Chuong3_1_IF
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float a,b,c,min,max;
//             Console.Write("a=");
//             a=float.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=float.Parse(Console.ReadLine());
//             Console.Write("c=");
//             c=float.Parse(Console.ReadLine());
//             min=a;
//             max=a;
//             if (min>b) min=b;
//             if (min>c) min=c;
//             if (max<b) max=b;
//             if (max<c) max=c;
//             Console.Write("SLN="+max+"\nSBN="+min);
//             Console.ReadLine();
//         }
//     }
// }

// -----------------------------------------------------------------------------

// using System;
// namespace Bai2_Chuong3_1_IF
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int may;
//             Console.Write("So may=");
//             may=int.Parse(Console.ReadLine());
//             if (may>=5)
//                 Console.WriteLine("So tien="+may*450);
//             else
//                 Console.WriteLine("So may="+may*500);
//             Console.ReadLine();
//         }
//     }
// }

// --------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong3_1_IF
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int TieuThu;
//             Console.Write("Tieu thu=");
//             TieuThu=int.Parse(Console.ReadLine());
//             if (TieuThu>=1 & TieuThu>=100)
//                 Console.Write("Phai tra="+TieuThu*550*1.1);
//             else if (TieuThu>=101 & TieuThu>=150)
//                 Console.Write("Phai tra="+TieuThu*750*1.1);
//             else if (TieuThu>=151 & TieuThu>=200)
//                 Console.Write("Phai tra="+TieuThu*950*1.1);
//             else
//                 Console.Write("Phai tra="+TieuThu*1350*1.1);
//             Console.ReadLine();

//         }
//     }
// }

// -----------------------------------------------------------------------------

// using System;
// namespace Bai1_Chuong3_1_SWIRCHCASE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int so;
//             Console.Write("Hay cho biet mau sac ma ban ua thich\n Nhap <1>: Do\n Nhap <2>: Xanh la\n Nhap <3>: Xanh duong\n Nhap <4>: Trang\n Nhap <5>: Den\nBan chon so: ");
//             so=int.Parse(Console.ReadLine());
//             Console.Write("------------------------------------\n");
//             switch (so)
//             {
//                 case 1:
//                     Console.Write("Ban thich mau: Do");break;
//                 case 2:
//                     Console.Write("Ban thich mau: Xanh la");break;
//                 case 3:
//                     Console.Write("Ban thich mau: Xanh duong");break;
//                 case 4:
//                     Console.Write("Ban thich mau: Trang");break;
//                 default:
//                     Console.Write("Ban thich mau: Den");break;
//             }
//             Console.Write("\n------------------------------------");
//             Console.ReadLine();
//         }
//     }
// }

// ----------------------------------------------------------------------------

// using System;
// namespace Bai2_CHuong3_1_SWITCHCASE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string dk;
//             Console.Write("Nhap so nguyen: ");
//             int so=int.Parse(Console.ReadLine());
//             if (so%2==0) dk="T";
//             else dk="F";
//             switch (dk)
//             {
//                 case "T": Console.Write("X la so chan");break;
//                 default: Console.Write("X la so le");break;
//                 Console.ReadLine();
//             }
//         }
//     }
// }

// -------------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong3_1_SWITCHCASE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Moi ban chon mau: ");
//             string mau=Console.ReadLine();
//             switch (mau)
//             {
//                 case "red": Console.Write("Ban da chon mau do");break;
//                 case "green": Console.Write("Ban da chon mau xanh la");break;
//                 case "yellow": Console.Write("Ban da chon mau vang");break;
//                 case "black": Console.Write("Ban da chon mau den");break;
//                 default: Console.Write("Khong hop le!!!");break;
//                 Console.ReadLine();
//             }
//         }
//     }
// }

// ----------------------------------------------------------------------------------------

// using System;
// namespace Bai1_Chuong3_2_WHILE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n;
//             Console.Write("Nhap so nguyen (n>=1 va n<=50): n=");
//             n=Convert.ToInt32(Console.ReadLine());
//             while (n>50 || n<1)
//             {
//                 Console.Write("Khong hop le!!!\nVui long nhap lai!!!\nn=");
//                 n=int.Parse(Console.ReadLine());
//             }
//         }
//     }
// }

// --------------------------------------------------------------------------------------------

// using System;
// namespace Bai2_Chuong3_2_WHILE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i=1,n;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             while (i<=n)
//             {
//                 Console.Write(i+"\t");
//                 // Console.Write(" ");
//                 i++;
//                 if (i%10==1) Console.WriteLine();
//             }
//             Console.ReadKey();
//         }
//     }
// }

// -------------------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong3_2_WHILE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i=1,j;
//             while (i<=9)
//             {
//                 j=1;
//                 while (j<=9)
//                 {
//                     Console.Write(i*j+"\t");
//                     if (j%9==0) Console.WriteLine();
//                     j++;
//                 }
//                 i++;
//             }
//             Console.ReadKey();
//         }
//     }
// }

// -----------------------------------------------------------

// using System;
// namespace Bai4a_Chuong3_2_WHILE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i,n,j;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             i=n;
//             while (i>=0)
//             {
//                 j=i;
//                 while (j>=0)
//                 {
//                     Console.Write('$');
//                     j--;
//                 }
//                 Console.WriteLine();
//                 i--;
//             }
//             Console.ReadKey();
//         }
//     }
// }

// ---------------------------------------------------------------

// using System;
// namespace Bai4b_Chuong3_2_WHILE
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i,j,k,h=1;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             i=n;
//             while (i>0)
//             {
//                 j=1;
//                 while (j<=i-1)
//                 {
//                     Console.Write(" ");
//                     j++;
//                 } 
//                 k=1;
//                 while (k<=(2*h-1))
//                 {
//                     Console.Write("*");
//                     k++;
//                 }
//                 Console.WriteLine();
//                 h++;
//                 i--;
//             }
//         }
//     }
// }

// ------------------------------------------------------------------

// using System;
// namespace Bai1_Chuong3_2_DoWhile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n;
//             do
//             {
//                 Console.Write("Nhap so nguyen n (1<=<50): ");
//                 n=int.Parse(Console.ReadLine());
//             }
//             while (n<1 || n>50);
//         }
//     }
// }

// -------------------------------------------------------------------------

// using System;
// namespace Bai2_Chuong3_2_DoWhile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i=1;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             do
//             {
//                 Console.Write(i+"\t");
//                 i++;
//                 if (i%10==1) Console.WriteLine();
//             }
//             while (i<=n);
//         }
//     }
// }

// ------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong3_2_DoWhile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i=1,j;
//             do
//             {
//                 j=1;
//                 do
//                 {
//                     Console.Write(i*j+"\t");
//                     j++;
//                 }
//                 while (j<=9);
//                 i++;
//                 Console.WriteLine();
//             }
//             while (i<=9);
//         }
//     }
// }

// ----------------------------------------------------

// using System;
// namespace Bai4a_Chuong3_2_DoWhile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i=1,j,n;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             i=n;
//             do
//             {
//                 j=i;
//                 do
//                 {
//                     Console.Write("*");
//                     j--;
//                 }
//                 while (j>=0);
//                 Console.WriteLine();
//                 i--;
//             }
//             while (i>=0);
//         }
//     }
// }

// ----------------------------------------------------------------

// using System;
// namespace Bai4b_Chuong3_2_DoWhile
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i,j,k=1,h;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             i=n;
//             do
//             {
//                 h=1;
//                 do
//                 {
//                     Console.Write(" ");
//                     h++;
//                 }
//                 while (h<=i);
//                 j=1;
//                 do
//                 {
//                     Console.Write("*");
//                     j++;
//                 }
//                 while (j<=(2*k-1));
//                 i--;
//                 k++;
//                 Console.WriteLine();
//             }
//             while (i>0);
//         }
//     }
// }

// --------------------------------------------------------

// using System;
// namespace Bai2_Chuong3_2_FOR
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             for (i=1;i<=n;i++)
//             {
//                 Console.Write(i+"\t");
//                 if (i%10==0) Console.WriteLine();
//             }
//         }
//     }
// }

// ----------------------------------------------------------------

// using System;
// namespace Bai3_Chuong3_2_FOR
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int i,j;
//             for (i=1;i<=9;i++)
//             {
//                 for (j=1;j<=9;j++)
//                 {
//                     Console.Write(i*j+"\t");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// -----------------------------------------------------

// using System;
// namespace Bai4a_Chuong3_2_FOR
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i,j;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             for (i=n;i>=0;i--)
//             {
//                 for (j=i;j>=0;j--)
//                 {
//                     Console.Write("$");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// ---------------------------------------------------------

// using System;
// namespace Bai4b_Chuong3_2_FOR
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i,j,k;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             for (i=1;i<=n;i++)
//             {
//                 for (j=1;j<=n-i;j++)
//                 {
//                     Console.Write(" ");
//                 }
//                 for (k=1;k<=(2*i-1);k++)
//                 {
//                     Console.Write("*");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// -------------------------------------------------

// using System;
// namespace Bai1_Chuong3_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,gt,i;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             if (n==0) Console.WriteLine("0!=1");
//             else
//             {
//                 gt=1;
//                 for (i=1;i<=n;i++)
//                 {
//                     gt*=i;
//                 } 
//                 Console.WriteLine(n+"!="+gt);
//             }
//         }
//     }
// }

// ----------------------------------------------------------------

// using System;
// namespace Bai2_Chuong3_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,i;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             for (i=2;i<n;i++)
//             {
//                 if (n%i==0)
//                 {
//                     Console.WriteLine(n+" khong la SNT");
//                     break;
//                 }
//             }
//             if (i==n) Console.WriteLine(n+" la SNT");
//         }
//     }
// }

// --------------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong3_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,so=0,m;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             m=n;
//             while (n>=1)
//             {
//                 n/=10;
//                 so++;
//             }
//             Console.Write(m+" co "+so+" chu so");
//         }
//     }
// }

// ---------------------------------------------------------------

// using System;
// namespace Bai4_Chuong3_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 float a,b;
//                 string pt,tt;
//                 Console.Write("a=");
//                 a=float.Parse(Console.ReadLine());
//                 Console.Write("b=");
//                 b=float.Parse(Console.ReadLine());
//                 Console.Write("Toan tu:");
//                 pt=Console.ReadLine();
//                 if (pt=="+") Console.WriteLine(a+"+"+b+"="+(a+b));
//                 else if (pt=="-") Console.WriteLine(a+"-"+b+"="+(a-b));
//                 else if (pt=="*") Console.WriteLine(a+"*"+b+"="+(a*b));
//                 else if (pt=="/") 
//                 {
//                     if (b==0) 
//                     {
//                         Console.WriteLine("Khong hop le!!!");continue;
//                     }
//                     else
//                     {
//                         Console.WriteLine(a+"+"+b+"="+(a+b));
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("Khong hop le!!!");continue;
//                 }
//                 Console.Write("Tiep tuc:");
//                 tt=Console.ReadLine();
//                 if (tt=="t") break;
//             }
//         }
//     }
// }

// --------------------------------------------------------------------------------------

// using System;
// namespace Bai1_Chuong4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             int[] so=new int[n];
//             int i;
//             Console.WriteLine("Hay nhap n so nguyen!");
//             for (i=0;i<n;i++)
//             {
//                 so[i]=int.Parse(Console.ReadLine());
//             }
//             Console.Write("Cac so nguyen da nhap la:");
//             int num;
//             for (num=n-1;num>=0;num--)
//             {
//                 Console.Write(so[num]+" ");
//             }
//         }
//     }
// }

// ------------------------------------------------------------------------
// using System;
// namespace Bai2_Chuong4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] L=new int[100];
//             int i;
//             Console.WriteLine("Moi ban nhap cac so nguyen!\nNeu ban nhap 0 chuong trinh se dung lai va cho ban ket qua.");
//             for (i=0;i<=10;i++)
//             {
//                 int n=int.Parse(Console.ReadLine());
//                 L[i]=n;
//                 if (n==0) break;
//             }
//             int duong=0,am=0;
//             int[] A=new int[100];
//             int[] B=new int[100];
//             foreach (int x in L)
//             {
//                 if (x>0)
//                 {
//                     A[duong]=x;
//                     duong++;
//                 } 
//                 else
//                 {
//                     B[am]=x;
//                     am++;
//                 }
//             }
//             Console.Write ("Cac so nguyen duong la: ");
//             foreach (int SoDuong in A)
//             {
//                 if (SoDuong!=0)
//                 {
//                     Console.Write(SoDuong+" ");
//                 }
//             }
//             Console.Write("\nCac so nguyen am la: ");
//             foreach (int SoAm in B)
//             {
//                 if (SoAm!=0)
//                 {
//                     Console.Write(SoAm+" ");
//                 }
//             }
//         }
//     }
// }

// ----------------------------------------------------------------------

// using System;
// namespace Bai3_Chuong4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,x,y;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             Console.Write("X=");
//             x=int.Parse(Console.ReadLine());
//             Console.Write("Y=");
//             y=int.Parse(Console.ReadLine());
//             int[] A=new int[n];
//             Console.WriteLine("Moi nhap "+n+" so nguyen vao tap hop A");
//             int i,X=0;
//             for (i=0;i<n;i++)
//             {
//                 A[i]=int.Parse(Console.ReadLine());
//             }
//             foreach (int so in A)
//             {
//                 if (so==x)
//                 {
//                     X++;
//                     A[Array.IndexOf(A,2)]=y;
//                 }
//             }
//             Console.WriteLine("So "+x+" xuat hien trong tap hop A "+X+" lan");
//             Console.WriteLine("Tap hop A viet lai.");
//             foreach (int a in A) Console.Write(a+" ");
//         }
//     }
// }

// ---------------------------------------------------------------------------------------------

// using System;
// namespace Bai1_Chuong4_Mang2Chieu
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int m,n;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             Console.Write("m=");
//             m=int.Parse(Console.ReadLine());
//             int [,] A=new int[n,m];
//             int [,] B=new int[n,m];
//             int s=0;
//             for (int i=0;i<n;i++)
//             {
//                 for (int j=0; j<m; j++)
//                 {
//                     Console.Write("Nhap A[{0},{1}] = ",i,j);
//                     A[i,j]=int.Parse(Console.ReadLine());
//                     s+=A[i,j];
//                 }
//             }
//             for (int h=0;h<n;h++)
//             {
//                 for (int k=0; k<m; k++)
//                 {
//                     Console.Write("Nhap B[{0},{1}] = ",h,k);
//                     B[h,k]=int.Parse(Console.ReadLine());
//                     s+=B[h,k];
//                 }
//             }
//             Console.WriteLine("Tong cua hai ma tran A va B la: "+s);
//         }
//     }
// }

// --------------------------------------------------------------------------------

// using System;
// namespace Bai2_Chuong4_Mang2Chieu
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Lop ban co bao nhieu hoc sinh? ");
//             int n=int.Parse(Console.ReadLine());
//             int[,] A=new int[2,n];
//             for (int j=0; j<n; j++)
//             {
//                 Console.WriteLine("- Hoc sinh thu "+(j+1)+":");
//                 Console.Write("   + Diem Toan: ");
//                 int toan=int.Parse(Console.ReadLine());
//                 Console.Write("   + Diem Ly: ");
//                 int ly=int.Parse(Console.ReadLine());
//                 A[0,j]=toan;
//                 A[1,j]=ly;
//             }
//             for (int h=0; h<n;h++)
//             {
//                 float s=(A[0,h]+A[1,h]);
//                 Console.WriteLine("Diem trung binh hoc tap cua hoc sinh thu "+(h+1)+" la: "+(s/2));
//             }
//         }
//     }
// }

// ----------------------------------------------------------------------------------------------------------------
// namespace Bai1_Chuong4
// {
//     class PhanSo
//     {
//         private int tuA;
//         private int mauA;
//         private int tuB;
//         private int mauB;
//         public int TuA
//         {
//             get {return tuA;}
//             set {tuA=value;}
//         }
//         public int TuB
//         {
//             get {return tuB;}
//             set {tuB=value;}
//         }
//         public int MauA
//         {
//             get {return mauA;}
//             set 
//             {
//                 if (value!=0) {mauA=value;} //khong co mau = 0
//             }
//         }
//         public int MauB
//         {
//             get {return mauB;}
//             set 
//             {
//                 if (value!=0) {mauB=value;} //khong co mau = 0
//             }
//         }
//         public string Cong()
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
//                     for (int i=1;i<=Math.Abs(tu);i++)
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
//                     for (int i=1;i<=Math.Abs(mau);i++)
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
//         public string Tru()
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
//                     for (int i=1;i<=Math.Abs(tu);i++)
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
//                     for (int i=1;i<=Math.Abs(mau);i++)
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
//         public string Nhan()
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
//                     for (int i=1;i<=Math.Abs(tu);i++)
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
//                     for (int i=1;i<=Math.Abs(mau);i++)
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
//         public string Chia()
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
//                     for (int i=1;i<=Math.Abs(tu);i++)
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
//                     for (int i=1;i<=Math.Abs(mau);i++)
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
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             PhanSo PhS = new PhanSo();
//             Console.WriteLine("Moi nhap phan so A (a/b)");
//             Console.Write("a = ");
//             PhS.TuA = int.Parse(Console.ReadLine());
//             Console.Write("b = ");
//             PhS.MauA = int.Parse(Console.ReadLine());
//             Console.WriteLine("Moi nhap phan so B (c/d)");
//             Console.Write("c = ");
//             PhS.TuB = int.Parse(Console.ReadLine());
//             Console.Write("d = ");
//             PhS.MauB = int.Parse(Console.ReadLine());
//             if (PhS.MauA!=0 & PhS.MauB!=0)
//             {
//             Console.WriteLine("*** IN KET QUA ***");
//             Console.WriteLine("{0}/{1} + {2}/{3} = {4}",PhS.TuA,PhS.MauA,PhS.TuB,PhS.MauB,PhS.Cong());
//             Console.WriteLine("{0}/{1} - {2}/{3} = {4}",PhS.TuA,PhS.MauA,PhS.TuB,PhS.MauB,PhS.Tru());
//             Console.WriteLine("{0}/{1} * {2}/{3} = {4}",PhS.TuA,PhS.MauA,PhS.TuB,PhS.MauB,PhS.Nhan());
//             if (PhS.TuB!=0)
//             {
//             Console.WriteLine("{0}/{1} / {2}/{3} = {4}",PhS.TuA,PhS.MauA,PhS.TuB,PhS.MauB,PhS.Chia());
//             }
//             else { Console.WriteLine("Phan tu B = 0 => Khong thuc hien duoc phep tinh chia.");}
//             }
//             else {Console.WriteLine("Mau so bat buoc phai khac 0.");}
//         }
//     }
// }
