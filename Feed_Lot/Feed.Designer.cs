namespace Farm_Monitor
{
    partial class frmFeedAnimals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeedAnimals));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFeedType = new System.Windows.Forms.ComboBox();
            this.cmbKraal = new System.Windows.Forms.ComboBox();
            this.txtFeedQuantitiy = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lblAnimalsInKraal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kraal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Feed Amount (kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(15, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Feed Type:";
            // 
            // cmbFeedType
            // 
            this.cmbFeedType.BackColor = System.Drawing.Color.Silver;
            this.cmbFeedType.FormattingEnabled = true;
            this.cmbFeedType.Location = new System.Drawing.Point(87, 53);
            this.cmbFeedType.Name = "cmbFeedType";
            this.cmbFeedType.Size = new System.Drawing.Size(121, 21);
            this.cmbFeedType.TabIndex = 7;
            // 
            // cmbKraal
            // 
            this.cmbKraal.BackColor = System.Drawing.Color.Silver;
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(87, 26);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(121, 21);
            this.cmbKraal.TabIndex = 8;
            this.cmbKraal.SelectedIndexChanged += new System.EventHandler(this.CmbKraal_SelectedIndexChanged);
            // 
            // txtFeedQuantitiy
            // 
            this.txtFeedQuantitiy.BackColor = System.Drawing.Color.Silver;
            this.txtFeedQuantitiy.Location = new System.Drawing.Point(129, 106);
            this.txtFeedQuantitiy.Name = "txtFeedQuantitiy";
            this.txtFeedQuantitiy.Size = new System.Drawing.Size(100, 20);
            this.txtFeedQuantitiy.TabIndex = 9;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.BackColor = System.Drawing.Color.Silver;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecord.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(254, 93);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 46);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Record Feed";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lblAnimalsInKraal
            // 
            this.lblAnimalsInKraal.AutoSize = true;
            this.lblAnimalsInKraal.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimalsInKraal.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalsInKraal.ForeColor = System.Drawing.Color.Silver;
            this.lblAnimalsInKraal.Location = new System.Drawing.Point(226, 29);
            this.lblAnimalsInKraal.Name = "lblAnimalsInKraal";
            this.lblAnimalsInKraal.Size = new System.Drawing.Size(61, 14);
            this.lblAnimalsInKraal.TabIndex = 11;
            this.lblAnimalsInKraal.Text = "Contains:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(60, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 14);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFeedAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 155);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnimalsInKraal);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtFeedQuantitiy);
            this.Controls.Add(this.cmbKraal);
            this.Controls.Add(this.cmbFeedType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFeedAnimals";
            this.Text = "Feed Animals";
            this.Load += new System.EventHandler(this.FrmFeedAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFeedType;
        private System.Windows.Forms.ComboBox cmbKraal;
        private System.Windows.Forms.TextBox txtFeedQuantitiy;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label lblAnimalsInKraal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}