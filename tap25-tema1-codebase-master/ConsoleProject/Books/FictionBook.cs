using ConsoleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Books
{
    class FictionBook:IBook
    {
        public string Title { get; private set; }

        public FictionBook(string title)
        {
            Title = title;
        }
    }
}
