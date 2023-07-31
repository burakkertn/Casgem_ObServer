using Casgem_ObServer.DAL;

namespace Casgem_ObServer.ObServerPattern
{
    public class CreateDiscountCode : IObServer
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider, Context context)
        {
            _serviceProvider = serviceProvider;

        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGİAGUsTOS",
                DiscountAmount = 25,
                DiscountCodeStatus = true
            }
                  );
            context.SaveChanges();
        }

    
    }
}
