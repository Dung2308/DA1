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
    public partial class TrangchuADMIN : Form
    {
        public TrangchuADMIN()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quanlynhanvien quanlynhanvien = new Quanlynhanvien();   
            quanlynhanvien.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke thongke = new Thongke();
            thongke.Show();
            this.Hide();
        }
    }
}
