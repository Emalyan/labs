using System;

namespace Laba_Var9
{
    public partial class Book
    {
        public string Test;
        public string Title { get; set; }
        public string Autor { get; set; }
        public string PublicationDate { get; set; }
        public int SoldEditions { get; set; }

        public static string Genre;

        private string price;            

        public readonly string TestTwo = "TestTwo";

        public Book()
        {

        }

        public string GetPrice
        {
            get
            {
                return price;
            }
        }
        
        public string SetPrice 
        { 
            set 
            {
                price = value; 
            } 
        }

        public Book(string title, string autor, string publicationDate, int soldEditions)
        {
            Title = title;
            Autor = autor;
            PublicationDate = publicationDate;
            SoldEditions = soldEditions;
        }

        public bool IsValid()
        {
            var inputConsole = Console.ReadLine();
            var isValie = int.TryParse(inputConsole, out int _);
            return isValie;
        }

        static Book()
        {
            Console.WriteLine("Вызван статический конструктор");
        }

        public Book(Book book)
        {
            Title = book.Title;
            Autor = book.Autor;
            PublicationDate = book.PublicationDate;
            SoldEditions = book.SoldEditions;
        }

        public override bool Equals(object obj)
        {
            var book = obj as Book;
            return book != null ? book.Autor == Autor : false;
        }

        public override string ToString()
        {
            return $"{Title}, {Autor}, {PublicationDate}, {SoldEditions}";
        }

        public override int GetHashCode()
        {
            return SoldEditions;
        }



        ~Book()
        {
            Console.WriteLine("Destruct");
        }

        public static void ShowGenre()
        {
            Genre = "Ужасы";
            Console.WriteLine(Genre);
        }
    }
}
