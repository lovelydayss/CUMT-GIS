using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sells_system
{
    public partial class change_password : Form
    {
        public User user;

        public change_password()
        {
            InitializeComponent();
        }

        //修改密码

        private void Change_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
            {
                return;
            }
        
            if(Update_pwd()>0)
            {
                MessageBox.Show("密码修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("密码修改失败，请重试！");
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
            if(text_pwd1.Text.Trim()=="")
            {
                MessageBox.Show("请输入原密码！");
                return false;
            }
            if(text_pwd1.Text.Trim()!=user.UserPassword)
            {
                MessageBox.Show("原密码输入错误！");
                return false;
            }
            if (text_pwd2.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码！");
                return false;
            }
            if (text_pwd3.Text.Trim() == "")
            {
                MessageBox.Show("请再次输入新密码！");
                return false;
            }
            if (text_pwd2.Text.Trim() != text_pwd3.Text.Trim())
            {
                MessageBox.Show("两次输入新密码不一致！");
                return false;
            }

            return true;
        }

        //数据库更新

        private int Update_pwd()
        {
            DB_helper dbHelper = new DB_helper();
            user.UserPassword = text_pwd2.Text.Trim();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"update userdb set 密码='{0}'where 用户编号='{1}'", user.UserPassword, user.UserId);
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                result=cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
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
