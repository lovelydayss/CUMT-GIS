using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class examine_employee : Form
    {
        DataSet ds = new DataSet();
        public Employee employee=new Employee();

        public examine_employee()
        {
            InitializeComponent();
        }

        //数据加载

        private void Data_loading_Click(object sender, EventArgs e)
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [employee] ");
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "employee");
                this.Dgv_employee.DataSource = this.ds.Tables["employee"];

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

        //修改

        private void Data_update_Click(object sender, EventArgs e)
        {
            if (!Check_input())
                return;

            employee_changes ec = new employee_changes();
            ec.employee = this.employee;
            ec.Show();
        }

        //删除

        private void Data_remove_Click(object sender, EventArgs e)
        {
            if(!Check_input())
            {
                return;
            }
            if (Check_key())
            {
                MessageBox.Show("存在与该员工相关联的订单信息，禁止删除！ ");
                return;
            }

            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {

                //1.sql语句
                string sql = string.Format(@"delete from [employee ] where 员工编号='{0}'",text_id.Text.Trim());
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

            if(result>0)
            {
                MessageBox.Show("成功删除员工数据！ ");
            }
            else
            {
                MessageBox.Show("数据删除失败，请重试！ ");
            }
        }

        //添加

        private void Data_add_Click(object sender, EventArgs e)
        {
            employee_adds ea = new employee_adds();
            ea.Show();
        }
    
        //输入检查

        private bool Check_input()
        {
            if(text_id.Text.Trim()=="")
            {
                MessageBox.Show("员工编号不能为空!");
                return false;
            }

            if (Convert.ToInt32(text_id.Text.Trim()) < 0)
            {
                MessageBox.Show(" 业务员编号不能为负数！ ");
                return false;
            }

            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [employee] where 员工编号='{0}'", text_id.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if (reader.Read())
                {
                    employee.EmployeeId = Convert.ToInt32(text_id.Text.Trim());
                    employee.EmployeeName = reader["员工姓名"].ToString();
                    employee.EmployeePhone = reader["员工电话"].ToString();
                    employee.EmployeeAdress = reader["员工地址"].ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show("员工编号无效，请重试!");
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

        //外键检查

        private bool Check_key()
        {
            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from sell,stock,retreat where sell.业务员编号='{0}' or stock.业务员编号='{0}' or retreat.业务员编号='{0}' ", text_id.Text.Trim());
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
    }
}
