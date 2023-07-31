using Casgem_ObServer.DAL;

namespace Casgem_ObServer.ObServerPattern
{
    public class CreateWelcomeMessage : IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider, Context context)
        {
            _serviceProvider = serviceProvider;
         
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessageges.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize abone olduğuunuz için teşekkür ederiz, hoş geldiniz"
            }
                );
            context.SaveChanges();
        }
    }
}
