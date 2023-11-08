// using System;
// namespace Bai2
// {
//     class ThietBi
//     {
//         public virtual void Status(string TinhNang)
//         {
//             Console.WriteLine();
//         }
//     }
//     class MayQuat: ThietBi
//     {
//         public override void Status(string TinhNang)
//         {
//             if (TinhNang=="ON")
//             {
//                 Console.WriteLine("May quat dang mo");
//             }
//             else if (TinhNang=="OFF")
//             {
//                 Console.WriteLine("May quat da tat");
//             }
//         }
//     }
//     class DieuHoa: ThietBi
//     {
//         public override void Status(string TinhNang)
//         {
//             if (TinhNang=="ON")
//             {
//                 Console.WriteLine("Dieu hoa dang mo");
//             }
//             else if (TinhNang=="OFF")
//             {
//                 Console.WriteLine("Dieu hoa da tat");
//             }
//         }
//     }
//     class Tivi: ThietBi
//     {
//         public override void Status(string TinhNang)
//         {
//             if (TinhNang=="ON")
//             {
//                 Console.WriteLine("Tivi dang mo");
//             }
//             else if (TinhNang=="OFF")
//             {
//                 Console.WriteLine("Tivi da tat");
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.Write("Thiet bi: ");
//             string tb=Console.ReadLine();
//             Console.Write("Tinh nang: ");
//             string tn=Console.ReadLine();
//             if (tb=="May quat")
//             {
//                 MayQuat q=new MayQuat();
//                 q.Status(tn);
//             }
//             else if (tb=="Dieu hoa")
//             {
//                 DieuHoa dh=new DieuHoa();
//                 dh.Status(tn);
//             }
//             else if (tb=="Tivi")
//             {
//                 Tivi tv=new Tivi();
//                 tv.Status(tn);
//             }
//         }
//     }
// }