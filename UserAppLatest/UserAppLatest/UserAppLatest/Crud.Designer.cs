namespace UserAppLatest
{
    partial class Crud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            crudUserID = new Guna.UI2.WinForms.Guna2TextBox();
            crudUserName = new Guna.UI2.WinForms.Guna2TextBox();
            usrPassword = new Guna.UI2.WinForms.Guna2TextBox();
            dataGridView1 = new DataGridView();
            btnInsert = new Custom_Controls_in_CS.ButtonZ();
            buttonz1 = new Custom_Controls_in_CS.ButtonZ();
            buttonz2 = new Custom_Controls_in_CS.ButtonZ();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 15, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 44);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 10);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "label";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 44);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(314, 7);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            // 
            // crudUserID
            // 
            crudUserID.CustomizableEdges = customizableEdges1;
            crudUserID.DefaultText = "";
            crudUserID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            crudUserID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            crudUserID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            crudUserID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            crudUserID.FocusedState.BorderColor = Color.Black;
            crudUserID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crudUserID.ForeColor = Color.Black;
            crudUserID.HoverState.BorderColor = Color.White;
            crudUserID.Location = new Point(28, 75);
            crudUserID.Margin = new Padding(3, 4, 3, 4);
            crudUserID.Name = "crudUserID";
            crudUserID.PasswordChar = '\0';
            crudUserID.PlaceholderText = "";
            crudUserID.SelectedText = "";
            crudUserID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            crudUserID.Size = new Size(199, 30);
            crudUserID.TabIndex = 1;
            // 
            // crudUserName
            // 
            crudUserName.CustomizableEdges = customizableEdges3;
            crudUserName.DefaultText = "";
            crudUserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            crudUserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            crudUserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            crudUserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            crudUserName.FocusedState.BorderColor = Color.Black;
            crudUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crudUserName.ForeColor = Color.Black;
            crudUserName.HoverState.BorderColor = Color.White;
            crudUserName.Location = new Point(268, 75);
            crudUserName.Margin = new Padding(3, 4, 3, 4);
            crudUserName.Name = "crudUserName";
            crudUserName.PasswordChar = '\0';
            crudUserName.PlaceholderText = "";
            crudUserName.SelectedText = "";
            crudUserName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            crudUserName.Size = new Size(258, 30);
            crudUserName.TabIndex = 2;
            // 
            // usrPassword
            // 
            usrPassword.CustomizableEdges = customizableEdges5;
            usrPassword.DefaultText = "";
            usrPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            usrPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            usrPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            usrPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            usrPassword.FocusedState.BorderColor = Color.Black;
            usrPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usrPassword.ForeColor = Color.Black;
            usrPassword.HoverState.BorderColor = Color.White;
            usrPassword.Location = new Point(567, 75);
            usrPassword.Margin = new Padding(3, 4, 3, 4);
            usrPassword.Name = "usrPassword";
            usrPassword.PasswordChar = '\0';
            usrPassword.PlaceholderText = "";
            usrPassword.SelectedText = "";
            usrPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            usrPassword.Size = new Size(216, 30);
            usrPassword.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(238, 239, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(142, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(553, 240);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Transparent;
            btnInsert.BorderColor = Color.Transparent;
            btnInsert.BorderWidth = 0;
            btnInsert.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            btnInsert.ButtonText = "ADD USER";
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.EndColor = Color.FromArgb(127, 0, 255);
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnInsert.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            btnInsert.ForeColor = Color.White;
            btnInsert.GradientAngle = 90;
            btnInsert.Location = new Point(73, 378);
            btnInsert.MouseClickColor1 = Color.DarkOrchid;
            btnInsert.MouseClickColor2 = Color.DarkOrchid;
            btnInsert.MouseHoverColor1 = Color.DarkOrchid;
            btnInsert.MouseHoverColor2 = Color.DarkOrchid;
            btnInsert.Name = "btnInsert";
            btnInsert.ShowButtontext = true;
            btnInsert.Size = new Size(198, 40);
            btnInsert.StartColor = Color.FromArgb(127, 0, 255);
            btnInsert.TabIndex = 5;
            btnInsert.TextLocation_X = 60;
            btnInsert.TextLocation_Y = 12;
            btnInsert.Transparent1 = 250;
            btnInsert.Transparent2 = 250;
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // buttonz1
            // 
            buttonz1.BackColor = Color.Transparent;
            buttonz1.BorderColor = Color.Transparent;
            buttonz1.BorderWidth = 0;
            buttonz1.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            buttonz1.ButtonText = "EDIT USER";
            buttonz1.Cursor = Cursors.Hand;
            buttonz1.EndColor = Color.FromArgb(15, 82, 186);
            buttonz1.FlatAppearance.BorderSize = 0;
            buttonz1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonz1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonz1.FlatStyle = FlatStyle.Flat;
            buttonz1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonz1.ForeColor = Color.White;
            buttonz1.GradientAngle = 90;
            buttonz1.Location = new Point(320, 378);
            buttonz1.MouseClickColor1 = Color.Teal;
            buttonz1.MouseClickColor2 = Color.Teal;
            buttonz1.MouseHoverColor1 = Color.Teal;
            buttonz1.MouseHoverColor2 = Color.Teal;
            buttonz1.Name = "buttonz1";
            buttonz1.ShowButtontext = true;
            buttonz1.Size = new Size(198, 40);
            buttonz1.StartColor = Color.FromArgb(15, 82, 186);
            buttonz1.TabIndex = 6;
            buttonz1.TextLocation_X = 60;
            buttonz1.TextLocation_Y = 12;
            buttonz1.Transparent1 = 250;
            buttonz1.Transparent2 = 250;
            buttonz1.UseVisualStyleBackColor = false;
            buttonz1.Click += buttonz1_Click;
            // 
            // buttonz2
            // 
            buttonz2.BackColor = Color.Transparent;
            buttonz2.BorderColor = Color.Transparent;
            buttonz2.BorderWidth = 0;
            buttonz2.ButtonShape = Custom_Controls_in_CS.ButtonZ.ButtonsShapes.Rect;
            buttonz2.ButtonText = "DELETE USER";
            buttonz2.Cursor = Cursors.Hand;
            buttonz2.EndColor = Color.FromArgb(210, 43, 43);
            buttonz2.FlatAppearance.BorderSize = 0;
            buttonz2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonz2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonz2.FlatStyle = FlatStyle.Flat;
            buttonz2.Font = new Font("Nirmala UI", 9F, FontStyle.Bold);
            buttonz2.ForeColor = Color.White;
            buttonz2.GradientAngle = 90;
            buttonz2.Location = new Point(567, 378);
            buttonz2.MouseClickColor1 = Color.Red;
            buttonz2.MouseClickColor2 = Color.Red;
            buttonz2.MouseHoverColor1 = Color.Red;
            buttonz2.MouseHoverColor2 = Color.Red;
            buttonz2.Name = "buttonz2";
            buttonz2.ShowButtontext = true;
            buttonz2.Size = new Size(198, 40);
            buttonz2.StartColor = Color.FromArgb(210, 43, 43);
            buttonz2.TabIndex = 7;
            buttonz2.TextLocation_X = 60;
            buttonz2.TextLocation_Y = 12;
            buttonz2.Transparent1 = 250;
            buttonz2.Transparent2 = 250;
            buttonz2.UseVisualStyleBackColor = false;
            buttonz2.Click += buttonz2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 53);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 8;
            label3.Text = "UserID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(268, 53);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 9;
            label4.Text = "UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(567, 53);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // Crud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonz2);
            Controls.Add(buttonz1);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(usrPassword);
            Controls.Add(crudUserName);
            Controls.Add(crudUserID);
            Controls.Add(panel1);
            Name = "Crud";
            Text = "Crud";
            Load += Crud_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox crudUserID;
        private Guna.UI2.WinForms.Guna2TextBox crudUserName;
        private Guna.UI2.WinForms.Guna2TextBox usrPassword;
        private DataGridView dataGridView1;
        private Custom_Controls_in_CS.ButtonZ btnInsert;
        private Custom_Controls_in_CS.ButtonZ buttonz1;
        private Custom_Controls_in_CS.ButtonZ buttonz2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}