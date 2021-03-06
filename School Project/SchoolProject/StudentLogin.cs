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
namespace SchoolProject
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolStart fr = new SchoolStart();
            fr.Show();
        }

        private void SLoginButton_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From Table_Student where StudentId=@p1 and StudentPassword=@p2", connection);
            cmd1.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd1.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                StudentPannel fr = new StudentPannel();
                fr.SID = textBox1.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password or Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
