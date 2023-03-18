using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class examine_records : Form
    {
        DataSet ds = new DataSet();

        public examine_records()
        {
            InitializeComponent();
        }

        //查询

        private void Employee_data_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (!CheckEmployee())
            {
                return;
            }

            Select_sales();
            Select_values();
        }

        //显示全体员工销售额

        private void All_value_Click(object sender, EventArgs e)
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select 业务员编号,sum(总金额) 业务员总金额 from [sell]  group by 业务员编号 ");
                //2.DataAdapter 工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "value");
                this.dgv_value.DataSource = this.ds.Tables["value"];

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

        //显示全体员工销售订单

        private void All_sales_Click(object sender, EventArgs e)
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [sell] order by 业务员编号 ASC, 销售编号 ASC");
                //2.DataAdapter 工具
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

        //输入检查

        public bool CheckInput()
        {
            if (text_num.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入所需查询员工编号！ ");
                return false;
            }

            return true;
        }

        //业务员检查

        public bool CheckEmployee()
        {
            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from employee where 员工编号='{0}'", text_num.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(" 未找到当前业务员，请重试 ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }

            return false;
        }

        //搜索员工销售订单统计

        private void Select_sales()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from sell where 业务员编号='{0}'", text_num.Text.Trim());
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

        //搜索员工销售额统计

        private void Select_values()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select 业务员编号,sum(总金额) 业务员总金额 from sell where 业务员编号='{0}' group by 业务员编号"
                                            , text_num.Text.Trim());
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "value");
                this.dgv_value.DataSource = this.ds.Tables["value"];

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
