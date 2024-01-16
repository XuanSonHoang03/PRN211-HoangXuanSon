using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<MemberObject> GetListAllMember(bool descending = false);
        public MemberObject GetMemberByID(int id);
        public MemberObject GetMemberByEmailPassword(string email, string password);
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject Umember);
        public void DeleteMember(int id);
        public List<MemberObject> searchMemberByName(String name, List<MemberObject> list);
        public List<MemberObject> searchMemberById(int id, List<MemberObject> list);
        public List<MemberObject> filterByCity(String city, List<MemberObject> list);
        public List<MemberObject> filterByCountry(String Country, List<MemberObject> list);
    }
}
