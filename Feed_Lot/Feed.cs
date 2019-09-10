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
    public partial class frmFeedAnimals : Form
    {
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";

        public frmFeedAnimals()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            double amount;
            if (txtFeedQuantitiy.Text == "")
                errorProvider1.SetError(txtFeedQuantitiy, "This space cannot be empty!");
            else if (double.TryParse(txtFeedQuantitiy.Text, out amount) != true)
                errorProvider1.SetError(txtFeedQuantitiy, "The entered value is not valid. Feed quantity must be indicated as a number that could be interpreted as kilograms (decimal).");
            else
            {

                try
                {
                    OleDbConnection conn = new OleDbConnection(constring);
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("SELECT Feed_ID FROM FEED WHERE Feed_Type = '" + cmbFeedType.Text + "'", conn);
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string feedID = reader[0].ToString();
                    command = new OleDbCommand("INSERT INTO FEED_USED (Kraal_ID,FEED_ID,Feed_Amount,Feed_Date) VALUES (@Kraal_ID,@Feed_ID,@Feed_Amount,@Feed_Date)", conn);
                    command.Parameters.AddWithValue("@Kraal_ID", cmbKraal.Text);
                    command.Parameters.AddWithValue("@Feed_ID", feedID);
                    command.Parameters.AddWithValue("@Feed_Amount", amount);
                    command.Parameters.AddWithValue("@Feed_Date", lblDate.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Feeding session has been logged succesfully!");
                    txtFeedQuantitiy.Clear();
                    cmbKraal.SelectedIndex = 0;
                    cmbFeedType.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not add feeding session to the database due to an error: " + ex.Message);
                }
            }
        }

        public void populate(ComboBox cmb, string sql, string field)
        {
            OleDbConnection con = new OleDbConnection(constring);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = field;
            cmb.ValueMember = field;
            con.Close();
        }

        private void FrmFeedAnimals_Load(object sender, EventArgs e)
        {
            try
            {
                populate(cmbKraal, "SELECT Kraal_ID FROM KRAAL ORDER BY Kraal_ID", "Kraal_ID");
                populate(cmbFeedType, "SELECT Feed_Type FROM FEED ORDER BY Feed_Type", "Feed_Type");
                DateTime date = DateTime.Today;
                lblDate.Text = date.ToString("yyyy/MM/dd");
            }

            catch   (Exception ex)
            {
                MessageBox.Show("Could not populate combobox for kraal and feed type due to an error: " + ex.Message);
            }
        }

        private void CmbKraal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKraal.Text != "System.Data.DataRowView")
            {
                OleDbConnection conn = new OleDbConnection(constring);
                conn.Open();
                OleDbCommand command = new OleDbCommand("SELECT Description FROM ANIMAL_TYPE WHERE Animal_Type = (SELECT Animal_Type FROM KRAAL WHERE Kraal_ID = " + cmbKraal.Text + ")", conn);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                lblAnimalsInKraal.Text = "Contains: " + reader[0].ToString();
                conn.Close();
            }
        }
    }
}
