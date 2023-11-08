// namespace Bai5
// {
//     class DoanhNghiep
//     {
//         private string ten;
//         private string ma;
//         private string add;
//         public string TenDN
//         {
//             get {return ten;}
//             set {ten=value;}
//         }
//         public string MST
//         {
//             get {return ma;}
//             set {ma=value;}
//         }
//         public string DiaChi
//         {
//             get {return add;}
//             set {add=value;}
//         }
//         public string[,] l=new string[100,3];
//         public DoanhNghiep()
//         {
//             for (int i=0;i<100;i++)
//             {
//                 for (int j=0;j<3;j++)
//                 {
//                     l[i,j]="NONE";
//                 }
//             }
//         }
//         public string this[int i, int j]
//         {
//             get
//             {
//                 string tg;
//                 if (i>=0 & i<100 & j>=0 & j<3)
//                 {
//                     tg=l[i,j];
//                 }
//                 else
//                 {
//                     tg="";
//                 }
//                 return tg;
//             }
//             set
//             {
//                 if (i>=0 & i<100 & j>=0 & j<3)
//                 {
//                     l[i,j]=value;
//                 }
//             }
//         }
//         public int row;
//         public int column;
//         public void Nhap()
//         {
//             string[] lines=File.ReadAllLines(@"doanhnghiep.txt");
//             row=lines.Length;
//             column=lines[0].Split(";").Length;
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     l[i,j]=lines[i].Trim().Split(";")[j];
//                 }
//             }
//         }
//         public void Xuat()
//         {
//             for (int i=0;i<row;i++)
//             {
//                 Console.Write((i+1)+". ");
//                 for (int j=0;j<column;j++)
//                 {
//                     Console.Write(l[i,j]+"; ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//         public void tim_ten()
//         {
//             Console.Write("Nhap ten doanh nghiep can tim: ");
//             string ten=Console.ReadLine();
//             for (int i=0;i<row;i++)
//             {
//                 if (l[i,0]==ten)
//                 {
//                     Console.WriteLine("Ma so thue: "+l[i,1]);
//                     break;
//                 }
//             }
//         }
//         public void tim_mst()
//         {
//             Console.Write("Nhap ma so thue can tim: ");
//             string mst=Console.ReadLine();
//             for (int i=0;i<row;i++)
//             {
//                 if (l[i,1]==mst)
//                 {
//                     Console.WriteLine("Ten doanh nghiep: "+l[i,0]);
//                     Console.WriteLine("    Dia chi: "+l[i,2]);
//                     break;
//                 }
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DoanhNghiep dn=new DoanhNghiep();
//             dn.Nhap();
//             dn.Xuat();
//             dn.tim_ten();
//             dn.tim_mst();
//         }
//     }
// }