namespace UserAppLatest
{
    partial class ForgotPassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            verifyOTP = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges5;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(237, 154);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmail.Size = new Size(322, 46);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 96);
            label1.Name = "label1";
            label1.Size = new Size(236, 23);
            label1.TabIndex = 2;
            label1.Text = "Enter your OTP sent via mail";
            label1.Click += label1_Click;
            // 
            // verifyOTP
            // 
            verifyOTP.Cursor = Cursors.Hand;
            verifyOTP.CustomizableEdges = customizableEdges7;
            verifyOTP.DisabledState.BorderColor = Color.DarkGray;
            verifyOTP.DisabledState.CustomBorderColor = Color.DarkGray;
            verifyOTP.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            verifyOTP.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            verifyOTP.FillColor = Color.FromArgb(127, 0, 255);
            verifyOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            verifyOTP.ForeColor = Color.White;
            verifyOTP.Location = new Point(237, 224);
            verifyOTP.Name = "verifyOTP";
            verifyOTP.ShadowDecoration.CustomizableEdges = customizableEdges8;
            verifyOTP.Size = new Size(322, 46);
            verifyOTP.TabIndex = 3;
            verifyOTP.Text = "Verify";
            verifyOTP.Click += verifyOTP_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(verifyOTP);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button verifyOTP;
    }
}