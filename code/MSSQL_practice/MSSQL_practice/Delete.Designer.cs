namespace MSSQL_practice
{
    partial class Deletepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Button();
            this.table_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.table_comboBox = new System.Windows.Forms.ComboBox();
            this.id_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.remind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 25);
            this.back.TabIndex = 5;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            // 
            // table_label
            // 
            this.table_label.AutoSize = true;
            this.table_label.Location = new System.Drawing.Point(9, 53);
            this.table_label.Name = "table_label";
            this.table_label.Size = new System.Drawing.Size(39, 15);
            this.table_label.TabIndex = 6;
            this.table_label.Text = "Table";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(12, 91);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(18, 15);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "id";
            // 
            // table_comboBox
            // 
            this.table_comboBox.FormattingEnabled = true;
            this.table_comboBox.Location = new System.Drawing.Point(54, 50);
            this.table_comboBox.Name = "table_comboBox";
            this.table_comboBox.Size = new System.Drawing.Size(121, 23);
            this.table_comboBox.TabIndex = 8;
            this.table_comboBox.SelectedIndexChanged += new System.EventHandler(this.table_comboBox_SelectedIndexChanged);
            // 
            // id_comboBox
            // 
            this.id_comboBox.FormattingEnabled = true;
            this.id_comboBox.Location = new System.Drawing.Point(54, 88);
            this.id_comboBox.Name = "id_comboBox";
            this.id_comboBox.Size = new System.Drawing.Size(121, 23);
            this.id_comboBox.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(860, 479);
            this.dataGridView1.TabIndex = 10;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(201, 88);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 25);
            this.delete.TabIndex = 11;
            this.delete.Text = "確定刪除";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // remind
            // 
            this.remind.AutoSize = true;
            this.remind.Location = new System.Drawing.Point(307, 93);
            this.remind.Name = "remind";
            this.remind.Size = new System.Drawing.Size(0, 15);
            this.remind.TabIndex = 13;
            // 
            // Deletepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 608);
            this.Controls.Add(this.remind);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.id_comboBox);
            this.Controls.Add(this.table_comboBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.table_label);
            this.Controls.Add(this.back);
            this.Name = "Deletepage";
            this.Text = "刪除頁面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label table_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.ComboBox table_comboBox;
        private System.Windows.Forms.ComboBox id_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label remind;
    }
}