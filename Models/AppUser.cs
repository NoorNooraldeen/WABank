using Microsoft.AspNetCore.Identity;

namespace WABank.Models
{
    public class AppUser : IdentityUser
    {
        public decimal Balance { get; set; }
        public String? Image { get; set; }
    }
}
