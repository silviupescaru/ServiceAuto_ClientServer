using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceAuto_Server.Domain;
using ServiceAuto_Server.Repository;
using ServiceAuto_Server.Service;
using ServiceAuto_Client.View;
using System.ServiceModel;
using System.Configuration;
using System.Windows.Forms;

namespace ServiceAuto_Client.Controller
{
    public class ControllerLogin
    {
        private ILoginGUI iLoginGUI;
        private IUserService iUserService;

        public ControllerLogin(ILoginGUI iLoginGUI)
        {
            this.iLoginGUI = iLoginGUI;
            this.createBinding();
        }

        private void createBinding()
        {
            ChannelFactory<IUserService> channelEmployee;
            NetTcpBinding tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.Security.Mode = SecurityMode.Transport;
            tcp.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
            tcp.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;
            string s = ConfigurationManager.ConnectionStrings["IPAdress"].ConnectionString;
            channelEmployee = new ChannelFactory<IUserService>(tcp, "net.tcp://" + s + ":52001/User");
            try
            {
                this.iUserService = channelEmployee.CreateChannel();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Login()
        {
            try
            {
                string username = this.iLoginGUI.Username;
                string password = this.iLoginGUI.Password;

                if(username.Length > 0 && password.Length > 0)
                {
                    bool result = this.iUserService.LoginUser(username, password);
                    if(result == true)
                    {
                        string role = this.iUserService.GetRole(username, password);
                        if (role.Equals("Employee"))
                        {
                            MessageBox.Show("Employee success");
                        }
                        else if (role.Equals("Manager"))
                        {
                            MessageBox.Show("Manager success");
                        }
                        else if (role.Equals("Administrator"))
                        {
                            MessageBox.Show("Admin success");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
