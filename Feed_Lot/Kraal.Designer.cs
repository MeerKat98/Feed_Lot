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
            this.cmbKraal.BackColor = System.Drawing.Color.Silver;
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(140, 26);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(100, 21);
            this.cmbKraal.TabIndex = 2;
            this.cmbKraal.SelectedIndexChanged += new System.EventHandler(this.CmbKraal_SelectedIndexChanged);
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.Silver;
            this.txtCount.Enabled = false;
            this.txtCount.Location = new System.Drawing.Point(140, 87);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 21);
            this.txtCount.TabIndex = 3;
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.BackColor = System.Drawing.Color.Silver;
            this.txtAnimalType.Enabled = false;
            this.txtAnimalType.Location = new System.Drawing.Point(140, 113);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(100, 21);
            this.txtAnimalType.TabIndex = 4;
            // 
            // txtAvgWeight
            // 
            this.txtAvgWeight.BackColor = System.Drawing.Color.Silver;
            this.txtAvgWeight.Enabled = false;
            this.txtAvgWeight.Location = new System.Drawing.Point(140, 165);
            this.txtAvgWeight.Name = "txtAvgWeight";
            this.txtAvgWeight.Size = new System.Drawing.Size(100, 21);
            this.txtAvgWeight.TabIndex = 6;
            // 
            // txtTotalFeed
            // 
            this.txtTotalFeed.BackColor = System.Drawing.Color.Silver;
            this.txtTotalFeed.Enabled = false;
            this.txtTotalFeed.Location = new System.Drawing.Point(140, 191);
            this.txtTotalFeed.Name = "txtTotalFeed";
            this.txtTotalFeed.Size = new System.Drawing.Size(100, 21);
            this.txtTotalFeed.TabIndex = 7;
            // 
            // txtAvgFeed
            // 
            this.txtAvgFeed.BackColor = System.Drawing.Color.Silver;
            this.txtAvgFeed.Enabled = false;
            this.txtAvgFeed.Location = new System.Drawing.Point(140, 217);
            this.txtAvgFeed.Name = "txtAvgFeed";
            this.txtAvgFeed.Size = new System.Drawing.Size(100, 21);
            this.txtAvgFeed.TabIndex = 8;
            // 
            // txtFeedType
            // 
            this.txtFeedType.BackColor = System.Drawing.Color.Silver;
            this.txtFeedType.Enabled = false;
            this.txtFeedType.Location = new System.Drawing.Point(140, 243);
            this.txtFeedType.Name = "txtFeedType";
            this.txtFeedType.Size = new System.Drawing.Size(100, 21);
            this.txtFeedType.TabIndex = 9;
            // 
            // lblKraal
            // 
            this.lblKraal.AutoSize = true;
            this.lblKraal.BackColor = System.Drawing.Color.Transparent;
            this.lblKraal.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKraal.ForeColor = System.Drawing.Color.Silver;
            this.lblKraal.Location = new System.Drawing.Point(13, 28);
            this.lblKraal.Name = "lblKraal";
            this.lblKraal.Size = new System.Drawing.Size(85, 14);
            this.lblKraal.TabIndex = 10;
            this.lblKraal.Text = "Select a Kraal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Animal Count:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Animal Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kraal Avg. Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Feed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Avg. Feed Consumed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(12, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Feed Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(157, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Animals in Kraal:";
            // 
            // dataGridAnimalsInKraal
            // 
            this.dataGridAnimalsInKraal.BackgroundColor = System.Drawing.Color.Silver;
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
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKraal";
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