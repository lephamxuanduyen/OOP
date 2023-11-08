namespace Bai3
{
    class Edition
    {
        private string title;
        private string author;
        private int year;
        public string Title
        {
            get
            {
                return title;
            }
            set 
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set 
            {
                author = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set 
            {
                year = value;
            }
        }
        public virtual void Xuat()
        {
            Console.WriteLine();
        }
    }
    class Book: Edition
    {
        private string publisher;
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }
        public void Nhap(ref Book[] ds)
        {
            string input = File.ReadAllText(@"book_b3.txt");
            int i,j;
            string[,] res = new string[100,4];
            i=0; 
            foreach (var row in input.Split("\n"))
            {
                j=0;
                foreach (var col in row.Split(";"))
                {
                    res[i,j]=col.Trim();
                    j++;
                }
                Book book = new Book();
                book.Title = res[i,0];
                book.Author = res[i,1];
                book.Year = res[i,2];
                book.Publisher = res[i,3];
                ds[i] = book;
                i++;
            }
        }
    }
    class Article: Edition
    {
        private string journal;
        public string Journal
        {
            get
            {
                return journal;
            }
            set
            {
                journal = value;
            }
        }
        public void Nhap(ref Article[] ds)
        {
            string input = File.ReadAllText(@"article_b3.txt");
            int i,j;
            string[,] res = new string[100,4];
            i=0; 
            foreach (var row in input.Split("\n"))
            {
                j=0;
                foreach (var col in row.Split(";"))
                {
                    res[i,j]=col.Trim();
                    j++;
                }
                Article article = new Article();
                article.Title = res[i,0];
                article.Author = res[i,1];
                article.Year = res[i,2];
                article.Journal = res[i,3];
                ds[i] = article;
                i++;
            }
        }
    }
    class OnlineResoure: Edition
    {
        private string link;
        public string Link
        {
            get
            {
                return link;
            }
            set
            {
                link = value;
            }
        }
        private string abstracts;
        public string Abstract
        {
            get
            {
                return abstracts;
            }
            set
            {
                abstracts = value;
            }
        }
        public void Nhap(ref OnlineResoure[] ds)
        {
            string input = File.ReadAllText(@"onl_res_b3.txt");
            int i,j;
            string[,] res = new string[100,4];
            i=0; 
            foreach (var row in input.Split("\n"))
            {
                j=0;
                foreach (var col in row.Split(";"))
                {
                    res[i,j]=col.Trim();
                    j++;
                }
                Article onl_res = new Article();
                onl_res.Title = res[i,0];
                onl_res.Author = res[i,1];
                onl_res.Year = res[i,2];
                onl_res.Publisher = res[i,3];
                ds[i] = onl_res;
                i++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book[] l_book = new Book[100];
            Article[] l_article = new Article[100];
            OnlineResoure[] l_onl_res = new OnlineResoure[100];
            Book book 
        }
    }
}