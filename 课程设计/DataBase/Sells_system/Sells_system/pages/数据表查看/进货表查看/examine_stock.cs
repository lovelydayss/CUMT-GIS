using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{
    public partial class examine_stock : Form
    {
        DataSet ds = new DataSet();

        public examine_stock()
        {
            InitializeComponent();
        }

        //查询

        private void Stock_data_Click(object sender, EventArgs e)
        {
            if(!CheckInput())
            {
                return;
            }
            Update_data();
        }

        //显示全部商品订单

        private void Stock_goods_Click(object sender, EventArgs e)
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [stock] ");
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "stocks");
                this.Dgv_stock.DataSource = this.ds.Tables["stocks"];

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

        public bool CheckInput()
        {
            if (text_fac.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入供货商名称！ ");
                return false;
            }

            return true;
        }
    
        //数据更新

        public void Update_data()
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from[stock] where 生产厂商 = '{0}'"
                                            , text_fac.Text.Trim());
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "stocks");
                this.Dgv_stock.DataSource = this.ds.Tables["stocks"];

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
