using Obs.Core.Models;
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
    public partial class AdminForm : Form
    {
        private void AdminForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            Cursor.Show();
            this.Cursor = Cursors.Default;
        }

        private void HİKİekle_btn_Click(object sender, EventArgs e)
        {
            var form = new AddForm(typeof(User)); // örnek tablo
            form.ShowDialog();
        }

        private void HİKİdüzenle_btn_Click(object sender, EventArgs e)
        {
        }

        private void HİDİekle_btn_Click(object sender, EventArgs e)
        {
            var form = new AddForm(typeof(Discontinuity)); // örnek tablo
            form.ShowDialog();
        }

        private void adminlogout_btn_Click(object sender, EventArgs e)
        {
            this.Close();

            // LoginForm açık mı kontrol et
            var exitLoginForm = Application.OpenForms["Loginform"];

            if (exitLoginForm != null)
            {
                exitLoginForm.Show();
            }
            else
            {
                // Eğer açık değilse yeni bir tane oluştur ve göster
                var newLoginForm = new Loginform();
                newLoginForm.Show();
            }
        }
    }
}