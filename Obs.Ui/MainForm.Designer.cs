namespace Obs.Ui
{
    partial class MainForm
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
            loginform_btn = new Button();
            appexit_btn = new Button();
            SuspendLayout();
            // 
            // loginform_btn
            // 
            loginform_btn.Location = new Point(12, 35);
            loginform_btn.Name = "loginform_btn";
            loginform_btn.Size = new Size(166, 77);
            loginform_btn.TabIndex = 0;
            loginform_btn.Text = "Giriş Ekranı";
            loginform_btn.UseVisualStyleBackColor = true;
            loginform_btn.Click += loginform_btn_Click;
            // 
            // appexit_btn
            // 
            appexit_btn.Location = new Point(416, 35);
            appexit_btn.Name = "appexit_btn";
            appexit_btn.Size = new Size(166, 77);
            appexit_btn.TabIndex = 1;
            appexit_btn.Text = "Uygulamayı Kapat";
            appexit_btn.UseVisualStyleBackColor = true;
            appexit_btn.Click += appexit_btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 148);
            Controls.Add(appexit_btn);
            Controls.Add(loginform_btn);
            Name = "MainForm";
            Text = "Obs | Ana Sayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button loginform_btn;
        private Button appexit_btn;
    }
}