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
            this.btnClose = new System.Windows.Forms.Button();
            this.gridViewAnimals = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtKraal = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtInitialWeight = new System.Windows.Forms.TextBox();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.txtWeightGain = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(441, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // gridViewAnimals
            // 
            this.gridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAnimals.Location = new System.Drawing.Point(12, 66);
            this.gridViewAnimals.Name = "gridViewAnimals";
            this.gridViewAnimals.Size = new System.Drawing.Size(234, 323);
            this.gridViewAnimals.TabIndex = 2;
            this.gridViewAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAnimals_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kraal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Animal Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Species:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Arrival Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departure Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Initail Weight: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Weight Gained:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Current Weight:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(279, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 46);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(402, 67);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(114, 20);
            this.txtTag.TabIndex = 14;
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.Location = new System.Drawing.Point(402, 93);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(114, 20);
            this.txtAnimalType.TabIndex = 15;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(402, 119);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(114, 20);
            this.txtSpecies.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(402, 145);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(114, 20);
            this.txtStatus.TabIndex = 17;
            // 
            // txtKraal
            // 
            this.txtKraal.Location = new System.Drawing.Point(402, 171);
            this.txtKraal.Name = "txtKraal";
            this.txtKraal.Size = new System.Drawing.Size(114, 20);
            this.txtKraal.TabIndex = 18;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(402, 197);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(114, 20);
            this.txtArrivalDate.TabIndex = 19;
            // 
            // txtInitialWeight
            // 
            this.txtInitialWeight.Location = new System.Drawing.Point(402, 223);
            this.txtInitialWeight.Name = "txtInitialWeight";
            this.txtInitialWeight.Size = new System.Drawing.Size(114, 20);
            this.txtInitialWeight.TabIndex = 20;
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.Location = new System.Drawing.Point(402, 249);
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(114, 20);
            this.txtCurrentWeight.TabIndex = 21;
            // 
            // txtWeightGain
            // 
            this.txtWeightGain.Location = new System.Drawing.Point(402, 275);
            this.txtWeightGain.Name = "txtWeightGain";
            this.txtWeightGain.Size = new System.Drawing.Size(114, 20);
            this.txtWeightGain.TabIndex = 22;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(402, 301);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(114, 20);
            this.txtDepartureDate.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(78, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // frmView_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 411);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtWeightGain);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.txtInitialWeight);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtKraal);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtAnimalType);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridViewAnimals);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.TextBox txtAnimalType;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtKraal;
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
    }
}
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
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtKraal = new System.Windows.Forms.TextBox();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.txtInitialWeight = new System.Windows.Forms.TextBox();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.txtWeightGain = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAnimals
            // 
            this.gridViewAnimals.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridViewAnimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAnimals.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridViewAnimals.Location = new System.Drawing.Point(0, 0);
            this.gridViewAnimals.Name = "gridViewAnimals";
            this.gridViewAnimals.RowHeadersVisible = false;
            this.gridViewAnimals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewAnimals.Size = new System.Drawing.Size(80, 418);
            this.gridViewAnimals.TabIndex = 2;
            this.gridViewAnimals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAnimals_CellContentClick);
            this.gridViewAnimals.MouseEnter += new System.EventHandler(this.GridViewAnimals_MouseHover);
            this.gridViewAnimals.MouseLeave += new System.EventHandler(this.GridViewAnimals_MouseLeave);
            this.gridViewAnimals.MouseHover += new System.EventHandler(this.GridViewAnimals_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tag: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kraal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Animal Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Species:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Arrival Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Departure Date: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Initail Weight: ";
            // 
            // lblGains
            // 
            this.lblGains.AutoSize = true;
            this.lblGains.Location = new System.Drawing.Point(126, 286);
            this.lblGains.Name = "lblGains";
            this.lblGains.Size = new System.Drawing.Size(81, 13);
            this.lblGains.TabIndex = 10;
            this.lblGains.Text = "Weight Gained:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Current Weight:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(160, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtTag
            // 
            this.txtTag.Enabled = false;
            this.txtTag.Location = new System.Drawing.Point(241, 75);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(114, 20);
            this.txtTag.TabIndex = 14;
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.Location = new System.Drawing.Point(241, 101);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(114, 20);
            this.txtAnimalType.TabIndex = 15;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(241, 127);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(114, 20);
            this.txtSpecies.TabIndex = 16;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(241, 153);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(114, 20);
            this.txtStatus.TabIndex = 17;
            // 
            // txtKraal
            // 
            this.txtKraal.Location = new System.Drawing.Point(241, 179);
            this.txtKraal.Name = "txtKraal";
            this.txtKraal.Size = new System.Drawing.Size(114, 20);
            this.txtKraal.TabIndex = 18;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Enabled = false;
            this.txtArrivalDate.Location = new System.Drawing.Point(241, 205);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(114, 20);
            this.txtArrivalDate.TabIndex = 19;
            // 
            // txtInitialWeight
            // 
            this.txtInitialWeight.Enabled = false;
            this.txtInitialWeight.Location = new System.Drawing.Point(241, 231);
            this.txtInitialWeight.Name = "txtInitialWeight";
            this.txtInitialWeight.Size = new System.Drawing.Size(114, 20);
            this.txtInitialWeight.TabIndex = 20;
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.Enabled = false;
            this.txtCurrentWeight.Location = new System.Drawing.Point(241, 257);
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(114, 20);
            this.txtCurrentWeight.TabIndex = 21;
            // 
            // txtWeightGain
            // 
            this.txtWeightGain.Enabled = false;
            this.txtWeightGain.Location = new System.Drawing.Point(241, 283);
            this.txtWeightGain.Name = "txtWeightGain";
            this.txtWeightGain.Size = new System.Drawing.Size(114, 20);
            this.txtWeightGain.TabIndex = 22;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(241, 309);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(114, 20);
            this.txtDepartureDate.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(241, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(137, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // frmView_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 418);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtWeightGain);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.txtInitialWeight);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtKraal);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtAnimalType);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnEdit);
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
            this.Controls.Add(this.gridViewAnimals);
            this.Name = "frmView_Animal";
            this.ShowIcon = false;
            this.Text = "View Animal Details";
            this.Load += new System.EventHandler(this.FrmView_Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
