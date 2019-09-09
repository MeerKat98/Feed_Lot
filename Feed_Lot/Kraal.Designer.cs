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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKraal));
            this.cmbKraal = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.txtAvgWeight = new System.Windows.Forms.TextBox();
            this.txtTotalFeed = new System.Windows.Forms.TextBox();
            this.txtAvgFeed = new System.Windows.Forms.TextBox();
            this.txtFeedType = new System.Windows.Forms.TextBox();
            this.lblKraal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridAnimalsInKraal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalsInKraal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKraal
            // 
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(131, 25);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(100, 21);
            this.cmbKraal.TabIndex = 2;
            this.cmbKraal.SelectedIndexChanged += new System.EventHandler(this.CmbKraal_SelectedIndexChanged);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(131, 86);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 3;
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.Location = new System.Drawing.Point(131, 112);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(100, 20);
            this.txtAnimalType.TabIndex = 4;
            // 
            // txtAvgWeight
            // 
            this.txtAvgWeight.Location = new System.Drawing.Point(131, 164);
            this.txtAvgWeight.Name = "txtAvgWeight";
            this.txtAvgWeight.Size = new System.Drawing.Size(100, 20);
            this.txtAvgWeight.TabIndex = 6;
            // 
            // txtTotalFeed
            // 
            this.txtTotalFeed.Location = new System.Drawing.Point(131, 190);
            this.txtTotalFeed.Name = "txtTotalFeed";
            this.txtTotalFeed.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFeed.TabIndex = 7;
            // 
            // txtAvgFeed
            // 
            this.txtAvgFeed.Location = new System.Drawing.Point(131, 216);
            this.txtAvgFeed.Name = "txtAvgFeed";
            this.txtAvgFeed.Size = new System.Drawing.Size(100, 20);
            this.txtAvgFeed.TabIndex = 8;
            // 
            // txtFeedType
            // 
            this.txtFeedType.Location = new System.Drawing.Point(131, 242);
            this.txtFeedType.Name = "txtFeedType";
            this.txtFeedType.Size = new System.Drawing.Size(100, 20);
            this.txtFeedType.TabIndex = 9;
            // 
            // lblKraal
            // 
            this.lblKraal.AutoSize = true;
            this.lblKraal.Location = new System.Drawing.Point(13, 28);
            this.lblKraal.Name = "lblKraal";
            this.lblKraal.Size = new System.Drawing.Size(76, 13);
            this.lblKraal.TabIndex = 10;
            this.lblKraal.Text = "Select a Kraal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Animal Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Animal Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kraal Avg. Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Feed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Avg. Feed Consumed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Feed Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Animals in Kraal:";
            // 
            // dataGridAnimalsInKraal
            // 
            this.dataGridAnimalsInKraal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridAnimalsInKraal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAnimalsInKraal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnimalsInKraal.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridAnimalsInKraal.Location = new System.Drawing.Point(260, 0);
            this.dataGridAnimalsInKraal.Name = "dataGridAnimalsInKraal";
            this.dataGridAnimalsInKraal.RowHeadersVisible = false;
            this.dataGridAnimalsInKraal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridAnimalsInKraal.Size = new System.Drawing.Size(80, 286);
            this.dataGridAnimalsInKraal.TabIndex = 19;
            this.dataGridAnimalsInKraal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAnimalsInKraal_CellContentClick);
            this.dataGridAnimalsInKraal.MouseEnter += new System.EventHandler(this.DataGridAnimalsInKraal_MouseEnter);
            this.dataGridAnimalsInKraal.MouseLeave += new System.EventHandler(this.DataGridAnimalsInKraal_MouseLeave);
            // 
            // frmKraal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 286);
            this.Controls.Add(this.dataGridAnimalsInKraal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKraal);
            this.Controls.Add(this.txtFeedType);
            this.Controls.Add(this.txtAvgFeed);
            this.Controls.Add(this.txtTotalFeed);
            this.Controls.Add(this.txtAvgWeight);
            this.Controls.Add(this.txtAnimalType);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.cmbKraal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKraal";
            this.ShowIcon = false;
            this.Text = "Kraal";
            this.Load += new System.EventHandler(this.FrmKraal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimalsInKraal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbKraal;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtAnimalType;
        private System.Windows.Forms.TextBox txtAvgWeight;
        private System.Windows.Forms.TextBox txtTotalFeed;
        private System.Windows.Forms.TextBox txtAvgFeed;
        private System.Windows.Forms.TextBox txtFeedType;
        private System.Windows.Forms.Label lblKraal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridAnimalsInKraal;
    }
}