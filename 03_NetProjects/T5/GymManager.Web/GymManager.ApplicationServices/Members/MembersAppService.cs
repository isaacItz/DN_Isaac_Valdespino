using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService : IMembersAppService
    {
        private static List<Member> Members = new List<Member>();
        public int AddMember(Member member)
        {
            member.Id = new Random().Next();
            Members.Add(member);
            return member.Id;
        }
        public List<Member> GetMembers()
        {
            return Members;
        }

        public void DeleteMember(int memberId)
        {
            var member = GetMember(memberId);
            Members.Remove(member);
        }

        public Member GetMember(int memberId)
        {
            var member = Members.Where(x => x.Id == memberId).FirstOrDefault();
            return member;
        }

        public void EditMember(Member member)
        {
            var m = GetMember(member.Id);
            m.Name = member.Name;
            m.LastName = member.LastName;
            m.BirthDay = member.BirthDay;
            m.Email = member.Email;
            m.CityId = member.CityId;
            m.AllowNewsLetter = member.AllowNewsLetter;
        }
    }
}
