
namespace start_cs
{
    partial class Mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Parameter_set = new System.Windows.Forms.Button();
            this.Data_import = new System.Windows.Forms.Button();
            this.Adjust_computation = new System.Windows.Forms.Button();
            this.Text_adjust_data = new System.Windows.Forms.TextBox();
            this.Text_adjust_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.File_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Parameter_set
            // 
            this.Parameter_set.Location = new System.Drawing.Point(49, 550);
            this.Parameter_set.Name = "Parameter_set";
            this.Parameter_set.Size = new System.Drawing.Size(89, 38);
            this.Parameter_set.TabIndex = 0;
            this.Parameter_set.Text = "参数设置";
            this.Parameter_set.UseVisualStyleBackColor = true;
            this.Parameter_set.Click += new System.EventHandler(this.Parameter_set_Click);
            // 
            // Data_import
            // 
            this.Data_import.Location = new System.Drawing.Point(183, 550);
            this.Data_import.Name = "Data_import";
            this.Data_import.Size = new System.Drawing.Size(89, 38);
            this.Data_import.TabIndex = 1;
            this.Data_import.Text = "导入数据";
            this.Data_import.UseVisualStyleBackColor = true;
            this.Data_import.Click += new System.EventHandler(this.Data_import_Click);
            // 
            // Adjust_computation
            // 
            this.Adjust_computation.Location = new System.Drawing.Point(319, 550);
            this.Adjust_computation.Name = "Adjust_computation";
            this.Adjust_computation.Size = new System.Drawing.Size(89, 38);
            this.Adjust_computation.TabIndex = 2;
            this.Adjust_computation.Text = "平差计算";
            this.Adjust_computation.UseVisualStyleBackColor = true;
            this.Adjust_computation.Click += new System.EventHandler(this.Adjust_computation_Click);
            // 
            // Text_adjust_data
            // 
            this.Text_adjust_data.Location = new System.Drawing.Point(49, 57);
            this.Text_adjust_data.Multiline = true;
            this.Text_adjust_data.Name = "Text_adjust_data";
            this.Text_adjust_data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Text_adjust_data.Size = new System.Drawing.Size(514, 187);
            this.Text_adjust_data.TabIndex = 3;
            // 
            // Text_adjust_result
            // 
            this.Text_adjust_result.Location = new System.Drawing.Point(49, 286);
            this.Text_adjust_result.Multiline = true;
            this.Text_adjust_result.Name = "Text_adjust_result";
            this.Text_adjust_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Text_adjust_result.Size = new System.Drawing.Size(514, 218);
            this.Text_adjust_result.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "起算数据";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "平差结果";
            // 
            // File_save
            // 
            this.File_save.Location = new System.Drawing.Point(461, 550);
            this.File_save.Name = "File_save";
            this.File_save.Size = new System.Drawing.Size(89, 38);
            this.File_save.TabIndex = 7;
            this.File_save.Text = "保存成果";
            this.File_save.UseVisualStyleBackColor = true;
            this.File_save.Click += new System.EventHandler(this.File_save_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 627);
            this.Controls.Add(this.File_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text_adjust_result);
            this.Controls.Add(this.Text_adjust_data);
            this.Controls.Add(this.Adjust_computation);
            this.Controls.Add(this.Data_import);
            this.Controls.Add(this.Parameter_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "测量平差";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Parameter_set;
        private System.Windows.Forms.Button Data_import;
        private System.Windows.Forms.Button Adjust_computation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button File_save;
        public System.Windows.Forms.TextBox Text_adjust_data;
        public System.Windows.Forms.TextBox Text_adjust_result;
    }
}

