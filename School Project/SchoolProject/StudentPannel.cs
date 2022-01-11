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
    public partial class StudentPannel : Form
    {
        public StudentPannel()
        {
            InitializeComponent();
        }
       // SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");
        public string SID;


        private void StudentPannel_Load(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("Select LessonName , Exam1 , Exam2, Exam3 , Project , AvaregeNote, NoteState From Table_Notes  INNER JOIN Table_Lesson on Table_Notes.NotesBranch = Table_Lesson.LessonId where StudentId = @p1",connection);
            //cmd.Parameters.AddWithValue("@p1", SID);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //connection.Close();

        }
    }
}
