using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system
{
    public partial class registration_and_login : Form
    {

        public User user=new User();

        public registration_and_login()
        {
            InitializeComponent();
        }

        //登录

        private void Login_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
            {
                return;
            }
            
            if(Login())
            {
                this.Hide();
                main_form mf = new main_form();
                mf.user = this.user;
                mf.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("账户名或密码输入错误，请重试！");
            }
        
        }

        //非空验证

        private bool CheckInput()
        {
            if(txtName.Text.Trim()=="" )
            {
                MessageBox.Show("请输入用户名！");
                return false;
            }

            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                return false;
            }
            return true;
        }

        //登录

        public bool Login()
        {
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [userdb] where 用户名='{0}' and 密码='{1}'", name, pwd);
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if(reader.Read())
                {
                    user.UserId = Convert.ToInt32(reader[0]);
                    user.UserName = reader["用户名"].ToString();
                    user.UserPassword = reader["密码"].ToString();
                    return true;
                }

            }
            catch(Exception ex)
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
