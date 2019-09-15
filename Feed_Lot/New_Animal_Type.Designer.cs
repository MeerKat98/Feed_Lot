namespace Farm_Monitor
{
    partial class New_Animal_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Animal_Type));
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.Color.Silver;
            this.txtTypeName.Location = new System.Drawing.Point(113, 12);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(121, 20);
            this.txtTypeName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Animal Type:";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.BackColor = System.Drawing.Color.Silver;
            this.btnAddAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAnimal.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.Location = new System.Drawing.Point(93, 68);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 46);
            this.btnAddAnimal.TabIndex = 22;
            this.btnAddAnimal.Text = "Add";
            this.btnAddAnimal.UseVisualStyleBackColor = false;
            this.btnAddAnimal.Click += new System.EventHandler(this.BtnAddAnimal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // New_Animal_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farm_Monitor.Properties.Resources.Pattern3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(266, 140);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAnimal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "New_Animal_Type";
            this.Text = "New Animal Type";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}