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
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Rudolph\Desktop\CMPG 223\Project
                            \Feed_Lot\Feed_Lot\Resources\FarmMonitor.accdb;Persist Security Info=True";

        public frmFeedAnimals()
        {
            InitializeComponent();
            //populate(constring, cmbKraal, "KRAAL", "Kraal_ID");

           try
            {
                OleDbConnection con = new OleDbConnection(constring);
                con.Open();
                OleDbCommand command;
                string sql1 = @"SELECT Kraal_ID FROM KRAAL";
                string sql2 = @"SELECT Feed_Type FROM FEED";
                OleDbDataAdapter adapter = new OleDbDataAdapter();

                //Fill Kraal combobox
                command = new OleDbCommand(sql1, con);

                DataSet ds1 = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds1, "KRAAL");

                cmbKraal.DisplayMember = "Kraal_ID";
                cmbKraal.ValueMember = "Kraal_ID";
                cmbKraal.DataSource = ds1.Tables["KRAAL"];

                //Fill Feed type combobox
                command = new OleDbCommand(sql2, con);

                DataSet ds2 = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(ds2, "FEED");

                cmbFeedType.DisplayMember = "Feed_Type";
                cmbFeedType.ValueMember = "Feed_Type";
                cmbFeedType.DataSource = ds1.Tables["FEED"];

                con.Close();
            }

            catch
            {
                MessageBox.Show("SELECT FROM FEED & KRAAL and fill combobox error");
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKraal.SelectedValue != null && cmbFeedType.SelectedValue != null && txtFeedQuantitiy.Text != null)
                {
                    int selectedKraal = (Int32)cmbKraal.SelectedValue;      //assign kraal ID to int variable
                    string selectedFeedType = cmbFeedType.SelectedItem.ToString();  //assign feed type to string variable
                    double feedAmt = double.Parse(txtFeedQuantitiy.Text);   //assign feed amount to double variable
                    int selectedFeedID = 0;                          //declare empty string variable to hold the feed type later
                    DateTime date = DateTime.Now;                 //create DateTime object with the current date

                    //feed ID is asssigned to selectedFeedID according to selected feed type
                    if (selectedFeedType == "Cattle Feed")
                        selectedFeedID = 1;
                    else if (selectedFeedType == "Sheep Feed")
                        selectedFeedID = 2;
                    else if (selectedFeedType == "Chicken Feed")
                        selectedFeedID = 3;
                    else if (selectedFeedType == "Pig Feed")
                        selectedFeedID = 4;
                    else
                        MessageBox.Show("Invalid feed type selected");

                    //insert data into FEED_USED table
                    OleDbConnection con = new OleDbConnection(constring);
                    con.Open();
                    OleDbCommand command;
                    string sqlInsert = "INSERT into FEED_USED (Kraal_ID, Feed_ID, Feed_Amount, Feed_Date) VALUES ("+selectedKraal+","+selectedFeedID+","+feedAmt+","+date+")";
                    OleDbDataAdapter adapter = new OleDbDataAdapter();

                    command = new OleDbCommand(sqlInsert, con);

                    adapter.InsertCommand = new OleDbCommand(sqlInsert, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("INSERT into FEED_USED error");
            }
        }

        public void populate(string constring, ComboBox cmb, string table, string field)
        {
            OleDbConnection con = new OleDbConnection(constring);
            con.Open();
            OleDbCommand command;
            string sql = @"SELECT " + field + " FROM " + table;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            command = new OleDbCommand(sql, con);

            DataSet ds = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(ds, table);

            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = field;
            cmb.ValueMember = field;
            con.Close();
        }
    }
}
