namespace Sells_system.pages
{
    partial class examine_manufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examine_manufacturer));
            this.Data_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Data_remove = new System.Windows.Forms.Button();
            this.text_fac = new System.Windows.Forms.TextBox();
            this.Data_change = new System.Windows.Forms.Button();
            this.Data_loading = new System.Windows.Forms.Button();
            this.Dgv_fac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_fac)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_add
            // 
            this.Data_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_add.Location = new System.Drawing.Point(632, 329);
            this.Data_add.Name = "Data_add";
            this.Data_add.Size = new System.Drawing.Size(111, 47);
            this.Data_add.TabIndex = 72;
            this.Data_add.Text = "添加供货商";
            this.Data_add.UseVisualStyleBackColor = true;
            this.Data_add.Click += new System.EventHandler(this.Data_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(631, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 71;
            this.label1.Text = "供货商名称";
            // 
            // Data_remove
            // 
            this.Data_remove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_remove.Location = new System.Drawing.Point(632, 146);
            this.Data_remove.Name = "Data_remove";
            this.Data_remove.Size = new System.Drawing.Size(111, 47);
            this.Data_remove.TabIndex = 70;
            this.Data_remove.Text = "删除";
            this.Data_remove.UseVisualStyleBackColor = true;
            this.Data_remove.Click += new System.EventHandler(this.Data_remove_Click);
            // 
            // text_fac
            // 
            this.text_fac.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_fac.Location = new System.Drawing.Point(629, 86);
            this.text_fac.Name = "text_fac";
            this.text_fac.Size = new System.Drawing.Size(118, 27);
            this.text_fac.TabIndex = 69;
            // 
            // Data_change
            // 
            this.Data_change.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_change.Location = new System.Drawing.Point(632, 212);
            this.Data_change.Name = "Data_change";
            this.Data_change.Size = new System.Drawing.Size(111, 47);
            this.Data_change.TabIndex = 68;
            this.Data_change.Text = "修改";
            this.Data_change.UseVisualStyleBackColor = true;
            this.Data_change.Click += new System.EventHandler(this.Data_change_Click);
            // 
            // Data_loading
            // 
            this.Data_loading.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_loading.Location = new System.Drawing.Point(632, 401);
            this.Data_loading.Name = "Data_loading";
            this.Data_loading.Size = new System.Drawing.Size(111, 47);
            this.Data_loading.TabIndex = 67;
            this.Data_loading.Text = "数据加载";
            this.Data_loading.UseVisualStyleBackColor = true;
            this.Data_loading.Click += new System.EventHandler(this.Data_loading_Click);
            // 
            // Dgv_fac
            // 
            this.Dgv_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_fac.Location = new System.Drawing.Point(45, 34);
            this.Dgv_fac.Name = "Dgv_fac";
            this.Dgv_fac.RowHeadersWidth = 51;
            this.Dgv_fac.RowTemplate.Height = 27;
            this.Dgv_fac.Size = new System.Drawing.Size(541, 414);
            this.Dgv_fac.TabIndex = 66;
            // 
            // examine_manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.Data_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_remove);
            this.Controls.Add(this.text_fac);
            this.Controls.Add(this.Data_change);
            this.Controls.Add(this.Data_loading);
            this.Controls.Add(this.Dgv_fac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examine_manufacturer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供货商表显示";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_fac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Data_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Data_remove;
        private System.Windows.Forms.TextBox text_fac;
        private System.Windows.Forms.Button Data_change;
        private System.Windows.Forms.Button Data_loading;
        private System.Windows.Forms.DataGridView Dgv_fac;
    }
}