namespace Sells_system.pages
{
    partial class examine_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examine_employee));
            this.Dgv_employee = new System.Windows.Forms.DataGridView();
            this.Data_loading = new System.Windows.Forms.Button();
            this.Data_change = new System.Windows.Forms.Button();
            this.text_id = new System.Windows.Forms.TextBox();
            this.Data_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Data_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_employee
            // 
            this.Dgv_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_employee.Location = new System.Drawing.Point(29, 28);
            this.Dgv_employee.Name = "Dgv_employee";
            this.Dgv_employee.RowHeadersWidth = 51;
            this.Dgv_employee.RowTemplate.Height = 27;
            this.Dgv_employee.Size = new System.Drawing.Size(541, 414);
            this.Dgv_employee.TabIndex = 0;
            // 
            // Data_loading
            // 
            this.Data_loading.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_loading.Location = new System.Drawing.Point(616, 395);
            this.Data_loading.Name = "Data_loading";
            this.Data_loading.Size = new System.Drawing.Size(111, 47);
            this.Data_loading.TabIndex = 60;
            this.Data_loading.Text = "数据加载";
            this.Data_loading.UseVisualStyleBackColor = true;
            this.Data_loading.Click += new System.EventHandler(this.Data_loading_Click);
            // 
            // Data_change
            // 
            this.Data_change.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_change.Location = new System.Drawing.Point(616, 206);
            this.Data_change.Name = "Data_change";
            this.Data_change.Size = new System.Drawing.Size(111, 47);
            this.Data_change.TabIndex = 61;
            this.Data_change.Text = "修改";
            this.Data_change.UseVisualStyleBackColor = true;
            this.Data_change.Click += new System.EventHandler(this.Data_update_Click);
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_id.Location = new System.Drawing.Point(613, 80);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(118, 27);
            this.text_id.TabIndex = 62;
            // 
            // Data_remove
            // 
            this.Data_remove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_remove.Location = new System.Drawing.Point(616, 140);
            this.Data_remove.Name = "Data_remove";
            this.Data_remove.Size = new System.Drawing.Size(111, 47);
            this.Data_remove.TabIndex = 63;
            this.Data_remove.Text = "删除";
            this.Data_remove.UseVisualStyleBackColor = true;
            this.Data_remove.Click += new System.EventHandler(this.Data_remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(624, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 64;
            this.label1.Text = "员工编号";
            // 
            // Data_add
            // 
            this.Data_add.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Data_add.Location = new System.Drawing.Point(616, 323);
            this.Data_add.Name = "Data_add";
            this.Data_add.Size = new System.Drawing.Size(111, 47);
            this.Data_add.TabIndex = 65;
            this.Data_add.Text = "新员工添加";
            this.Data_add.UseVisualStyleBackColor = true;
            this.Data_add.Click += new System.EventHandler(this.Data_add_Click);
            // 
            // examine_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Controls.Add(this.Data_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data_remove);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.Data_change);
            this.Controls.Add(this.Data_loading);
            this.Controls.Add(this.Dgv_employee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examine_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工表显示";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_employee;
        private System.Windows.Forms.Button Data_loading;
        private System.Windows.Forms.Button Data_change;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Button Data_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Data_add;
    }
}