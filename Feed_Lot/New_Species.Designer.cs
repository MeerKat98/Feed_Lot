﻿namespace Farm_Monitor
{
    partial class New_Species
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.txtSpeciesName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(32, 274);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(200, 110);
            this.btnAddAnimal.TabIndex = 15;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(499, 274);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 110);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Species Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Animal Type:";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(285, 112);
            this.cmbAnimalType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(316, 39);
            this.cmbAnimalType.TabIndex = 19;
            // 
            // txtSpeciesName
            // 
            this.txtSpeciesName.Location = new System.Drawing.Point(285, 38);
            this.txtSpeciesName.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtSpeciesName.Name = "txtSpeciesName";
            this.txtSpeciesName.Size = new System.Drawing.Size(316, 38);
            this.txtSpeciesName.TabIndex = 20;
            // 
            // New_Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 413);
            this.Controls.Add(this.txtSpeciesName);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "New_Species";
            this.Text = "New_Species";
            this.Load += new System.EventHandler(this.New_Species_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.TextBox txtSpeciesName;
    }
}