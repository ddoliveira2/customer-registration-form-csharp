using presentation.Bll;
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
    public partial class FrmListCustomer : Form
    {
        private CustomerBll _bll;
        public FrmListCustomer()
        {
            InitializeComponent();
            _bll = new CustomerBll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FrmCreateUpdateCustomer("").ShowDialog();
            CarregaGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListCustomer_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvCustomer.DataSource = _bll.GetListCustomer(txtName.Text, txtRg.Text, txtCpf.Text);
            dgvCustomer.Columns["status"].Visible = false;

            dgvCustomer.Columns["id"].Width = 150;
            dgvCustomer.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomer.Columns["id"].HeaderText = "Código";

            dgvCustomer.Columns["name"].Width = 150;
            dgvCustomer.Columns["name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvCustomer.Columns["name"].HeaderText = "Nome";
            dgvCustomer.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvCustomer.Columns["rg"].Width = 150;
            dgvCustomer.Columns["rg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomer.Columns["rg"].HeaderText = "RG";


            dgvCustomer.Columns["cpf"].Width = 150;
            dgvCustomer.Columns["cpf"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomer.Columns["cpf"].HeaderText = "CPF";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count > 0) {
                FrmCreateUpdateCustomer update = new FrmCreateUpdateCustomer(dgvCustomer.CurrentRow.Cells["id"].Value.ToString());
                update.ShowDialog();
                CarregaGrid();
            }
        }
    }
}
