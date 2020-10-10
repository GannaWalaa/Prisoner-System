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
    public partial class LoginForm : Form
    {
        string str = "Data Source=DESKTOP-E5DQRUK;Initial Catalog=Project;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "select count(*) from UserLogin where username ='" + usernameTxt.Text + "'and userPassword='" + passwordTxt.Text ;
            if (officerRdoBtn.Checked == true)
            {
                qry += "'and userState='Officer'";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //this.Hide();
                    officerNextProcedureForm newForm = new officerNextProcedureForm();
                    newForm.Show();
                }
                else
                    MessageBox.Show("Error username/password please try again");
                con.Close();
            }
            else if (adminRdoBtn.Checked == true)
            {
                qry += "'and userState='Admin'";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    //this.Hide();
                    adminManageChooseForm newForm = new adminManageChooseForm();
                    newForm.Show();
                }
                else
                    MessageBox.Show("Error username/password please try again");
                con.Close();
            }
            else
                MessageBox.Show("Error, Please choose you are an officer or admin");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
