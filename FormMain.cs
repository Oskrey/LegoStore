using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegoStore
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            FormAuth form_auth = new FormAuth();
            this.Hide();
            form_auth.ShowDialog();
        }
    }
}
