using Sells_system.pages;
using System;
using System.Windows.Forms;

namespace Sells_system
{
    public partial class main_form : Form
    {
        public User user=new User();

        public main_form()
        {
            InitializeComponent();
        }

        //退出

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr= MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr==System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //修改密码

        private void Change_pwd_Click(object sender, EventArgs e)
        {
            change_password cp = new change_password();
            cp.user = this.user;
            cp.Show();
            this.user = cp.user;
        }

        //添加用户

        private void User_add_Click(object sender, EventArgs e)
        {
            registration reg = new registration();
            reg.Show();
        }

        //进货登记

        private void Stocks_Click(object sender, EventArgs e)
        {
            stocks_records sr = new stocks_records();
            sr.Show();
        }

        //销售登记

        private void Sells_Click(object sender, EventArgs e)
        {
            sells_records sr = new sells_records();
            sr.Show();
        }

        //退货登记

        private void Retreats_Click(object sender, EventArgs e)
        {

            sales_return_records srr = new sales_return_records();
            srr.Show();
        }

        //日进货统计

        private void Day_stocks_Click(object sender, EventArgs e)
        {
            stock_day sd = new stock_day();
            sd.ShowDialog();
        }

        //月进货统计

        private void Month_stocks_Click(object sender, EventArgs e)
        {
            stock_month sm = new stock_month();
            sm.ShowDialog();
        }

        //季度进货统计

        private void Quarter_stocks_Click(object sender, EventArgs e)
        {
            stock_quarter sq = new stock_quarter();
            sq.ShowDialog();
        }

        //年进货统计

        private void Year_stocks_Click(object sender, EventArgs e)
        {
            stock_year sy = new stock_year();
            sy.ShowDialog();
        }

        //日销售量统计

        private void Day_sales_Click(object sender, EventArgs e)
        {
            sell_day sd = new sell_day();
            sd.ShowDialog();
        }

        //月销售统计

        private void Month_sales_Click(object sender, EventArgs e)
        {
            sell_month sm = new sell_month();
            sm.ShowDialog();
        }

        //季度销售统计

        private void Quarter_sales_Click(object sender, EventArgs e)
        {
            sell_quarter sq = new sell_quarter();
            sq.ShowDialog();
        }

        //年销售统计

        private void Year_sales_Click(object sender, EventArgs e)
        {
            sell_year sy = new sell_year();
            sy.ShowDialog();
        }

        //业绩查看

        private void Ex_records_Click(object sender, EventArgs e)
        {
            examine_records er = new examine_records();
            er.ShowDialog();
        }

        //现存货表查看

        private void Ex_goods_Click(object sender, EventArgs e)
        {
            examine_goods eg = new examine_goods();
            eg.ShowDialog();
        }

        //销售表查看

        private void Ex_sell_Click(object sender, EventArgs e)
        {
            examine_sell es = new examine_sell();
            es.ShowDialog();
        }

        //退货表查看

        private void Ex_retreat_Click(object sender, EventArgs e)
        {
            examine_retreat er = new examine_retreat();
            er.ShowDialog();
        }

        //员工表查看

        private void Ex_employee_Click(object sender, EventArgs e)
        {
            examine_employee ee = new examine_employee();
            ee.ShowDialog();
        }

        //供货商表查看

        private void Ex_manufacturer_Click(object sender, EventArgs e)
        {
            examine_manufacturer em = new examine_manufacturer();
            em.ShowDialog();
        }

        //进货表查看

        private void Ex_stock_Click(object sender, EventArgs e)
        {
            examine_stock es = new examine_stock();
            es.ShowDialog();
        }

        //彩蛋，删库跑路

        private void Delete_database_Click(object sender, EventArgs e)
        {
            DialogResult sr = MessageBox.Show("确定删除数据库？ 删除可能造成数据丢失！ ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (sr == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("傻孩子，快跑！", "提示");
                MessageBox.Show("快跑啊！", "提示");
                MessageBox.Show("你已经被逮捕，从现在时刻起，你有权保持沉默，但你说的每一句话都会做为呈堂供词！", "提示");
            }
                
        }
    }
}
