using presentation.Bll;
using presentation.Dto;
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
        private CustomerBll _bll;
        private string _id;
        private string _msg;
        public FrmCreateUpdateCustomer(string id)
        {
            InitializeComponent();

            this._id = id;
            this._bll = new CustomerBll();


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
            Int64 id = 0;

            Int64.TryParse(this._id, out id);

            if (id > 0)
            {
                CustomerDto update = _bll.GetOneCustome(this._id);
                txtCode.Text = this._id;
                txtName.Text = update.name;
                txtRg.Text = update.rg;
                txtCpf.Text = update.cpf;

                if (update.status == true)
                {
                    cboStatus.SelectedIndex = 0;
                }
                else
                {
                    cboStatus.SelectedIndex = 1;
                }

            }
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                CustomerDto update = new CustomerDto
                {
                    name = txtName.Text,
                    rg = txtRg.Text,
                    cpf = txtCpf.Text,
                    status = cboStatus.SelectedIndex == 0 ? true : false
                };

                _bll.UpdateCustomer(txtCode.Text, update, out _msg);
                MessageBox.Show(_msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                CustomerDto create = new CustomerDto
                {
                    name = txtName.Text,
                    rg = txtRg.Text,
                    cpf = txtCpf.Text,
                    status = cboStatus.SelectedIndex == 0 ? true : false
                };

                _bll.CreateCustomer(create, out _msg);
                MessageBox.Show(_msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
