using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubMembershipCommunity.Models
{
    public class UserInfo
    {
        public int ID { get; set; }

        public string FullName { get; set; }
        public string ChapterName { get; set; }

        public string LoginResults { get; set; }
    }
}