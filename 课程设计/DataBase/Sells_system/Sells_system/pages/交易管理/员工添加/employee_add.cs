using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sells_system.pages.sales_manage
{
    public partial class employee_add : Form
    {
        public string Employee_id;
        public int result = 0;

        public employee_add()
        {
            InitializeComponent();
        }

        //添加入库

        private void Ea_add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            result = Update_ea();
            if (result > 0)
            {
                MessageBox.Show("成功添加员工");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加员工失败");
            }
        }

        //清空重填

        private void Ea_reset_Click(object sender, EventArgs e)
        {
            text_name.Text = "";
            text_phone.Text = "";
            text_address.Text = "";
        }

        //返回

        private void Ea_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //显示

        private void Employee_show(object sender, EventArgs e)
        {
            text_id.Text = Employee_id;
        }

        //输入检查

        public bool CheckInput()
        {

            if (text_name.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入员工姓名！ ");
                return false;
            }
            if (text_phone.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入员工电话！ ");
                return false;
            }
            if (text_address.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入员工地址！ ");
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
                string sql = string.Format(@"set identity_insert employee ON;
                                             insert into employee(员工编号,员工姓名,员工电话,员工地址) values ('{0}','{1}','{2}','{3}');
                                             set identity_insert employee OFF",
                                             text_id.Text.Trim(), text_name.Text.Trim(), text_phone.Text.Trim(), text_address.Text.Trim());
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
