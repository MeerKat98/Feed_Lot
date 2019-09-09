namespace Farm_Monitor
{
    partial class frmWeigh_Animal
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
            this.label2 = new System.Windows.Forms.Label();
            this.animaltbx = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weightbx = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.datetbx = new System.Windows.Forms.TextBox();
            this.dataGridViewWeigh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeigh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(535, 507);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 110);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date weighed:";
            // 
            // animaltbx
            // 
            this.animaltbx.Location = new System.Drawing.Point(297, 100);
            this.animaltbx.Name = "animaltbx";
            this.animaltbx.Size = new System.Drawing.Size(161, 38);
            this.animaltbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "        ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "  ";
            // 
            // weightbx
            // 
            this.weightbx.Location = new System.Drawing.Point(297, 191);
            this.weightbx.Name = "weightbx";
            this.weightbx.Size = new System.Drawing.Size(161, 38);
            this.weightbx.TabIndex = 7;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(125, 507);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(132, 110);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // datetbx
            // 
            this.datetbx.Location = new System.Drawing.Point(297, 284);
            this.datetbx.Name = "datetbx";
            this.datetbx.Size = new System.Drawing.Size(161, 38);
            this.datetbx.TabIndex = 9;
            // 
            // dataGridViewWeigh
            // 
            this.dataGridViewWeigh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeigh.Location = new System.Drawing.Point(549, 91);
            this.dataGridViewWeigh.Name = "dataGridViewWeigh";
            this.dataGridViewWeigh.RowTemplate.Height = 40;
            this.dataGridViewWeigh.Size = new System.Drawing.Size(492, 365);
            this.dataGridViewWeigh.TabIndex = 10;
            // 
            // frmWeigh_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 820);
            this.Controls.Add(this.dataGridViewWeigh);
            this.Controls.Add(this.datetbx);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.weightbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.animaltbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmWeigh_Animal";
            this.Text = "Weigh_Animal";
            this.Load += new System.EventHandler(this.frmWeigh_Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox animaltbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weightbx;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.TextBox datetbx;
        private System.Windows.Forms.DataGridView dataGridViewWeigh;
    }
}