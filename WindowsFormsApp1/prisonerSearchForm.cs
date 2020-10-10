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
    public partial class prisonerSearchForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E5DQRUK;Initial Catalog=Project;Integrated Security=True");
        public prisonerSearchForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry = "select * from prisonerInfo where prisoner_PunshYears='" + punishmentYearTxt.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter daaa = new SqlDataAdapter(cmd);
            daaa.Fill(dt2);
            searchDataGridView.DataSource = dt2;
            con.Close();
            punishmentYearTxt.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            //to check if username exists before
            SqlDataAdapter ad1 = new SqlDataAdapter("select count(*)from prisonInfo where prison_name='" + prisonNameTxt.Text + "'", con);
            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                string qry = "select prison_ID from prisonInfo where prison_name='" + prisonNameTxt.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                string qry1 = "select * from prisonerInfo where prisoner_prisonID='" + dt.Rows[0][0] + "'";
                SqlCommand cmd1 = new SqlCommand(qry1, con);
                cmd.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt2);
                searchDataGridView.DataSource = dt2;
                prisonNameTxt.Text = string.Empty;
            }
            else
                MessageBox.Show("Invalid prison name, Please enter correct name");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry = "select * from prisonerInfo where prisoner_crime='" + crimeTxt.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmd);
            daa.Fill(dt1);
            searchDataGridView.DataSource = dt1;
            con.Close();
            crimeTxt.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry = "select * from prisonerInfo where prisoner_cellNumb='" + cellNumbTxt.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter daaa = new SqlDataAdapter(cmd);
            daaa.Fill(dt2);
            searchDataGridView.DataSource = dt2;
            con.Close();
            cellNumbTxt.Text = string.Empty;
        }
    }
}
