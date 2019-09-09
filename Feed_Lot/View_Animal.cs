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
    public partial class frmView_Animal : Form
    {
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";
        public frmView_Animal()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();       //Close this mdi child
        }

        private void FrmView_Animal_Load(object sender, EventArgs e)
        {
            display("SELECT Tag_Code FROM ANIMAL ORDER BY Tag_Code");     //Display all animals when opened.
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            display("SELECT Tag_Code FROM ANIMAL WHERE Tag_Code LIKE '%" + txtSearch.Text + "%'");      //Update the dataGridView to only contain items simelar to the text in the seatch textbox.
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

        private void GridViewAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Find the column- and row-index of the selected item.
            int rowindex = gridViewAnimals.CurrentCell.RowIndex;
            int columnindex = gridViewAnimals.CurrentCell.ColumnIndex;
            OleDbConnection conn = new OleDbConnection(constring);      //Create connection.
            conn.Open();        //Open connection.
            //Create command and give it the query.
            OleDbCommand command = new OleDbCommand("SELECT Animal_ID, Species_ID, Kraal_ID, Tag_Code, Arrival_Date, Departure_Date, Status FROM ANIMAL WHERE Tag_Code = '" + Convert.ToString(gridViewAnimals.Rows[rowindex].Cells[columnindex].Value) + "'", conn);
            OleDbDataReader reader = command.ExecuteReader();       //Create and excecute a dataReader to read multiple values from the DB.
            reader.Read();
            string animal_ID = reader[0].ToString();        //Get animal_ID to be used later.
            string specie = reader[1].ToString();       //Get animal species_ID to be used later.
            txtKraal.Text = reader[2].ToString();       //Enter the animals current kraal.
            txtTag.Text = reader[3].ToString();     //Enter animals tag code.
            DateTime arrival = Convert.ToDateTime(reader[4].ToString());     //Enter animals arrival & departure date.
            if (reader[5].ToString() == "")
                txtDepartureDate.Text = "Not Departed.";
            else
            {
                DateTime departure = Convert.ToDateTime(reader[5].ToString());
                txtDepartureDate.Text = departure.ToString("yyyy/MM/dd");      //Enter aniaml departure date.
            }
            txtArrivalDate.Text = arrival.ToString("yyyy/MM/dd");
            txtStatus.Text = reader[6].ToString();      //Enter animals status.
            conn.Close();       //Close connection.
            txtSpecies.Text = fetchData("SELECT Description FROM SPECIES WHERE Species_ID = " + specie);        //Enter animals species description (using species_ID).
            string animal_type = fetchData("SELECT Animal_Type FROM SPECIES WHERE Species_ID = " + specie);     //Get animal_type_ID to be used later.
            txtAnimalType.Text = fetchData("SELECT Description FROM ANIMAL_TYPE WHERE Animal_Type = " + animal_type);       //Use animal_type_ID to enter animal type description.
            txtInitialWeight.Text = fetchData("SELECT Weight FROM ANIMAL_WEIGHT WHERE Date_Weighed = #" + arrival + "# AND Animal_ID = " + animal_ID);
            txtCurrentWeight.Text = fetchData("SELECT Weight FROM ANIMAL_WEIGHT WHERE Date_Weighed = (SELECT MAX(Date_Weighed) FROM ANIMAL_WEIGHT WHERE Animal_ID = " + animal_ID + ") AND Animal_ID = " + animal_ID);
            double gains = Convert.ToDouble(txtCurrentWeight.Text) - Convert.ToDouble(txtInitialWeight.Text);
            txtWeightGain.Text = gains.ToString();
            if (gains < 0)
            {
                lblGains.Text = "Weight Lost: ";
                lblGains.ForeColor = Color.Red;
            }
            else
            {
                lblGains.Text = "Weight Gained: ";
                lblGains.ForeColor = Color.Green;
            }
            /*
            */
        }

        public string fetchData(string sql)
        {
            //Method used to easily retrieve a single value from the DB.
            OleDbConnection conn = new OleDbConnection(constring);      //Create connection.
            conn.Open();        //Open connection.
            OleDbCommand command = new OleDbCommand(sql, conn);     //Create command with parameter sql statement and link to the connection.
            OleDbDataReader reader = command.ExecuteReader();       //Create and excecute reader.
            reader.Read();
            string outp = reader[0].ToString();     //Save retrieved value in variable.
            conn.Close();       //Close connection.
            return outp;        //Return output variable containing the retrieved value.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowindex = gridViewAnimals.CurrentCell.RowIndex;
            int columnindex = gridViewAnimals.CurrentCell.ColumnIndex;
            string code = Convert.ToString(gridViewAnimals.Rows[rowindex].Cells[columnindex].Value);
            string sql2 = "Delete FROM ANIMAL WHERE Tag_Code ='" + Convert.ToString(gridViewAnimals.Rows[rowindex].Cells[columnindex].Value) + "'";
            string sql1 = "Delete FROM ANIMAL_WEIGHT WHERE Date_Weighed = #" + txtArrivalDate.Text + "# AND  Animal_ID = " + txtAnimal_ID.Text+"AND Weight = "+txtInitialWeight.Text;


            DialogResult result = MessageBox.Show("Are you sure you want to delete animal " + code, "Delete " + code, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    string sql = "Delete FROM ANIMAL WHERE Tag_Code ='"+ code + "'";
            
                    OleDbConnection conn = new OleDbConnection(constring);      //Create connection.
                    conn.Open();        //Open connection.
                    OleDbCommand command = new OleDbCommand(sql, conn);
                    OleDbDataAdapter adap = new OleDbDataAdapter();

                    adap.DeleteCommand = command;
                    adap.DeleteCommand.ExecuteNonQuery();

                    command.Dispose();
                    conn.Close();
                    //Animal_ID, Species_ID, Kraal_ID, Tag_Code, Arrival_Date, Departure_Date, Status
                    display("SELECT Tag_Code FROM ANIMAL");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete animal due to database error: " + ex.Message);
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int rowindex = gridViewAnimals.CurrentCell.RowIndex;
            int columnindex = gridViewAnimals.CurrentCell.ColumnIndex;
            string sql1 = "UPDATE FarmMonitor SET Animal_ID = '"+txtAnimal_ID.Text+"' ,Species_ID  = '" + txtSpecies.Text+ "',Kraal_ID = '"+txtKraal.Text+ "',Tag_Code = '"+txtTag.Text+ "',Arrival_Date = '"+txtArrivalDate.Text+ "',Departure_Date = '"+txtDepartureDate.Text+"',Status = '"+txtStatus.Text+"' WHERE Tag_Code = '" + Convert.ToString(gridViewAnimals.Rows[rowindex].Cells[columnindex].Value) + "'";
            //Animal_ID, Species_ID, Kraal_ID, Tag_Code, Arrival_Date, Departure_Date, Status


            OleDbConnection conn = new OleDbConnection(constring);      //Create connection.
            conn.Open();        //Open connection.
            OleDbCommand command = new OleDbCommand(sql1, conn);
            OleDbDataAdapter adap = new OleDbDataAdapter();

            adap.UpdateCommand = command;
            adap.UpdateCommand.ExecuteNonQuery();

            command.Dispose();
            conn.Close();
            //Animal_ID, Species_ID, Kraal_ID, Tag_Code, Arrival_Date, Departure_Date, Status
            /* "SELECT Weight FROM ANIMAL_WEIGHT WHERE Date_Weighed = #" + txtArrivalDate.Text + "# AND Animal_ID = " + */
            display("SELECT Tag_Code FROM ANIMAL");
        }

        private void GridViewAnimals_MouseHover(object sender, EventArgs e)
        {
            gridViewAnimals.BorderStyle = BorderStyle.FixedSingle;
        }

        private void GridViewAnimals_MouseLeave(object sender, EventArgs e)
        {
            gridViewAnimals.BorderStyle = BorderStyle.None;
        }
    }
}