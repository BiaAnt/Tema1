using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Interfaces;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleProject.Services
{
    class BookManager:IBookManager
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book)
        {
            books.Add(book);
        }
    }
}
