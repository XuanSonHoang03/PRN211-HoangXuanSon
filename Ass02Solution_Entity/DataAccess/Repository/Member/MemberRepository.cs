using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Member
{
    public class MemberRepository : IMemberRepository
    {
        public void AddMember(BusinessObject.Models.Member member)
        {
            MemberDAO.Instance.AddMember(member);
        }

        public void DeleteMember(int id)
        {
            MemberDAO.Instance.DeleteMember(id);
        }

        public BusinessObject.Models.Member GetMemberByUserPass(string user, string pass)
        {
            return MemberDAO.Instance.GetMemberByUserPass(user, pass);
        }

        public IEnumerable<BusinessObject.Models.Member> GetMembers()
        {
            return MemberDAO.Instance.GetMembers();
        }

        public void UpdateMember(BusinessObject.Models.Member member)
        {
            MemberDAO.Instance.UpdateMember(member);
        }
    }
}
