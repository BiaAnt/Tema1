using System;
using System.Collections.Generic;
using ConsoleProject.Members;
using ConsoleProject.Interfaces;
using ConsoleProject.Services;

namespace ConsoleProject
{
    public class LibrarySystem : IBookManager, IMemberManager, IBorrowManager
    {
        private List<IBook> books = new List<IBook>();
        private List<IMember> members = new List<IMember>();
        private IBorrowManager borrowingManager;
        private IBookManager bookManager;
        private IMemberManager memberManager;

        public LibrarySystem()
        {
            bookManager = new BookManager();
            memberManager = new MemberManager();
            borrowingManager = new BorrowManager(books, members);
        }

        public void AddBook(IBook book)
        {
            books.Add(book);
            bookManager.AddBook(book);
        }


        public void AddMember(IMember member)
        {
            members.Add(member);
            memberManager.AddMember(member);
        }

        public void BorrowBook(IMember member, IBook book)
        {
            borrowingManager.BorrowBook(member, book);
        }

        public void ReturnBook(IMember member, IBook book)
        {
            borrowingManager.ReturnBook(member, book);
        }
    }
}
