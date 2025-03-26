using ConsoleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleProject.Books
{
    class NonfictionBook:IBook
    {
        public string Title { get; private set; }

        public NonfictionBook(string title)
        {
            Title = title;
        }
    }
}
