using Microsoft.Office.Interop.Word;
using ServiceAuto_Client.Language;
using ServiceAuto_Client.View;
using ServiceAuto_Server.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAuto_Client.Controller
{
    public class ControllerStatistics
    {
        private StatisticsGUI vStatistics;
        private Dictionary<string, uint> statistics;
        private ICarService iCarService;
        private LangHelper lang;

        private int index;

        public ControllerStatistics(int index)
        {
            this.createBindings();

            this.vStatistics = new StatisticsGUI(index);
           
            this.lang = new LangHelper();
            this.lang.Add(this.vStatistics);

            this.eventsManagement();
        }

        private void createBindings()
        {
            ChannelFactory<ICarService> channelManager;
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
            channelManager = new ChannelFactory<ICarService>(tcp, "net.tcp://" + s + ":52001/Car");
            try
            {
                this.iCarService = channelManager.CreateChannel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void eventsManagement()
        {
            this.vStatistics.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vStatistics.GetBackButton().Click += new EventHandler(backToManager);
            this.vStatistics.GetCriterion().SelectedIndexChanged += new EventHandler(showStatistics);
            this.vStatistics.GetLanguageBox().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.vStatistics.GetLanguageBox().SelectedIndex == 0)
                this.lang.ChangeLanguage("en");
            else if (this.vStatistics.GetLanguageBox().SelectedIndex == 1)
                this.lang.ChangeLanguage("fr");
            else if (this.vStatistics.GetLanguageBox().SelectedIndex == 2)
                this.lang.ChangeLanguage("ru");
        }

        private void backToManager(object sender, EventArgs e)
        {
            try
            {
                ControllerManager manager = new ControllerManager(index);
                manager.GetView();
                this.vStatistics.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public StatisticsGUI GetView()
        {
            this.vStatistics.Show();
            return this.vStatistics;
        }

        private void showStatistics(object sender, EventArgs e)
        {
            string criterion = this.vStatistics.GetCriterion().SelectedItem.ToString();


            statistics = this.iCarService.CarStatistics(this.vStatistics.GetCriterion().SelectedItem.ToString());

            if (this.statistics != null)
            {
                this.vStatistics.ClearChart();
                this.vStatistics.SetLegendsChart(criterion);
                this.vStatistics.SetSeriesChart(statistics, criterion);
                this.vStatistics.SetTitleChart("Statistics by " + criterion);
            }
        }

    }
}
