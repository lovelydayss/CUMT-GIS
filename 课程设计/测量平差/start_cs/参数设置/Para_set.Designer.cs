
namespace start_cs
{
    partial class Para_set
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
            this.buttun_change = new System.Windows.Forms.Button();
            this.buttun_return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_network_level = new System.Windows.Forms.TextBox();
            this.TB_network_type = new System.Windows.Forms.TextBox();
            this.TB_tolerance = new System.Windows.Forms.TextBox();
            this.TB_mean_errors = new System.Windows.Forms.TextBox();
            this.TB_precision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_weight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttun_change
            // 
            this.buttun_change.Location = new System.Drawing.Point(51, 386);
            this.buttun_change.Name = "buttun_change";
            this.buttun_change.Size = new System.Drawing.Size(91, 36);
            this.buttun_change.TabIndex = 0;
            this.buttun_change.Text = "更改";
            this.buttun_change.UseVisualStyleBackColor = true;
            this.buttun_change.Click += new System.EventHandler(this.buttun_change_Click);
            // 
            // buttun_return
            // 
            this.buttun_return.Location = new System.Drawing.Point(201, 386);
            this.buttun_return.Name = "buttun_return";
            this.buttun_return.Size = new System.Drawing.Size(91, 36);
            this.buttun_return.TabIndex = 1;
            this.buttun_return.Text = "返回";
            this.buttun_return.UseVisualStyleBackColor = true;
            this.buttun_return.Click += new System.EventHandler(this.buttun_return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "控制网等级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "控制网类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "限差";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "先验中误差";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "数据精度";
            // 
            // TB_network_level
            // 
            this.TB_network_level.Location = new System.Drawing.Point(192, 57);
            this.TB_network_level.Multiline = true;
            this.TB_network_level.Name = "TB_network_level";
            this.TB_network_level.Size = new System.Drawing.Size(100, 25);
            this.TB_network_level.TabIndex = 7;
            // 
            // TB_network_type
            // 
            this.TB_network_type.Location = new System.Drawing.Point(192, 107);
            this.TB_network_type.Multiline = true;
            this.TB_network_type.Name = "TB_network_type";
            this.TB_network_type.Size = new System.Drawing.Size(100, 25);
            this.TB_network_type.TabIndex = 8;
            // 
            // TB_tolerance
            // 
            this.TB_tolerance.Location = new System.Drawing.Point(192, 207);
            this.TB_tolerance.Multiline = true;
            this.TB_tolerance.Name = "TB_tolerance";
            this.TB_tolerance.Size = new System.Drawing.Size(100, 25);
            this.TB_tolerance.TabIndex = 9;
            // 
            // TB_mean_errors
            // 
            this.TB_mean_errors.Location = new System.Drawing.Point(192, 259);
            this.TB_mean_errors.Multiline = true;
            this.TB_mean_errors.Name = "TB_mean_errors";
            this.TB_mean_errors.Size = new System.Drawing.Size(100, 25);
            this.TB_mean_errors.TabIndex = 10;
            // 
            // TB_precision
            // 
            this.TB_precision.Location = new System.Drawing.Point(192, 309);
            this.TB_precision.Multiline = true;
            this.TB_precision.Name = "TB_precision";
            this.TB_precision.Size = new System.Drawing.Size(100, 25);
            this.TB_precision.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "定权方式";
            // 
            // TB_weight
            // 
            this.TB_weight.Location = new System.Drawing.Point(192, 158);
            this.TB_weight.Name = "TB_weight";
            this.TB_weight.Size = new System.Drawing.Size(100, 25);
            this.TB_weight.TabIndex = 13;
            // 
            // Para_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 463);
            this.Controls.Add(this.TB_weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_precision);
            this.Controls.Add(this.TB_mean_errors);
            this.Controls.Add(this.TB_tolerance);
            this.Controls.Add(this.TB_network_type);
            this.Controls.Add(this.TB_network_level);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttun_return);
            this.Controls.Add(this.buttun_change);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Para_set";
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.Para_set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttun_change;
        private System.Windows.Forms.Button buttun_return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_network_level;
        private System.Windows.Forms.TextBox TB_network_type;
        private System.Windows.Forms.TextBox TB_tolerance;
        private System.Windows.Forms.TextBox TB_mean_errors;
        private System.Windows.Forms.TextBox TB_precision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_weight;
    }
}