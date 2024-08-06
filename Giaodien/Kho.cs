using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaodien
{
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainnvien mainnvien = new Mainnvien();
            mainnvien.Show();
            this.Hide();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtintaikhoan thongtintaikhoan = new thongtintaikhoan();
            thongtintaikhoan.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dangnhap = new Dangnhap();
            dangnhap.Show();
            this.Hide();
        }

        private void Kho_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke thongke = new Thongke();
            thongke.Show();
            this.Hide();
        }
    }
}
