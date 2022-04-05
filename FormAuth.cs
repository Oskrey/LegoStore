using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LegoStore
{
    public partial class FormAuth : Form
    {
        private string text = String.Empty;
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxCaptcha.Text == text)
            {

                string login = textBoxLogin.Text;
                string password = textBoxPasswd.Text;
                SqlCommand command = ClassTotal.connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from [Сотрудники] Where [Почта] = @login and [Пароль] = @password";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if ((bool)reader["Статус"])
                    {
                        ClassTotal.id = (int)reader["ID_сотрудника"];
                        ClassTotal.idRole = (int)reader["ID_роли"];
                        switch (ClassTotal.idRole)
                        {

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Капча введена неверно");
                pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
                textBoxCaptcha.Clear();
            }
        }

        private Bitmap CreateImage(int Width, int Height) //генерация изображения со случайным текстом
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);


            //Добавим различные цвета
            Brush[] colors = 
            { 
                 Brushes.Black,
                 Brushes.Red,
                 Brushes.RoyalBlue,
                 Brushes.Green 
            };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }
    }
}
