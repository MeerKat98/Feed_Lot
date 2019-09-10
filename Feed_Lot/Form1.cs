using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Monitor
{
    public partial class frmhomePage : Form
    {
        public frmhomePage()
        {
            InitializeComponent();
        }

        private void MenuStripNewAnimal_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms) {
                if (f.Text == "Add New Animal") {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false) {
                frmNew_Animal newAnimal = new frmNew_Animal();
                newAnimal.MdiParent = this;
                newAnimal.Show();
            }
        }

        private void MenuStripKraal_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Kraal")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmKraal kraal = new frmKraal();
                kraal.MdiParent = this;
                kraal.Show();
            }
        }

        private void MenuStripViewAnimal_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "View Animal Details")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmView_Animal view = new frmView_Animal();
                view.MdiParent = this;
                view.Show();
            }
        }

        private void MenuStripFeed_Click(object sender, EventArgs e)
            {
                bool IsOpen = false;

                foreach (Form f in Application.OpenForms)
                {
                    if (f.Text == "Feed Animals")
                    {
                        IsOpen = true;
                        f.Focus();
                        break;
                    }
                }

                if (IsOpen == false)
                {
                    frmFeedAnimals feed = new frmFeedAnimals();
                    feed.MdiParent = this;
                    feed.Show();
                }
        }

        private void weighAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Weigh_Animal")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                frmWeigh_Animal  WeighAnimal = new frmWeigh_Animal();
                WeighAnimal.MdiParent = this;
                WeighAnimal.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExit_MouseHover(object sender, EventArgs e)
        {
            tltCloseProg.Show("Close Program",btnExit);
        }

        private void FrmhomePage_Load(object sender, EventArgs e)
        {
            loadingScreen frmLoad = new loadingScreen();
            frmLoad.ShowDialog();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
