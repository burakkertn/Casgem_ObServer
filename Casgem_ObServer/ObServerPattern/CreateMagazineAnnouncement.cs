using Casgem_ObServer.DAL;

namespace Casgem_ObServer.ObServerPattern
{
    public class CreateMagazineAnnouncement : IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider, Context context)
        {
            _serviceProvider = serviceProvider;

        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProseses.Add(new UserProses
            {
                UserProsesNameSurname = appUser.Name + " " + appUser.Surname,
                UserProsesMagazine = "Spor Dergisi",
                UserProsesContent = "Dergi bültenimize abone olduğuunuz için teşekkür ederiz, hoş geldiniz"
            }
                  );
            context.SaveChanges();
        }
    }
}
