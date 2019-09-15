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
        string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";

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
            errorProvider1.Clear();
            Boolean speciesTaken = false;
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Animal_Type FROM ANIMAL_TYPE WHERE Description = '" + cmbAnimalType.Text + "'", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string animalType = reader[0].ToString();

            cmd = new OleDbCommand("SELECT Description FROM SPECIES", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == txtSpeciesName.Text)
                    speciesTaken = true;
            }
            if (txtSpeciesName.Text == "")
            {
                errorProvider1.SetError(txtSpeciesName, "This field cannot be empty!");
            }
            else if (speciesTaken == true)
            {
                errorProvider1.SetError(txtSpeciesName,"This species is already regestered!");
            }
            else
            {
                cmd = new OleDbCommand($@"INSERT INTO SPECIES (Description, Animal_Type) VALUES('{txtSpeciesName.Text}','{animalType}')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Species succesfully regestered!" + animalType);
                txtSpeciesName.Clear();
            }
        }


        private void New_Species_Load(object sender, EventArgs e)
        {

        }
    }
}
