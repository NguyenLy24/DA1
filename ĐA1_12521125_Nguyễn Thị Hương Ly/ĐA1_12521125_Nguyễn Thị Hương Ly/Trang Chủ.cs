using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ĐA1_12521125_Nguyễn_Thị_Hương_Ly
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSach frm = new frmQLSach();
            frm.TopLevel = false;
            frm.Parent = this; 
            panel1.Visible = false; // ẩn panel1
            frm.Show();
            int x = menuStrip1.Width; // x là vị trí bên trái của form quản lý, bằng với chiều rộng của menu
            int y = 0; // y là vị trí phía trên của form quản lý, bằng 0
            int width = this.Width - menuStrip1.Width; // width là chiều rộng của form quản lý, bằng chiều rộng của form cha trừ đi chiều rộng của menu
            int height = this.Height; // height là chiều cao của form quản lý, bằng chiều cao của form cha
            frm.SetBounds(x, y, width, height);
            frm.BringToFront(); // đưa form quản lý sách lên trên cùng
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frm = new frmQLKhachHang();
            frm.TopLevel = false;
            frm.Parent = this; 
            panel1.Visible = false; 
            frm.Show();
            int x = menuStrip1.Width; 
            int y = 0; 
            int width = this.Width - menuStrip1.Width; 
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void quảnLýNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB frm = new frmNXB();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTheLoai frm = new frmTheLoai();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frm = new frmPhieuNhap();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKiemSach frm = new frmTKiemSach();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void thongKePhieuNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKePhieuNhap frm = new frmTKePhieuNhap();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêSáchBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKeHoaDonBan frm = new frmTKeHoaDonBan();
            frm.TopLevel = false;
            frm.Parent = this;
            panel1.Visible = false;
            frm.Show();
            int x = menuStrip1.Width;
            int y = 0;
            int width = this.Width - menuStrip1.Width;
            int height = this.Height;
            frm.SetBounds(x, y, width, height);
            frm.BringToFront();
        }
    }
}
