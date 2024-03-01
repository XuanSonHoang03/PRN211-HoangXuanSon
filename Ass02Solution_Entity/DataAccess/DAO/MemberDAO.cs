using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
        Ass02SolutionContext context = new Ass02SolutionContext();

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Member> GetMembers()
        {
            return context.Members.ToList();
        }
        public Member GetMemberByUserPass(string user, string pass)
        {
            return context.Members.Where(m => m.Email == user && m.Password == pass).FirstOrDefault();
        }
        public void DeleteMember(int id)
        {
            Member member = context.Members.Find(id);
            context.Members.Remove(member);
            context.SaveChanges();
        }
        public void AddMember(Member member)
        {
            context.Members.Add(member);
            context.SaveChanges();
        }
        public void UpdateMember(Member member)
        {
            context.Members.Update(member);
            context.SaveChanges();
        }
    }
}
