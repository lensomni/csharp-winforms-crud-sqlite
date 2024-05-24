namespace oop_kr
{
    partial class AddDishToOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDishToOrderForm));
            this.DataGridViewSearchDishes = new System.Windows.Forms.DataGridView();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchDishes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewSearchDishes
            // 
            this.DataGridViewSearchDishes.AllowUserToAddRows = false;
            this.DataGridViewSearchDishes.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewSearchDishes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewSearchDishes.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewSearchDishes.Location = new System.Drawing.Point(52, 79);
            this.DataGridViewSearchDishes.Name = "DataGridViewSearchDishes";
            this.DataGridViewSearchDishes.ReadOnly = true;
            this.DataGridViewSearchDishes.RowHeadersVisible = false;
            this.DataGridViewSearchDishes.RowTemplate.Height = 30;
            this.DataGridViewSearchDishes.Size = new System.Drawing.Size(557, 277);
            this.DataGridViewSearchDishes.TabIndex = 3;
            this.DataGridViewSearchDishes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewSearchDishes_CellDoubleClick);
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Items.AddRange(new object[] {
            "Все",
            "Основные блюда",
            "Супы",
            "Салаты",
            "Десерты",
            "Напитки"});
            this.ComboBoxCategory.Location = new System.Drawing.Point(349, 27);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(260, 29);
            this.ComboBoxCategory.TabIndex = 5;
            this.ComboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategory_SelectedIndexChanged);
            // 
            // AddDishToOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 375);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.DataGridViewSearchDishes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDishToOrderForm";
            this.Text = "AddDishForm";
            this.Load += new System.EventHandler(this.AddDishToOrderForm_Load);
            this.Resize += new System.EventHandler(this.AddDishToOrderForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewSearchDishes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewSearchDishes;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
    }
}