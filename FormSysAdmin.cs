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
    public partial class FormSysAdmin : Form
    {
        public FormSysAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonРедактировать_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index >= 0)
            {
                int id = Int32.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                FormUser formUser = new FormUser(id, ClassTotal.Mode.Редактирование);
                Hide();
                formUser.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Выбереите сотрудника");
            }
        }

        private void buttonСтатус_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonСменаДоступа_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (index >= 0)
            {
                int id = (int)dataGridView1.Rows[index].Cells[0].Value;
                bool active = (bool)dataGridView1.Rows[index].Cells[8].Value;
                int костыль;
                if (active)
                    костыль = 0;
                else костыль = 1;
                SqlCommand com = new SqlCommand();
                com.Connection = ClassTotal.connection;
                com.CommandText = ("update [Сотрудники] set [Статус]= " + костыль + " where [ID сотрудника]= " + id);
                com.ExecuteNonQuery();
                refresh();
            }
        }
        private void refresh()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select [ID сотрудника], [Название роли], Фамилия, Имя, Отчество, Почта, Статус " +
                "from Сотрудники join Роли on Сотрудники.[ID роли] = Роли.[ID роли]", ClassTotal.connection);
            da.Fill(ds, "Name");
            dataGridView1.DataSource = ds.Tables["Name"];
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void FormSysAdmin_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void buttonПоиск_Click(object sender, EventArgs e)
        {

        }

        private void buttonРегистрация_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser(-1,ClassTotal.Mode.Добавление);
            formUser.ShowDialog();
            refresh();

        }

        private void buttonНазад_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
