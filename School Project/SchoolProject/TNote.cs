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
    public partial class TNote : Form
    {
        public TNote()
        {
            InitializeComponent();
        }
        public string tId;
        public string lessonId;
        public double avg;
        SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");
        //SchoolDataSetTableAdapters.DataTable1TableAdapter adapter = new SchoolDataSetTableAdapters.DataTable1TableAdapter();
        private void TNote_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select  TeacherBranch, TeacherName from Table_Teacher where TeacherId = @p1", connection);
            cmd.Parameters.AddWithValue("@p1",tId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                lessonId = dr[0].ToString();
                TeacherNameLbl.Text = dr[1].ToString();
            }
            connection.Close();
            //dataGridView1.DataSource = adapter.ListNotes(byte.Parse(tId));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
        //  dataGridView1.DataSource = adapter.SearchStudent(byte.Parse(tId),int.Parse(IDtextBox1.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            IDtextBox1.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            NametextBox2.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            Exam1textBox1.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString(); 
            Exam2Textbox.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            Exam3TextBox.Text = dataGridView1.Rows[choosen].Cells[6].Value.ToString(); 
            ProjectTextBox.Text = dataGridView1.Rows[choosen].Cells[7].Value.ToString();
           // NoteAvgTextBox.Text = dataGridView1.Rows[choosen].Cells[8].Value.ToString();

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //adapter.UpdateNotes(byte.Parse(Exam1textBox1.Text), byte.Parse(Exam2Textbox.Text), byte.Parse(Exam3TextBox.Text), byte.Parse(ProjectTextBox.Text), int.Parse(IDtextBox1.Text));
           // adapter.UpdateLastState(decimal.Parse(avg.ToString()), bool.Parse(StateLabel.Text), int.Parse(IDtextBox1.Text));
          //  dataGridView1.DataSource = adapter.ListNotes(byte.Parse(tId));
        }

        private void CalculeteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int e1 = Convert.ToInt16(Exam1textBox1.Text);
                int e2 = Convert.ToInt16(Exam2Textbox.Text);
                int e3 = Convert.ToInt16(Exam3TextBox.Text);
                int p = Convert.ToInt16(ProjectTextBox.Text);

                avg = (e1 + e2 + e3 + p) / 4;
               // NoteAvgTextBox.Text = avg.ToString();
                if (avg >= 45)
                {
                    StateLabel.Text = "True";
                }
                else { StateLabel.Text = "False"; }
            }
            catch 
            {
                MessageBox.Show("Invalid Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            IDtextBox1.Text = null;
            NametextBox2.Text = null;
            Exam1textBox1.Text = null;
            Exam2Textbox.Text = null;
            Exam3TextBox.Text = null;
            ProjectTextBox.Text = null;
            //NoteAvgTextBox.Text = null;        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
