using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class fac_adds : Form
    {
        public fac_adds()
        {
            InitializeComponent();
        }

        //添加

        private void Ea_add_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            if (Update_fa() > 0)
            {
                MessageBox.Show("成功添加供货商！");
                this.Close();
            }
            else
            {
                MessageBox.Show("供货商添加失败,请重试！");
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
                MessageBox.Show(" 请输入供货商名称！ ");
                return false;
            }
            if (text_legel.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入法人代表！ ");
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
                string sql = string.Format(@"insert into manufacturer(厂商名称,法人代表,电话,厂商地址) values ('{0}','{1}','{2}','{3}')"
                                             , text_name.Text.Trim(), text_legel.Text.Trim(), text_phone.Text.Trim(), text_address.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                result=cmd.ExecuteNonQuery();

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
