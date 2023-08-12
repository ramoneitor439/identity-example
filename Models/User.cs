using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityJWT.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string CI { get; set; } = null!;
        [Required]
        public string Role { get; set; } = null!;
    }
}
