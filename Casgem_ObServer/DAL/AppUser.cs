using Microsoft.AspNetCore.Identity;

namespace Casgem_ObServer.DAL
{
    public class AppUser : IdentityUser<int>
    {
        public int Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public bool District { get; set; }
    }
}
