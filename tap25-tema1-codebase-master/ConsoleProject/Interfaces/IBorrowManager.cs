using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Interfaces
{
    public interface IBorrowManager
    {
        void BorrowBook(IMember member, IBook book);
        void ReturnBook(IMember member, IBook book);
    }
}
