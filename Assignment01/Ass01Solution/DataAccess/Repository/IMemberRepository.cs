using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<member> GetMembers();
        member GetMemberByID(int id);
        void UpdateMember(member member);
        void DeleteMember(int id);
        void InsertMember(member member);
    }
}
