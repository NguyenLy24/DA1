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
    public partial class frmQLSach : Form
    {
        BUS_QLSach bussach = new BUS_QLSach();
        public frmQLSach()
        {
            InitializeComponent();
        }

        private void QLSach_Load(object sender, EventArgs e)
        {
            dgSach.DataSource = bussach.getSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masa = txtMaSach.Text;
            string tensa = txtTenSach.Text;
            string matl = txtMaTL.Text;
            string manxb = txtMaNxb.Text;
            float dongia=float.Parse(txtDonGia.Text);
            int sl = int.Parse(txtSLuong.Text);
            string tgia = txtTG.Text;
            DTO_QLSach sa =new DTO_QLSach(masa, tensa, matl, manxb, dongia, sl, tgia);
            if (bussach.kiemtramatrung(masa) == 1)
            {
                MessageBox.Show("Mã sách đã tồn tại!");
            }
            else
            {
                if (bussach.themSach(sa) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgSach.DataSource = bussach.getSach();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ dữ liệu!");
                }
            }
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaSach.Text = dgSach[0, hang].Value.ToString();
            txtTenSach.Text = dgSach[1, hang].Value.ToString();
            txtMaTL.Text = dgSach[2, hang].Value.ToString();
            txtMaNxb.Text = dgSach[3, hang].Value.ToString();
            txtDonGia.Text = dgSach[4, hang].Value.ToString();
            txtSLuong.Text = dgSach[5, hang].Value.ToString();
            txtTG.Text = dgSach[6, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string masa = txtMaSach.Text;
            string tensa = txtTenSach.Text;
            string matl = txtMaTL.Text;
            string manxb = txtMaNxb.Text;
            float dongia = float.Parse(txtDonGia.Text);
            int sl = int.Parse(txtSLuong.Text);
            string tgia = txtTG.Text;
            DTO_QLSach sa = new DTO_QLSach(masa, tensa, matl, manxb, dongia, sl, tgia);
            if (bussach.suaSach(sa) == true)
            {
                MessageBox.Show("Sửa thành công");
                dgSach.DataSource = bussach.getSach();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaSach.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (bussach.xoaSach(ma) == true)
                {
                    MessageBox.Show("Xóa thành công");
                    dgSach.DataSource = bussach.getSach();
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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
