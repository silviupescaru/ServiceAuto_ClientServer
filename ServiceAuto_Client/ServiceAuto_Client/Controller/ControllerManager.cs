using ServiceAuto_Client.Language;
using ServiceAuto_Client.Service;
using ServiceAuto_Client.View;
using ServiceAuto_Server.Domain;
using ServiceAuto_Server.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ServiceAuto_Client.Controller
{
    public class ControllerManager
    {
        private ManagerGUI vManager;
        private ICarService iCarService;
        private LoginGUI vLogin;
        private LangHelper lang;
        private int index;

        public ControllerManager(int index)
        {
            this.vManager = new ManagerGUI(index);
            this.vLogin = new LoginGUI(index);
            this.lang = new LangHelper();
            this.lang.Add(this.vManager);

            this.index = index;

            this.createBindings();
            this.eventsManagement();
        }

        public ManagerGUI GetView()
        {
            this.vManager.Show();
            return this.vManager;
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
            this.vManager.FormClosed += new FormClosedEventHandler(exitApplication);
            this.vManager.GetSearchButton().Click += new EventHandler(searchBy);
            this.vManager.GetFilterBy().SelectedIndexChanged += new EventHandler(filterBy);
            this.vManager.GetOrderBy().SelectedIndexChanged += new EventHandler(orderBy);
            this.vManager.GetViewAllButton().Click += new EventHandler(viewAll);
            this.vManager.GetSaveCSVButton().Click += new EventHandler(saveCSV);
            this.vManager.GetSaveJSONButton().Click += new EventHandler(saveJSON);
            this.vManager.GetSaveXMLButton().Click += new EventHandler(saveXML);
            this.vManager.GetSaveDOCButton().Click += new EventHandler(saveDOC);
            this.vManager.GetStatisticsButton().Click += new EventHandler(showStatistics);
            this.vManager.GetLogoutButton().Click += new EventHandler(logout);
            this.vManager.GetCarTable().RowStateChanged += new DataGridViewRowStateChangedEventHandler(setCarControls);
            this.vManager.GetLanguageBox().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.vManager.GetLanguageBox().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.vManager.GetLanguageBox().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.vManager.GetLanguageBox().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }
        }

        private void searchBy(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                    this.vManager.GetCarTable().Rows.Clear();

                if (this.vManager.GetSearchBy().Text.Length > 0)
                {
                    List<Car> listEngineNo = this.iCarService.SearchCarByEngineNo(this.vManager.GetSearchBy().Text);
                    List<Car> listPlateNo = this.iCarService.SearchCarByPlate(this.vManager.GetSearchBy().Text);
                    if (listEngineNo == null)
                    {
                        if (listPlateNo == null)
                            MessageBox.Show(this.lang.GetString("messageBoxNoCarDesiredEngineNo"));
                        else
                        {
                            foreach (Car car in listPlateNo)
                            {
                                if (car != null)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                    this.vManager.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (Car car in listEngineNo)
                        {
                            if (car != null)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                this.vManager.GetCarTable().Rows.Add(row);
                            }
                        }
                    }
                }
                else MessageBox.Show(this.lang.GetString("messageBoxSearchEmpty"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void filterBy(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                    this.vManager.GetCarTable().DataSource = this.iCarService.EmptyTable();

                string selectedOption = this.vManager.GetFilterBy().Text;

                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        this.vManager.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Owner(this.vManager.GetOwner().Text);
                        if (list != null)
                        {
                            foreach (Car car in list)
                            {
                                if (car != null)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                    this.vManager.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        this.vManager.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Brand(this.vManager.GetBrand().Text);
                        if (list != null)
                        {
                            foreach (Car car in list)
                            {
                                if (car != null)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                    this.vManager.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        this.vManager.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Color(this.vManager.GetColor().Text);
                        if (list != null)
                        {
                            foreach (Car car in list)
                            {
                                if (car != null)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                    this.vManager.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        this.vManager.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Fuel(this.vManager.GetFuel().Text);
                        if (list != null)
                        {
                            foreach (Car car in list)
                            {
                                if (car != null)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                    this.vManager.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "YEAR")
                    {
                        this.vManager.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Year(Convert.ToInt32(this.vManager.GetYear().Text));
                        if (list != null)
                        {
                            foreach (Car car in list)
                            {
                                if (car != null)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                    row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                    this.vManager.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else MessageBox.Show(this.lang.GetString("messageBoxNoDataDesiredFilter"));

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void orderBy(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                    this.vManager.GetCarTable().Rows.Clear();

                string selectedOption = this.vManager.GetOrderBy().Text;
                if (selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "NONE")
                    {
                        List<Car> list = this.iCarService.CarList();
                        foreach (Car car in list)
                        {
                            if (car != null)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                this.vManager.GetCarTable().Rows.Add(row);
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND AND FUEL")
                    {
                        this.vManager.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_BrandFuel();
                        foreach (Car car in list)
                        {
                            if (car != null)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                                row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                                this.vManager.GetCarTable().Rows.Add(row);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void viewAll(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable() != null)
                {
                    this.vManager.GetCarTable().Rows.Clear();
                    List<Car> list = this.iCarService.CarList();
                    foreach (Car car in list)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.CarID });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Owner });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Brand });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Color });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Fuel });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Year });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.EngineNo });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.PlateNo });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Defect });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.RepairCost });
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = car.Repaired });
                        this.vManager.GetCarTable().Rows.Add(row);
                    }
                    this.vManager.GetCarTable().Rows.Add();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void saveCSV(object sender, EventArgs e)
        {
            try
            {
                FileSaveServiceFactory.FileType fileType = FileSaveServiceFactory.FileType.Excel;
                FileSaveService fileSaveService = FileSaveServiceFactory.CreateFileSaveService(fileType);

                MemoryStream chartImage = new MemoryStream();
                List<Car> carList = new List<Car>();
                string figureTitle = "Car List Figure";

                fileSaveService.CreateFile(chartImage, carList, figureTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveJSON(object sender, EventArgs e)
        {
            try
            {
                FileSaveServiceFactory.FileType fileType = FileSaveServiceFactory.FileType.JSON;
                FileSaveService fileSaveService = FileSaveServiceFactory.CreateFileSaveService(fileType);

                MemoryStream chartImage = new MemoryStream();
                List<Car> carList = new List<Car>();
                string figureTitle = "Car List Figure";

                fileSaveService.CreateFile(chartImage, carList, figureTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveXML(object sender, EventArgs e)
        {
            try
            {
                FileSaveServiceFactory.FileType fileType = FileSaveServiceFactory.FileType.XML;
                FileSaveService fileSaveService = FileSaveServiceFactory.CreateFileSaveService(fileType);

                MemoryStream chartImage = new MemoryStream();
                List<Car> carList = new List<Car>();
                string figureTitle = "Car List Figure";

                fileSaveService.CreateFile(chartImage, carList, figureTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveDOC(object sender, EventArgs e)
        {
            try
            {
                FileSaveServiceFactory.FileType fileType = FileSaveServiceFactory.FileType.Word;
                FileSaveService fileSaveService = FileSaveServiceFactory.CreateFileSaveService(fileType);

                MemoryStream chartImage = new MemoryStream();
                List<Car> carList = new List<Car>();
                string figureTitle = "Car List Figure";

                fileSaveService.CreateFile(chartImage, carList, figureTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logout(object sender, EventArgs e)
        {
            try
            {
                ControllerLogin login = new ControllerLogin(1);
                login.GetView();
                this.vManager.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void showStatistics(object sender, EventArgs e)
        {
            try
            {
                ControllerStatistics statistics = new ControllerStatistics(index);
                statistics.GetView();
                this.vManager.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void setCarControls(object sender, EventArgs e)
        {
            try
            {
                if (this.vManager.GetCarTable().SelectedRows.Count > 0)
                {
                    DataGridViewRow drvr = this.vManager.GetCarTable().SelectedRows[0];

                    uint carID = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.vManager.GetCarID().Value = carID;

                    string owner = drvr.Cells[1].Value.ToString();
                    this.vManager.GetOwner().Text = owner;

                    string brand = drvr.Cells[2].Value.ToString();
                    this.vManager.GetBrand().Text = brand;

                    string color = drvr.Cells[3].Value.ToString();
                    this.vManager.GetColor().Text = color;

                    string fuel = drvr.Cells[4].Value.ToString();
                    this.vManager.GetFuel().Text = fuel;

                    int year = Convert.ToInt32(drvr.Cells[5].Value);
                    this.vManager.GetYear().Text = year.ToString();

                    string engineNo = drvr.Cells[6].Value.ToString();
                    this.vManager.GetEngineNo().Text = engineNo;

                    string plateNo = drvr.Cells[7].Value.ToString();
                    this.vManager.GetPlateNo().Text = plateNo;

                    string defect = drvr.Cells[8].Value.ToString();
                    this.vManager.GetDefect().Text = defect;

                    float repairCost = (float)Convert.ToDouble(drvr.Cells[9].Value);
                    this.vManager.GetRepairCost().Text = repairCost.ToString();

                    bool repaired = Convert.ToBoolean(drvr.Cells[10].Value);
                    this.vManager.GetRepaired().SelectedIndex = Convert.ToInt32(repaired);

                    string imageName = brand + "_" + color;
                    string workingDirectory = Environment.CurrentDirectory;
                    workingDirectory = workingDirectory.Substring(0, workingDirectory.Length - 9);

                    string path = workingDirectory + "resources\\cars\\" + imageName + ".jpg";
                    string secondPath = workingDirectory + "resources\\cars\\noCarFound.jpg";

                    try
                    {
                        this.vManager.GetPictureBox().Image = System.Drawing.Image.FromFile(path);
                    }
                    catch
                    {
                        this.vManager.GetPictureBox().Image = System.Drawing.Image.FromFile(secondPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
