namespace Sells_system.pages
{
    partial class examine_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examine_stock));
            this.Stock_goods = new System.Windows.Forms.Button();
            this.Dgv_stock = new System.Windows.Forms.DataGridView();
            this.Stock_data = new System.Windows.Forms.Button();
            this.text_fac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Stock_goods
            // 
            this.Stock_goods.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stock_goods.Location = new System.Drawing.Point(541, 31);
            this.Stock_goods.Name = "Stock_goods";
            this.Stock_goods.Size = new System.Drawing.Size(168, 47);
            this.Stock_goods.TabIndex = 61;
            this.Stock_goods.Text = "显示全部进货订单";
            this.Stock_goods.UseVisualStyleBackColor = true;
            this.Stock_goods.Click += new System.EventHandler(this.Stock_goods_Click);
            // 
            // Dgv_stock
            // 
            this.Dgv_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_stock.Location = new System.Drawing.Point(38, 122);
            this.Dgv_stock.Name = "Dgv_stock";
            this.Dgv_stock.RowHeadersWidth = 51;
            this.Dgv_stock.RowTemplate.Height = 27;
            this.Dgv_stock.Size = new System.Drawing.Size(717, 336);
            this.Dgv_stock.TabIndex = 60;
            // 
            // Stock_data
            // 
            this.Stock_data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Stock_data.Location = new System.Drawing.Point(331, 31);
            this.Stock_data.Name = "Stock_data";
            this.Stock_data.Size = new System.Drawing.Size(139, 47);
            this.Stock_data.TabIndex = 59;
            this.Stock_data.Text = "按供货商查询";
            this.Stock_data.UseVisualStyleBackColor = true;
            this.Stock_data.Click += new System.EventHandler(this.Stock_data_Click);
            // 
            // text_fac
            // 
            this.text_fac.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_fac.Location = new System.Drawing.Point(173, 43);
            this.text_fac.Name = "text_fac";
            this.text_fac.Size = new System.Drawing.Size(108, 27);
            this.text_fac.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "供货商名";
            // 
            // examine_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.Stock_goods);
            this.Controls.Add(this.Dgv_stock);
            this.Controls.Add(this.Stock_data);
            this.Controls.Add(this.text_fac);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examine_stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 进货表显示";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Stock_goods;
        private System.Windows.Forms.DataGridView Dgv_stock;
        private System.Windows.Forms.Button Stock_data;
        private System.Windows.Forms.TextBox text_fac;
        private System.Windows.Forms.Label label1;
    }
}