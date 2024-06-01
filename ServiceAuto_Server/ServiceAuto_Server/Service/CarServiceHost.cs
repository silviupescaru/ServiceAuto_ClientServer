using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Service
{
    public class CarServiceHost
    {
        public CarServiceHost() 
        {
            Console.WriteLine("Connecting to Service Auto DB ...");
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.ReaderQuotas.MaxArrayLength = System.Int32.MaxValue;
            string s = ConfigurationManager.ConnectionStrings["IPAdress"].ConnectionString;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Message.ClientCredentialType = MessageCredentialType.Certificate;
            ICarService carService = new CarService();
            ServiceHost serviceHost = new ServiceHost(carService);

            try
            {
                serviceHost.AddServiceEndpoint(typeof(IUserService), tcp, "net.tcp://" + s + ":52001/Car");
                serviceHost.Open();
                Console.WriteLine("The connection to the DB was done successfully!");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to database! " + ex.ToString());
                Console.ReadLine();
            }
            finally 
            {
                serviceHost.Close();
            }
        }
    }
}
