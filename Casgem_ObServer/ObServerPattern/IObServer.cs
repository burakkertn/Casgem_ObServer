using Casgem_ObServer.DAL;

namespace Casgem_ObServer.ObServerPattern
{
    public interface IObServer
    {
        void CreateNewUser(AppUser appUser);
    }
}
