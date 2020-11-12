using System;

namespace Open_Lab_10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetTitle("The Return of the King");
            LOTR.SetPages(416);
            LOTR.SetCategory("Fantasy book");
            LOTR.SetAuthor("J.R.R. Tolkien");
            LOTR.SetReleaseDate("1 December 2003");
            LOTR.PrintBookInfo();
            Console.ReadKey();
        }
    }
    class Book
    {
        string title;
        int pages;
        string category;
        string author;
        string releaseDate;

        public void SetTitle(string str)
        {
            this.title = str;
        }
        public void SetPages(int i)
        {
            this.pages = i;
        }
        public void SetCategory(string str)
        {
            this.category = str;
        }
        public void SetAuthor(string str)
        {
            this.author = str;
        }
        public void SetReleaseDate(string str)
        {
            this.releaseDate = str;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine("Title of the book: " + title);
            Console.WriteLine("Author of the book: " + author);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Pages: " + pages);
            Console.WriteLine("Release date: " + releaseDate);
        }
    }
}