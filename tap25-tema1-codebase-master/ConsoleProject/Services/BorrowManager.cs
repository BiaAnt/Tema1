using ConsoleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Services
{
    class BorrowManager:IBorrowManager
    {
        private readonly List<IBook> books;
        private readonly List<IMember> members;
        public BorrowManager(List<IBook> books, List<IMember> members)
        {
            this.books = books;
            this.members = members;
        }

        public void BorrowBook(IMember member, IBook book)
        {
            if (books.Contains(book) && members.Contains(member))
            {
                books.Remove(book);
                Console.WriteLine($"{member.Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine("Book or member not found.");
            }
        }

        public void ReturnBook(IMember member, IBook book)
        {
            books.Add(book);
            Console.WriteLine($"{member.Name} returned {book.Title}");
        }

    }
}
