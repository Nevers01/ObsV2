namespace Obs.Ui
{
    partial class Loginform
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
            LoginUsername_txt = new MaterialSkin.Controls.MaterialTextBox();
            LoginPassword_txt = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            Login_btn = new MaterialSkin.Controls.MaterialButton();
            MainMenu_btn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // LoginUsername_txt
            // 
            LoginUsername_txt.AnimateReadOnly = false;
            LoginUsername_txt.BorderStyle = BorderStyle.None;
            LoginUsername_txt.Depth = 0;
            LoginUsername_txt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LoginUsername_txt.LeadingIcon = null;
            LoginUsername_txt.Location = new Point(263, 90);
            LoginUsername_txt.MaxLength = 50;
            LoginUsername_txt.MouseState = MaterialSkin.MouseState.OUT;
            LoginUsername_txt.Multiline = false;
            LoginUsername_txt.Name = "LoginUsername_txt";
            LoginUsername_txt.Size = new Size(244, 50);
            LoginUsername_txt.TabIndex = 0;
            LoginUsername_txt.Text = "";
            LoginUsername_txt.TrailingIcon = null;
            // 
            // LoginPassword_txt
            // 
            LoginPassword_txt.AnimateReadOnly = false;
            LoginPassword_txt.BorderStyle = BorderStyle.None;
            LoginPassword_txt.Depth = 0;
            LoginPassword_txt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LoginPassword_txt.LeadingIcon = null;
            LoginPassword_txt.Location = new Point(263, 191);
            LoginPassword_txt.MaxLength = 50;
            LoginPassword_txt.MouseState = MaterialSkin.MouseState.OUT;
            LoginPassword_txt.Multiline = false;
            LoginPassword_txt.Name = "LoginPassword_txt";
            LoginPassword_txt.Size = new Size(244, 50);
            LoginPassword_txt.TabIndex = 1;
            LoginPassword_txt.Text = "";
            LoginPassword_txt.TrailingIcon = null;
            LoginPassword_txt.KeyDown += LoginPassword_txt_KeyDown;
            LoginPassword_txt.Password = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(263, 68);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(89, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Kullanıcı Adı";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(263, 169);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(34, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Şifre";
            // 
            // Login_btn
            // 
            Login_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Login_btn.BackColor = SystemColors.Control;
            Login_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Login_btn.Depth = 0;
            Login_btn.HighEmphasis = true;
            Login_btn.Icon = null;
            Login_btn.Location = new Point(338, 283);
            Login_btn.Margin = new Padding(4, 6, 4, 6);
            Login_btn.MouseState = MaterialSkin.MouseState.HOVER;
            Login_btn.Name = "Login_btn";
            Login_btn.NoAccentTextColor = Color.Empty;
            Login_btn.Size = new Size(89, 36);
            Login_btn.TabIndex = 4;
            Login_btn.Text = "Giriş Yap";
            Login_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Login_btn.UseAccentColor = false;
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // MainMenu_btn
            // 
            MainMenu_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainMenu_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            MainMenu_btn.Depth = 0;
            MainMenu_btn.HighEmphasis = true;
            MainMenu_btn.Icon = null;
            MainMenu_btn.Location = new Point(307, 340);
            MainMenu_btn.Margin = new Padding(4, 6, 4, 6);
            MainMenu_btn.MouseState = MaterialSkin.MouseState.HOVER;
            MainMenu_btn.Name = "MainMenu_btn";
            MainMenu_btn.NoAccentTextColor = Color.Empty;
            MainMenu_btn.Size = new Size(148, 36);
            MainMenu_btn.TabIndex = 5;
            MainMenu_btn.Text = "Ana Menüye Dön";
            MainMenu_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            MainMenu_btn.UseAccentColor = false;
            MainMenu_btn.UseVisualStyleBackColor = true;
            MainMenu_btn.Click += MainMenu_btn_Click;
            // 
            // Loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainMenu_btn);
            Controls.Add(Login_btn);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(LoginPassword_txt);
            Controls.Add(LoginUsername_txt);
            Name = "Loginform";
            Text = "Obs | Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox LoginUsername_txt;
        private MaterialSkin.Controls.MaterialTextBox LoginPassword_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton Login_btn;
        private MaterialSkin.Controls.MaterialButton MainMenu_btn;
    }
}