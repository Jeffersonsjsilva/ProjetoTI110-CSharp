using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace lojaABC
{
    public partial class frmWebCam : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        public frmWebCam()
        {
            InitializeComponent();
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pctDispositivos.Image = img;
        }

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cbbDispositivos.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cbbDispositivos.Items.Add(device.Name);
                }
                cbbDispositivos.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {

                DeviceExist = false;
                cbbDispositivos.Items.Add("Nenhum dispositivo encontrado");
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (btnCapturar.Text == "Capturar")
            {


                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cbbDispositivos.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    //encerra o sinal da camera
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btnCapturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!","Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //encerra o sinal da camera.
                    //note que este bloco de código se repetiu, você pode criar um método para ele.
                    if(!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            //salvar imagem
                            sfdSalvarImagem.Filter = "JPEG (*.jpg;*.jpeg;*.jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*jfif";
                            DialogResult res = sfdSalvarImagem.ShowDialog();
                            if(res == DialogResult.OK)
                            {
                                pctDispositivos.Image.Save(sfdSalvarImagem.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarIMG = new OpenFileDialog();
            BuscarIMG.InitialDirectory = "c:\\imagens\\";
            BuscarIMG.FileName = "imagem";
            BuscarIMG.Title = "Procurar imagem";
            BuscarIMG.Filter = ("*jpg|*.jpg|*png|*.png|*bmp|*.bmp|*tif|*.tif");
            BuscarIMG.ShowDialog();
            pctDispositivos.ImageLocation = (BuscarIMG.FileName);

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pctDispositivos.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
