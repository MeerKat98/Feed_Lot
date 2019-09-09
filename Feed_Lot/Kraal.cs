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
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Desktop\Feed_Lot\FarmMonitor.accdb";
        int animalType;
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
            OleDbConnection con = new OleDbConnection(constring);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Kraal_ID FROM KRAAL", con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            cmbKraal.DataSource = ds.Tables[0];
            cmbKraal.DisplayMember = "Kraal_ID";
            cmbKraal.ValueMember = "Kraal_ID";
        }

        private void CmbKraal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(constring);
                con.Open();

                OleDbCommand command = new OleDbCommand("SELECT Animal_Type FROM KRAAL WHERE Kraal_ID = " + cmbKraal.Text, con);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                animalType = Convert.ToInt32(reader[0]);

                command = new OleDbCommand("SELECT Description FROM ANIMAL_TYPE WHERE Animal_Type = " + animalType, con);
                reader = command.ExecuteReader();
                reader.Read();
                txtAnimalType.Text = reader[0].ToString();

                command = new OleDbCommand("SELECT Feed_ID FROM FEED_USED WHERE Kraal_ID = " + cmbKraal.Text, con);
                reader = command.ExecuteReader();
                reader.Read();
                string feedID = reader[0].ToString();

                command = new OleDbCommand("SELECT Feed_Type FROM FEED WHERE Feed_ID = " + feedID, con);
                reader = command.ExecuteReader();
                reader.Read();
                txtFeedType.Text = reader[0].ToString();

                command = new OleDbCommand("SELECT SUM(Feed_Amount) FROM FEED_USED WHERE Kraal_ID = " + cmbKraal.Text, con);
                reader = command.ExecuteReader();
                reader.Read();
                txtTotalFeed.Text = reader[0].ToString();

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Tag_Code FROM ANIMAL WHERE Kraal_ID = " + cmbKraal.Text, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "fill");
                dataGridAnimalsInKraal.DataSource = ds;
                dataGridAnimalsInKraal.DataMember = "fill";
                con.Close();
                txtCount.Text = Convert.ToString(dataGridAnimalsInKraal.Rows.Count - 1); //Avoiding opening and closing the database too many times
                txtAvgFeed.Text = Convert.ToString(Convert.ToInt32(txtTotalFeed.Text) / Convert.ToInt32(txtCount.Text));
            }
            catch (Exception) { }
        }
    }
}
