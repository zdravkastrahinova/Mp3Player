namespace Mp3Player
{
    partial class FormMp3Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMp3Player));
            this.label_playlist = new System.Windows.Forms.Label();
            this.listBox_songs = new System.Windows.Forms.ListBox();
            this.button_addSong = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button_createPlaylist = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_loadPlaylist = new System.Windows.Forms.Button();
            this.openFileDialog_loadPlaylist = new System.Windows.Forms.OpenFileDialog();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.button_volumeDown = new System.Windows.Forms.Button();
            this.button_volumeUp = new System.Windows.Forms.Button();
            this.pictureBox_visualisation = new System.Windows.Forms.PictureBox();
            this.button_next = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualisation)).BeginInit();
            this.SuspendLayout();
            // 
            // label_playlist
            // 
            this.label_playlist.AutoSize = true;
            this.label_playlist.BackColor = System.Drawing.Color.Transparent;
            this.label_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playlist.Location = new System.Drawing.Point(14, 239);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Size = new System.Drawing.Size(75, 15);
            this.label_playlist.TabIndex = 5;
            this.label_playlist.Text = "My Playlist";
            // 
            // listBox_songs
            // 
            this.listBox_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_songs.FormattingEnabled = true;
            this.listBox_songs.ItemHeight = 15;
            this.listBox_songs.Location = new System.Drawing.Point(14, 260);
            this.listBox_songs.Name = "listBox_songs";
            this.listBox_songs.Size = new System.Drawing.Size(260, 154);
            this.listBox_songs.TabIndex = 6;
            this.listBox_songs.SelectedIndexChanged += new System.EventHandler(this.listBox_songs_SelectedIndexChanged);
            // 
            // button_addSong
            // 
            this.button_addSong.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_addSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addSong.Location = new System.Drawing.Point(280, 260);
            this.button_addSong.Name = "button_addSong";
            this.button_addSong.Size = new System.Drawing.Size(169, 33);
            this.button_addSong.TabIndex = 7;
            this.button_addSong.Text = "Add Song";
            this.button_addSong.UseVisualStyleBackColor = false;
            this.button_addSong.Click += new System.EventHandler(this.button_addSong_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button_createPlaylist
            // 
            this.button_createPlaylist.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_createPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createPlaylist.Location = new System.Drawing.Point(280, 338);
            this.button_createPlaylist.Name = "button_createPlaylist";
            this.button_createPlaylist.Size = new System.Drawing.Size(169, 33);
            this.button_createPlaylist.TabIndex = 8;
            this.button_createPlaylist.Text = "Create Playlist";
            this.button_createPlaylist.UseVisualStyleBackColor = false;
            this.button_createPlaylist.Click += new System.EventHandler(this.button_createPlaylist_Click);
            // 
            // button_loadPlaylist
            // 
            this.button_loadPlaylist.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_loadPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loadPlaylist.Location = new System.Drawing.Point(280, 299);
            this.button_loadPlaylist.Name = "button_loadPlaylist";
            this.button_loadPlaylist.Size = new System.Drawing.Size(169, 33);
            this.button_loadPlaylist.TabIndex = 11;
            this.button_loadPlaylist.Text = "Load Playlist";
            this.button_loadPlaylist.UseVisualStyleBackColor = false;
            this.button_loadPlaylist.Click += new System.EventHandler(this.button_loadPlaylist_Click);
            // 
            // openFileDialog_loadPlaylist
            // 
            this.openFileDialog_loadPlaylist.FileName = "openFileDialog1";
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.BackColor = System.Drawing.Color.RoyalBlue;
            this.trackBar_volume.Enabled = false;
            this.trackBar_volume.Location = new System.Drawing.Point(326, 180);
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(86, 45);
            this.trackBar_volume.TabIndex = 13;
            // 
            // button_volumeDown
            // 
            this.button_volumeDown.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_volumeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volumeDown.Location = new System.Drawing.Point(412, 202);
            this.button_volumeDown.Name = "button_volumeDown";
            this.button_volumeDown.Size = new System.Drawing.Size(37, 23);
            this.button_volumeDown.TabIndex = 14;
            this.button_volumeDown.Text = "-";
            this.button_volumeDown.UseVisualStyleBackColor = false;
            this.button_volumeDown.Click += new System.EventHandler(this.button_volumeDown_Click);
            // 
            // button_volumeUp
            // 
            this.button_volumeUp.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_volumeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_volumeUp.Location = new System.Drawing.Point(412, 180);
            this.button_volumeUp.Name = "button_volumeUp";
            this.button_volumeUp.Size = new System.Drawing.Size(37, 23);
            this.button_volumeUp.TabIndex = 15;
            this.button_volumeUp.Text = "+";
            this.button_volumeUp.UseVisualStyleBackColor = false;
            this.button_volumeUp.Click += new System.EventHandler(this.button_volumeUp_Click);
            // 
            // pictureBox_visualisation
            // 
            this.pictureBox_visualisation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_visualisation.Image = global::Mp3Player.Properties.Resources.ColorImage;
            this.pictureBox_visualisation.Location = new System.Drawing.Point(14, 12);
            this.pictureBox_visualisation.Name = "pictureBox_visualisation";
            this.pictureBox_visualisation.Size = new System.Drawing.Size(435, 161);
            this.pictureBox_visualisation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_visualisation.TabIndex = 12;
            this.pictureBox_visualisation.TabStop = false;
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_next.BackgroundImage = global::Mp3Player.Properties.Resources.next;
            this.button_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.Location = new System.Drawing.Point(264, 180);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(56, 45);
            this.button_next.TabIndex = 4;
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_pause
            // 
            this.button_pause.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_pause.BackgroundImage = global::Mp3Player.Properties.Resources.pause;
            this.button_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pause.Location = new System.Drawing.Point(202, 179);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(56, 46);
            this.button_pause.TabIndex = 3;
            this.button_pause.UseVisualStyleBackColor = false;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_stop.BackgroundImage = global::Mp3Player.Properties.Resources.stop;
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.Location = new System.Drawing.Point(79, 179);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(56, 46);
            this.button_stop.TabIndex = 2;
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_start.BackgroundImage = global::Mp3Player.Properties.Resources.play;
            this.button_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(140, 179);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(56, 46);
            this.button_start.TabIndex = 1;
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_previous
            // 
            this.button_previous.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_previous.BackgroundImage = global::Mp3Player.Properties.Resources.previous;
            this.button_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.Location = new System.Drawing.Point(17, 179);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(56, 46);
            this.button_previous.TabIndex = 0;
            this.button_previous.UseVisualStyleBackColor = false;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // FormMp3Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mp3Player.Properties.Resources.NewBlueBackgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 424);
            this.Controls.Add(this.button_volumeUp);
            this.Controls.Add(this.button_volumeDown);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.pictureBox_visualisation);
            this.Controls.Add(this.button_loadPlaylist);
            this.Controls.Add(this.button_createPlaylist);
            this.Controls.Add(this.button_addSong);
            this.Controls.Add(this.listBox_songs);
            this.Controls.Add(this.label_playlist);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_previous);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMp3Player";
            this.Text = "Mp3 Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMp3Player_FormClosing);
            this.Load += new System.EventHandler(this.FormMp3Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_visualisation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_playlist;
        private System.Windows.Forms.ListBox listBox_songs;
        private System.Windows.Forms.Button button_addSong;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button_createPlaylist;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button_loadPlaylist;
        private System.Windows.Forms.OpenFileDialog openFileDialog_loadPlaylist;
        private System.Windows.Forms.PictureBox pictureBox_visualisation;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Button button_volumeDown;
        private System.Windows.Forms.Button button_volumeUp;
    }
}

