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
    public partial class MStudent : Form
    {
        public MStudent()
        {
            InitializeComponent();
        }
        public string gender = " ";
      
        SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");
        //SchoolDataSetTableAdapters.SchoolTableTableAdapter schoolTables = new SchoolDataSetTableAdapters.SchoolTableTableAdapter();
        private void TStudent_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select * From Table_Club", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
           


        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

          
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            IDtextBox1.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            NametextBox2.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
           
            gender = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            if (gender == "Kız") radioButton1.Checked = true;
            if (gender == "Erkek") radioButton2.Checked = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

            if (radioButton2.Checked == true) gender = "Erkek";
            if (radioButton1.Checked == true) gender = "Kız";
          // schoolTables.AddStudent(NametextBox2.Text, byte.Parse(ClubcomboBox1.SelectedValue.ToString()), gender);
           // dataGridView1.DataSource = schoolTables.ListStudent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete From Table_Student where StudentId= @p1", connection);
            cmd.Parameters.AddWithValue("@p1", IDtextBox1.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
          //  dataGridView1.DataSource = schoolTables.ListStudent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //schoolTables.UpdateStudent(NametextBox2.Text, gender, byte.Parse(ClubcomboBox1.SelectedValue.ToString()), int.Parse(IDtextBox1.Text));
           // dataGridView1.DataSource = schoolTables.ListStudent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) gender = "Kız";
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) gender = "Erkek";
                
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = schoolTables.ListStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = schoolTables.GetDataBy3(int.Parse(SearchtextBox4.Text));
            
        }
    }
}
