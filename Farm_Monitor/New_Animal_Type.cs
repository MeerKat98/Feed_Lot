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
        string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Robin de Klerk\Google Drive\Shared projects\Farm_Monitor\Farm_Monitor\Resources\FarmMonitor.accdb";

        public New_Animal_Type()
        {
            InitializeComponent();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            string name = txtTypeName.Text;
            string query = $"SELECT Description FROM ANIMAL_TYPE WHERE Description LIKE '%{name}%'";

            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            Object t = cmd.ExecuteScalar();
            if (t != null)
            {
                con.Close();
                MessageBox.Show($"The category is too similar to an existing category: {t}, please choose a new name.");
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
