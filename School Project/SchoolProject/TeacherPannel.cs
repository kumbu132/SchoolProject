using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class TeacherPannel : Form
    {
        public TeacherPannel()
        {
            InitializeComponent();
        }
        public string tıd1;
        private void ClubButton(object sender, EventArgs e)
        {
            
        }

        private void LessonButton(object sender, EventArgs e)
        {
            MLesson fr = new MLesson();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MStudent fr = new MStudent();

            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TNote fr = new TNote();
            fr.tId = tıd1;
            fr.Show();
        }
    }
}
