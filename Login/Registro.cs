using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class txtName : Form
    {
        public txtName()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login objVentanaLogin = new Login();
            objVentanaLogin.Show();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {

        }

        private void txtNickname_Leave(object sender, EventArgs e)
        {

        }

        private void txtPass2_Enter(object sender, EventArgs e)
        {
            txtPass2.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}
