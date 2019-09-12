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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MeerKat\Documents\GitRepos\Feed_Lot\FarmMonitor.accdb";
        string animal_ID;
        string searchExpression = "ID = 5";
        private void btnsearch_Click(object sender, EventArgs e)
        {
            errblanktag.Clear();
            if (tbxtag.Text == "")
            {
                errblanktag.SetError(tbxtag, "This field cannot be empty!");
            }
            display("SELECT * FROM ANIMAL WHERE Tag_Code LIKE '%" + tbxtag.Text + "%'");      //Update the dataGridView to only contain items simelar to the text in the seatch textbox.
            display2("SELECT Date_Weighed, Weight FROM ANIMAL_WEIGHT WHERE Tag_Code LIKE '%" + tbxtag.Text + "%'");      //Update the dataGridView to only contain items simelar to the text in the seatch textbox.
        }
        public void display(string sql)
        {
            OleDbConnection conn = new OleDbConnection(constring);      //Create connection to DB.
            conn.Open();        //Open connection.
            OleDbDataAdapter adap = new OleDbDataAdapter(sql, conn);        //Create adapter with sql command and link to connection.
            DataSet ds = new DataSet();     //Create dataset.
            adap.Fill(ds, "fill");      //Fill the Datagrid view.
            conn.Close();       //Close connection.
            datagridviewreport.DataSource = ds;        //Specify gridView's datasource and datamember.
            datagridviewreport.DataMember = "fill";

            //the column- and row-index 
                
                label3.Visible = true;
                int rowindex = datagridviewweight.CurrentCell.RowIndex;
          

                string currentdate = Convert.ToString(datagridviewweight.Rows[rowindex].Cells[1].Value);
                int currentweight = Convert.ToInt16(datagridviewweight.Rows[rowindex].Cells[2].Value);
                string startdate =Convert.ToString(datagridviewreport.Rows[1].Cells[5].Value);
                DataGridViewCell cell = GetCellWhereTextExistsInGridView(startdate, datagridviewweight, 1);
                int startweight = Convert.ToInt16(datagridviewreport.Rows[cell.RowIndex].Cells[2].Value);
                DateTime enddate = Convert.ToDateTime(currentdate);
                DateTime begdate = Convert.ToDateTime(startdate);
                TimeSpan period = enddate - begdate;
                int weight = currentweight - startweight;

                if (weight > 0)
                    label5.Text = "The animal has gained " + weight + "kg for the period of" + period;
            

           
        }
        private DataGridViewCell GetCellWhereTextExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell cellWhereTextIsMet = null;

            // For every row in the grid (obviously)
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // I did not test this case, but cell.Value is an object, and objects can be null
                // So check if the cell is null before using .ToString()
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    // the searchText is equals to the text in this cell.
                    cellWhereTextIsMet = row.Cells[columnIndex];
                    break;
                }
            }

            return cellWhereTextIsMet;
        }
        private void display2(string sql)
        {
            OleDbConnection conn = new OleDbConnection(constring);      //Create connection to DB.
            conn.Open();        //Open connection.
            OleDbDataAdapter adap = new OleDbDataAdapter(sql, conn);        //Create adapter with sql command and link to connection.
            DataSet ds = new DataSet();     //Create dataset.
            adap.Fill(ds, "fill");      //Fill the Datagrid view.
            conn.Close();       //Close connection.
            datagridviewweight.DataSource = ds;        //Specify gridView's datasource and datamember.
            datagridviewweight.DataMember = "fill";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
