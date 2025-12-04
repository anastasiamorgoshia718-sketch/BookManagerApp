using System;
using System.Collections.Generic;
using System.Linq;

namespace BookManagerApp
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        // ახალი წიგნის დამატება
        public void AddBook(string title, string author, int year)
        {
            var book = new Book(title, author, year);
            books.Add(book);
            Console.WriteLine("New book added successfully.");
        }

        // ყველა წიგნის სიის ჩვენება
        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("Books in the collection:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        // წიგნის ძებნა სათაურის მიხედვით
        public void SearchBookByTitle(string title)
        {
            var foundBooks = books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundBooks.Count == 0)
            {
                Console.WriteLine("No books found with that title.");
                return;
            }

            Console.WriteLine("Books found:");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
