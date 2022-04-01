using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;

namespace Новости
{
    public partial class FormAutorization : Form
    {

        bool vis = true;  //видимость пароля

        public FormAutorization()
        {
            InitializeComponent();
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {
            LegoStore.Program.connection
            if (sqlConnection.State == ConnectionState.Closed)
            {
                // MessageBox.Show("Подключение установлено");
                MessageBox.Show("Отсутствует соединение с сервером");
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sqlConnection.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@login", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("@pass", textBoxPasswd.Text);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM Userss WHERE Login LIKE @login AND Passwd LIKE @pass";
            object result = cmd.ExecuteScalar();
            int a = Convert.ToInt32(result);
            conn.Close();
            
            if(a == 1)
            {
                FormCatalog form4 = new FormCatalog();
                form4.Show();
                this.Hide();
                if (textBoxLogin.Text == "admin")
                {
                    form4.buttonAdd.Visible = true;
                    form4.buttonAdd2.Visible = true;
                    form4.buttonAdd3.Visible = true;
                    form4.buttonAdd4.Visible = true;
                    form4.buttonDel.Visible = true;
                    form4.buttonDel2.Visible = true;
                    form4.buttonDel3.Visible = true;
                    form4.buttonDel4.Visible = true;
                }
                else
                {
                    form4.buttonAdd.Visible = false;
                    form4.buttonAdd2.Visible = false;
                    form4.buttonAdd3.Visible = false;
                    form4.buttonAdd4.Visible = false;
                    form4.buttonDel.Visible = false;
                    form4.buttonDel2.Visible = false;
                    form4.buttonDel3.Visible = false;
                    form4.buttonDel4.Visible = false;
                }
            }
            
            else
            {
                MessageBox.Show("Пожалуйста, проверьте правильность введенных данных", "Ошибка авторизации");
                textBoxLogin.Clear();
                textBoxPasswd.Clear();
            }
            
            conn.Close();

            if (textBoxLogin.TextLength < 4 || textBoxPasswd.TextLength < 4)
            {
                //MessageBox.Show("Длина логина или пароля меньше допустимой. Минимальная длина - 4 символа.", "Ошибка авторизации");
            }
            else
            {
                if (textBoxLogin.TextLength > 20 || textBoxPasswd.TextLength < 20)
                {
                    //MessageBox.Show("Длина логина или пароля больше допустимой. Максимальная длина - 20 символа.", "Ошибка авторизации");
                }
            }
        }

        private void buttonLook_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                textBoxPasswd.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBoxPasswd.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void textBoxPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;        //Рзрешить ввод цифр
            if (e.KeyChar == 8) return;                 //Разрешить <-
            if (e.KeyChar == 35) return;              //#
            if (e.KeyChar == 36) return;              //$
            if (e.KeyChar == 38) return;              //&
            if (e.KeyChar == 40) return;              //(
            if (e.KeyChar == 41) return;              //)
            if (e.KeyChar == 42) return;              //*
            if (e.KeyChar == 95) return;              //_
            if (e.KeyChar == 64) return;              //@
            if (e.KeyChar == 27)                        //Разрешить esc
            {
                (sender as TextBox).Text = "";
                return;
            }
            if (Char.IsLetter(e.KeyChar)) return;
            e.Handled = true;    //Все остальное - запрет
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormRegistration form3 = new FormRegistration();
            form3.Show();
            this.Hide();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(textBoxLogin.TextLength < 4 || textBoxPasswd.TextLength < 4)
            //{
            //    MessageBox.Show("Длина логина или пароля меньше допустимой. Минимальная длина - 4 символа.", "Ошибка авторизации");
            //}
            //if (textBoxLogin.TextLength > 20 || textBoxPasswd.TextLength < 20)
            //{
            //    MessageBox.Show("Длина логина или пароля больше допустимой. Максимальная длина - 20 символа.", "Ошибка авторизации");
            //}
        }
    }
}
