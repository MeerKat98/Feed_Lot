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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNew_Animal));
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
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidAnimalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInvalidSpecies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag Code:";
            // 
            // txtTagCode
            // 
            this.txtTagCode.BackColor = System.Drawing.Color.Silver;
            this.txtTagCode.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTagCode.Location = new System.Drawing.Point(108, 19);
            this.txtTagCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(132, 22);
            this.txtTagCode.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Silver;
            this.txtWeight.Location = new System.Drawing.Point(108, 47);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(132, 20);
            this.txtWeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight:";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.BackColor = System.Drawing.Color.Silver;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(326, 101);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 21);
            this.cmbSpecies.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(272, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Animal Type:";
            // 
            // cmbAnimalType
            // 
            this.cmbAnimalType.BackColor = System.Drawing.Color.Silver;
            this.cmbAnimalType.FormattingEnabled = true;
            this.cmbAnimalType.Location = new System.Drawing.Point(108, 101);
            this.cmbAnimalType.Name = "cmbAnimalType";
            this.cmbAnimalType.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimalType.TabIndex = 10;
            this.cmbAnimalType.SelectedIndexChanged += new System.EventHandler(this.CmbAnimalType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(23, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kraal:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.Silver;
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAnimal.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(15, 149);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 46);
            this.btnAddAnimal.TabIndex = 13;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // cmbKraal
            // 
            this.cmbKraal.BackColor = System.Drawing.Color.Silver;
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(108, 74);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(121, 21);
            this.cmbKraal.TabIndex = 14;
            this.cmbKraal.SelectedIndexChanged += new System.EventHandler(this.CmbKraal_SelectedIndexChanged);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.Silver;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddType.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(122, 149);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(121, 23);
            this.btnAddType.TabIndex = 15;
            this.btnAddType.Text = "Add Animal Type";
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.BtnAddType_Click);
            // 
            // btnAddSpecies
            // 
            this.btnAddSpecies.BackColor = System.Drawing.Color.Silver;
            this.btnAddSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSpecies.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpecies.Location = new System.Drawing.Point(258, 149);
            this.btnAddSpecies.Name = "btnAddSpecies";
            this.btnAddSpecies.Size = new System.Drawing.Size(121, 23);
            this.btnAddSpecies.TabIndex = 16;
            this.btnAddSpecies.Text = "Add Species";
            this.btnAddSpecies.UseVisualStyleBackColor = false;
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
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(403, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = " Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // frmNew_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnClose;
    }
}