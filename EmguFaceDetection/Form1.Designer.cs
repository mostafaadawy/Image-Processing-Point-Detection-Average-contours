
namespace EmguFaceDetection
{
    partial class frmEmguFaceDetection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thersholdingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toZeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toZeroInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addaptiveMainBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addaptiveMainBinaryInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addaptiveGaussianBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addaptiveGaussianBinaryInvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericBlockSize = new System.Windows.Forms.NumericUpDown();
            this.OTSUValLabel = new System.Windows.Forms.Label();
            this.lblOtsu = new System.Windows.Forms.Label();
            this.numericReplace = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericThershold = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.diffBox = new Emgu.CV.UI.ImageBox();
            this.resultBox = new Emgu.CV.UI.ImageBox();
            this.camerabox = new Emgu.CV.UI.ImageBox();
            this.avgImage = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReplace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThershold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camerabox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.thersholdingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // thersholdingToolStripMenuItem
            // 
            this.thersholdingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.binaryInvToolStripMenuItem,
            this.maskToolStripMenuItem,
            this.toZeroToolStripMenuItem,
            this.toZeroInvToolStripMenuItem,
            this.truncToolStripMenuItem,
            this.oTSUToolStripMenuItem,
            this.addaptiveMainBinaryToolStripMenuItem,
            this.addaptiveMainBinaryInvToolStripMenuItem,
            this.addaptiveGaussianBinaryToolStripMenuItem,
            this.addaptiveGaussianBinaryInvToolStripMenuItem});
            this.thersholdingToolStripMenuItem.Name = "thersholdingToolStripMenuItem";
            this.thersholdingToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.thersholdingToolStripMenuItem.Text = "Thersholding";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.binaryToolStripMenuItem.Text = "Binary";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // binaryInvToolStripMenuItem
            // 
            this.binaryInvToolStripMenuItem.Name = "binaryInvToolStripMenuItem";
            this.binaryInvToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.binaryInvToolStripMenuItem.Text = "Binary inv";
            this.binaryInvToolStripMenuItem.Click += new System.EventHandler(this.binaryInvToolStripMenuItem_Click);
            // 
            // maskToolStripMenuItem
            // 
            this.maskToolStripMenuItem.Name = "maskToolStripMenuItem";
            this.maskToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.maskToolStripMenuItem.Text = "Mask";
            this.maskToolStripMenuItem.Click += new System.EventHandler(this.maskToolStripMenuItem_Click);
            // 
            // toZeroToolStripMenuItem
            // 
            this.toZeroToolStripMenuItem.Name = "toZeroToolStripMenuItem";
            this.toZeroToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.toZeroToolStripMenuItem.Text = "To Zero";
            this.toZeroToolStripMenuItem.Click += new System.EventHandler(this.toZeroToolStripMenuItem_Click);
            // 
            // toZeroInvToolStripMenuItem
            // 
            this.toZeroInvToolStripMenuItem.Name = "toZeroInvToolStripMenuItem";
            this.toZeroInvToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.toZeroInvToolStripMenuItem.Text = "To Zero Inv";
            this.toZeroInvToolStripMenuItem.Click += new System.EventHandler(this.toZeroInvToolStripMenuItem_Click);
            // 
            // truncToolStripMenuItem
            // 
            this.truncToolStripMenuItem.Name = "truncToolStripMenuItem";
            this.truncToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.truncToolStripMenuItem.Text = "Trunc";
            this.truncToolStripMenuItem.Click += new System.EventHandler(this.truncToolStripMenuItem_Click);
            // 
            // oTSUToolStripMenuItem
            // 
            this.oTSUToolStripMenuItem.Name = "oTSUToolStripMenuItem";
            this.oTSUToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.oTSUToolStripMenuItem.Text = "OTSU";
            this.oTSUToolStripMenuItem.Click += new System.EventHandler(this.oTSUToolStripMenuItem_Click);
            // 
            // addaptiveMainBinaryToolStripMenuItem
            // 
            this.addaptiveMainBinaryToolStripMenuItem.Name = "addaptiveMainBinaryToolStripMenuItem";
            this.addaptiveMainBinaryToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addaptiveMainBinaryToolStripMenuItem.Text = "Addaptive Main Binary";
            this.addaptiveMainBinaryToolStripMenuItem.Click += new System.EventHandler(this.addaptiveMainBinaryToolStripMenuItem_Click);
            // 
            // addaptiveMainBinaryInvToolStripMenuItem
            // 
            this.addaptiveMainBinaryInvToolStripMenuItem.Name = "addaptiveMainBinaryInvToolStripMenuItem";
            this.addaptiveMainBinaryInvToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addaptiveMainBinaryInvToolStripMenuItem.Text = "Addaptive Main Binary Inv";
            this.addaptiveMainBinaryInvToolStripMenuItem.Click += new System.EventHandler(this.addaptiveMainBinaryInvToolStripMenuItem_Click);
            // 
            // addaptiveGaussianBinaryToolStripMenuItem
            // 
            this.addaptiveGaussianBinaryToolStripMenuItem.Name = "addaptiveGaussianBinaryToolStripMenuItem";
            this.addaptiveGaussianBinaryToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addaptiveGaussianBinaryToolStripMenuItem.Text = "Addaptive Gaussian Binary";
            this.addaptiveGaussianBinaryToolStripMenuItem.Click += new System.EventHandler(this.addaptiveGaussianBinaryToolStripMenuItem_Click);
            // 
            // addaptiveGaussianBinaryInvToolStripMenuItem
            // 
            this.addaptiveGaussianBinaryInvToolStripMenuItem.Name = "addaptiveGaussianBinaryInvToolStripMenuItem";
            this.addaptiveGaussianBinaryInvToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.addaptiveGaussianBinaryInvToolStripMenuItem.Text = "Addaptive Gaussian Binary Inv";
            this.addaptiveGaussianBinaryInvToolStripMenuItem.Click += new System.EventHandler(this.addaptiveGaussianBinaryInvToolStripMenuItem_Click);
            // 
            // Parameters
            // 
            this.Parameters.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Parameters.Controls.Add(this.label3);
            this.Parameters.Controls.Add(this.numericBlockSize);
            this.Parameters.Controls.Add(this.OTSUValLabel);
            this.Parameters.Controls.Add(this.lblOtsu);
            this.Parameters.Controls.Add(this.numericReplace);
            this.Parameters.Controls.Add(this.label2);
            this.Parameters.Controls.Add(this.numericThershold);
            this.Parameters.Controls.Add(this.label1);
            this.Parameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.Parameters.Location = new System.Drawing.Point(0, 24);
            this.Parameters.Margin = new System.Windows.Forms.Padding(2);
            this.Parameters.Name = "Parameters";
            this.Parameters.Padding = new System.Windows.Forms.Padding(2);
            this.Parameters.Size = new System.Drawing.Size(1209, 42);
            this.Parameters.TabIndex = 5;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Parameters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adaptive Block Size";
            // 
            // numericBlockSize
            // 
            this.numericBlockSize.Location = new System.Drawing.Point(464, 15);
            this.numericBlockSize.Margin = new System.Windows.Forms.Padding(2);
            this.numericBlockSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericBlockSize.Name = "numericBlockSize";
            this.numericBlockSize.Size = new System.Drawing.Size(64, 20);
            this.numericBlockSize.TabIndex = 6;
            this.numericBlockSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // OTSUValLabel
            // 
            this.OTSUValLabel.AutoSize = true;
            this.OTSUValLabel.Location = new System.Drawing.Point(1006, 20);
            this.OTSUValLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OTSUValLabel.Name = "OTSUValLabel";
            this.OTSUValLabel.Size = new System.Drawing.Size(0, 13);
            this.OTSUValLabel.TabIndex = 5;
            // 
            // lblOtsu
            // 
            this.lblOtsu.AutoSize = true;
            this.lblOtsu.Location = new System.Drawing.Point(823, 17);
            this.lblOtsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtsu.Name = "lblOtsu";
            this.lblOtsu.Size = new System.Drawing.Size(184, 13);
            this.lblOtsu.TabIndex = 4;
            this.lblOtsu.Text = "OTSU Automatic Thersholding Value:";
            // 
            // numericReplace
            // 
            this.numericReplace.Location = new System.Drawing.Point(262, 16);
            this.numericReplace.Margin = new System.Windows.Forms.Padding(2);
            this.numericReplace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericReplace.Name = "numericReplace";
            this.numericReplace.Size = new System.Drawing.Size(60, 20);
            this.numericReplace.TabIndex = 3;
            this.numericReplace.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Replaced Value:";
            // 
            // numericThershold
            // 
            this.numericThershold.Location = new System.Drawing.Point(100, 16);
            this.numericThershold.Margin = new System.Windows.Forms.Padding(2);
            this.numericThershold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericThershold.Name = "numericThershold";
            this.numericThershold.Size = new System.Drawing.Size(60, 20);
            this.numericThershold.TabIndex = 1;
            this.numericThershold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thershold Value:";
            // 
            // diffBox
            // 
            this.diffBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.diffBox.Location = new System.Drawing.Point(12, 449);
            this.diffBox.Margin = new System.Windows.Forms.Padding(2);
            this.diffBox.Name = "diffBox";
            this.diffBox.Size = new System.Drawing.Size(171, 140);
            this.diffBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diffBox.TabIndex = 5;
            this.diffBox.TabStop = false;
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultBox.Location = new System.Drawing.Point(1027, 17);
            this.resultBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(171, 153);
            this.resultBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resultBox.TabIndex = 4;
            this.resultBox.TabStop = false;
            // 
            // camerabox
            // 
            this.camerabox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.camerabox.Location = new System.Drawing.Point(0, 0);
            this.camerabox.Margin = new System.Windows.Forms.Padding(2);
            this.camerabox.Name = "camerabox";
            this.camerabox.Size = new System.Drawing.Size(202, 156);
            this.camerabox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.camerabox.TabIndex = 3;
            this.camerabox.TabStop = false;
            // 
            // avgImage
            // 
            this.avgImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.avgImage.Location = new System.Drawing.Point(996, 420);
            this.avgImage.Margin = new System.Windows.Forms.Padding(2);
            this.avgImage.Name = "avgImage";
            this.avgImage.Size = new System.Drawing.Size(202, 169);
            this.avgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avgImage.TabIndex = 6;
            this.avgImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.avgImage);
            this.groupBox1.Controls.Add(this.diffBox);
            this.groupBox1.Controls.Add(this.resultBox);
            this.groupBox1.Controls.Add(this.camerabox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1209, 600);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // frmEmguFaceDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1209, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmguFaceDetection";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Emgu Face Detection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmguFaceDetection_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericReplace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThershold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camerabox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericBlockSize;
        private System.Windows.Forms.Label OTSUValLabel;
        private System.Windows.Forms.Label lblOtsu;
        private System.Windows.Forms.NumericUpDown numericReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericThershold;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox resultBox;
        private Emgu.CV.UI.ImageBox camerabox;
        private System.Windows.Forms.ToolStripMenuItem thersholdingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryInvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toZeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toZeroInvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTSUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addaptiveMainBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addaptiveMainBinaryInvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addaptiveGaussianBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addaptiveGaussianBinaryInvToolStripMenuItem;
        private Emgu.CV.UI.ImageBox diffBox;
        private Emgu.CV.UI.ImageBox avgImage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

