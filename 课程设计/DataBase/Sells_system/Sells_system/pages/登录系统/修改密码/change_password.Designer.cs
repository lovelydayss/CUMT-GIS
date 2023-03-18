namespace Sells_system
{
    partial class change_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password));
            this.change = new System.Windows.Forms.Button();
            this.return_mf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_pwd1 = new System.Windows.Forms.TextBox();
            this.text_pwd2 = new System.Windows.Forms.TextBox();
            this.text_pwd3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.change.Location = new System.Drawing.Point(63, 272);
            this.change.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(117, 47);
            this.change.TabIndex = 0;
            this.change.Text = "修改";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.Change_Click);
            // 
            // return_mf
            // 
            this.return_mf.Location = new System.Drawing.Point(229, 272);
            this.return_mf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.return_mf.Name = "return_mf";
            this.return_mf.Size = new System.Drawing.Size(117, 47);
            this.return_mf.TabIndex = 1;
            this.return_mf.Text = "返回";
            this.return_mf.UseVisualStyleBackColor = true;
            this.return_mf.Click += new System.EventHandler(this.Return_mf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(58, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // text_pwd1
            // 
            this.text_pwd1.Location = new System.Drawing.Point(211, 61);
            this.text_pwd1.Name = "text_pwd1";
            this.text_pwd1.PasswordChar = '*';
            this.text_pwd1.Size = new System.Drawing.Size(175, 27);
            this.text_pwd1.TabIndex = 5;
            // 
            // text_pwd2
            // 
            this.text_pwd2.Location = new System.Drawing.Point(211, 129);
            this.text_pwd2.Name = "text_pwd2";
            this.text_pwd2.PasswordChar = '*';
            this.text_pwd2.Size = new System.Drawing.Size(175, 27);
            this.text_pwd2.TabIndex = 6;
            // 
            // text_pwd3
            // 
            this.text_pwd3.Location = new System.Drawing.Point(211, 199);
            this.text_pwd3.Name = "text_pwd3";
            this.text_pwd3.PasswordChar = '*';
            this.text_pwd3.Size = new System.Drawing.Size(175, 27);
            this.text_pwd3.TabIndex = 7;
            // 
            // change_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 373);
            this.Controls.Add(this.text_pwd3);
            this.Controls.Add(this.text_pwd2);
            this.Controls.Add(this.text_pwd1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.return_mf);
            this.Controls.Add(this.change);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button return_mf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_pwd1;
        private System.Windows.Forms.TextBox text_pwd2;
        private System.Windows.Forms.TextBox text_pwd3;
    }
}