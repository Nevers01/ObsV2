using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obs.Ui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginform_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            var loginForm = new Loginform();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void appexit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}