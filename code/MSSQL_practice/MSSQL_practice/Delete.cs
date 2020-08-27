using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSSQL_practice
{
    public partial class Deletepage : Form
    {
        public Deletepage()
        {
            InitializeComponent();
            back.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            table_comboBox.Items.Clear();
            foreach (DataTable dt in MSSQL_practice.Homepage.ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr[0].ToString() != "sysdiagrams")
                        table_comboBox.Items.Add(dr[0].ToString());
                }
            }
            MSSQL_practice.Homepage.conn.Close();
        }

        private void table_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MSSQL_practice.Homepage.conn.ConnectionString = MSSQL_practice.Homepage.connsql;
            MSSQL_practice.Homepage.conn.Open();

            string sql = "SELECT * FROM " + table_comboBox.SelectedItem.ToString(); 
            SqlCommand cmd = new SqlCommand(sql, MSSQL_practice.Homepage.conn);
            SqlDataAdapter myda = new SqlDataAdapter(sql, MSSQL_practice.Homepage.conn); 
            DataTable dt_table = new DataTable();
            myda.Fill(dt_table); 
            dataGridView1.DataSource = dt_table;

            id_comboBox.Items.Clear();
                foreach (DataRow dr in dt_table.Rows)
                {
                        id_comboBox.Items.Add(dr[0].ToString());
                }

            MSSQL_practice.Homepage.conn.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (id_comboBox.SelectedItem == null)
            {
                remind.Text = "點選刪除時 id 不可為空或不存在";
            }
            else
            {
                remind.Text = "id: " + id_comboBox.SelectedItem.ToString() + " 已經刪除";
                string sql = "DELETE FROM " + table_comboBox.SelectedItem.ToString() + " WHERE id = '" + id_comboBox.SelectedItem.ToString() + "'";
                using (SqlCommand cmd = new SqlCommand(sql, MSSQL_practice.Homepage.conn))
                {
                    MSSQL_practice.Homepage.conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("刪除商品資料成功");  

                    string sql_GridView1 = "select * from " + table_comboBox.SelectedItem.ToString();
                    SqlDataAdapter myda = new SqlDataAdapter(sql_GridView1, MSSQL_practice.Homepage.conn);
                    DataTable dt = new DataTable(); 
                    myda.Fill(dt); 
                    dataGridView1.DataSource = dt; 

                    MSSQL_practice.Homepage.conn.Close(); 
                }
            }
        }
        
    }
}
