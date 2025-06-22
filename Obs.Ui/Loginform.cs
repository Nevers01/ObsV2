using Obs.Core.Helper;
using System;
using System.Windows.Forms;

namespace Obs.Ui
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var dbContext = new ObsDbContext();
            var loginService = new LoginHelper(dbContext);

            var result = loginService.LoginControl(LoginUsername_txt.Text, LoginPassword_txt.Text);

            if (result.IsSuccess)
            {
                MessageBox.Show($"Hoşgeldin {LoginUsername_txt.Text}! Giriş başarılı.");

                if (result.IsAdmin)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Retry; // örnek olarak
                }

                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainMenu_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoginPassword_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_btn.PerformClick(); // Giriş işlemini tetikler
            }
        }
    }
}