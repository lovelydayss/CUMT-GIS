using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class sell_quarter : Form
    {
        DataSet ds = new DataSet();

        public sell_quarter()
        {
            InitializeComponent();
        }

        //查询

        private void Statistics_quarter_Click(object sender, EventArgs e)
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
            if (text_quarters.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入所需查询季度！ ");
                return false;
            }
            if (Convert.ToInt32(text_quarters.Text.Trim()) > 4||Convert.ToInt32(text_quarters.Text.Trim()) <0)
            {
                MessageBox.Show(" 季度输入存在问题，请确认！ ");
                return false;
            }

            return true;
        }

        //季度首月份

        public int First_month_of_quarter(int qua)
        {
            if (qua == 1)
            {
                return 1;
            }
            if (qua == 2)
            {
                return 4;
            }
            if (qua == 3)
            {
                return 7;
            }
            if (qua == 4)
            {
                return 10;
            }

            return 0;
        }

        //季度尾月份

        public int Last_month_of_quarter(int qua)
        {
            if (qua == 1)
            {
                return 3;
            }
            if (qua == 2)
            {
                return 6;
            }
            if (qua == 3)
            {
                return 9;
            }
            if (qua == 4)
            {
                return 12;
            }

            return 0;
        }


        //销售订单统计

        private void Select_sales()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();
            int quarter = Convert.ToInt32(text_quarters.Text.Trim());

            try
            {
                //1.sql语句
                string sql = string.Format(@"select * from sell where 销售年='{0}'and 销售月 between'{1}'and'{2}'"
                                            , text_years.Text.Trim(), First_month_of_quarter(quarter), Last_month_of_quarter(quarter));
                //2.DatAdapter工具
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
            int quarter = Convert.ToInt32(text_quarters.Text.Trim());

            try
            {
                //1.sql语句
                string sql = string.Format(@"select 生产厂商,sum(总金额) 生产厂商总金额 from sell where 销售年='{0}'and 销售月 between'{1}'and'{2}' group by 生产厂商 "
                                            , text_years.Text.Trim(), First_month_of_quarter(quarter), Last_month_of_quarter(quarter));
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
            int quarter = Convert.ToInt32(text_quarters.Text.Trim());

            try
            {
                //1.sql语句
                string sql = string.Format(@"select sum(总金额)总金额 from sell where 销售年='{0}'and 销售月 between'{1}'and'{2}'"
                                            , text_years.Text.Trim(), First_month_of_quarter(quarter), Last_month_of_quarter(quarter));
                //2.DataAdapter 工具
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
