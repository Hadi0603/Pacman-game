using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_game
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PACMANDataSet.hadinaeem' table. You can move, or remove it, as needed.
            this.hadinaeemTableAdapter.Fill(this.PACMANDataSet.hadinaeem);

            this.reportViewer1.RefreshReport();
        }

        private void rptPlaybtn_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Close();
        }
    }
}
