﻿namespace Software1
{
    partial class AddPart
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
            this.AddPartBox = new System.Windows.Forms.GroupBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.EnterMin = new System.Windows.Forms.TextBox();
            this.EnterMax = new System.Windows.Forms.TextBox();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MachineLabel = new System.Windows.Forms.Label();
            this.EnterMachID = new System.Windows.Forms.TextBox();
            this.EnterPrice = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.EnterInv = new System.Windows.Forms.TextBox();
            this.InvLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EnterPartName = new System.Windows.Forms.TextBox();
            this.OutsourcedRD = new System.Windows.Forms.RadioButton();
            this.InHouseRD = new System.Windows.Forms.RadioButton();
            this.ROPartID = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.AddPartBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPartBox
            // 
            this.AddPartBox.Controls.Add(this.ROPartID);
            this.AddPartBox.Controls.Add(this.IdLabel);
            this.AddPartBox.Controls.Add(this.ErrorLabel);
            this.AddPartBox.Controls.Add(this.Save);
            this.AddPartBox.Controls.Add(this.Cancel);
            this.AddPartBox.Controls.Add(this.EnterMin);
            this.AddPartBox.Controls.Add(this.EnterMax);
            this.AddPartBox.Controls.Add(this.MinLabel);
            this.AddPartBox.Controls.Add(this.MaxLabel);
            this.AddPartBox.Controls.Add(this.MachineLabel);
            this.AddPartBox.Controls.Add(this.EnterMachID);
            this.AddPartBox.Controls.Add(this.EnterPrice);
            this.AddPartBox.Controls.Add(this.PriceLabel);
            this.AddPartBox.Controls.Add(this.EnterInv);
            this.AddPartBox.Controls.Add(this.InvLabel);
            this.AddPartBox.Controls.Add(this.NameLabel);
            this.AddPartBox.Controls.Add(this.EnterPartName);
            this.AddPartBox.Controls.Add(this.OutsourcedRD);
            this.AddPartBox.Controls.Add(this.InHouseRD);
            this.AddPartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartBox.Location = new System.Drawing.Point(12, 12);
            this.AddPartBox.Name = "AddPartBox";
            this.AddPartBox.Size = new System.Drawing.Size(469, 426);
            this.AddPartBox.TabIndex = 0;
            this.AddPartBox.TabStop = false;
            this.AddPartBox.Text = "Add Part";
            this.AddPartBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorLabel.Location = new System.Drawing.Point(9, 270);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 16;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(263, 373);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 15;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(373, 373);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EnterMin
            // 
            this.EnterMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMin.Location = new System.Drawing.Point(276, 248);
            this.EnterMin.Name = "EnterMin";
            this.EnterMin.Size = new System.Drawing.Size(85, 20);
            this.EnterMin.TabIndex = 13;
            this.EnterMin.Text = "Min";
            // 
            // EnterMax
            // 
            this.EnterMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMax.Location = new System.Drawing.Point(130, 248);
            this.EnterMax.Name = "EnterMax";
            this.EnterMax.Size = new System.Drawing.Size(85, 20);
            this.EnterMax.TabIndex = 12;
            this.EnterMax.Text = "Max";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(233, 248);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(27, 13);
            this.MinLabel.TabIndex = 11;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.Location = new System.Drawing.Point(3, 248);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(30, 13);
            this.MaxLabel.TabIndex = 10;
            this.MaxLabel.Text = "Max";
            // 
            // MachineLabel
            // 
            this.MachineLabel.AutoSize = true;
            this.MachineLabel.Location = new System.Drawing.Point(3, 212);
            this.MachineLabel.Name = "MachineLabel";
            this.MachineLabel.Size = new System.Drawing.Size(72, 13);
            this.MachineLabel.TabIndex = 9;
            this.MachineLabel.Text = "Machine ID";
            // 
            // EnterMachID
            // 
            this.EnterMachID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMachID.Location = new System.Drawing.Point(130, 212);
            this.EnterMachID.Name = "EnterMachID";
            this.EnterMachID.Size = new System.Drawing.Size(231, 20);
            this.EnterMachID.TabIndex = 8;
            this.EnterMachID.Text = "Mach ID";
            // 
            // EnterPrice
            // 
            this.EnterPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPrice.Location = new System.Drawing.Point(130, 176);
            this.EnterPrice.Name = "EnterPrice";
            this.EnterPrice.Size = new System.Drawing.Size(231, 20);
            this.EnterPrice.TabIndex = 7;
            this.EnterPrice.Text = "Price/Cost";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(3, 176);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 13);
            this.PriceLabel.TabIndex = 6;
            this.PriceLabel.Text = "Price/Cost";
            // 
            // EnterInv
            // 
            this.EnterInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterInv.Location = new System.Drawing.Point(130, 140);
            this.EnterInv.Name = "EnterInv";
            this.EnterInv.Size = new System.Drawing.Size(231, 20);
            this.EnterInv.TabIndex = 5;
            this.EnterInv.Text = "Inventory Count";
            // 
            // InvLabel
            // 
            this.InvLabel.AutoSize = true;
            this.InvLabel.Location = new System.Drawing.Point(3, 140);
            this.InvLabel.Name = "InvLabel";
            this.InvLabel.Size = new System.Drawing.Size(60, 13);
            this.InvLabel.TabIndex = 4;
            this.InvLabel.Text = "Inventory";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 105);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // EnterPartName
            // 
            this.EnterPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterPartName.Location = new System.Drawing.Point(130, 102);
            this.EnterPartName.Name = "EnterPartName";
            this.EnterPartName.Size = new System.Drawing.Size(231, 20);
            this.EnterPartName.TabIndex = 2;
            this.EnterPartName.Text = "Part Name";
            // 
            // OutsourcedRD
            // 
            this.OutsourcedRD.AutoSize = true;
            this.OutsourcedRD.Location = new System.Drawing.Point(97, 31);
            this.OutsourcedRD.Name = "OutsourcedRD";
            this.OutsourcedRD.Size = new System.Drawing.Size(90, 17);
            this.OutsourcedRD.TabIndex = 1;
            this.OutsourcedRD.TabStop = true;
            this.OutsourcedRD.Text = "Outsourced";
            this.OutsourcedRD.UseVisualStyleBackColor = true;
            this.OutsourcedRD.CheckedChanged += new System.EventHandler(this.OutsourcedRD_CheckedChanged);
            // 
            // InHouseRD
            // 
            this.InHouseRD.AutoSize = true;
            this.InHouseRD.Location = new System.Drawing.Point(6, 31);
            this.InHouseRD.Name = "InHouseRD";
            this.InHouseRD.Size = new System.Drawing.Size(76, 17);
            this.InHouseRD.TabIndex = 0;
            this.InHouseRD.TabStop = true;
            this.InHouseRD.Text = "In-House";
            this.InHouseRD.UseVisualStyleBackColor = true;
            this.InHouseRD.CheckedChanged += new System.EventHandler(this.InHouseRD_CheckedChanged);
            // 
            // ROPartID
            // 
            this.ROPartID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROPartID.Location = new System.Drawing.Point(131, 66);
            this.ROPartID.Name = "ROPartID";
            this.ROPartID.ReadOnly = true;
            this.ROPartID.Size = new System.Drawing.Size(231, 20);
            this.ROPartID.TabIndex = 20;
            this.ROPartID.Text = "Auto Gen";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 69);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(47, 13);
            this.IdLabel.TabIndex = 19;
            this.IdLabel.Text = "Part ID";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 454);
            this.Controls.Add(this.AddPartBox);
            this.Name = "AddPart";
            this.Text = "Add Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            this.AddPartBox.ResumeLayout(false);
            this.AddPartBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddPartBox;
        private System.Windows.Forms.RadioButton OutsourcedRD;
        private System.Windows.Forms.RadioButton InHouseRD;
        private System.Windows.Forms.TextBox EnterMin;
        private System.Windows.Forms.TextBox EnterMax;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.Label MachineLabel;
        private System.Windows.Forms.TextBox EnterMachID;
        private System.Windows.Forms.TextBox EnterPrice;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox EnterInv;
        private System.Windows.Forms.Label InvLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EnterPartName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox ROPartID;
        private System.Windows.Forms.Label IdLabel;
    }
}