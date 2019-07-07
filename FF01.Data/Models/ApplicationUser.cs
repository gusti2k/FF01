using Microsoft.AspNetCore.Identity;
using System;

namespace FF01.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Rating { get; set; }
        public string ProfilImangeUrl { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsActive { get; set; }

    }
}
