namespace MarketManagement.Views
{
    partial class CustomerForm
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
            this.textBoxSrcSName = new System.Windows.Forms.TextBox();
            this.labelSrcSName = new System.Windows.Forms.Label();
            this.buttonSrcSName = new System.Windows.Forms.Button();
            this.RTBCForm = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxSrcSName
            // 
            this.textBoxSrcSName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrcSName.Location = new System.Drawing.Point(280, 192);
            this.textBoxSrcSName.Name = "textBoxSrcSName";
            this.textBoxSrcSName.Size = new System.Drawing.Size(250, 27);
            this.textBoxSrcSName.TabIndex = 37;
            // 
            // labelSrcSName
            // 
            this.labelSrcSName.AutoSize = true;
            this.labelSrcSName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcSName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSrcSName.Location = new System.Drawing.Point(60, 195);
            this.labelSrcSName.Name = "labelSrcSName";
            this.labelSrcSName.Size = new System.Drawing.Size(201, 18);
            this.labelSrcSName.TabIndex = 36;
            this.labelSrcSName.Text = "Search Shop By Name";
            // 
            // buttonSrcSName
            // 
            this.buttonSrcSName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSrcSName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrcSName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSrcSName.Location = new System.Drawing.Point(455, 225);
            this.buttonSrcSName.Name = "buttonSrcSName";
            this.buttonSrcSName.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcSName.TabIndex = 41;
            this.buttonSrcSName.Text = "Search";
            this.buttonSrcSName.UseVisualStyleBackColor = false;
            this.buttonSrcSName.Click += new System.EventHandler(this.buttonSrcSName_Click);
            // 
            // RTBCForm
            // 
            this.RTBCForm.Location = new System.Drawing.Point(577, 132);
            this.RTBCForm.Name = "RTBCForm";
            this.RTBCForm.Size = new System.Drawing.Size(193, 190);
            this.RTBCForm.TabIndex = 43;
            this.RTBCForm.Text = "";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RTBCForm);
            this.Controls.Add(this.buttonSrcSName);
            this.Controls.Add(this.textBoxSrcSName);
            this.Controls.Add(this.labelSrcSName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSrcSName;
        private System.Windows.Forms.Label labelSrcSName;
        private System.Windows.Forms.Button buttonSrcSName;
        private System.Windows.Forms.RichTextBox RTBCForm;
    }
}