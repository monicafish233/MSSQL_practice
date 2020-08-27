namespace MSSQL_practice
{
    partial class Homepage
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.data_comboBox = new System.Windows.Forms.ComboBox();
            this.link_label = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 460);
            this.dataGridView1.TabIndex = 1;
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(118, 12);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(100, 30);
            this.ADD.TabIndex = 2;
            this.ADD.Text = "新增";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.add_to_new);
            // 
            // data_comboBox
            // 
            this.data_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.data_comboBox.FormattingEnabled = true;
            this.data_comboBox.Location = new System.Drawing.Point(12, 95);
            this.data_comboBox.Name = "data_comboBox";
            this.data_comboBox.Size = new System.Drawing.Size(232, 23);
            this.data_comboBox.TabIndex = 3;
            this.data_comboBox.SelectedIndexChanged += new System.EventHandler(this.data_comboBox_SelectedIndexChanged);
            // 
            // link_label
            // 
            this.link_label.AutoSize = true;
            this.link_label.Location = new System.Drawing.Point(12, 54);
            this.link_label.Name = "link_label";
            this.link_label.Size = new System.Drawing.Size(112, 15);
            this.link_label.TabIndex = 5;
            this.link_label.Text = "鏈接資料庫成功";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(100, 30);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "刷新";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_table);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(224, 12);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(100, 30);
            this.update.TabIndex = 7;
            this.update.Text = "修改";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.updata_page);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(330, 12);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 30);
            this.delete.TabIndex = 8;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(436, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(100, 30);
            this.select.TabIndex = 9;
            this.select.Text = "查詢";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 596);
            this.Controls.Add(this.select);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.link_label);
            this.Controls.Add(this.data_comboBox);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Homepage";
            this.Text = "主頁";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.ComboBox data_comboBox;
        private System.Windows.Forms.Label link_label;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button select;
    }
}

