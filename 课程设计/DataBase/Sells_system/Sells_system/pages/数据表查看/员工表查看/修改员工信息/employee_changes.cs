using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class employee_changes : Form
    {
        public Employee employee=new Employee();

        public employee_changes()
        {
            InitializeComponent();
        }

        //返回

        private void Ea_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改

        private void Ea_change_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            if (Update_ea() > 0)
            {
                MessageBox.Show("修改员工信息成功! ");
                this.Close();
            }
            else
            {
                MessageBox.Show("员工信息修改失败,请重试! ");
            }
        }

        //显示

        private void Data_show(object sender, EventArgs e)
        {
            text_name.Text = employee.EmployeeName;
            text_phone.Text = employee.EmployeePhone;
            text_address.Text = employee.EmployeeAdress;
        }

        //输入检查

        public bool CheckInput()
        {
            if (text_name.Text.Trim() == "")
            {
                MessageBox.Show(" 员工姓名不能为空！ ");
                return false;
            }
            if (text_phone.Text.Trim() == "")
            {
                MessageBox.Show(" 员工电话不能为空！ ");
                return false;
            }
            if (text_address.Text.Trim() == "")
            {
                MessageBox.Show(" 员工地址不能为空！ ");
                return false;
            }

            return true;
        }

        //数据库更新

        private int Update_ea()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {

                //1.sql语句
                string sql = string.Format(@"update [employee] set 员工姓名='{0}',员工电话='{1}',员工地址='{2}'where 员工编号='{3}'"
                                             , text_name.Text.Trim(), text_phone.Text.Trim(), text_address.Text.Trim(),employee.EmployeeId);
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
