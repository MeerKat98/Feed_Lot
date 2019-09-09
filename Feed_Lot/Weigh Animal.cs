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
    public partial class frmWeigh_Animal : Form
    {
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dell\Desktop\Feed_Lot\FarmMonitor.accdb";
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
            OleDbConnection connection = new OleDbConnection(constring);
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Tag_Code FROM ANIMAL ORDER BY Tag_Code", connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "member");
            dataGridViewWeigh.DataSource = ds;
            dataGridViewWeigh.DataMember = "member";
            connection.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
        }


        /*
            try
            {
                OleDbConnection connection = new OleDbConnection(constring);
                connection.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO ANIMAL_WEIGHT (Animal_ID,Date_Weighed,Weight) VALUES (@Animal_ID,@Date_Weighed,@Weight)", connection);
                cmd.Parameters.AddWithValue("@Animal_ID", reader[0]);
                cmd.Parameters.AddWithValue("@Weighed_Date", dateOnly.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Weight", weightbx.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Database insert error: " + ex.Message);
            }
        */




        /*OleDbConnection con = new OleDbConnection(constring);
        con.Open();
         //OleDbCommand command = new OleDbCommand("UPDATE ANIMAL_WEIGHT SET Weight = "+ weightbx.Text +" WHERE Animal_ID = " + animaltbx.Text+"", con);
        OleDbCommand command = new OleDbCommand("UPDATE ANIMAL_WEIGHT SET Weight = "+ weightbx.Text +", Date_Weighed ="+ datetbx.Text + " WHERE Animal_ID = " + animaltbx.Text, con);
        //OleDbCommand command = new OleDbCommand("INSERT INTO ANIMAL_WEIGHT(Weight)"+ weightbx.Text +" WHERE Animal_ID =" + animaltbx.Text+"", con);
        command.ExecuteNonQuery();


        OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * ANIMAL_WEIGHT WHERE Animal_ID = " + animaltbx.Text, con);
        DataSet ds = new DataSet();
        adapter.Fill(ds, "fill");
        dataGridViewWeigh.DataSource = ds;
        dataGridViewWeigh.DataMember = "fill";
        con.Close();
        */
    }
}
