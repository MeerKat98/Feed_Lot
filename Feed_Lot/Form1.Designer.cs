namespace Farm_Monitor
{
    partial class frmhomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripKraal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripViewAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripNewAnimal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFeed = new System.Windows.Forms.ToolStripMenuItem();
            this.weighAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.tltCloseProg = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripKraal,
            this.menuStripViewAnimal,
            this.menuStripNewAnimal,
            this.menuStripFeed,
            this.weighAnimalToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(842, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "File";
            // 
            // menuStripKraal
            // 
            this.menuStripKraal.Name = "menuStripKraal";
            this.menuStripKraal.Size = new System.Drawing.Size(65, 27);
            this.menuStripKraal.Text = "Kraal";
            this.menuStripKraal.Click += new System.EventHandler(this.MenuStripKraal_Click);
            // 
            // menuStripViewAnimal
            // 
            this.menuStripViewAnimal.Name = "menuStripViewAnimal";
            this.menuStripViewAnimal.Size = new System.Drawing.Size(127, 27);
            this.menuStripViewAnimal.Text = "View Animal";
            this.menuStripViewAnimal.Click += new System.EventHandler(this.MenuStripViewAnimal_Click);
            // 
            // menuStripNewAnimal
            // 
            this.menuStripNewAnimal.Name = "menuStripNewAnimal";
            this.menuStripNewAnimal.Size = new System.Drawing.Size(123, 27);
            this.menuStripNewAnimal.Text = "New Animal";
            this.menuStripNewAnimal.Click += new System.EventHandler(this.MenuStripNewAnimal_Click);
            // 
            // menuStripFeed
            // 
            this.menuStripFeed.Name = "menuStripFeed";
            this.menuStripFeed.Size = new System.Drawing.Size(60, 27);
            this.menuStripFeed.Text = "Feed";
            this.menuStripFeed.Click += new System.EventHandler(this.MenuStripFeed_Click);
            // 
            // weighAnimalToolStripMenuItem
            // 
            this.weighAnimalToolStripMenuItem.Name = "weighAnimalToolStripMenuItem";
            this.weighAnimalToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.weighAnimalToolStripMenuItem.Text = "Weigh Animal ";
            this.weighAnimalToolStripMenuItem.Click += new System.EventHandler(this.weighAnimalToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.BackgroundImage = global::Farm_Monitor.Properties.Resources.index;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnExit.Location = new System.Drawing.Point(792, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseHover += new System.EventHandler(this.BtnExit_MouseHover);
            // 
            // tltCloseProg
            // 
            this.tltCloseProg.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // frmhomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.nastockLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 513);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmhomePage";
            this.Text = "Farm Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmhomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripKraal;
        private System.Windows.Forms.ToolStripMenuItem menuStripViewAnimal;
        private System.Windows.Forms.ToolStripMenuItem menuStripNewAnimal;
        private System.Windows.Forms.ToolStripMenuItem menuStripFeed;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weighAnimalToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip tltCloseProg;
    }
}

