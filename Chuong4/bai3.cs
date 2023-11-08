// namespace Bai3
// {
//     class TamGiac
//     {
//         private float canh1;
//         private float canh2;
//         private float canh3;
//         public float a
//         {
//             get {return canh1;}
//             set {canh1=value;}
//         }
//         public float b
//         {
//             get {return canh2;}
//             set {canh2=value;}
//         }
//         public float c
//         {
//             get {return canh3;}
//             set {canh3=value;}
//         }
//         public void Nhap()
//         {
//             Console.Write("a=");
//             a=float.Parse(Console.ReadLine());
//             Console.Write("b=");
//             b=float.Parse(Console.ReadLine());
//             Console.Write("c=");
//             c=float.Parse(Console.ReadLine());
//         }
//         public string Kiemtra()
//         {
//             string loai="";
//             if (a!=b & a!=c & b!=c)
//             {
//                 if (a*a==b*b+c*c || b*b==a*a+c*c || c*c==a*a+b*b)
//                 {
//                     loai=("tam giac vuong.");
//                 }
//                 else 
//                 {
//                     loai=("tam giac thuong.");
//                 }
//             }
//             else if (a==b & b==c & a==c)
//             {
//                 loai=("tam giac deu.");
//             }
//             else if ((a==b & a!=c) || (a==c & a!=b) || (b==c & b!=a))
//             {
//                 if ((a==b & c*c==a*a+b*b) || (a==c & b*b==a*a+c*c) || (b==c & a*a==b*b+c*c))
//                 {
//                     loai=("tam giac vuong can.");
//                 }
//                 else
//                 {
//                     loai=("tam giac can.");
//                 }
//             }
//             return loai;
//         }
//         public void Xuat()
//         {
//             if (a!=0 & b!=0 & c!=0 & a+b>c & a+c>b & b+c>a)
//             {
//                 Console.WriteLine("Day la "+Kiemtra());
//             }
//             else
//             {
//                 Console.WriteLine("Day khong phai 3 canh cua mot tam giac.");
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             TamGiac tg=new TamGiac();
//             tg.Nhap();
//             tg.Xuat();
//         }
//     }
// }