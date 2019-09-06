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
    public partial class frmWeigh_Animal : Form
    {
        public frmWeigh_Animal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //added datetime as label
        private void frmWeigh_Animal_Load(object sender, EventArgs e)
        {
            datetbx.Text = Convert.ToString(DateTime.Now);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
