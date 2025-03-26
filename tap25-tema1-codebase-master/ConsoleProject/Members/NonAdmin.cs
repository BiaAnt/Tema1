using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Members
{
    class NonAdmin
    {
        public string Name { get; private set; }

        public NonAdmin(string name)
        {
            Name = name;
        }
    }
}
