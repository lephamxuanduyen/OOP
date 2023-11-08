// namespace Bai4
// {
//     class Info
//     {
//         public string ID { get; set; }
//         public string Hoten { get; set; }
//         public string Group { get; set; }
//     }
//     class DiemTP
//     {
//         public float TP1 { get; set; }
//         public float TP2 { get; set; }
//         public float TP3 { get; set; }
//         public double tinhTB(float a,float b,float c)
//         {
//             return Math.Round((a*0.1+b*0.3+c*0.6),2);
//         }
//     }
//     class Program
//     {
        
//         static void Main(string[] args)
//         {
//             string input_info=File.ReadAllText(@"Info.txt");
//             string[,] DSSV = new string[100,4];
//             int i,j;
//             i=0;
//             foreach (var row in input_info.Split("\n"))
//             {
//                 string[] SV = new string[3];
//                 j=0;
//                 foreach (var col in row.Split(";"))
//                 {
//                     SV[j]=col.Trim();
//                     j++;
//                 }
//                 Info sv = new Info();
//                 sv.ID = SV[0];
//                 sv.Hoten = SV[1];
//                 sv.Group = SV[2];
//                 DSSV[i,0]=SV[0];
//                 DSSV[i,1]=SV[1];
//                 DSSV[i,2]=SV[2];
//                 i++;
//             }
//             string input_diem = File.ReadAllText(@"DiemTP.txt");
//             int a,b;
//             a=0;
//             foreach (var row in input_diem.Split("\n"))
//             {
//                 float[] diem = new float[3];
//                 b=0;
//                 foreach (var col in row.Split(";"))
//                 {
//                     diem[b]=float.Parse(col.Trim());
//                     b++;
//                 }
//                 DiemTP d = new DiemTP();
//                 d.TP1 = diem[0];
//                 d.TP2 = diem[1];
//                 d.TP3 = diem[2];
//                 double tb = d.tinhTB(diem[0],diem[1],diem[2]);
//                 DSSV[a,3]=Convert.ToString(tb);
//                 a++;
//             }
//             Console.WriteLine("So luong sinh vien co trong lop hoc phan OOP: "+i);
//             Console.WriteLine("{0,-5}| {1,-20}| {2,-5}| {3,5}","ID","Ho ten","Group","Diem TB");
//             for (int k=0;k<i;k++)
//             {
//                 Console.WriteLine("{0,-5}| {1,-20}| {2,-5}| {3,5}",DSSV[k,0],DSSV[k,1],DSSV[k,2],DSSV[k,3]);
//             }
//         }
//     }
// }