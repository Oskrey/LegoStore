
namespace LegoStore
{
    partial class FormAuth
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.buttonCapchaRefresh = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.textBoxAlert = new System.Windows.Forms.TextBox();
            this.timerDeny = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.buttonLook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(4, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(223, 17);
            this.labelWelcome.TabIndex = 18;
            this.labelWelcome.Text = "Д О Б Р О   П О Ж А Л О В А Т Ь";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 102);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(9, 55);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 15;
            this.labelLogin.Text = "Логин";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 263);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(214, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "ВОЙТИ";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 119);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(178, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(12, 72);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(215, 20);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(12, 239);
            this.textBoxCaptcha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(140, 20);
            this.textBoxCaptcha.TabIndex = 2;
            // 
            // buttonCapchaRefresh
            // 
            this.buttonCapchaRefresh.Location = new System.Drawing.Point(156, 239);
            this.buttonCapchaRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapchaRefresh.Name = "buttonCapchaRefresh";
            this.buttonCapchaRefresh.Size = new System.Drawing.Size(70, 19);
            this.buttonCapchaRefresh.TabIndex = 22;
            this.buttonCapchaRefresh.TabStop = false;
            this.buttonCapchaRefresh.Text = "Обновить";
            this.buttonCapchaRefresh.UseVisualStyleBackColor = true;
            this.buttonCapchaRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(82, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 15);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "LegoStore";
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTimer.Location = new System.Drawing.Point(6, 154);
            this.textBoxTimer.Multiline = true;
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(220, 132);
            this.textBoxTimer.TabIndex = 24;
            this.textBoxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimer.Visible = false;
            // 
            // textBoxAlert
            // 
            this.textBoxAlert.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlert.Location = new System.Drawing.Point(7, 7);
            this.textBoxAlert.Multiline = true;
            this.textBoxAlert.Name = "textBoxAlert";
            this.textBoxAlert.Size = new System.Drawing.Size(220, 132);
            this.textBoxAlert.TabIndex = 24;
            this.textBoxAlert.Text = "Вы заблокированы в системе\r\nза неудачные попытки входа";
            this.textBoxAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAlert.Visible = false;
            // 
            // timerDeny
            // 
            this.timerDeny.Interval = 1000;
            this.timerDeny.Tick += new System.EventHandler(this.timerDeny_Tick);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(12, 146);
            this.pictureBoxCaptcha.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(214, 88);
            this.pictureBoxCaptcha.TabIndex = 20;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // buttonLook
            // 
            this.buttonLook.BackgroundImage = global::LegoStore.Properties.Resources.Glaz;
            this.buttonLook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLook.Location = new System.Drawing.Point(196, 119);
            this.buttonLook.Name = "buttonLook";
            this.buttonLook.Size = new System.Drawing.Size(30, 22);
            this.buttonLook.TabIndex = 19;
            this.buttonLook.TabStop = false;
            this.buttonLook.UseVisualStyleBackColor = true;
            this.buttonLook.Click += new System.EventHandler(this.buttonLook_Click);
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 298);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCapchaRefresh);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.buttonLook);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxAlert);
            this.Controls.Add(this.textBoxTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLook;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Button buttonCapchaRefresh;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.TextBox textBoxAlert;
        private System.Windows.Forms.Timer timerDeny;
    }
}