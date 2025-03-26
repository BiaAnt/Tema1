using ConsoleProject.Books;
using ConsoleProject.CodGresit;
using ConsoleProject.Interfaces;
using ConsoleProject.Members;
using ConsoleProject.Services;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");
            
            List<IBook> books = new List<IBook>();
            List<IMember> members = new List<IMember>();


            IMember member1 = new Admin("John Doe");

            IBook book1 = new FictionBook("The Great Gatsby");

            books.Add(book1);
            members.Add(member1);
            

            IMemberManager memberManager = new MemberManager();
            memberManager.AddMember(member1);

            IBookManager bookManager = new BookManager();
            bookManager.AddBook(book1);

            IBorrowManager borrowManager = new BorrowManager(books,members);
            borrowManager.BorrowBook(member1,book1);
            borrowManager.ReturnBook(member1, book1);


            
/*
            // This code demonstrates a library system that violates SOLID principles.
            LibrarySystem library = new LibrarySystem();
            library.AddBook("The Great Gatsby");
            library.AddMember("John Doe");
            library.BorrowBook("John Doe", "The Great Gatsby");
            library.ReturnBook("John Doe", "The Great Gatsby");

            // Hints:
            // 1. SRP: Separate the responsibilities of managing books and members into different classes.
            // 2. OCP: Use inheritance or interfaces to allow adding new book types without modifying existing code.
            // 3. LSP: Ensure that derived classes can be substituted for their base classes without altering the correctness of the program.
            // 4. ISP: Split the LibrarySystem interface into smaller, more specific interfaces.
            // 5. DIP: Depend on abstractions (e.g., interfaces) rather than concrete classes.*/
        }
    }
}
