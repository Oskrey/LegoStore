using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public FormUser(int id, ClassTotal.Mode mode)
        {
            this.id = id;
            this.mode = mode;
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {

        }
    }
}
