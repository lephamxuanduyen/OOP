// namespace Bai1
// {
//     class DanhSachBDS
//     {
//         private string[,] l=new string[100,10];
//         public DanhSachBDS()
//         {
//             for (int i=0;i<100;i++)
//             {
//                 for (int j=0;j<10;j++)
//                 {
//                     l[i,j]="NONE";
//                 }
//             }
//         }
//         public string this[int i, int j]
//         {
//             get
//             {
//                 string tg="";
//                 if (i>=0 & i<100 & j>=0 & j<10)
//                 {
//                     tg=l[i,j];
//                 }
//                 return tg;
//             }
//             set
//             {
//                 if (i>=0 & i<100 & j>=0 & j<10)
//                 {
//                     l[i,j]=value;
//                 }
//             }
//         }
//         public void Nhap(ref int row, ref int column)
//         {
//             string[]lines=File.ReadAllLines(@"bds.txt");
//             row=lines.Length;
//             column=lines[0].Split(";").Length;
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     l[i,j]=lines[i].Trim().Split(";")[j].Trim();
//                 }
//             }
//         }
//         public void Them(ref int row)
//         {
//             string i0,i1,i2,i3,i4,i5;
//             Console.Write("MaBDS: ");
//             i0=Console.ReadLine();
//             Console.Write("Ten BDS: ");
//             i1=Console.ReadLine();
//             Console.Write("Huong: ");
//             i2=Console.ReadLine();
//             Console.Write("Dia chi: ");
//             i3=Console.ReadLine();
//             Console.Write("Dien tich: ");
//             i4=Console.ReadLine();
//             Console.Write("Gia ban: ");
//             i5=Console.ReadLine();
//             string dk="TRUE";
//             for (int i=0; i<row;i++)
//             {
//                 if (l[i,0]==i0)
//                 {
//                     Console.WriteLine("Ma Bat Dong San nay da ton tai.");
//                     dk="FALSE";
//                     break;
//                 }
//             }
//             if (dk=="TRUE")
//             {
//                 l[row,0]=i0;
//                 l[row,1]=i1;
//                 l[row,2]=i2;
//                 l[row,3]=i3;
//                 l[row,4]=i4;
//                 l[row,5]=i5;
//                 row++;          
//             }
//         }
//         public void Sua(int row)
//         {
//             Console.Write("Nhap ma BDS can sua: ");
//             string ma=Console.ReadLine();
//             string kt="False";
//             // TIM VA SUA
//             for (int i=0;i<row;i++)
//             {
//                 if (ma==l[i,0])
//                 {
//                     kt="True";
//                     Console.WriteLine("Nhap thong tin can sua.");
//                     Console.Write("Ten BDS: ");
//                     l[i,1]=Console.ReadLine();
//                     Console.Write("Huong: ");
//                     l[i,2]=Console.ReadLine();
//                     Console.Write("Dia chi: ");
//                     l[i,3]=Console.ReadLine();
//                     Console.Write("Dien tich: ");
//                     l[i,4]=Console.ReadLine();
//                     Console.Write("Gia ban: ");
//                     l[i,5]=Console.ReadLine();
//                     break;
//                 }
//             }
//             if (kt=="False")
//             {
//                 Console.WriteLine("Ma bat dong san nay khong ton tai.");
//             }
//         }
//         public void Xoa(int row)
//         {
//             Console.Write("Nhap ma BDS can xoa: ");
//             string ma=Console.ReadLine();
//             // TIM VA XOA
//             string kt="False";
//             for (int i=0;i<row;i++)
//             {
//                 if (ma==l[i,0])
//                 {
//                     kt="True";
//                     l[i,0]="NONE";
//                     l[i,1]="NONE";
//                     l[i,2]="NONE";
//                     l[i,3]="NONE";
//                     l[i,4]="NONE";
//                     l[i,5]="NONE";
//                     break;
//                 }
//             }
//             if (kt=="False")
//             {
//                 Console.WriteLine("Ma bat dong san nay khong ton tai.");
//             }
//         }
//         public void Xuat(int row, int column)
//         {
//             for (int i=0;i<100;i++)
//             {
//                 if (l[i,0]!="NONE")
//                 {
//                     for (int j=0;j<column;j++)
//                     {
//                         Console.Write(l[i,j]+"; ");
//                     }
//                     Console.WriteLine();
//                 }
//             }
//         }
//         public void Tim_ten(int row, int column)
//         {
//             Console.Write("Nhap Ten BDS can tim: ");
//             string ten=Console.ReadLine();
//             for (int i=0;i<row;i++)
//             {
//                 if (ten==l[i,1])
//                 {
//                     for (int j=0;j<column;j++)
//                     {
//                         Console.Write(l[i,j]+"; ");
//                     }
//                     Console.WriteLine();
//                 }
//             }
//         }
//         public void Tim_huong(int row, int column)
//         {
//             Console.Write("Nhap huong ban can tim: ");
//             string huong=Console.ReadLine();
//             for (int i=0;i<row;i++)
//             {
//                 if (huong==l[i,2])
//                 {
//                     for (int j=0;j<column;j++)
//                     {
//                         Console.Write(l[i,j]+"; ");
//                     }
//                     Console.WriteLine();
//                 }
//             }
//         }
//         public void Tim_Gia(int row, int column)
//         {
//             Console.Write("Nhap Gia cua BDS can tim: ");
//             string gia=Console.ReadLine();
//             for (int i=0;i<row;i++)
//             {
//                 if (gia==l[i,5])
//                 {
//                     for (int j=0;j<column;j++)
//                     {
//                         Console.Write(l[i,j]+"; ");
//                     }
//                     Console.WriteLine();
//                 }
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DanhSachBDS bds=new DanhSachBDS();
//             int row=0;
//             int column=0;
//             bds.Nhap(ref row,ref column);
//             while (true)
//             {
//                 Console.WriteLine(" ________________________________");
//                 Console.WriteLine("|             MENU               |");
//                 Console.WriteLine("|________________________________|");
//                 Console.WriteLine("|    Bam 1: Them moi danh sach   |");
//                 Console.WriteLine("|    Bam 2: Sua thong tinh       |");
//                 Console.WriteLine("|    Bam 3: Xoa thong tin        |");
//                 Console.WriteLine("|    Bam 4: Xuat danh sach       |");
//                 Console.WriteLine("|    Bam 5: Tim theo Ten         |");
//                 Console.WriteLine("|    Bam 6: Tim theo Huong       |");
//                 Console.WriteLine("|    Bam 7: Tim theo Gia         |");
//                 Console.WriteLine("|    Bam 0: Exit                 |");
//                 Console.WriteLine("|________________________________|");
//                 Console.Write("Moi ban chon chuc nang: ");
//                 int cn=int.Parse(Console.ReadLine());
//                 if (cn==1)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("| THEM MOI BAT DONG SAN |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Them(ref row);
//                 }
//                 else if (cn==2)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     SUA THONG TIN     |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Sua(row);
//                 }
//                 else if (cn==3)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     XOA THONG TIN     |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Xoa(row);
//                 }
//                 else if (cn==4)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     XUAT DANH SACH    |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Xuat(row,column);
//                 }
//                 else if (cn==5)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     TIM THEO TEN      |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Tim_ten(row,column);
//                 }
//                 else if (cn==6)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|    TIM THEO HUONG     |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Tim_huong(row,column);
//                 }
//                 else if (cn==7)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     TIM THEO GIA      |");
//                     Console.WriteLine("|_______________________|");
//                     bds.Tim_Gia(row,column);
//                 }
//                 else if (cn==0)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|         EXIT          |");
//                     Console.WriteLine("|_______________________|");
//                     break;
//                 }
//             }
//         }
//     }
// }