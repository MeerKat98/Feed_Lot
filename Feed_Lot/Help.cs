using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Monitor
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void goalOfProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Help_Load(object sender, EventArgs e)
        {
            lblHelpUserRequirements.Text = "-Animals must be sorted into weight classes.\n- Farmer must be able to see how much the animals are worth.\n- Monitor average individual intake of feed.\n- Recording of employees’ activities and responsibilities.\n- Simple database interaction.\n-Monitor all animals’ weight gains.\n-Mortality rate must be included in the report.";
            lblGoals.Text = "-Improve system processes by allowing managers to have a better understanding of the business.\n- Improve system processes by keeping an up to date record of the work done.\n- Improve system knowledge with proper reporting to be more aware of the state of business";
            lblCommonErrors.Text = "-System.InvalidOperationException: The ConnectionString property has not been initialized.\n\nTo fix this error you must initialize your connection string by going to your server explorer-- >\ndata connection-- >\nright click on FarmMonitor databse -->\nselect properties-- >\ncopy connection string and paste the string where you declare the connection string in code.";
            lblImprovements.Text = "-Automation of data and information processing.\n- More effective identification by use of bar codes.\n- Notification of irregular eating patterns, as it is an indication of illness.\n-Can include additional information to make the reporting more accurate and efficient.\n- Recording of employees’ activities and responsibilities.\n- Implemetation of mobile appliction.";
            lblDevs.Text = "NINJA DEVELOPERS\n -Devan. Email: devanmoller51 @gmail.com\n-Jumanah. Email: jumanah1998 @gmail.com\n-Ruan. Email: ruanbez1998 @gmail.com\n-Marsha. Email: marsha.fourie @gmail.com\n-Rudolph. Email: rudolphoosthuizen42 @gmail.com";
            lblHardwareRequirements.Text = "Minimum Hardware Requirements:\n-cpu: 2.56 GHz a sec.\n-4 GB RAM\n-50 MB Storage (for program files only. Additional space is required for dastabase\n\nSoftware requirements:\n-Windows 7,8 or 10\n-Access database engine 64 bit";
        }
    }
}
