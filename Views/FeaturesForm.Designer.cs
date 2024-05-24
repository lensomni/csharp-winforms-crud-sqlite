namespace oop_kr
{
    partial class FeaturesForm
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
            this.ButtonDeleteDataBase = new System.Windows.Forms.Button();
            this.ButtonCreateDataBase = new System.Windows.Forms.Button();
            this.ButtonSaveToJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonDeleteDataBase
            // 
            this.ButtonDeleteDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonDeleteDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteDataBase.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeleteDataBase.ForeColor = System.Drawing.Color.White;
            this.ButtonDeleteDataBase.Location = new System.Drawing.Point(287, 167);
            this.ButtonDeleteDataBase.Name = "ButtonDeleteDataBase";
            this.ButtonDeleteDataBase.Size = new System.Drawing.Size(303, 67);
            this.ButtonDeleteDataBase.TabIndex = 4;
            this.ButtonDeleteDataBase.Text = "Удалить БД";
            this.ButtonDeleteDataBase.UseVisualStyleBackColor = false;
            this.ButtonDeleteDataBase.Click += new System.EventHandler(this.ButtonDeleteDataBase_Click);
            // 
            // ButtonCreateDataBase
            // 
            this.ButtonCreateDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonCreateDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateDataBase.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateDataBase.ForeColor = System.Drawing.Color.White;
            this.ButtonCreateDataBase.Location = new System.Drawing.Point(287, 258);
            this.ButtonCreateDataBase.Name = "ButtonCreateDataBase";
            this.ButtonCreateDataBase.Size = new System.Drawing.Size(303, 67);
            this.ButtonCreateDataBase.TabIndex = 5;
            this.ButtonCreateDataBase.Text = "Создать БД";
            this.ButtonCreateDataBase.UseVisualStyleBackColor = false;
            this.ButtonCreateDataBase.Click += new System.EventHandler(this.ButtonCreateDataBase_Click);
            // 
            // ButtonSaveToJSON
            // 
            this.ButtonSaveToJSON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(28)))), ((int)(((byte)(90)))));
            this.ButtonSaveToJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveToJSON.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSaveToJSON.ForeColor = System.Drawing.Color.White;
            this.ButtonSaveToJSON.Location = new System.Drawing.Point(287, 349);
            this.ButtonSaveToJSON.Name = "ButtonSaveToJSON";
            this.ButtonSaveToJSON.Size = new System.Drawing.Size(303, 67);
            this.ButtonSaveToJSON.TabIndex = 6;
            this.ButtonSaveToJSON.Text = "Сохранить в JSON ";
            this.ButtonSaveToJSON.UseVisualStyleBackColor = false;
            this.ButtonSaveToJSON.Click += new System.EventHandler(this.ButtonSaveToJSON_Click);
            // 
            // FeaturesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(844, 466);
            this.Controls.Add(this.ButtonSaveToJSON);
            this.Controls.Add(this.ButtonCreateDataBase);
            this.Controls.Add(this.ButtonDeleteDataBase);
            this.Name = "FeaturesForm";
            this.Text = "FeaturesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDeleteDataBase;
        private System.Windows.Forms.Button ButtonCreateDataBase;
        private System.Windows.Forms.Button ButtonSaveToJSON;
    }
}