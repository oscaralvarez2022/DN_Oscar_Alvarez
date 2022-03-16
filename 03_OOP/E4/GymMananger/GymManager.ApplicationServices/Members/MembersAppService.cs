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


        private static List<MembershipType> MembershipTypes = new List<MembershipType>();

        public int AddMembershipType(MembershipType membershipTypes)
        {
            membershipTypes.Id = new Random().Next();
            MembershipTypes.Add(membershipTypes);

            return membershipTypes.Id;
        }

        public void DeleteMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypeId).FirstOrDefault();

            MembershipTypes.Remove(m);
        }

        public MembershipType GetMembershipType(int membershipTypeId)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipTypeId).FirstOrDefault();

            return m;
        }

        public void EditMembershipType(MembershipType membershipType)
        {
            var m = MembershipTypes.Where(x => x.Id == membershipType.Id).FirstOrDefault();
            m.Name = membershipType.Name;
            m.Cost = membershipType.Cost;
            m.CreatedOn = membershipType.CreatedOn;
            m.Duration = membershipType.Duration;
            m.Name = membershipType.Name;

        }

        public List<MembershipType> GetMembershipTypes()
        {       
            return MembershipTypes;
        }
        
    }
}
