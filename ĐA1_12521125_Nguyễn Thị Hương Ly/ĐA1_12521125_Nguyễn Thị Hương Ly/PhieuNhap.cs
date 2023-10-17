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
    public partial class frmPhieuNhap : Form
    {
        BUS_PhieuNhap buspnhap = new BUS_PhieuNhap();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dgPhieuNhap.DataSource = buspnhap.getPhieuNhap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maph = txtMaPhieu.Text;
            DateTime ngaynhap = DateTime.Parse(dateNgayNhap.Value.ToShortDateString());
            string manv = txtNVtaoph.Text;
            string masa = txtMaSach.Text;
            float tongtien = float.Parse(txtTTienNhap.Text);
            DTO_PhieuNhap pn = new DTO_PhieuNhap(maph, ngaynhap, manv, masa, tongtien);
            if (buspnhap.kiemtramatrung(maph) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
            else
            {
                if (buspnhap.themPhieu(pn) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgPhieuNhap.DataSource = buspnhap.getPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ dữ liệu!");
                }
            }
        }

        private void dgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaPhieu.Text = dgPhieuNhap[0, hang].Value.ToString();
            dateNgayNhap.Text = dgPhieuNhap[1, hang].Value.ToString();
            txtNVtaoph.Text = dgPhieuNhap[2, hang].Value.ToString();
            txtMaSach.Text = dgPhieuNhap[3, hang].Value.ToString();
            txtTTienNhap.Text = dgPhieuNhap[4, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maph = txtMaPhieu.Text;
            DateTime ngaynhap = DateTime.Parse(dateNgayNhap.Value.ToShortDateString());
            string manv = txtNVtaoph.Text;
            string masa = txtMaSach.Text;
            float tongtien = float.Parse(txtTTienNhap.Text);
            DTO_PhieuNhap pn = new DTO_PhieuNhap(maph, ngaynhap, manv, masa, tongtien);
            if (buspnhap.suaPhieu(pn) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgPhieuNhap.DataSource = buspnhap.getPhieuNhap();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaPhieu.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (buspnhap.xoaPhieu(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgPhieuNhap.DataSource = buspnhap.getPhieuNhap();
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

        private void txtTTienNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
