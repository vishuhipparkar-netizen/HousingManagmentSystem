using Microsoft.AspNetCore.Identity;    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Infrastructure.Identity
{
   public class ApplicationUser : IdentityUser
    {
        public string FulltName { get; set; }=string.Empty;
        public string? ProfilePhoto { get; set; }

    }
}
