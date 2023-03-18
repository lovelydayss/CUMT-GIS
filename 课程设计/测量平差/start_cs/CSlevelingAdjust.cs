using System;
using System.Collections;
using System.Windows.Forms;

namespace start_cs
{
    public class Parameter             //参数模块
    {
        public string level = "四等";                     //网等级,默认为四等
        public string type="高程";                        //网类别，默认为高程
        public string weight = "距离";                    //定权方法，默认为距离 
        public double tolerance=0.1;                    //限差，默认为 0.1
        public double main_error=0.001;                 //先验中误差的绝对值，默认为0.001
        public int precision = 6;                       //平差结果精度,默认保留6位小数
            
    }

    public class CSlevelingAdjust       //平差模块
    {
        public Parameter parameter;                    //参数控制块

        public Mainform mainform;
        public int know_Pnumber;                //已知点数
        public int total_Pnumber;               //总点数
        public int total_Lnumber;               //高差总数

        public double pvv;                              //[pvv]
        public double m_mu;                             //验后单位权中误差

        public ArrayList StartP = new ArrayList();
        //public int[] StartP;                           //高差起始点号

        public ArrayList EndP = new ArrayList();
        //public int[] EndP;                             //高差终止点号

        public ArrayList Pname = new ArrayList();
        //public string[] Pname;                         //点名数组

        public ArrayList P = new ArrayList();
        //public double[] P;                             //观测值的权

        public ArrayList Height = new ArrayList();
        //public double[] Height;                        //高程值数组

        public ArrayList L = new ArrayList();
        //public double[] L;                             //观测值数组

        public ArrayList ATPA = new ArrayList();
        //public double[] ATPA;                          //法方程系数矩阵

        public ArrayList ATPL = new ArrayList();
        //public double[] ATPL;                          //法方程自由项

        public ArrayList dX = new ArrayList();
        //public double[] dX;                            //残差平差值

        public ArrayList V = new ArrayList();
        //public double[] V                              //残差数组

        
        public int Num_of_Point_Name(string str,ArrayList array)
        {
            for(int i=0;i<array.Count;i++)
            {
                if(str==array[i].ToString())
                {
                    return i;
                }
            }
            MessageBox.Show("未找到目标点，请重试！！");
            return 0;
        }

        public CSlevelingAdjust()
        {
            know_Pnumber = 0;
            total_Pnumber = 0;
            total_Lnumber = 0;

            parameter = new Parameter();
        }

        //对称矩阵下标计算
        private int ij(int i, int j)
        {
            return (i >= j) ? i * (i + 1) / 2 + j : j * (j + 1) / 2 + i;
        }

        //对称正定矩阵求逆
        public bool Inverse(ArrayList a, int n)
        {
            ArrayList a0 = new ArrayList();
            for (int i = 0; i < n; i++) 
            {
                a0.Add(0);
            }

            for (int k = 0; k < n; k++)
            {
                double a00 = double.Parse(a[0].ToString());
                if (a00 + 1.0 == 1.0)
                {
                    return false;
                }
                for (int i = 1; i < n; i++)
                {
                    double ai0 = double.Parse(a[i * (i + 1) / 2].ToString());

                    if (i <= n - k - 1)
                    {
                        a0[i]=-ai0 / a00;
                    }
                    else
                    {
                        a0[i] = ai0 / a00;
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        a[(i - 1) * i / 2 + j - 1] = double.Parse(a[i * (i + 1) / 2 + j].ToString()) + ai0 * double.Parse(a0[j].ToString());
                    }
                }
                for (int i = 1; i < n; i++)
                {
                    a[(n - 1) * n / 2 + i - 1] = double.Parse(a0[i].ToString());
                }
                a[n * (n + 1) / 2 - 1] = 1.0 / a00;
            }
            return true;
        }

        //近似高程值计算
        void Ca_H0()
        {
            for (int i = know_Pnumber; i < total_Pnumber; i++)
            {
                Height.Add(-9999.9);
            }

            int jj = 0;
            for (int ii = 1; ; ii++)
            {
                for (int i = 0; i < total_Lnumber; i++)
                {
                    int k1 = int.Parse(StartP[i].ToString());
                    int k2 = int.Parse(EndP[i].ToString());

                    if (double.Parse(Height[k1].ToString()) > -9999.0 && double.Parse(Height[k2].ToString()) < -9999.0)
                    {
                        Height[k2] = double.Parse(Height[k1].ToString()) + double.Parse(L[i].ToString());
                        jj++;
                    }
                    else if (double.Parse(Height[k1].ToString()) < -9999.0 && double.Parse(Height[k2].ToString()) > -9999.0)
                    {
                        Height[k1] = double.Parse(Height[k2].ToString()) - double.Parse(L[i].ToString());
                        jj++;
                    }
                }

                if (jj == (total_Pnumber - know_Pnumber))
                {
                    break;
                }

                if (ii > (total_Pnumber - know_Pnumber))
                {
                    mainform.Text_adjust_data.AppendText("\r\n\r\n下列点无法计算出概略高程:\r\n");

                    for (int i = 0; i < total_Pnumber; i++)
                    {
                        if (double.Parse(Height[i].ToString()) < -9999.0)
                        {
                            mainform.Text_adjust_data.AppendText(string.Format("  {0} ", Pname[i]));
                        }
                    }
                    MessageBox.Show("近似高程计算失败!!");
                }
            }
        }

        //构建法方程
        void Ca_ATPA()
        {
            int t = total_Pnumber;

            for (int i = 0; i < t * (t + 1) / 2; i++)
            {
                ATPA.Add(0.0);
            }
            for (int i = 0; i < t; i++)
            {
                ATPL.Add(0.0);
            }

            for (int k = 0; k < total_Lnumber; k++)
            {
                int i = int.Parse(StartP[k].ToString());
                int j = int.Parse(EndP[k].ToString());

                double Pk = double.Parse(P[k].ToString());
                double Lk = double.Parse(L[k].ToString()) - (double.Parse(Height[j].ToString()) - double.Parse(Height[i].ToString()));

                ATPL[i] = double.Parse(ATPL[i].ToString()) - Pk * Lk;
                ATPL[j] = double.Parse(ATPL[j].ToString()) + Pk * Lk;
                ATPA[ij(i, i)] = double.Parse(ATPA[ij(i, i)].ToString()) + Pk;
                ATPA[ij(j, j)] = double.Parse(ATPA[ij(j, j)].ToString()) + Pk;
                ATPA[ij(i, j)] = double.Parse(ATPA[ij(i, j)].ToString()) - Pk;

            }
        }

        //计算高程平差值
        void Ca_dX()
        {
            if (!Inverse(ATPA, total_Pnumber))
            {
                MessageBox.Show("法方程系数矩阵降秩！！");
                //法方程系数矩阵降秩
                //.......
            }

            for (int i = 0; i < total_Pnumber; i++)
            {
                double xi = 0.0;
                for (int j = 0; j < total_Pnumber; j++)
                {
                    xi += double.Parse(ATPA[ij(i, j)].ToString()) * double.Parse(ATPL[j].ToString());
                }
                dX.Add(xi);
                Height[i] = double.Parse(Height[i].ToString()) + xi;

            }
        }

        //计算残差
        void Ca_V()
        {

            for (int i = 0; i <= total_Lnumber - 1; i++)
            {
                int k1 = int.Parse(StartP[i].ToString());
                int k2 = int.Parse(EndP[i].ToString());

                V.Add(double.Parse(Height[k2].ToString()) - double.Parse(Height[k1].ToString()) - double.Parse(L[i].ToString()));
                pvv += double.Parse(V[i].ToString()) * double.Parse(V[i].ToString()) * double.Parse(P[i].ToString());
            }
        }

        //平差值输出
        public void Print()
        {

            mainform.Text_adjust_result.AppendText("\r\n       //***  高程平差值及其精度 ***// \r\n");
            mainform.Text_adjust_result.AppendText("\r\n   点名  近似高程  改正数  高程平差值  中误差 \r\n");
            
            for(int i=0;i<total_Pnumber;i++)
            {
                mainform.Text_adjust_result.AppendText(string.Format("    {0}",Pname[i].ToString()));
                
                double dx = double.Parse(dX[i].ToString());
                double qii = double.Parse(ATPA[ij(i, i)].ToString());

                mainform.Text_adjust_result.AppendText(string.Format("   {0}   {1}   {2}   {3}\r\n",
                    Math.Round(double.Parse(Height[i].ToString())-dx,parameter.precision),
                    Math.Round(dx, parameter.precision),
                    Math.Round(double.Parse(Height[i].ToString()), parameter.precision),
                    Math.Round(System.Math.Sqrt(qii)*m_mu, parameter.precision)));

            }

            mainform.Text_adjust_result.AppendText("\r\n       //***  观测值平差值及其精度 ***// \r\n");
            mainform.Text_adjust_result.AppendText("\r\n No. 起点 终点 观测高差   v  高差平差值  观测权 中误差 \r\n");

            for(int i=0;i<total_Lnumber;i++)
            {
                int k1 = int.Parse(StartP[i].ToString());
                int k2 = int.Parse(EndP[i].ToString());
                double qii = double.Parse(ATPA[ij(k1, k1)].ToString());
                double qjj = double.Parse(ATPA[ij(k2, k2)].ToString());
                double qij = double.Parse(ATPA[ij(k1, k2)].ToString());
                double ml = System.Math.Sqrt(qii + qjj - 2.0 * qij) * m_mu;

                mainform.Text_adjust_result.AppendText(string.Format("  {0}    {1}   {2}   {3}  {4}   {5}   {6}   {7} \r\n",
                   i + 1, 
                   Pname[k1].ToString(), 
                   Pname[k2].ToString(), 
                   Math.Round(double.Parse(L[i].ToString()), parameter.precision), 
                   Math.Round(double.Parse(V[i].ToString()), parameter.precision),
                   Math.Round(double.Parse((double.Parse(L[i].ToString()) + double.Parse(V[i].ToString())).ToString()), parameter.precision),
                   Math.Round(double.Parse(P[i].ToString()), parameter.precision), 
                   Math.Round(ml, parameter.precision)));
            }
        }
    
        //最小二乘平差
        public void LS_Adjustment()
        {
            Ca_H0();                //近似高程计算
            Ca_ATPA();              //组成法方程

            //处理已知点
            for(int i=0;i<know_Pnumber;i++)
            {
                ATPA[ij(i, i)] = 1.0e30;
            }

            Ca_dX();
            Ca_V();

            m_mu = System.Math.Sqrt(pvv / (total_Lnumber - (total_Pnumber - know_Pnumber)));

            mainform.Text_adjust_result.AppendText(string.Format(" 最小二乘平差结果：\r\n\r\n   [pvv]= {0} \r\n", Math.Round(pvv, parameter.precision)));
            mainform.Text_adjust_result.AppendText(string.Format("   |u|=  {0}  \r\n", Math.Round(m_mu, parameter.precision)));

            Print();

        }
    }
}
