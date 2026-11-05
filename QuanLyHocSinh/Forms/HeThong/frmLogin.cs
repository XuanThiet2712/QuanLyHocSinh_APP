using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.Services;

namespace QuanLyHocSinh.Forms.HeThong
{
    public partial class frmLogin : Form
    {
        private readonly AuthService auth = new AuthService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            if (user == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ tên đăng nhập và mật khẩu");
                return;
            }

            if (auth.DangNhap(user, txtPass.Text))
            {
                DialogResult = DialogResult.OK;   // báo cho Program.cs biết đã thành công
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPass.Clear();
                txtPass.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
