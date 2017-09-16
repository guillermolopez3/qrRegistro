using System;

using System.Data;
using System.Drawing;

using System.Linq;

using System.Windows.Forms;
using AForge.Video.DirectShow;
using BarcodeLib.BarcodeReader;



namespace ReadQRcode
{
    public partial class Form1 : Form
    {
        FilterInfoCollection ball;
        VideoCaptureDevice fuenteVideo;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ball = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in ball)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            fuenteVideo = new VideoCaptureDevice(ball[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = fuenteVideo;
            videoSourcePlayer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fuenteVideo.IsRunning)
            {

                fuenteVideo.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
                try
                {
                    Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                    string[] resultados = BarcodeReader.read(img, BarcodeReader.QRCODE);
                    img.Dispose();
                    if (resultados != null && resultados.Count() > 0)
                    {
                        if (resultados[0].IndexOf("--") != -1)
                        {
                            resultados[0] = resultados[0].Replace("--", "");
                            videoSourcePlayer1.Stop();
                            mostrarPersonaRegistrada(resultados[0]);
                            //NombreInscripto ins = new NombreInscripto();
                            //ins.ShowDialog();
                            videoSourcePlayer1.Start();
                        }

                    }
                }
                catch (Exception ex) { }
            }
        }

        private void videoSourcePlayer1_Click(object sender, EventArgs e)
        {

        }


        private void mostrarPersonaRegistrada(string valor)
        {
            NombreInscripto ins = new NombreInscripto(valor);
            ins.ShowDialog();

            if(ins.aceptarCancelat()==true)//si aceptó
            {
                DataTable ta = new DataTable();
                ta = ins.getTabla();
                ins.Close();
                mostrarFormRegistro(ta);
            }

        }

        private void mostrarFormRegistro(DataTable tab)
        {
            if(tab.Rows.Count>0)
            {
                RegistrarAsistencia reg = new RegistrarAsistencia(tab);
                reg.ShowDialog();
            }
        }

        private void btnCUE_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            if(string.IsNullOrEmpty(txtCUE.Text))
            {
                MessageBox.Show("Ingrese un CUE");
                txtCUE.Focus();
                return;
            }
            tabla = new DConectar().consultarRegistroManualmente(txtCUE.Text);

            if(tabla!=null)
            {
                if(tabla.Rows.Count>0)
                {
                    RegistrarAsistencia reg = new RegistrarAsistencia(tabla);
                    reg.ShowDialog();
                }
                else
                {
                    MessageBox.Show("CUE no encontrado");
                }
            }
            else
            {
                MessageBox.Show("CUE no encontrado");
            }

        }

        private void btnTotalInscriptos_Click(object sender, EventArgs e)
        {
            TotalInscriptos tot = new TotalInscriptos();
            tot.ShowDialog();
        }
    }
}
