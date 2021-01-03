namespace MarketManagement.Views
{
    partial class EmployeeForm
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
            this.buttonCManage = new System.Windows.Forms.Button();
            this.buttonPManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCManage
            // 
            this.buttonCManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCManage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCManage.Location = new System.Drawing.Point(93, 236);
            this.buttonCManage.Name = "buttonCManage";
            this.buttonCManage.Size = new System.Drawing.Size(615, 51);
            this.buttonCManage.TabIndex = 14;
            this.buttonCManage.Text = "Customer Management";
            this.buttonCManage.UseVisualStyleBackColor = false;
            this.buttonCManage.Click += new System.EventHandler(this.buttonCManage_Click);
            // 
            // buttonPManage
            // 
            this.buttonPManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPManage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPManage.Location = new System.Drawing.Point(92, 163);
            this.buttonPManage.Name = "buttonPManage";
            this.buttonPManage.Size = new System.Drawing.Size(615, 51);
            this.buttonPManage.TabIndex = 13;
            this.buttonPManage.Text = "Ptoduct Management";
            this.buttonPManage.UseVisualStyleBackColor = false;
            this.buttonPManage.Click += new System.EventHandler(this.buttonPManage_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCManage);
            this.Controls.Add(this.buttonPManage);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCManage;
        private System.Windows.Forms.Button buttonPManage;
    }
}