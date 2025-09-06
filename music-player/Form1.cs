using System;
using System.Windows.Forms;
using NAudio.Wave;

namespace music_player
{
    public partial class Form1 : Form
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // updates every 100 ms
            timer.Tick += Timer_Tick;

            progressBar1.MouseDown += progressBar1_MouseDown;
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.Filter = "WAV Files|*.wav";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (outputDevice != null)
                    {
                        outputDevice?.Stop();
                    }

                    audioFile = new AudioFileReader(openFileDialog.FileName);
                    progressBar1.Value = 0;
                    UpdateTimeLabels();
                }
            }
        }

        private void ButtonPlay_Click(object? sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }

            if (audioFile != null)
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                ButtonPlay.Text = "Stop";
                ButtonPlay.Click -= ButtonPlay_Click;
                ButtonPlay.Click += ButtonStop_Click;

                // setting a ProgressBar
                progressBar1.Minimum = 0;
                progressBar1.Maximum = (int)audioFile.TotalTime.TotalMilliseconds;

                timer.Start();
            }
        }

        private void ButtonStop_Click(object? sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice?.Stop();
            }
        }

        private void OnPlaybackStopped(object? sender, StoppedEventArgs args)
        {
            outputDevice?.Dispose();
            outputDevice = null;

            ButtonPlay.Text = "Play";
            ButtonPlay.Click -= ButtonStop_Click;
            ButtonPlay.Click += ButtonPlay_Click;

            timer.Stop();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (audioFile != null)
            {
                int currentMilliseconds = (int)audioFile.CurrentTime.TotalMilliseconds;
                if (currentMilliseconds <= progressBar1.Maximum)
                {
                    progressBar1.Value = currentMilliseconds;
                }

                UpdateTimeLabels();
            }
        }

        private void progressBar1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (audioFile == null) return;

            // Вычисляем позицию клика в процентах от ширины ProgressBar
            double ratio = (double)e.X / progressBar1.Width;

            // Вычисляем и устанавливаем новую позицию в аудиофайле
            TimeSpan newPosition = TimeSpan.FromSeconds(audioFile.TotalTime.TotalSeconds * ratio);
            audioFile.CurrentTime = newPosition;

            // Обновляем ProgressBar и метки времени
            progressBar1.Value = (int)newPosition.Milliseconds;
            UpdateTimeLabels();
        }

        private void UpdateTimeLabels()
        {
            if (audioFile == null) return;

            labelCurrentTime.Text = audioFile.CurrentTime.ToString(@"mm\:ss");
            labelTotalTime.Text = audioFile.TotalTime.ToString(@"mm\:ss");
        }
    }
}
