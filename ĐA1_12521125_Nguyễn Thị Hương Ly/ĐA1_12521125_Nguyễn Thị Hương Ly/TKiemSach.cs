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
    public partial class frmTKiemSach : Form
    {
        BUS_TKiemSach  bustkiemsa = new BUS_TKiemSach();
        public frmTKiemSach()
        {
            InitializeComponent();
        }

        private void frmTKiemSach_Load(object sender, EventArgs e)
        {
            dgSach.DataSource = bustkiemsa.getTKiemSach();
        }

        private void btnTKiem_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();
            string tenSach = txtTenSach.Text.Trim();
            string maTheLoai = txtMaTL.Text.Trim();
            string tacGia = txtTacGia.Text.Trim();

            // Tạo một biến lưu trữ điều kiện lọc
            string filter = "";
            // Kiểm tra nếu các TextBox không rỗng thì thêm vào điều kiện lọc với toán tử AND
            if (!string.IsNullOrEmpty(maSach))
            {
                filter += "MaSach like '%" + maSach + "%' AND ";
            }
            if (!string.IsNullOrEmpty(tenSach))
            {
                filter += "TenSach like '%" + tenSach + "%' AND ";
            }
            if (!string.IsNullOrEmpty(maTheLoai))
            {
                filter += "MaTL like '%" + maTheLoai + "%' AND ";
            }
            if (!string.IsNullOrEmpty(tacGia))
            {
                filter += "TacGia like '%" + tacGia + "%' AND ";
            }
            // Loại bỏ toán tử AND cuối cùng nếu có
            if (filter.EndsWith(" AND "))
            {
                filter = filter.Remove(filter.Length - 5);
            }

            // Áp dụng điều kiện lọc cho DataGridView
            (dgSach.DataSource as DataTable).DefaultView.RowFilter = filter;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                this.Close();
                frmTrangChu f = new frmTrangChu();
                f.Show();
            }
        }
    }
}
