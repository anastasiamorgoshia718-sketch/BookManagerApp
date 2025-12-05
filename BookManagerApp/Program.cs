using System;

namespace BookManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookManager = new BookManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nBook Manager Menu:");
                Console.WriteLine("1. Add a new book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search a book by title");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook(bookManager);
                        break;
                    case "2":
                        bookManager.ShowBooks();
                        break;
                    case "3":
                        SearchBook(bookManager);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // adds new book
        static void AddBook(BookManager bookManager)
        {
            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the author: ");
            string author = Console.ReadLine();

            int year;
            while (true)
            {
                Console.Write("Enter the publication year: ");
                if (int.TryParse(Console.ReadLine(), out year))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a valid number.");
                }
            }

            bookManager.AddBook(title, author, year);
        }

        // search book by title
        static void SearchBook(BookManager bookManager)
        {
            Console.Write("Enter the title to search: ");
            string title = Console.ReadLine();
            bookManager.SearchBookByTitle(title);
        }
    }
}
