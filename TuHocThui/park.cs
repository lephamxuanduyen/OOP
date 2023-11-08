using System;
namespace park
{
    class CusTomer
    {
        private string name;
        private double price;
        public string Ten
        {
            get {return name;}
            set {name = value;}
        }
        public double Price
        {
            get {return price;}
            set {price = value;}
        }
        public void Nhap()
        {
            Console.Write("Ten khach hang: ");
            Ten = Console.ReadLine();
        }
        public virtual void DeoThe()
        {
            Console.Write("Deo the mau ");
        }
    }
    class Adult:CusTomer
    {
        private string id;
        public string ID
        {
            get {return id;}
            set {id = value;}
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("ID: ");
            ID = Console.ReadLine();
            Price = 250000;
        }
        public override void DeoThe()
        {
            base.DeoThe();
            Console.WriteLine("do.");
        }
    }
    class Children:CusTomer
    {
        private float high;
        public float High
        {
            get {return high;}
            set {high = value;}
        }
        public new void Nhap()
        {
            base.Nhap();
            Console.Write("High: ");
            High = float.Parse(Console.ReadLine());
            if (High>1) {Price = 130000;}
            else {Price = 0;}
        }
        public override void DeoThe()
        {
            base.DeoThe();
            Console.WriteLine("xanh.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adult nglon1 = new Adult();
            nglon1.Nhap();
            nglon1.DeoThe();
            Adult nglon2 = new Adult();
            nglon2.Nhap();
            nglon2.DeoThe();
            Children child1 = new Children();
            child1.Nhap();
            child1.DeoThe();
            Children child2 = new Children();
            child2.Nhap();
            child2.DeoThe();
            Children child3 = new Children();
            child3.Nhap();
            child3.DeoThe();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Doanh thu: " + (nglon1.Price + nglon2.Price + child1.Price + child2.Price + child3.Price));
        }
    }
}