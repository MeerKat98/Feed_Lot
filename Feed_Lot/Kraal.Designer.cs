namespace Farm_Monitor
{
    partial class frmKraal
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
            this.cmbKraal = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtAvgWeight = new System.Windows.Forms.TextBox();
            this.txtTotalFeed = new System.Windows.Forms.TextBox();
            this.txtAvgFeed = new System.Windows.Forms.TextBox();
            this.txtFeedType = new System.Windows.Forms.TextBox();
            this.lblKraal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(369, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // cmbKraal
            // 
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(122, 20);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(121, 21);
            this.cmbKraal.TabIndex = 2;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(134, 94);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 3;
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.Location = new System.Drawing.Point(134, 120);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalType.TabIndex = 4;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(134, 146);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 20);
            this.txtSpecies.TabIndex = 5;
            // 
            // txtAvgWeight
            // 
            this.txtAvgWeight.Location = new System.Drawing.Point(134, 198);
            this.txtAvgWeight.Name = "txtAvgWeight";
            this.txtAvgWeight.Size = new System.Drawing.Size(100, 20);
            this.txtAvgWeight.TabIndex = 6;
            // 
            // txtTotalFeed
            // 
            this.txtTotalFeed.Location = new System.Drawing.Point(134, 224);
            this.txtTotalFeed.Name = "txtTotalFeed";
            this.txtTotalFeed.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFeed.TabIndex = 7;
            // 
            // txtAvgFeed
            // 
            this.txtAvgFeed.Location = new System.Drawing.Point(134, 250);
            this.txtAvgFeed.Name = "txtAvgFeed";
            this.txtAvgFeed.Size = new System.Drawing.Size(100, 20);
            this.txtAvgFeed.TabIndex = 8;
            // 
            // txtFeedType
            // 
            this.txtFeedType.Location = new System.Drawing.Point(134, 276);
            this.txtFeedType.Name = "txtFeedType";
            this.txtFeedType.Size = new System.Drawing.Size(100, 20);
            this.txtFeedType.TabIndex = 9;
            // 
            // lblKraal
            // 
            this.lblKraal.AutoSize = true;
            this.lblKraal.Location = new System.Drawing.Point(15, 23);
            this.lblKraal.Name = "lblKraal";
            this.lblKraal.Size = new System.Drawing.Size(76, 13);
            this.lblKraal.TabIndex = 10;
            this.lblKraal.Text = "Select a Kraal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Animal Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Animal Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Animal Species:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kraal Avg. Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Feed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Avg. Feed Consumed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Feed Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Animals in Kraal:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(289, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(155, 273);
            this.dataGridView1.TabIndex = 19;
            // 
            // frmKraal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 389);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKraal);
            this.Controls.Add(this.txtFeedType);
            this.Controls.Add(this.txtAvgFeed);
            this.Controls.Add(this.txtTotalFeed);
            this.Controls.Add(this.txtAvgWeight);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.txtAnimalType);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.cmbKraal);
            this.Controls.Add(this.btnClose);
            this.Name = "frmKraal";
            this.Text = "Kraal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbKraal;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAnimalType;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtAvgWeight;
        private System.Windows.Forms.TextBox txtTotalFeed;
        private System.Windows.Forms.TextBox txtAvgFeed;
        private System.Windows.Forms.TextBox txtFeedType;
        private System.Windows.Forms.Label lblKraal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}