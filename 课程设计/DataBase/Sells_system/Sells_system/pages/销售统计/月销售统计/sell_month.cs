using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class sell_month : Form
    {
        DataSet ds = new DataSet();

        public sell_month()
        {
            InitializeComponent();
        }

        //查询

        private void Statistics_month_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }

            Select_sales();
            Select_fac();
            Select_all_value();
        }

        //输入检查

        public bool CheckInput()
        {
            if (text_years.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入所需查询年份！ ");
                return false;
            }
            if (text_months.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入所需查询月份！ ");
                return false;
            }
            if (Convert.ToInt32(text_months.Text.Trim()) > 12)
            {
                MessageBox.Show(" 月份输入存在问题，请确认！ ");
                return false;
            }

            if ( Convert.ToInt32(text_months.Text.Trim()) < 0 || Convert.ToInt32(text_years.Text.Trim()) < 0)
            {
                MessageBox.Show(" 日期存在问题，请确认！ ");
                return false;
            }

            return true;
        }

        //销售订单统计

        private void Select_sales()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [sell] where 销售年='{0}'and 销售月='{1}'", text_years.Text.Trim(), text_months.Text.Trim());
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "sales");
                this.dgv_sales.DataSource = this.ds.Tables["sales"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        //供货商统计

        private void Select_fac()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select 生产厂商,sum(总金额) 生产厂商总金额 from [sell] where 销售年='{0}'and 销售月='{1}' group by 生产厂商"
                                            , text_years.Text.Trim(), text_months.Text.Trim());
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "fac");
                this.dgv_fac.DataSource = this.ds.Tables["fac"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        //总金额统计

        private void Select_all_value()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select sum(总金额)总金额 from [sell] where 销售年='{0}'and 销售月='{1}'", text_years.Text.Trim(), text_months.Text.Trim());
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "all");
                this.all_value.Text = this.ds.Tables["all"].Rows[0]["总金额"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        
    }
}
