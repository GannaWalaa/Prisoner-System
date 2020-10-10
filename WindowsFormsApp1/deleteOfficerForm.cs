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
    public partial class deleteOfficerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E5DQRUK;Initial Catalog=Project;Integrated Security=True");
        int selectedRow;
        public deleteOfficerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry = "select officer_ID,officer_name from officerInfo where officer_name='" + officerNameTxt.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            officerDataGridView.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            con.Open();
            string qry = "select count(*) from officerInfo where officer_ID ='" + Convert.ToInt32(officerIDTxt.Text) + "'";
            SqlDataAdapter ad = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                string qry2 = "delete from Userlogin where off_ID='" + Convert.ToInt32(officerIDTxt.Text) + "'";
                SqlCommand cmd1 = new SqlCommand(qry2, con);
                cmd1.ExecuteNonQuery();
                qry = "delete from officerInfo where officer_ID='" + Convert.ToInt32(officerIDTxt.Text) + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
           
                MessageBox.Show("data is deleted");
                int rowindex = officerDataGridView.CurrentCell.RowIndex;
                officerDataGridView.Rows.RemoveAt(rowindex);
                officerNameTxt.Clear();
                officerIDTxt.Clear();
            }
            else
                MessageBox.Show("Please enter right data to delete");
            con.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = officerDataGridView.Rows[selectedRow];
            officerIDTxt.Text = row.Cells[0].Value.ToString();
        }
    }
    }
