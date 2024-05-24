namespace oop_kr
{
    partial class AnalyticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.ButtonRefreshChart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGenerateReport = new System.Windows.Forms.Button();
            this.chartDishDemand = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartDishDemand)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CalendarFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStartDate.CustomFormat = "dd/MM/yyyy   HH:mm";
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(70, 50);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.Value = new System.DateTime(2024, 5, 17, 18, 22, 40, 0);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CalendarFont = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEndDate.CustomFormat = "dd/MM/yyyy   HH:mm";
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(322, 50);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(196, 23);
            this.dateTimePickerEndDate.TabIndex = 1;
            this.dateTimePickerEndDate.Value = new System.DateTime(2024, 5, 22, 0, 0, 0, 0);
            // 
            // ButtonRefreshChart
            // 
            this.ButtonRefreshChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonRefreshChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRefreshChart.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonRefreshChart.ForeColor = System.Drawing.Color.White;
            this.ButtonRefreshChart.Location = new System.Drawing.Point(543, 41);
            this.ButtonRefreshChart.Name = "ButtonRefreshChart";
            this.ButtonRefreshChart.Size = new System.Drawing.Size(98, 40);
            this.ButtonRefreshChart.TabIndex = 8;
            this.ButtonRefreshChart.Text = "OK";
            this.ButtonRefreshChart.UseVisualStyleBackColor = false;
            this.ButtonRefreshChart.Click += new System.EventHandler(this.ButtonRefreshChart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label6.Location = new System.Drawing.Point(37, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "от";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label1.Location = new System.Drawing.Point(286, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "до";
            // 
            // ButtonGenerateReport
            // 
            this.ButtonGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerateReport.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonGenerateReport.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerateReport.Location = new System.Drawing.Point(668, 407);
            this.ButtonGenerateReport.Name = "ButtonGenerateReport";
            this.ButtonGenerateReport.Size = new System.Drawing.Size(169, 52);
            this.ButtonGenerateReport.TabIndex = 33;
            this.ButtonGenerateReport.Text = "Составить отчёт";
            this.ButtonGenerateReport.UseVisualStyleBackColor = false;
            this.ButtonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // chartDishDemand
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.chartDishDemand.ChartAreas.Add(chartArea1);
            this.chartDishDemand.Location = new System.Drawing.Point(6, 104);
            this.chartDishDemand.Name = "chartDishDemand";
            this.chartDishDemand.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chartDishDemand.Series.Add(series1);
            this.chartDishDemand.Size = new System.Drawing.Size(656, 402);
            this.chartDishDemand.TabIndex = 2;
            this.chartDishDemand.Text = "chart1";
            title1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Анализ спроса на блюда в зависимости от цены";
            this.chartDishDemand.Titles.Add(title1);
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 534);
            this.Controls.Add(this.ButtonGenerateReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonRefreshChart);
            this.Controls.Add(this.chartDishDemand);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Name = "AnalyticsForm";
            this.Text = "AnalyticsForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartDishDemand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button ButtonRefreshChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonGenerateReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDishDemand;
    }
}