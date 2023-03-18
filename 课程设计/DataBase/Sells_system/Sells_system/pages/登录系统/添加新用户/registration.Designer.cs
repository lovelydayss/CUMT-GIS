namespace Sells_system
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.Reg = new System.Windows.Forms.Button();
            this.return_mf = new System.Windows.Forms.Button();
            this.text_reg1 = new System.Windows.Forms.TextBox();
            this.text_reg2 = new System.Windows.Forms.TextBox();
            this.text_reg3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Reg
            // 
            this.Reg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reg.Location = new System.Drawing.Point(72, 278);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(117, 47);
            this.Reg.TabIndex = 0;
            this.Reg.Text = "添加";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // return_mf
            // 
            this.return_mf.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.return_mf.Location = new System.Drawing.Point(253, 278);
            this.return_mf.Name = "return_mf";
            this.return_mf.Size = new System.Drawing.Size(117, 47);
            this.return_mf.TabIndex = 1;
            this.return_mf.Text = "返回";
            this.return_mf.UseVisualStyleBackColor = true;
            this.return_mf.Click += new System.EventHandler(this.Return_mf_Click);
            // 
            // text_reg1
            // 
            this.text_reg1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_reg1.Location = new System.Drawing.Point(231, 55);
            this.text_reg1.Name = "text_reg1";
            this.text_reg1.Size = new System.Drawing.Size(149, 27);
            this.text_reg1.TabIndex = 2;
            // 
            // text_reg2
            // 
            this.text_reg2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_reg2.Location = new System.Drawing.Point(231, 122);
            this.text_reg2.Name = "text_reg2";
            this.text_reg2.PasswordChar = '*';
            this.text_reg2.Size = new System.Drawing.Size(149, 27);
            this.text_reg2.TabIndex = 3;
            // 
            // text_reg3
            // 
            this.text_reg3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_reg3.Location = new System.Drawing.Point(231, 191);
            this.text_reg3.Name = "text_reg3";
            this.text_reg3.PasswordChar = '*';
            this.text_reg3.Size = new System.Drawing.Size(149, 27);
            this.text_reg3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(85, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(67, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "确认密码";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 373);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_reg3);
            this.Controls.Add(this.text_reg2);
            this.Controls.Add(this.text_reg1);
            this.Controls.Add(this.return_mf);
            this.Controls.Add(this.Reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新用户添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.Button return_mf;
        private System.Windows.Forms.TextBox text_reg1;
        private System.Windows.Forms.TextBox text_reg2;
        private System.Windows.Forms.TextBox text_reg3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}