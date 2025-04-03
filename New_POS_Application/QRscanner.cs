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
using ZXing.Aztec;
using ZXing;
using System.Diagnostics.Tracing;

namespace New_POS_Application
{
    public partial class QRscanner : Form
    {
        FilterInfoCollection filter;
        VideoCaptureDevice cam;
        public double CustomerCash;

        public QRscanner()
        {
            InitializeComponent();
        }

        private void QRscanner_Load(object sender, EventArgs e)
        {
            QRcamera.Hide();
            CashScanned_tbox.Hide();
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
            {
                QRcamera.Items.Add(filterInfo.Name);
            }
            QRcamera.SelectedIndex = 0;
            cam = new VideoCaptureDevice(filter[QRcamera.SelectedIndex].MonikerString);
            cam.NewFrame += CaptureDevice_NewFrame;
            cam.Start();
            timer3.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);

                if (result != null)
                {
                    if (CashScanned_tbox.Text == "")
                    {                       
                        CashScanned_tbox.Text = result.ToString(); 
                        try
                        {
                            CustomerCash = Convert.ToDouble(CashScanned_tbox.Text);
                            timer3.Stop();
                            if (cam.IsRunning)
                            {
                                cam.Stop();
                                this.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid QR", "ERROR");
                            cam.Stop();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}