﻿using System;
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
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";
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
            txtCount.Clear();
            txtAnimalType.Clear();
            txtAvgFeed.Clear();
            txtAvgWeight.Clear();
            txtFeedType.Clear();
            txtTotalFeed.Clear();
            try
            {
                OleDbConnection con = new OleDbConnection(constring);
                con.Open();
                //Get Animal Type & Fill txtAnimal_Type with animal types description
                OleDbCommand command = new OleDbCommand("SELECT Description FROM ANIMAL_TYPE WHERE Animal_Type = " +
                    "(SELECT Animal_Type FROM KRAAL WHERE Kraal_ID = " + cmbKraal.Text + ")", con);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                txtAnimalType.Text = reader[0].ToString();
                //Get Feed_ID
                command = new OleDbCommand("SELECT Feed_ID FROM FEED_USED WHERE Kraal_ID = " + cmbKraal.Text, con);
                reader = command.ExecuteReader();
                reader.Read();
                string feedID = reader[0].ToString();
                //Fill txtFeed with the feedtype
                command = new OleDbCommand("SELECT Feed_Type FROM FEED WHERE Feed_ID = " + feedID, con);
                reader = command.ExecuteReader();
                reader.Read();
                txtFeedType.Text = reader[0].ToString();
                //Get total feed used => txtTotalFeed
                command = new OleDbCommand("SELECT SUM(Feed_Amount) FROM FEED_USED WHERE Kraal_ID = " + cmbKraal.Text, con);
                reader = command.ExecuteReader();
                reader.Read();
                txtTotalFeed.Text = reader[0].ToString();
                //Get animal count from kraal => txtCount
                command = new OleDbCommand("SELECT COUNT(Tag_Code) FROM ANIMAL WHERE Kraal_ID = " + cmbKraal.Text, con);
                reader = command.ExecuteReader();
                reader.Read();
                txtCount.Text = reader[0].ToString();
                //Get avg weight per kraal => txtAvgWeight
                command = new OleDbCommand("SELECT AVG(Weight) FROM " +
                    "(SELECT ANIMAL.Animal_ID, ANIMAL_WEIGHT.Weight FROM ANIMAL INNER JOIN ANIMAL_WEIGHT ON ANIMAL.Animal_ID = ANIMAL_WEIGHT.Animal_ID " +
                    "WHERE ANIMAL.Kraal_ID = " + cmbKraal.Text + ")", con);
                reader = command.ExecuteReader();
                reader.Read();
                txtAvgWeight.Text = Math.Round(Convert.ToDouble(reader[0]),2).ToString();
                //Fill datagridview with animals that are in the selected kraal
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT Tag_Code FROM ANIMAL WHERE Kraal_ID = " + cmbKraal.Text, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "fill");
                dataGridAnimalsInKraal.DataSource = ds;
                dataGridAnimalsInKraal.DataMember = "fill";
                con.Close();
                txtAvgFeed.Text = Convert.ToString(Convert.ToInt32(txtTotalFeed.Text) / Convert.ToInt32(txtCount.Text));
            }
            catch (Exception ex)
            {
                if (ex.Message != "No value given for one or more required parameters.")
                    MessageBox.Show(ex.Message);
            }
        }

        private void DataGridAnimalsInKraal_MouseEnter(object sender, EventArgs e)
        {
            dataGridAnimalsInKraal.BorderStyle = BorderStyle.FixedSingle;
        }

        private void DataGridAnimalsInKraal_MouseLeave(object sender, EventArgs e)
        {
            dataGridAnimalsInKraal.BorderStyle = BorderStyle.None;
        }

        private void DataGridAnimalsInKraal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
