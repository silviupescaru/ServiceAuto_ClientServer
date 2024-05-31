using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ServiceAuto_Server.Domain;
using ServiceAuto_Server.Repository;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Service
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    internal class UserService : IUserService
    {
        private IUserRepository iUserRepository;

        public UserService()
        {
            this.iUserRepository = new UserRepository();
        }
    }
}
