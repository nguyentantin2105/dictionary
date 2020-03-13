using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tudien1
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            
            InitializeComponent();
            
        }
        public static string taikhoan { get; set; }

        public Admin Admin
        {
            get => default(Admin);
            set
            {
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=PC;Initial Catalog=dictionnal;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
               
                string sql = "select *from admin where TaiKhoan='" + tk + "' and MatKhau='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader re = cmd.ExecuteReader();
                if (re.Read()==true)
                {
                    this.Hide();
                    Admin ad = new Admin();
                    taikhoan=tk;
                        ad.Show();
                }
                else
                {
                    DialogResult rt=MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (rt == DialogResult.OK)
                    {
                        this.Hide();
                        Form1 menu = new Form1();
                        menu.Show();

                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Bạn có muốn thoát không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (s==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
