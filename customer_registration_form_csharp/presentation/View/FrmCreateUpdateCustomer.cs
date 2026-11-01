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
    public partial class FrmCreateUpdateCustomer : Form
    {
        public FrmCreateUpdateCustomer(string id)
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtName.Focus();
        }

        private void FrmCreateUpdateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
