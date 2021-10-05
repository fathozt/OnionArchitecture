using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.Domain.Entities.Authentications
{
    public class AppUser : IdentityUser<int>
    {
        public int CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
