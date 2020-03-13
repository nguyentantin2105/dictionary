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
    public partial class Admin : Form
    {
        private string str= "Data Source=PC;Initial Catalog=dictionnal;Integrated Security=True";
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
           
            Connection();
            lblAdmin.Text = SignIn.taikhoan;
        }

        public void Connection()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter ad = new SqlDataAdapter("select * from Tudien order by Enterm", conn);
            DataTable dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            dtgList.DataSource = dt;
            dtgList.Refresh();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter ad_tem = new SqlDataAdapter("select * from Tudien order by Enterm ASC", conn);
            DataTable dt_tem = new DataTable();
            ad_tem.Fill(dt_tem);
             if (txtEng.Text == "")
                {
                    MessageBox.Show("Chưa nhập từ tiếng Anh!");
                return;
                }
             if (txtViet.Text == "")
                {
                    MessageBox.Show("Chưa nhập nghĩa!");
                return;
                }
           
            while (txtEng.Text == "" || txtViet.Text == "");
            string Voca = this.txtEng.Text;
            string Meaning = this.txtViet.Text;
            string str_2 = "insert into Tudien(Enterm,VnMean) values(N'" + Voca + "',N'" + Meaning + "')";
            SqlCommand cmd_insert = new SqlCommand();
            cmd_insert.Connection = conn;
            conn.Open();
            foreach (DataRow r in dt_tem.Rows)
            {
                if (r.ItemArray[0].ToString() == Voca)
                {
                    MessageBox.Show("Từ này đã thêm rồi!");
                    return;
                }
            }
            cmd_insert.CommandText = str_2;
            cmd_insert.ExecuteNonQuery();
            txtEng.Clear();
            txtViet.Clear();
            Connection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtEng.Text == "")
            {
                MessageBox.Show("Chưa nhập từ tiếng Anh!");
                return;
            }
            SqlConnection conn = new SqlConnection("Data Source=PC;Initial Catalog=dictionnal;Integrated Security=True");
            SqlDataAdapter ad_tem = new SqlDataAdapter("select * from Tudien order by Enterm ASC", conn);
            DataTable dt_tem = new DataTable();
            ad_tem.Fill(dt_tem);
            string Voca = txtEng.Text;
            foreach (DataRow r in dt_tem.Rows)
            {
                if (r.ItemArray[0].ToString() == Voca)
                {
                    string str_delete = "delete from Tudien where Enterm ='" + Voca + "'";
                    SqlCommand cmd_delete = new SqlCommand();
                    cmd_delete.Connection = conn;
                    conn.Open();
                    cmd_delete.CommandText = str_delete;
                    cmd_delete.ExecuteNonQuery();
                    Connection();
                    txtEng.Clear();
                    txtViet.Clear();
                    return;
                }
            }
            MessageBox.Show("Từ không tồn tại!");
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }

   
        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEng.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
            txtViet.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }

        private void dtgList_KeyDown(object sender, KeyEventArgs e)
        {
            txtEng.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
            txtViet.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
        }

        private void dtgList_KeyUp(object sender, KeyEventArgs e)
        {
            txtEng.Text = dtgList.CurrentRow.Cells[0].Value.ToString();
            txtViet.Text = dtgList.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
