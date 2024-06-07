using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using ServiceAuto_Client.Language;

namespace ServiceAuto_Client.View
{
    public partial class ManagerGUI : Form, Observable
    {
        public ManagerGUI(int index)
        {
            InitializeComponent();

            this.numericUpDownCarID.Value = 1;
            this.textBoxOwner.Text = string.Empty;
            this.textBoxBrand.Text = string.Empty;
            this.textBoxColor.Text = string.Empty;
            this.textBoxSearchBar.Text = string.Empty;
            this.comboBoxFuel.SelectedItem = 0;
            this.textBoxYear.Text = string.Empty;
            this.textBoxEngineNo.Text = string.Empty;
            this.textBoxPlateNo.Text = string.Empty;
            this.textBoxDefect.Text = string.Empty;
            this.textBoxRepairCost.Text = string.Empty;
            this.comboBoxRepaired.SelectedIndex = 0;
            this.comboBoxFilterBy.SelectedItem = 0;
            this.comboBoxCarFilter.SelectedItem = 0;

            this.comboBoxLanguage.SelectedItem = index;
        }

        public NumericUpDown GetCarID()
        {
            return this.numericUpDownCarID;
        }

        public TextBox GetOwner()
        {
            return this.textBoxOwner;
        }

        public TextBox GetBrand()
        {
            return this.textBoxBrand;
        }

        public TextBox GetColor()
        {
            return this.textBoxColor;
        }

        public ComboBox GetLanguageBox()
        {
            return this.comboBoxLanguage;
        }

        public ComboBox GetFuel()
        {
            return this.comboBoxFuel;
        }

        public TextBox GetYear()
        {
            return this.textBoxYear;
        }

        public TextBox GetEngineNo()
        {
            return this.textBoxEngineNo;
        }

        public TextBox GetPlateNo()
        {
            return this.textBoxPlateNo;
        }

        public TextBox GetDefect()
        {
            return this.textBoxDefect;
        }

        public TextBox GetRepairCost()
        {
            return this.textBoxRepairCost;
        }

        public ComboBox GetRepaired()
        {
            return this.comboBoxRepaired;
        }

        public ComboBox GetOrderBy()
        {
            return this.comboBoxCarFilter;
        }

        public ComboBox GetFilterBy()
        {
            return this.comboBoxFilterBy;
        }

        public DataGridView GetCarTable()
        {
            return this.dataGridViewCarTable;
        }

        public TextBox GetSearchBy()
        {
            return this.textBoxSearchBar;
        }

        public Button GetSaveCSVButton()
        {
            return this.buttonSaveCSV;
        }

        public Button GetSaveJSONButton()
        {
            return this.buttonSaveJSON;
        }

        public Button GetSaveXMLButton()
        {
            return this.buttonSaveXML;
        }

        public Button GetSaveDOCButton()
        {
            return this.buttonSaveDOC;
        }

        public Button GetViewAllButton()
        {
            return this.buttonViewAll;
        }

        public Button GetSearchButton()
        {
            return this.buttonSearch;
        }

        public Button GetLogoutButton()
        {
            return this.buttonLogout;
        }

        public Button GetStatisticsButton()
        {
            return this.buttonStatistics;
        }

        public PictureBox GetPictureBox()
        {
            return this.pictureBoxCar;
        }

        public void Update(Subject obs)
        {
            LangHelper lang = (LangHelper)obs;

            this.labelHeader.Text = lang.GetString("labelHeader");
            this.labelCarID.Text = lang.GetString("labelCarID");
            this.labelOwner.Text = lang.GetString("labelOwner");
            this.labelBrand.Text = lang.GetString("labelBrand");
            this.labelColor.Text = lang.GetString("labelColor");
            this.labelFuel.Text = lang.GetString("labelFuel");
            this.labelYear.Text = lang.GetString("labelYear");
            this.labelEngineNo.Text = lang.GetString("labelEngineNo");
            this.labelPlateNo.Text = lang.GetString("labelPlateNo");
            this.labelDefect.Text = lang.GetString("labelDefect");
            this.labelRepairCost.Text = lang.GetString("labelRepairCost");
            this.labelRepaired.Text = lang.GetString("labelRepaired");
            this.labelCarOrderBy.Text = lang.GetString("labelOrderBy");
            this.labelFilterBy.Text = lang.GetString("labelFilterBy");
            this.labelSearchBar.Text = lang.GetString("labelSearch");
            this.labelChangeLanguage.Text = lang.GetString("labelChangeLanguage");
            this.labelLoggedIn.Text = lang.GetString("labelLoggedManager");

            this.buttonSearch.Text = lang.GetString("buttonSearch");
            this.buttonViewAll.Text = lang.GetString("buttonViewAll");
            this.buttonSaveCSV.Text = lang.GetString("buttonSaveCSV");
            this.buttonSaveXML.Text = lang.GetString("buttonSaveXML");
            this.buttonSaveDOC.Text = lang.GetString("buttonSaveDOC");
            this.buttonSaveJSON.Text = lang.GetString("buttonSaveJSON");
            this.buttonStatistics.Text = lang.GetString("buttonStatistics");
            this.buttonLogout.Text = lang.GetString("buttonLogout");
        }
    }
}
