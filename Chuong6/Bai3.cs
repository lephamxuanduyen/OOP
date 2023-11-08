// namespace Bai3
// {
//     class Edition
//     {
//         public string Title;
//         public string Author;
//         public string Year;
//         // public Edition(string Title, string Author, string Year)
//         // {
//         //     this.Title=Title;
//         //     this.Author=Author;
//         //     this.Year=Year;
//         // }
//         public virtual void Nhap()
//         {
//             Console.WriteLine();
//         }
//         public virtual void CompartTo()
//         {
//             Console.WriteLine();
//         }
//         public virtual void Tim_TG()
//         {
//             Console.WriteLine();
//         }
//     }
//     class Book: Edition
//     {
//         public string Publisher;
//         // public Book(string Title, string Author, string Year, string Publisher): base(Title, Author,Year)
//         // {
//         //     this.Publisher=Publisher;
//         // }
//         private Book[] l_book= new Book[100];
//         public override void Nhap()
//         {
//             string input = File.ReadAllText(@"book_b3.txt");
//             int i=0,j=0;
//             string[,] res = new string[100,4];
//             foreach (var row in input.Split("\n"))
//             {
//                 j=0;
//                 foreach (var col in row.Split(";"))
//                 {
//                     res[i,j] = col.Trim();
//                     j++;
//                 }
//                 // Book a = new Book(res[i,0],res[i,1],res[i,2],res[i,3]);
//                 Book a = new Book();
//                 a.Title = res[i,0];
//                 a.Author = res[i,1];
//                 a.Year = res[i,2];
//                 a.Publisher = res[i,3];
//                 l_book[i] = a;
//                 i++;
//             }
//         }
//         // public Book this[int i]
//         // {
//         //     get
//         //     {
//         //         Book tm;
//         //         if (i>=0 & i<100)
//         //         {
//         //             tm = l_book[i];
//         //         }
//         //         else
//         //         {
//         //             tm=null;
//         //         }
//         //         return tm;
//         //     }
//         //     set
//         //     {
//         //         if (i>=0 & i<100)
//         //         {
//         //             l_book[i] = value;
//         //         }
//         //     }
//         // }
//         public override void CompartTo()
//         {
//             string[] book_name = new string [100];
//             int i=0;
//             foreach (Book book in l_book)
//             {
//                 if (book.Title!="")
//                 {
//                     book_name[i] = book.Title;
//                     i++;
//                 }
//             }
//             Array.Sort(book_name);
//             Book[] tg = new Book[100];
//             int j=0;
//             while (j!=i)
//             {
//                 foreach (Book book in l_book)
//                 {
//                     if (book.Title == book_name[j])
//                     {
//                         tg[j] = book;
//                         j++;
//                         break;
//                     }
//                 }
//             }
//             for (int x=0; x<i;x++)
//             {
//                 l_book[x]=tg[x];
//             }
//             foreach (Book book in l_book)
//             {
//                 Console.WriteLine(book.Title+"; "+book.Author+"; "+book.Publisher+"; "+book.Year);
//             }
//         }
//         public override void Tim_TG()
//         {
//             Console.Write("Nhap ten tac gia: ");
//             string ten_tg = Console.ReadLine();
//             foreach (Book book in l_book)
//             {
//                 if (book.Title == ten_tg)
//                 {
//                     Console.WriteLine(book.Title+"; "+book.Author+"; "+book.Publisher+"; "+book.Year);
//                 }
//             }
//         }
//     }
//     class Article: Edition
//     {
//         public string Journal;
//         // public Article(string Title, string Author, string Year, string Journal): base(Title, Author,Year)
//         // {
//         //     this.Journal=Journal;
//         // }
//         private Article[] l_article= new Article[100];
//         public override void Nhap()
//         {
//             string input = File.ReadAllText(@"article_b3.txt");
//             int i=0,j=0;
//             string[,] res = new string[100,4];
//             foreach (var row in input.Split("\n"))
//             {
//                 j=0;
//                 foreach (var col in row.Split(";"))
//                 {
//                     res[i,j] = col.Trim();
//                     j++;
//                 }
//                 // Article a = new Article(res[i,0],res[i,1],res[i,2],res[i,3]);
//                 Article a = new Article();
//                 a.Title = res[i,0];
//                 a.Author = res[i,1];
//                 a.Year = res[i,2];
//                 a.Journal = res[i,3];
//                 l_article[i] = a;
//                 i++;
//             }
//         }
//         // public Article this[int i]
//         // {
//         //     get
//         //     {
//         //         Article tm;
//         //         if (i>=0 & i<100)
//         //         {
//         //             tm = l_article[i];
//         //         }
//         //         else
//         //         {
//         //             tm=null;
//         //         }
//         //         return tm;
//         //     }
//         //     set
//         //     {
//         //         if (i>=0 & i<100)
//         //         {
//         //             l_article[i] = value;
//         //         }
//         //     }
//         // }
//         public override void CompartTo()
//         {
//             string[] article_name = new string [100];
//             int i=0;
//             foreach (Article article in l_article)
//             {
//                 if (article.Title!="")
//                 {
//                     article_name[i] = article.Title;
//                     i++;
//                 }
//             }
//             Array.Sort(article_name);
//             Article[] tg = new Article[100];
//             int j=0;
//             while (j!=i)
//             {
//                 foreach (Article article in l_article)
//                 {
//                     if (article.Title == article_name[j])
//                     {
//                         tg[j] = article;
//                         j++;
//                         break;
//                     }
//                 }
//             }
//             for (int x=0; x<i;x++)
//             {
//                 l_article[x]=tg[x];
//             }
//             foreach (Article article in l_article)
//             {
//                 Console.WriteLine(article.Title+"; "+article.Author+"; "+article.Journal+"; "+article.Year);
//             }
//         }
//         public override void Tim_TG()
//         {
//             Console.Write("Nhap ten tac gia: ");
//             string ten_tg = Console.ReadLine();
//             foreach (Article article in l_article)
//             {
//                 if (article.Title == ten_tg)
//                 {
//                     Console.WriteLine(article.Title+"; "+article.Author+"; "+article.Journal+"; "+article.Year);
//                 }
//             }
//         }
//     }
//     class OnlineResoure: Edition
//     {
//         public string Link;
//         public string Abstract;
//         // public OnlineResoure(string Title, string Author, string Link, string Abstract, string Year): base(Title, Author,Year)
//         // {
//         //     this.Link=Link;
//         //     this.Abstract=Abstract;
//         // }
//         private OnlineResoure[] l_onlres = new OnlineResoure[100];
//         public override void Nhap()
//         {
//             string input = File.ReadAllText(@"onl_res_b3.txt");
//             int i=0,j=0;
//             string[,] res = new string[100,5];
//             foreach (var row in input.Split("\n"))
//             {
//                 j=0;
//                 foreach (var col in row.Split(";"))
//                 {
//                     res[i,j] = col.Trim();
//                     j++;
//                 }
//                 // OnlineResoure a = new OnlineResoure(res[i,0],res[i,1],res[i,2],res[i,3],res[i,4]);
//                 OnlineResoure a = new OnlineResoure();
//                 a.Title = res[i,0];
//                 a.Author = res[i,1];
//                 a.Year = res[i,2];
//                 a.Link = res[i,3];
//                 a.Abstract = res[i,4];
//                 l_onlres[i] = a;
//                 i++;
//             }
//         }
//         // public OnlineResoure this[int i]
//         // {
//         //     get
//         //     {
//         //         OnlineResoure tm;
//         //         if (i>=0 & i<100)
//         //         {
//         //             tm = l_onlres[i];
//         //         }
//         //         else
//         //         {
//         //             tm=null;
//         //         }
//         //         return tm;
//         //     }
//         //     set
//         //     {
//         //         if (i>=0 & i<100)
//         //         {
//         //             l_onlres[i] = value;
//         //         }
//         //     }
//         // }
//         public override void CompartTo()
//         {
//             string[] onlres_name = new string [100];
//             int i=0;
//             foreach (OnlineResoure onlres in l_onlres)
//             {
//                 if (onlres.Title!="")
//                 {
//                     onlres_name[i] = onlres.Title;
//                     i++;
//                 }
//             }
//             Array.Sort(onlres_name);
//             OnlineResoure[] tg = new OnlineResoure[100];
//             int j=0;
//             while (j!=i)
//             {
//                 foreach (OnlineResoure onlres in l_onlres)
//                 {
//                     if (onlres.Title == onlres_name[j])
//                     {
//                         tg[j] = onlres;
//                         j++;
//                         break;
//                     }
//                 }
//             }
//             for (int x=0; x<i;x++)
//             {
//                 l_onlres[x]=tg[x];
//             }
//             foreach (OnlineResoure onlres in l_onlres)
//             {
//                 Console.WriteLine(onlres.Title+"; "+onlres.Author+"; "+onlres.Link+"; "+onlres.Abstract+"; "+onlres.Year);
//             }
//         }
//         public override void Tim_TG()
//         {
//             Console.Write("Nhap ten tac gia: ");
//             string ten_tg = Console.ReadLine();
//             foreach (OnlineResoure onlres in l_onlres)
//             {
//                 if (onlres.Title == ten_tg)
//                 {
//                     Console.WriteLine(onlres.Title+"; "+onlres.Author+"; "+onlres.Abstract+"; "+onlres.Link+"; "+onlres.Year);
//                 }
//             }
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Book book = new Book();
//             book.Nhap();
//             book.CompartTo();
//             book.Tim_TG();

//             Article article = new Article();
//             article.Nhap();
//             article.CompartTo();
//             article.Tim_TG();

//             OnlineResoure onlineResoure = new OnlineResoure();
//             onlineResoure.Nhap();
//             onlineResoure.CompartTo();
//             onlineResoure.Tim_TG();
//         }
//     }
// }

// //   https://vb2cnttk8.blogspot.com/2018/10/exercise-java-oop-quan-ly-thu-vien.html

// //   https://v1study.com/csharp-solution-practical-3-exrcise-2.html

// using System;
// namespace C_
// {
//     class Meo 
//     {
//         public string Tenmeo; public static int dem=0;
//         public  string giong; public string gioitinh ; public int tuoi ; 
//         public void Nhap()
//         {
//             Console.WriteLine("Nhap ten meo :");
//             Tenmeo = (Console.ReadLine());
//             Console.WriteLine("Nhap giong :");
//             giong=(Console.ReadLine());
//             Console.WriteLine("Nhap  gioi tinh :");
//             gioitinh = (Console.ReadLine());
//             Console.WriteLine("Nhap tuoi :");
//             tuoi = int.Parse(Console.ReadLine());
            
//         }
//         public void Xuat()
//         {
//             Console.WriteLine("meo {0}, giong {1}, gioi tinh {2}, tuoi {3} ",Tenmeo,giong,gioitinh ,tuoi);
//         }
//         // ~ sach()
//         // {
//         // Console.WriteLine("Doi tuong Sach da bi huy.");
//         // }
//         public Meo()
//         {
//             dem++;
//         }
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Meo m1=new Meo();
//             Meo m2=new Meo();
//             m1.Nhap();
//             m1.Xuat();
          
//             m2.Nhap();
//             m2.Xuat();
//             Console.WriteLine("So luong :"+Meo.dem);
//         }
//     }
// }