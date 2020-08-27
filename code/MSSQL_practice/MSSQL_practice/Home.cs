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

namespace MSSQL_practice
{
    public partial class Homepage : Form
    {
        public static string connsql = MSSQL_practice.Sign_in.SQL_str.ToString();
        public static SqlConnection conn = new SqlConnection();
        public static DataSet ds;
        public Homepage()
        {
            InitializeComponent();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connsql; //設定連線字串
                conn.Open(); // 開啟資料庫連線
                link_label.Text = "鏈接成功";

                ds = new DataSet();
                string sql = "select * from sys.tables";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds);
                data_comboBox.Items.Clear();
                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() != "sysdiagrams")
                            data_comboBox.Items.Add(dr[0].ToString());
                    }
                }
            }
        }

        private void data_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from " + data_comboBox.SelectedItem.ToString(); // 查詢語句
            SqlDataAdapter myda = new SqlDataAdapter(sql, connsql); // 例項化介面卡
            DataTable dt = new DataTable(); // 例項化資料表
            myda.Fill(dt); // 儲存資料
            dataGridView1.DataSource = dt; // 設定到DataGridView中
        }

        private void add_to_new(object sender, EventArgs e)
        {
            if (data_comboBox.SelectedItem == null)
            {
                link_label.Text = "表資料不可為空";
            }
            else
            {
                addpage f = new addpage(data_comboBox.SelectedItem.ToString());
                f.ShowDialog(this);
            }

        }

        private void Refresh_table(object sender, EventArgs e)
        {
            if (data_comboBox.SelectedItem == null)
            {
                link_label.Text = "表資料不可為空";
            }
            else
            {
                link_label.Text = "資料表已刷新";
                string sql = "select * from " + data_comboBox.SelectedItem.ToString(); 
                SqlDataAdapter myda = new SqlDataAdapter(sql, connsql); 
                DataTable dt = new DataTable(); 
                myda.Fill(dt); 
                dataGridView1.DataSource = dt;
            }
        }

        private void updata_page(object sender, EventArgs e)
        {
            if (data_comboBox.SelectedItem == null)
            {
                link_label.Text = "表資料不可為空";
            }
            else
            {
                updatepage f = new updatepage(data_comboBox.SelectedItem.ToString());
                f.ShowDialog(this);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
                Deletepage f = new Deletepage();
                f.ShowDialog(this);
        }

        private void select_Click(object sender, EventArgs e)
        {
                Selectpage f = new Selectpage();
                f.ShowDialog(this);
        }
    }
}
