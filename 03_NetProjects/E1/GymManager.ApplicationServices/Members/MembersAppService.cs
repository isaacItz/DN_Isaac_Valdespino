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
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            members.Add(new Member
            {
                Name = "Israel",
                LastName = "Perez",
                BirthDay = new DateTime(1986, 9, 24),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "isra@prueba.com"
            });
            members.Add(new Member
            {
                Name = "Antonio",
                LastName = "Sarosi",
                BirthDay = new DateTime(1984, 9, 24),
                AllowNewsLetter = false,
                CityId = 1,
                Email = "antony@prueba.com"
            });
            members.Add(new Member
            {
                Name = "Isaac",
                LastName = "Valdespino",
                BirthDay = new DateTime(1989, 9, 24),
                AllowNewsLetter = false,
                CityId = 1,
                Email = "isaac@prueba.com"
            });
            members.Add(new Member
            {
                Name = "Ivan",
                LastName = "Blancas",
                BirthDay = new DateTime(1996, 7, 12),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "ivan@prueba.com"
            });
            members.Add(new Member
            {
                Name = "Saul",
                LastName = "Aguilar",
                BirthDay = new DateTime(1999, 9, 24),
                AllowNewsLetter = false,
                CityId = 1,
                Email = "saul@prueba.com"
            });
            members.Add(new Member
            {
                Name = "Elon",
                LastName = "Musk",
                BirthDay = new DateTime(1986, 9, 24),
                AllowNewsLetter = true,
                CityId = 1,
                Email = "muskElon@tesla.world"
            });
            return members;
        }
    }
}
