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
using DataTable = System.Data.DataTable;
using app = Microsoft.Office.Interop.Excel.Application;

namespace ĐA1_12521125_Nguyễn_Thị_Hương_Ly
{
    public partial class frmTKePhieuNhap : Form
    {
        BUS_TKePhieuNhap bustkepn = new BUS_TKePhieuNhap();
        public frmTKePhieuNhap()
        {
            InitializeComponent();
        }

        private void frmTKPhieuNhap_Load(object sender, EventArgs e)
        {
            dgTKePhieuNhap.DataSource = bustkepn.getTKnhap();
        }

        private void dgTKePhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgTKePhieuNhap.Rows[e.RowIndex];
            }
            catch { }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            (dgTKePhieuNhap.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("MaPhieu like '%" + txtTimKiem.Text + "%'");
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
        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;//Thiết lập độ rộng của các cột trong Workbook
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnXuatPN_Click(object sender, EventArgs e)
        {
            export2Excel(dgTKePhieuNhap, @"D:\ĐỒ ÁN\", "xuatfileExcelThongKeNhap");
            DialogResult dg = MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK) { }
        }
    }
}
