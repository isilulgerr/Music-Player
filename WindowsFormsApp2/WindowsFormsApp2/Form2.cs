using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string CONNECTION_STRING = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\isilu\OneDrive\Masaüstü\APP PROJECT\WindowsFormsApp2\WindowsFormsApp2\databaseofmusicapp.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click_1(object sender, EventArgs e)
        {
            string playlist_name, playlist_description;
            playlist_name = textboxplaylistname.Text.ToString();
            playlist_description = textboxplaylistdescription.Text.ToString();

            if (String.IsNullOrEmpty(playlist_name) || string.IsNullOrEmpty(playlist_description))
            {
                MessageBox.Show("No empty fields.");
            }
            else
            {

                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Playlists(playlistName, description) VALUES ('" + playlist_name + "','" + playlist_description + "')";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    showDataPlaylists();
                    MessageBox.Show("you created a new playlits succesfully");
                    textboxplaylistdescription.Text = "";
                    textboxplaylistname.Text = "";
                }
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showDataLikedTracks();
            showDataPlaylists();
            showDataTopArtist();
        }

        private void showDataTopArtist()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Artists order by placementInWorld ASC", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void showDataPlaylists() {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Playlists ", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewPlaylists.DataSource = dt;
        }

        private void showDataLikedTracks()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("select * from Userlikedtrack ", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewLikedTracks.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool albumSearchSelected = radioButtonAlbum.Checked;
            bool trackSearchSelected = radioButtonTrack.Checked;
            bool artistSearchSelected = radioButtonArtist.Checked;
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string searched = textBox1.Text.ToString();
            if (albumSearchSelected)
            {

                try {
                    adpt = new SqlDataAdapter("select * from Albums where albumName = '" + searched + "' ", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearchResults.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (trackSearchSelected)
            {
                try
                {
                    adpt = new SqlDataAdapter("select * from Tracks where title = '"+searched+"' ", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearchResults.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (artistSearchSelected)
            {
                try
                {
                    adpt = new SqlDataAdapter("select * from Artists where artistName = '" + searched + "' ", conn);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewSearchResults.DataSource = dt;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);



                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string playlist_name, playlist_description;
            playlist_name = textboxplaylistname.Text.ToString();
            playlist_description = textboxplaylistdescription.Text.ToString();

            if (String.IsNullOrEmpty(playlist_name) || string.IsNullOrEmpty(playlist_description))
            {
                MessageBox.Show("No empty fields.");
            }
            else
            {

                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM Playlists WHERE playlistName = '" + playlist_name + "'AND description = '" + playlist_description + "'";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    showDataPlaylists();
                    MessageBox.Show("you deleted a playlits succesfully");
                    textboxplaylistdescription.Text = "";
                    textboxplaylistname.Text = "";
                }
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string playlist_name, playlist_description;
            playlist_name = textboxplaylistname.Text.ToString();
            playlist_description = textboxplaylistdescription.Text.ToString();

            if (String.IsNullOrEmpty(playlist_name) || string.IsNullOrEmpty(playlist_description))
            {
                MessageBox.Show("No empty fields.");
            }
            else
            {

                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Playlists SET description = '" + playlist_description + "' WHERE playlistName = '" + playlist_name + "'  ";
                cmd.Connection = conn;
                int a = cmd.ExecuteNonQuery();
                conn.Close();
                if (a > 0)
                {
                    showDataPlaylists();
                    MessageBox.Show("you changed the description of playlist successfully.");
                    textboxplaylistdescription.Text = "";
                    textboxplaylistname.Text = "";
                }
            }
        }

        
    } }
