namespace Sells_system.pages
{
    partial class examine_records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examine_records));
            this.all_sales = new System.Windows.Forms.Button();
            this.all_value = new System.Windows.Forms.Button();
            this.dgv_value = new System.Windows.Forms.DataGridView();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.employee_data = new System.Windows.Forms.Button();
            this.text_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // all_sales
            // 
            this.all_sales.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.all_sales.Location = new System.Drawing.Point(532, 388);
            this.all_sales.Name = "all_sales";
            this.all_sales.Size = new System.Drawing.Size(197, 47);
            this.all_sales.TabIndex = 48;
            this.all_sales.Text = "显示全体员工销售订单";
            this.all_sales.UseVisualStyleBackColor = true;
            this.all_sales.Click += new System.EventHandler(this.All_sales_Click);
            // 
            // all_value
            // 
            this.all_value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.all_value.Location = new System.Drawing.Point(532, 314);
            this.all_value.Name = "all_value";
            this.all_value.Size = new System.Drawing.Size(197, 47);
            this.all_value.TabIndex = 47;
            this.all_value.Text = "显示全体员工销售额";
            this.all_value.UseVisualStyleBackColor = true;
            this.all_value.Click += new System.EventHandler(this.All_value_Click);
            // 
            // dgv_value
            // 
            this.dgv_value.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_value.Location = new System.Drawing.Point(38, 289);
            this.dgv_value.Name = "dgv_value";
            this.dgv_value.RowHeadersWidth = 51;
            this.dgv_value.RowTemplate.Height = 27;
            this.dgv_value.Size = new System.Drawing.Size(397, 168);
            this.dgv_value.TabIndex = 46;
            // 
            // dgv_sales
            // 
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Location = new System.Drawing.Point(38, 92);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 51;
            this.dgv_sales.RowTemplate.Height = 27;
            this.dgv_sales.Size = new System.Drawing.Size(717, 174);
            this.dgv_sales.TabIndex = 45;
            // 
            // employee_data
            // 
            this.employee_data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employee_data.Location = new System.Drawing.Point(611, 25);
            this.employee_data.Name = "employee_data";
            this.employee_data.Size = new System.Drawing.Size(109, 41);
            this.employee_data.TabIndex = 44;
            this.employee_data.Text = "查询";
            this.employee_data.UseVisualStyleBackColor = true;
            this.employee_data.Click += new System.EventHandler(this.Employee_data_Click);
            // 
            // text_num
            // 
            this.text_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_num.Location = new System.Drawing.Point(263, 32);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(76, 27);
            this.text_num.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(68, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 42;
            this.label1.Text = "所需查询员工编号";
            // 
            // examine_records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.all_sales);
            this.Controls.Add(this.all_value);
            this.Controls.Add(this.dgv_value);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.employee_data);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examine_records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 业绩查看";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button all_sales;
        private System.Windows.Forms.Button all_value;
        private System.Windows.Forms.DataGridView dgv_value;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Button employee_data;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.Label label1;
    }
}