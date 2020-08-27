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
    public partial class addpage : Form
    {
        String table_name;
        Label[] labAry;
        TextBox[] TextBoxAry;
        public addpage(string strTextMsg)
        {
            InitializeComponent();
            label1.Text = strTextMsg;
            back.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            table_name = label1.Text;
            string sql = "SELECT * FROM " + table_name;
            MSSQL_practice.Homepage.conn.ConnectionString = MSSQL_practice.Homepage.connsql;
            MSSQL_practice.Homepage.conn.Open();

            SqlDataAdapter myda = new SqlDataAdapter(sql, MSSQL_practice.Homepage.conn); 
            DataTable dt = new DataTable(); 
            myda.Fill(dt); 
            table_dataGridView.DataSource = dt;

            SqlCommand cmd = new SqlCommand(sql, MSSQL_practice.Homepage.conn);
            SqlDataReader DR = cmd.ExecuteReader();
            labAry = new Label[DR.FieldCount - 2];
            TextBoxAry = new TextBox[DR.FieldCount - 2];
            for (int i = 1; i < DR.FieldCount-1; i++)
            {
                labAry[i-1] = new Label();
                labAry[i-1].Text = DR.GetName(i).ToString();
                labAry[i-1].Location = new Point(12, 90 + (i-1) * 50);
                labAry[i-1].AutoSize = true;
                this.Controls.Add(labAry[i-1]);
                TextBoxAry[i-1] = new TextBox();
                TextBoxAry[i-1].Text = "NULL";
                TextBoxAry[i-1].Location = new Point(100, 90 + (i - 1) * 50);
                this.Controls.Add(TextBoxAry[i-1]);
            }
            MSSQL_practice.Homepage.conn.Close();
        }

        private void determine_add(object sender, EventArgs e)
        {
            table_name = label1.Text;
            StringBuilder SQL_str = new StringBuilder();
            SQL_str.Clear();
            SQL_str.Append("insert into " + table_name + "(");
            for (int i = 0; i < labAry.Length; i++)
            {
                SQL_str.Append(labAry[i].Text);
                if(i< labAry.Length -1)
                    SQL_str.Append(",");
            }
            SQL_str.Append(")values(");
            for (int i = 0; i < labAry.Length; i++)
            {
                SQL_str.Append("'" + TextBoxAry[i].Text.Trim().ToString() + "'");
                if (i < labAry.Length - 1)
                    SQL_str.Append(",");
            }
            SQL_str.Append(")");
            using (SqlCommand cmd = new SqlCommand(SQL_str.ToString(), MSSQL_practice.Homepage.conn))
            {
                MSSQL_practice.Homepage.conn.Open(); 
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("新增商品資料成功"); 

                string sql_GridView1 = "SELECT * FROM " + table_name; 
                SqlDataAdapter myda = new SqlDataAdapter(sql_GridView1, MSSQL_practice.Homepage.conn); 
                DataTable dt = new DataTable(); 
                myda.Fill(dt);
                table_dataGridView.DataSource = dt;

                MSSQL_practice.Homepage.conn.Close();  
            }
        }
    }
}
