namespace MarketManagement.Views
{
    partial class AdminForm
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
            this.buttonEManage = new System.Windows.Forms.Button();
            this.buttonSManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEManage
            // 
            this.buttonEManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEManage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEManage.Location = new System.Drawing.Point(93, 236);
            this.buttonEManage.Name = "buttonEManage";
            this.buttonEManage.Size = new System.Drawing.Size(615, 51);
            this.buttonEManage.TabIndex = 12;
            this.buttonEManage.Text = "Employee Management";
            this.buttonEManage.UseVisualStyleBackColor = false;
            this.buttonEManage.Click += new System.EventHandler(this.buttonEManage_Click);
            // 
            // buttonSManage
            // 
            this.buttonSManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSManage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSManage.Location = new System.Drawing.Point(92, 163);
            this.buttonSManage.Name = "buttonSManage";
            this.buttonSManage.Size = new System.Drawing.Size(615, 51);
            this.buttonSManage.TabIndex = 11;
            this.buttonSManage.Text = "Shop Management";
            this.buttonSManage.UseVisualStyleBackColor = false;
            this.buttonSManage.Click += new System.EventHandler(this.buttonSManage_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEManage);
            this.Controls.Add(this.buttonSManage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEManage;
        private System.Windows.Forms.Button buttonSManage;
    }
}