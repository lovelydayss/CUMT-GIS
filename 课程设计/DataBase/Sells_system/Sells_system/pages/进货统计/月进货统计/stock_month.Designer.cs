namespace Sells_system.pages
{
    partial class stock_month
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_month));
            this.all_value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_fac = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.statistics_quarters = new System.Windows.Forms.Button();
            this.text_months = new System.Windows.Forms.TextBox();
            this.text_years = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_stock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // all_value
            // 
            this.all_value.Enabled = false;
            this.all_value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.all_value.Location = new System.Drawing.Point(617, 361);
            this.all_value.Name = "all_value";
            this.all_value.Size = new System.Drawing.Size(138, 27);
            this.all_value.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(458, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 40;
            this.label5.Text = "进货总金额";
            // 
            // dgv_fac
            // 
            this.dgv_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fac.Location = new System.Drawing.Point(38, 283);
            this.dgv_fac.Name = "dgv_fac";
            this.dgv_fac.RowHeadersWidth = 51;
            this.dgv_fac.RowTemplate.Height = 27;
            this.dgv_fac.Size = new System.Drawing.Size(390, 168);
            this.dgv_fac.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(344, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 27);
            this.label4.TabIndex = 38;
            this.label4.Text = "年 ";
            // 
            // statistics_quarters
            // 
            this.statistics_quarters.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statistics_quarters.Location = new System.Drawing.Point(617, 32);
            this.statistics_quarters.Name = "statistics_quarters";
            this.statistics_quarters.Size = new System.Drawing.Size(109, 41);
            this.statistics_quarters.TabIndex = 37;
            this.statistics_quarters.Text = "查询";
            this.statistics_quarters.UseVisualStyleBackColor = true;
            this.statistics_quarters.Click += new System.EventHandler(this.Statistics_quarters_Click);
            // 
            // text_months
            // 
            this.text_months.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_months.Location = new System.Drawing.Point(399, 39);
            this.text_months.Name = "text_months";
            this.text_months.Size = new System.Drawing.Size(50, 27);
            this.text_months.TabIndex = 36;
            // 
            // text_years
            // 
            this.text_years.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_years.Location = new System.Drawing.Point(263, 39);
            this.text_years.Name = "text_years";
            this.text_years.Size = new System.Drawing.Size(54, 27);
            this.text_years.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(470, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "月";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "所需统计月份为";
            // 
            // dgv_stock
            // 
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(38, 94);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowTemplate.Height = 27;
            this.dgv_stock.Size = new System.Drawing.Size(717, 174);
            this.dgv_stock.TabIndex = 32;
            // 
            // stock_month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.all_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_fac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statistics_quarters);
            this.Controls.Add(this.text_months);
            this.Controls.Add(this.text_years);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stock_month";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 月进货统计";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox all_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_fac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button statistics_quarters;
        private System.Windows.Forms.TextBox text_months;
        private System.Windows.Forms.TextBox text_years;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stock;
    }
}