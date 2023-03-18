namespace Sells_system.pages
{
    partial class examine_retreat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examine_retreat));
            this.text_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.All_retreat = new System.Windows.Forms.Button();
            this.Dgv_retreat = new System.Windows.Forms.DataGridView();
            this.Retreat_data = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_retreat)).BeginInit();
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
            // All_retreat
            // 
            this.All_retreat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.All_retreat.Location = new System.Drawing.Point(558, 31);
            this.All_retreat.Name = "All_retreat";
            this.All_retreat.Size = new System.Drawing.Size(170, 47);
            this.All_retreat.TabIndex = 61;
            this.All_retreat.Text = "显示全部退货订单";
            this.All_retreat.UseVisualStyleBackColor = true;
            this.All_retreat.Click += new System.EventHandler(this.All_retreat_Click);
            // 
            // Dgv_retreat
            // 
            this.Dgv_retreat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_retreat.Location = new System.Drawing.Point(38, 122);
            this.Dgv_retreat.Name = "Dgv_retreat";
            this.Dgv_retreat.RowHeadersWidth = 51;
            this.Dgv_retreat.RowTemplate.Height = 27;
            this.Dgv_retreat.Size = new System.Drawing.Size(717, 336);
            this.Dgv_retreat.TabIndex = 60;
            // 
            // Retreat_data
            // 
            this.Retreat_data.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Retreat_data.Location = new System.Drawing.Point(380, 31);
            this.Retreat_data.Name = "Retreat_data";
            this.Retreat_data.Size = new System.Drawing.Size(109, 47);
            this.Retreat_data.TabIndex = 59;
            this.Retreat_data.Text = "查询";
            this.Retreat_data.UseVisualStyleBackColor = true;
            this.Retreat_data.Click += new System.EventHandler(this.Retreat_data_Click);
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
            // examine_retreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.All_retreat);
            this.Controls.Add(this.Dgv_retreat);
            this.Controls.Add(this.Retreat_data);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examine_retreat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 退货表显示";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_retreat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button All_retreat;
        private System.Windows.Forms.DataGridView Dgv_retreat;
        private System.Windows.Forms.Button Retreat_data;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label1;
    }
}