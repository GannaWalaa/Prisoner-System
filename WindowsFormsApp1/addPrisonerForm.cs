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
    public partial class addPrisonerForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E5DQRUK;Initial Catalog=Project;Integrated Security=True");
        public addPrisonerForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string qry = "select count(*) from prisonerInfo where prisoner_ID = " + idTxt.Text + "";
            SqlDataAdapter ad1 = new SqlDataAdapter(qry, con);
            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
                MessageBox.Show("ID already Exists, Choose another one");
            else
            {
                string qry2 = "select count(*) from prisonInfo where prison_name = '" + prisonNameTxt.Text + "'";
                SqlDataAdapter ad2 = new SqlDataAdapter(qry2, con);
                DataTable dt2 = new DataTable();
                ad2.Fill(dt2);
                if (dt2.Rows[0][0].ToString() == "1")
                {

                    string qry1 = "select prison_ID from prisonInfo where prison_name='" + prisonNameTxt.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry1, con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                   DataTable dt = new DataTable();
                    da.Fill(dt);

                    qry = "insert into prisonerInfo values('" + Convert.ToInt32(idTxt.Text) + "','" + nameTxt.Text + "','" + Convert.ToInt32(cellNumbTxt.Text) + "','" + crimeTxt.Text + "','" + Convert.ToInt32(punishmentTxt.Text) + "','" + dt.Rows[0][0] + "','" + Convert.ToInt32(ageTxt.Text) + "','"+prisonDateTxt.Text+"')";
                    SqlCommand cmd1 = new SqlCommand(qry, con);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Data added");
                }
                else
                    MessageBox.Show("Invalid prison name,Please enter correct name");
            }
            con.Close();

        }
    }
}
