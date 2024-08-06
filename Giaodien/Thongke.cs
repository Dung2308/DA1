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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainnvien mainnvien = new Mainnvien();
            mainnvien.Show();
            this.Hide();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
            this.Hide();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtintaikhoan thongtintaikhoan = new thongtintaikhoan();
            thongtintaikhoan.Show();
            this.Hide();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhanvien quanlynhanvien = new Quanlynhanvien();
            quanlynhanvien.Show();
            this.Hide();
        }
    }
}
