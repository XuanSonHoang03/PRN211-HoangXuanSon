using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<member> ListMembers = new List<member>()
        {
            new member {MemberID = 1,MemberName = "Hoàng Xuân Sơn",
                Email = "hson@gmail.com",Password = "123",City = "Hà Nội",Country = "Việt Nam"},
            new member {MemberID = 2,MemberName = "Nguyễn Như Phương",
                Email = "nphuong@gmail.com",Password = "123",City = "Hà Nội",Country = "Việt Nam"},
            new member {MemberID = 3,MemberName = "Phan Hương Chi",
                Email = "hchi@gmail.com",Password = "123",City = "Hưng Yên",Country = "Việt Nam"},
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock) {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<member> GetMemberList => ListMembers;
        public member getMemberByID(int memberID)
        {
            member mem = ListMembers.SingleOrDefault(pro => pro.MemberID == memberID);
            return mem;
        }
        public void DeleteMember(int memberID)
        {
            member mem = getMemberByID(memberID);
            if (mem != null)
            {
                ListMembers.Remove(mem);
            } else
            {
                throw new Exception("Car doesn't exist");
            }
        }
        public void AddNewMember(member mem)
        {
            mem = getMemberByID(mem.MemberID);
            if (mem == null)
            {
                ListMembers.Add(mem);
            }
            else
            {
                throw new Exception("Member alreadly exist");
            }
        }
        public void UpdateMember(member mem)
        {
            member mem1 = getMemberByID((int)mem.MemberID);
            if(mem1 != null)
            {
                var index = ListMembers.IndexOf(mem1);
                ListMembers[index] = mem;
            } else
            {
                throw new Exception("Member doesn't exist");
            }
        }
    }
}
