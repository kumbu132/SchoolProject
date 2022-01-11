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
using System.Net;
using System.IO;
using RestSharp;
using System.Net.Http;

namespace SchoolProject
{
   
    public partial class TeacherLogin : Form
    {
        
        public TeacherLogin()
        {
            InitializeComponent();
        

        }
        SqlConnection connection = new SqlConnection(@"Data Source=YAVUZ;Initial Catalog=School_Project;Integrated Security=True");


        private void SLoginButton_Click(object sender, EventArgs e)
        {
            //string postData = "user_id"+textBox1.Text + textBox2.Text;
            //APIHandler apiIHandler = new APIHandler();


            //apiIHandler.webPostMethod(postData, "http://192.168.8.136:1337/api/students");

            var client = new RestClient("http://192.168.8.136:1337/api/students");
           // HttpClient = -1; 
            var request = new RestRequest();
            request.Method = Method.Post;
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-Type", "application/json");
            var body = new { A = "username" };
            request.AddJsonBody(body);
                request.AddParameter("application/json", ParameterType.RequestBody);
            var  response = client.ExecutePostAsync(request);
           // Console.WriteLine(response.Content);

            //connection.Open();
            //SqlCommand cmd1 = new SqlCommand("Select * From Table_Teacher where TeacherId=@p1 and TeacherPassword=@p2", connection);
            //cmd1.Parameters.AddWithValue("@p1", textBox1.Text);
            //cmd1.Parameters.AddWithValue("@p2", textBox2.Text);
            //SqlDataReader dr = cmd1.ExecuteReader();
            //if (dr.Read())
            //{
            //    TeacherPannel fr = new TeacherPannel();
            //    fr.tıd1 = textBox1.Text;
            //    fr.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Password or Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchoolStart fr = new SchoolStart();
            fr.Show();
        }
    }
}
