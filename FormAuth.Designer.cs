
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
            this.buttonLook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLook
            // 
            this.buttonLook.BackgroundImage = global::LegoStore.Properties.Resources.Glaz;
            this.buttonLook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLook.Location = new System.Drawing.Point(239, 145);
            this.buttonLook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLook.Name = "buttonLook";
            this.buttonLook.Size = new System.Drawing.Size(57, 28);
            this.buttonLook.TabIndex = 19;
            this.buttonLook.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Д О Б Р О   П О Ж А Л О В А Т Ь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Логин";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(52, 324);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(215, 28);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "ВОЙТИ";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Location = new System.Drawing.Point(52, 147);
            this.textBoxPasswd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPasswd.MaxLength = 20;
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(179, 22);
            this.textBoxPasswd.TabIndex = 12;
            this.textBoxPasswd.UseSystemPasswordChar = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(52, 89);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(244, 22);
            this.textBoxLogin.TabIndex = 11;
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(52, 180);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(244, 108);
            this.pictureBoxCaptcha.TabIndex = 20;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(51, 294);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(100, 22);
            this.textBoxCaptcha.TabIndex = 21;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(203, 294);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(93, 23);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(121, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "LegoStore";
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Controls.Add(this.buttonLook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPasswd);
            this.Controls.Add(this.textBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAuth";
            this.Text = "FormAuth";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxPasswd;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label3;
    }
}