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
    public partial class thongtintaikhoan : Form
    {
        public thongtintaikhoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainnvien main = new Mainnvien();
            main.Show();
            this.Hide();
        }

        private void qLYKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap dang = new Dangnhap();
            dang.Show();
            this.Hide();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thongtintaikhoan_Load(object sender, EventArgs e)
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
