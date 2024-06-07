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
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repaired = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxPlateNo = new System.Windows.Forms.TextBox();
            this.textBoxDefect = new System.Windows.Forms.TextBox();
            this.textBoxEngineNo = new System.Windows.Forms.TextBox();
            this.labelDefect = new System.Windows.Forms.Label();
            this.labelPlateNo = new System.Windows.Forms.Label();
            this.labelEngineNo = new System.Windows.Forms.Label();
            this.labelRepaired = new System.Windows.Forms.Label();
            this.comboBoxRepaired = new System.Windows.Forms.ComboBox();
            this.textBoxRepairCost = new System.Windows.Forms.TextBox();
            this.labelRepairCost = new System.Windows.Forms.Label();
            this.buttonNotifyWhatsapp = new System.Windows.Forms.Button();
            this.buttonNotifyEmail = new System.Windows.Forms.Button();
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
            this.labelChangeLanguage.Location = new System.Drawing.Point(62, 207);
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
            this.comboBoxLanguage.Location = new System.Drawing.Point(256, 209);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(112, 24);
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
            this.pictureBoxCar.Location = new System.Drawing.Point(1033, 263);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(373, 373);
            this.pictureBoxCar.TabIndex = 62;
            this.pictureBoxCar.TabStop = false;
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveCSV.Location = new System.Drawing.Point(84, 352);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveCSV.TabIndex = 61;
            this.buttonSaveCSV.Text = "SAVE CSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = true;
            // 
            // buttonSaveJSON
            // 
            this.buttonSaveJSON.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveJSON.Location = new System.Drawing.Point(225, 351);
            this.buttonSaveJSON.Name = "buttonSaveJSON";
            this.buttonSaveJSON.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveJSON.TabIndex = 60;
            this.buttonSaveJSON.Text = "SAVE JSON";
            this.buttonSaveJSON.UseVisualStyleBackColor = true;
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveXML.Location = new System.Drawing.Point(84, 397);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveXML.TabIndex = 59;
            this.buttonSaveXML.Text = "SAVE XML";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            // 
            // buttonSaveDOC
            // 
            this.buttonSaveDOC.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSaveDOC.Location = new System.Drawing.Point(225, 398);
            this.buttonSaveDOC.Name = "buttonSaveDOC";
            this.buttonSaveDOC.Size = new System.Drawing.Size(125, 23);
            this.buttonSaveDOC.TabIndex = 58;
            this.buttonSaveDOC.Text = "SAVE DOC";
            this.buttonSaveDOC.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonLogout.Location = new System.Drawing.Point(1165, 809);
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
            this.labelLoggedIn.Location = new System.Drawing.Point(1128, 786);
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
            this.dataGridViewCarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carID,
            this.owner,
            this.brand,
            this.color,
            this.fuel,
            this.year,
            this.engineNo,
            this.plateNo,
            this.defect,
            this.repairCost,
            this.repaired});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCarTable.Location = new System.Drawing.Point(66, 457);
            this.dataGridViewCarTable.Name = "dataGridViewCarTable";
            this.dataGridViewCarTable.Size = new System.Drawing.Size(846, 392);
            this.dataGridViewCarTable.TabIndex = 55;
            // 
            // carID
            // 
            this.carID.HeaderText = "Car ID";
            this.carID.Name = "carID";
            // 
            // owner
            // 
            this.owner.HeaderText = "Owner";
            this.owner.Name = "owner";
            // 
            // brand
            // 
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            // 
            // fuel
            // 
            this.fuel.HeaderText = "Fuel";
            this.fuel.Name = "fuel";
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            // 
            // engineNo
            // 
            this.engineNo.HeaderText = "EngineNo";
            this.engineNo.Name = "engineNo";
            // 
            // plateNo
            // 
            this.plateNo.HeaderText = "PlateNo";
            this.plateNo.Name = "plateNo";
            // 
            // defect
            // 
            this.defect.HeaderText = "Defect";
            this.defect.Name = "defect";
            // 
            // repairCost
            // 
            this.repairCost.HeaderText = "Repair Cost";
            this.repairCost.Name = "repairCost";
            // 
            // repaired
            // 
            this.repaired.HeaderText = "Repaired";
            this.repaired.Name = "repaired";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonSearch.Location = new System.Drawing.Point(231, 312);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(130, 23);
            this.buttonSearch.TabIndex = 54;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonViewAll.Location = new System.Drawing.Point(669, 399);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(125, 23);
            this.buttonViewAll.TabIndex = 53;
            this.buttonViewAll.Text = "VIEW ALL";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxSearchBar.Location = new System.Drawing.Point(75, 313);
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
            this.comboBoxFilterBy.Location = new System.Drawing.Point(231, 268);
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
            this.comboBoxCarFilter.Location = new System.Drawing.Point(75, 265);
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
            this.labelFilterBy.Location = new System.Drawing.Point(228, 247);
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
            this.labelSearchBar.Location = new System.Drawing.Point(72, 291);
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
            this.labelCarOrderBy.Location = new System.Drawing.Point(72, 243);
            this.labelCarOrderBy.Name = "labelCarOrderBy";
            this.labelCarOrderBy.Size = new System.Drawing.Size(116, 22);
            this.labelCarOrderBy.TabIndex = 47;
            this.labelCarOrderBy.Text = "Car Order By";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonUpdate.Location = new System.Drawing.Point(501, 398);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(78, 23);
            this.buttonUpdate.TabIndex = 46;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonDelete.Location = new System.Drawing.Point(580, 398);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 23);
            this.buttonDelete.TabIndex = 45;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonAdd.Location = new System.Drawing.Point(419, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 23);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxBrand.Location = new System.Drawing.Point(512, 259);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(139, 22);
            this.textBoxBrand.TabIndex = 43;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxColor.Location = new System.Drawing.Point(512, 285);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(139, 22);
            this.textBoxColor.TabIndex = 42;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxOwner.Location = new System.Drawing.Point(512, 233);
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
            this.comboBoxFuel.Location = new System.Drawing.Point(512, 311);
            this.comboBoxFuel.Name = "comboBoxFuel";
            this.comboBoxFuel.Size = new System.Drawing.Size(139, 24);
            this.comboBoxFuel.TabIndex = 40;
            // 
            // numericUpDownCarID
            // 
            this.numericUpDownCarID.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.numericUpDownCarID.Location = new System.Drawing.Point(512, 207);
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
            this.labelFuel.Location = new System.Drawing.Point(402, 311);
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
            this.labelColor.Location = new System.Drawing.Point(402, 285);
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
            this.labelBrand.Location = new System.Drawing.Point(402, 259);
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
            this.labelOwner.Location = new System.Drawing.Point(402, 233);
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
            this.labelCarID.Location = new System.Drawing.Point(402, 207);
            this.labelCarID.Name = "labelCarID";
            this.labelCarID.Size = new System.Drawing.Size(54, 20);
            this.labelCarID.TabIndex = 34;
            this.labelCarID.Text = "Car ID";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxYear.Location = new System.Drawing.Point(512, 339);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(139, 22);
            this.textBoxYear.TabIndex = 67;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.BackColor = System.Drawing.Color.Transparent;
            this.labelYear.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelYear.ForeColor = System.Drawing.Color.White;
            this.labelYear.Location = new System.Drawing.Point(402, 339);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(41, 20);
            this.labelYear.TabIndex = 66;
            this.labelYear.Text = "Year";
            // 
            // textBoxPlateNo
            // 
            this.textBoxPlateNo.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxPlateNo.Location = new System.Drawing.Point(777, 233);
            this.textBoxPlateNo.Name = "textBoxPlateNo";
            this.textBoxPlateNo.Size = new System.Drawing.Size(139, 22);
            this.textBoxPlateNo.TabIndex = 73;
            // 
            // textBoxDefect
            // 
            this.textBoxDefect.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxDefect.Location = new System.Drawing.Point(777, 259);
            this.textBoxDefect.Name = "textBoxDefect";
            this.textBoxDefect.Size = new System.Drawing.Size(139, 22);
            this.textBoxDefect.TabIndex = 72;
            // 
            // textBoxEngineNo
            // 
            this.textBoxEngineNo.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxEngineNo.Location = new System.Drawing.Point(777, 207);
            this.textBoxEngineNo.Name = "textBoxEngineNo";
            this.textBoxEngineNo.Size = new System.Drawing.Size(139, 22);
            this.textBoxEngineNo.TabIndex = 71;
            // 
            // labelDefect
            // 
            this.labelDefect.AutoSize = true;
            this.labelDefect.BackColor = System.Drawing.Color.Transparent;
            this.labelDefect.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelDefect.ForeColor = System.Drawing.Color.White;
            this.labelDefect.Location = new System.Drawing.Point(667, 259);
            this.labelDefect.Name = "labelDefect";
            this.labelDefect.Size = new System.Drawing.Size(58, 20);
            this.labelDefect.TabIndex = 70;
            this.labelDefect.Text = "Defect";
            // 
            // labelPlateNo
            // 
            this.labelPlateNo.AutoSize = true;
            this.labelPlateNo.BackColor = System.Drawing.Color.Transparent;
            this.labelPlateNo.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelPlateNo.ForeColor = System.Drawing.Color.White;
            this.labelPlateNo.Location = new System.Drawing.Point(667, 233);
            this.labelPlateNo.Name = "labelPlateNo";
            this.labelPlateNo.Size = new System.Drawing.Size(67, 20);
            this.labelPlateNo.TabIndex = 69;
            this.labelPlateNo.Text = "PlateNo";
            // 
            // labelEngineNo
            // 
            this.labelEngineNo.AutoSize = true;
            this.labelEngineNo.BackColor = System.Drawing.Color.Transparent;
            this.labelEngineNo.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelEngineNo.ForeColor = System.Drawing.Color.White;
            this.labelEngineNo.Location = new System.Drawing.Point(667, 207);
            this.labelEngineNo.Name = "labelEngineNo";
            this.labelEngineNo.Size = new System.Drawing.Size(81, 20);
            this.labelEngineNo.TabIndex = 68;
            this.labelEngineNo.Text = "EngineNo";
            // 
            // labelRepaired
            // 
            this.labelRepaired.AutoSize = true;
            this.labelRepaired.BackColor = System.Drawing.Color.Transparent;
            this.labelRepaired.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelRepaired.ForeColor = System.Drawing.Color.White;
            this.labelRepaired.Location = new System.Drawing.Point(667, 311);
            this.labelRepaired.Name = "labelRepaired";
            this.labelRepaired.Size = new System.Drawing.Size(76, 20);
            this.labelRepaired.TabIndex = 74;
            this.labelRepaired.Text = "Repaired";
            // 
            // comboBoxRepaired
            // 
            this.comboBoxRepaired.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.comboBoxRepaired.FormattingEnabled = true;
            this.comboBoxRepaired.Items.AddRange(new object[] {
            "",
            "Yes",
            "No"});
            this.comboBoxRepaired.Location = new System.Drawing.Point(777, 309);
            this.comboBoxRepaired.Name = "comboBoxRepaired";
            this.comboBoxRepaired.Size = new System.Drawing.Size(139, 24);
            this.comboBoxRepaired.TabIndex = 75;
            // 
            // textBoxRepairCost
            // 
            this.textBoxRepairCost.Font = new System.Drawing.Font("Montserrat", 8.999999F);
            this.textBoxRepairCost.Location = new System.Drawing.Point(777, 284);
            this.textBoxRepairCost.Name = "textBoxRepairCost";
            this.textBoxRepairCost.Size = new System.Drawing.Size(139, 22);
            this.textBoxRepairCost.TabIndex = 77;
            // 
            // labelRepairCost
            // 
            this.labelRepairCost.AutoSize = true;
            this.labelRepairCost.BackColor = System.Drawing.Color.Transparent;
            this.labelRepairCost.Font = new System.Drawing.Font("Montserrat SemiBold", 9.999999F, System.Drawing.FontStyle.Bold);
            this.labelRepairCost.ForeColor = System.Drawing.Color.White;
            this.labelRepairCost.Location = new System.Drawing.Point(667, 284);
            this.labelRepairCost.Name = "labelRepairCost";
            this.labelRepairCost.Size = new System.Drawing.Size(93, 20);
            this.labelRepairCost.TabIndex = 76;
            this.labelRepairCost.Text = "Repair Cost";
            // 
            // buttonNotifyWhatsapp
            // 
            this.buttonNotifyWhatsapp.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonNotifyWhatsapp.Location = new System.Drawing.Point(800, 369);
            this.buttonNotifyWhatsapp.Name = "buttonNotifyWhatsapp";
            this.buttonNotifyWhatsapp.Size = new System.Drawing.Size(112, 23);
            this.buttonNotifyWhatsapp.TabIndex = 78;
            this.buttonNotifyWhatsapp.Text = "NOTIFY Whatsapp";
            this.buttonNotifyWhatsapp.UseVisualStyleBackColor = true;
            // 
            // buttonNotifyEmail
            // 
            this.buttonNotifyEmail.Font = new System.Drawing.Font("Montserrat", 7.5F);
            this.buttonNotifyEmail.Location = new System.Drawing.Point(800, 397);
            this.buttonNotifyEmail.Name = "buttonNotifyEmail";
            this.buttonNotifyEmail.Size = new System.Drawing.Size(112, 23);
            this.buttonNotifyEmail.TabIndex = 79;
            this.buttonNotifyEmail.Text = "NOTIFY Email";
            this.buttonNotifyEmail.UseVisualStyleBackColor = true;
            // 
            // EmployeeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceAuto_Client.Properties.Resources.employeeBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1514, 963);
            this.Controls.Add(this.buttonNotifyEmail);
            this.Controls.Add(this.buttonNotifyWhatsapp);
            this.Controls.Add(this.textBoxRepairCost);
            this.Controls.Add(this.labelRepairCost);
            this.Controls.Add(this.comboBoxRepaired);
            this.Controls.Add(this.labelRepaired);
            this.Controls.Add(this.textBoxPlateNo);
            this.Controls.Add(this.textBoxDefect);
            this.Controls.Add(this.textBoxEngineNo);
            this.Controls.Add(this.labelDefect);
            this.Controls.Add(this.labelPlateNo);
            this.Controls.Add(this.labelEngineNo);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
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
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxPlateNo;
        private System.Windows.Forms.TextBox textBoxDefect;
        private System.Windows.Forms.TextBox textBoxEngineNo;
        private System.Windows.Forms.Label labelDefect;
        private System.Windows.Forms.Label labelPlateNo;
        private System.Windows.Forms.Label labelEngineNo;
        private System.Windows.Forms.Label labelRepaired;
        private System.Windows.Forms.ComboBox comboBoxRepaired;
        private System.Windows.Forms.TextBox textBoxRepairCost;
        private System.Windows.Forms.Label labelRepairCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn carID;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn defect;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn repaired;
        private System.Windows.Forms.Button buttonNotifyWhatsapp;
        private System.Windows.Forms.Button buttonNotifyEmail;
    }
}