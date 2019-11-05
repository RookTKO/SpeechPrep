using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpeechPrep.Models
{
    public class User : IdentityUser
    {
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}