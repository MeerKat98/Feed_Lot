using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Farm_Monitor
{
    public partial class frmKraal : Form
    {
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Farm_Monitor\FarmMonitor.accdb";
        public frmKraal()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKraal_Load(object sender, EventArgs e)
        {
            populate("SELECT Kraal_ID FROM KRAAL", cmbKraal);
        }

        public void populate(string sql, ComboBox cmb)
        {
            OleDbConnection con = new OleDbConnection(constring);
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = "Kraal_ID";
            cmb.ValueMember = "Kraal_ID";
        }
    }
}
