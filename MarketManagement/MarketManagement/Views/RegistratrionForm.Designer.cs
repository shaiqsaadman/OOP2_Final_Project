namespace MarketManagement.Views
{
    partial class RegistratrionForm
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
            this.buttonRSubmit = new System.Windows.Forms.Button();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBoxRePass = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRUsername = new System.Windows.Forms.TextBox();
            this.textBoxRName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPI = new System.Windows.Forms.Label();
            this.rTRegOutput = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCustomer = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployee = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRSubmit
            // 
            this.buttonRSubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRSubmit.Location = new System.Drawing.Point(56, 196);
            this.buttonRSubmit.Name = "buttonRSubmit";
            this.buttonRSubmit.Size = new System.Drawing.Size(133, 47);
            this.buttonRSubmit.TabIndex = 42;
            this.buttonRSubmit.Text = "Submit";
            this.buttonRSubmit.UseVisualStyleBackColor = false;
            this.buttonRSubmit.Click += new System.EventHandler(this.SubClicked);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg.Location = new System.Drawing.Point(153, 2);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(291, 33);
            this.labelReg.TabIndex = 5;
            this.labelReg.Text = "Registration Form";
            // 
            // textBoxRePass
            // 
            this.textBoxRePass.Location = new System.Drawing.Point(120, 111);
            this.textBoxRePass.Name = "textBoxRePass";
            this.textBoxRePass.Size = new System.Drawing.Size(236, 20);
            this.textBoxRePass.TabIndex = 21;
            this.textBoxRePass.UseSystemPasswordChar = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(120, 85);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(236, 20);
            this.textBoxPass.TabIndex = 20;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Re-type Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // textBoxRUsername
            // 
            this.textBoxRUsername.Location = new System.Drawing.Point(120, 59);
            this.textBoxRUsername.Name = "textBoxRUsername";
            this.textBoxRUsername.Size = new System.Drawing.Size(236, 20);
            this.textBoxRUsername.TabIndex = 4;
            // 
            // textBoxRName
            // 
            this.textBoxRName.Location = new System.Drawing.Point(120, 33);
            this.textBoxRName.Name = "textBoxRName";
            this.textBoxRName.Size = new System.Drawing.Size(236, 20);
            this.textBoxRName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonRSubmit);
            this.panel1.Controls.Add(this.textBoxRePass);
            this.panel1.Controls.Add(this.textBoxPass);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxRUsername);
            this.panel1.Controls.Add(this.textBoxRName);
            this.panel1.Controls.Add(this.labelPI);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 260);
            this.panel1.TabIndex = 6;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(209, 196);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(133, 47);
            this.buttonReset.TabIndex = 44;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.ResetClicked);
            // 
            // labelPI
            // 
            this.labelPI.AutoSize = true;
            this.labelPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPI.Location = new System.Drawing.Point(3, 0);
            this.labelPI.Name = "labelPI";
            this.labelPI.Size = new System.Drawing.Size(158, 17);
            this.labelPI.TabIndex = 2;
            this.labelPI.Text = "Personal Information";
            // 
            // rTRegOutput
            // 
            this.rTRegOutput.Location = new System.Drawing.Point(404, 103);
            this.rTRegOutput.Name = "rTRegOutput";
            this.rTRegOutput.Size = new System.Drawing.Size(198, 261);
            this.rTRegOutput.TabIndex = 7;
            this.rTRegOutput.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Rrgister as a: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCustomer);
            this.groupBox1.Controls.Add(this.radioButtonAdmin);
            this.groupBox1.Controls.Add(this.radioButtonEmployee);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(132, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 20);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonCustomer
            // 
            this.radioButtonCustomer.AutoSize = true;
            this.radioButtonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCustomer.Location = new System.Drawing.Point(177, 1);
            this.radioButtonCustomer.Name = "radioButtonCustomer";
            this.radioButtonCustomer.Size = new System.Drawing.Size(91, 20);
            this.radioButtonCustomer.TabIndex = 2;
            this.radioButtonCustomer.TabStop = true;
            this.radioButtonCustomer.Text = "Customer";
            this.radioButtonCustomer.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(0, 1);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(69, 20);
            this.radioButtonAdmin.TabIndex = 0;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEmployee.Location = new System.Drawing.Point(75, 1);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(96, 20);
            this.radioButtonEmployee.TabIndex = 1;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Employee";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            // 
            // RegistratrionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(614, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rTRegOutput);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "RegistratrionForm";
            this.Text = "RegistratrionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRSubmit;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.TextBox textBoxRePass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRUsername;
        private System.Windows.Forms.TextBox textBoxRName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPI;
        private System.Windows.Forms.RichTextBox rTRegOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCustomer;
        private System.Windows.Forms.RadioButton radioButtonEmployee;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Button buttonReset;
    }
}