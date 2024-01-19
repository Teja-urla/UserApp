using System;
using System.Data.SQLite;
using System.Net.NetworkInformation;
using System.Text;

namespace UserAppLatest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool visible = false; // show/don't show password
        int userLevel = 0; // for finding userlevel

        /// <summary>
        /// IT RETURNS USERNAME
        /// </summary>
        /// <returns></returns>
        private string get_username()
        {
            string username = null;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3"))
            {
                int employee = 0;

                if (radiobtnAdmin.Checked) { employee = 1; userLevel = 1; } // Choosing admin
                else if (radiobtnUser.Checked) { employee = 2; userLevel = 2; } // Choosing user

                string checkExistenceSQL = "SELECT username FROM userApp WHERE userid = @userid and userlevel = @userlevel and password = @password";

                using (SQLiteCommand checkExistenceCommand = new SQLiteCommand(checkExistenceSQL, conn))
                {
                    checkExistenceCommand.Parameters.AddWithValue("@userid", Form1UsrID.Text);
                    checkExistenceCommand.Parameters.AddWithValue("@password", Form1UsrPassword.Text);
                    checkExistenceCommand.Parameters.AddWithValue("@userlevel", employee);

                    try
                    {
                        conn.Open();

                        object result = checkExistenceCommand.ExecuteScalar();

                        if (result != null)
                        {
                            username = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }

            return username;
        }
        /// <summary>
        /// IT CHECKS WHEATHER EMPLOYEE IS PRESENT OR NOT
        /// </summary>
        /// <returns></returns>
        private bool findEmployee()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");
            int employee = 0;
            if (radiobtnAdmin.Checked) { employee = 1; }
            else if (radiobtnUser.Checked) { employee = 2; }
            string checkExistenceSQL = "SELECT COUNT(*) FROM userApp WHERE userid = @userid and userlevel = @userlevel and password = @password";

            SQLiteCommand checkExistenceCommand = new SQLiteCommand(checkExistenceSQL, conn);
            checkExistenceCommand.Parameters.AddWithValue("@userid", Form1UsrID.Text);
            checkExistenceCommand.Parameters.AddWithValue("@password", Form1UsrPassword.Text);
            checkExistenceCommand.Parameters.AddWithValue("@userlevel", employee);

            try
            {
                conn.Open();

                // Finding the number of users present in the database.If present it returns nonZero value
                int userCount = Convert.ToInt32(checkExistenceCommand.ExecuteScalar());

                if (userCount > 0)
                {
                    /* Well You can Proceed */
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return false;
            // MessageBox.Show("USER INVALID");
        }

        /// <summary>
        /// USER/ADMIN GETS LOGINED IF THEIR DATA IS PRESENT 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn(object sender, EventArgs e)
        {
            bool find_employee = findEmployee();
            bool admincheck = radiobtnAdmin.Checked;
            bool usercheck = radiobtnUser.Checked;
            string usr_name = get_username();
            if (find_employee)
            {
                if (admincheck)
                {
                    MessageBox.Show("Admin Login Successful");
                    Admin admin = new Admin(usr_name); // Admin.cs file
                    admin.ShowDialog();
                }
                else if (usercheck)
                {
                    MessageBox.Show("User Login Successful");
                    User user = new User();
                    user.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Select Admin/User");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username/Password");
            }
        }

        /// <summary>
        /// DONT CARE ABOUT THE FOLLOWING FUNCTION. ITS USELESS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (visible == false)
            {
                Form1UsrPassword.UseSystemPasswordChar = false;
                visible = true;
            }
            else
            {
                Form1UsrPassword.UseSystemPasswordChar = true;
                visible = false;
            }
        }

        /// <summary>
        /// FOR ENABLE/ DISABLE SHOW PASSWORD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                Form1UsrPassword.PasswordChar = '\0'; // Show characters
            }
            else
            {
                Form1UsrPassword.PasswordChar = '●'; // Hide characters
            }
        }
        /// <summary>
        /// FOR CHECKING INTERCONNECTIVITY.
        /// </summary>
        /// <returns></returns>
        public bool pingStatus()
        {
            bool pingstatus = false;
            string hostNameOrAddress = "Google.com";
            using (Ping p = new Ping())
            {
                string data = "aaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;
                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingstatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception ex)
                {
                    pingstatus = false;
                }
                return pingstatus;
            }
        }

        /// <summary>
        /// FORGOT PASSWORD LINK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pingStatus() == true)
            {
                ForgotPassword forgotPassword = new ForgotPassword();
                forgotPassword.ShowDialog();
            }
            else
            {
                InternetConnectivity internetConnectivity = new InternetConnectivity();
                internetConnectivity.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InternetConnectivity internetConnectivity = new InternetConnectivity(); 
            internetConnectivity.ShowDialog();
        }
    }
}
