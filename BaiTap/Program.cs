// using System;
// namespace Bai1_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string HoTen;
//             Console.Write("Nhap ho ten: ");
//             HoTen=Console.ReadLine();
//             Console.Write("Chao ban "+HoTen+"!!!");
//             Console.ReadLine();
//         }
//     }
// }

// -------------------------------------------------------------

// using System;
// namespace Bai2_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int r;
//             Console.Write("Nhap vao ban kinh cua duong tron: ");
//             r=int.Parse(Console.ReadLine());
//             double DienTich=Math.PI*Math.Pow(r, 2);
//             double ChuVi=2*r*Math.PI;
//             Console.WriteLine("Dien tich cua duong tron co ban kinh "+r+" la = "+Math.Round(DienTich,1));
//             Console.WriteLine("Chu vi cua duong tron co ban kinh "+r+" la = "+Math.Round(ChuVi,1));
//             Console.ReadLine();
//         }
//     }
// }

// ----------------------------------------------------------------------------------------------------------------------

// using System;
// namespace Bai3.Bai3_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a,b;
//             Console.WriteLine("Nhap hai canh ke cua tam giac vuong:");
//             a=int.Parse(Console.ReadLine());
//             b=int.Parse(Console.ReadLine());
//             double c=Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
//             Console.Write("Canh ke thu nhat la: "+a+", canh ke thu hai: "+b+", co canh huyen = "+Math.Round(c,2));
//             Console.ReadLine();
//         }
//     }
// }

// -------------------------------------------------------------------------------------------------------------------------------

// using System;
// namespace Bai4_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a,b,c,d;
//             Console.Write("a=");
//             a=int.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=int.Parse(Console.ReadLine());
//             Console.Write("c=");
//             c=int.Parse(Console.ReadLine());
//             Console.Write("d=");
//             d=int.Parse(Console.ReadLine());
//             int Tong=a+b+c+d;
//             float tbc=Tong/4;
//             Console.WriteLine("Tong = "+Tong);
//             Console.Write("Trung binh cong = "+tbc);
//             Console.ReadLine();
//         }
//     }
// }

// ----------------------------------------------------------------------

// using System;
// namespace Bai5_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int TienGui,thang;
//             Console.Write("So tien ban dau: ");
//             TienGui=int.Parse(Console.ReadLine());
//             Console.Write("So thang gui: ");
//             thang=int.Parse(Console.ReadLine());
//             Console.Write("Lai suat/ thang: ");
//             float r=float.Parse(Console.ReadLine());
//             Console.WriteLine("Voi so tien ban dau "+TienGui+", sau "+thang+" thang gui, lai suat "+r+"/ thang");
//             Console.WriteLine("Thi so tien nhan duoc cuoi ky la: "+TienGui*(1+thang*r));
//             Console.ReadLine();
//         }
//     }
// }

// ---------------------------------------------------------------------------------------------------------------------------

// using System;
// namespace Bai6_Chuong2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int DonGiaNgayCong,SoNgayCong,TienTamUng;
//             Console.Write("Ho ten: ");
//             string HoTen=Console.ReadLine();
//             Console.Write("So Ngay cong: ");
//             SoNgayCong=int.Parse(Console.ReadLine());
//             Console.Write("Don gia ngay cong: ");
//             DonGiaNgayCong=int.Parse(Console.ReadLine());
//             Console.Write("He so phu cap: ");
//             float HeSoPhuCap=float.Parse(Console.ReadLine());
//             Console.Write("Tam ung: ");
//             TienTamUng=int.Parse(Console.ReadLine());
//             float luong=DonGiaNgayCong*SoNgayCong*HeSoPhuCap;
//             Console.Write("Nhan vien "+HoTen+", Co tien luong="+luong+", Tam ung= "+TienTamUng+" va thuc linh = "+(luong-TienTamUng));
//             Console.ReadLine();
//         }

//     }
// }

// -----------------------------------------------------------------------------------------------------------------------------------------------------

// using System;
// namespace Bai3_1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float a,b,c;
//             Console.Write("a=");
//             a=int.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=int.Parse(Console.ReadLine());
//             Console.Write("c=");
//             c=int.Parse(Console.ReadLine());
//             if (a+b>c & b+c>a & a+c>b)
//             {
//                 float s=(a+b+c)/2;
//                 double DienTich=Math.Sqrt(s*(s-a)*(s-b)*(s-c));
//                 Console.WriteLine("Dien tich="+Math.Round(DienTich,3));
//             }
//             else Console.WriteLine("Khong hop le");
//         }
//     }
// }

// ------------------------------------------------------------------------------------

// using System;
// namespace Bai3_2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int M1,M2,M3,s;
//             Console.Write("M1=");
//             M1=int.Parse(Console.ReadLine());
//             Console.Write("M2=");
//             M2=int.Parse(Console.ReadLine());
//             Console.Write("M3=");
//             M3=int.Parse(Console.ReadLine());
//             Console.Write("S=");
//             s=int.Parse(Console.ReadLine());
//             Console.Write("Phai tra=");
//             if (s>0 & s<=100) Console.WriteLine(M1*s);
//             else if (s>100 & s<=150) Console.WriteLine(100*M1+(s-100)*M2);
//             else Console.WriteLine(M1*100+50*M2+(s-150)*M3);
//         }
//     }
// }

// -------------------------------------------------------------------------------------

// using System;
// namespace Bai3_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float x,y;
//             Console.Write("x=");
//             x=float.Parse(Console.ReadLine());
//             Console.Write("y=");
//             y=float.Parse(Console.ReadLine());
//             Console.Write("Phep toan:");
//             string ch=Console.ReadLine();
//             if (ch=="+") Console.WriteLine(x+"+"+y+"="+(x+y));
//             else if (ch=="-") Console.WriteLine(x+"-"+y+"="+(x-y));
//             else if (ch=="*") Console.WriteLine(x+"*"+y+"="+(x*y));
//             else
//             {
//                 if (y==0) Console.WriteLine("Khong hop le");
//                 else Console.WriteLine(x+"/"+y+"="+(x/y));
//             }
//         }
//     }
// }

// --------------------------------------------------------------------------------

// using System;
// namespace Bai3_4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             float t,l,h;
//             t=float.Parse(Console.ReadLine());
//             l=float.Parse(Console.ReadLine());
//             h=float.Parse(Console.ReadLine());
//             float tbc=(t*2+l*3+h)/6;
//             if (tbc<3) Console.WriteLine("Kem");
//             else if (tbc>=3 & tbc<5) Console.WriteLine("Yeu");
//             else if (tbc>=5 & tbc<6) Console.WriteLine("Trung binh");
//             else if (tbc>=6 & tbc<7) Console.WriteLine("Trung binh Kha");
//             else if (tbc>=7 & tbc<8) Console.WriteLine("Kha");
//             else if (tbc>=8 & tbc<9) Console.WriteLine("Gioi");
//             else Console.WriteLine("Xuat sac");
//         }        
//     }
// }

// ---------------------------------------------------------------------------------------

// using System;
// namespace Bai3_5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int nghi=int.Parse(Console.ReadLine());
//             Console.Write("Xep loai ");
//             if (nghi==0) Console.WriteLine("A");
//             else if (nghi>0 & nghi<2) Console.WriteLine("B");
//             else if (nghi>=2 & nghi<4) Console.WriteLine("C");
//             else Console.WriteLine("D");
//         }
//     }
// }

// -------------------------------------------------------------------------

// using System;
// namespace Bai3_6
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a=int.Parse(Console.ReadLine());
//             int b=int.Parse(Console.ReadLine());
//             int c=int.Parse(Console.ReadLine());
//             if (a+b>c & a+c>b & b+c>a)
//             {
//                 if (a==b & a==c & b==c) Console.WriteLine("Tam giac deu");
//                 else if ((a*a==b*b+c*c) || (b*b==a*a+c*c) || (c*c==a*a+b*b)) Console.WriteLine("Tam giac vuong");
//                 else Console.WriteLine("Tam giac loai khac");
//             }
//             else Console.WriteLine("Khong hop le");
//         }
//     }
// }

// -------------------------------------------------------------------------------------------------------------------------------
// using System;
// namespace Bai3_7a
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.Write("n=");
//                 int n=int.Parse(Console.ReadLine());
//                 int i=1,gt=1;
//                 if (n==0) Console.WriteLine("n!=1");
//                 else if (n<0) break;
//                 else
//                 {
//                     while (i<=n)
//                     {
//                         gt*=i;
//                         i++;
//                     }
//                     Console.WriteLine("n!="+gt);
//                 }
//             }
//         }
//     }
// }

// -------------------------------------------------------------------------

// using System;
// namespace Bai3_7a1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             do
//             {
//                 Console.Write("n=");
//                 int n=int.Parse(Console.ReadLine());
//                 if (n<0) break;
//                 else if (n==0) Console.WriteLine("n!=1");
//                 else
//                 {
//                     int i=1,gt=1;
//                     do
//                     {
//                         gt*=i;
//                         i++;
//                     }
//                     while (i<=n);
//                     Console.WriteLine("n!="+gt);
//                 }
//             }
//             while (true);
//         }
//     }
// }

// -----------------------------------------------------------------

// using System;
// namespace Bai3_7b
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 Console.Write("n=");
//                 int n=int.Parse(Console.ReadLine());
//                 if (n<0) break;
//                 else if (n==0) Console.WriteLine("n!=1");
//                 else
//                 {
//                     int gt=1;
//                     for (int i=1;i<=n;i++)
//                     {
//                         gt*=i;
//                     }
//                     Console.WriteLine("n!="+gt);                
//                 }
//             }
//         }
//     }
// }

// ---------------------------------------------------------------------------

// using System;
// namespace Bai3_8
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string dau=Console.ReadLine();
//             int n=int.Parse(Console.ReadLine());
//             int i=1;
//             while (i<=n)
//             {
//                 int j=1;
//                 while (j<=i)
//                 {
//                     Console.Write(dau);
//                     j++;
//                 }
//                 i++;
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// ------------------------------------------------------

// using System;
// namespace Bai3_9a
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n=int.Parse(Console.ReadLine());
//             int i=2;
//             while (i<=n)
//             {
//                 Console.Write(i+" ");
//                 i+=2;
//             }
//         }
//     }
// }

// ---------------------------------------------------------------

// using System;
// namespace bai3_9b
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n=int.Parse(Console.ReadLine());
//             int i;
//             for (i=2;i<=n;i+=2)
//             {
//                 Console.Write(i+" ");
//             }
//         }
//     }
// }

// -------------------------------------------------------

// using System;
// namespace Bai3_10a
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             int i;
//             for (i=1;i<=n;i++) Console.WriteLine(i);
//         }
//     }
// }

// ------------------------------------------------------------------

// using System;
// namespace Bai3_10b
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             int i;
//             for (i=1;i<=n;i++)
//             {
//                 Console.Write(i+" ");
//                 if (i%5==0) Console.WriteLine();
//             }
//         }
//     }
// }

// -------------------------------------------------------------

// using System;
// namespace Bai3_10c
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             int i,j;
//             for (i=1;i<=n;i++)
//             {
//                 for (j=1;j<=n;j++)
//                 {
//                     Console.Write(j+" ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// --------------------------------------------------------------

// using System;
// namespace Bai3_11
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int am=0, duong=0;
//             while (true)
//             {
//                 Console.Write("n=");
//                 int n=int.Parse(Console.ReadLine());
//                 if (n==0) break;
//                 else if (n<0) am++;
//                 else duong++;
//             }
//             Console.WriteLine(duong+" so duong\n"+am+" so am");
//         }
//     }
// }

// ------------------------------------------------------------------------
// using System;
// namespace Bai4_1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n,gt;
//             nhap(out n);
//             gt=giaithua(n);
//             inkq(gt,n);
//         }
//         private static void nhap(out int n)
//         {
//             Console.Write("Nhap n=");
//             n=int.Parse(Console.ReadLine());
//         }
//         private static int giaithua(int n)
//         {
//             int gt=1;
//             for (int i=1; i<=n;i++)
//                 gt*=i;
//             return gt;
//         }
//         private static void inkq(int gt,int n)
//         {
//             Console.Write(n+"!="+gt);
//         }
//     }
// }

// -----------------------------------------------------------
// using System;
// namespace Bai4_2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 int n;
//                 nhap(out n);
//                 inkq(n);
//                 Console.Write("\nBan co muon tiep tuc hay khong? (Bam T de ket thuc)");
//                 string tt=Console.ReadLine();
//                 if (tt=="T") break;
//             }
//         }
//         private static void nhap(out int n)
//         {
//             Console.Write("Nhap mot so nguyen duong n=");
//             n=int.Parse(Console.ReadLine());
//         }
//         private static void inkq(int n)
//         {
//             Console.WriteLine("Cac so nguyen chan trong "+n+" so tu nhien dau tien la:");
//             for (int i=2;i<=n;i+=2)
//             {
//                 Console.Write(i+" ");
//             }
//         }
//     }
// }

// ---------------------------------------------------------------------------------------------------------

// using System;
// namespace Bai4_4
// {
//     class Program
    // {
    //     static void Main(string[] args)
//         {
//             int a, b,c;
//             nhap(out a, out b, out c);
//             max3(a,b,c);
//         }
//         private static void nhap(out int a, out int b, out int c)
//         {
//             Console.WriteLine("Moi nhap 3 so:");
//             Console.Write("- a=");
//             a=int.Parse(Console.ReadLine());
//             Console.Write("- b=");
//             b=int.Parse(Console.ReadLine());
//             Console.Write("- c=");
//             c=int.Parse(Console.ReadLine());
//         }
//         private static void max3(int a,int b,int c)
//         {
//             int max=a;
//             if (b>max) max =b;
//             else if (c>max) max=c;
//             Console.WriteLine("So lon nhat la:"+max);
//         }
//     }
// }

//-----------------------------------------------------------------------

// using System;
// namespace Bai4_5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int M1=0, M2=0, S=0;
//             while (true)
//             {
//                 Console.WriteLine("CONG VIEC");
//                 Console.WriteLine("----------------------");
//                 Console.WriteLine("So 1: Nhap M1, M2 va S");
//                 Console.WriteLine("So 2: Tinh so tien phai tra");
//                 Console.WriteLine("So 0: Thoat");
//                 Console.WriteLine("----------------------");
//                 Console.Write("Moi ban chon cong viec: ");
//                 int cv=int.Parse(Console.ReadLine());
//                 if (cv==0) break;
//                 else if (cv==1) 
//                 {
//                     nhap(out M1, out M2, out S);
//                 }
//                 else if (cv==2) 
//                 {
//                     tinhtien(M1,M2,S);
//                 }
//             }
//         }
//         private static void nhap(out int M1,out  int M2, out int S)
//         {
//             Console.Write("M1=");
//             M1=int.Parse(Console.ReadLine());
//             Console.Write("M2=");
//             M2=int.Parse(Console.ReadLine());
//             Console.Write("S=");
//             S=int.Parse(Console.ReadLine());
//         }
//         private static void tinhtien(int M1,int M2,int S)
//         {
//             int tiendien;
//             if (S<=100) 
//             {
//                 tiendien=S*M1;
//             }
//             else 
//             {
//                 tiendien=100*M1+(S-100)*M2;
//             }
//             float phaitra=tiendien*(11/10);
//             Console.WriteLine("So dien nang tieu thu la: "+S+" chu");
//             Console.WriteLine("So tien dien phai tra la: "+phaitra);
//             Console.ReadKey();
//         }
//     }
// }

//-----------------------------------------------------------------------------------

// using System;
// namespace Bai5_1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n=0,x;
//             int[] L=new int[n];
//             Input(out n,out L,out x);
//             FirstAndLast(L,n);
//             Search(L,x,n);
//         }
//         private static void Input(out int n,out int[]L,out int x)
//         {
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             L=new int[n];
//             for (int i=0;i<n;i++)
//             {
//                 L[i]=int.Parse(Console.ReadLine());
//             }
//             Console.Write("x=");
//             x=int.Parse(Console.ReadLine());
//         }
//         private static void FirstAndLast(int[] L,int n)
//         {
//             Console.WriteLine("["+L[0]+","+L[n-1]+"]");
//         }
//         private static void Search(int[] L, int x,int n)
//         {
//             for (int i=0;i<n;i++)
//             {
//                 if (L[i]==x) 
//                 {
//                     Console.WriteLine("True");
//                     break;
//                 }
//                 else
//                 {
//                     if (i==n-1) Console.WriteLine("False");
//                 }
//             }
//         }
//     }
// }

// ---------------------------------------------------------------------

// using System;
// namespace Bai5_1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n=0;
//             int[] L=new int[n];
//             Input(out n,out L);
//             int max=SearchMax(L,n);
//             int min=SearchMin(L,n);
//             Output(min, max);
//         }
//         private static void Input(out int n,out int[]L)
//         {
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             L=new int[n];
//             for (int i=0;i<n;i++)
//             {
//                 L[i]=int.Parse(Console.ReadLine());
//             }
//         }
//         private static int SearchMin(int[] L,int n)
//         {
//             int min=L[0];
//             for (int i=0;i<n;i++)
//             {
//                 if (L[i]<min)
//                 {
//                     min=L[i];
//                 }
//             }
//             return min;
//         }
//         private static int SearchMax(int[] L,int n)
//         {
//             int max=L[0];
//             for (int i=0;i<n;i++)
//             {
//                 if (L[i]>max)
//                 {
//                     max=L[i];
//                     return max;
//                 }
                
//             }
//             return max;
//         }
//         private static void Output(int min, int max)
//         {
//             Console.WriteLine(max+" "+min);
//         }
//     }
// }

//-------------------------------------------------------------------

// using System;
// namespace Bai5_3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int duong=0;
//             int chan=0;
//             int tong_chan=0;
//             int n;
//             Console.Write("n=");
//             n=int.Parse(Console.ReadLine());
//             int[] l=new int[n];
//             for (int i=0; i<n;i++)
//             {
//                 l[i]=int.Parse(Console.ReadLine());
//             }
//             for (int y=0; y<n;y++)
//             {
//                 if (l[y]>0) duong++;
//                 if (l[y]%2==0)
//                 {
//                     chan++;
//                     tong_chan+=l[y];
//                 }
//             }
//             float tbc;
//             if (chan==0) tbc=0;
//             else tbc=tong_chan/chan;
//             Console.Write("SND="+duong+"\nTBC="+tbc);
//         }
//     }
// }

//------------------------------------------------------------------------------

// using System;
// namespace Bai5_4
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             int[] l=new int[n];
//             int[]L=new int[n];
//             for (int i=0; i<n;i++)
//             {
//                 l[i]=int.Parse(Console.ReadLine());
//             }
//             for (int x=n-1; x>=0;x--)
//             {
//                 L[n-x-1]=l[x];
//             }
//             for (int q=0;q<n;q++)
//             {
//                 Console.Write(L[q]+" ");
//             }
//             Console.WriteLine();
//             int tg;
//             for (int y=0;y<n;y++)
//             {
//                 for (int z=y+1;z<n;z++)
//                 {
//                     if (l[y]>l[z])
//                     {
//                         tg=l[y];
//                         l[y]=l[z];
//                         l[z]=tg;
//                     }
//                 }
//             }
//             for (int t=0;t<n;t++)
//             {
//                 Console.Write(l[t]+" ");
//             }
//         }
//     }
// }

//--------------------------------------------------------------

// using System;
// namespace Bai5_5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             int[]l=new int[n];
//             int tong=0;
//             for (int i=0;i<n;i++)
//             {
//                 l[i]=int.Parse(Console.ReadLine());
//             }
//             for (int j=0;j<n;j++)
//             {
//                 if (j%2==1) tong+=l[j];
//             }
//             Console.Write("Tong="+tong);
//         }
//     }
// }

//--------------------------------------------------------------

// using System;
// namespace Bai5_6
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[]a=new int[10];
//             int[]b=new int[10];
//             for (int i=0;i<10;i++)
//             {
//                 a[i]=int.Parse(Console.ReadLine());
//             }
//             for (int j=0;j<9;j+=2)
//             {
//                 b[j]=a[j+1];
//                 b[j+1]=a[j];
//             }
//             for (int k=0;k<10;k++) Console.Write(b[k]+" ");
//         }
//     }
// }

//----------------------------------------------------------------------

// using System;
// namespace Vidu1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string ten;
//             string mon;
//             int tuoi;
//             float diem;
//             Console.Write("Ho va ten: ");
//             ten=Console.ReadLine();
//             Console.Write("Tuoi: ");
//             tuoi=int.Parse(Console.ReadLine());
//             Console.Write("Mon hoc: ");
//             mon=Console.ReadLine();
//             Console.Write("Diem: ");
//             diem=float.Parse(Console.ReadLine());
//             Console.Write("Ban "+ten+" "+tuoi+" tuoi, hoc mon "+mon+" duoc "+diem+" diem");
//         }
//     }
// }

//-------------------------------------------------------------------------------------------------------

// using System;
// namespace Vidu2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int s=0;
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             for (int i=0; i<n;i++)
//             {
//                 int so=int.Parse(Console.ReadLine());
//                 if (so==0) break;
//                 if (so%2==1) s+=so;
//             }
//             Console.WriteLine("Tong cac so le la: "+s);
//         }
//     }
// }

//-----------------------------------------------------------------------

// using System;
// namespace Vidu3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Nhap vao so luong gio hang: ");
//             int n=int.Parse(Console.ReadLine());
//             int[] a=new int[n];
//             for (int i=0;i<n;i++)
//             {
//                 Random gio=new Random();
//                 a[i]=gio.Next(1,9);
//                 Console.WriteLine("Gio "+(i+1)+" co "+ a[i]+" do vat.");
//             }
//         }
//     }
// }

//-----------------------------------------------

// using System;
// namespace Bai1
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Ho va ten: ");
//             string name=Console.ReadLine();
//             Console.Write("Lop: ");
//             string lop=Console.ReadLine();
//             float[] diem=new float[4];
//             Console.Write("Diem_QTH: ");
//             diem[0]=float.Parse(Console.ReadLine());
//             Console.Write("Diem_HTTTQL: ");
//             diem[1]=float.Parse(Console.ReadLine());
//             Console.Write("Diem_CSLT: ");
//             diem[2]=float.Parse(Console.ReadLine());
//             Console.Write("Diem_Triet: ");
//             diem[3]=float.Parse(Console.ReadLine());
//             float s=0;
//             for (int i=0;i<4;i++)
//             {
//                 if (diem[i]>=0 & diem[i]<=3.9) s+=0;
//                 else if (diem[i]>=4 & diem[i]<=5.4) s+=1;
//                 else if (diem[i]>=5.5 & diem[i]<=6.9) s+=2;
//                 else if (diem[i]>=7 & diem[i]<=8.4) s+=3;
//                 else if (diem[i]>=8.5 & diem[i]<=10) s+=4;
//             }
//             float GPA=s/4;
//             string XepLoai="";
//             if (GPA>=0 & GPA<2) XepLoai="Yeu";   
//             else if (GPA>=2 & GPA<2.5)XepLoai="Trung Binh";   
//             else if (GPA>=2.5 & GPA<3.2) XepLoai="Kha";   
//             else if (GPA>=3.2 & GPA<3.6) XepLoai="Gioi";   
//             else if (GPA>=3.6 & GPA<4) XepLoai="Xuat Sac";
//             Console.WriteLine("Sinh vien "+name+",Lop "+lop+", Dat GPA "+GPA+",Xep loai "+XepLoai);
//         }
//     }
// }

// -------------------------------------------------------------------------------------------------------------
// using System;
// namespace Bai2
// {
//     class Program
//     {
//         private static void Nhap(out float a,out float b,out string tinh)
//         {
//             Console.Write("a=");
//             a=float.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=float.Parse(Console.ReadLine());
//             Console.Write("Toan tu: ");
//             tinh=Console.ReadLine();
//         }
//         private static float ThucHien(string tinh, float a, float b)
//         {
//             float kq=0;
//             if (tinh=="+") kq=a+b;
//             else if (tinh=="-") kq=a-b;
//             else if (tinh=="*") kq=a*b;
//             else if (tinh=="/")
//             {
//                 if (b!=0) kq=a/b;
//             }
//             return kq;
//         }
//         private static void InKQ(float kq,string tinh,float a,float b)
//         {
//             if (tinh=="+" || tinh=="-" || tinh=="*") Console.WriteLine(a+tinh+b+" = "+kq);
//             else if (tinh=="/")
//             {
//                 if (b!=0) Console.WriteLine(a+tinh+b+" = "+kq);
//                 else Console.WriteLine("Khong thuc hien duoc!!!");
//             }
//         }
//         static void Main(string[] args)
//         {
//             while (true)
//             {
//                 float a,b,kq;
//                 string tinh;
//                 Nhap(out a, out b, out tinh);
//                 kq=ThucHien(tinh,a,b);
//                 InKQ(kq,tinh,a,b);
//                 Console.Write("Tiep tuc: ");
//                 string tt=Console.ReadLine();
//                 if (tt=="t" || tt=="T") break;
//             }
//         }
//     }
// }


// ----------------------------------------------------------------------------------
// using System;
// namespace Bai3
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("n=");
//             int n=int.Parse(Console.ReadLine());
//             // Nhập chuỗi
//             Console.Write("A = ");
//             string kitu=Console.ReadLine();
//             // Biến chuỗi thành mảng
//             string[] a=kitu.Split(new char[] {',','[',']'});
//             float[] A=new float[n];
//             for (int i=0;i<n;i++)
//             {
//                 A[i]=float.Parse(a[i+1]);
//             }
//             // Tính tổng
//             float s=0,t=1;
//             float min=A[0];
//             float max=A[n-1];
//             for (int so=0;so<n;so++)
//             {
//                 if (A[so]<0) s+=A[so];
//             // Tính tích
//                 if (A[so]<min) min=A[so];
//                 if (A[so]>max) max=A[so];
//             }
//             int u=(Array.IndexOf(A,min));
//             int v=(Array.IndexOf(A,max));
//             if (u<v)
//             {
//                 for (int num=u+1;num<v;num++) t*=A[num];
//             }
//             else if (u>v)
//             {
//                 for (int nums=v+1;nums<u;nums++) t*=A[nums];
//             }
//             Console.WriteLine("Tong = "+-s);
//             Console.WriteLine("Tich = "+Math.Round(t,3));
//             // Sắp xếp tăng dần
//             Array.Sort(A);
//             Console.Write("A_tang = [");
//             for (int j=0;j<n-1;j++) Console.Write(A[j]+",");
//             Console.WriteLine(A[n-1]+"]");
//             // Biến đổi
//             Console.Write("A_biendoi = [");
//             for (int chan=0;chan<n-1;chan++)
//             {
//                 if (((int)(A[chan]))%2==0) Console.Write((int)A[chan]+",");
//             }
//             if (((int)A[n-1])%2==0) Console.Write((int)A[n-1]);
//             for (int le=0;le<n-1;le++)
//             {
//                 if (((int)A[le])%2!=0) Console.Write((int)A[le]+",");
//             }
//             if (((int)A[n-1])%2!=0) Console.Write((int)A[n-1]);
//             Console.Write("]");
//         }
//     }
// }

// -----------------------------------------------------------------------------------------------
// using System;
// namespace Bai4
// {   class Program
//     {   private static int SearchMax(int[]tong,int n)
//         {   int max=tong[0];
//             for (int i=0;i<n;i++) {if (max<tong[i]) {max =tong[i];}} return max;
//         }
//         private static int Dem(int[]tong,int n,int max)
//         {   int dem=0;
//             for (int i=0;i<n;i++) {if (tong[i]==max) {dem++;}} return dem;
//         }
//         private static int[] DemSL(int[,] L,int n,int x)
//         {   int[] A=new int[n];
//             for (int i=0;i<n;i++) 
//             {   int s=0;
//                 for (int j=0;j<n;j++) {   if (L[i,j]==x & i!=j) s++;}
//                 A[i]=s;
//             }
//             return A;
//         }
//         static void Main(string[] args)
//         {   //Nhap cac phan tu cua mang
//             int n=int.Parse(Console.ReadLine());
//             int[,]L=new int[n,n];
//             for (int i=0;i<n;i++)
//             {   string nhap=Console.ReadLine();
//                 var l=nhap.Split(' ');
//                 for (int j=0;j<n;j++) {L[i,j]=int.Parse(l[j]);}
//             }
//             //Tính tổng điểm của từng đội
//             int[]tong=new int[n];
//             for (int i=0;i<n;i++) 
//             {   int s=0;
//                 for (int j=0;j<n;j++) {s+=L[i,j];} tong[i]=s;
//             }
//             //In ra đội có số điểm lớn nhất
//             if (Dem(tong,n,SearchMax(tong,n))>1) 
//                 {   while (Dem(tong,n,SearchMax(tong,n))>1) 
//                     {   Console.Write((Array.IndexOf(tong,SearchMax(tong,n))+1)+" ");
//                         Console.WriteLine();
//                         tong[SearchMax(tong,n)]=0;
//                     }
//                     // Console.WriteLine();
//                 }
//             else { Console.WriteLine((Array.IndexOf(tong,SearchMax(tong,n)))+1);}
//             // In ra đội có sô trận thắng nhiều hơn thua
//             int[]thang=DemSL(L,n,3);
//             int[]thua=DemSL(L,n,0);
//             for (int i=0;i<n;i++) {if (thang[i]>thua[i]) {Console.Write(i+1+" ");}}
//             Console.WriteLine();
//             // In r đội không thua
//             for (int k=0;k<n;k++) {if (thua[k]==0) {Console.Write(k+1+" ");}}
//         }
//     }
// }

// ----------------------------------------------------------------------------------------------------------
// using System;
// namespace C3Vd3
// {
//     class Hocsinh
//     {
//         public double Weight;
//         public double Height;
//         public void Info()
//         {
//         Console.WriteLine(" Hoc sinh co can nang la: "

//         + Height + " va chieu cao la: " + Weight);

//         }
//         public Hocsinh() //Constructor không có tham số

//         {
//             Weight = 40;
//             Height = 150;
//         }

//         public Hocsinh(int w, int h) //Constructor có tham số

//         {
//             Weight = w;
//             Height = h;
//         }

//     }   
//     class SodoHocsinh
//     {
//         static void Main()
//         {
//             Hocsinh hs1 = new Hocsinh();
//             hs1.Info();
//             Hocsinh hs2 = new Hocsinh(48, 160);
//             hs2.Info();
//         }
//     }
// }

// -----------------------------------------------------------------------

// using System;
// namespace C3Vd2
// {
//     public class Time
//     {
//     // private member variables
//         int Year;
//         int Month;
//         int Date;
//         int Hour;
//         int Minute;
//         int Second = 30;
//         public void DisplayCurrentTime( )
//         {
//             Console.WriteLine("Current time is: {0}/{1}/{2} {3}:{4}:{5}",Date,Month, Year, Hour, Minute, Second);
//         }
//         public Time(System.DateTime dt)
//         {
//             Console.WriteLine("Ham constructor tu dong duoc goi!");
//             Year = dt.Year;
//             Month = dt.Month;
//             Date = dt.Day;
//             Hour = dt.Hour;
//             Minute = dt.Minute;
//         }
//     }
//     class DateTimeConstructorApp
//     {
//         static void Main()
//         {
//         System.DateTime currentTime = System.DateTime.Now;
//         Time t = new Time(currentTime);
//         t.DisplayCurrentTime( );
//         Console.ReadLine();
//         }
//     }
// }
// --------------------------------------------------------------------------
// using System;
// namespace C3Vd1
// {
//     class HinhChuNhat
//     {
//         public float Dai;
//         public float Rong;
//         public void Nhap()
//         {
//             Console.WriteLine("Nhap chieu dai hinh chu nhat :");
//             Dai = float.Parse(Console.ReadLine());
//             Console.WriteLine("Nhap chieu rong hinh chu nhat :");
//             Rong = float.Parse(Console.ReadLine());
//         }
//         public void Xuat()
//         {
//             Console.WriteLine("Hinh chu nhat: Dai = {0}, Rong = {1}",Dai, Rong);
//         }
//         public float Chuvi()
//         {
//             return (Dai+Rong)*2;
//         } 
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             HinhChuNhat h = new HinhChuNhat();
//             h.Nhap();
//             h.Xuat();
//             Console.WriteLine("Chu vi HCN: {0}",h.Chuvi());
//             Console.ReadLine();
//         }
//     }
// }
// ----------------------------------------------------------------------------
// using System;
// namespace Bai1Chuong3
// {
//     class Sach
//     {
//         public string Tensach;
//         public string Tacgia;
//         public int NamXB;
//         public int Soluong;
//         public void Info()
//         {
//             Console.WriteLine(Tensach+" cua "+Tacgia+" duoc xuat ban nam "+NamXB+" voi so luong "+Soluong);
//         }
//         public Sach()
//         {
//             Tensach="Khong Gia Dinh";
//             Tacgia="Hector Malot";
//             NamXB=1878;
//             Soluong=123;
//         }
//         public Sach(string s,string t, int n,int sl)
//         {
//             Tensach=s;
//             Tacgia=t;
//             NamXB=n;
//             Soluong=sl;
//         }
//         ~Sach()
//         {
//             Console.WriteLine("Doi tuong Sach da bi huy.");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Sach s1=new Sach();
//             s1.Info();
//             Sach s2=new Sach("De men phieu luu ki","To Hoai",1941,124);
//             s2.Info();
//         }
//     }
// }

// --------------------------------------------------------------------------
// namespace Bai2Chuong3
// {
//     class Meo
//     {
//         public string Ten;
//         public string Giong;
//         public string GioiTinh;
//         public int Tuoi;
//         public void Nhap()
//         {
//             Console.Write("Ten Meo: ");
//             Ten=Console.ReadLine();
//             Console.Write("Giong: ");
//             Giong=Console.ReadLine();
//             Console.Write("Gioi tinh: ");
//             GioiTinh=Console.ReadLine();
//             Console.Write("Tuoi: ");
//             Tuoi=int.Parse(Console.ReadLine());
//         }
//         public void Xuat()
//         {
//             Console.WriteLine("Meo ten "+Ten+", giong "+Giong+", gioi tinh "+GioiTinh+" duoc "+Tuoi+" tuoi");
//         }
//         public int dem(int num)
//         {
//             num++;
//             return num;
//         }
//         ~Meo()
//         {
//             Console.WriteLine("Doi tuong Sach da bi huy.");
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
            
//             int num=0;
//             while (true)
//             {
//                 Meo m=new Meo();
//                 m.Nhap();
//                 m.Xuat();
//                 num=m.dem(num);
//                 // Console.WriteLine("So luong meo da nhap la: "+m.dem(num));
//                 Console.Write("Tiep tuc: ");
//                 string tt=Console.ReadLine();
//                 if (tt=="T"||tt=="t")
//                 {
//                     Console.WriteLine("So luong meo da nhap la: "+num);
//                     break;
//                 }
//             }
//         }
//     }
// }
//     // class Program
//     //     {
//     //         static void Main(string[] args)
//     //         {
//     //             Meo m1=new Meo();
//     //             m1.Nhap();
//     //             m1.Xuat();
//     //             Meo m2=new Meo();
//     //             m2.Nhap();
//     //             m2.Xuat();
//     //             Console.WriteLine("So luong meo da nhap: "+Meo.dem);
//     //         }
//     //     }
//     // }
// -----------------------------------------------------------------------------------------
// namespace Bai4Chuong3
// {
//     class Triangle
//     {
//         public int a;
//         public int b;
//         public int c;
//         public void Nhap()
//         {
//             Console.Write("a=");
//             a=int.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=int.Parse(Console.ReadLine());
//             Console.Write("c=");
//             c=int.Parse(Console.ReadLine());
//         }
//         public int Tinh_ChuVi()
//         {
//             return a+b+c;
//         }
//         public double Tinh_Dientich()
//         {
//             float p=(a+b+c)/2;
//             return Math.Round(Math.Sqrt((p-a)*(p-b)*(p-c)*p),3);     
//         }
//         public void Xuat()
//         {
//             Console.WriteLine("Cac canh cua tam giac lan luot la: a={0}, b={1}, c={2}",a,b,c);
//             if ((a+b)>c & (a+c)>b & (b+c)>a & a!=0 & b!=0 & c!=0)
//             {
//                 Console.WriteLine("Chu vi: "+Tinh_ChuVi());
//                 Console.WriteLine("Dien tich: "+Tinh_Dientich());
//             }
//             else 
//             {
//                 Console.WriteLine("Khong hop le");
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Triangle tg=new Triangle();
//             while (true)
//             {
//                  Console.WriteLine("MENU:\n-----------------------------------------\nBam 1: Nhap cac canh a,b,c cua tam giac.\nBam 2: Tinh chu vi va dien tich hinh tam giac.\nBam 3: xuat ra cac gia tri a,b,c.\nBam 0: Thoat khoi chuong trinh.\n------------------------------------------");
//                 Console.Write("Moi ban chon cong viec: ");
//                 int CV=int.Parse(Console.ReadLine());
//                 if (CV==1) 
//                 {
//                     tg.Nhap();
//                 }
//                 else if (CV==2)
//                 {
//                     int cv=tg.Tinh_ChuVi();
//                     double dt=tg.Tinh_Dientich();
//                 }
//                 else if (CV==3)
//                 {
//                     tg.Xuat();
//                 }
//                 else if (CV==0)break;
//             }
//         }
//     }
// }

// ---------------------------------------------------------------------------------------------------------------------------------

// namespace Bai3Chuong3
// {
//     class Organization
//     {
//         public string Name;
//         public string Country;
//         public string City;
//         public string Address;
//         public string Telephone;
//         public int dem=0;
//         public void Nhap()
//         {
//             while (true)
//             {
//                 Console.Write("Ten doanh nghiep: ");
//                 Name=Console.ReadLine();
//                 if (Name=="")
//                 {
//                     Console.WriteLine("Nhap thong tin loi!!!");
//                     break;
//                 }
//                 else dem++;
//                 Console.Write("Quoc gia: ");
//                 Country=Console.ReadLine();
//                 if (Country=="")
//                 {
//                     Console.WriteLine("Nhap thong tin loi!!!");
//                     break;
//                 }
//                 else dem++;
//                 Console.Write("Thanh pho: ");
//                 City=Console.ReadLine();
//                 if (City=="")
//                 {
//                     Console.WriteLine("Nhap thong tin loi!!!");
//                     break;
//                 }
//                 else dem++;
//                 Console.Write("Dia chi: ");
//                 Address=Console.ReadLine();
//                 if (Address=="")
//                 {
//                     Console.WriteLine("Nhap thong tin loi!!!");
//                     break;
//                 }
//                 else dem++;
//                 Console.Write("So dien thoai: ");
//                 Telephone=Console.ReadLine();
//                 if (Telephone=="" || Telephone.Length!=10)
//                 {
//                     Console.WriteLine("Nhap thong tin loi!!!");
//                     break;
//                 }
//                 else
//                 {
//                     int num=0;
//                     for (int i=0;i<10;i++)
//                     {
//                         if (char.IsDigit(Telephone[i]))
//                         {
//                             num++;
//                         }
//                         else
//                         {
//                             Console.WriteLine("Nhap thong tin loi!!!");
//                             break;
//                         }
//                     }
//                     if (num==10) dem++;
//                     else break;
//                 }
//                 if (dem==5) break;
//             }
//         }
//         public void Xuat()
//         {
//             if (dem==5)
//             {
//                 Console.WriteLine("Doanh nghiep - {0} - {1} - {2} - {3} - {4}",Name,Country, City, Address, Telephone);
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Organization o=new Organization();
//             o.Nhap();
//             o.Xuat();
//         }
//     }
// }
// // --------------------------------------------------------------------------------------------------------------------------------------

// using System;
// namespace XepSach
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int k = 0;
//             int n = int.Parse(Console.ReadLine());
//             string str = Console.ReadLine();
//             string[] numbers = str.Split(" ");
//             int[] l = new int[n];
//             int[] d = new int[100];
//             for (int i = 0; i<n; i++){
//                 l[i] = int.Parse(numbers[i]);
//             }
//             for (int i = 0; i<n; i++){
//                 d[l[i]-1]++;
//             }
//             for (int i = 0; i<100; i++){
//                 while (d[i]-->0){
//                     l[k++] = i+1;
//                 }
//             }
//             foreach (int i in l){
//                 Console.Write(i+" ");
//             }
//         }
//     }
// }