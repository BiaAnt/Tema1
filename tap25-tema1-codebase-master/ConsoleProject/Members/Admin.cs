using ConsoleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Members
{
    class Admin:IMember
    {
        public string Name { get; private set; }

        public Admin(string name)
        {
            Name = name;
        }
    }
}
