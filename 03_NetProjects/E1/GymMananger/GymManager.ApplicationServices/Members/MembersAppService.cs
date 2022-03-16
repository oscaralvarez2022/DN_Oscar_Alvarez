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
                Name = "Moy",
                LastName = "alvarez",
                BirthDay = new DateTime(1982, 03, 18),
                AllowNewsletter = true,
                CityId = 2,
                Email = "moises@micorre.com"
            }) ;

            return members;
        }
    }
}
