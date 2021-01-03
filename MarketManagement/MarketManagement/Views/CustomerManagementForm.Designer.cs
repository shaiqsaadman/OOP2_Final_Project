namespace MarketManagement.Views
{
    partial class CustomerManagementForm
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
            this.buttonDeleteC = new System.Windows.Forms.Button();
            this.buttonAddC = new System.Windows.Forms.Button();
            this.buttonUpdateC = new System.Windows.Forms.Button();
            this.textBoxCUName = new System.Windows.Forms.TextBox();
            this.labelCUName = new System.Windows.Forms.Label();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.labelCName = new System.Windows.Forms.Label();
            this.textBoxSrcC = new System.Windows.Forms.TextBox();
            this.labelSrcC = new System.Windows.Forms.Label();
            this.buttonSrcC = new System.Windows.Forms.Button();
            this.textBoxCOTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeleteC
            // 
            this.buttonDeleteC.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeleteC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDeleteC.Location = new System.Drawing.Point(299, 356);
            this.buttonDeleteC.Name = "buttonDeleteC";
            this.buttonDeleteC.Size = new System.Drawing.Size(182, 34);
            this.buttonDeleteC.TabIndex = 40;
            this.buttonDeleteC.Text = "Delete Customer";
            this.buttonDeleteC.UseVisualStyleBackColor = false;
            this.buttonDeleteC.Click += new System.EventHandler(this.buttonDeleteC_Click);
            // 
            // buttonAddC
            // 
            this.buttonAddC.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddC.Location = new System.Drawing.Point(299, 276);
            this.buttonAddC.Name = "buttonAddC";
            this.buttonAddC.Size = new System.Drawing.Size(182, 34);
            this.buttonAddC.TabIndex = 39;
            this.buttonAddC.Text = "Add Customer";
            this.buttonAddC.UseVisualStyleBackColor = false;
            this.buttonAddC.Click += new System.EventHandler(this.buttonAddC_Click);
            // 
            // buttonUpdateC
            // 
            this.buttonUpdateC.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateC.Location = new System.Drawing.Point(299, 316);
            this.buttonUpdateC.Name = "buttonUpdateC";
            this.buttonUpdateC.Size = new System.Drawing.Size(182, 34);
            this.buttonUpdateC.TabIndex = 38;
            this.buttonUpdateC.Text = "Update Customer";
            this.buttonUpdateC.UseVisualStyleBackColor = false;
            this.buttonUpdateC.Click += new System.EventHandler(this.buttonUpdateC_Click);
            // 
            // textBoxCUName
            // 
            this.textBoxCUName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCUName.Location = new System.Drawing.Point(299, 210);
            this.textBoxCUName.Name = "textBoxCUName";
            this.textBoxCUName.Size = new System.Drawing.Size(276, 27);
            this.textBoxCUName.TabIndex = 37;
            // 
            // labelCUName
            // 
            this.labelCUName.AutoSize = true;
            this.labelCUName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCUName.Location = new System.Drawing.Point(105, 213);
            this.labelCUName.Name = "labelCUName";
            this.labelCUName.Size = new System.Drawing.Size(188, 18);
            this.labelCUName.TabIndex = 36;
            this.labelCUName.Text = "Customer Username";
            // 
            // textBoxCName
            // 
            this.textBoxCName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCName.Location = new System.Drawing.Point(299, 177);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(276, 27);
            this.textBoxCName.TabIndex = 35;
            // 
            // labelCName
            // 
            this.labelCName.AutoSize = true;
            this.labelCName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCName.Location = new System.Drawing.Point(105, 180);
            this.labelCName.Name = "labelCName";
            this.labelCName.Size = new System.Drawing.Size(149, 18);
            this.labelCName.TabIndex = 34;
            this.labelCName.Text = "Customer Name";
            // 
            // textBoxSrcC
            // 
            this.textBoxSrcC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrcC.Location = new System.Drawing.Point(270, 95);
            this.textBoxSrcC.Name = "textBoxSrcC";
            this.textBoxSrcC.Size = new System.Drawing.Size(276, 27);
            this.textBoxSrcC.TabIndex = 33;
            // 
            // labelSrcC
            // 
            this.labelSrcC.AutoSize = true;
            this.labelSrcC.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcC.Location = new System.Drawing.Point(105, 98);
            this.labelSrcC.Name = "labelSrcC";
            this.labelSrcC.Size = new System.Drawing.Size(159, 18);
            this.labelSrcC.TabIndex = 32;
            this.labelSrcC.Text = "Search Customer";
            // 
            // buttonSrcC
            // 
            this.buttonSrcC.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSrcC.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrcC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSrcC.Location = new System.Drawing.Point(471, 128);
            this.buttonSrcC.Name = "buttonSrcC";
            this.buttonSrcC.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcC.TabIndex = 42;
            this.buttonSrcC.Text = "Search";
            this.buttonSrcC.UseVisualStyleBackColor = false;
            this.buttonSrcC.Click += new System.EventHandler(this.buttonSrcC_Click);
            // 
            // textBoxCOTP
            // 
            this.textBoxCOTP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCOTP.Location = new System.Drawing.Point(299, 243);
            this.textBoxCOTP.Name = "textBoxCOTP";
            this.textBoxCOTP.Size = new System.Drawing.Size(276, 27);
            this.textBoxCOTP.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Customer OTP";
            // 
            // CustomerManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.textBoxCOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSrcC);
            this.Controls.Add(this.buttonDeleteC);
            this.Controls.Add(this.buttonAddC);
            this.Controls.Add(this.buttonUpdateC);
            this.Controls.Add(this.textBoxCUName);
            this.Controls.Add(this.labelCUName);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.labelCName);
            this.Controls.Add(this.textBoxSrcC);
            this.Controls.Add(this.labelSrcC);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CustomerManagementForm";
            this.Text = "CustomerManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteC;
        private System.Windows.Forms.Button buttonAddC;
        private System.Windows.Forms.Button buttonUpdateC;
        private System.Windows.Forms.TextBox textBoxCUName;
        private System.Windows.Forms.Label labelCUName;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.Label labelCName;
        private System.Windows.Forms.TextBox textBoxSrcC;
        private System.Windows.Forms.Label labelSrcC;
        private System.Windows.Forms.Button buttonSrcC;
        private System.Windows.Forms.TextBox textBoxCOTP;
        private System.Windows.Forms.Label label1;
    }
}