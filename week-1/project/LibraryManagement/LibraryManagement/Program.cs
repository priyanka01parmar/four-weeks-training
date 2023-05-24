namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize collections for books, authors, and borrowers
            List<Book> books = new List<Book>();
            List<Author> authors = new List<Author>();
            List<Borrower> borrowers = new List<Borrower>();
            List<BorrowedBook> borrowedBooks = new List<BorrowedBook>();

            // Main program loop
            while (true)
            {
                DisplayMenu();

                int choice;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    
                    case 1:
                        // Add a book
                        Book.Addbook();
                       
                        break;
                    case 2:
                        // Update a book
                        
                        break;
                    case 3:
                        // Delete a book
                        break; 
                    case 4:
                        // List of all book
                        break;
                    case 16:
                        // Filter books by status
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            // Display the menu options
            Console.WriteLine("Welcome to the Library Management System!\n");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Update a book");
            Console.WriteLine("3. Delete a book");
            Console.WriteLine("4. List all books");
            Console.WriteLine("5. Add an Author");
            Console.WriteLine("6. Update an author");
            Console.WriteLine("7. Delete an author");
            Console.WriteLine("8. List all author");
            Console.WriteLine("9. Add a borrower");
            Console.WriteLine("10. Update a borrower");
            Console.WriteLine("11. Delete a borrower");
            Console.WriteLine("12. List all borrower");
            Console.WriteLine("13. Register a book a borrower");
            Console.WriteLine("14. Display borrowed books");
            Console.WriteLine("15. Search books");
            Console.WriteLine("16. Filter books by status");
            Console.WriteLine("\nEnter the number corresponding to the action you'd like to perform:");
        }
    }

    // Class definitions
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; }

        public Book(String title,Author author, int publicationyear)
        {
            Title = title; 
            Author = author;
            PublicationYear = publicationyear;
            IsAvailable = true; 
        }
        public void AddBook(string title, Author author, int publicationYear)
        {
            Console.WriteLine("Enter Title of Book:");
            Console.ReadLine();
            Console.WriteLine("Enter Author Name:");
            Console.ReadLine();
            Console.WriteLine("Enter PublicationYear of Book:");
            Console.ReadLine();

        }
        public void UpdateBook(Book book, string newTitle, Author newAuthor, int newPublicationYear)
        {
            book.Title = newTitle;
            book.Author = newAuthor;
            book.PublicationYear = newPublicationYear;
        }
             
        public void DeleteBook(Book book)
        {
            books.Remove(book);
        }
    }

    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    class Borrower
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}