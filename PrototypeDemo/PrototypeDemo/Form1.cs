using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PrototypeDemo
{
    public partial class Form1 : Form
    {
        private readonly MoodDetection moodDetection;
        private string workingDirectory = Environment.CurrentDirectory;
        CameraFeed cameraFeed;

        public Form1()
        {
            InitializeComponent();

            cameraFeed = new CameraFeed(pictureBox1);
            moodDetection = new MoodDetection();
        }

        private async void btnMeasure_Click(object sender, EventArgs e)
        {
            string filePath = string.Format(@"{0}\Face.png", Directory.GetParent(workingDirectory).Parent.FullName);

            if (cameraFeed.IsCameraRunning == true)
            {
                Bitmap snapshot = new Bitmap(pictureBox1.Image);

                // Locally saves a photo
                snapshot.Save(filePath, ImageFormat.Png);

                // Gets the mood
                var mood = await moodDetection.GetEmotions(filePath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            cameraFeed.Dispose();
        }
    }
}
