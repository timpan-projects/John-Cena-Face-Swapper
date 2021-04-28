﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace JohnCenaFaceSwap
{
    

    public partial class Form1 : Form
    {
        private Capture webCam = null;
        public Form1()
        {
            InitializeComponent();
            webCam = new Capture(0);
            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            //取得網路攝影機的影像
            Image<Bgr, Byte> frame = webCam.QueryFrame().ToImage<Bgr, Byte>();
            //顯示影像到PictureBox上
            pictureBox1.Image = frame.ToBitmap();
        }


    }
}
