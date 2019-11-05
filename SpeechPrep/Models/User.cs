﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpeechPrep.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; };
        [Required]
        public string LastName { get; set; };
        public MembershipType MembershipType { get; set; };
        public byte MembershipTypeId { get; set; };
    }
}