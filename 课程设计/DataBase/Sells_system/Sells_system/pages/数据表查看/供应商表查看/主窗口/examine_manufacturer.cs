using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class examine_manufacturer : Form
    {
        DataSet ds = new DataSet();
        public Manufacturer manufacturer=new Manufacturer();

        public examine_manufacturer()
        {
            InitializeComponent();
        }

        //删除

        private void Data_remove_Click(object sender, EventArgs e)
        {
            if (!Check_input())
            {
                return;
            }
            if(Check_key())
            {
                MessageBox.Show("存在与该厂商相关联订单信息，禁止删除！ ");
                return;
            }


            DB_helper dbHelper = new DB_helper();
            int result = 0;

            try
            {

                //1.sql语句
                string sql = string.Format(@"delete from [manufacturer] where 厂商名称='{0}'", text_fac.Text.Trim());
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

            if (result > 0)
            {
                MessageBox.Show("成功删除该厂商数据！ ");
            }
            else
            {
                MessageBox.Show("删除失败，请重试！ ");
            }
        }

        //修改

        private void Data_change_Click(object sender, EventArgs e)
        {
            if(!Check_input())
            {
                return;
            }

            fac_changes fc = new fac_changes();
            fc.manufacturer = this.manufacturer;
            fc.Show();
        }

        //添加新供货商

        private void Data_add_Click(object sender, EventArgs e)
        {
            fac_adds fa = new fac_adds();
            fa.Show();
        }

        //数据加载

        private void Data_loading_Click(object sender, EventArgs e)
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [manufacturer] ");
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "manufacturer");
                this.Dgv_fac.DataSource = this.ds.Tables["manufacturer"];

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

        //输入检查

        private bool Check_input()
        {
            if (text_fac.Text.Trim() == "")
            {
                MessageBox.Show("供货商名称不能为空!");
                return false;
            }

            DB_helper dbHelper = new DB_helper();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [manufacturer] where 厂商名称='{0}'", text_fac.Text.Trim());
                //2.command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                SqlDataReader reader = cmd.ExecuteReader();
                //5.判断
                if (reader.Read())
                {
                    manufacturer.ManufacturerName = reader["厂商名称"].ToString();
                    manufacturer.ManufacturerLegel = reader["法人代表"].ToString();
                    manufacturer.ManufacturerPhone = reader["电话"].ToString();
                    manufacturer.ManufacturerAdress = reader["厂商地址"].ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show("供货商名称无效，请重试!");
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
                string sql = string.Format(@"select * from sell,stock,retreat where sell.生产厂商='{0}' or retreat.生产厂商= '{0}' or stock.生产厂商 = '{0}'", text_fac.Text.Trim());
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
