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
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFeedType = new System.Windows.Forms.ComboBox();
            this.cmbKraal = new System.Windows.Forms.ComboBox();
            this.txtFeedQuantitiy = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(256, 148);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kraal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Feed Amount (kg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Feed Type:";
            // 
            // cmbFeedType
            // 
            this.cmbFeedType.FormattingEnabled = true;
            this.cmbFeedType.Location = new System.Drawing.Point(152, 60);
            this.cmbFeedType.Name = "cmbFeedType";
            this.cmbFeedType.Size = new System.Drawing.Size(121, 21);
            this.cmbFeedType.TabIndex = 7;
            // 
            // cmbKraal
            // 
            this.cmbKraal.FormattingEnabled = true;
            this.cmbKraal.Location = new System.Drawing.Point(152, 33);
            this.cmbKraal.Name = "cmbKraal";
            this.cmbKraal.Size = new System.Drawing.Size(121, 21);
            this.cmbKraal.TabIndex = 8;
            // 
            // txtFeedQuantitiy
            // 
            this.txtFeedQuantitiy.Location = new System.Drawing.Point(152, 87);
            this.txtFeedQuantitiy.Name = "txtFeedQuantitiy";
            this.txtFeedQuantitiy.Size = new System.Drawing.Size(100, 20);
            this.txtFeedQuantitiy.TabIndex = 9;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(12, 148);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 46);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Record Feed";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // frmFeedAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 206);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.txtFeedQuantitiy);
            this.Controls.Add(this.cmbKraal);
            this.Controls.Add(this.cmbFeedType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmFeedAnimals";
            this.Text = "Feed Animals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFeedType;
        private System.Windows.Forms.ComboBox cmbKraal;
        private System.Windows.Forms.TextBox txtFeedQuantitiy;
        private System.Windows.Forms.Button btnRecord;
    }
}