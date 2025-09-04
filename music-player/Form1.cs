using NAudio.Wave;

namespace music_player
{
    public partial class Form1 : Form
    {
        private WaveOutEvent? outputDevice;
        private AudioFileReader? audioFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.Filter = "WAV Files|*.wav";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    audioFile = new AudioFileReader(openFileDialog.FileName);
                }
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
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
            }
        }

        private void BtnStop_Click(object? sender, EventArgs e)
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
        }
    }
}
