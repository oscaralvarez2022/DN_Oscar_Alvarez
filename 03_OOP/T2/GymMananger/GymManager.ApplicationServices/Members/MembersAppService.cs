using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.ApplicationServices.Members
{
    public class MembersAppService: iMembersAppService
    {
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();

            members.Add(new Member
            {
                Name ="Israel",
                LastName ="Pérez",
                BirthDay = new DateTime(1986,9,24),
                AllowNewsletter =true,
                CityId = 1,
                Email = "isra@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Egdar",
                LastName = "García",
                BirthDay = new DateTime(2000, 10, 11),
                AllowNewsletter = false,
                CityId=2,
                Email = "edgar@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Juan",
                LastName = "López",
                BirthDay = new DateTime(1966, 9, 4),
                AllowNewsletter = true,
                CityId = 1,
                Email = "juan@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Elon",
                LastName = "Musk",
                BirthDay = new DateTime(2000, 12, 2),
                AllowNewsletter = false,
                CityId = 2,
                Email = "elon@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Bart",
                LastName = "Simpson",
                BirthDay = new DateTime(1982, 4, 20),
                AllowNewsletter = true,
                CityId = 3,
                Email = "bart@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Homero",
                LastName = "Simpson",
                BirthDay = new DateTime(1966, 2, 22),
                AllowNewsletter = false,
                CityId = 3,
                Email = "homero@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Rick",
                LastName = "Sanchez",
                BirthDay = new DateTime(1960, 2, 10),
                AllowNewsletter = true,
                CityId = 6,
                Email = "rick@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Summer",
                LastName = "Smith",
                BirthDay = new DateTime(2003, 1, 3),
                AllowNewsletter = true,
                CityId = 6,
                Email = "summer@preueba.com"
            });

            members.Add(new Member
            {
                Name = "Morty",
                LastName = "Smith",
                BirthDay = new DateTime(2008, 5, 11),
                AllowNewsletter = true,
                CityId = 6,
                Email = "morty@preueba.com"
            });

            return members;
        }
    }
}
