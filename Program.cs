﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LegoStore
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           connection =  new SqlConnection(); //Создание объекта подключения
            connection.ConnectionString = @"Data Source=DESKTOP-467M70L\SQLEXPRESS;Initial Catalog=LegoStore;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  //Строка подключения
            try
            {
                connection.Open();      //Опасная команда
                MessageBox.Show("Связь с сервером установлена");
                Application.Run(new FormMain());

            }
            catch (SqlException ex)     //Обработка сбоя при подключении
            {
                switch (ex.Number)      //Номер ошибки
                {
                    case 17: MessageBox.Show("Неверное имя сервера"); break;
                    case 4060: MessageBox.Show("Неверное имя БД"); break;
                    case 18456: MessageBox.Show("Неверное имя пользователя или пароль"); break;
                }
                MessageBox.Show(ex.Message + Environment.NewLine+ "Уровень ошибки " + ex.Class); return;
            }
            catch (Exception ex)            //Общий сбой при подключении
            {
                MessageBox.Show("Ошибка подключения " + ex.Message); return;
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }

        }
        public static SqlConnection connection;

    }
}
