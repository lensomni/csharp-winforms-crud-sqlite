namespace oop_kr
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackBarDishPrice = new System.Windows.Forms.TrackBar();
            this.textBoxSearchDish = new System.Windows.Forms.TextBox();
            this.ButtonGenerateMenu = new System.Windows.Forms.Button();
            this.ButtonAddDish = new System.Windows.Forms.Button();
            this.dataGridViewAllDishes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.comboBoxDishCategory = new System.Windows.Forms.ComboBox();
            this.textBoxDishPrice = new System.Windows.Forms.TextBox();
            this.textBoxDishDescription = new System.Windows.Forms.TextBox();
            this.textBoxDishName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelSearchResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDishPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDishes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(4, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelSearchResult);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TrackBarDishPrice);
            this.tabPage1.Controls.Add(this.textBoxSearchDish);
            this.tabPage1.Controls.Add(this.ButtonGenerateMenu);
            this.tabPage1.Controls.Add(this.ButtonAddDish);
            this.tabPage1.Controls.Add(this.dataGridViewAllDishes);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(468, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "10000";
            // 
            // TrackBarDishPrice
            // 
            this.TrackBarDishPrice.BackColor = System.Drawing.Color.White;
            this.TrackBarDishPrice.Location = new System.Drawing.Point(369, 11);
            this.TrackBarDishPrice.Maximum = 0;
            this.TrackBarDishPrice.Name = "TrackBarDishPrice";
            this.TrackBarDishPrice.Size = new System.Drawing.Size(246, 45);
            this.TrackBarDishPrice.SmallChange = 500;
            this.TrackBarDishPrice.TabIndex = 23;
            this.TrackBarDishPrice.Scroll += new System.EventHandler(this.TrackBarDishPrice_Scroll);
            // 
            // textBoxSearchDish
            // 
            this.textBoxSearchDish.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchDish.Location = new System.Drawing.Point(23, 17);
            this.textBoxSearchDish.Name = "textBoxSearchDish";
            this.textBoxSearchDish.Size = new System.Drawing.Size(320, 26);
            this.textBoxSearchDish.TabIndex = 9;
            this.textBoxSearchDish.TextChanged += new System.EventHandler(this.textBoxSearchDish_TextChanged);
            // 
            // ButtonGenerateMenu
            // 
            this.ButtonGenerateMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonGenerateMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerateMenu.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGenerateMenu.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerateMenu.Location = new System.Drawing.Point(597, 379);
            this.ButtonGenerateMenu.Name = "ButtonGenerateMenu";
            this.ButtonGenerateMenu.Size = new System.Drawing.Size(239, 52);
            this.ButtonGenerateMenu.TabIndex = 8;
            this.ButtonGenerateMenu.Text = "Сгенерировать меню";
            this.ButtonGenerateMenu.UseVisualStyleBackColor = false;
            this.ButtonGenerateMenu.Click += new System.EventHandler(this.ButtonGenerateMenu_Click);
            // 
            // ButtonAddDish
            // 
            this.ButtonAddDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDish.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddDish.ForeColor = System.Drawing.Color.White;
            this.ButtonAddDish.Location = new System.Drawing.Point(644, 4);
            this.ButtonAddDish.Name = "ButtonAddDish";
            this.ButtonAddDish.Size = new System.Drawing.Size(192, 52);
            this.ButtonAddDish.TabIndex = 7;
            this.ButtonAddDish.Text = "Новое блюдо";
            this.ButtonAddDish.UseVisualStyleBackColor = false;
            this.ButtonAddDish.Click += new System.EventHandler(this.ButtonAddDish_Click);
            // 
            // dataGridViewAllDishes
            // 
            this.dataGridViewAllDishes.AllowUserToAddRows = false;
            this.dataGridViewAllDishes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllDishes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllDishes.Location = new System.Drawing.Point(23, 87);
            this.dataGridViewAllDishes.Name = "dataGridViewAllDishes";
            this.dataGridViewAllDishes.ReadOnly = true;
            this.dataGridViewAllDishes.RowHeadersVisible = false;
            this.dataGridViewAllDishes.RowTemplate.Height = 30;
            this.dataGridViewAllDishes.Size = new System.Drawing.Size(813, 274);
            this.dataGridViewAllDishes.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ButtonCancel);
            this.tabPage2.Controls.Add(this.ButtonSave);
            this.tabPage2.Controls.Add(this.comboBoxDishCategory);
            this.tabPage2.Controls.Add(this.textBoxDishPrice);
            this.tabPage2.Controls.Add(this.textBoxDishDescription);
            this.tabPage2.Controls.Add(this.textBoxDishName);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label6.Location = new System.Drawing.Point(548, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "руб";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label5.Location = new System.Drawing.Point(233, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Категория";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label4.Location = new System.Drawing.Point(239, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label3.Location = new System.Drawing.Point(233, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label2.Location = new System.Drawing.Point(233, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Название";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(552, 354);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(199, 50);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(110, 354);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(199, 50);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboBoxDishCategory
            // 
            this.comboBoxDishCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDishCategory.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.comboBoxDishCategory.FormattingEnabled = true;
            this.comboBoxDishCategory.Items.AddRange(new object[] {
            "Основные блюда",
            "Супы",
            "Салаты",
            "Десерты",
            "Напитки"});
            this.comboBoxDishCategory.Location = new System.Drawing.Point(419, 284);
            this.comboBoxDishCategory.Name = "comboBoxDishCategory";
            this.comboBoxDishCategory.Size = new System.Drawing.Size(203, 29);
            this.comboBoxDishCategory.TabIndex = 3;
            // 
            // textBoxDishPrice
            // 
            this.textBoxDishPrice.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.textBoxDishPrice.Location = new System.Drawing.Point(419, 223);
            this.textBoxDishPrice.Name = "textBoxDishPrice";
            this.textBoxDishPrice.Size = new System.Drawing.Size(123, 26);
            this.textBoxDishPrice.TabIndex = 2;
            // 
            // textBoxDishDescription
            // 
            this.textBoxDishDescription.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.textBoxDishDescription.Location = new System.Drawing.Point(419, 110);
            this.textBoxDishDescription.Multiline = true;
            this.textBoxDishDescription.Name = "textBoxDishDescription";
            this.textBoxDishDescription.Size = new System.Drawing.Size(264, 78);
            this.textBoxDishDescription.TabIndex = 1;
            // 
            // textBoxDishName
            // 
            this.textBoxDishName.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.textBoxDishName.Location = new System.Drawing.Point(419, 49);
            this.textBoxDishName.Name = "textBoxDishName";
            this.textBoxDishName.Size = new System.Drawing.Size(264, 26);
            this.textBoxDishName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelSearchResult
            // 
            this.labelSearchResult.AutoSize = true;
            this.labelSearchResult.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchResult.Location = new System.Drawing.Point(22, 53);
            this.labelSearchResult.Name = "labelSearchResult";
            this.labelSearchResult.Size = new System.Drawing.Size(0, 21);
            this.labelSearchResult.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(432, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "до";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(529, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "руб";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDishPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllDishes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ButtonGenerateMenu;
        private System.Windows.Forms.Button ButtonAddDish;
        private System.Windows.Forms.DataGridView dataGridViewAllDishes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxDishName;
        private System.Windows.Forms.ComboBox comboBoxDishCategory;
        private System.Windows.Forms.TextBox textBoxDishPrice;
        private System.Windows.Forms.TextBox textBoxDishDescription;
        private System.Windows.Forms.TextBox textBoxSearchDish;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TrackBar TrackBarDishPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSearchResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}