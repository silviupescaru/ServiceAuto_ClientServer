using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using ServiceAuto_Server.Domain;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Service
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        bool loginUser(User user);
    }
}
