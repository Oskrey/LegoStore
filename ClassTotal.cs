﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoStore
{
    public static class ClassTotal
    {
        public static string connectionString = @"Data Source=LapTop, 1433;Initial Catalog=LegoStore;User ID=testo;Password=testo;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";  //Строка подключения
        public static SqlConnection connection;
        public static int id;
        public static int idRole;
        public enum Mode { Просмотр, Редактирование, Добавление};
    }
}
