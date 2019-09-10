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
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";
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
            display("SELECT Tag_Code FROM ANIMAL ORDER BY Tag_Code");
            DateTime now = DateTime.Today;
            lblDate.Text = now.ToString("yyyy/MM/dd");
        }

        private void animaltbx_TextChanged(object sender, EventArgs e)
        {
            display("SELECT Tag_Code FROM ANIMAL WHERE Tag_Code LIKE '%" + animaltbx.Text + "%'");      //Update the dataGridView to only contain items simelar to the text in the seatch textbox.
        }

        public void display(string sql)
        {
            OleDbConnection conn = new OleDbConnection(constring);      //Create connection to DB.
            conn.Open();        //Open connection.
            OleDbDataAdapter adap = new OleDbDataAdapter(sql, conn);        //Create adapter with sql command and link to connection.
            DataSet ds = new DataSet();     //Create dataset.
            adap.Fill(ds, "fill");      //Fill the Datagrid view.
            conn.Close();       //Close connection.
            gridViewAnimals.DataSource = ds;        //Specify gridView's datasource and datamember.
            gridViewAnimals.DataMember = "fill";
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Boolean validTag = false;
            double weight;
            if (double.TryParse(weightbx.Text, out weight))
            {
                OleDbConnection conn = new OleDbConnection(constring);
                conn.Open();
                OleDbCommand command = new OleDbCommand("SELECT Tag_Code FROM ANIMAL", conn);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0].ToString() == animaltbx.Text)
                    {
                        validTag = true;
                    }
                }
                if (validTag)
                {
                    try
                    {
                        command = new OleDbCommand("SELECT Animal_ID FROM ANIMAL WHERE Tag_Code = '" + animaltbx.Text + "'",conn);
                        reader = command.ExecuteReader();
                        reader.Read();
                        string animalID = reader[0].ToString();

                        command = new OleDbCommand("INSERT INTO ANIMAL_WEIGHT (Animal_ID, Date_Weighed, Weight) VALUES (@Animal_ID,@Date_Weighed,@Weight)",conn);
                        command.Parameters.AddWithValue("@Animal_ID", animalID);
                        command.Parameters.AddWithValue("@Date_Weighed", lblDate.Text);
                        command.Parameters.AddWithValue("@Weight", weightbx.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Animal weight has been added succesfully!");
                        animaltbx.Clear();
                        weightbx.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add animal weight to the database due to an error: " + ex.Message + "\nNote: Animals can only be weighed once a day!");
                    }
                }
                else
                    errorProvider1.SetError(animaltbx, "No animal has this tag code! Please click on a tag code in the datagrid view to the left.");
                conn.Close();
            }
            else
                errorProvider1.SetError(weightbx, "This value is not a valid weight!");
        }

        private void GridViewAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = gridViewAnimals.CurrentCell.RowIndex;
            int columnindex = gridViewAnimals.CurrentCell.ColumnIndex;
            animaltbx.Text = Convert.ToString(gridViewAnimals.Rows[rowindex].Cells[columnindex].Value);
        }

        private void GridViewAnimals_MouseEnter(object sender, EventArgs e)
        {
            gridViewAnimals.BorderStyle = BorderStyle.FixedSingle;
        }

        private void GridViewAnimals_MouseLeave(object sender, EventArgs e)
        {
            gridViewAnimals.BorderStyle = BorderStyle.None;
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
