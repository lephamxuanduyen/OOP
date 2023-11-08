// namespace DongGoiBDS
// {
//     class BatDongSan
//     {
//         private string[,] l = new string[100,10];
//         public BatDongSan()
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
//                 string ts;
//                 if (i>=0 & i<100 & j>=0 &j<10)
//                 {
//                     ts=l[i,j];
//                 }
//                 else
//                 {
//                     ts="";
//                 }
//                 return ts;
//             }
//             set
//             {
//                 if (i>=0 & i<100 & j>=0 &j<10)
//                 {
//                     l[i,j]=value;
//                 }
//             }
//         }
//     }

//     class DanhSachBDS
//     {
//         static void Them(out string id,out string name,out string huong,out string add,out string s,out string p)
//         {
//             Console.Write("MaBDS: ");
//             id=Console.ReadLine();
//             Console.Write("Ten BDS: ");
//             name=Console.ReadLine();
//             Console.Write("Huong: ");
//             huong=Console.ReadLine();
//             Console.Write("Dia chi: ");
//             add=Console.ReadLine();
//             Console.Write("Dien tich: ");
//             s=Console.ReadLine();
//             Console.Write("Gia ban: ");
//             p=Console.ReadLine();
//         }

//         static void Main(string[] args)
//         {
//             // NHẬP DANH SÁCH
//             BatDongSan bds=new BatDongSan();
//             int row, column;
//             string[] lines = File.ReadAllLines(@"bds.txt");
//             row=lines.Length;
//             column=lines[0].Split(' ').Length;
//             string[,]ds=new string[row,column];
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     ds[i,j]=lines[i].Trim().Split(";")[j];
//                 }
//             }
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     bds[i,j]=ds[i,j].Trim();
//                 }
//             }

//             // MENU CHỨC NĂNG

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
//                     string i0,i1,i2,i3,i4,i5;
//                     Them(out i0,out i1,out i2,out i3,out i4,out i5);
//                     string dk="TRUE";
//                     for (int i=0; i<row;i++)
//                     {
//                         if (bds[i,0]==i0)
//                         {
//                             Console.WriteLine("Ma Bat Dong San nay da ton tai.");
//                             dk="FALSE";
//                             break;
//                         }
//                     }
//                     if (dk=="TRUE")
//                     {
//                         bds[row,0]=i0;
//                         bds[row,1]=i1;
//                         bds[row,2]=i2;
//                         bds[row,3]=i3;
//                         bds[row,4]=i4;
//                         bds[row,5]=i5;
//                         Console.WriteLine(" _______________________");
//                         Console.WriteLine("|   DA THEM THANH CONG  |");
//                         Console.WriteLine("|_______________________|");
//                     }
//                 }
//                 else if (cn==2)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     SUA THONG TIN     |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Nhap ma BDS can sua: ");
//                     string ma=Console.ReadLine();
//                     // TIM VA SUA
//                     int dem=0;
//                     for (int i=0;i<100;i++)
//                     {
//                         if (ma==bds[i,0])
//                         {
//                             Console.WriteLine("Nhap thong tin can sua.");
//                             Console.Write("Ten BDS: ");
//                             bds[i,1]=Console.ReadLine();
//                             Console.Write("Huong: ");
//                             bds[i,2]=Console.ReadLine();
//                             Console.Write("Dia chi: ");
//                             bds[i,3]=Console.ReadLine();
//                             Console.Write("Dien tich: ");
//                             bds[i,4]=Console.ReadLine();
//                             Console.Write("Gia ban: ");
//                             bds[i,5]=Console.ReadLine();
//                             Console.WriteLine(" _______________________");
//                             Console.WriteLine("|   DA SUA THANH CONG   |");
//                             Console.WriteLine("|_______________________|");
//                             break;
//                         }
//                         dem++;
//                     }
//                     if (dem==100 & ma!=bds[99,0])
//                     {
//                         Console.WriteLine("Bat dong san nay khong ton tai.");
//                     }
//                 }
//                 else if (cn==3)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     XOA THONG TIN     |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Nhap ma BDS can xoa: ");
//                     string ma=Console.ReadLine();
//                     // TIM VA XOA
//                     int dem=0;
//                     for (int i=0;i<100;i++)
//                     {
//                         if (ma==bds[i,0])
//                         {
//                             bds[i,0]="NONE";
//                             bds[i,1]="NONE";
//                             bds[i,2]="NONE";
//                             bds[i,3]="NONE";
//                             bds[i,4]="NONE";
//                             bds[i,5]="NONE";
//                             Console.WriteLine(" _______________________");
//                             Console.WriteLine("|   DA XOA THANH CONG   |");
//                             Console.WriteLine("|_______________________|");
//                             break;
//                         }
//                         dem++;
//                     }
//                     if (dem==100 & ma!=bds[99,0])
//                     {
//                         Console.WriteLine("Bat dong san nay khong ton tai.");
//                     }
//                 }
//                 else if (cn==4)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     XUAT DANH SACH    |");
//                     Console.WriteLine("|_______________________|");
//                     for (int i=0;i<100;i++)
//                     {
//                         if (bds[i,0]!="NONE")
//                         {
//                             for (int j=0;j<column;j++)
//                             {
//                                 Console.Write(bds[i,j]+"; ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
//                 else if (cn==5)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     TIM THEO TEN      |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Nhap Ten BDS can tim: ");
//                     string ten=Console.ReadLine();
//                     for (int i=0;i<100;i++)
//                     {
//                         if (ten==bds[i,1])
//                         {
//                             for (int j=0;j<column;j++)
//                             {
//                                 Console.Write(bds[i,j]+"; ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
//                 else if (cn==6)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|    TIM THEO HUONG     |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Nhap Huong can tim: ");
//                     string huong=Console.ReadLine();
//                     for (int i=0;i<100;i++)
//                     {
//                         if (huong==bds[i,2])
//                         {
//                             for (int j=0;j<column;j++)
//                             {
//                                 Console.Write(bds[i,j]+"; ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
//                 else if (cn==7)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     TIM THEO GIA      |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Nhap Gia cua BDS can tim: ");
//                     string gia=Console.ReadLine();
//                     for (int i=0;i<100;i++)
//                     {
//                         if (gia==bds[i,5])
//                         {
//                             for (int j=0;j<column;j++)
//                             {
//                                 Console.Write(bds[i,j]+"; ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
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

