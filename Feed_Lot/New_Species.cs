using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Monitor
{
    public partial class New_Species : Form
    {
        string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Farm_Monitor\FarmMonitor.accdb";

        public New_Species()
        {
            InitializeComponent();
            populate(connection, cmbAnimalType, "ANIMAL_TYPE", "Description");
        }

        public void populate(string connection, ComboBox cmb, string table, string field)
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select " + field + " from " + table, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = field;
            cmb.ValueMember = field;
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            string name = txtSpeciesName.Text;
            string query = $"SELECT * FROM ANIMAL_TYPE WHERE Description = '{name}'";

            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            Object t = cmd.ExecuteScalar();
            if (t != null)
            {
                MessageBox.Show("The speciesalready exists, please choose a new name.");
            }
            else
            {
                OleDbCommand cmd2 = new OleDbCommand($@"INSERT INTO ANIMAL_TYPE(Description) VALUES('{name}')", con);
                cmd2.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
