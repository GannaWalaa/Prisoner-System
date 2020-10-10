using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class updatePrisonInfoForm : Form
    {
        string str = "Data Source=DESKTOP-E5DQRUK;Initial Catalog=Project;Integrated Security=True";
        public updatePrisonInfoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string qry = "select count(*) from prisonInfo where prison_ID = " + IDTxt.Text + "";
            SqlDataAdapter ad = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
                MessageBox.Show("ID already Exists, Choose another one");
            else
            {
                SqlCommand cmd = new SqlCommand("insert into prisonInfo values(" + IDTxt.Text + ", '" + nameTxt.Text + "', '" + placeTxt.Text + "', " + capacityTxt.Text + ",'"+Convert.ToInt32(amountOfCellTxt.Text)+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is added successfully!");
            }
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            this.Hide();
            prisonForm f9 = new prisonForm();
            f9.Show();
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}