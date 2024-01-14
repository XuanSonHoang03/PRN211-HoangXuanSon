using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        
        public void DeleteMember(int id)
        {
            MemberDAO.Instance.DeleteMember(id);    
        }

        public member GetMemberByID(int id)
        {
            return MemberDAO.Instance.getMemberByID(id);
        }

        public IEnumerable<member> GetMembers()
        {
            return MemberDAO.Instance.GetMemberList;
        }

        public void InsertMember(member member)
        {
            MemberDAO.Instance.AddNewMember(member);
        }

        public void UpdateMember(member member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
