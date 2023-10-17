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
    public partial class frmQLKhachHang : Form
    {
        BUS_QLKhachHang buskh = new BUS_QLKhachHang();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            dgKH.DataSource = buskh.getKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string makh=txtMaKH.Text;
            string tenkh=txtTenKH.Text;
            string diachiKH=txtDcKH.Text;
            string sdtkh=txtSDTkh.Text;
            string email=txtEmailKH.Text;
            DateTime ngaydat = DateTime.Parse(dateNDatDon.Value.ToShortDateString());
            DTO_QLKhachHang kh=new DTO_QLKhachHang(makh, tenkh, diachiKH, sdtkh, email, ngaydat);
            if (buskh.kiemtramatrung(makh) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
            else
            {
                if (buskh.themKH(kh) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgKH.DataSource = buskh.getKhachHang();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ dữ liệu!");
                }
            }

        }

        private void dgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaKH.Text = dgKH[0, hang].Value.ToString();
            txtTenKH.Text = dgKH[1, hang].Value.ToString();
            txtDcKH.Text = dgKH[2, hang].Value.ToString();
            txtSDTkh.Text = dgKH[3, hang].Value.ToString();
            txtEmailKH.Text = dgKH[4, hang].Value.ToString();
            dateNDatDon.Text = dgKH[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string diachiKH = txtDcKH.Text;
            string sdtkh = txtSDTkh.Text;
            string email = txtEmailKH.Text;
            DateTime ngaydat = DateTime.Parse(dateNDatDon.Value.ToShortDateString());
            DTO_QLKhachHang kh = new DTO_QLKhachHang(makh, tenkh, diachiKH, sdtkh, email, ngaydat);
            if (buskh.suaKH(kh) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgKH.DataSource = buskh.getKhachHang();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKH.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (buskh.xoaKH(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgKH.DataSource = buskh.getKhachHang();
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

        private void txtSDTkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
