using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PrototypeDemo
{
    class CameraFeed : IDisposable
    {
        public bool IsCameraRunning { get; private set; }

        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;

        private PictureBox pictureBox;

        public CameraFeed(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            IsCameraRunning = false;
            StartCaptureCamera();
        }

        private void StartCaptureCamera()
        {
            IsCameraRunning = true;
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            while (IsCameraRunning)
            {
                capture.Read(frame);
                image = BitmapConverter.ToBitmap(frame);

                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }

                pictureBox.Image = image;
            }
        }

        public void Dispose()
        {
            IsCameraRunning = false;
            capture.Dispose();
            camera.Abort();
        }
    }
}
