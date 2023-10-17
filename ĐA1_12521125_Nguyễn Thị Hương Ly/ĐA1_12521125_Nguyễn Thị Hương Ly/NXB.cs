using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace ĐA1_12521125_Nguyễn_Thị_Hương_Ly
{
    public partial class frmNXB : Form
    {
        BUS_NXB busnxb = new BUS_NXB();
        public frmNXB()
        {
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            dgNXB.DataSource = busnxb.getNXB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.Text;
            string tennxb = txtTenNXB.Text;
            string dchi = txtDchiNXB.Text;
            string sdt = txtSDTnxb.Text;
            string email=txtEmailNXB.Text;
            DTO_NXB nxb =new DTO_NXB(manxb, tennxb, dchi, sdt, email);
            if (busnxb.kiemtramatrung(manxb) == 1)
            {
                MessageBox.Show("Mã sách đã tồn tại!");
            }
            else
            {
                if (busnxb.themNXB(nxb) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgNXB.DataSource = busnxb.getNXB();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ dữ liệu!");
                }
            }
        }

        private void dgNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaNXB.Text = dgNXB[0, hang].Value.ToString();
            txtTenNXB.Text = dgNXB[1, hang].Value.ToString();
            txtDchiNXB.Text = dgNXB[2, hang].Value.ToString();
            txtSDTnxb.Text = dgNXB[3, hang].Value.ToString();
            txtEmailNXB.Text = dgNXB[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manxb = txtMaNXB.Text;
            string tennxb = txtTenNXB.Text;
            string dchi = txtDchiNXB.Text;
            string sdt = txtSDTnxb.Text;
            string email = txtEmailNXB.Text;
            DTO_NXB nxb = new DTO_NXB(manxb, tennxb, dchi, sdt, email);
            if (busnxb.suaNXB(nxb) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgNXB.DataSource = busnxb.getNXB();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNXB.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (busnxb.xoaNXB(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgNXB.DataSource = busnxb.getNXB();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                frmTrangChu frm = new frmTrangChu();
                frm.ShowDialog();
                this.Hide();
            }
        }

        private void txtSDTnxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
