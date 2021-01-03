namespace MarketManagement.Views
{
    partial class EmployeeManagementForm
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
            this.buttonDeleteE = new System.Windows.Forms.Button();
            this.buttonAddE = new System.Windows.Forms.Button();
            this.buttonUpdateE = new System.Windows.Forms.Button();
            this.textBoxEUName = new System.Windows.Forms.TextBox();
            this.labelEUName = new System.Windows.Forms.Label();
            this.textBoxEName = new System.Windows.Forms.TextBox();
            this.labelEName = new System.Windows.Forms.Label();
            this.textBoxSrcE = new System.Windows.Forms.TextBox();
            this.labelSrcE = new System.Windows.Forms.Label();
            this.buttonSrcE = new System.Windows.Forms.Button();
            this.textBoxEOTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeleteE
            // 
            this.buttonDeleteE.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeleteE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDeleteE.Location = new System.Drawing.Point(291, 356);
            this.buttonDeleteE.Name = "buttonDeleteE";
            this.buttonDeleteE.Size = new System.Drawing.Size(182, 34);
            this.buttonDeleteE.TabIndex = 31;
            this.buttonDeleteE.Text = "Delete Employee";
            this.buttonDeleteE.UseVisualStyleBackColor = false;
            this.buttonDeleteE.Click += new System.EventHandler(this.buttonDeleteE_Click);
            // 
            // buttonAddE
            // 
            this.buttonAddE.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddE.Location = new System.Drawing.Point(291, 276);
            this.buttonAddE.Name = "buttonAddE";
            this.buttonAddE.Size = new System.Drawing.Size(182, 34);
            this.buttonAddE.TabIndex = 30;
            this.buttonAddE.Text = "Add Employee";
            this.buttonAddE.UseVisualStyleBackColor = false;
            this.buttonAddE.Click += new System.EventHandler(this.buttonAddE_Click);
            // 
            // buttonUpdateE
            // 
            this.buttonUpdateE.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateE.Location = new System.Drawing.Point(291, 316);
            this.buttonUpdateE.Name = "buttonUpdateE";
            this.buttonUpdateE.Size = new System.Drawing.Size(182, 34);
            this.buttonUpdateE.TabIndex = 29;
            this.buttonUpdateE.Text = "Update Employee";
            this.buttonUpdateE.UseVisualStyleBackColor = false;
            this.buttonUpdateE.Click += new System.EventHandler(this.buttonUpdateE_Click);
            // 
            // textBoxEUName
            // 
            this.textBoxEUName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEUName.Location = new System.Drawing.Point(291, 210);
            this.textBoxEUName.Name = "textBoxEUName";
            this.textBoxEUName.Size = new System.Drawing.Size(276, 27);
            this.textBoxEUName.TabIndex = 28;
            // 
            // labelEUName
            // 
            this.labelEUName.AutoSize = true;
            this.labelEUName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEUName.Location = new System.Drawing.Point(97, 213);
            this.labelEUName.Name = "labelEUName";
            this.labelEUName.Size = new System.Drawing.Size(188, 18);
            this.labelEUName.TabIndex = 27;
            this.labelEUName.Text = "Employee Username";
            // 
            // textBoxEName
            // 
            this.textBoxEName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEName.Location = new System.Drawing.Point(291, 177);
            this.textBoxEName.Name = "textBoxEName";
            this.textBoxEName.Size = new System.Drawing.Size(276, 27);
            this.textBoxEName.TabIndex = 26;
            // 
            // labelEName
            // 
            this.labelEName.AutoSize = true;
            this.labelEName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEName.Location = new System.Drawing.Point(97, 180);
            this.labelEName.Name = "labelEName";
            this.labelEName.Size = new System.Drawing.Size(149, 18);
            this.labelEName.TabIndex = 25;
            this.labelEName.Text = "Employee Name";
            // 
            // textBoxSrcE
            // 
            this.textBoxSrcE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrcE.Location = new System.Drawing.Point(262, 95);
            this.textBoxSrcE.Name = "textBoxSrcE";
            this.textBoxSrcE.Size = new System.Drawing.Size(276, 27);
            this.textBoxSrcE.TabIndex = 24;
            // 
            // labelSrcE
            // 
            this.labelSrcE.AutoSize = true;
            this.labelSrcE.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcE.Location = new System.Drawing.Point(97, 98);
            this.labelSrcE.Name = "labelSrcE";
            this.labelSrcE.Size = new System.Drawing.Size(159, 18);
            this.labelSrcE.TabIndex = 23;
            this.labelSrcE.Text = "Search Employee";
            // 
            // buttonSrcE
            // 
            this.buttonSrcE.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSrcE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrcE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSrcE.Location = new System.Drawing.Point(463, 128);
            this.buttonSrcE.Name = "buttonSrcE";
            this.buttonSrcE.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcE.TabIndex = 42;
            this.buttonSrcE.Text = "Search";
            this.buttonSrcE.UseVisualStyleBackColor = false;
            this.buttonSrcE.Click += new System.EventHandler(this.buttonSrcE_Click);
            // 
            // textBoxEOTP
            // 
            this.textBoxEOTP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEOTP.Location = new System.Drawing.Point(291, 243);
            this.textBoxEOTP.Name = "textBoxEOTP";
            this.textBoxEOTP.Size = new System.Drawing.Size(276, 27);
            this.textBoxEOTP.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Employee OTP";
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.textBoxEOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSrcE);
            this.Controls.Add(this.buttonDeleteE);
            this.Controls.Add(this.buttonAddE);
            this.Controls.Add(this.buttonUpdateE);
            this.Controls.Add(this.textBoxEUName);
            this.Controls.Add(this.labelEUName);
            this.Controls.Add(this.textBoxEName);
            this.Controls.Add(this.labelEName);
            this.Controls.Add(this.textBoxSrcE);
            this.Controls.Add(this.labelSrcE);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "EmployeeManagementForm";
            this.Text = "EmployeeManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDeleteE;
        private System.Windows.Forms.Button buttonAddE;
        private System.Windows.Forms.Button buttonUpdateE;
        private System.Windows.Forms.TextBox textBoxEUName;
        private System.Windows.Forms.Label labelEUName;
        private System.Windows.Forms.TextBox textBoxEName;
        private System.Windows.Forms.Label labelEName;
        private System.Windows.Forms.TextBox textBoxSrcE;
        private System.Windows.Forms.Label labelSrcE;
        private System.Windows.Forms.Button buttonSrcE;
        private System.Windows.Forms.TextBox textBoxEOTP;
        private System.Windows.Forms.Label label1;
    }
}