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
using ServiceAuto_Client.Language;

namespace ServiceAuto_Client.Controller
{
    public class ControllerLogin
    {
        private LoginGUI loginGUI;
        private IUserService iUserService;
        private LangHelper lang;

        public ControllerLogin(int index)
        {
            this.loginGUI = new LoginGUI(index);
            this.lang = new LangHelper();

            this.createBinding();
            this.eventsManagement();
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

        public LoginGUI GetView()
        {
            return this.loginGUI;
        }

        private void eventsManagement()
        {
            this.loginGUI.FormClosed += new FormClosedEventHandler(exitApplication);
            this.loginGUI.GetLoginButton().Click += new EventHandler(login);
            this.loginGUI.GetChangeLangugae().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.loginGUI.GetChangeLangugae().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.loginGUI.GetChangeLangugae().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.loginGUI.GetChangeLangugae().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }
        }

        private void login(object sender, EventArgs e)
        {
            try
            {
                string username = this.loginGUI.GetUsername().Text;
                string password = this.loginGUI.GetPassword().Text;

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
                    else MessageBox.Show("Wrong username or password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
