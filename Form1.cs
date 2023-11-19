using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NewTims
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new("SELECT * FROM Student", "server = (LOCAL); database = Avinash; trusted_connection = true; Encrypt=False");
            DataSet ds = new();
            da.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new("server = (Local); database = Avinash; trusted_connection = true; Encrypt=False");
            con.Open();
            string qur = "INSERT INTO Student VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";

            SqlCommand cmd = new(qur, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted sucessfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}