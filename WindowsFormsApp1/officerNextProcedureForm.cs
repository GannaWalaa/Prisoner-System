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
    public partial class officerNextProcedureForm : Form
    {
        public officerNextProcedureForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            prisonerSearchForm f5 = new prisonerSearchForm();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            updatePrisonCellNumbForm f7 = new updatePrisonCellNumbForm();
            f7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addPrisonerForm f10 = new addPrisonerForm();
            f10.Show();
        }
    }
}
