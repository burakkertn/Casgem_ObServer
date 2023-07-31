using Casgem_ObServer.DAL;
using System;

namespace Casgem_ObServer.ObServerPattern
{
    public class ObServerObject
    {
        private readonly List<IObServer> _obServers;


        public ObServerObject()
        {
            _obServers = new List<IObServer>();
        }

        public void RegisterObServer(IObServer obServer)
        {
            _obServers.Add(obServer);

        }
        public void RemoveObServer(IObServer obServer)
        {
            _obServers.Remove(obServer);

        }
        public void NotifyObServer(AppUser appUser)
        {

            _obServers.ForEach(x =>
            {
                x.CreateNewUser(appUser);



            });
        }
    }
}


