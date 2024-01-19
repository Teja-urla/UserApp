namespace UserAppLatest
{
    partial class InternetConnectivity
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            internetStatusText = new Label();
            wifiPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)wifiPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 28);
            label1.TabIndex = 0;
            label1.Text = "Internet Connectivity Checking...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // internetStatusText
            // 
            internetStatusText.AutoSize = true;
            internetStatusText.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            internetStatusText.Location = new Point(247, 126);
            internetStatusText.Margin = new Padding(4, 0, 4, 0);
            internetStatusText.Name = "internetStatusText";
            internetStatusText.Size = new Size(0, 25);
            internetStatusText.TabIndex = 1;
            // 
            // wifiPic
            // 
            wifiPic.Location = new Point(92, 118);
            wifiPic.Name = "wifiPic";
            wifiPic.Size = new Size(75, 60);
            wifiPic.TabIndex = 2;
            wifiPic.TabStop = false;
            wifiPic.Click += pictureBox1_Click;
            // 
            // InternetConnectivity
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 364);
            Controls.Add(wifiPic);
            Controls.Add(internetStatusText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "InternetConnectivity";
            Text = "InternetConnectivity";
            Load += InternetConnectivity_Load;
            ((System.ComponentModel.ISupportInitialize)wifiPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label internetStatusText;
        private PictureBox wifiPic;
    }
}