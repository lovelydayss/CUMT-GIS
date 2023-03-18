using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class employee_adds : Form
    {
        private int employee_id = 0;

        public employee_adds()
        {
            InitializeComponent();
        }

        //添加

        private void Ea_add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            Update_ea();
            if (employee_id > 0)
            {
                MessageBox.Show(string.Format(" 成功添加员工,员工编号为 {0}", employee_id));
                this.Close();
            }
            else
            {
                MessageBox.Show(" 添加员工失败,请重试!");
            }
        }

        //返回

        private void Ea_return_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Update_ea()
        {
            DB_helper dbHelper = new DB_helper();

            try
            {

                //1.sql语句
                string sql = string.Format(@"insert into employee(员工姓名,员工电话,员工地址) values ('{0}','{1}','{2}');SELECT @@Identity;"
                                             , text_name.Text.Trim(), text_phone.Text.Trim(), text_address.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                employee_id = Convert.ToInt32(cmd.ExecuteScalar());
            
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
