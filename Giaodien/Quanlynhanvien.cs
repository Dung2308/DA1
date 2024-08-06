using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DTO.Models;

namespace Giaodien
{
    public partial class Quanlynhanvien : Form
    {
        Accountservice accountservice;
        public Quanlynhanvien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            accountservice = new Accountservice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int type = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    accountservice.Deleteacc(type);


                    LoadData(accountservice.Getallacc());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtintaikhoan thongtintaikhoan = new thongtintaikhoan();
            thongtintaikhoan.Show();
            this.Hide();
        }

        private void Quanlynhanvien_Load(object sender, EventArgs e)
        {

        }
        private void LoadData(dynamic data)
        {
            dataGridView1.Rows.Clear();
            int stt = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "STT"; dataGridView1.Columns[0].HeaderText = "Số thứ tự";
            dataGridView1.Columns[1].Name = "Ten"; dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[2].Name = "Username"; dataGridView1.Columns[2].HeaderText = "Username";
            dataGridView1.Columns[3].Name = "Password"; dataGridView1.Columns[3].HeaderText = "Password";
            dataGridView1.Columns[4].Name = "ID"; dataGridView1.Columns[4].HeaderText = "ID";

            foreach (var item in data)
            {
                dataGridView1.Rows.Add(stt++, item.Ten, item.Username, item.Password, item.Type);
            }

        }
        void loadaccountlist()
        {

        }
        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongke thongke = new Thongke();
            thongke.Show();
            this.Hide();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kho kho = new Kho();
            kho.Show();
            this.Hide();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangchuADMIN trangchuADMIN = new TrangchuADMIN();
            trangchuADMIN.Show();
            this.Hide();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            LoadData(accountservice.Getallacc());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            {
                string Ten = txtten.Text;
                string Username = txtusn.Text;
                string Password = txtpw.Text;
                int Id = Convert.ToInt32(txtid.Text);


                var confirmResult = MessageBox.Show("Bạn muốn thêm ", "Có", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    // Call the BLL method to add the new employee
                    accountservice.Addacc(Ten, Username, Password, Id);


                    // Refresh the data grid view or perform other actions as needed
                    LoadData(accountservice.Getallacc());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                string Ten = txtten.Text;
                string Username = txtusn.Text;
                string Password = txtpw.Text;
                if (string.IsNullOrWhiteSpace(Ten) || string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa thông tin nhân viên này?", "Confirm Update", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    accountservice.UpdateAcc(Ten, Username, Password,id);
                    LoadData(accountservice.Getallacc());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
            }
        }
    }
}
