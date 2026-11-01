using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentation.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "ADMIN" && txtPassword.Text == "123456")
            {
                this.Hide();
                new FrmMain().ShowDialog();
                this.Show();
            }
            else { 
            MessageBox.Show("Usuário não encontrado","Usuário",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
