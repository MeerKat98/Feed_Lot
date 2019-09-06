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

        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Farm_Monitor\FarmMonitor.accdb";

        public frmNew_Animal()
        {
            InitializeComponent();
            populate(connectionString, cmbKraal,"KRAAL","Kraal_ID");
            populate(connectionString, cmbSpecies, "SPECIES", "Description");
            populate(connectionString, cmbAnimalType, "ANIMAL_TYPE", "Description");
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
            
        }

        private void BtnAddAnimal_Click(object sender, EventArgs e)
        {
            addAnimal();
        }

        private void FrmNew_Animal_Load(object sender, EventArgs e)
        {
            
        }
      
        public void populate(string connection, ComboBox cmb, string table, string field)
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select "+ field +" from " + table, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cmb.DataSource = ds.Tables[0];
            cmb.DisplayMember = field;
            cmb.ValueMember = field;
        }


        private void BtnAddType_Click(object sender, EventArgs e)
        {
            New_Animal_Type childForm = new New_Animal_Type();

            childForm.ShowDialog(this);
        }

        private void BtnAddSpecies_Click(object sender, EventArgs e)
        {
            New_Species childForm = new New_Species();

            childForm.ShowDialog(this);
        }

        
        public void addAnimal()
        {   //Error code values 
            int cmdError, cmdError2;

            //Date code stamps creation in dateonly 
            //Use .toString(y/d/m)
            DateTime dt = DateTime.Now;
            DateTime dateOnly = dt.Date;

            //Inserting of animal with details into Animal Table
            string cmdQuery = "INSERT INTO ANIMAL (Species_ID,Kraal_ID,Tag_Code,Arrival_Date) VALUES (@Species_ID,@Kraal_ID,@Tag_Code,@Arrival_Date)";
            
            //Inserting of animal weight and weighed date with animal_id generated with cmdQuery1
            string cmdQuery2 = "INSERT INTO ANIMAL_WEIGHT (Animal_ID,Date_Weighed,Weight) VALUES (@Animal_ID,@Date_Weighed,@Weight)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(cmdQuery, connection))
                {
                    try{
                        connection.Open();
                    }
                    catch (Exception ex){
                        Console.Out.WriteLine("Database Connection Error code:" + ex);
                    }

                    OleDbCommand command = new OleDbCommand("SELECT Species_ID FROM SPECIES WHERE Description ='" + cmbSpecies.Text + "'", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();

                    cmd.Parameters.AddWithValue("@Species_ID", reader[0]);
                    cmd.Parameters.AddWithValue("@Kraal_ID", cmbKraal.Text);
                    cmd.Parameters.AddWithValue("@Tag_Code", txtTagCode.Text);
                    cmd.Parameters.AddWithValue("@Arrival_Date", dateOnly.ToString("yyyy/MM/dd"));
                    cmdError = (int)cmd.ExecuteNonQuery();

                    
                }
                using(OleDbCommand cmd = new OleDbCommand(cmdQuery2, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        Console.Out.WriteLine("Database Connection Error code:" + ex);
                    }

                    OleDbCommand command = new OleDbCommand("SELECT Animal_ID FROM ANIMAL WHERE Tag_Code ='" + txtTagCode.Text + "'", connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    reader.Read();

                   
                    cmd.Parameters.AddWithValue("@Animal_ID", reader[0]);
                    cmd.Parameters.AddWithValue("@Weighed_Date", dateOnly.ToString("yyyy/MM/dd"));
                    cmd.Parameters.AddWithValue("@Weight", txtWeight.Text);
                    if(cmdError > 0)
                    cmdError2 = (int)cmd.ExecuteNonQuery();
                }
            }
            if (cmdError > 0)
                MessageBox.Show("Success, Animal has been addded to the database.");
            else
                MessageBox.Show("Failed, Animal could not be added to database.\nPlease check database availabilty and privileges");
        }

        private void frmNew_Animal_Load_1(object sender, EventArgs e)
        {

        }
    }
}