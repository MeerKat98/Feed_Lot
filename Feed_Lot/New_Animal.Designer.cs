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
            this.components = new System.ComponentModel.Container();
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
            this.errInvalidTag = new System.Windows.Forms.ErrorProvider(this.components);
            this.errInvalidWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.errInvalidAnimalType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errInvalidSpecies = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidAnimalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(403, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Code:";
            // 
            // txtTagCode
            // 
            this.txtTagCode.Location = new System.Drawing.Point(108, 19);
            this.txtTagCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(132, 20);
            this.txtTagCode.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(108, 47);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight:";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(326, 101);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecies.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animal Type:";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(108, 101);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kraal:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(15, 149);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 46);
            this.btnAddAnimal.TabIndex = 13;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // cmbKraal
            // 
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(108, 74);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(121, 21);
            this.cmbKraal.TabIndex = 14;
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(122, 149);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(121, 23);
            this.btnAddType.TabIndex = 15;
            this.btnAddType.Text = "Add Animal Type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // btnAddSpecies
            // 
            this.btnAddSpecies.Location = new System.Drawing.Point(258, 149);
            this.btnAddSpecies.Name = "btnAddSpecies";
            this.btnAddSpecies.Size = new System.Drawing.Size(121, 23);
            this.btnAddSpecies.TabIndex = 16;
            this.btnAddSpecies.Text = "Add Species";
            this.btnAddSpecies.UseVisualStyleBackColor = true;
            this.btnAddSpecies.Click += new System.EventHandler(this.BtnAddSpecies_Click);
            // 
            // errInvalidTag
            // 
            this.errInvalidTag.ContainerControl = this;
            this.errInvalidTag.Tag = "This field cannot be empty!";
            // 
            // errInvalidWeight
            // 
            this.errInvalidWeight.ContainerControl = this;
            // 
            // errInvalidAnimalType
            // 
            this.errInvalidAnimalType.ContainerControl = this;
            // 
            // errInvalidSpecies
            // 
            this.errInvalidSpecies.ContainerControl = this;
            // 
            // frmNew_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 207);
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
            this.Name = "frmNew_Animal";
            this.Text = "Add New Animal";
            this.Load += new System.EventHandler(this.FrmNew_Animal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidAnimalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidSpecies)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errInvalidTag;
        private System.Windows.Forms.ErrorProvider errInvalidWeight;
        private System.Windows.Forms.ErrorProvider errInvalidAnimalType;
        private System.Windows.Forms.ErrorProvider errInvalidSpecies;
    }
}