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
    public partial class frmTheLoai : Form
    {
        BUS_TheLoai bustl= new BUS_TheLoai();
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            dgTL.DataSource = bustl.getTL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string matl = txtMaTL.Text;
            string tentl = txtTenTL.Text;
            DTO_TheLoai tl = new DTO_TheLoai(matl, tentl);
            if (bustl.kiemtramatrung(matl) == 1)
            {
                MessageBox.Show("Mã thể loại đã tồn tại!");
            }
            else
            {
                if (bustl.themTL(tl) == true)
                {
                    MessageBox.Show("Thêm thành công");
                    dgTL.DataSource = bustl.getTL();
                }
                else
                {
                    MessageBox.Show("Bạn cần nhập đủ dữ liệu!");
                }
            }
        }

        private void dgTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hang = e.RowIndex;
            txtMaTL.Text = dgTL[0, hang].Value.ToString();
            txtTenTL.Text = dgTL[1, hang].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string matl = txtMaTL.Text;
            string tentl = txtTenTL.Text;
            DTO_TheLoai tl = new DTO_TheLoai(matl, tentl);
            if (bustl.suaTL(tl) == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgTL.DataSource = bustl.getTL();
            }
            else
            {
                MessageBox.Show("Sửa không thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaTL.Text;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (bustl.xoaTL(ma) == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgTL.DataSource = bustl.getTL();
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
    }
}
