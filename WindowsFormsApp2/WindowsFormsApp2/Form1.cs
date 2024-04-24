
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string CONNECTION_STRING = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\isilu\OneDrive\Masaüstü\APP PROJECT\WindowsFormsApp2\WindowsFormsApp2\databaseofmusicapp.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.ToString();
            if (String.IsNullOrEmpty(username))
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed!", "You cannot continue", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Users WHERE username = '" + username + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Form2 form2 = new Form2();
                        form2.Show(); this.Hide();

                        //MessageBox.Show("User found for id:" + reader.GetInt32(0));
                    }
                }
                else
                {
                    MessageBox.Show("UsernameIncorrect");
                }
                //MessageBox.Show("Connection Successful!");
                conn.Close();
            }
        }
    }
}
