using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sells_system.pages.sales_manage
{
    public partial class factor_add : Form
    {
        public string Fac_name;
        public int result = 0;

        public factor_add()
        {
            InitializeComponent();
        }

        //添加入库

        private void Fac_add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            result = Update_fa();
            if (result > 0)
            {
                MessageBox.Show("成功添加供货商! ");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加供货商失败! ");
            }
        }

        //清空重填

        private void Fac_reset_Click(object sender, EventArgs e)
        {
            text_legel.Text = "";
            text_phone.Text = "";
            text_address.Text = "";
        }

        //返回

        private void Fac_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //显示

        private void Fac_show(object sender, EventArgs e)
        {
            text_name.Text = Fac_name;
        }

        //输入检查

        public bool CheckInput()
        {
            if (text_legel.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入厂商法人代表！ ");
                return false;
            }
            if (text_phone.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入厂商电话！ ");
                return false;
            }
            if (text_address.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入厂商地址！ ");
                return false;
            }

            return true;
        }

        //数据库更新

        private int Update_fa()
        {
            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {
                //1.sql语句
                string sql = string.Format(@"insert into manufacturer(厂商名称,法人代表,电话,厂商地址) values ('{0}','{1}','{2}','{3}')",
                    text_name.Text.Trim(), text_legel.Text.Trim(), text_phone.Text.Trim(), text_address.Text.Trim());
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
