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
using SpeechLib;
namespace Tudien1
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter ad;
        private DataTable dt = null;
        private string str="Data Source=PC;Initial Catalog=dictionnal;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        public Tudaluucs Tudaluucs
        {
            get => default(Tudaluucs);
            set
            {
            }
        }

        public SignIn SignIn
        {
            get => default(SignIn);
            set
            {
            }
        }

        public SearchOnline SearchOnline
        {
            get => default(SearchOnline);
            set
            {
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {//Data Source=PC;Initial Catalog=dictionnal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            conn = new SqlConnection(str);
            Connection();
            this.Resize += new EventHandler(Form1_Resize);
        }
        public void Connection()
        {
            conn = new SqlConnection(str);
            ad = new SqlDataAdapter("select * from Tudien order by Enterm", conn);
            dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            this.lstList.DataSource = dt;
            this.lstList.DisplayMember = "Enterm";
            conn.Close();
            txtNhap.Focus();
        }

        public void txtNhap_TextChanged(object sender, EventArgs e)
        {

           
            conn = new SqlConnection(str);
            ad = new SqlDataAdapter("select * from Tudien where Enterm like '" + this.txtNhap.Text + "%' order by Enterm ASC ", conn);
            dt = new DataTable();
            try
            {
                
                dt.Clear();
                ad.Fill(dt);
                lstList.DataSource = dt;
                this.lstList.DisplayMember = "Enterm";
                if (lstList.Items.Count > 0)
                {
                    lstList.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { }
        }
     
        public void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn st = new SignIn();
            st.Show();
        }

        public void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(str);
            ad = new SqlDataAdapter("select * from Tudien where Enterm ='" + this.lstList.Text + "'", conn);
            dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0) { setRichTexBox(dt); }
            }
            
        }

        public void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                lstList.Height = this.Height;
                txtNhap.Height = this.Height;
                rtbResult.Width = this.Width;
            }
        }
        public void setRichTexBox(DataTable dtTuDien)
        {
            string st1 = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033\\deflangfe1041{\\fonttbl{\\f0\\fswiss\\fprq2\\fcharset0 Arial;}}"
                       + "{\\colortbl ;\\red255\\green0\\blue0;\\red255\\green0\\blue255;\\red0\\green176\\blue80;}"
                       + "{\\*\\generator Msftedit 5.41.21.2508;}\\viewkind4\\uc1\\pard\\nowidctlpar\\cf1\\b\\f0\\fs20 ";


            string st2 = "\\cf2\\b T\\u7915?     :\\cf0   [Tuvung]\\par"
                        + "\\cf3 Gi\\u7843?i th\\'edch :\\par"
                        + "\\cf0\\b0      [giaithich]\\par"
                        + "\\par";


            string st3 = "}";
            string tt = "";
            string str = "";
            foreach (DataRow r in dtTuDien.Rows)
            {
                tt = st2;
                tt = tt.Replace("[Tuvung]", DecodeString(r["Enterm"].ToString()));
                tt = tt.Replace("[giaithich]", DecodeString(r["VnMean"].ToString()));
                str += tt;
            }
            str = st1 + str + st3;
            rtbResult.Rtf = str;
        }
        public string DecodeString(string unicodeString)
        {
            Encoding uni = Encoding.Unicode;
            Byte[] encodedBytes = uni.GetBytes(unicodeString);
            int i = 0;
            int code = 0;
            string ret = "";
            for (i = 0; i < encodedBytes.Length - 1;)
            {
                code = BitConverter.ToUInt16(encodedBytes, i);
                if (code > 254)
                {
                    ret += "\\u" + code.ToString() + "?";
                }
                else if (code == 10) //Ma cua ky tu enter
                {
                    ret += "\\par      ";
                }
                else
                {
                    ret += BitConverter.ToChar(encodedBytes, i);
                }

                i += 2;
            }
            return ret;
        }
        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        public void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (s == DialogResult.Yes)
            {
                conn.Close();
                conn = null;             
                ad = null;
                this.Close();
            }
        }

        public void btnRead_Click(object sender, EventArgs e)
        {
            string speedtext=dt.Rows[0].ItemArray[0].ToString();
            SpVoice voice = new SpVoice();
            voice.Speak(speedtext, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstList.SelectedItem = txtNhap.Text;
            }
            if (e.KeyCode == Keys.Up)
            {
                lstList.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                lstList.Focus();
            }
        }

        private void txtNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstList.SelectedItem = txtNhap.Text;
            }
            if (e.KeyCode == Keys.Up)
            {
                lstList.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                lstList.Focus();
            }
        }
        private void Save(DataTable dataTudien)
        {
            conn = new SqlConnection(str);

            SqlDataAdapter ad_tem = new SqlDataAdapter("select * from Table_Save order by Enterm ASC", conn);
            DataTable dt_tem = new DataTable();
            ad_tem.Fill(dt_tem);

            string Voca = this.lstList.Text;
            //string Typ = dataTudien.Rows[0].ItemArray[1].ToString();
            string Meaning = dataTudien.Rows[0].ItemArray[1].ToString();
            SqlCommand cmd_insert = new SqlCommand();
            cmd_insert.Connection = conn;
            conn.Open();

            string str_2 = "insert into Table_Save(Enterm,VnMean) values(N'" + Voca + "',N'" + Meaning + "')";

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
            //Xoá các dòng có trường Meaning=NULL
            SqlCommand cmd_delete = new SqlCommand();
            string str_3 = "delete from Table_Save where Enterm is NULL";
            //string str_3 = "delete from Table_Saved where Vocabulary like'Compatible";
            cmd_delete.Connection = conn;
            cmd_delete.CommandText = str_3;
            cmd_delete.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Đã thêm vào ưa thích!");

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save(dt);
        }

        private void từĐãLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tudaluucs tdl = new Tudaluucs();
            tdl.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchOnline search = new SearchOnline();
            search.Show();
        }
    }
}

