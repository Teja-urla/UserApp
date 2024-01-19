namespace UserAppLatest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            forgotPassword = new LinkLabel();
            panel4 = new Panel();
            checkBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            buttonz1 = new Custom_Controls_in_CS.ButtonZ();
            Form1UsrPassword = new Guna.UI2.WinForms.Guna2TextBox();
            Form1UsrID = new Guna.UI2.WinForms.Guna2TextBox();
            radiobtnUser = new RadioButton();
            radiobtnAdmin = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(forgotPassword);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonz1);
            panel1.Controls.Add(Form1UsrPassword);
            panel1.Controls.Add(Form1UsrID);
            panel1.Controls.Add(radiobtnUser);
            panel1.Controls.Add(radiobtnAdmin);
            panel1.Location = new Point(115, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 362);
            panel1.TabIndex = 0;
            // 
            // forgotPassword
            // 
            forgotPassword.AutoSize = true;
            forgotPassword.Cursor = Cursors.Hand;
            forgotPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            forgotPassword.Location = new Point(255, 327);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(123, 20);
            forgotPassword.TabIndex = 12;
            forgotPassword.TabStop = true;
            forgotPassword.Text = "ForgotPassword";
            forgotPassword.LinkClicked += forgotPassword_LinkClicked;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(checkBox);
            panel4.Location = new Point(524, 209);
            panel4.Name = "panel4";
            panel4.Size = new Size(30, 30);
            panel4.TabIndex = 10;
            panel4.Paint += panel4_Paint;
            // 
            // checkBox
            // 
            checkBox.BackColor = Color.Transparent;
            checkBox.CheckedState.BorderColor = Color.Transparent;
            checkBox.CheckedState.BorderRadius = 2;
            checkBox.CheckedState.BorderThickness = 0;
            checkBox.CheckedState.FillColor = Color.Transparent;
            checkBox.CheckMarkColor = Color.Transparent;
            checkBox.Cursor = Cursors.Hand;
            checkBox.CustomizableEdges = customizableEdges1;
            checkBox.Location = new Point(0, 0);
            checkBox.Name = "checkBox";
            checkBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            checkBox.Size = new Size(30, 30);
            checkBox.TabIndex = 11;
            checkBox.Text = "guna2CustomCheckBox1";
            checkBox.UncheckedState.BorderColor = Color.Transparent;
            checkBox.UncheckedState.BorderRadius = 2;
            checkBox.UncheckedState.BorderThickness = 0;
            checkBox.UncheckedState.FillColor = Color.Transparent;
            checkBox.Click += checkBox_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(380, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(61, 62);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(140, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 62);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 216);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "UserID";
            // 
            // buttonz1
            // 
            buttonz1.BackColor = Color.Transparent;
            buttonz1.BorderColor = Color.Transparent;
            buttonz1.BorderWidth = 0;
            buttonz1.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            buttonz1.ButtonText = "Log in";
            buttonz1.Cursor = Cursors.Hand;
            buttonz1.EndColor = Color.FromArgb(127, 0, 255);
            buttonz1.FlatAppearance.BorderSize = 0;
            buttonz1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonz1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonz1.FlatStyle = FlatStyle.Flat;
            buttonz1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonz1.ForeColor = Color.White;
            buttonz1.GradientAngle = 90;
            buttonz1.Location = new Point(115, 277);
            buttonz1.MouseClickColor1 = Color.FromArgb(133, 0, 189);
            buttonz1.MouseClickColor2 = Color.FromArgb(133, 0, 189);
            buttonz1.MouseHoverColor1 = Color.FromArgb(133, 0, 189);
            buttonz1.MouseHoverColor2 = Color.FromArgb(133, 0, 189);
            buttonz1.Name = "buttonz1";
            buttonz1.ShowButtontext = true;
            buttonz1.Size = new Size(384, 47);
            buttonz1.StartColor = Color.FromArgb(127, 0, 255);
            buttonz1.TabIndex = 4;
            buttonz1.Text = "buttonz1";
            buttonz1.TextLocation_X = 160;
            buttonz1.TextLocation_Y = 10;
            buttonz1.Transparent1 = 250;
            buttonz1.Transparent2 = 250;
            buttonz1.UseVisualStyleBackColor = false;
            buttonz1.Click += loginBtn;
            // 
            // Form1UsrPassword
            // 
            Form1UsrPassword.CustomizableEdges = customizableEdges3;
            Form1UsrPassword.DefaultText = "";
            Form1UsrPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Form1UsrPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Form1UsrPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Form1UsrPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Form1UsrPassword.FocusedState.BorderColor = Color.Black;
            Form1UsrPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Form1UsrPassword.ForeColor = Color.Black;
            Form1UsrPassword.HoverState.BorderColor = Color.White;
            Form1UsrPassword.Location = new Point(115, 204);
            Form1UsrPassword.Margin = new Padding(3, 4, 3, 4);
            Form1UsrPassword.Name = "Form1UsrPassword";
            Form1UsrPassword.PasswordChar = '●';
            Form1UsrPassword.PlaceholderText = "";
            Form1UsrPassword.SelectedText = "";
            Form1UsrPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Form1UsrPassword.Size = new Size(384, 47);
            Form1UsrPassword.TabIndex = 3;
            Form1UsrPassword.UseSystemPasswordChar = true;
            // 
            // Form1UsrID
            // 
            Form1UsrID.BackColor = Color.White;
            Form1UsrID.CustomizableEdges = customizableEdges5;
            Form1UsrID.DefaultText = "";
            Form1UsrID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Form1UsrID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Form1UsrID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Form1UsrID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Form1UsrID.FocusedState.BorderColor = Color.Black;
            Form1UsrID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Form1UsrID.ForeColor = Color.Black;
            Form1UsrID.HoverState.BorderColor = Color.White;
            Form1UsrID.Location = new Point(115, 123);
            Form1UsrID.Margin = new Padding(3, 4, 3, 4);
            Form1UsrID.Name = "Form1UsrID";
            Form1UsrID.PasswordChar = '\0';
            Form1UsrID.PlaceholderText = "";
            Form1UsrID.SelectedText = "";
            Form1UsrID.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Form1UsrID.Size = new Size(384, 47);
            Form1UsrID.TabIndex = 2;
            // 
            // radiobtnUser
            // 
            radiobtnUser.AutoSize = true;
            radiobtnUser.Cursor = Cursors.Hand;
            radiobtnUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiobtnUser.Location = new Point(380, 70);
            radiobtnUser.Name = "radiobtnUser";
            radiobtnUser.Size = new Size(61, 24);
            radiobtnUser.TabIndex = 1;
            radiobtnUser.TabStop = true;
            radiobtnUser.Text = "User";
            radiobtnUser.UseVisualStyleBackColor = true;
            // 
            // radiobtnAdmin
            // 
            radiobtnAdmin.AutoSize = true;
            radiobtnAdmin.Cursor = Cursors.Hand;
            radiobtnAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radiobtnAdmin.Location = new Point(140, 70);
            radiobtnAdmin.Name = "radiobtnAdmin";
            radiobtnAdmin.Size = new Size(75, 24);
            radiobtnAdmin.TabIndex = 0;
            radiobtnAdmin.TabStop = true;
            radiobtnAdmin.Text = "Admin";
            radiobtnAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 38);
            label1.TabIndex = 1;
            label1.Text = "Log in";
            // 
            // button1
            // 
            button1.Location = new Point(477, 65);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private RadioButton radiobtnUser;
        private RadioButton radiobtnAdmin;
        private Guna.UI2.WinForms.Guna2TextBox Form1UsrID;
        private Guna.UI2.WinForms.Guna2TextBox Form1UsrPassword;
        private Custom_Controls_in_CS.ButtonZ buttonz1;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2CustomCheckBox checkBox;
        private LinkLabel forgotPassword;
        private Button button1;
    }
}
