using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Threading;


namespace Recognition
{
    public partial class Form1 : Form
    {

        VideoCapture webCam;
        bool blnCapturingInProgress = false;
        Image<Bgr, byte> imgOrginal;
        Image<Gray, byte> imgProcessed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                webCam = new VideoCapture(0);
            }
            catch (NoNullAllowedException except)
            {
                txtXYradius.Text = except.Message;
            }

            Application.Idle += ProcessUpdate;
            blnCapturingInProgress = true;
        }

        private void ProcessUpdate(object sender, EventArgs e)
        {
            imgOrginal = webCam.QueryFrame().ToImage <Bgr,byte>();
            if (imgOrginal == null) return;
            imgProcessed = imgOrginal.InRange(new Bgr ( 0,120,0), new Bgr(120, 256, 130)); 
            imgProcessed = imgProcessed.SmoothGaussian(9);
            CircleF[] circles = imgProcessed.HoughCircles(new Gray(100),
                new Gray(50),
                2,
                imgProcessed.Height / 4,
                10,
                400 )[0];

            foreach (CircleF circle in circles) {
                if (txtXYradius.Text != "") txtXYradius.AppendText(Environment.NewLine);
                txtXYradius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) + ", y" + circle.Center.Y.ToString().PadLeft(4) + ", radius =" +
                    circle.Radius.ToString("###,000").PadLeft(7));
                txtXYradius.ScrollToCaret();

                CvInvoke.Circle(imgOrginal, 
                    new Point(((int)circle.Center.X), (int)circle.Center.Y), 3, new MCvScalar(0,255,0), 
                    -1,
                    LineType.AntiAlias,
                    0);
                imgOrginal.Draw(circle, new Bgr(Color.Red), 3);
            }

            ibOriginal.Image = imgOrginal;
            ibProcessed.Image = imgProcessed;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (webCam != null)
            {
                webCam.Dispose();
            }

        }

        private void PauseOrResume_Click(object sender, EventArgs e)
        {
            if (blnCapturingInProgress == true)
            {
                Application.Idle -= ProcessUpdate;
                blnCapturingInProgress = false;
                btnPauseOrResume.Text = "resume"; 
            }
            else
            {
                Application.Idle += ProcessUpdate;
                blnCapturingInProgress = true;
                btnPauseOrResume.Text = "pause";
            }
        }
    }
}
