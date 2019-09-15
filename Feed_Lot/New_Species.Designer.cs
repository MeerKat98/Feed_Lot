namespace Farm_Monitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Species));
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnimalType = new System.Windows.Forms.ComboBox();
            this.txtSpeciesName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.Silver;
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAnimal.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(77, 90);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 46);
            this.btnAddAnimal.TabIndex = 15;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "Species Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "Animal Type:";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.BackColor = System.Drawing.Color.Silver;
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(118, 45);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalType.TabIndex = 19;
            // 
            // txtSpeciesName
            // 
            this.txtSpeciesName.BackColor = System.Drawing.Color.Silver;
            this.txtSpeciesName.Location = new System.Drawing.Point(118, 14);
            this.txtSpeciesName.Name = "txtSpeciesName";
            this.txtSpeciesName.Size = new System.Drawing.Size(121, 20);
            this.txtSpeciesName.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // New_Species
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 158);
            this.Controls.Add(this.txtSpeciesName);
            this.Controls.Add(this.cmbAnimalType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Species";
            this.Text = "New_Species";
            this.Load += new System.EventHandler(this.New_Species_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnimalType;
        private System.Windows.Forms.TextBox txtSpeciesName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}