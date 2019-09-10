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
    public partial class frmNew_Animal : Form
    {

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";
        double weight;

        public frmNew_Animal()
        {
            InitializeComponent();
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            Boolean gudData = true;
            Boolean tagNotTaken = true;
            errInvalidWeight.Clear();
            errInvalidTag.Clear();
            errInvalidAnimalType.Clear();
            if (txtTagCode.Text == "")
            {
                errInvalidTag.SetError(txtTagCode,"This field cannot be empty!");
                gudData = false;
            }
            if (txtWeight.Text == "")
            {
                errInvalidWeight.SetError(txtWeight, "This field cannot be empty!");
                gudData = false;
            }
            else
            { 
                try
                {
                    weight = Convert.ToDouble(txtWeight.Text);
                }
                catch (Exception ex)
                {
                    errInvalidWeight.SetError(txtWeight, "Invalid Weight! " + ex.Message + "\nNote: Decimals should be indicated with a comma(,)");
                    gudData = false;
                }
            }

            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            OleDbCommand command = new OleDbCommand("SELECT Tag_Code FROM ANIMAL", conn);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == txtTagCode.Text)
                {
                    tagNotTaken = false;
                    errInvalidTag.SetError(txtTagCode,"Another animal already has this tag code!");
                }
            }
            conn.Close();
            if (gudData && tagNotTaken)
            {
                addAnimal();
            }
        }

        private void FrmNew_Animal_Load(object sender, EventArgs e)
        {
            
        }
      
        public void populate(ComboBox cmb, string sql, string field)
        {
            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = field;
            cmb.ValueMember = field;
            con.Close();
        }


        private void BtnAddType_Click(object sender, EventArgs e)
        {
            New_Animal_Type childForm = new New_Animal_Type();
            childForm.ShowDialog(this);
            populate(cmbAnimalType, "SELECT Description FROM ANIMAL_TYPE ORDER BY Description", "Description");
        }

        private void BtnAddSpecies_Click(object sender, EventArgs e)
        {
            New_Species childForm = new New_Species();
            childForm.ShowDialog(this);
            populate(cmbSpecies, "SELECT Description FROM SPECIES WHERE Animal_Type = (SELECT Animal_Type FROM ANIMAL_TYPE WHERE Description = '" + cmbAnimalType.Text + "')", "Description");
        }


        public void addAnimal()
        {   //Error code values 
            int cmdError = 1;

            //Date code stamps creation in dateonly 
            //Use .toString(y/d/m)
            DateTime dt = DateTime.Now;
            DateTime dateOnly = dt.Date;

            //Inserting of animal with details into Animal Table
            string cmdQuery = "INSERT INTO ANIMAL (Species_ID,Kraal_ID,Tag_Code,Arrival_Date,Status) VALUES (@Species_ID,@Kraal_ID,@Tag_Code,@Arrival_Date,@Status)";            
            //Inserting of animal weight and weighed date with animal_id generated with cmdQuery1
            string cmdQuery2 = "INSERT INTO ANIMAL_WEIGHT (Animal_ID,Date_Weighed,Weight) VALUES (@Animal_ID,@Date_Weighed,@Weight)";

            if (cmbKraal.Text == "")
            {
                DialogResult result = MessageBox.Show("There is no kraal allocated for this animal type. Would you like the system to create a new kraal for " + cmbAnimalType.Text + "?", "No Kraal for " + cmbAnimalType.Text, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        OleDbConnection conn = new OleDbConnection(connectionString);
                        conn.Open();
                        OleDbCommand commandKraal = new OleDbCommand("SELECT Animal_Type FROM ANIMAL_Type WHERE Description = '" + cmbAnimalType.Text + "'", conn);
                        OleDbDataReader readerKraal = commandKraal.ExecuteReader();
                        readerKraal.Read();
                        string animalType = readerKraal[0].ToString();
                        commandKraal = new OleDbCommand("INSERT INTO KRAAL (Animal_Type) VALUES (@Animal_Type)", conn);
                        commandKraal.Parameters.AddWithValue("@Animal_Type", animalType);
                        commandKraal.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Kraal created succesfully");
                        populate(cmbKraal, "SELECT Kraal_ID FROM KRAAL WHERE Animal_Type = (SELECT Animal_Type FROM ANIMAL_TYPE WHERE description = '" + cmbAnimalType.Text + "')", "Kraal_ID");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not create new kraal due to an error :" + ex.Message);
                    }
                }
            }

            if (cmbKraal.Text == "")
                errInvalidAnimalType.SetError(cmbKraal, "This field cannot be empty!");
            else
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand(cmdQuery, connection))
                    {
                        try{
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT Species_ID FROM SPECIES WHERE Description ='" + cmbSpecies.Text + "'", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            reader.Read();

                            cmd.Parameters.AddWithValue("@Species_ID", reader[0]);
                            cmd.Parameters.AddWithValue("@Kraal_ID", cmbKraal.Text);
                            cmd.Parameters.AddWithValue("@Tag_Code", txtTagCode.Text);
                            cmd.Parameters.AddWithValue("@Arrival_Date", dateOnly.ToString("yyyy/MM/dd"));
                            cmd.Parameters.AddWithValue("@Status", "ALIVE");
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex){
                            Console.Out.WriteLine("Database Connection Error code:" + ex);
                        } 
                    }
                    using(OleDbCommand cmd = new OleDbCommand(cmdQuery2, connection))
                    {
                        try
                        {
                            connection.Open();
                            OleDbCommand command = new OleDbCommand("SELECT Animal_ID FROM ANIMAL WHERE Tag_Code ='" + txtTagCode.Text + "'", connection);
                            OleDbDataReader reader = command.ExecuteReader();
                            reader.Read();


                            cmd.Parameters.AddWithValue("@Animal_ID", reader[0]);
                            cmd.Parameters.AddWithValue("@Weighed_Date", dateOnly.ToString("yyyy/MM/dd"));
                            cmd.Parameters.AddWithValue("@Weight", txtWeight.Text);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.Out.WriteLine("Database Connection Error code:" + ex);
                        }  
                    }
                }
                if (cmdError > 0)
                    MessageBox.Show("Success, Animal has been addded to the database.");
                else
                    MessageBox.Show("Failed, Animal could not be added to database.\nPlease check database availabilty and privileges");
                txtTagCode.Clear();
                txtWeight.Clear();
                cmbAnimalType.SelectedIndex = 0;
                cmbKraal.SelectedIndex = 0;
                cmbSpecies.SelectedIndex = 0;
            }
        }

        private void FrmNew_Animal_Load_1(object sender, EventArgs e)
        {
            populate(cmbAnimalType, "SELECT Description FROM ANIMAL_TYPE ORDER BY Description", "Description");
        }

        private void CmbKraal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnimalType.Text != "System.Data.DataRowView")
            {
                cmbKraal.Text = "";
                populate(cmbKraal, "SELECT Kraal_ID FROM KRAAL WHERE Animal_Type = (SELECT Animal_Type FROM ANIMAL_TYPE WHERE description = '" + cmbAnimalType.Text + "')", "Kraal_ID");
                populate(cmbSpecies, "SELECT Description FROM SPECIES WHERE Animal_Type = (SELECT Animal_Type FROM ANIMAL_TYPE WHERE Description = '" + cmbAnimalType.Text + "')", "Description");
            }
        }
    }
}