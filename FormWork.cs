using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoStore
{
    public partial class FormWork : Form
    {
        public FormWork()
        {
            InitializeComponent();
        }

        private void FormWork_Load(object sender, EventArgs e)
        {
            string text = "";
            switch (ClassTotal.idRole)
            {
                case (2):
                    labelRole.Text = "Вы директор";
                    text = "select * from [Детали]";
                    break;
                case (3):
                    labelRole.Text = "Вы менеджер";
                    text = "select * from [Заказы]";
                    break;
                case (4):
                    labelRole.Text = "Вы сисадмин";
                    text = "select * from [Сотрудники]";
                    break;
            }

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(text, ClassTotal.connection);
            da.Fill(ds, "Name");
            dataGridView.DataSource = ds.Tables["Name"];
            dataGridView.DataSource = ds.Tables[0];
        }

    }
}
