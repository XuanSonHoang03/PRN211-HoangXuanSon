using BusinessObject;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> memberList = new List<MemberObject>()
        {
            new MemberObject(11,"Hoang Xuan Son","sonhx@gmail.com", "123", "Ha Noi","VietNam"),
            new MemberObject(2,"Nguyen Nhu Phuong","nphuong@gmail.com", "123", "Ha Noi","Thailand"),
            new MemberObject(3,"Phan Huong Chi","hchi@gmail.com", "123", "Hung Yen","VietNam"),
            new MemberObject(4,"Bao Duc Chu","ducchung@gmail.com", "123", "Paris","France"),
            new MemberObject(5,"Cao Duc Co","duccong@gmail.com", "123", "New York","US"),
            new MemberObject(6,"Dung Duc Mo","ducmong@gmail.com", "123", "Phu Tho","VietNam"),
            new MemberObject(7,"Ly Duc Thim","ducthimng@gmail.com", "123", "Thanh Hoa","VietNam"),
            new MemberObject(8,"Van Duc Chau","ducchaung@gmail.com", "123", "Ha Noi","VietNam"),
            new MemberObject(9,"Nguyen Duc Di","ducding@gmail.com", "123", "Phu Tho","VietNam"),
            new MemberObject(10,"Sao Duc Cau","duccaung@gmail.com", "123", "Phu Ket","Thailand")
        };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminEmail = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];     
            memberList.Add(new MemberObject(1, "Admin", adminEmail, adminPassword, "Ha Noi", "VietNam"));
        }
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
        public List<MemberObject> GetListAllMember(bool descending = false)
        {
            if (descending)
            {
                return memberList.OrderByDescending(mb => mb.MemberName).ToList();
            }
            else
            {
                return memberList.OrderBy(mb => mb.MemberName).ToList();
            }
        }

        public MemberObject GetMemberByEmailPassword(string email, string password)
        {
            return memberList.SingleOrDefault(mb =>
                 mb.Email.Equals(email) && mb.Password.Equals(password)
            );
        }
        public MemberObject GetMemberByID(int id)
        {
            return memberList.SingleOrDefault(member => member.MemberID == id);
        }

        public void InsertMember(MemberObject member)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(member.Email);
            if (GetMemberByID(member.MemberID) == null && member.Email.Trim() != "" && member.Password.Trim() != "" && match.Success)
            {
                memberList.Add(member);
                return;
            }
            else
            {
                throw new Exception("Member existed");
            }
        }

        public void UpdateMember(MemberObject Umember)
        {
            MemberObject member = GetMemberByID(Umember.MemberID);
            if (member != null)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(Umember.Email);

                if (Umember.Email != null && Umember.Password != null && match.Success)
                {
                    member.MemberName = Umember.MemberName;
                    member.Email = Umember.Email;
                    member.Password = Umember.Password;
                    member.City = Umember.City;
                    member.Country = Umember.Country;

                    return;
                }
                else
                {
                    throw new Exception("Invalid email, password, or format");
                }
            }
            else
            {
                throw new Exception("Member not found");
            }
        }


        public void DeleteMember(int id)
        {
            MemberObject member = GetMemberByID(id);
            if (member != null)
            {
                memberList.Remove(member);
            }
            else
            {
                throw new Exception("Member did not existed");
            }
        }
        public List<MemberObject> searchMemberByName(String name, List<MemberObject> list)
        {
            if (list == null)
            {
                list = memberList;
            }
            return list.Where(mb => mb.MemberName.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<MemberObject> searchMemberById(int id, List<MemberObject> list)
        {
            if (list == null)
            {
                list = memberList;
            }
            return list.Where(mb => mb.MemberID.ToString().Contains(id.ToString())).ToList();
        }

        public List<MemberObject> filterByCity(String city, List<MemberObject> list)
        {
            if (list == null)
            {
                list = memberList;
            }
            return list.Where(mb => mb.City.Equals(city)).ToList();
        }

        public List<MemberObject> filterByCountry(String Country, List<MemberObject> list)
        {
            if (list == null)
            {
                list = memberList;
            }
            return list.Where(mb => mb.Country.Equals(Country)).ToList();
        }
    }
}
