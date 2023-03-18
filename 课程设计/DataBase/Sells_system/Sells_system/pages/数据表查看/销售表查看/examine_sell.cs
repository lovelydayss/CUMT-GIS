using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sells_system.pages
{

    public partial class examine_sell : Form
    {
        DataSet ds = new DataSet();

        public examine_sell()
        {
            InitializeComponent();
        }

        //查询

        private void Sells_data_Click(object sender, EventArgs e)
        {

            if(!CheckInput())
            {
                return;
            }

            Update_data();
        }


        //显示全部销售订单

        private void All_goods_Click(object sender, EventArgs e)
        {
            DB_helper dbHelper = new DB_helper();
            ds = new DataSet();

            try
            {
                //1.sql语句
                string sql = string.Format("select * from [sell] ");
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "sell");
                this.Dgv_sell.DataSource = this.ds.Tables["sell"];

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
            if (text_name.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入商品名称！ ");
                return false;
            }

            if (text_name.Text.Trim() == "")
            {
                MessageBox.Show(" 请输入商品类型！ ");
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
                string sql = string.Format("select * from [sell] where 商品名='{0}' and 型号='{1}'"
                                            , text_name.Text.Trim(), text_type.Text.Trim());
                //2.DataAdapter工具
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //3.打开连接
                dbHelper.OpenConnection();
                //4.执行
                adapter.Fill(ds, "sell");
                this.Dgv_sell.DataSource = this.ds.Tables["sell"];

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
