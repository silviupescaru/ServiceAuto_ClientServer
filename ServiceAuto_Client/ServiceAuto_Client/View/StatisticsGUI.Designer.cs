namespace ServiceAuto_Client.View
{
    partial class StatisticsGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartCarStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelChangeLanguage = new System.Windows.Forms.Label();
            this.comboBoxChangeLanguage = new System.Windows.Forms.ComboBox();
            this.labelSelectCriterion = new System.Windows.Forms.Label();
            this.comboBoxCriterion = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartCarStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCarStatistics
            // 
            this.chartCarStatistics.BackColor = System.Drawing.Color.Transparent;
            this.chartCarStatistics.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartCarStatistics.ChartAreas.Add(chartArea2);
            this.chartCarStatistics.Cursor = System.Windows.Forms.Cursors.No;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chartCarStatistics.Legends.Add(legend2);
            this.chartCarStatistics.Location = new System.Drawing.Point(32, 31);
            this.chartCarStatistics.Name = "chartCarStatistics";
            this.chartCarStatistics.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCarStatistics.Series.Add(series2);
            this.chartCarStatistics.Size = new System.Drawing.Size(837, 533);
            this.chartCarStatistics.TabIndex = 4;
            this.chartCarStatistics.Text = "chartCarStatistics";
            // 
            // labelChangeLanguage
            // 
            this.labelChangeLanguage.AutoSize = true;
            this.labelChangeLanguage.BackColor = System.Drawing.Color.Transparent;
            this.labelChangeLanguage.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelChangeLanguage.ForeColor = System.Drawing.Color.White;
            this.labelChangeLanguage.Location = new System.Drawing.Point(233, 642);
            this.labelChangeLanguage.Name = "labelChangeLanguage";
            this.labelChangeLanguage.Size = new System.Drawing.Size(163, 22);
            this.labelChangeLanguage.TabIndex = 12;
            this.labelChangeLanguage.Text = "Change Language";
            // 
            // comboBoxChangeLanguage
            // 
            this.comboBoxChangeLanguage.FormattingEnabled = true;
            this.comboBoxChangeLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "Russian"});
            this.comboBoxChangeLanguage.Location = new System.Drawing.Point(402, 645);
            this.comboBoxChangeLanguage.Name = "comboBoxChangeLanguage";
            this.comboBoxChangeLanguage.Size = new System.Drawing.Size(119, 21);
            this.comboBoxChangeLanguage.TabIndex = 11;
            // 
            // labelSelectCriterion
            // 
            this.labelSelectCriterion.AutoSize = true;
            this.labelSelectCriterion.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectCriterion.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.labelSelectCriterion.ForeColor = System.Drawing.Color.White;
            this.labelSelectCriterion.Location = new System.Drawing.Point(233, 608);
            this.labelSelectCriterion.Name = "labelSelectCriterion";
            this.labelSelectCriterion.Size = new System.Drawing.Size(139, 22);
            this.labelSelectCriterion.TabIndex = 10;
            this.labelSelectCriterion.Text = "Select Criterion";
            // 
            // comboBoxCriterion
            // 
            this.comboBoxCriterion.FormattingEnabled = true;
            this.comboBoxCriterion.Items.AddRange(new object[] {
            "",
            "Brand",
            "Fuel"});
            this.comboBoxCriterion.Location = new System.Drawing.Point(402, 611);
            this.comboBoxCriterion.Name = "comboBoxCriterion";
            this.comboBoxCriterion.Size = new System.Drawing.Size(119, 21);
            this.comboBoxCriterion.TabIndex = 9;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Montserrat", 9F);
            this.buttonBack.Location = new System.Drawing.Point(530, 623);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 29);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Back to Manager";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // StatisticsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceAuto_Client.Properties.Resources.statisticsBG;
            this.ClientSize = new System.Drawing.Size(900, 699);
            this.Controls.Add(this.labelChangeLanguage);
            this.Controls.Add(this.comboBoxChangeLanguage);
            this.Controls.Add(this.labelSelectCriterion);
            this.Controls.Add(this.comboBoxCriterion);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.chartCarStatistics);
            this.Name = "StatisticsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsGUI";
            ((System.ComponentModel.ISupportInitialize)(this.chartCarStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCarStatistics;
        private System.Windows.Forms.Label labelChangeLanguage;
        private System.Windows.Forms.ComboBox comboBoxChangeLanguage;
        private System.Windows.Forms.Label labelSelectCriterion;
        private System.Windows.Forms.ComboBox comboBoxCriterion;
        private System.Windows.Forms.Button buttonBack;
    }
}