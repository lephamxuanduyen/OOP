// namespace Bai2
// {
//     class DanhSachThangLeo
//     {
//         private string[,] l=new string[100,10];
//         public DanhSachThangLeo()
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
//             string[]lines=File.ReadAllLines(@"thang.txt");
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
//         public void Tim(int column)
//         {
//             Console.Write("Nhap khoang chieu cao cua thang leo ban muon tim: ");
//             var num=Console.ReadLine();
//             var a_b=num.Split(" ");
//             int a=int.Parse(a_b[0]);
//             int b=int.Parse(a_b[1]);
//             if (a<=b)
//             {
//                 string tim="False";
//                 for (int x=a;x<=b;x++)
//                 {
//                     string so=Convert.ToString(x)+"m";
//                     for (int i=0;i<100;i++)
//                     {
//                         if (l[i,2]==so)
//                         {
//                             tim="True";
//                             for (int j=0;j<column;j++)
//                             {
//                                 Console.Write(l[i,j]+"; ");
//                             }
//                             Console.WriteLine();
//                         }
//                     }
//                 }
//                 if (tim=="False")
//                 {
//                     Console.WriteLine("Khong tim thay thang thoa man dieu kien.");
//                 }
//             }
//             else Console.WriteLine("Chieu cao ban nhap khong chinh xac");
//         }
//         public void SapXep(int row, int column)
//         {
//             // Tạo một mảng chứa các mức giá (kiểu float)
//             float[] PRICE=new float[row];
//             for (int i=0;i<row;i++)
//             {
//                 PRICE[i]=float.Parse(l[i,4]);
//             }
//             // Sắp xếp các phần tử trong mảng
//             Array.Sort(PRICE);
//             // Loại giá trị trùng lặp
//             // Nếu giá trị không trùng lặp, thêm giá trị này vào mảng price[]
//             string [] price = new string [row];
//             int k=0;
//             for (int i=0;i<row-1;i++)
//             {
//                 if(PRICE[i]!=PRICE[i+1])
//                 {
//                     price[k]=Convert.ToString(PRICE[i]);
//                     k++;
//                     // Như vậy, k là số phần tử thật sự của mảng price[]
//                 }
//             }
//             if (PRICE[row-1]!=PRICE[row-2])
//             {
//                 price[k]=Convert.ToString(PRICE[row-1]);
//                 k++;
//             }
//             // 
//             // Tạo và sắp xếp các phần tử của thang theo giá bán vào 1 mảng trung gian
//             string[,]tg=new string [row,column];
//             int i_tg=0;
//             for(int a=0;a<k;a++)
//             {
//                 for (int i=0;i<row;i++)
//                 {
//                     if (l[i,4]==price[a])
//                     {
//                         for (int j=0;j<column;j++)
//                         {
//                             tg[i_tg,j]=l[i,j];
//                         }
//                         i_tg++;
//                     }
//                 }
//             }
//             // Gán các phần tử của mảng ảo thang[] = các phần tử của mảng tg[] để sắp xếp mảng theo giá
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     l[i,j]=tg[i,j];
//                 }
//             }
//             Console.WriteLine("Neu ban muon xem lai danh sach, hay bam phim 2.");
//         }
//         public void SoSanh(int row)
//         {
//             Console.Write("Ma thang: ");
//             string ma=Console.ReadLine();
//             Console.Write("So luong: ");
//             int sl=int.Parse(Console.ReadLine());
//             string DK="False";
//             for (int i=0;i<row;i++)
//             {
//                 if (l[i,0]==ma)
//                 {
//                     DK="True";
//                     int num=int.Parse(l[i,3]);
//                     if (sl<=num)
//                     {
//                         Console.WriteLine("OK");
//                     }
//                     else
//                     {
//                         Console.WriteLine("CHI CON "+num+" THANG. KHONG DU HANG.");
//                     }
//                     break;
//                 }
//             }
//             if (DK=="False")
//             {
//                 Console.WriteLine("Ma thang nay khong ton tai.");
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             DanhSachThangLeo thang=new DanhSachThangLeo();
//             int row=0;
//             int column=0;
//             thang.Nhap(ref row,ref column);
//             while (true)
//             {
//                 Console.WriteLine(" ___________________________");
//                 Console.WriteLine("|  MENU                     |");
//                 Console.WriteLine("|___________________________|");
//                 Console.WriteLine("| Bam 1: Them moi danh sach |");
//                 Console.WriteLine("| Bam 2: Xuat danh sach     |");
//                 Console.WriteLine("| Bam 3: Tim san pham       |");
//                 Console.WriteLine("| Bam 4: Sap xep            |");
//                 Console.WriteLine("| Bam 5: Kiem tra           |");
//                 Console.WriteLine("| Bam 6: So sanh            |");
//                 Console.WriteLine("| Bam 0: Exit               |");
//                 Console.WriteLine("|___________________________|");
//                 Console.Write("Moi ban chon chuc nang: ");
//                 int cv=int.Parse(Console.ReadLine());
//                 if (cv==1)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|   THEM MOI DANH SACH  |");
//                     Console.WriteLine("|_______________________|");
//                     thang.Them(ref row);
//                 }
//                 else if (cv==2)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     XUAT DANH SACH    |");
//                     Console.WriteLine("|_______________________|");
//                     thang.Xuat(row,column);
//                 }
//                 else if (cv==3)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|      TIM SAN PHAM     |");
//                     Console.WriteLine("|_______________________|");
//                     thang.Tim(column);
//                 }
//                 else if (cv==4)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|        SAP XEP        |");
//                     Console.WriteLine("|_______________________|");
//                     thang.SapXep(row,column);
//                 }
//             }
//         }
//     }
// }