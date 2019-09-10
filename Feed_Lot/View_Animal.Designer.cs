namespace Farm_Monitor
{
    partial class frmView_Animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView_Animal));
            this.gridViewAnimals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGains = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtInitialWeight = new System.Windows.Forms.TextBox();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.txtWeightGain = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.cmbAnimal_Type = new System.Windows.Forms.ComboBox();
            this.cmbKraal = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCalendar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAnimals
            // 
            this.gridViewAnimals.BackgroundColor = System.Drawing.Color.Silver;
            this.gridViewAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAnimals.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridViewAnimals.Location = new System.Drawing.Point(0, 0);
            this.gridViewAnimals.Name = "gridViewAnimals";
            this.gridViewAnimals.RowHeadersVisible = false;
            this.gridViewAnimals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewAnimals.Size = new System.Drawing.Size(80, 423);
            this.gridViewAnimals.TabIndex = 1;
            this.gridViewAnimals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAnimals_CellContentClick);
            this.gridViewAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAnimals_CellContentClick);
            this.gridViewAnimals.MouseEnter += new System.EventHandler(this.GridViewAnimals_MouseHover);
            this.gridViewAnimals.MouseLeave += new System.EventHandler(this.GridViewAnimals_MouseLeave);
            this.gridViewAnimals.MouseHover += new System.EventHandler(this.GridViewAnimals_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(126, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(126, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kraal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(126, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Animal Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(126, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Species:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(126, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "Arrival Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(126, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departure Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(126, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "Initail Weight: ";
            // 
            // lblGains
            // 
            this.lblGains.AutoSize = true;
            this.lblGains.BackColor = System.Drawing.Color.Transparent;
            this.lblGains.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGains.ForeColor = System.Drawing.Color.Silver;
            this.lblGains.Location = new System.Drawing.Point(126, 286);
            this.lblGains.Name = "lblGains";
            this.lblGains.Size = new System.Drawing.Size(94, 14);
            this.lblGains.TabIndex = 10;
            this.lblGains.Text = "Weight Gained:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(126, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(126, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 14);
            this.label10.TabIndex = 12;
            this.label10.Text = "Current Weight:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(137, 354);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 46);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtTag
            // 
            this.txtTag.BackColor = System.Drawing.Color.Silver;
            this.txtTag.Enabled = false;
            this.txtTag.Location = new System.Drawing.Point(241, 75);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(114, 20);
            this.txtTag.TabIndex = 14;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.BackColor = System.Drawing.Color.Silver;
            this.txtArrivalDate.Enabled = false;
            this.txtArrivalDate.Location = new System.Drawing.Point(241, 205);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(114, 20);
            this.txtArrivalDate.TabIndex = 19;
            // 
            // txtInitialWeight
            // 
            this.txtInitialWeight.BackColor = System.Drawing.Color.Silver;
            this.txtInitialWeight.Enabled = false;
            this.txtInitialWeight.Location = new System.Drawing.Point(241, 231);
            this.txtInitialWeight.Name = "txtInitialWeight";
            this.txtInitialWeight.Size = new System.Drawing.Size(114, 20);
            this.txtInitialWeight.TabIndex = 20;
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.BackColor = System.Drawing.Color.Silver;
            this.txtCurrentWeight.Enabled = false;
            this.txtCurrentWeight.Location = new System.Drawing.Point(241, 257);
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(114, 20);
            this.txtCurrentWeight.TabIndex = 21;
            // 
            // txtWeightGain
            // 
            this.txtWeightGain.BackColor = System.Drawing.Color.Silver;
            this.txtWeightGain.Enabled = false;
            this.txtWeightGain.Location = new System.Drawing.Point(241, 283);
            this.txtWeightGain.Name = "txtWeightGain";
            this.txtWeightGain.Size = new System.Drawing.Size(114, 20);
            this.txtWeightGain.TabIndex = 22;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.BackColor = System.Drawing.Color.Silver;
            this.txtDepartureDate.Enabled = false;
            this.txtDepartureDate.Location = new System.Drawing.Point(241, 309);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(114, 20);
            this.txtDepartureDate.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(218, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(84, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 14);
            this.label11.TabIndex = 25;
            this.label11.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(137, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirmEdit.Enabled = false;
            this.btnConfirmEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEdit.ForeColor = System.Drawing.Color.Green;
            this.btnConfirmEdit.Location = new System.Drawing.Point(137, 354);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(156, 46);
            this.btnConfirmEdit.TabIndex = 8;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = false;
            this.btnConfirmEdit.Visible = false;
            this.btnConfirmEdit.Click += new System.EventHandler(this.BtnConfirmEdit_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Location = new System.Drawing.Point(300, 354);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(50, 46);
            this.btnCancelEdit.TabIndex = 9;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbAnimal_Type
            // 
            this.cmbAnimal_Type.BackColor = System.Drawing.Color.Silver;
            this.cmbAnimal_Type.Enabled = false;
            this.cmbAnimal_Type.FormattingEnabled = true;
            this.cmbAnimal_Type.Location = new System.Drawing.Point(241, 101);
            this.cmbAnimal_Type.Name = "cmbAnimal_Type";
            this.cmbAnimal_Type.Size = new System.Drawing.Size(114, 21);
            this.cmbAnimal_Type.TabIndex = 3;
            // 
            // cmbKraal
            // 
            this.cmbKraal.BackColor = System.Drawing.Color.Silver;
            this.cmbKraal.Enabled = false;
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(241, 179);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(114, 21);
            this.cmbKraal.TabIndex = 6;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Silver;
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(241, 153);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(114, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.BackColor = System.Drawing.Color.Silver;
            this.cmbSpecies.Enabled = false;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(241, 127);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(114, 21);
            this.cmbSpecies.TabIndex = 4;
            this.cmbSpecies.SelectedIndexChanged += new System.EventHandler(this.CmbSpecies_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(128, 141);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1_DateSelected);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Silver;
            this.btnCalendar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalendar.BackgroundImage")));
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalendar.Enabled = false;
            this.btnCalendar.Location = new System.Drawing.Point(361, 306);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(39, 34);
            this.btnCalendar.TabIndex = 26;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.BtnCalendar_Click);
            // 
            // frmView_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 423);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGains);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbKraal);
            this.Controls.Add(this.cmbAnimal_Type);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtWeightGain);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.txtInitialWeight);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.gridViewAnimals);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConfirmEdit);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmView_Animal";
            this.Text = "View Animal Details";
            this.Load += new System.EventHandler(this.FrmView_Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridViewAnimals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGains;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.TextBox txtInitialWeight;
        private System.Windows.Forms.TextBox txtCurrentWeight;
        private System.Windows.Forms.TextBox txtWeightGain;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAnimal_ID;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.ComboBox cmbAnimal_Type;
        private System.Windows.Forms.ComboBox cmbKraal;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}
           /*
            */
