namespace Farm_Monitor
{
    partial class frmNew_Animal
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTagCode = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.cmbKraal = new System.Windows.Forms.ComboBox();
            this.btnAddType = new System.Windows.Forms.Button();
            this.btnAddSpecies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1075, 355);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 110);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Code:";
            // 
            // txtTagCode
            // 
            this.txtTagCode.Location = new System.Drawing.Point(288, 45);
            this.txtTagCode.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(345, 38);
            this.txtTagCode.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(288, 112);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(345, 38);
            this.txtWeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight:";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(869, 241);
            this.cmbSpecies.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(316, 39);
            this.cmbSpecies.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animal Type:";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(288, 241);
            this.cmbAnimalType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(316, 39);
            this.cmbAnimalType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kraal:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(40, 355);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(200, 110);
            this.btnAddAnimal.TabIndex = 13;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // cmbKraal
            // 
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(288, 176);
            this.cmbKraal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(316, 39);
            this.cmbKraal.TabIndex = 14;
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(325, 355);
            this.btnAddType.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(323, 55);
            this.btnAddType.TabIndex = 15;
            this.btnAddType.Text = "Add Animal Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // btnAddSpecies
            // 
            this.btnAddSpecies.Location = new System.Drawing.Point(688, 355);
            this.btnAddSpecies.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnAddSpecies.Name = "btnAddSpecies";
            this.btnAddSpecies.Size = new System.Drawing.Size(323, 55);
            this.btnAddSpecies.TabIndex = 16;
            this.btnAddSpecies.Text = "Add Species";
            this.btnAddSpecies.UseVisualStyleBackColor = true;
            this.btnAddSpecies.Click += new System.EventHandler(this.BtnAddSpecies_Click);
            // 
            // frmNew_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 494);
            this.Controls.Add(this.btnAddSpecies);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.cmbKraal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTagCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmNew_Animal";
            this.Text = "Add New Animal";
            this.Load += new System.EventHandler(this.frmNew_Animal_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTagCode;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ComboBox cmbKraal;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Button btnAddSpecies;
    }
}