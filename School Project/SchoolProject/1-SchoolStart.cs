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
    public partial class SchoolStart : Form
    {
        public SchoolStart()
        {
            InitializeComponent();
        }

        private void TLoginButton_Click(object sender, EventArgs e)
        {
            TeacherLogin fr = new TeacherLogin();
            fr.Show();
            this.Hide();
        }

        private void SLoginButton_Click(object sender, EventArgs e)
        {
            StudentLogin fr = new StudentLogin();
            fr.Show();
            this.Hide();
        }

        
    }
}
