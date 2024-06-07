using System;
using System.IO;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceAuto_Client.Language;
using ServiceAuto_Client.View;
using ServiceAuto_Client.Service;
using ServiceAuto_Server.Domain;
using ServiceAuto_Server.Repository;
using ServiceAuto_Server.Service;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Mail;
using Microsoft.Office.Interop.Word;
using System.Net;

namespace ServiceAuto_Client.Controller
{
    public class ControllerEmployee
    {
        private EmployeeGUI employeeGUI;
        private ICarService iCarService;
        private LoginGUI loginGUI;
        private LangHelper lang;

        public ControllerEmployee(int index)
        {
            this.employeeGUI = new EmployeeGUI(index);
            this.lang = new LangHelper();
            this.lang.Add(this.employeeGUI);

            this.createBinding();
            this.eventManagement();
        }

        public EmployeeGUI GetView()
        {
            this.employeeGUI.Show();
            return this.employeeGUI;
        }

        private void createBinding()
        {
            ChannelFactory<ICarService> channelEmployee;
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
            channelEmployee = new ChannelFactory<ICarService>(tcp, "net.tcp://" + s + ":52001/Car");
            try
            {
                this.iCarService = channelEmployee.CreateChannel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void eventManagement()
        {
            this.employeeGUI.FormClosed += new FormClosedEventHandler(exitApplication);
            this.employeeGUI.GetAddButton().Click += new EventHandler(addCar);
            this.employeeGUI.GetUpdateButton().Click += new EventHandler(updateCar);
            this.employeeGUI.GetDeleteButton().Click += new EventHandler(deleteCar);
            this.employeeGUI.GetSearchButton().Click += new EventHandler(searchBy);
            this.employeeGUI.GetFilterBy().SelectedIndexChanged += new EventHandler(filterBy);
            this.employeeGUI.GetCarOrderBy().SelectedIndexChanged += new EventHandler(orderBy);
            this.employeeGUI.GetViewAllButton().Click += new EventHandler(viewAll);
            this.employeeGUI.GetSaveCSVButton().Click += new EventHandler(saveCSV);
            this.employeeGUI.GetSaveJSONButton().Click += new EventHandler(saveJSON);
            this.employeeGUI.GetSaveXMLButton().Click += new EventHandler(saveXML);
            this.employeeGUI.GetSaveDOCButton().Click += new EventHandler(saveDOC);
            this.employeeGUI.GetNotifyWhatsappButton().Click += new EventHandler(notifyRepairedWhatsapp);
            this.employeeGUI.GetNotifyEmailButton().Click += new EventHandler(notifyRepairedEmail);
            this.employeeGUI.GetLogoutButton().Click += new EventHandler(logout);
            this.employeeGUI.GetCarTable().RowStateChanged += new DataGridViewRowStateChangedEventHandler(setCarControls);
            this.employeeGUI.GetLanguageBox().SelectedIndexChanged += new EventHandler(changeLanguage);
        }

        private void exitApplication(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeLanguage(object sender, EventArgs e)
        {
            if (this.employeeGUI.GetLanguageBox().SelectedIndex == 0)
            {
                this.lang.ChangeLanguage("en");
            }
            else if (this.employeeGUI.GetLanguageBox().SelectedIndex == 1)
            {
                this.lang.ChangeLanguage("fr");
            }
            else if (this.employeeGUI.GetLanguageBox().SelectedIndex == 2)
            {
                this.lang.ChangeLanguage("ru");
            }
        }

        private void addCar(object sender, EventArgs e)
        {
            try
            {
                Car car = this.validInformation();

                if (car != null)
                {
                    bool result = this.iCarService.AddCar(car);
                    if (result == true)
                    {
                        MessageBox.Show(this.lang.GetString("messageBoxAddSuccess"));
                        this.resetGUIControls();

                        if (this.employeeGUI.GetCarTable() == null)
                            MessageBox.Show(this.lang.GetString("messageBoxNoData"));
                    }
                    else MessageBox.Show(this.lang.GetString("messageBoxAddFail"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateCar(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(this.employeeGUI.GetCarID().Value))
                {
                    Car car = this.validInformation();
                    if (car != null)
                    {
                        bool result = this.iCarService.UpdateCar(car);
                        if (result)
                        {
                            MessageBox.Show(this.lang.GetString("messageBoxUpdateSuccess"));
                            this.resetGUIControls();
                        }
                        else MessageBox.Show(this.lang.GetString("messageBoxUpdateFail"));
                    }
                }
                else MessageBox.Show(this.lang.GetString("messageBoxNoDataSelected"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteCar(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(this.employeeGUI.GetCarID().Value))
                {
                    uint selectedID = Convert.ToUInt32(this.employeeGUI.GetCarID().Value);
                    bool result = this.iCarService.DeleteCar(selectedID);

                    if (result)
                    {
                        MessageBox.Show(this.lang.GetString("messageBoxDeleteSuccess"));
                        this.resetGUIControls();
                    }
                    else MessageBox.Show(this.lang.GetString("messageBoxDeleteFail"));
                }
                else MessageBox.Show(this.lang.GetString("messageBoxNoDataSelectedDelete"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchBy(object sender, EventArgs e)
        {
            try
            {
                if (this.employeeGUI.GetCarTable() != null)
                    this.employeeGUI.GetCarTable().Rows.Clear();

                if (this.employeeGUI.GetSearch().Text.Length > 0)
                {
                    List<Car> listEngineNo = this.iCarService.SearchCarByEngineNo(this.employeeGUI.GetSearch().Text);
                    List<Car> listPlateNo = this.iCarService.SearchCarByPlate(this.employeeGUI.GetSearch().Text);
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
                                    this.employeeGUI.GetCarTable().Rows.Add(row);
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
                                this.employeeGUI.GetCarTable().Rows.Add(row);
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
                if (this.employeeGUI.GetCarTable() != null)
                    this.employeeGUI.GetCarTable().DataSource = this.iCarService.EmptyTable();

                string selectedOption = this.employeeGUI.GetFilterBy().Text;

                if (selectedOption != null && selectedOption.Length > 0)
                {
                    if (selectedOption.ToUpper() == "OWNER")
                    {
                        this.employeeGUI.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Owner(this.employeeGUI.GetOwner().Text);
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
                                    this.employeeGUI.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND")
                    {
                        this.employeeGUI.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Brand(this.employeeGUI.GetBrand().Text);
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
                                    this.employeeGUI.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "COLOR")
                    {
                        this.employeeGUI.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Color(this.employeeGUI.GetColor().Text);
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
                                    this.employeeGUI.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "FUEL")
                    {
                        this.employeeGUI.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Fuel(this.employeeGUI.GetFuel().Text);
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
                                    this.employeeGUI.GetCarTable().Rows.Add(row);
                                }
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "YEAR")
                    {
                        this.employeeGUI.GetCarTable().Rows.Clear();
                        List<Car> list = this.iCarService.CarList_Year(Convert.ToInt32(this.employeeGUI.GetYear().Text));
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
                                    this.employeeGUI.GetCarTable().Rows.Add(row);
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
                if (this.employeeGUI.GetCarTable() != null)
                    this.employeeGUI.GetCarTable().Rows.Clear();

                string selectedOption = this.employeeGUI.GetCarOrderBy().Text;
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
                                this.employeeGUI.GetCarTable().Rows.Add(row);
                            }
                        }
                    }
                    else if (selectedOption.ToUpper() == "BRAND AND FUEL")
                    {
                        this.employeeGUI.GetCarTable().Rows.Clear();
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
                                this.employeeGUI.GetCarTable().Rows.Add(row);
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
                if (this.employeeGUI.GetCarTable() != null)
                {
                    this.employeeGUI.GetCarTable().Rows.Clear();
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
                        this.employeeGUI.GetCarTable().Rows.Add(row);
                    }
                    this.employeeGUI.GetCarTable().Rows.Add();
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
                List<Car> carList = this.iCarService.CarList();
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
                List<Car> carList = this.iCarService.CarList();
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
                List<Car> carList = this.iCarService.CarList();
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
                List<Car> carList = this.iCarService.CarList();
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
                this.employeeGUI.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void notifyRepairedWhatsapp(object sender, EventArgs e)
        {
            try
            {
                if(this.employeeGUI.GetCarTable().SelectedRows.Count > 0)
                {
                    DataGridViewRow drvr = this.employeeGUI.GetCarTable().SelectedRows[0];

                    bool repaired = Convert.ToBoolean(drvr.Cells[10].Value);

                    if (repaired == true) 
                    {

                        TwilioClient.Init(".", "..");

                        var message = MessageResource.Create(
                            from: new Twilio.Types.PhoneNumber("whatsapp:+12292109286"),
                            to: new Twilio.Types.PhoneNumber("whatsapp:+40765211258"),
                            body: "Your car has been repaired!"
                            );
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void notifyRepairedEmail(object sender, EventArgs e)
        {
            try
            {

                using (System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage())
                {
                    mail.From = new MailAddress("baldnikobellic@gmail.com");
                    mail.To.Add("prowhite91@gmail.com");
                    mail.Subject = "Hello World";
                    mail.Body = "<h1>Your car has been repaired</h1>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("baldnikobellic@gmail.com", "olacikita");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
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
                if (this.employeeGUI.GetCarTable().SelectedRows.Count > 0)
                {
                    DataGridViewRow drvr = this.employeeGUI.GetCarTable().SelectedRows[0];

                    uint carID = Convert.ToUInt32(drvr.Cells[0].Value);
                    this.employeeGUI.GetCarID().Value = carID;

                    string owner = drvr.Cells[1].Value.ToString();
                    this.employeeGUI.GetOwner().Text = owner;

                    string brand = drvr.Cells[2].Value.ToString();
                    this.employeeGUI.GetBrand().Text = brand;

                    string color = drvr.Cells[3].Value.ToString();
                    this.employeeGUI.GetColor().Text = color;

                    string fuel = drvr.Cells[4].Value.ToString();
                    this.employeeGUI.GetFuel().Text = fuel;

                    int year = Convert.ToInt32(drvr.Cells[5].Value);
                    this.employeeGUI.GetYear().Text = year.ToString();

                    string engineNo = drvr.Cells[6].Value.ToString();
                    this.employeeGUI.GetEngineNo().Text = engineNo;

                    string plateNo = drvr.Cells[7].Value.ToString();
                    this.employeeGUI.GetPlateNo().Text = plateNo;

                    string defect = drvr.Cells[8].Value.ToString();
                    this.employeeGUI.GetDefect().Text = defect;

                    float repairCost = (float)Convert.ToDouble(drvr.Cells[9].Value);
                    this.employeeGUI.GetRepairCost().Text = repairCost.ToString();

                    bool repaired = Convert.ToBoolean(drvr.Cells[10].Value);
                    this.employeeGUI.GetRepaired().SelectedIndex = Convert.ToInt32(repaired);

                    string imageName = brand + "_" + color;
                    string workingDirectory = Environment.CurrentDirectory;
                    workingDirectory = workingDirectory.Substring(0, workingDirectory.Length - 9);

                    string path = workingDirectory + "resources\\cars\\" + imageName + ".jpg";
                    string secondPath = workingDirectory + "resources\\cars\\noCarFound.jpg";

                    try
                    {
                        this.employeeGUI.GetPictureBox().Image = System.Drawing.Image.FromFile(path);
                    }
                    catch
                    {
                        this.employeeGUI.GetPictureBox().Image = System.Drawing.Image.FromFile(secondPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void resetGUIControls()
        {
            this.employeeGUI.GetCarID().Value = 1;
            this.employeeGUI.GetOwner().Text = string.Empty;
            this.employeeGUI.GetBrand().Text = string.Empty;
            this.employeeGUI.GetColor().Text = string.Empty;
            this.employeeGUI.GetFuel().Text = string.Empty;
            this.employeeGUI.GetYear().Text = string.Empty;
            this.employeeGUI.GetEngineNo().Text = string.Empty;
            this.employeeGUI.GetPlateNo().Text = string.Empty;
            this.employeeGUI.GetDefect().Text = string.Empty;
            this.employeeGUI.GetRepairCost().Text = string.Empty;
            this.employeeGUI.GetRepaired().SelectedIndex = 0;
            this.employeeGUI.GetSearch().Text = string.Empty;
            this.employeeGUI.GetCarOrderBy().SelectedItem = 0;
            this.employeeGUI.GetFilterBy().SelectedItem = 0;
            this.employeeGUI.GetCarTable().Rows.Clear();
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
                    this.employeeGUI.GetCarTable().Rows.Add(row);
                }
            }
        }

        private Car validInformation()
        {
            uint id = (uint)this.employeeGUI.GetCarID().Value;
            Debug.Print("Car ID: " + id);
            if (id == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxCarIDNonZero"));
                return null;
            }
            string owner = this.employeeGUI.GetOwner().Text;
            Debug.Print("Car Owner: " + owner);
            if (owner == null || owner.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxOwnerEmpty"));
                return null;
            }
            string brand = this.employeeGUI.GetBrand().Text;
            Debug.Print("Car Brand: " + brand);
            if (brand == null || brand.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxBrandEmpty"));
                return null;
            }
            string color = this.employeeGUI.GetColor().Text;
            Debug.Print("Car Color: " + color);
            if (color == null || color.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxColorEmpty"));
                return null;
            }
            string fuel = this.employeeGUI.GetFuel().Text;
            Debug.Print("Car Fuel: " + fuel);
            if (fuel == null || fuel.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxFuelEmpty"));
                return null;
            }
            int year = Convert.ToInt32(this.employeeGUI.GetYear().Text);
            Debug.Print("Car Year: " + year);
            if(year == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxYearEmpty"));
                return null;
            }
            string engineNo = this.employeeGUI.GetEngineNo().Text;
            Debug.Print("Car Engine No: " + engineNo);
            if (engineNo == null || engineNo.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxEngineNoEmpty"));
                return null;
            }
            string plateNo = this.employeeGUI.GetPlateNo().Text;
            Debug.Print("Car Plate No: " + plateNo);
            if (plateNo == null || plateNo.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxPlateNoEmpty"));
                return null;
            }
            string defect = this.employeeGUI.GetDefect().Text;
            Debug.Print("Car Defect: " + defect);
            if (defect == null || defect.Length == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxDefectEmpty"));
                return null;
            }
            float repairCost = (float)Convert.ToDouble(this.employeeGUI.GetRepairCost().Text);
            Debug.Print("Car Repair Cost: " + repairCost);
            if (repairCost == 0)
            {
                MessageBox.Show(this.lang.GetString("messageBoxRepairCostEmpty"));
                return null;
            }

            bool repaired = Convert.ToBoolean(this.employeeGUI.GetRepaired().SelectedIndex);
            Debug.Print("Car Repaired: " + repaired);
            
            return new Car(id, owner, brand, color, fuel, year, engineNo, plateNo, defect, repairCost, repaired);
        }
    }
}
