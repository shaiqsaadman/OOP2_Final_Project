namespace MarketManagement.Views
{
    partial class ProductManagementForm
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
            this.buttonDeleteP = new System.Windows.Forms.Button();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.buttonUpdateP = new System.Windows.Forms.Button();
            this.textBoxPType = new System.Windows.Forms.TextBox();
            this.labelPType = new System.Windows.Forms.Label();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.labelPName = new System.Windows.Forms.Label();
            this.textBoxSrcP = new System.Windows.Forms.TextBox();
            this.labelSrcP = new System.Windows.Forms.Label();
            this.buttonSrcP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeleteP
            // 
            this.buttonDeleteP.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeleteP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDeleteP.Location = new System.Drawing.Point(345, 320);
            this.buttonDeleteP.Name = "buttonDeleteP";
            this.buttonDeleteP.Size = new System.Drawing.Size(182, 34);
            this.buttonDeleteP.TabIndex = 40;
            this.buttonDeleteP.Text = "Delete Product";
            this.buttonDeleteP.UseVisualStyleBackColor = false;
            this.buttonDeleteP.Click += new System.EventHandler(this.buttonDeleteP_Click);
            // 
            // buttonAddP
            // 
            this.buttonAddP.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddP.Location = new System.Drawing.Point(345, 240);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(182, 34);
            this.buttonAddP.TabIndex = 39;
            this.buttonAddP.Text = "Add Product";
            this.buttonAddP.UseVisualStyleBackColor = false;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // buttonUpdateP
            // 
            this.buttonUpdateP.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateP.Location = new System.Drawing.Point(345, 280);
            this.buttonUpdateP.Name = "buttonUpdateP";
            this.buttonUpdateP.Size = new System.Drawing.Size(182, 34);
            this.buttonUpdateP.TabIndex = 38;
            this.buttonUpdateP.Text = "Update Product";
            this.buttonUpdateP.UseVisualStyleBackColor = false;
            this.buttonUpdateP.Click += new System.EventHandler(this.buttonUpdateP_Click);
            // 
            // textBoxPType
            // 
            this.textBoxPType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPType.Location = new System.Drawing.Point(345, 207);
            this.textBoxPType.Name = "textBoxPType";
            this.textBoxPType.Size = new System.Drawing.Size(276, 27);
            this.textBoxPType.TabIndex = 37;
            // 
            // labelPType
            // 
            this.labelPType.AutoSize = true;
            this.labelPType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPType.Location = new System.Drawing.Point(180, 210);
            this.labelPType.Name = "labelPType";
            this.labelPType.Size = new System.Drawing.Size(126, 18);
            this.labelPType.TabIndex = 36;
            this.labelPType.Text = "Product Type";
            // 
            // textBoxPName
            // 
            this.textBoxPName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPName.Location = new System.Drawing.Point(345, 174);
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.Size = new System.Drawing.Size(276, 27);
            this.textBoxPName.TabIndex = 35;
            // 
            // labelPName
            // 
            this.labelPName.AutoSize = true;
            this.labelPName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPName.Location = new System.Drawing.Point(180, 177);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(133, 18);
            this.labelPName.TabIndex = 34;
            this.labelPName.Text = "Product Name";
            // 
            // textBoxSrcP
            // 
            this.textBoxSrcP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrcP.Location = new System.Drawing.Point(345, 90);
            this.textBoxSrcP.Name = "textBoxSrcP";
            this.textBoxSrcP.Size = new System.Drawing.Size(276, 27);
            this.textBoxSrcP.TabIndex = 33;
            // 
            // labelSrcP
            // 
            this.labelSrcP.AutoSize = true;
            this.labelSrcP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcP.Location = new System.Drawing.Point(180, 93);
            this.labelSrcP.Name = "labelSrcP";
            this.labelSrcP.Size = new System.Drawing.Size(143, 18);
            this.labelSrcP.TabIndex = 32;
            this.labelSrcP.Text = "Search Product";
            // 
            // buttonSrcP
            // 
            this.buttonSrcP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSrcP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrcP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSrcP.Location = new System.Drawing.Point(546, 123);
            this.buttonSrcP.Name = "buttonSrcP";
            this.buttonSrcP.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcP.TabIndex = 43;
            this.buttonSrcP.Text = "Search";
            this.buttonSrcP.UseVisualStyleBackColor = false;
            this.buttonSrcP.Click += new System.EventHandler(this.buttonSrcP_Click);
            // 
            // ProductManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSrcP);
            this.Controls.Add(this.buttonDeleteP);
            this.Controls.Add(this.buttonAddP);
            this.Controls.Add(this.buttonUpdateP);
            this.Controls.Add(this.textBoxPType);
            this.Controls.Add(this.labelPType);
            this.Controls.Add(this.textBoxPName);
            this.Controls.Add(this.labelPName);
            this.Controls.Add(this.textBoxSrcP);
            this.Controls.Add(this.labelSrcP);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ProductManagementForm";
            this.Text = "ProductManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteP;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.Button buttonUpdateP;
        private System.Windows.Forms.TextBox textBoxPType;
        private System.Windows.Forms.Label labelPType;
        private System.Windows.Forms.TextBox textBoxPName;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.TextBox textBoxSrcP;
        private System.Windows.Forms.Label labelSrcP;
        private System.Windows.Forms.Button buttonSrcP;
    }
}