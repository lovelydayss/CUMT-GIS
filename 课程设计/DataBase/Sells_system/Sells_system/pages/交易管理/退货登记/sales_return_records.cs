using Sells_system.pages.sales_manage;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class sales_return_records : Form
    {
        public bool flag = false;
        public int goods_id;
        public int goods_nums;
        public int sell_value;

        public sales_return_records()
        {
            InitializeComponent();
        }

        //退货

        private void Add_sr_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            if (!CheckEmployee())
                return;

            if (!Update_sell_sr())
            {
                MessageBox.Show("销售数据库更新失败，请重试");
                return;
            }

            if (!Update_goods_sr())
            {
                MessageBox.Show("存货数据库更新失败，请重试");
                return;
            }

            if (!Update_sales_return_sr())
            {
                MessageBox.Show("退货订单入库失败，请重试");
                return;
            }

            DialogResult sr = MessageBox.Show("退货订单更新成功 ，是否继续添加？ ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sr == System.Windows.Forms.DialogResult.OK)
            {
                text_name.Text = "";
                text_fac.Text = "";
                text_type.Text = "";
                text_value.Text = "";
                text_num.Text = "";
                text_date_year.Text = "";
                text_date_month.Text = "";
                text_date_day.Text = "";
                text_employee.Text = "";
                text_all_value.Text = "";
            }
            else
            {
                this.Close();
            }
        }

        //清空重填

        private void Reset_sm_Click(object sender, EventArgs e)
        {
            text_name.Text = "";
            text_fac.Text = "";
            text_type.Text = "";
            text_value.Text = "";
            text_num.Text = "";
            text_date_year.Text = "";
            text_date_month.Text = "";
            text_date_day.Text = "";
            text_employee.Text = "";
            text_all_value.Text = "";
        }

        //返回

        private void Sr_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //销售订单号项显示

        private void Sales_show(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (text_id.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入销售订单号！ ");
                return;
            }

            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [sell] where 销售编号='{0}'", text_id.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if (reader.Read())
                {
                    text_name.Text = reader["商品名"].ToString();
                    text_fac.Text = reader["生产厂商"].ToString();
                    text_type.Text = reader["型号"].ToString();
                    text_value.Text = reader["单价"].ToString();
                    text_sell.Text = reader["数量"].ToString();
                    text_retreat.Text= reader["退货标识"].ToString();
                    sell_value = Convert.ToInt32(reader["单价"]);
                    flag = true;
                }
                else
                {
                    MessageBox.Show(" 未找到指定销售订单，请重试！");
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
        }


        //输入检查

        public bool CheckInput()
        {
            
            if(!flag)
            {
                MessageBox.Show(" 销售订单号存在问题，请重试！ ");
                return false;
            }

            if (text_num.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入数量！ ");
                return false;
            }
            if (text_date_year.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入退货年份！ ");
                return false;
            }
            if (text_date_month.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入退货月份！ ");
                return false;
            }
            if (text_date_day.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入退货日期！ ");
                return false;
            }
            if (text_employee.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入业务员编号！ ");
                return false;
            }
            if (text_all_value.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入退货总金额！ ");
                return false;
            }           

            if (Convert.ToInt32(text_date_day.Text.Trim()) > 31 || Convert.ToInt32(text_date_month.Text.Trim()) > 12)
            {
                MessageBox.Show(" 退货日期存在问题，请确认！ ");
                return false;
            }

            if (Convert.ToInt32(text_date_day.Text.Trim()) < 0 || Convert.ToInt32(text_date_month.Text.Trim()) < 0 || Convert.ToInt32(text_date_year.Text.Trim()) < 0)
            {
                MessageBox.Show(" 退货日期存在问题，请确认！ ");
                return false;
            }

            if (Convert.ToInt32(text_num.Text.Trim()) < 0)
            {
                MessageBox.Show(" 商品数量不能为负数！ ");
                return false;
            }
            if (Convert.ToInt32(text_employee.Text.Trim()) < 0)
            {
                MessageBox.Show(" 业务员编号不能为负数！ ");
                return false;
            }
            if (Convert.ToInt32(text_all_value.Text.Trim()) != Convert.ToInt32(text_num.Text.Trim()) * sell_value)
            {
                MessageBox.Show(" 退货总金额不符，请重试！ ");
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
                string sql = string.Format("select * from [employee] where 员工编号='{0}'", text_employee.Text.Trim());
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
                    DialogResult sre = MessageBox.Show(" 未找到当前业务员，是否添加？ ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sre == System.Windows.Forms.DialogResult.OK)
                    {
                        employee_add ea = new employee_add();
                        ea.Employee_id = text_employee.Text.Trim();
                        ea.ShowDialog();
                        return true;
                    }
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

        //退货订单数据库更新

        private bool Update_sales_return_sr()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"insert into retreat(商品名,生产厂商,型号,单价,数量,退货年,退货月,退货日,业务员编号,总金额) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                    text_name.Text.Trim(), text_fac.Text.Trim(), text_type.Text.Trim(), text_value.Text.Trim(), text_num.Text.Trim(), text_date_year.Text.Trim(), text_date_month.Text.Trim(), text_date_day.Text.Trim(), text_employee.Text.Trim(), text_all_value.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }

            return result > 0;
        }

        //存货数据库更新

        public bool Update_goods_sr()
        {
            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [goods] where 商品名='{0}'and 型号='{1}'and 生产厂商='{2}'", text_name.Text.Trim(), text_type.Text.Trim(), text_fac.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断

                if (!reader.Read())
                {
                    MessageBox.Show("未找到指定销售订单，请重试");
                    return false;
                }

                goods_id = Convert.ToInt32(reader["商品编号"]);
                goods_nums = Convert.ToInt32(reader["数量"]);

                if (Update_data_sr() > 0)
                {
                    return true;
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
        
        //存货数据库修改数据项

        private int Update_data_sr()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"update goods set 数量+='{0}' where 商品编号='{1}'",
                     text_num.Text.Trim(), goods_id);
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return result;
        }
        
        //销售数据库更新

        public bool Update_sell_sr()
        {

            try
            {
                int sell_num = Convert.ToInt32(text_sell.Text.Trim());
                int sell_retreat = Convert.ToInt32(text_retreat.Text.Trim());

                if (sell_retreat+Convert.ToInt32(text_num.Text.Trim())>sell_num)
                {
                    MessageBox.Show("订单退货量大于销售量，请重试!");
                    return false;
                }

                if (Update_sell_data_sr() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }

            return false;
        }

        //销售数据库修改数据项

        private int Update_sell_data_sr()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"update sell set 退货标识+='{0}' where 销售编号='{1}'",
                     text_num.Text.Trim(), text_id.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常： " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return result;
        }

        
    }
}
