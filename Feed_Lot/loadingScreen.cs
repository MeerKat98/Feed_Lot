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
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            timer1.Start();
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
