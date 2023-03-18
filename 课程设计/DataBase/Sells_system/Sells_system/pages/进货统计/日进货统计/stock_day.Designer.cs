namespace Sells_system.pages
{
    partial class stock_day
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stock_day));
            this.all_value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_fac = new System.Windows.Forms.DataGridView();
            this.text_days = new System.Windows.Forms.TextBox();
            this.text_months = new System.Windows.Forms.TextBox();
            this.text_years = new System.Windows.Forms.TextBox();
            this.statistics_day = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.all_value.Location = new System.Drawing.Point(616, 356);
            this.all_value.Name = "all_value";
            this.all_value.Size = new System.Drawing.Size(141, 27);
            this.all_value.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(465, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "进货总金额";
            // 
            // dgv_fac
            // 
            this.dgv_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fac.Location = new System.Drawing.Point(40, 286);
            this.dgv_fac.Name = "dgv_fac";
            this.dgv_fac.RowHeadersWidth = 51;
            this.dgv_fac.RowTemplate.Height = 27;
            this.dgv_fac.Size = new System.Drawing.Size(389, 168);
            this.dgv_fac.TabIndex = 33;
            // 
            // text_days
            // 
            this.text_days.Location = new System.Drawing.Point(502, 39);
            this.text_days.Name = "text_days";
            this.text_days.Size = new System.Drawing.Size(50, 25);
            this.text_days.TabIndex = 32;
            // 
            // text_months
            // 
            this.text_months.Location = new System.Drawing.Point(387, 39);
            this.text_months.Name = "text_months";
            this.text_months.Size = new System.Drawing.Size(50, 25);
            this.text_months.TabIndex = 31;
            // 
            // text_years
            // 
            this.text_years.Location = new System.Drawing.Point(281, 39);
            this.text_years.Name = "text_years";
            this.text_years.Size = new System.Drawing.Size(50, 25);
            this.text_years.TabIndex = 30;
            // 
            // statistics_day
            // 
            this.statistics_day.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statistics_day.Location = new System.Drawing.Point(648, 29);
            this.statistics_day.Name = "statistics_day";
            this.statistics_day.Size = new System.Drawing.Size(109, 41);
            this.statistics_day.TabIndex = 29;
            this.statistics_day.Text = "查询";
            this.statistics_day.UseVisualStyleBackColor = true;
            this.statistics_day.Click += new System.EventHandler(this.Statistics_day_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(568, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(455, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 27);
            this.label3.TabIndex = 27;
            this.label3.Text = "月";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(337, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "年";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "请输入所需统计日期";
            // 
            // dgv_stock
            // 
            this.dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stock.Location = new System.Drawing.Point(40, 88);
            this.dgv_stock.Name = "dgv_stock";
            this.dgv_stock.RowHeadersWidth = 51;
            this.dgv_stock.RowTemplate.Height = 27;
            this.dgv_stock.Size = new System.Drawing.Size(717, 174);
            this.dgv_stock.TabIndex = 24;
            // 
            // stock_day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.all_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_fac);
            this.Controls.Add(this.text_days);
            this.Controls.Add(this.text_months);
            this.Controls.Add(this.text_years);
            this.Controls.Add(this.statistics_day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stock_day";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日进货统计";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox all_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_fac;
        private System.Windows.Forms.TextBox text_days;
        private System.Windows.Forms.TextBox text_months;
        private System.Windows.Forms.TextBox text_years;
        private System.Windows.Forms.Button statistics_day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_stock;
    }
}