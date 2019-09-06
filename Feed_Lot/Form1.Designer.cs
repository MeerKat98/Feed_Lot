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
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.weighAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2112, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // menuStripKraal
            // 
            this.menuStripKraal.Name = "menuStripKraal";
            this.menuStripKraal.Size = new System.Drawing.Size(94, 48);
            this.menuStripKraal.Text = "Kraal";
            this.menuStripKraal.Click += new System.EventHandler(this.MenuStripKraal_Click);
            // 
            // menuStripViewAnimal
            // 
            this.menuStripViewAnimal.Name = "menuStripViewAnimal";
            this.menuStripViewAnimal.Size = new System.Drawing.Size(193, 48);
            this.menuStripViewAnimal.Text = "View Animal";
            this.menuStripViewAnimal.Click += new System.EventHandler(this.MenuStripViewAnimal_Click);
            // 
            // menuStripNewAnimal
            // 
            this.menuStripNewAnimal.Name = "menuStripNewAnimal";
            this.menuStripNewAnimal.Size = new System.Drawing.Size(189, 48);
            this.menuStripNewAnimal.Text = "New Animal";
            this.menuStripNewAnimal.Click += new System.EventHandler(this.MenuStripNewAnimal_Click);
            // 
            // menuStripFeed
            // 
            this.menuStripFeed.Name = "menuStripFeed";
            this.menuStripFeed.Size = new System.Drawing.Size(95, 48);
            this.menuStripFeed.Text = "Feed";
            this.menuStripFeed.Click += new System.EventHandler(this.MenuStripFeed_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(153, 48);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // weighAnimalToolStripMenuItem
            // 
            this.weighAnimalToolStripMenuItem.Name = "weighAnimalToolStripMenuItem";
            this.weighAnimalToolStripMenuItem.Size = new System.Drawing.Size(222, 48);
            this.weighAnimalToolStripMenuItem.Text = "Weigh Animal ";
            this.weighAnimalToolStripMenuItem.Click += new System.EventHandler(this.weighAnimalToolStripMenuItem_Click);
            // 
            // frmhomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources._42_60149484;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2112, 1283);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmhomePage";
            this.Text = "Farm Monitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

