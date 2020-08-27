namespace MSSQL_practice
{
    partial class addpage
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
            this.label1 = new System.Windows.Forms.Label();
            this.determine = new System.Windows.Forms.Button();
            this.table_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 25);
            this.back.TabIndex = 0;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // determine
            // 
            this.determine.Location = new System.Drawing.Point(200, 45);
            this.determine.Name = "determine";
            this.determine.Size = new System.Drawing.Size(100, 25);
            this.determine.TabIndex = 3;
            this.determine.Text = "確定新增";
            this.determine.UseVisualStyleBackColor = true;
            this.determine.Click += new System.EventHandler(this.determine_add);
            // 
            // table_dataGridView
            // 
            this.table_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_dataGridView.Location = new System.Drawing.Point(308, 12);
            this.table_dataGridView.Name = "table_dataGridView";
            this.table_dataGridView.RowTemplate.Height = 27;
            this.table_dataGridView.Size = new System.Drawing.Size(860, 584);
            this.table_dataGridView.TabIndex = 4;
            // 
            // addpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 608);
            this.Controls.Add(this.table_dataGridView);
            this.Controls.Add(this.determine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "addpage";
            this.Text = "新增頁面";
            ((System.ComponentModel.ISupportInitialize)(this.table_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button determine;
        private System.Windows.Forms.DataGridView table_dataGridView;
    }
}