namespace Casgem_ObServer.Models
{
    public class RegisterViewModel
    {
        public int Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public bool District { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
