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

namespace UserAppLatest
{
    public partial class Crud : Form
    {
        string CrudUserName = "";
        public Crud(string str)
        {
            CrudUserName = str;
            // CrudUserName.ToUpper();
            InitializeComponent();
        }
        int selectedRow;
        /// <summary>
        /// FOR DISPLAYING THE DATA FROM THE DATABASE IN THE GRID
        /// </summary>
        public void PrintUserData()
        {
            string connectionString = "Data Source=test.db;Version=3";  // Replace with your SQLite connection string
            string selectQuery = "SELECT * FROM userApp";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection))
                {
                    try
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        /// <summary>
        /// WHEN CLICKED, THE SELECTED ITEMS GETS DISPLAYED ON THE TEXTBOXEX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            crudUserID.Text = row.Cells["userid"].Value.ToString();
            crudUserName.Text = row.Cells["username"].Value.ToString();
            usrPassword.Text = row.Cells["password"].Value.ToString();

        }

        /* SEARCHES THE DATABASE WHEATHER THE GIVEN USERID IS PRESENT OR NOT  */
        private bool findUser(string userid)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");

            string checkExistenceSQL = "SELECT COUNT(*) FROM userApp WHERE userid = @userid";

            SQLiteCommand checkExistenceCommand = new SQLiteCommand(checkExistenceSQL, conn);
            checkExistenceCommand.Parameters.AddWithValue("@userid", userid);

            try
            {
                conn.Open();

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
        /// INSERTS THE USER INFO INTO THE DATABASE
        /// </summary>
        private void insertUser()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");
            try
            {
                conn.Open();
                Console.WriteLine("Connected to SQLite!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            finally
            {
                conn.Close();
            }
            if (!findUser(crudUserID.Text))
            {
                string insertSql = "INSERT INTO userApp (userlevel, userid, username, password) VALUES (@userlevel, @userid, @username, @password)";

                SQLiteCommand insertCommand = new SQLiteCommand(insertSql, conn);
                insertCommand.Parameters.AddWithValue("@userid", crudUserID.Text);
                insertCommand.Parameters.AddWithValue("@username", crudUserName.Text);
                insertCommand.Parameters.AddWithValue("@password", usrPassword.Text);
                insertCommand.Parameters.AddWithValue("@userlevel", 2);

                try
                {
                    conn.Open();
                    string st = usrPassword.Text;
                    int length = usrPassword.Text.Length;
                    if(crudUserID.Text.Length == 0 || crudUserName.Text.Length == 0) {
                        MessageBox.Show("Enter valid User ID/ Username");
                    }
                    else if (length < 8)
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
                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("User Info Inserted");
                        }
                        else
                        {
                            MessageBox.Show("Password should contain a special character");
                        }
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
            }
            else
            {
                MessageBox.Show("User Exists with the given Info");
            }
        }

        private void updateUser()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");

            if (findUser(crudUserID.Text))
            {
                string updateSQL = "UPDATE userApp SET username = @username, password = @password WHERE userid = @userid";

                SQLiteCommand updateCommand = new SQLiteCommand(updateSQL, conn);

                updateCommand.Parameters.AddWithValue("@userid", crudUserID.Text);  // Assuming userid is of numeric type
                updateCommand.Parameters.AddWithValue("@username", crudUserName.Text);  // Assuming username is of text type
                updateCommand.Parameters.AddWithValue("@password", usrPassword.Text);  // Assuming password is of text type

                try
                {
                    conn.Open();
                    string st = usrPassword.Text;
                    int length = usrPassword.Text.Length;
                    if (crudUserID.Text.Length == 0 || crudUserName.Text.Length == 0)
                    {
                        MessageBox.Show("Enter valid User ID/ Username");
                    }
                    else if (length < 8)
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
            else
            {
                MessageBox.Show("Incorrect UserName or Password");
            }
        }

        private void deleteUser()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=test.db;Version=3");

            if (findUser(crudUserID.Text))
            {
                string deleteSQL = "DELETE FROM userApp WHERE userid = @userid";
                SQLiteCommand deleteCommand = new SQLiteCommand(deleteSQL, conn);

                deleteCommand.Parameters.AddWithValue("@userid", crudUserID.Text);  // Assuming userid is of numeric type

                try
                {
                    conn.Open();
                    DialogResult res = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("User Successfully Deleted");
                    }
                    else
                    {
                        MessageBox.Show("User Deletion Cancelled");
                    }

                    Console.WriteLine("User deleted successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
                // MessageBox.Show("User Successfully Deleted");

            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            label2.Text = CrudUserName; // For displaying userName
            PrintUserData();
        }
        /// <summary>
        /// CHECKING WHEATHER INTERNET CONNECTION IS PRESENT OR NOT.
        /// </summary>
        /// <returns></returns>
        public bool pingStatus()
        {
            bool pingstatus = false;
            string hostNameOrAddress = "Google.com";
            // Creating a new Instance of Ping class
            using (Ping p = new Ping())
            {
                // data to be sent during the ping request
                string data = "aaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;
                try
                {
                    // Sends a ping request to the specified host with the defined timeout and data buffer
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                insertUser();
                PrintUserData();
            }
            else
            {
                InternetConnectivity internetConnectivity = new InternetConnectivity();
                internetConnectivity.Show();
            }
        }

        private void buttonz1_Click(object sender, EventArgs e)
        {
            if(pingStatus() == true)
            {
                updateUser();
                PrintUserData();
            }
            else
            {
                InternetConnectivity internetConnectivity = new InternetConnectivity();
                internetConnectivity.Show();
            }
        }

        private void buttonz2_Click(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                deleteUser();
                PrintUserData();
            }
            else
            {
                InternetConnectivity internetConnectivity = new InternetConnectivity();
                internetConnectivity.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
