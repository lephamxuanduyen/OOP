// namespace Thang
// {
//     class ThangLeo
//     {
//         private string[,] thang=new string[100,5];
//         public ThangLeo()
//         {
//             for (int i=0;i<100;i++)
//             {
//                 for (int j=0;j<5;j++)
//                 {
//                     thang[i,j]="NONE";
//                 }
//             }
//         }
//         public string this[int i, int j]
//         {
//             get
//             {
//                 string ts;
//                 if (i>=0 & i<100 & j>=0 & j<5)
//                 {
//                     ts=thang[i,j];
//                 }
//                 else
//                 {
//                     ts="";
//                 }
//                 return ts;
//             }
//             set
//             {
//                 if (i>=0 & i<100 & j>=0 & j<5)
//                 {
//                     thang[i,j]=value;
//                 }
//             }
//         }
//     }
//     class DanhSachThang
//     {
//         static void Them(out string ma,out string ten,out string cao,out string n,out string gia)
//         {
//             Console.Write("Ma thang: ");
//             ma=Console.ReadLine();
//             Console.Write("Loai thang: ");
//             ten=Console.ReadLine();
//             Console.Write("Chieu Cao: ");
//             cao=Console.ReadLine();
//             Console.Write("So luong: ");
//             n=Console.ReadLine();
//             Console.Write("Gia ban: ");
//             gia=Console.ReadLine();
//         }
//         static void Main(string[] args)
//         {
//             // Nhập danh sách
//             string [] lines=File.ReadAllLines(@"F:\OOP\bt_DongGoi\thang.txt");
//             int row=lines.Length;
//             int column=(lines[0].Split(";").Length);
//             string[,]ds=new string[row, column];
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     ds[i,j]=lines[i].Trim().Split(";")[j];
//                 }
//             }
//             ThangLeo thang = new ThangLeo();
//             for (int i=0;i<row;i++)
//             {
//                 for (int j=0;j<column;j++)
//                 {
//                     thang[i,j]=ds[i,j].Trim();
//                 }
//             } 
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
//                     string i0="",i1="",i2="",i3="",i4="";
//                     Them(out i0,out i1,out i2,out i3,out i4);
//                     string dk="True";
//                     if (i0=="" || i1=="" || i2=="" ||i3==""||i4=="" ||i0==" " || i1==" " || i2==" " ||i3==" "||i4==" ")
//                         {
//                             Console.WriteLine("Khong duoc nhap du lieu rong.");
//                             dk="False";
//                         }
//                     else
//                     {
//                         for (int i=0;i<100;i++)
//                         {
//                             if(i0==thang[i,0])
//                             {
//                                 Console.WriteLine("Ma thang nay da ton tai.");
//                                 dk="False";
//                                 break;
//                             }
//                         }
//                     }
//                     if (dk=="True")
//                     {
//                         thang[row,0]=i0;
//                         thang[row,1]=i1;
//                         thang[row,2]=i2;
//                         thang[row,3]=i3;
//                         thang[row,4]=i4;
//                         row++;
//                         Console.WriteLine(" _______________________");
//                         Console.WriteLine("|   DA THEM THANH CONG  |");
//                         Console.WriteLine("|_______________________|");
//                     }
//                 }
//                 else if (cv==2)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|     XUAT DANH SACH    |");
//                     Console.WriteLine("|_______________________|");
//                     for (int i=0;i<row;i++)
//                     {
                        
//                         Console.Write(i+1+". ");
//                         for (int j=0;j<column;j++)
//                         {
//                             Console.Write(thang[i,j]+"; ");
//                         }
//                         Console.WriteLine();
//                     }
//                 }
//                 else if (cv==3)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|      TIM SAN PHAM     |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Nhap khoang chieu cao cua thang leo ban muon tim: ");
//                     var num=Console.ReadLine();
//                     var a_b=num.Split(" ");
//                     int a=int.Parse(a_b[0]);
//                     int b=int.Parse(a_b[1]);
//                     if (a<=b)
//                     {
//                         string tim="False";
//                         for (int x=a;x<=b;x++)
//                         {
//                             string so=Convert.ToString(x)+"m";
//                             for (int i=0;i<100;i++)
//                             {
//                                 if (thang[i,2]==so)
//                                 {
//                                     tim="True";
//                                     for (int j=0;j<column;j++)
//                                     {
//                                         Console.Write(thang[i,j]+"; ");
//                                     }
//                                     Console.WriteLine();
//                                 }
//                             }
//                         }
//                         if (tim=="False")
//                         {
//                             Console.WriteLine("Khong tim thay thang thoa man dieu kien.");
//                         }
//                     }
//                     else Console.WriteLine("Chieu cao ban nhap khong chinh xac");
//                 }
//                 else if (cv==4)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|        SAP XEP        |");
//                     Console.WriteLine("|_______________________|");
//                     // Tạo một mảng chứa các mức giá (kiểu float)
//                     float[] PRICE=new float[row];
//                     for (int i=0;i<row;i++)
//                     {
//                         PRICE[i]=float.Parse(thang[i,4]);
//                     }
//                     // Sắp xếp các phần tử trong mảng
//                     Array.Sort(PRICE);
//                     // Loại giá trị trùng lặp
//                     // Nếu giá trị không trùng lặp, thêm giá trị này vào mảng price[]
//                     string [] price = new string [row];
//                     int k=0;
//                     for (int i=0;i<row-1;i++)
//                     {
//                         if(PRICE[i]!=PRICE[i+1])
//                         {
//                             price[k]=Convert.ToString(PRICE[i]);
//                             k++;
//                             // Như vậy, k là số phần tử thật sự của mảng price[]
//                         }
//                     }
//                     if (PRICE[row-1]!=PRICE[row-2])
//                     {
//                         price[k]=Convert.ToString(PRICE[row-1]);
//                         k++;
//                     }
                    
//                     // Tạo và sắp xếp các phần tử của thang theo giá bán vào 1 mảng trung gian
//                     string[,]tg=new string [row,column];
//                     int i_tg=0;
//                     for(int a=0;a<k;a++)
//                     {
//                         for (int i=0;i<row;i++)
//                         {
//                             if (thang[i,4]==price[a])
//                             {
//                                 for (int j=0;j<column;j++)
//                                 {
//                                     tg[i_tg,j]=thang[i,j];
//                                 }
//                                 i_tg++;
//                             }
//                         }
//                     }
//                     // Gán các phần tử của mảng ảo thang[] = các phần tử của mảng tg[] để sắp xếp mảng theo giá
//                     for (int i=0;i<row;i++)
//                     {
//                         for (int j=0;j<column;j++)
//                         {
//                             thang[i,j]=tg[i,j];
//                         }
//                     }
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("| DA SAP XEP THANH CONG |");
//                     Console.WriteLine("|_______________________|");
//                     Console.WriteLine("Neu ban muon xem lai danh sach, hay bam phim 2.");
//                 }
//                 else if (cv==5)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|       KIEM TRA        |");
//                     Console.WriteLine("|_______________________|");
//                     Console.Write("Ma thang: ");
//                     string ma=Console.ReadLine();
//                     Console.Write("So luong: ");
//                     int sl=int.Parse(Console.ReadLine());
//                     string DK="False";
//                     for (int i=0;i<row;i++)
//                     {
//                         if (thang[i,0]==ma)
//                         {
//                             DK="True";
//                             int num=int.Parse(thang[i,3]);
//                             if (sl<=num)
//                             {
//                                 Console.WriteLine("OK");
//                             }
//                             else
//                             {
//                                 Console.WriteLine("CHI CON "+num+" THANG. KHONG DU HANG.");
//                             }
//                             break;
//                         }
//                     }
//                     if (DK=="False")
//                     {
//                         Console.WriteLine("Ma thang nay khong ton tai.");
//                     }
//                 }
//                 else if (cv==6)
//                 {
//                     Console.WriteLine(" _______________________");
//                     Console.WriteLine("|        SO SANH        |");
//                     Console.WriteLine("|_______________________|");
//                     // Nhập điều kiện so sánh
//                     Console.Write("Loai thang: ");
//                     string loai=Console.ReadLine();
//                     Console.Write("Chieu cao: ");
//                     string cao=Console.ReadLine();
//                     string kt="False";
//                     // Tao mang thang_tm[] chua cac thang thoa man dieu kien
//                     string [,] thang_tm=new string [row,column];
//                     int tt=0;
//                     for (int i=0;i<row;i++)
//                     {
//                         if (thang[i,1]==loai & thang[i,2]==cao)
//                         {
//                             kt="True";
//                             for (int j=0;j<column;j++)
//                             {
//                                 thang_tm[tt,j]=thang[i,j];
//                             }
//                             tt++;
//                             // Nhu vay, tt chinh la so phan tu that su cua mang thang_tm[]


//                         }
//                     }
//                     if (kt=="False")
//                     {
//                         Console.WriteLine("Phan khuc nay khong ton tai");
//                     }
//                     else
//                     {
//                     // Tao mang Gia[] chua cac muc gia cua thang
//                     float[] Gia=new float[tt];
//                     for (int i=0;i<tt;i++)
//                     {
//                         Gia[i]=float.Parse(thang_tm[i,4]);
//                     }
//                     Array.Sort(Gia);
//                     Console.WriteLine("Phan khuc ban chon co muc gia "+Gia[0]+" - "+Gia[tt-1]+" trieu VND.");
//                     }
//                 }
//                 else if (cv==0) break;
//             }
//         }
//     }
// }