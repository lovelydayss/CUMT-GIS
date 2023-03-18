using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sells_system.pages.sales_manage;

namespace Sells_system.pages
{
    public partial class stocks_records : Form
    {

        public int goods_id;
       
        public stocks_records()
        {
            InitializeComponent();
        }

        //返回

        private void Sr_return_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //添加入库

        private void Add_sr_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            if (!CheckFactor())
                return;
            if (!CheckEmployee())
                return;

            if (!Update_goods_sr())
            {
                MessageBox.Show("存货数据库更新失败，请重试");
                return;
            }
            if (!Update_stock_sr())
            {
                MessageBox.Show("进货订单入库失败，请重试");
                return;
            }

            DialogResult sr = MessageBox.Show("进货订单更新成功 ，是否继续添加？ ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        //输入检查

        public bool CheckInput()
        {
            if (text_name.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入商品名称！ ");
                return false;
            }
            if (text_fac.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入生产厂商！ ");
                return false;
            }
            if (text_type.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入型号！ ");
                return false;
            }
            if (text_value.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入单价！ ");
                return false;
            }
            if (text_num.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入数量！ ");
                return false;
            }
            if (text_date_year.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入进货年份！ ");
                return false;
            }
            if (text_date_month.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入进货月份！ ");
                return false;
            }
            if (text_date_day.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入进货日期！ ");
                return false;
            }
            if (text_employee.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入业务员编号！ ");
                return false;
            }
            if (text_all_value.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入进货总金额！ ");
                return false;
            }

            if (Convert.ToInt32(text_date_day.Text.Trim()) > 31 || Convert.ToInt32(text_date_month.Text.Trim()) > 12)
            {
                MessageBox.Show(" 进货日期存在问题，请确认！ ");
                return false;
            }

            if (Convert.ToInt32(text_date_day.Text.Trim()) < 0 || Convert.ToInt32(text_date_month.Text.Trim()) < 0 || Convert.ToInt32(text_date_year.Text.Trim()) < 0)
            {
                MessageBox.Show(" 进货日期存在问题，请确认！ ");
                return false;
            }

            if (Convert.ToInt32(text_value.Text.Trim()) < 0)
            {
                MessageBox.Show(" 商品单价不能为负数！ ");
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


            if (Convert.ToInt32(text_all_value.Text.Trim()) != Convert.ToInt32(text_num.Text.Trim()) * Convert.ToInt32(text_value.Text.Trim()))
            {
                MessageBox.Show(" 进货总金额不符，请重试！ ");
                return false;
            }
            

            return true;
        }

        //供货商检查

        public bool CheckFactor()
        {
            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [manufacturer] where 厂商名称='{0}'", text_fac.Text.Trim());
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
                    DialogResult srf = MessageBox.Show(" 未找到当前供货商，是否添加？ ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (srf == System.Windows.Forms.DialogResult.OK)
                    {
                        factor_add fa = new factor_add();
                        fa.Fac_name = text_fac.Text.Trim();
                        fa.ShowDialog();
                        if(fa.result>0)
                        {
                            return true;
                        }
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
                        if(ea.result>0)
                        {
                            return true;
                        }
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

        //进货订单数据库更新

        private bool Update_stock_sr()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;


            try
            {
                //1.sql语句
                string sql = string.Format(@"insert into stock(商品名,生产厂商,型号,单价,数量,进货年,进货月,进货日,业务员编号,总金额) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", 
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
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [goods] where 商品名='{0}'and 型号='{1}'and 生产厂商='{2}'", 
                    text_name.Text.Trim(),text_type.Text.Trim(), text_fac.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if (reader.Read())
                {
                    goods_id = Convert.ToInt32(reader["商品编号"]);
                    result = Update_data_sr();
                }
                else
                {
                    DialogResult srf = MessageBox.Show(" 未找到当前商品项，是否添加新商品项？ ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (srf == System.Windows.Forms.DialogResult.OK)
                    {
                        result = Add_goods_sr();
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

            return result > 0;

        }

        //存货数据库添加新数据项

        private int Add_goods_sr()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"insert into goods(商品名,型号,数量,生产厂商)values('{0}','{1}','{2}','{3}')",
                    text_name.Text.Trim(), text_type.Text.Trim(), text_num.Text.Trim(), text_fac.Text.Trim());
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
            
            if (result > 0)
            {
                MessageBox.Show("成功添加新商品项");
            }
            else
            {
                MessageBox.Show("新商品项添加失败，请重试");
            }

            return result;
        }
    
        //存货数据库修改原有数据项

        private int Update_data_sr()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"update goods set 数量+='{0}' where 商品编号='{1}'",
                     text_num.Text.Trim(),goods_id);
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
