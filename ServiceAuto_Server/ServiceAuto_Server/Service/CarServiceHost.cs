using System;
using System.Configuration;
using System.ServiceModel;

namespace ServiceAuto_Server.Service
{
    public class CarServiceHost
    {
        private ServiceHost _serviceHost;

        public CarServiceHost()
        {
            Console.WriteLine("CarServiceHost initialized.");
        }

        public void Start()
        {
            Console.WriteLine("Connecting to Service Auto DB ...");
            NetTcpBinding tcp = new NetTcpBinding
            {
                OpenTimeout = new TimeSpan(0, 60, 0),
                SendTimeout = new TimeSpan(0, 60, 0),
                ReceiveTimeout = new TimeSpan(0, 60, 0),
                CloseTimeout = new TimeSpan(0, 60, 0),
                MaxReceivedMessageSize = int.MaxValue
            };
            tcp.ReaderQuotas.MaxArrayLength = int.MaxValue;

            string s = ConfigurationManager.ConnectionStrings["IPAdress"].ConnectionString;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;

            ICarService carService = new CarService();
            _serviceHost = new ServiceHost(carService);

            try
            {
                _serviceHost.AddServiceEndpoint(typeof(ICarService), tcp, "net.tcp://" + s + ":52001/Car");
                _serviceHost.Open();
                Console.WriteLine("The connection to the DB was done successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to database! " + ex);
            }
        }

        public void Stop()
        {
            if (_serviceHost != null)
            {
                try
                {
                    _serviceHost.Close();
                    Console.WriteLine("ServiceHost closed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to close ServiceHost! " + ex);
                }
            }
        }
    }
}
