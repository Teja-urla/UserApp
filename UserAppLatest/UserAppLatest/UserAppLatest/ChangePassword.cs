using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserAppLatest
{
    public partial class ChangePassword : Form
    {
        string userName = "";
        string userID = "";
        public ChangePassword(string str)
        {
            userName = str;
            InitializeComponent();
        }

        private void getAdminID()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");

            string checkExistenceSQL = "SELECT userid FROM userApp WHERE userlevel = 1";

            SQLiteCommand checkExistenceCommand = new SQLiteCommand(checkExistenceSQL, conn);
            try
            {
                conn.Open();

                userID = Convert.ToString(checkExistenceCommand.ExecuteScalar());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void updateUser()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");

            string updateSQL = "UPDATE userApp SET password = @password WHERE userid = @userid";

            SQLiteCommand updateCommand = new SQLiteCommand(updateSQL, conn);

            updateCommand.Parameters.AddWithValue("@userid", userID);  // Assuming userid is of text type
            updateCommand.Parameters.AddWithValue("@password", confirmPassword.Text);  // Assuming password is of text type

            try
            {
                conn.Open();
                string st = confirmPassword.Text;
                int length = confirmPassword.Text.Length;
                if (length < 8)
                {
                    MessageBox.Show("Minimum 8 characters required");
                }
                else if (st[0] >= 'a' && st[0] <= 'z')
                {
                    MessageBox.Show("Password First letter of Password require Caps");
                }
                else
                {
                    bool flag = false; // flag is for checking wheather the password contains a special character or not
                    for (global::System.Int32 i = 0; i < length; i++)
                    {
                        if (char.IsLetter(st[i]) || char.IsDigit(st[i]))
                        {
                            continue;
                        }
                        else
                        {
                            flag = true; break;
                        }
                    }
                    if (flag)
                    {
                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("User Info Updated");
                    }
                    else
                    {
                        MessageBox.Show("Password should contain a special character");
                    }
                }
                // updateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            getAdminID();
            label1.Text = userName;
        }

        private void updateFunction()
        {
            if (enterPassword.Text != confirmPassword.Text)
            {
                MessageBox.Show("Your password and confirmation password are not matching");
                enterPassword.Text = "";
                confirmPassword.Text = "";
            }
            else
            {
                this.Hide();
                updateUser();
                Admin admin = new Admin(userName);
                admin.ShowDialog();
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

        private void updateButton(object sender, EventArgs e)
        {
            if (pingStatus())
            {
                updateFunction();
            }
            else
            {
                InternetConnectivity internetConnectivity = new InternetConnectivity();
                internetConnectivity.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
