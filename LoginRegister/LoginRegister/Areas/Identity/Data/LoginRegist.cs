using Microsoft.AspNetCore.Identity;

namespace LoginRegister.Areas.Identity.Data
{
    public class LoginRegist:IdentityUser
    {
        public string Firstname { get; set; }   
        public string Surname { get; set; }

        public string Address { get; set; }
    }
}
