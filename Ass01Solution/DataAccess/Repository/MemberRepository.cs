using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public List<MemberObject> GetListAllMember(bool descending = false) => MemberDAO.Instance.GetListAllMember(descending);

        public MemberObject GetMemberByID(int id) =>  MemberDAO.Instance.GetMemberByID(id);

        public MemberObject GetMemberByEmailPassword(string email, string password) =>
            MemberDAO.Instance.GetMemberByEmailPassword(email, password);

        public void InsertMember(MemberObject member) => MemberDAO.Instance.InsertMember(member);

        public void UpdateMember(MemberObject Umember) => MemberDAO.Instance.UpdateMember(Umember);

        public void DeleteMember(int id) => MemberDAO.Instance.DeleteMember(id);

        public List<MemberObject> searchMemberById(int id, List<MemberObject> list) =>
            MemberDAO.Instance.searchMemberById(id, list);

        public List<MemberObject> searchMemberByName(string name, List<MemberObject> list) =>
            MemberDAO.Instance.searchMemberByName(name, list);

        public List<MemberObject> filterByCity(String city, List<MemberObject> list) =>
            MemberDAO.Instance.filterByCity(city, list);

        public List<MemberObject> filterByCountry(String Country, List<MemberObject> list) =>
            MemberDAO.Instance.filterByCountry(Country, list);
    }
}
