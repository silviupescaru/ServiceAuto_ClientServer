using Microsoft.Office.Interop.Word;
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
    public partial class AdministratorGUI : Form, Observable
    {
        public AdministratorGUI(int index)
        {
            InitializeComponent();
            this.numericUpDownUserID.Value = 0;
            this.textBoxUsername.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
            this.textBoxRole.Text = string.Empty;
            this.textBoxPhoneNumber.Text = string.Empty;
            this.textBoxEmail.Text = string.Empty;
            this.textBoxSearch.Text = string.Empty;

            this.comboBoxChangeLanguage.SelectedItem = index;
        }

        public NumericUpDown GetUserID()
        {
            return this.numericUpDownUserID;
        }

        public TextBox GetUsername()
        {
            return this.textBoxUsername;
        }

        public TextBox GetPassword()
        {
            return this.textBoxPassword;
        }

        public TextBox GetRole()
        {
            return this.textBoxRole;
        }

        public TextBox GetPhoneNumber()
        {
            return this.textBoxPhoneNumber;
        }

        public TextBox GetEmail()
        {
            return this.textBoxEmail;
        }

        public ComboBox GetLanguageBox()
        {
            return this.comboBoxChangeLanguage;
        }

        public TextBox GetSearch()
        {
            return this.textBoxSearch;
        }

        public DataGridView GetUserTable()
        {
            return this.dataGridViewUsers;
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

        public void Update(Subject obs)
        {
            LangHelper lang = (LangHelper)obs;

            this.labelUserID.Text = lang.GetString("labelUserID");
            this.labelUsername.Text = lang.GetString("labelUsername");
            this.labelPassword.Text = lang.GetString("labelPassword");
            this.labelRole.Text = lang.GetString("labelRole");
            this.labelPhoneNumber.Text = lang.GetString("labelPhoneNumber");
            this.labelEmail.Text = lang.GetString("labelEmail");
            this.labelChangeLanguage.Text = lang.GetString("labelChangeLanguage");
            this.labelSearch.Text = lang.GetString("labelSearchRole");
            this.labelLoggedUser.Text = lang.GetString("labelLoggedAdmin");

            this.buttonAdd.Text = lang.GetString("buttonAdd");
            this.buttonUpdate.Text = lang.GetString("buttonUpdate");
            this.buttonDelete.Text = lang.GetString("buttonDelete");
            this.buttonSearch.Text = lang.GetString("buttonSearch");
            this.buttonViewAll.Text = lang.GetString("buttonViewAll");
            this.buttonLogout.Text = lang.GetString("buttonLogout");
        }
    }
}
