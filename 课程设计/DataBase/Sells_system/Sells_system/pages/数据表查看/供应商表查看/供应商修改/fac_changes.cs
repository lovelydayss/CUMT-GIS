using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class fac_changes : Form
    {
        public Manufacturer manufacturer=new Manufacturer();

        public fac_changes()
        {
            InitializeComponent();
        }

        //修改

        private void Ea_change_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            if (Update_ea() > 0)
            {
                MessageBox.Show("修改供货商信息成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("供货商信息修改失败,请重试");
            }
        }

        //返回

        private void Ea_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //显示

        private void Data_show(object sender, EventArgs e)
        {
            text_legel.Text = manufacturer.ManufacturerName;
            text_phone.Text = manufacturer.ManufacturerPhone;
            text_address.Text = manufacturer.ManufacturerAdress;
            text_name.Text = manufacturer.ManufacturerName;
        }

        //输入检查

        public bool CheckInput()
        {
            if (text_legel.Text.Trim() == "")
            {
                MessageBox.Show(" 法人代表不能为空！ ");
                return false;
            }
            if (text_phone.Text.Trim() == "")
            {
                MessageBox.Show(" 供货商电话不能为空！ ");
                return false;
            }
            if (text_address.Text.Trim() == "")
            {
                MessageBox.Show(" 供货商地址不能为空！ ");
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
                string sql = string.Format(@"update [manufacturer] set 法人代表='{0}',电话='{1}',厂商地址='{2}'where 厂商名称='{3}'"
                                             , text_legel.Text.Trim(), text_phone.Text.Trim(), text_address.Text.Trim(), manufacturer.ManufacturerName);
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
