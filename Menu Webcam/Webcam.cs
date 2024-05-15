using System;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Threading.Tasks;

namespace Menu_Webcam
{
    public partial class Webcam : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public Webcam()
        {
            InitializeComponent();
            CMBWebcam.Text = "Selecione a Sua Webcam";

            // Load available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                CMBWebcam.Items.Add(device.Name);
            }

            if (CMBWebcam.Items.Count > 0)
            {
                CMBWebcam.SelectedIndex = 0;
            }

            CMBWebcam.SelectedIndexChanged += CMBWebcam_SelectedIndexChanged;
            this.FormClosing += Webcam_FormClosing;
        }

        private void CMBWebcam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBWebcam.SelectedIndex >= 0)
            {
                StopVideoSource(); // Stop the current video source

                videoSource = new VideoCaptureDevice(videoDevices[CMBWebcam.SelectedIndex].MonikerString);
                videoSource.NewFrame += video_NewFrame;
                videoSource.Start();
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            UpdatePictureBoxImage(Pimagem, frame);
        }

        private void UpdatePictureBoxImage(PictureBox pictureBox, Bitmap frame)
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.BeginInvoke(new MethodInvoker(() => SetImage(pictureBox, frame)));
            }
            else
            {
                SetImage(pictureBox, frame);
            }
        }


        private void SetImage(PictureBox pictureBox, Bitmap frame)
        {
            pictureBox.Image?.Dispose();
            pictureBox.Image = frame;
        }
       
        private void Webcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void StopVideoSource()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.NewFrame -= video_NewFrame;
                videoSource.WaitForStop();
            }
        }

        private void BtnCapturar_Click(object sender, EventArgs e)
        {
            if (Pimagem.Image != null)
            {
                Bitmap capturedImage = (Bitmap)Pimagem.Image.Clone();
                UpdatePictureBoxImage(Pcopia, capturedImage);
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            ClearPictureBoxImage(Pcopia);
        }

        private void ClearPictureBoxImage(PictureBox pictureBox)
        {
            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new MethodInvoker(delegate
                {
                    pictureBox.Image?.Dispose();
                    pictureBox.Image = null;
                }));
            }
            else
            {
                pictureBox.Image?.Dispose();
                pictureBox.Image = null;
            }
            MessageBox.Show("A sua Copia Foi Limpa Com Sucesso !...", "Copia", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Pcopia.Image != null)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Imagem JPEG|*.jpg|Imagem PNG|*.png|Todos os Arquivos|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap toSave = (Bitmap)Pcopia.Image.Clone();
                        await Task.Run(() => toSave.Save(saveFileDialog.FileName));
                        toSave.Dispose();
                    }
                }
                MessageBox.Show("Sua Imagem Guardada Com Sucesso !..","Imagem",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do Programa ? Sim/ Nao", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
            StopVideoSource(); // Implementação para parar a webcam
            MessageBox.Show("A sua Webcam Esta Parada !..", "Webcam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Webcam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Webcam_Load(object sender, EventArgs e)
        {
            CMBWebcam.Text = "Selecione a Sua Webcam";
        }
    }
}
