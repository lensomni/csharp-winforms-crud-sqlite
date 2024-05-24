namespace oop_kr
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonShowMenuForm = new System.Windows.Forms.Button();
            this.ButtonShowAnalyticsForm = new System.Windows.Forms.Button();
            this.ButtonShowOrdersForm = new System.Windows.Forms.Button();
            this.ButtonShowFeaturesForm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonShowMenuForm
            // 
            this.ButtonShowMenuForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowMenuForm.Location = new System.Drawing.Point(0, 87);
            this.ButtonShowMenuForm.Name = "ButtonShowMenuForm";
            this.ButtonShowMenuForm.Size = new System.Drawing.Size(188, 74);
            this.ButtonShowMenuForm.TabIndex = 4;
            this.ButtonShowMenuForm.Text = "МЕНЮ";
            this.ButtonShowMenuForm.UseVisualStyleBackColor = true;
            this.ButtonShowMenuForm.Click += new System.EventHandler(this.ButtonShowMenuForm_Click);
            // 
            // ButtonShowAnalyticsForm
            // 
            this.ButtonShowAnalyticsForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowAnalyticsForm.Location = new System.Drawing.Point(0, 249);
            this.ButtonShowAnalyticsForm.Name = "ButtonShowAnalyticsForm";
            this.ButtonShowAnalyticsForm.Size = new System.Drawing.Size(188, 74);
            this.ButtonShowAnalyticsForm.TabIndex = 5;
            this.ButtonShowAnalyticsForm.Text = "АНАЛИЗ";
            this.ButtonShowAnalyticsForm.UseVisualStyleBackColor = true;
            this.ButtonShowAnalyticsForm.Click += new System.EventHandler(this.ButtonShowAnalyticsForm_Click);
            // 
            // ButtonShowOrdersForm
            // 
            this.ButtonShowOrdersForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowOrdersForm.Location = new System.Drawing.Point(0, 168);
            this.ButtonShowOrdersForm.Name = "ButtonShowOrdersForm";
            this.ButtonShowOrdersForm.Size = new System.Drawing.Size(188, 74);
            this.ButtonShowOrdersForm.TabIndex = 6;
            this.ButtonShowOrdersForm.Text = "ЗАКАЗЫ";
            this.ButtonShowOrdersForm.UseVisualStyleBackColor = true;
            this.ButtonShowOrdersForm.Click += new System.EventHandler(this.ButtonShowOrdersForm_Click);
            // 
            // ButtonShowFeaturesForm
            // 
            this.ButtonShowFeaturesForm.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonShowFeaturesForm.Location = new System.Drawing.Point(0, 330);
            this.ButtonShowFeaturesForm.Name = "ButtonShowFeaturesForm";
            this.ButtonShowFeaturesForm.Size = new System.Drawing.Size(188, 74);
            this.ButtonShowFeaturesForm.TabIndex = 7;
            this.ButtonShowFeaturesForm.Text = "ДОП";
            this.ButtonShowFeaturesForm.UseVisualStyleBackColor = true;
            this.ButtonShowFeaturesForm.Click += new System.EventHandler(this.ButtonShowFeaturesForm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Peru;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.ButtonShowFeaturesForm);
            this.panel2.Controls.Add(this.ButtonShowOrdersForm);
            this.panel2.Controls.Add(this.ButtonShowMenuForm);
            this.panel2.Controls.Add(this.ButtonShowAnalyticsForm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 554);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 554);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 554);
            this.panel3.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(-3, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 74);
            this.button5.TabIndex = 7;
            this.button5.Text = "БД";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ButtonShowFeaturesForm_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(-3, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 74);
            this.button6.TabIndex = 6;
            this.button6.Text = "ЗАКАЗЫ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ButtonShowOrdersForm_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(-3, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 74);
            this.button7.TabIndex = 4;
            this.button7.Text = "МЕНЮ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ButtonShowMenuForm_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(-3, 276);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 74);
            this.button8.TabIndex = 5;
            this.button8.Text = "АНАЛИТИКА";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ButtonShowAnalyticsForm_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 74);
            this.button1.TabIndex = 7;
            this.button1.Text = "ДОП";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 74);
            this.button2.TabIndex = 6;
            this.button2.Text = "ЗАКАЗЫ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(0, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 74);
            this.button3.TabIndex = 4;
            this.button3.Text = "МЕНЮ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(0, 249);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 74);
            this.button4.TabIndex = 5;
            this.button4.Text = "АНАЛИЗ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 554);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonShowMenuForm;
        private System.Windows.Forms.Button ButtonShowAnalyticsForm;
        private System.Windows.Forms.Button ButtonShowOrdersForm;
        private System.Windows.Forms.Button ButtonShowFeaturesForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}