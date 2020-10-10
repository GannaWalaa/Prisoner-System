using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminManageChooseForm : Form
    {
        public adminManageChooseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateOfficerInfoForm f2 = new updateOfficerInfoForm();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatePrisonInfoForm f3 = new updatePrisonInfoForm();
            f3.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
