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
    public partial class frmHoaDonBan : Form
    {
        BUS_HoaDonBan bushdb = new BUS_HoaDonBan();
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            dgHDB.DataSource = bushdb.getHDB();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahdb = txtMaHDB.Text;
            DateTime ngayban = DateTime.Parse(dateNgayBan.Value.ToShortDateString());
            string manv = txtNVtaohd.Text;
            string makh = txtMaKH.Text;
            string masa = txtMaSach.Text;
            float tongtien = float.Parse(txtTTienBan.Text);
            DTO_HoaDonBan pn = new DTO_HoaDonBan(mahdb, ngayban, manv, makh, masa, tongtien);
            if (bushdb.kiemtramatrung(mahdb) == 1)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
            else
            {
                if (bushdb.themHDB(pn) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgHDB.DataSource = bushdb.getHDB();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ dữ liệu!");
                }
            }
        }

        private void dgHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaHDB.Text = dgHDB[0, hang].Value.ToString();
            dateNgayBan.Text = dgHDB[1, hang].Value.ToString();
            txtNVtaohd.Text = dgHDB[2, hang].Value.ToString();
            txtMaKH.Text = dgHDB[3, hang].Value.ToString();
            txtMaSach.Text = dgHDB[4, hang].Value.ToString();
            txtTTienBan.Text = dgHDB[5, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahdb = txtMaHDB.Text;
            DateTime ngayban = DateTime.Parse(dateNgayBan.Value.ToShortDateString());
            string manv = txtNVtaohd.Text;
            string makh = txtMaKH.Text;
            string masa = txtMaSach.Text;
            float tongtien = float.Parse(txtTTienBan.Text);
            DTO_HoaDonBan pn = new DTO_HoaDonBan(mahdb, ngayban, manv, makh, masa, tongtien);
            if (bushdb.suaHDB(pn) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgHDB.DataSource = bushdb.getHDB();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaHDB.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (bushdb.xoaHDB(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgHDB.DataSource = bushdb.getHDB();
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

        private void txtTTienBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
