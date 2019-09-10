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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeigh_Animal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.animaltbx = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.weightbx = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.gridViewAnimals = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tag_Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // animaltbx
            // 
            this.animaltbx.BackColor = System.Drawing.Color.Silver;
            this.animaltbx.Location = new System.Drawing.Point(101, 17);
            this.animaltbx.Margin = new System.Windows.Forms.Padding(1);
            this.animaltbx.Name = "animaltbx";
            this.animaltbx.Size = new System.Drawing.Size(88, 20);
            this.animaltbx.TabIndex = 3;
            this.animaltbx.TextChanged += new System.EventHandler(this.animaltbx_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(22, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight:";
            // 
            // weightbx
            // 
            this.weightbx.BackColor = System.Drawing.Color.Silver;
            this.weightbx.Location = new System.Drawing.Point(101, 51);
            this.weightbx.Margin = new System.Windows.Forms.Padding(1);
            this.weightbx.Name = "weightbx";
            this.weightbx.Size = new System.Drawing.Size(88, 20);
            this.weightbx.TabIndex = 7;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Silver;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebtn.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(65, 144);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(1);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(79, 43);
            this.updatebtn.TabIndex = 8;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // gridViewAnimals
            // 
            this.gridViewAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAnimals.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridViewAnimals.Location = new System.Drawing.Point(217, 0);
            this.gridViewAnimals.Name = "gridViewAnimals";
            this.gridViewAnimals.RowHeadersVisible = false;
            this.gridViewAnimals.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewAnimals.Size = new System.Drawing.Size(80, 215);
            this.gridViewAnimals.TabIndex = 10;
            this.gridViewAnimals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewAnimals_CellClick);
            this.gridViewAnimals.MouseEnter += new System.EventHandler(this.GridViewAnimals_MouseEnter);
            this.gridViewAnimals.MouseLeave += new System.EventHandler(this.GridViewAnimals_MouseLeave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Silver;
            this.lblDate.Location = new System.Drawing.Point(62, 87);
            this.lblDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 14);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmWeigh_Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(297, 215);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gridViewAnimals);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.weightbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.animaltbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmWeigh_Animal";
            this.Text = "Weigh_Animal";
            this.Load += new System.EventHandler(this.frmWeigh_Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox animaltbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weightbx;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridView gridViewAnimals;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}