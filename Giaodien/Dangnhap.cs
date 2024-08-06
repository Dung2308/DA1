using BLL;
using DTO.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace Giaodien
{
    public partial class Dangnhap : Form
    {
        private readonly Accountservice accountservice;
        public Dangnhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            accountservice = new Accountservice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = txtusn.Text;
            string password = txtpw.Text;


            Account account = accountservice.Authenticate(username, password);

            if (account != null)
            {
                MessageBox.Show("??ng nh?p thành công");
                if (account.Type == 1)
                {
                    TrangchuADMIN trangchuADMIN = new TrangchuADMIN();
                    trangchuADMIN.Show();
                }
                else if (account.Type == 0)
                {
                    Mainnvien mainnvien = new Mainnvien();
                    mainnvien.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai tên ??ng nh?p ho?c m?t kh?u");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Password password = new Password();
            password.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIgnup sIgnup = new SIgnup();
            sIgnup.Show();
            this.Hide();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
           
        }
        }
    }
