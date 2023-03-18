using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sells_system
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        //添加新用户

        private void Reg_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int result = Reg_account();
                if (result > 0)
                {
                    MessageBox.Show("新用户添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新用户添加失败");
                }

            }
        }

        //返回

        private void Return_mf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //非空验证

        public bool CheckInput()
        {
            if (text_reg1.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名！ ");
                return false;
            }
            if (text_reg2.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！ ");
                return false;
            }
            if (text_reg3.Text.Trim() == "")
            {
                MessageBox.Show("请再次输入密码！ ");
                return false;
            }
            if (text_reg2.Text.Trim() != text_reg3.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致！ ");
                return false;
            }

            return true;
        }

        //数据库更新

        private int Reg_account()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"insert into userdb(用户名,密码) values ('{0}','{1}')"
                                            , text_reg1.Text.Trim(), text_reg2.Text.Trim());
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
