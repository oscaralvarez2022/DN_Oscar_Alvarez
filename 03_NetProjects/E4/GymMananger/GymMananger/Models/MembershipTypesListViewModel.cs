using GymManager.Core.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymMananger.Web.Models
{

    public class MembershipTypesListViewModel
    {
        public int MembershipTypeCount { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
    }
}
