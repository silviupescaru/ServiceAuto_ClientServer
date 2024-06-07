using ServiceAuto_Client.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAuto_Client.View
{
    public partial class EmployeeGUI : Form, Observable
    {
        public EmployeeGUI(int index)
        {
            InitializeComponent();
            this.numericUpDownCarID.Value = 0;
            this.textBoxOwner.Text = string.Empty;
            this.textBoxBrand.Text = string.Empty;
            this.textBoxColor.Text = string.Empty;
            this.comboBoxFuel.SelectedItem = 0;
            this.textBoxYear.Text = string.Empty;
            this.textBoxEngineNo.Text = string.Empty;
            this.textBoxPlateNo.Text = string.Empty;
            this.textBoxDefect.Text = string.Empty;
            this.textBoxRepairCost.Text = string.Empty;
            this.comboBoxRepaired.SelectedItem = 0;

            this.comboBoxCarFilter.SelectedItem = 0;
            this.comboBoxFilterBy.SelectedItem = 0;
            this.textBoxSearchBar.Text = string.Empty;

            this.comboBoxLanguage.SelectedIndex = index;
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

        public ComboBox GetCarOrderBy()
        {
            return this.comboBoxCarFilter;
        }

        public ComboBox GetFilterBy()
        {
            return this.comboBoxFilterBy;
        }

        public TextBox GetSearch()
        {
            return this.textBoxSearchBar;
        }

        public DataGridView GetCarTable()
        {
            return this.dataGridViewCarTable;
        }

        public Button GetAddButton()
        {
            return this.buttonAdd;
        }

        public Button GetUpdateButton()
        {
            return this.buttonUpdate;
        }

        public Button GetDeleteButton()
        {
            return this.buttonDelete;
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

        public Button GetSearchButton()
        {
            return this.buttonSearch;
        }

        public Button GetViewAllButton()
        {
            return this.buttonViewAll;
        }

        public Button GetLogoutButton()
        {
            return this.buttonLogout;
        }

        public PictureBox GetPictureBox()
        {
            return this.pictureBoxCar;
        }

        public void Update(Subject obs)
        {
            LangHelper lang = (LangHelper)obs;

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
            this.labelLoggedIn.Text = lang.GetString("labelLoggedIn");
            this.labelHeader.Text = lang.GetString("labelHeader");
            this.labelChangeLanguage.Text = lang.GetString("labelChangeLanguage");

            this.buttonLogout.Text = lang.GetString("buttonLogout");
            this.buttonAdd.Text = lang.GetString("buttonAdd");
            this.buttonUpdate.Text = lang.GetString("buttonUpdate");
            this.buttonDelete.Text = lang.GetString("buttonDelete");
            this.buttonSearch.Text = lang.GetString("buttonSearch");
            this.buttonViewAll.Text = lang.GetString("buttonViewAll");
            this.buttonSaveCSV.Text = lang.GetString("buttonSaveCSV");
            this.buttonSaveXML.Text = lang.GetString("buttonSaveXML");
            this.buttonSaveDOC.Text = lang.GetString("buttonSaveDOC");
            this.buttonSaveJSON.Text = lang.GetString("buttonSaveJSON");

        }
    }
}
