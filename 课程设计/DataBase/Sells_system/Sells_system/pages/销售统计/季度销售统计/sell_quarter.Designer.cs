namespace Sells_system.pages
{
    partial class sell_quarter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sell_quarter));
            this.all_value = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_fac = new System.Windows.Forms.DataGridView();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.statistics_quarter = new System.Windows.Forms.Button();
            this.text_quarters = new System.Windows.Forms.TextBox();
            this.text_years = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // all_value
            // 
            this.all_value.Enabled = false;
            this.all_value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.all_value.Location = new System.Drawing.Point(617, 363);
            this.all_value.Name = "all_value";
            this.all_value.Size = new System.Drawing.Size(138, 27);
            this.all_value.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(472, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 38;
            this.label5.Text = "销售总金额";
            // 
            // dgv_fac
            // 
            this.dgv_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fac.Location = new System.Drawing.Point(38, 287);
            this.dgv_fac.Name = "dgv_fac";
            this.dgv_fac.RowHeadersWidth = 51;
            this.dgv_fac.RowTemplate.Height = 27;
            this.dgv_fac.Size = new System.Drawing.Size(379, 168);
            this.dgv_fac.TabIndex = 37;
            // 
            // dgv_sales
            // 
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Location = new System.Drawing.Point(38, 93);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.RowHeadersWidth = 51;
            this.dgv_sales.RowTemplate.Height = 27;
            this.dgv_sales.Size = new System.Drawing.Size(717, 174);
            this.dgv_sales.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(324, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "年     第";
            // 
            // statistics_quarter
            // 
            this.statistics_quarter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statistics_quarter.Location = new System.Drawing.Point(617, 27);
            this.statistics_quarter.Name = "statistics_quarter";
            this.statistics_quarter.Size = new System.Drawing.Size(109, 41);
            this.statistics_quarter.TabIndex = 34;
            this.statistics_quarter.Text = "查询";
            this.statistics_quarter.UseVisualStyleBackColor = true;
            this.statistics_quarter.Click += new System.EventHandler(this.Statistics_quarter_Click);
            // 
            // text_quarters
            // 
            this.text_quarters.Location = new System.Drawing.Point(423, 37);
            this.text_quarters.Name = "text_quarters";
            this.text_quarters.Size = new System.Drawing.Size(50, 25);
            this.text_quarters.TabIndex = 33;
            // 
            // text_years
            // 
            this.text_years.Location = new System.Drawing.Point(260, 37);
            this.text_years.Name = "text_years";
            this.text_years.Size = new System.Drawing.Size(50, 25);
            this.text_years.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(486, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 31;
            this.label3.Text = "季度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 30;
            this.label1.Text = "所需统计季度为";
            // 
            // sell_quarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.all_value);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_fac);
            this.Controls.Add(this.dgv_sales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statistics_quarter);
            this.Controls.Add(this.text_quarters);
            this.Controls.Add(this.text_years);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sell_quarter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "季度销售统计";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox all_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_fac;
        private System.Windows.Forms.DataGridView dgv_sales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button statistics_quarter;
        private System.Windows.Forms.TextBox text_quarters;
        private System.Windows.Forms.TextBox text_years;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}