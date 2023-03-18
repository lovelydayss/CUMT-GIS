namespace Sells_system.pages
{
    partial class examine_sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examine_sell));
            this.text_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.All_goods = new System.Windows.Forms.Button();
            this.Dgv_sell = new System.Windows.Forms.DataGridView();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sells_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sell)).BeginInit();
            this.SuspendLayout();
            // 
            // text_type
            // 
            this.text_type.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_type.Location = new System.Drawing.Point(207, 65);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(108, 27);
            this.text_type.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(73, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "商品型号";
            // 
            // All_goods
            // 
            this.All_goods.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.All_goods.Location = new System.Drawing.Point(558, 31);
            this.All_goods.Name = "All_goods";
            this.All_goods.Size = new System.Drawing.Size(171, 47);
            this.All_goods.TabIndex = 61;
            this.All_goods.Text = "显示全部销售订单";
            this.All_goods.UseVisualStyleBackColor = true;
            this.All_goods.Click += new System.EventHandler(this.All_goods_Click);
            // 
            // Dgv_sell
            // 
            this.Dgv_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sell.Location = new System.Drawing.Point(38, 122);
            this.Dgv_sell.Name = "Dgv_sell";
            this.Dgv_sell.RowHeadersWidth = 51;
            this.Dgv_sell.RowTemplate.Height = 27;
            this.Dgv_sell.Size = new System.Drawing.Size(717, 336);
            this.Dgv_sell.TabIndex = 60;
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_name.Location = new System.Drawing.Point(207, 25);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(108, 27);
            this.text_name.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "商品名";
            // 
            // Sells_data
            // 
            this.Sells_data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sells_data.Location = new System.Drawing.Point(377, 31);
            this.Sells_data.Name = "Sells_data";
            this.Sells_data.Size = new System.Drawing.Size(109, 47);
            this.Sells_data.TabIndex = 65;
            this.Sells_data.Text = "查询";
            this.Sells_data.UseVisualStyleBackColor = true;
            this.Sells_data.Click += new System.EventHandler(this.Sells_data_Click);
            // 
            // examine_sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.Sells_data);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.All_goods);
            this.Controls.Add(this.Dgv_sell);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examine_sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 销售表显示";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button All_goods;
        private System.Windows.Forms.DataGridView Dgv_sell;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sells_data;
    }
}