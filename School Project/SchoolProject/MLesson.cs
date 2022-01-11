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
    public partial class MLesson : Form
    {
        public MLesson()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");
        void list()
        {
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("Select * From Table_Lesson", connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            list();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("insert into Table_Lesson (LessonName) values (@p1)", connection);
            cmd2.Parameters.AddWithValue("@p1", textBox2.Text);
            cmd2.ExecuteNonQuery();
            connection.Close();

            list();
        }

             

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
        }

        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("delete from Table_Lesson where LessonId= @p1", connection);
            cmd3.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd3.ExecuteNonQuery();
            connection.Close();

            list();
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("update Table_Lesson set LessonName = @p1 where LessonId=@p2", connection);
            cmd3.Parameters.AddWithValue("@p1", textBox2.Text);
            cmd3.Parameters.AddWithValue("@p2", textBox1.Text);
            cmd3.ExecuteNonQuery();
            connection.Close();

            list();
        }

        private void quitbutton(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
