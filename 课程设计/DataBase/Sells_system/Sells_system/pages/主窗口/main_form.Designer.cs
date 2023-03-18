namespace Sells_system
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.登录系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.user_add = new System.Windows.Forms.ToolStripMenuItem();
            this.change_pwd = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.交易管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stocks = new System.Windows.Forms.ToolStripMenuItem();
            this.sells = new System.Windows.Forms.ToolStripMenuItem();
            this.sales_return = new System.Windows.Forms.ToolStripMenuItem();
            this.进货统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day_stocks = new System.Windows.Forms.ToolStripMenuItem();
            this.month_stocks = new System.Windows.Forms.ToolStripMenuItem();
            this.quarter_stocks = new System.Windows.Forms.ToolStripMenuItem();
            this.year_stocks = new System.Windows.Forms.ToolStripMenuItem();
            this.销售统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day_sales = new System.Windows.Forms.ToolStripMenuItem();
            this.month_sales = new System.Windows.Forms.ToolStripMenuItem();
            this.quarter_sales = new System.Windows.Forms.ToolStripMenuItem();
            this.year_sales = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_records = new System.Windows.Forms.ToolStripMenuItem();
            this.查看数据表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_goods = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_sell = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_retreat = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_manufacturer = new System.Windows.Forms.ToolStripMenuItem();
            this.ex_stock = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_database = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录系统ToolStripMenuItem,
            this.交易管理ToolStripMenuItem,
            this.进货统计ToolStripMenuItem,
            this.销售统计ToolStripMenuItem,
            this.ex_records,
            this.查看数据表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 登录系统ToolStripMenuItem
            // 
            this.登录系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_add,
            this.change_pwd,
            this.Cancel,
            this.Delete_database});
            this.登录系统ToolStripMenuItem.Name = "登录系统ToolStripMenuItem";
            this.登录系统ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.登录系统ToolStripMenuItem.Text = "登录系统";
            // 
            // user_add
            // 
            this.user_add.Name = "user_add";
            this.user_add.Size = new System.Drawing.Size(224, 26);
            this.user_add.Text = "添加用户";
            this.user_add.Click += new System.EventHandler(this.User_add_Click);
            // 
            // change_pwd
            // 
            this.change_pwd.Name = "change_pwd";
            this.change_pwd.Size = new System.Drawing.Size(224, 26);
            this.change_pwd.Text = "修改密码";
            this.change_pwd.Click += new System.EventHandler(this.Change_pwd_Click);
            // 
            // Cancel
            // 
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(224, 26);
            this.Cancel.Text = "退出";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // 交易管理ToolStripMenuItem
            // 
            this.交易管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stocks,
            this.sells,
            this.sales_return});
            this.交易管理ToolStripMenuItem.Name = "交易管理ToolStripMenuItem";
            this.交易管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.交易管理ToolStripMenuItem.Text = "交易管理";
            // 
            // stocks
            // 
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(152, 26);
            this.stocks.Text = "进货登记";
            this.stocks.Click += new System.EventHandler(this.Stocks_Click);
            // 
            // sells
            // 
            this.sells.Name = "sells";
            this.sells.Size = new System.Drawing.Size(152, 26);
            this.sells.Text = "销售登记";
            this.sells.Click += new System.EventHandler(this.Sells_Click);
            // 
            // sales_return
            // 
            this.sales_return.Name = "sales_return";
            this.sales_return.Size = new System.Drawing.Size(152, 26);
            this.sales_return.Text = "退货登记";
            this.sales_return.Click += new System.EventHandler(this.Retreats_Click);
            // 
            // 进货统计ToolStripMenuItem
            // 
            this.进货统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.day_stocks,
            this.month_stocks,
            this.quarter_stocks,
            this.year_stocks});
            this.进货统计ToolStripMenuItem.Name = "进货统计ToolStripMenuItem";
            this.进货统计ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.进货统计ToolStripMenuItem.Text = "进货统计";
            // 
            // day_stocks
            // 
            this.day_stocks.Name = "day_stocks";
            this.day_stocks.Size = new System.Drawing.Size(197, 26);
            this.day_stocks.Text = "日进货量统计";
            this.day_stocks.Click += new System.EventHandler(this.Day_stocks_Click);
            // 
            // month_stocks
            // 
            this.month_stocks.Name = "month_stocks";
            this.month_stocks.Size = new System.Drawing.Size(197, 26);
            this.month_stocks.Text = "月进货量统计";
            this.month_stocks.Click += new System.EventHandler(this.Month_stocks_Click);
            // 
            // quarter_stocks
            // 
            this.quarter_stocks.Name = "quarter_stocks";
            this.quarter_stocks.Size = new System.Drawing.Size(197, 26);
            this.quarter_stocks.Text = "季度进货量统计";
            this.quarter_stocks.Click += new System.EventHandler(this.Quarter_stocks_Click);
            // 
            // year_stocks
            // 
            this.year_stocks.Name = "year_stocks";
            this.year_stocks.Size = new System.Drawing.Size(197, 26);
            this.year_stocks.Text = "年进货量统计";
            this.year_stocks.Click += new System.EventHandler(this.Year_stocks_Click);
            // 
            // 销售统计ToolStripMenuItem
            // 
            this.销售统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.day_sales,
            this.month_sales,
            this.quarter_sales,
            this.year_sales});
            this.销售统计ToolStripMenuItem.Name = "销售统计ToolStripMenuItem";
            this.销售统计ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.销售统计ToolStripMenuItem.Text = "销售统计";
            // 
            // day_sales
            // 
            this.day_sales.Name = "day_sales";
            this.day_sales.Size = new System.Drawing.Size(197, 26);
            this.day_sales.Text = "日销售量统计";
            this.day_sales.Click += new System.EventHandler(this.Day_sales_Click);
            // 
            // month_sales
            // 
            this.month_sales.Name = "month_sales";
            this.month_sales.Size = new System.Drawing.Size(197, 26);
            this.month_sales.Text = "月销售量统计";
            this.month_sales.Click += new System.EventHandler(this.Month_sales_Click);
            // 
            // quarter_sales
            // 
            this.quarter_sales.Name = "quarter_sales";
            this.quarter_sales.Size = new System.Drawing.Size(197, 26);
            this.quarter_sales.Text = "季度销售量统计";
            this.quarter_sales.Click += new System.EventHandler(this.Quarter_sales_Click);
            // 
            // year_sales
            // 
            this.year_sales.Name = "year_sales";
            this.year_sales.Size = new System.Drawing.Size(197, 26);
            this.year_sales.Text = "年销售量统计";
            this.year_sales.Click += new System.EventHandler(this.Year_sales_Click);
            // 
            // ex_records
            // 
            this.ex_records.Name = "ex_records";
            this.ex_records.Size = new System.Drawing.Size(83, 24);
            this.ex_records.Text = "业绩查看";
            this.ex_records.Click += new System.EventHandler(this.Ex_records_Click);
            // 
            // 查看数据表ToolStripMenuItem
            // 
            this.查看数据表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex_goods,
            this.ex_sell,
            this.ex_retreat,
            this.ex_employee,
            this.ex_manufacturer,
            this.ex_stock});
            this.查看数据表ToolStripMenuItem.Name = "查看数据表ToolStripMenuItem";
            this.查看数据表ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.查看数据表ToolStripMenuItem.Text = "查看数据表";
            // 
            // ex_goods
            // 
            this.ex_goods.Name = "ex_goods";
            this.ex_goods.Size = new System.Drawing.Size(167, 26);
            this.ex_goods.Text = "现存货表";
            this.ex_goods.Click += new System.EventHandler(this.Ex_goods_Click);
            // 
            // ex_sell
            // 
            this.ex_sell.Name = "ex_sell";
            this.ex_sell.Size = new System.Drawing.Size(167, 26);
            this.ex_sell.Text = "已售商品表";
            this.ex_sell.Click += new System.EventHandler(this.Ex_sell_Click);
            // 
            // ex_retreat
            // 
            this.ex_retreat.Name = "ex_retreat";
            this.ex_retreat.Size = new System.Drawing.Size(167, 26);
            this.ex_retreat.Text = "退货表";
            this.ex_retreat.Click += new System.EventHandler(this.Ex_retreat_Click);
            // 
            // ex_employee
            // 
            this.ex_employee.Name = "ex_employee";
            this.ex_employee.Size = new System.Drawing.Size(167, 26);
            this.ex_employee.Text = "员工表";
            this.ex_employee.Click += new System.EventHandler(this.Ex_employee_Click);
            // 
            // ex_manufacturer
            // 
            this.ex_manufacturer.Name = "ex_manufacturer";
            this.ex_manufacturer.Size = new System.Drawing.Size(167, 26);
            this.ex_manufacturer.Text = "供货商表";
            this.ex_manufacturer.Click += new System.EventHandler(this.Ex_manufacturer_Click);
            // 
            // ex_stock
            // 
            this.ex_stock.Name = "ex_stock";
            this.ex_stock.Size = new System.Drawing.Size(167, 26);
            this.ex_stock.Text = "进货表";
            this.ex_stock.Click += new System.EventHandler(this.Ex_stock_Click);
            // 
            // Delete_database
            // 
            this.Delete_database.Name = "Delete_database";
            this.Delete_database.Size = new System.Drawing.Size(224, 26);
            this.Delete_database.Text = "删库跑路";
            this.Delete_database.Click += new System.EventHandler(this.Delete_database_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登录系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Cancel;
        private System.Windows.Forms.ToolStripMenuItem 交易管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stocks;
        private System.Windows.Forms.ToolStripMenuItem sells;
        private System.Windows.Forms.ToolStripMenuItem sales_return;
        private System.Windows.Forms.ToolStripMenuItem 进货统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day_stocks;
        private System.Windows.Forms.ToolStripMenuItem month_stocks;
        private System.Windows.Forms.ToolStripMenuItem quarter_stocks;
        private System.Windows.Forms.ToolStripMenuItem year_stocks;
        private System.Windows.Forms.ToolStripMenuItem 销售统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem day_sales;
        private System.Windows.Forms.ToolStripMenuItem month_sales;
        private System.Windows.Forms.ToolStripMenuItem quarter_sales;
        private System.Windows.Forms.ToolStripMenuItem year_sales;
        private System.Windows.Forms.ToolStripMenuItem ex_records;
        private System.Windows.Forms.ToolStripMenuItem 查看数据表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex_goods;
        private System.Windows.Forms.ToolStripMenuItem ex_sell;
        private System.Windows.Forms.ToolStripMenuItem ex_retreat;
        private System.Windows.Forms.ToolStripMenuItem ex_employee;
        private System.Windows.Forms.ToolStripMenuItem ex_manufacturer;
        private System.Windows.Forms.ToolStripMenuItem change_pwd;
        private System.Windows.Forms.ToolStripMenuItem ex_stock;
        private System.Windows.Forms.ToolStripMenuItem user_add;
        private System.Windows.Forms.ToolStripMenuItem Delete_database;
    }
}