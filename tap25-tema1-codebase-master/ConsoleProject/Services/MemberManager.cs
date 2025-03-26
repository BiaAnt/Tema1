using ConsoleProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Services
{
    class MemberManager:IMemberManager
    {
        private List<IMember> members = new List<IMember>();
        public void AddMember(IMember member)
        {
            members.Add(member);
        }
    }
}
