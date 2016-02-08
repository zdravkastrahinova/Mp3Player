using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using Mp3Player.Entities;
using System.IO;


namespace Mp3Player
{
    public partial class FormMp3Player : Form
    {
        List<Song> songs = new List<Song>();
        IWavePlayer wavePlayer;
        AudioFileReader audioFileReader;
        bool isPaused;

        public FormMp3Player()
        {
            InitializeComponent();
        }

        private void button_addSong_Click(object sender, EventArgs e)
        {
            // add more then one songs in one try
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Mp3 File | *mp3";

            // load all selected songs in list and listbox
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                {
                    Song song = new Song();
                    song.Path = openFileDialog.FileNames[i];
                    song.Name = openFileDialog.SafeFileNames[i];
                    songs.Add(song);
                }
            }

            FillListBox(songs);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            // if there are songs in playlist
            if (songs.Count != 0)
            {
                if (!isPaused)
                {
                    ReleaseResources(); // release resources
                    StartPlayingSong(); // start playing
                }
                else
                {
                    wavePlayer.Play(); // don't release resources -> continue playing
                }
                pictureBox_visualisation.Image = Properties.Resources.PlayingSound;
                button_pause.BackgroundImage = Properties.Resources.pause;
            }
            else
            {
                button_addSong_Click(sender, e);
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            ReleaseResources();
            pictureBox_visualisation.Image = Properties.Resources.ColorImage;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isPaused)
                {
                    wavePlayer.Pause();
                    isPaused = true;
                    button_pause.BackgroundImage = Properties.Resources.play;
                    pictureBox_visualisation.Image = Properties.Resources.ColorImage;
                }
                else
                {
                    wavePlayer.Play();
                    isPaused = false;
                    button_pause.BackgroundImage = Properties.Resources.pause;
                    pictureBox_visualisation.Image = Properties.Resources.PlayingSound;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Song is not playing at the moment");
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_songs.SelectedIndex != (listBox_songs.Items.Count - 1))
                {
                    listBox_songs.SelectedIndex = listBox_songs.SelectedIndex + 1;
                }
                else
                {
                    listBox_songs.SelectedIndex = 0;
                }

                ReleaseResources();
                StartPlayingSong();

                pictureBox_visualisation.Image = Properties.Resources.PlayingSound;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("There are no loaded songs", "Oops...");
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_songs.SelectedIndex != 0)
                {
                    listBox_songs.SelectedIndex = listBox_songs.SelectedIndex - 1;
                }
                else
                {
                    listBox_songs.SelectedIndex = listBox_songs.Items.Count - 1;
                }

                ReleaseResources();
                StartPlayingSong();

                pictureBox_visualisation.Image = Properties.Resources.PlayingSound;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No songs were loaded");
            }
        }

        private void button_createPlaylist_Click(object sender, EventArgs e)
        {
            if (songs.Count != 0)
            {
                saveFileDialog.DefaultExt = ".wpl";
                saveFileDialog.Filter = "Mp3 Player Playlist | *wpl";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Append))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            foreach (Song s in songs)
                            {
                                sw.WriteLine(s.Path);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("First add songs in current playlist", "No songs loaded");
            }
        }

        private void button_loadPlaylist_Click(object sender, EventArgs e)
        {
            openFileDialog_loadPlaylist.Filter = "Mp3 Player Playlist | *wpl";

            if (openFileDialog_loadPlaylist.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog_loadPlaylist.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            Song song = new Song(sr.ReadLine());
                            songs.Add(song);
                        }
                    }
                }
            }

            FillListBox(songs);
        }

        private void listBox_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReleaseResources();
            StartPlayingSong();
            wavePlayer.PlaybackStopped += button_next_Click;
            pictureBox_visualisation.Image = Properties.Resources.PlayingSound;
        }

        private void button_volumeUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (audioFileReader.Volume != 1)
                {
                    if (trackBar_volume.Value != 10)
                    {
                        audioFileReader.Volume += 0.1f;
                        trackBar_volume.Value += 1;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Song is not playing at the moment", "Oops...");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You cannot volume up any more", "Volume is at maximum");
            }
        }

        private void button_volumeDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (audioFileReader.Volume != 0)
                {
                    if (trackBar_volume.Value != 0)
                    {
                        audioFileReader.Volume -= 0.1f;
                        trackBar_volume.Value -= 1;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Song is not playing at the moment", "Oops...");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("You cannot volume down any more", "Volume is at minimum");
            }
        }

        private void FormMp3Player_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void FormMp3Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Form mp3 player closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReleaseResources();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void StartPlayingSong()
        {
            try
            {
                int index = listBox_songs.SelectedIndex;
                Song currentSong = songs[index]; // get song from list by index

                wavePlayer = new WaveOut();
                audioFileReader = new AudioFileReader(currentSong.Path);
                wavePlayer.Init(audioFileReader);
                wavePlayer.Play();

                trackBar_volume.Value = 10;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select song that you want to play");
            }
        }

        private void ReleaseResources()
        {
            if (wavePlayer != null)
            {
                wavePlayer.Stop();
                wavePlayer.Dispose();
                wavePlayer = null;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
        }

        private void FillListBox(List<Song> songs)
        {
            listBox_songs.Items.Clear();
            for (int i = 0; i < songs.Count; i++)
            {
                listBox_songs.Items.Add(songs[i]);
            }
        }
    }
}