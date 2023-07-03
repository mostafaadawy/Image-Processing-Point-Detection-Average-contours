using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmguFaceDetection
{
    public partial class frmEmguFaceDetection : Form
    {
        #region def
        Image<Bgr, Byte> Frame;
        Image<Gray, Byte> HisFrame;
        Image<Gray, Byte> HisAvgFrame;
        Capture camera;
        bool isNotFirstFram = false;
        bool isNotFirstAvgFram = false;
        int filterNo = 0; //0 binary 1 binary inverse 2 mask 3 tozero 4 to zeroinverse 5 truncation 6 otsu 7 adaptive binary mainc 8 adaptive binary inverse mainc 9 adaptive gaussianc binary 10 adaptive guassain binary inverse
        // create a circular buffer to store the most recent 5 frames
        const int bufferLength = 4;
        Image<Gray, byte>[] buffer = new Image<Gray, byte>[bufferLength];
        int counter = 0;
        #endregion
        public frmEmguFaceDetection()
        {
            InitializeComponent();
        }

        private void btnBinarization_Click(object sender, EventArgs e)
        {
            filterNo = 0;
        }
        private void frmEmguFaceDetection_Load(object sender, EventArgs e)
        {
            int quarterWidth = this.Width / 2;
            int quarterHeight = this.Height / 2;

            // First ImageBox in the top-left quarter
            camerabox.Location = new Point(0, 0);
            camerabox.Size = new Size(quarterWidth, quarterHeight);

            // Second ImageBox in the top-right quarter
            resultBox.Location = new Point(quarterWidth, 0);
            resultBox.Size = new Size(quarterWidth, quarterHeight);

            // Third ImageBox in the bottom-left quarter
            diffBox.Location = new Point(0, quarterHeight);
            diffBox.Size = new Size(quarterWidth, quarterHeight);

            // Fourth ImageBox in the bottom-right quarter
            avgImage.Location = new Point(quarterWidth, quarterHeight);
            avgImage.Size = new Size(quarterWidth, quarterHeight);

            // Set the SizeMode property of all ImageBoxes to Zoom
            camerabox.SizeMode = PictureBoxSizeMode.Zoom;
            resultBox.SizeMode = PictureBoxSizeMode.Zoom;
            diffBox.SizeMode = PictureBoxSizeMode.Zoom;
            avgImage.SizeMode = PictureBoxSizeMode.Zoom;

            // Set the BorderStyle property of all ImageBoxes to None
            camerabox.BorderStyle = BorderStyle.None;
            resultBox.BorderStyle = BorderStyle.None;
            diffBox.BorderStyle = BorderStyle.None;
            avgImage.BorderStyle = BorderStyle.None;

        }
        private void FrameProcedure(object sender, EventArgs e)
        {
            
            if (camera.QueryFrame().Size.Height > 0 && camera.QueryFrame().Size.Width > 0)
            {
                // resize the image
                Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame = Frame.Flip(Emgu.CV.CvEnum.FLIP.HORIZONTAL);
                camerabox.Image = Frame;
            }
            //else
            //{
            //    // handle the error
            //    throw new Exception("Invalid image size");
            //}


           
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            camera = new Capture(); // without or 0 for webcam
            //camera = new Capture(1);//1 for extrernal camera
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);
            Application.Idle += new EventHandler(TherProcedure);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 0;
        }
        private void TherProcedure(object sender, EventArgs e)
        {
            Image<Gray, byte> _gryImage;
            _gryImage = Frame.Convert<Gray, byte>();

            Image<Gray, byte> _binImage;
            _binImage = new Image<Gray, byte>(_gryImage.Width,_gryImage.Height,new Gray(0));

            if (Frame == null)
            {
                return;
            }
            if (filterNo == 0) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_BINARY);
            else if (filterNo == 1) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_BINARY_INV);
            else if (filterNo == 2) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_BINARY);
            else if (filterNo == 3) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_TOZERO);
            else if (filterNo == 4) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_TOZERO_INV);
            else if (filterNo == 5) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_TRUNC);
            else if (filterNo == 6) CvInvoke.cvThreshold(_gryImage, _binImage, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_OTSU);
            else if (filterNo == 7) CvInvoke.cvAdaptiveThreshold(_gryImage, _binImage, (double)numericReplace.Value, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, THRESH.CV_THRESH_BINARY, (int)numericBlockSize.Value,0.0);
            else if (filterNo == 8) CvInvoke.cvAdaptiveThreshold(_gryImage, _binImage, (double)numericReplace.Value, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C, THRESH.CV_THRESH_BINARY_INV, (int)numericBlockSize.Value, 0.0);
            else if (filterNo == 9) CvInvoke.cvAdaptiveThreshold(_gryImage, _binImage, (double)numericReplace.Value, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C, THRESH.CV_THRESH_BINARY, (int)numericBlockSize.Value, 0.0);
            else if (filterNo == 10) CvInvoke.cvAdaptiveThreshold(_gryImage, _binImage, (double)numericReplace.Value, ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C, THRESH.CV_THRESH_BINARY_INV, (int)numericBlockSize.Value, 0.0);
            else return;
            if (isNotFirstFram)
            {
                Image<Gray, byte> _diffFrame;
                _diffFrame = new Image<Gray, byte>(_gryImage.Width, _gryImage.Height, new Gray(0));
                CvInvoke.cvAbsDiff(_binImage, HisFrame, _diffFrame);
                HisFrame=_binImage;
                // Apply Gaussian filter with kernel size 5 and sigma value 1.5
                //CvInvoke.cvSmooth(_diffFrame, _diffFrame, SMOOTH_TYPE.CV_GAUSSIAN, 5, 5, 1, 1);
                diffBox.Image = _diffFrame;
                resultBox.Image = _binImage;

                //average differance
                if (counter > bufferLength - 1)
                {
                    counter = 0;
                    // compute the average of the 5 frames
                    Image<Gray, byte> averageFrame = new Image<Gray, byte>(buffer[0].Width, buffer[0].Height);
                    for (int y = 0; y < averageFrame.Height; y++)
                    {
                        for (int x = 0; x < averageFrame.Width; x++)
                        {
                            // compute the average of each pixel across the 5 frames
                            double pixelValue = 0;
                            for (int i = 0; i < bufferLength; i++)
                            {
                                pixelValue += buffer[i][y, x].Intensity;
                            }
                            pixelValue /= bufferLength;

                            // set the average pixel value in the average frame
                            averageFrame[y, x] = new Gray((byte)pixelValue);
                        }
                    }

                    // update the buffer with the most recent frame
                    buffer[counter] = averageFrame;


                    if (isNotFirstAvgFram)
                    {
                        Image<Gray, byte> _diffAvgFrame;
                        _diffAvgFrame = new Image<Gray, byte>(buffer[0].Width, buffer[0].Height, new Gray(0));
                        CvInvoke.cvAbsDiff(averageFrame, HisAvgFrame, _diffAvgFrame);
                        CvInvoke.cvThreshold(_diffAvgFrame, _diffAvgFrame, (double)numericThershold.Value, (double)numericReplace.Value, THRESH.CV_THRESH_BINARY);
                        avgImage.Image = _diffAvgFrame;

                        // Find contours in the thresholded frame
                        List<Contour<Point>> contoursDetected = new List<Contour<Point>>();
                        using (MemStorage storage = new MemStorage())
                        {
                            for (Contour<Point> contour = _diffAvgFrame.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_LIST, storage); contour != null; contour = contour.HNext)
                            {
                                double area = contour.Area;
                                if (area > 10) // Adjust the threshold area as per your requirements
                                {
                                    // Get the centroid of the contour
                                    MCvMoments moments = contour.GetMoments();
                                    int cx = (int)(moments.GravityCenter.x);
                                    int cy = (int)(moments.GravityCenter.y);

                                    // Print the x and y coordinates of the laser point
                                    Console.WriteLine("Laser point detected at X: " + cx + ", Y: " + cy);

                                    // Draw the centroid on the frame
                                    Frame.Draw(new CircleF(new PointF(cx, cy), 5), new Bgr(0, 0, 255), -1);
                                }

                                contoursDetected.Add(contour);
                            }
                        }

                        // Display the processed frame in a PictureBox control
                        camerabox.Image = Frame;



                        HisAvgFrame = averageFrame;
                    }
                    else
                    {
                        //avgImage.Image = buffer[0];
                        HisAvgFrame = buffer[0];
                        isNotFirstAvgFram = true;
                    }
                }
                else
                {
                    buffer[counter] = _gryImage;
                    
                }

                counter++;
               


            }
            else
            {
                isNotFirstFram = true;
                HisFrame = _binImage;
            }
            

        }
 
        private void binaryInvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 1;
        }

        private void maskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 2;
        }

        private void toZeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 3;
        }

        private void toZeroInvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 4;
        }

        private void truncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 5;
        }

        private void oTSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 6;
        }

        private void addaptiveMainBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 7;
        }

        private void addaptiveMainBinaryInvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 8;
        }

        private void addaptiveGaussianBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 9;
        }

        private void addaptiveGaussianBinaryInvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterNo = 10;
        }
    }
}
