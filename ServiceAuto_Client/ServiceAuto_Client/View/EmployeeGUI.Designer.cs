namespace ServiceAuto_Client.View
{
    partial class EmployeeGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelChangeLanguage = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.buttonSaveCSV = new System.Windows.Forms.Button();
            this.buttonSaveJSON = new System.Windows.Forms.Button();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.buttonSaveDOC = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelLoggedIn = new System.Windows.Forms.Label();
            this.dataGridViewCarTable = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.comboBoxFilterBy = new System.Windows.Forms.ComboBox();
            this.comboBoxCarFilter = new System.Windows.Forms.ComboBox();
            this.labelFilterBy = new System.Windows.Forms.Label();
            this.labelSearchBar = new System.Windows.Forms.Label();
            this.labelCarOrderBy = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.comboBoxFuel = new System.Windows.Forms.ComboBox();
            this.numericUpDownCarID = new System.Windows.Forms.NumericUpDown();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelCarID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarID)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChangeLanguage
            // 
            this.labelChangeLanguage.AutoSize = true;
            this.labelChangeLanguage.BackColor = System.Drawing.Color.Transparent;
            this.labelChangeLanguage.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeLanguage.ForeColor = System.Drawing.Color.White;
            this.labelChangeLanguage.Location = new System.Drawing.Point(327, 164);
            this.labelChangeLanguage.Name = "labelChangeLanguage";
            this.labelChangeLanguage.Size = new System.Drawing.Size(163, 22);
            this.labelChangeLanguage.TabIndex = 65;
            this.labelChangeLanguage.Text = "Change Language";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "Russian"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(521, 166);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(130, 24);
            this.comboBoxLanguage.TabIndex = 64;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Montserrat ExtraBold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(353, 29);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(507, 73);
            this.labelHeader.TabIndex = 63;
            this.labelHeader.Text = "Cars Information";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCar.Location = new System.Drawing.Point(813, 157);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(373, 373);
            this.pictureBoxCar.TabIndex = 62;
            this.pictureBoxCar.TabStop = false;
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveCSV.Location = new System.Drawing.Point(465, 213);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveCSV.TabIndex = 61;
            this.buttonSaveCSV.Text = "SAVE CSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = true;
            // 
            // buttonSaveJSON
            // 
            this.buttonSaveJSON.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveJSON.Location = new System.Drawing.Point(606, 212);
            this.buttonSaveJSON.Name = "buttonSaveJSON";
            this.buttonSaveJSON.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveJSON.TabIndex = 60;
            this.buttonSaveJSON.Text = "SAVE JSON";
            this.buttonSaveJSON.UseVisualStyleBackColor = true;
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveXML.Location = new System.Drawing.Point(465, 258);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveXML.TabIndex = 59;
            this.buttonSaveXML.Text = "SAVE XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDOC
            // 
            this.buttonSaveDOC.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveDOC.Location = new System.Drawing.Point(606, 259);
            this.buttonSaveDOC.Name = "buttonSaveDOC";
            this.buttonSaveDOC.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveDOC.TabIndex = 58;
            this.buttonSaveDOC.Text = "SAVE DOC";
            this.buttonSaveDOC.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonLogout.Location = new System.Drawing.Point(944, 620);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(115, 26);
            this.buttonLogout.TabIndex = 57;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // labelLoggedIn
            // 
            this.labelLoggedIn.AutoSize = true;
            this.labelLoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.labelLoggedIn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelLoggedIn.ForeColor = System.Drawing.Color.White;
            this.labelLoggedIn.Location = new System.Drawing.Point(907, 597);
            this.labelLoggedIn.Name = "labelLoggedIn";
            this.labelLoggedIn.Size = new System.Drawing.Size(180, 20);
            this.labelLoggedIn.TabIndex = 56;
            this.labelLoggedIn.Text = "Logged in as Employee";
            // 
            // dataGridViewCarTable
            // 
            this.dataGridViewCarTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCarTable.Location = new System.Drawing.Point(52, 349);
            this.dataGridViewCarTable.Name = "dataGridViewCarTable";
            this.dataGridViewCarTable.Size = new System.Drawing.Size(697, 303);
            this.dataGridViewCarTable.TabIndex = 55;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSearch.Location = new System.Drawing.Point(465, 301);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 23);
            this.buttonSearch.TabIndex = 54;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonViewAll.Location = new System.Drawing.Point(606, 302);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(125, 23);
            this.buttonViewAll.TabIndex = 53;
            this.buttonViewAll.Text = "VIEW ALL";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxSearchBar.Location = new System.Drawing.Point(330, 301);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(130, 22);
            this.textBoxSearchBar.TabIndex = 52;
            // 
            // comboBoxFilterBy
            // 
            this.comboBoxFilterBy.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.comboBoxFilterBy.FormattingEnabled = true;
            this.comboBoxFilterBy.Items.AddRange(new object[] {
            "",
            "Owner",
            "Brand",
            "Color",
            "Fuel"});
            this.comboBoxFilterBy.Location = new System.Drawing.Point(330, 258);
            this.comboBoxFilterBy.Name = "comboBoxFilterBy";
            this.comboBoxFilterBy.Size = new System.Drawing.Size(130, 24);
            this.comboBoxFilterBy.TabIndex = 51;
            // 
            // comboBoxCarFilter
            // 
            this.comboBoxCarFilter.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.comboBoxCarFilter.FormattingEnabled = true;
            this.comboBoxCarFilter.Items.AddRange(new object[] {
            "",
            "None",
            "Brand and Fuel"});
            this.comboBoxCarFilter.Location = new System.Drawing.Point(330, 212);
            this.comboBoxCarFilter.Name = "comboBoxCarFilter";
            this.comboBoxCarFilter.Size = new System.Drawing.Size(130, 24);
            this.comboBoxCarFilter.TabIndex = 50;
            // 
            // labelFilterBy
            // 
            this.labelFilterBy.AutoSize = true;
            this.labelFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.labelFilterBy.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilterBy.ForeColor = System.Drawing.Color.White;
            this.labelFilterBy.Location = new System.Drawing.Point(327, 236);
            this.labelFilterBy.Name = "labelFilterBy";
            this.labelFilterBy.Size = new System.Drawing.Size(79, 22);
            this.labelFilterBy.TabIndex = 49;
            this.labelFilterBy.Text = "Filter By";
            // 
            // labelSearchBar
            // 
            this.labelSearchBar.AutoSize = true;
            this.labelSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.labelSearchBar.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBar.ForeColor = System.Drawing.Color.White;
            this.labelSearchBar.Location = new System.Drawing.Point(327, 279);
            this.labelSearchBar.Name = "labelSearchBar";
            this.labelSearchBar.Size = new System.Drawing.Size(99, 22);
            this.labelSearchBar.TabIndex = 48;
            this.labelSearchBar.Text = "Search bar";
            // 
            // labelCarOrderBy
            // 
            this.labelCarOrderBy.AutoSize = true;
            this.labelCarOrderBy.BackColor = System.Drawing.Color.Transparent;
            this.labelCarOrderBy.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarOrderBy.ForeColor = System.Drawing.Color.White;
            this.labelCarOrderBy.Location = new System.Drawing.Point(327, 190);
            this.labelCarOrderBy.Name = "labelCarOrderBy";
            this.labelCarOrderBy.Size = new System.Drawing.Size(116, 22);
            this.labelCarOrderBy.TabIndex = 47;
            this.labelCarOrderBy.Text = "Car Order By";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonUpdate.Location = new System.Drawing.Point(137, 295);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(78, 23);
            this.buttonUpdate.TabIndex = 46;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonDelete.Location = new System.Drawing.Point(216, 295);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 23);
            this.buttonDelete.TabIndex = 45;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonAdd.Location = new System.Drawing.Point(55, 295);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 23);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxBrand.Location = new System.Drawing.Point(161, 216);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(139, 22);
            this.textBoxBrand.TabIndex = 43;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxColor.Location = new System.Drawing.Point(161, 242);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(139, 22);
            this.textBoxColor.TabIndex = 42;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxOwner.Location = new System.Drawing.Point(161, 190);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(139, 22);
            this.textBoxOwner.TabIndex = 41;
            // 
            // comboBoxFuel
            // 
            this.comboBoxFuel.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.comboBoxFuel.FormattingEnabled = true;
            this.comboBoxFuel.Items.AddRange(new object[] {
            "",
            "Diesel",
            "Gasoline",
            "LPG",
            "Hybrid"});
            this.comboBoxFuel.Location = new System.Drawing.Point(161, 268);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(139, 24);
            this.comboBoxFuel.TabIndex = 40;
            // 
            // numericUpDownCarID
            // 
            this.numericUpDownCarID.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.numericUpDownCarID.Location = new System.Drawing.Point(161, 164);
            this.numericUpDownCarID.Maximum = new decimal(new int[] {
            4000000,
            0,
            0,
            0});
            this.numericUpDownCarID.Name = "numericUpDownCarID";
            this.numericUpDownCarID.Size = new System.Drawing.Size(138, 22);
            this.numericUpDownCarID.TabIndex = 39;
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.BackColor = System.Drawing.Color.Transparent;
            this.labelFuel.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelFuel.ForeColor = System.Drawing.Color.White;
            this.labelFuel.Location = new System.Drawing.Point(51, 268);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(41, 20);
            this.labelFuel.TabIndex = 38;
            this.labelFuel.Text = "Fuel";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelColor.ForeColor = System.Drawing.Color.White;
            this.labelColor.Location = new System.Drawing.Point(51, 242);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(47, 20);
            this.labelColor.TabIndex = 37;
            this.labelColor.Text = "Color";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.BackColor = System.Drawing.Color.Transparent;
            this.labelBrand.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelBrand.ForeColor = System.Drawing.Color.White;
            this.labelBrand.Location = new System.Drawing.Point(51, 216);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(54, 20);
            this.labelBrand.TabIndex = 36;
            this.labelBrand.Text = "Brand";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.BackColor = System.Drawing.Color.Transparent;
            this.labelOwner.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelOwner.ForeColor = System.Drawing.Color.White;
            this.labelOwner.Location = new System.Drawing.Point(51, 190);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(59, 20);
            this.labelOwner.TabIndex = 35;
            this.labelOwner.Text = "Owner";
            // 
            // labelCarID
            // 
            this.labelCarID.AutoSize = true;
            this.labelCarID.BackColor = System.Drawing.Color.Transparent;
            this.labelCarID.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelCarID.ForeColor = System.Drawing.Color.White;
            this.labelCarID.Location = new System.Drawing.Point(51, 164);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(54, 20);
            this.labelCarID.TabIndex = 34;
            this.labelCarID.Text = "Car ID";
            // 
            // EmployeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceAuto_Client.Properties.Resources.employeeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1224, 700);
            this.Controls.Add(this.labelChangeLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.buttonSaveCSV);
            this.Controls.Add(this.buttonSaveJSON);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.buttonSaveDOC);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.labelLoggedIn);
            this.Controls.Add(this.dataGridViewCarTable);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.comboBoxFilterBy);
            this.Controls.Add(this.comboBoxCarFilter);
            this.Controls.Add(this.labelFilterBy);
            this.Controls.Add(this.labelSearchBar);
            this.Controls.Add(this.labelCarOrderBy);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.comboBoxFuel);
            this.Controls.Add(this.numericUpDownCarID);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelCarID);
            this.Name = "EmployeeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChangeLanguage;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Button buttonSaveCSV;
        private System.Windows.Forms.Button buttonSaveJSON;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Button buttonSaveDOC;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelLoggedIn;
        private System.Windows.Forms.DataGridView dataGridViewCarTable;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.ComboBox comboBoxFilterBy;
        private System.Windows.Forms.ComboBox comboBoxCarFilter;
        private System.Windows.Forms.Label labelFilterBy;
        private System.Windows.Forms.Label labelSearchBar;
        private System.Windows.Forms.Label labelCarOrderBy;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.ComboBox comboBoxFuel;
        private System.Windows.Forms.NumericUpDown numericUpDownCarID;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelCarID;
    }
}