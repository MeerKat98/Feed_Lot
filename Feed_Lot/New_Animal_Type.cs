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
    public partial class New_Animal_Type : Form
    {
        string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";

        public New_Animal_Type()
        {
            InitializeComponent();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Boolean typeTaken = false;
            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Description FROM ANIMAL_TYPE", con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == txtTypeName.Text)
                    typeTaken = true;
            }
            if (txtTypeName.Text == "")
                errorProvider1.SetError(txtTypeName, "This field cannot be empty!");
            else if (typeTaken)
                errorProvider1.SetError(txtTypeName, "That type is already registered!");
            else
            {
                try
                {
                    cmd = new OleDbCommand("INSERT INTO ANIMAL_TYPE (Description) VALUES (@Description)", con);
                    cmd.Parameters.AddWithValue("@Description", txtTypeName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New animal type added succesfully!");
                    txtTypeName.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not add animal type due to an unexpected error: " + ex.Message);
                }
            }
            con.Close();
        }
    }
}
