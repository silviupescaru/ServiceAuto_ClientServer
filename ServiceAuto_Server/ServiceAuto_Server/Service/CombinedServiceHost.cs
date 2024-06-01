using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Service
{
    public class CombinedServiceHost
    {
        private readonly UserServiceHost _userServiceHost;
        private readonly CarServiceHost _carServiceHost;

        public CombinedServiceHost()
        {
            _userServiceHost = new UserServiceHost();
            _carServiceHost = new CarServiceHost();
        }

        public void Start()
        {
            _userServiceHost.Start();
            _carServiceHost.Start();
        }

        public void Stop()
        {
            _userServiceHost.Stop();
            _carServiceHost.Stop();
        }
    }

}
