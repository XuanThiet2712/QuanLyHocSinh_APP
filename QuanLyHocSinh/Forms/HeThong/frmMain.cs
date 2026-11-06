using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Helpers;


namespace QuanLyHocSinh.Forms.HeThong
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            PhanQuyenMenu(menuStrip1.Items);
            lblUser.Text = "Xin chào: " + Session.TenDangNhap + "  |  Nhóm: " + Session.MaNhom;
        }

        private void PhanQuyenMenu(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item.Tag != null && item.Tag.ToString() != "")
                    item.Visible = Session.CoQuyen(item.Tag.ToString());

                var menu = item as ToolStripMenuItem;
                if (menu != null && menu.HasDropDownItems)
                    PhanQuyenMenu(menu.DropDownItems);
            }
        }
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Session.Xoa();
            Application.Restart();   // khởi động lại, quay về form đăng nhập
        }



        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Mở form con trong vùng MDI; nếu đang mở rồi thì chỉ đưa lên phía trước
        private void MoForm<T>() where T : Form, new()
        {
            foreach (Form f in MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    return;
                }
            }
            T frm = new T();
            frm.MdiParent = this;
            this.Height = frm.Height + 100;
            this.Width = frm.Width + 100;
            frm.Show();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            MoForm<QLSV.Forms.Catalog.frmSinhVien>();
        }

        private void mnuDangKy_Click(object sender, EventArgs e)
        {
            MoForm<QuanLyHocSinh.Forms.Enroll.frmDangKyHocPhan>();
        }
    }
}
