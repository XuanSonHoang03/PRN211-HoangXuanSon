using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        MemberObject GetMemberById(int memberId);
        MemberObject getMemberByEmailPass(string email, string pass);
        List<MemberObject> GetMembers();
        void InsertMember(MemberObject member);
        void UpdateMember(MemberObject member);
        void DeleteMember(int memberId);
        MemberObject SearchMemberByName(string name);
        MemberObject SearchMemberById(int id);
        MemberObject FilterByCity(string city);
        MemberObject FilterByCountry(string country);
    }
}
