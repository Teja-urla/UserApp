using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAppLatest
{
    public partial class Admin : Form
    {
        string UserName = "";
        public Admin(string str)
        {
            UserName = str;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            adminLabel.Text = UserName;
        }
        /// <summary>
        /// SHOWS UP THE USERMANAGEMENT PAGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            Crud crud = new Crud(UserName);
            crud.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
