using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoStore
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        int id;
        ClassTotal.Mode mode;
        byte[] imgBytes;        //Обмен между ОП и БД
        Image bit;     //Изображение в видеопамяти
        string name_file;       //Путь к файлу с изображением
        MemoryStream stream;	//Промежуточный поток в памяти

        public FormUser(int id, ClassTotal.Mode mode)
        {
            this.id = id;
            this.mode = mode;
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            if(mode == ClassTotal.Mode.Редактирование)
            {
                SqlCommand cmd = ClassTotal.connection.CreateCommand();
                cmd.CommandText = "select * from [Сотрудники] where [ID сотрудника] = "+id;
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textBoxПочта.Text = reader["Почта"].ToString();
                textBoxПароль.Text = reader["Пароль"].ToString();
                textBoxИмя.Text = reader["Имя"].ToString();
                textBoxФамилия.Text = reader["Фамилия"].ToString();
                textBoxОтчество.Text = reader["Отчество"].ToString();
                textBoxТелефон.Text = reader["Контактный телефон"].ToString() ;
                if((bool)reader["Статус"])
                    checkBox1.Checked = true;
                else checkBox1.Checked = false;
                //Почему
                if (!reader.IsDBNull(reader.GetOrdinal("Фото")))  //Пусто
                {
                    imgBytes = (byte[])reader["Фото"];   //Взять фото из БД
                    stream = new MemoryStream(imgBytes);    //Преобразования
                    pictureBoxАватар.Image = Image.FromStream(stream);
                }
                reader.Close();



            }
            bit = pictureBoxАватар.Image;
            stream = new MemoryStream();
            bit.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            imgBytes = stream.ToArray();

            
                comboBoxРоль.Items.Clear();
                SqlCommand command = ClassTotal.connection.CreateCommand();
                command.CommandText = " select [ID роли], [Название роли] from Роли";
                SqlDataReader r = command.ExecuteReader();
                if (r.HasRows)
                {
                    while (r.Read())
                    {
                        comboBoxРоль.Items.Add(r[0] + ", " + r[1]);
                    }
                }
                r.Close();
            

        }

        private void buttonФиксировать_Click(object sender, EventArgs e)
        {
            //Проверка введенных данных
            string почта = textBoxПочта.Text;
            if(String.IsNullOrEmpty(почта))
            {
                MessageBox.Show("Вы не ввели электронную почту");
                return;
            }

            string пароль = textBoxПароль.Text;
            if (String.IsNullOrEmpty(пароль))
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            string имя = textBoxИмя.Text;
            if (String.IsNullOrEmpty(имя))
            {
                MessageBox.Show("Вы не ввели имя");
                return;
            }

            string фамилия = textBoxФамилия.Text;
            if (String.IsNullOrEmpty(фамилия))
            {
                MessageBox.Show("Вы не ввели фамилию");
                return;
            }

            string телефон;
            if (textBoxТелефон.MaskCompleted)
            {
                телефон = textBoxТелефон.Text;
            }
            else
            {
                MessageBox.Show("Вы не ввели телефон");
                return;
            }

            // В режиме добавления проверить отстутствие повторения логина
            if (mode == ClassTotal.Mode.Добавление)
            {
                SqlCommand commandSearch = ClassTotal.connection.CreateCommand();
                commandSearch.CommandText = " SELECT * FROM [Сотрудники] WHERE [Почта] = '" + почта+ "'";
                SqlDataReader r = commandSearch.ExecuteReader();
                if (r.HasRows)
                {
                    r.Close();
                    MessageBox.Show("Пользователь с таким аккаунтом зарегистрирован в системе");
                    return;
                }
                else
                {
                    r.Close();
                }
            }

            // Выполнить запрос на обновление БД
            SqlCommand command = ClassTotal.connection.CreateCommand();
            // Из битового образа перенсти с массив бит
            int temp;
            if (checkBox1.Checked)
                temp = 1;
            else temp = 0;
            switch (mode)
            {
                case ClassTotal.Mode.Добавление:
                    
                    command.CommandText = "INSERT INTO [Сотрудники] VALUES (" + comboBoxРоль.Text.Split(',')[0]+ ",'" + фамилия + "', '" + имя+ "', '" + textBoxОтчество.Text+ "', '" + почта+ "', '"+пароль+"', '" + телефон + "', " + temp + ", '"+dateTimePickerДатаУстройства.Value.Date+"', '"+ imgBytes+"')" ;
                    
                    break;


                case ClassTotal.Mode.Редактирование:
                    SqlCommand sqlCommand = ClassTotal.connection.CreateCommand();
                    sqlCommand.CommandText = " select * from Сотрудники where Почта = '"+почта+"' and  not[ID сотрудника] = "+id;
                    SqlDataReader r = sqlCommand.ExecuteReader();
                    if (r.IsDBNull(r.GetOrdinal("Почта")))  //Пусто
                    {
                        r.Close();
                        MessageBox.Show("Эта почта уже занята");
                    }
                    else
                    {
                        r.Close();

                        command.CommandText = "Update[Сотрудники] set [ID роли] = " + comboBoxРоль.Text.Split(',')[0] + ",[Фамилия] = '" + фамилия + "', [Имя] = '" + имя + "', [Отчество] ='" + textBoxОтчество.Text + "', [Почта] = '" + почта + "', [Пароль] = '" + пароль + "', [Контактный телефон] = '" + телефон + "', [Статус] = " + temp + ",[Дата устройства] '" + dateTimePickerДатаУстройства.Value.Date + "',[Фото] = '" + imgBytes + "')" +
                        "where ID сотрудника = " + id;
                    }
                    break;
            }

            int countResult = (int)command.ExecuteNonQuery();
            if(countResult != 0)
            {
                MessageBox.Show("Информация в БД обновлена успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonНазад_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void buttonВыбратьФото_Click(object sender, EventArgs e)
        {
            if (openFileDialogФото.ShowDialog() == DialogResult.OK)
            {
                //1. Поместить фото в битовый образ и на компонент
                name_file = openFileDialogФото.FileName;
                bit = Image.FromFile(openFileDialogФото.FileName);
                pictureBoxАватар.Image = bit;
                //2. Из битового образа перенести с массив бит
                stream = new MemoryStream();
                bit.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                imgBytes = stream.ToArray();
            }


        }

        private void buttonУдалитьФото_Click(object sender, EventArgs e)
        {
            pictureBoxАватар.Image = Properties.Resources.LEGO_logo_700x700;
        }
    }
}
