namespace oop_kr
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonAddOrder = new System.Windows.Forms.Button();
            this.dataGridViewAllOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelOrderPrice = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonPlaceOrder = new System.Windows.Forms.Button();
            this.ButtonAddDishToOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrderItems = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonAddOrder);
            this.tabPage1.Controls.Add(this.dataGridViewAllOrders);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ButtonAddOrder
            // 
            this.ButtonAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddOrder.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonAddOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonAddOrder.Location = new System.Drawing.Point(646, 30);
            this.ButtonAddOrder.Name = "ButtonAddOrder";
            this.ButtonAddOrder.Size = new System.Drawing.Size(192, 52);
            this.ButtonAddOrder.TabIndex = 3;
            this.ButtonAddOrder.Text = "Новый заказ";
            this.ButtonAddOrder.UseVisualStyleBackColor = false;
            this.ButtonAddOrder.Click += new System.EventHandler(this.ButtonAddOrder_Click);
            // 
            // dataGridViewAllOrders
            // 
            this.dataGridViewAllOrders.AllowUserToAddRows = false;
            this.dataGridViewAllOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllOrders.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllOrders.Location = new System.Drawing.Point(6, 98);
            this.dataGridViewAllOrders.Name = "dataGridViewAllOrders";
            this.dataGridViewAllOrders.ReadOnly = true;
            this.dataGridViewAllOrders.RowHeadersVisible = false;
            this.dataGridViewAllOrders.RowTemplate.Height = 30;
            this.dataGridViewAllOrders.Size = new System.Drawing.Size(832, 365);
            this.dataGridViewAllOrders.TabIndex = 2;
            this.dataGridViewAllOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllOrders_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelOrderPrice);
            this.tabPage2.Controls.Add(this.ButtonCancel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ButtonPlaceOrder);
            this.tabPage2.Controls.Add(this.ButtonAddDishToOrder);
            this.tabPage2.Controls.Add(this.dataGridViewOrderItems);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelOrderPrice
            // 
            this.labelOrderPrice.AutoSize = true;
            this.labelOrderPrice.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.labelOrderPrice.Location = new System.Drawing.Point(128, 370);
            this.labelOrderPrice.Name = "labelOrderPrice";
            this.labelOrderPrice.Size = new System.Drawing.Size(20, 21);
            this.labelOrderPrice.TabIndex = 9;
            this.labelOrderPrice.Text = "0";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.Location = new System.Drawing.Point(644, 354);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(169, 52);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.label1.Location = new System.Drawing.Point(57, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сумма: ";
            // 
            // ButtonPlaceOrder
            // 
            this.ButtonPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlaceOrder.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonPlaceOrder.Location = new System.Drawing.Point(313, 354);
            this.ButtonPlaceOrder.Name = "ButtonPlaceOrder";
            this.ButtonPlaceOrder.Size = new System.Drawing.Size(313, 52);
            this.ButtonPlaceOrder.TabIndex = 6;
            this.ButtonPlaceOrder.Text = "Оформить заказ";
            this.ButtonPlaceOrder.UseVisualStyleBackColor = false;
            this.ButtonPlaceOrder.Click += new System.EventHandler(this.ButtonPlaceOrder_Click);
            // 
            // ButtonAddDishToOrder
            // 
            this.ButtonAddDishToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonAddDishToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddDishToOrder.Font = new System.Drawing.Font("Montserrat", 11.25F);
            this.ButtonAddDishToOrder.ForeColor = System.Drawing.Color.White;
            this.ButtonAddDishToOrder.Location = new System.Drawing.Point(644, 77);
            this.ButtonAddDishToOrder.Name = "ButtonAddDishToOrder";
            this.ButtonAddDishToOrder.Size = new System.Drawing.Size(169, 52);
            this.ButtonAddDishToOrder.TabIndex = 4;
            this.ButtonAddDishToOrder.Text = "Добавить";
            this.ButtonAddDishToOrder.UseVisualStyleBackColor = false;
            this.ButtonAddDishToOrder.Click += new System.EventHandler(this.ButtonAddDishToOrder_Click);
            // 
            // dataGridViewOrderItems
            // 
            this.dataGridViewOrderItems.AllowUserToAddRows = false;
            this.dataGridViewOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrderItems.Location = new System.Drawing.Point(28, 77);
            this.dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            this.dataGridViewOrderItems.ReadOnly = true;
            this.dataGridViewOrderItems.RowHeadersVisible = false;
            this.dataGridViewOrderItems.RowTemplate.Height = 30;
            this.dataGridViewOrderItems.Size = new System.Drawing.Size(598, 250);
            this.dataGridViewOrderItems.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 534);
            this.Controls.Add(this.tabControl1);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ButtonAddOrder;
        private System.Windows.Forms.DataGridView dataGridViewAllOrders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonPlaceOrder;
        private System.Windows.Forms.Button ButtonAddDishToOrder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label labelOrderPrice;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;
    }
}