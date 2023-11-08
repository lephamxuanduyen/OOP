// namespace Duyen
// {
//     class canho
//     {
//         public string ID;
//         public float Area;
//         public int Floor;
//         public float Price;
//         public void Nhap()
//         {
//             Console.Write("ID: ");
//             ID = Console.ReadLine();
//             Console.Write("Area: ");
//             Area = float.Parse(Console.ReadLine());
//             Console.Write("Floor: ");
//             Floor = int.Parse(Console.ReadLine());
//             Console.Write("Price: ");
//             Price = float.Parse(Console.ReadLine());
//         }
//         public virtual double GiaBan()
//         {
//             return 0;
//         }
//     }
//     class basic:canho
//     {
//         public override double GiaBan()
//         {
//             return Price*Area;
//         }
//     }
//     class condo: canho
//     {
//         public string View;
//         public new void Nhap()
//         {
//             base.Nhap();
//             Console.Write("View: ");
//             View = Console.ReadLine();
//         }
//         public override double GiaBan()
//         {
//             double a = 0;
//             if (View == "Bien")
//             {
//                 a = 1.4;
//             }
//             else if (View == "Ho boi")
//             {
//                 a = 1.1;
//             }
//             if (View == "Thanh pho")
//             {
//                 a = 1.2;
//             }
//             else
//             {
//                 a = 1.0;
//             }
//             return Price*Area*a;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             basic[] chbt = new basic[10];
//             condo[] chcd = new condo[10];
//             double[] p = new double[10];
//             basic bth1 = new basic();
//             bth1.Nhap();
//             Console.WriteLine("Gia: "+bth1.GiaBan());
//             chbt[0]=bth1;
//             p[0]=bth1.GiaBan();
//             basic bth2 = new basic();
//             bth2.Nhap();
//             Console.WriteLine("Gia: "+bth2.GiaBan());
//             p[1]=bth1.GiaBan();
//             p[1]=bth2.GiaBan();
//             condo caocap1 = new condo();
//             Console.WriteLine("Gia: " + caocap1.GiaBan());
//             chcd[0] = caocap1;
//             p[2] = caocap1.GiaBan();
//             condo caocap2 = new condo();
//             Console.WriteLine("Gia: " + caocap2.GiaBan());
//             chcd[1] = caocap2;
//             p[3] = caocap2.GiaBan();
//             Array.Sort(p);
//             foreach (basic ch in chbt)
//             {
//                 if (ch.GiaBan()==p[0])
//                 {
//                     Console.WriteLine(ch.ID+"; "+ch.Area+"; "+ch.Floor+"; "+ch.Price+"; "+ch.GiaBan());
//                 }
//             }
//             foreach (condo ch in chcd)
//             {
//                 if (ch.GiaBan()==p[0])
//                 {
//                     Console.WriteLine(ch.ID+"; "+ch.Area+"; "+ch.Floor+"; "+ch.Price+"; "+ch.View+"; "+ch.GiaBan());
//                 }
//             }
//         }
//     }
// }