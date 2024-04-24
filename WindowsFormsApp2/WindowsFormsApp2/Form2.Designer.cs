namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxplaylistname = new System.Windows.Forms.TextBox();
            this.textboxplaylistdescription = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewLikedTracks = new System.Windows.Forms.DataGridView();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.radioButtonTrack = new System.Windows.Forms.RadioButton();
            this.radioButtonAlbum = new System.Windows.Forms.RadioButton();
            this.radioButtonArtist = new System.Windows.Forms.RadioButton();
            this.dataGridViewPlaylists = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikedTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEARCH TRACK,ALBUM,ARTIST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(689, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREATE PLAYLIST AND VIEW:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(377, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(20, 106);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.RowHeadersWidth = 62;
            this.dataGridViewSearchResults.RowTemplate.Height = 28;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(615, 136);
            this.dataGridViewSearchResults.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(689, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(689, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DESCRIPTION:";
            // 
            // textboxplaylistname
            // 
            this.textboxplaylistname.Location = new System.Drawing.Point(830, 47);
            this.textboxplaylistname.Name = "textboxplaylistname";
            this.textboxplaylistname.Size = new System.Drawing.Size(250, 26);
            this.textboxplaylistname.TabIndex = 7;
            // 
            // textboxplaylistdescription
            // 
            this.textboxplaylistdescription.Location = new System.Drawing.Point(830, 82);
            this.textboxplaylistdescription.Name = "textboxplaylistdescription";
            this.textboxplaylistdescription.Size = new System.Drawing.Size(250, 26);
            this.textboxplaylistdescription.TabIndex = 8;
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.insertbutton.Location = new System.Drawing.Point(1098, 61);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(90, 39);
            this.insertbutton.TabIndex = 9;
            this.insertbutton.Text = "INSERT";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(3, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "LIKED TRACKS:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewLikedTracks);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(20, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 341);
            this.panel1.TabIndex = 11;
            // 
            // dataGridViewLikedTracks
            // 
            this.dataGridViewLikedTracks.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridViewLikedTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLikedTracks.Location = new System.Drawing.Point(0, 51);
            this.dataGridViewLikedTracks.Name = "dataGridViewLikedTracks";
            this.dataGridViewLikedTracks.RowHeadersWidth = 62;
            this.dataGridViewLikedTracks.RowTemplate.Height = 28;
            this.dataGridViewLikedTracks.Size = new System.Drawing.Size(615, 261);
            this.dataGridViewLikedTracks.TabIndex = 11;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.updatebutton.Location = new System.Drawing.Point(1098, 106);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(90, 41);
            this.updatebutton.TabIndex = 12;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deletebutton.Location = new System.Drawing.Point(1098, 17);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(90, 38);
            this.deletebutton.TabIndex = 13;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // radioButtonTrack
            // 
            this.radioButtonTrack.AutoSize = true;
            this.radioButtonTrack.Location = new System.Drawing.Point(20, 76);
            this.radioButtonTrack.Name = "radioButtonTrack";
            this.radioButtonTrack.Size = new System.Drawing.Size(69, 24);
            this.radioButtonTrack.TabIndex = 14;
            this.radioButtonTrack.TabStop = true;
            this.radioButtonTrack.Text = "track";
            this.radioButtonTrack.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlbum
            // 
            this.radioButtonAlbum.AutoSize = true;
            this.radioButtonAlbum.Location = new System.Drawing.Point(95, 76);
            this.radioButtonAlbum.Name = "radioButtonAlbum";
            this.radioButtonAlbum.Size = new System.Drawing.Size(77, 24);
            this.radioButtonAlbum.TabIndex = 15;
            this.radioButtonAlbum.TabStop = true;
            this.radioButtonAlbum.Text = "album";
            this.radioButtonAlbum.UseVisualStyleBackColor = true;
            // 
            // radioButtonArtist
            // 
            this.radioButtonArtist.AutoSize = true;
            this.radioButtonArtist.Location = new System.Drawing.Point(178, 76);
            this.radioButtonArtist.Name = "radioButtonArtist";
            this.radioButtonArtist.Size = new System.Drawing.Size(69, 24);
            this.radioButtonArtist.TabIndex = 16;
            this.radioButtonArtist.TabStop = true;
            this.radioButtonArtist.Text = "artist";
            this.radioButtonArtist.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlaylists
            // 
            this.dataGridViewPlaylists.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridViewPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlaylists.Location = new System.Drawing.Point(693, 155);
            this.dataGridViewPlaylists.Name = "dataGridViewPlaylists";
            this.dataGridViewPlaylists.RowHeadersWidth = 62;
            this.dataGridViewPlaylists.RowTemplate.Height = 28;
            this.dataGridViewPlaylists.Size = new System.Drawing.Size(495, 160);
            this.dataGridViewPlaylists.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(697, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "TOP ARTISTS IN WORLD:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(693, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(495, 261);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1232, 684);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewPlaylists);
            this.Controls.Add(this.radioButtonArtist);
            this.Controls.Add(this.radioButtonAlbum);
            this.Controls.Add(this.radioButtonTrack);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.textboxplaylistdescription);
            this.Controls.Add(this.textboxplaylistname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewSearchResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLikedTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlaylists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxplaylistname;
        private System.Windows.Forms.TextBox textboxplaylistdescription;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewLikedTracks;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.RadioButton radioButtonTrack;
        private System.Windows.Forms.RadioButton radioButtonAlbum;
        private System.Windows.Forms.RadioButton radioButtonArtist;
        private System.Windows.Forms.DataGridView dataGridViewPlaylists;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}