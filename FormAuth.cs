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
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
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
            if(reader.HasRows)
            {
                reader.Read();
                if((bool)reader["Статус"])
                {
                    ClassTotal.id = (int)reader["ID_сотрудника"];
                    ClassTotal.idRole = (int)reader["ID_роли"];
                    switch (ClassTotal.idRole)
                    {
                        
                    }
                }
            }
        }
    }
}
