namespace MarketManagement.Views
{
    partial class ShopManagementForm
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
            this.dataGridViewSManage = new System.Windows.Forms.DataGridView();
            this.buttonSInventory = new System.Windows.Forms.Button();
            this.buttonSAddRep = new System.Windows.Forms.Button();
            this.buttonDeleteS = new System.Windows.Forms.Button();
            this.buttonAddS = new System.Windows.Forms.Button();
            this.buttonUpdateS = new System.Windows.Forms.Button();
            this.textBoxSType = new System.Windows.Forms.TextBox();
            this.labelSType = new System.Windows.Forms.Label();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.labelSName = new System.Windows.Forms.Label();
            this.textBoxSrcS = new System.Windows.Forms.TextBox();
            this.labelSrcS = new System.Windows.Forms.Label();
            this.buttonSrcS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSManage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSManage
            // 
            this.dataGridViewSManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSManage.Location = new System.Drawing.Point(491, 59);
            this.dataGridViewSManage.Name = "dataGridViewSManage";
            this.dataGridViewSManage.Size = new System.Drawing.Size(249, 349);
            this.dataGridViewSManage.TabIndex = 23;
            // 
            // buttonSInventory
            // 
            this.buttonSInventory.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSInventory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSInventory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSInventory.Location = new System.Drawing.Point(188, 374);
            this.buttonSInventory.Name = "buttonSInventory";
            this.buttonSInventory.Size = new System.Drawing.Size(276, 34);
            this.buttonSInventory.TabIndex = 22;
            this.buttonSInventory.Text = "Shop Inventory";
            this.buttonSInventory.UseVisualStyleBackColor = false;
            // 
            // buttonSAddRep
            // 
            this.buttonSAddRep.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSAddRep.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSAddRep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSAddRep.Location = new System.Drawing.Point(188, 334);
            this.buttonSAddRep.Name = "buttonSAddRep";
            this.buttonSAddRep.Size = new System.Drawing.Size(276, 34);
            this.buttonSAddRep.TabIndex = 21;
            this.buttonSAddRep.Text = "Monthly Shop Added Report";
            this.buttonSAddRep.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteS
            // 
            this.buttonDeleteS.BackColor = System.Drawing.Color.Tomato;
            this.buttonDeleteS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDeleteS.Location = new System.Drawing.Point(188, 294);
            this.buttonDeleteS.Name = "buttonDeleteS";
            this.buttonDeleteS.Size = new System.Drawing.Size(133, 34);
            this.buttonDeleteS.TabIndex = 20;
            this.buttonDeleteS.Text = "Delete Shop";
            this.buttonDeleteS.UseVisualStyleBackColor = false;
            this.buttonDeleteS.Click += new System.EventHandler(this.buttonDeleteS_Click);
            // 
            // buttonAddS
            // 
            this.buttonAddS.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddS.Location = new System.Drawing.Point(188, 214);
            this.buttonAddS.Name = "buttonAddS";
            this.buttonAddS.Size = new System.Drawing.Size(133, 34);
            this.buttonAddS.TabIndex = 19;
            this.buttonAddS.Text = "Add Shop";
            this.buttonAddS.UseVisualStyleBackColor = false;
            this.buttonAddS.Click += new System.EventHandler(this.buttonAddS_Click);
            // 
            // buttonUpdateS
            // 
            this.buttonUpdateS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdateS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateS.Location = new System.Drawing.Point(188, 254);
            this.buttonUpdateS.Name = "buttonUpdateS";
            this.buttonUpdateS.Size = new System.Drawing.Size(133, 34);
            this.buttonUpdateS.TabIndex = 18;
            this.buttonUpdateS.Text = "Update Shop";
            this.buttonUpdateS.UseVisualStyleBackColor = false;
            this.buttonUpdateS.Click += new System.EventHandler(this.buttonUpdateS_Click);
            // 
            // textBoxSType
            // 
            this.textBoxSType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSType.Location = new System.Drawing.Point(188, 181);
            this.textBoxSType.Name = "textBoxSType";
            this.textBoxSType.Size = new System.Drawing.Size(276, 27);
            this.textBoxSType.TabIndex = 17;
            // 
            // labelSType
            // 
            this.labelSType.AutoSize = true;
            this.labelSType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSType.Location = new System.Drawing.Point(49, 184);
            this.labelSType.Name = "labelSType";
            this.labelSType.Size = new System.Drawing.Size(101, 18);
            this.labelSType.TabIndex = 16;
            this.labelSType.Text = "Shop Type";
            // 
            // textBoxSName
            // 
            this.textBoxSName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSName.Location = new System.Drawing.Point(188, 148);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(276, 27);
            this.textBoxSName.TabIndex = 15;
            // 
            // labelSName
            // 
            this.labelSName.AutoSize = true;
            this.labelSName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSName.Location = new System.Drawing.Point(49, 151);
            this.labelSName.Name = "labelSName";
            this.labelSName.Size = new System.Drawing.Size(108, 18);
            this.labelSName.TabIndex = 14;
            this.labelSName.Text = "Shop Name";
            // 
            // textBoxSrcS
            // 
            this.textBoxSrcS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrcS.Location = new System.Drawing.Point(188, 59);
            this.textBoxSrcS.Name = "textBoxSrcS";
            this.textBoxSrcS.Size = new System.Drawing.Size(276, 27);
            this.textBoxSrcS.TabIndex = 13;
            // 
            // labelSrcS
            // 
            this.labelSrcS.AutoSize = true;
            this.labelSrcS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSrcS.Location = new System.Drawing.Point(49, 62);
            this.labelSrcS.Name = "labelSrcS";
            this.labelSrcS.Size = new System.Drawing.Size(118, 18);
            this.labelSrcS.TabIndex = 12;
            this.labelSrcS.Text = "Search Shop";
            // 
            // buttonSrcS
            // 
            this.buttonSrcS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSrcS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrcS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSrcS.Location = new System.Drawing.Point(389, 92);
            this.buttonSrcS.Name = "buttonSrcS";
            this.buttonSrcS.Size = new System.Drawing.Size(75, 23);
            this.buttonSrcS.TabIndex = 42;
            this.buttonSrcS.Text = "Search";
            this.buttonSrcS.UseVisualStyleBackColor = false;
            this.buttonSrcS.Click += new System.EventHandler(this.buttonSrcS_Click);
            // 
            // ShopManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSrcS);
            this.Controls.Add(this.dataGridViewSManage);
            this.Controls.Add(this.buttonSInventory);
            this.Controls.Add(this.buttonSAddRep);
            this.Controls.Add(this.buttonDeleteS);
            this.Controls.Add(this.buttonAddS);
            this.Controls.Add(this.buttonUpdateS);
            this.Controls.Add(this.textBoxSType);
            this.Controls.Add(this.labelSType);
            this.Controls.Add(this.textBoxSName);
            this.Controls.Add(this.labelSName);
            this.Controls.Add(this.textBoxSrcS);
            this.Controls.Add(this.labelSrcS);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "ShopManagementForm";
            this.Text = "ShopManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSManage;
        private System.Windows.Forms.Button buttonSInventory;
        private System.Windows.Forms.Button buttonSAddRep;
        private System.Windows.Forms.Button buttonDeleteS;
        private System.Windows.Forms.Button buttonAddS;
        private System.Windows.Forms.Button buttonUpdateS;
        private System.Windows.Forms.TextBox textBoxSType;
        private System.Windows.Forms.Label labelSType;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label labelSName;
        private System.Windows.Forms.TextBox textBoxSrcS;
        private System.Windows.Forms.Label labelSrcS;
        private System.Windows.Forms.Button buttonSrcS;
    }
}