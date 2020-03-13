using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SpeechLib;


namespace Tudien1
{
    public partial class Tudaluucs : Form
    {
        private DataSet rs = null;
        private SqlConnection conn;
        private SqlDataAdapter ad;
        private DataTable dt = null;
        private string str= "Data Source=PC;Initial Catalog=dictionnal;Integrated Security=True";
        public Tudaluucs()
        {
            InitializeComponent();
        }
        public void Connection()
        {
            conn = new SqlConnection(str);
            ad = new SqlDataAdapter("select * from Table_Save order by Enterm", conn);
            dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            this.lstList.DataSource = dt;
            this.lstList.DisplayMember = "Enterm";
            
        }
        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            ad = new SqlDataAdapter("select * from Table_Save where Enterm ='" + this.lstList.Text + "'", conn);
            dt = new DataTable();
            dt.Clear();
            ad.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0) { setRichTexBox(dt); }
            }
            conn.Close();
        }
        public void setRichTexBox(DataTable dtTuDien)
        {
            string st1 = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033\\deflangfe1041{\\fonttbl{\\f0\\fswiss\\fprq2\\fcharset0 Arial;}}"
                       + "{\\colortbl ;\\red255\\green0\\blue0;\\red255\\green0\\blue255;\\red0\\green176\\blue80;}"
                       + "{\\*\\generator Msftedit 5.41.21.2508;}\\viewkind4\\uc1\\pard\\nowidctlpar\\cf1\\b\\f0\\fs20 ";


            string st2 = "\\cf2\\b Lo\\u7841?i t\\u7915?     :\\cf0   [Tuvung]\\par"
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
                else if (code == 10) 
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

        private void Tudaluucs_Load(object sender, EventArgs e)
        {
            Connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            SqlCommand cmd_delete = new SqlCommand();
            string temp = dt.Rows[0].ItemArray[0].ToString();
            string str_delete= "delete from Table_Save where Enterm ='"+temp+"'";
            cmd_delete.Connection = conn;
            conn.Open();
            cmd_delete.CommandText = str_delete;
            cmd_delete.ExecuteNonQuery();
            MessageBox.Show("Đã xoá!");
           
            conn.Close();
            Connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string speedtext = dt.Rows[0].ItemArray[0].ToString();
            SpVoice voice = new SpVoice();
            voice.Speak(speedtext, SpeechVoiceSpeakFlags.SVSFDefault);
        }
    }
}
