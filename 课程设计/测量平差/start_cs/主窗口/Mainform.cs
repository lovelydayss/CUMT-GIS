using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace start_cs
{
    public partial class Mainform : Form
    {
        public CSlevelingAdjust cLeveling = new CSlevelingAdjust();
        bool input = false;                                     //判断是否有数据输入


        public Mainform()
        {
            InitializeComponent();
        }

        private void Parameter_set_Click(object sender, EventArgs e)
        {
            Para_set para = new Para_set();
            para.parament = cLeveling.parameter;
            para.ShowDialog();
            cLeveling.parameter = para.parament;
        }

        private void Data_import_Click(object sender, EventArgs e)
        {
            Text_adjust_data.Clear();
            Parameter par = cLeveling.parameter;
            cLeveling = new CSlevelingAdjust();
            cLeveling.parameter = par;
            cLeveling.mainform = this;

            OpenFileDialog filename = new OpenFileDialog();
            filename.Filter = "文本文件（*.txt）|*.txt";

            if(filename.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(filename.FileName, Encoding.UTF8);


                while(!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    if (Regex.IsMatch(str, @"^(\d{1,}\s){2}\d{1,}"))                      //匹配首行
                    {
                        MatchCollection matchs = Regex.Matches(str, @"\d");     //匹配单个数值

                        Text_adjust_data.AppendText("读入水准网数据：\r\n");
                        Text_adjust_data.AppendText(string.Format("\r\n  已知点 {0} 个,未知点 {1} 个,观测值 {2} 个\r\n", matchs[0], matchs[1], matchs[2]));
                        
                        //已知点数 总点数 总观测数
                        cLeveling.know_Pnumber = int.Parse(matchs[0].ToString());
                        cLeveling.total_Pnumber = int.Parse(matchs[0].ToString()) + int.Parse(matchs[1].ToString());
                        cLeveling.total_Lnumber = int.Parse(matchs[2].ToString());

                    }
                    else if(Regex.IsMatch(str, @"^([A-Za-z]\S{0,}\s){3,}"))                 //匹配点号
                    {
                        MatchCollection matchs = Regex.Matches(str, @"[A-Za-z]\S{0,}");     //匹配单个点号

                        Text_adjust_data.AppendText("\r\n  水准网中涉及点名有： ");
                        for(int i=0;i<matchs.Count;i++)
                        {
                            Text_adjust_data.AppendText(string.Format(" {0} ",matchs[i].ToString()));
                            cLeveling.Pname.Add(matchs[i].ToString());
                        }
                        Text_adjust_data.AppendText("\r\n\r\n  已知点高程为： ");

                    }
                    else if(Regex.IsMatch(str, @"^(\d{1,}[.]\d{3,}){1,}"))       //匹配已知点高程行
                    {
                        MatchCollection matchs = Regex.Matches(str, @"\d{1,}[.]\d{3}");     //匹配单个已知点高程
                        if(matchs.Count!=cLeveling.know_Pnumber)
                        {
                            MessageBox.Show("已知点高程数目有误，请重试");
                        }
                        else
                        {
                            for (int i = 0; i < matchs.Count; i++) 
                            {
                                Text_adjust_data.AppendText(string.Format("\r\n  已知点 {0} 的高程为：{1}", cLeveling.Pname[i], matchs[i]));
                                cLeveling.Height.Add(matchs[i].ToString());
                            }
                            Text_adjust_data.AppendText("\r\n\r\n    各观测值分别为： ");
                            Text_adjust_data.AppendText("\r\n  起点   终点   高差观测值  距离观测值   \r\n");
                        }
                    }
                    else if(Regex.IsMatch(str, @"^([A-Za-z]\S{0,}\s){2}[-]{0,1}\d{1,}[.]\d{3,}\s\d{1,}[.]\d{1,}"))        //匹配观测高差
                    {

                        MatchCollection matchs = Regex.Matches(str, @"[A-Za-z]\S{0,}");
                        
                        for(int i=0;i<matchs.Count;i++)
                        {
                            Text_adjust_data.AppendText(string.Format(@"    {0}  ", matchs[i]));
                        }

                        cLeveling.StartP.Add(cLeveling.Num_of_Point_Name(matchs[0].ToString(), cLeveling.Pname));
                        cLeveling.EndP.Add(cLeveling.Num_of_Point_Name(matchs[1].ToString(), cLeveling.Pname));

                        matchs = Regex.Matches(str, @"[-]{0,1}\d{1,}[.]\d{1,}");

                        for (int i = 0; i < matchs.Count; i++)
                        {
                            Text_adjust_data.AppendText(string.Format(@"    {0}   ", matchs[i]));
                        }

                        cLeveling.L.Add(matchs[0].ToString());
                        cLeveling.P.Add(1.0 / double.Parse(matchs[1].ToString().ToString()));

                        Text_adjust_data.AppendText(Environment.NewLine);
                    }

                }

                input = true;
            }
            else
            {
                MessageBox.Show("文件调用程序打开失败，请重试！");
            }


            /*****文件输入测试******

            for(int i=0;i<cLeveling.Pname.Count;i++)
            {
                Text_adjust_data.AppendText(string.Format(" {0} ",cLeveling.Pname[i].ToString()));
            }

            Text_adjust_data.AppendText(Environment.NewLine);

            for(int i=0;i<cLeveling.L.Count;i++)
            {
                Text_adjust_data.AppendText(string.Format(" {0} ", cLeveling.L[i].ToString()));
            }

            Text_adjust_data.AppendText(Environment.NewLine);

            for (int i = 0; i < cLeveling.Height.Count; i++)
            {
                Text_adjust_data.AppendText(string.Format(" {0} ", cLeveling.Height[i].ToString()));
            }

            Text_adjust_data.AppendText(Environment.NewLine);

            for (int i = 0; i < cLeveling.StartP.Count; i++)
            {
                Text_adjust_data.AppendText(string.Format(" {0} ", cLeveling.StartP[i].ToString()));
            }

            Text_adjust_data.AppendText(Environment.NewLine);

            for (int i = 0; i < cLeveling.StartP.Count; i++)
            {
                Text_adjust_data.AppendText(string.Format(" {0} ", cLeveling.EndP[i].ToString()));
            }

            Text_adjust_data.AppendText(Environment.NewLine);

            for (int i = 0; i < cLeveling.P.Count; i++)
            {
                Text_adjust_data.AppendText(string.Format(" {0} ", cLeveling.P[i].ToString()));
            }

            Text_adjust_data.AppendText(Environment.NewLine);

            Text_adjust_data.AppendText(cLeveling.total_Pnumber.ToString());
            Text_adjust_data.AppendText(cLeveling.total_Lnumber.ToString());
            Text_adjust_data.AppendText(cLeveling.know_Pnumber.ToString());

            Text_adjust_data.AppendText(Environment.NewLine);

            for (int i=0; i<cLeveling.EndP.Count;i++ )
            {

                Text_adjust_data.AppendText(cLeveling.Pname[int.Parse(cLeveling.StartP[i].ToString())].ToString());
                Text_adjust_data.AppendText(cLeveling.Pname[int.Parse(cLeveling.EndP[i].ToString())].ToString());
                Text_adjust_data.AppendText(Environment.NewLine);
            }

            ***************/
        }

        private void Adjust_computation_Click(object sender, EventArgs e)
        {
            if(input)
            {
                Text_adjust_result.Clear();
                cLeveling.LS_Adjustment();
                input = false;
            }
            else
            {
                MessageBox.Show("请输入数据！！");
            }

           
        }

        private void File_save_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            filename.Filter = "文本文件（*.txt）|*.txt";

            if (filename.ShowDialog() == DialogResult.OK) 
            {
                StreamWriter sw = new StreamWriter(filename.FileName);
                sw.Write(Text_adjust_data.Text.ToString());
                sw.Write(Environment.NewLine);
                sw.Write(Text_adjust_result.Text.ToString());

                sw.Write("\r\n相关参数：\r\n");
                sw.Write(string.Format("    控制网等级：{0}\r\n", cLeveling.parameter.level));
                sw.Write(string.Format("    控制网类型：{0}\r\n", cLeveling.parameter.type));
                sw.Write(string.Format("    定权方式：{0}\r\n", cLeveling.parameter.weight));
                sw.Write(string.Format("    限差：{0}\r\n", cLeveling.parameter.tolerance.ToString()));
                sw.Write(string.Format("    先验中误差：{0}\r\n", cLeveling.parameter.main_error.ToString()));
                sw.Write(string.Format("    数据精度：{0}\r\n", cLeveling.parameter.precision.ToString()));
                sw.Flush();

                MessageBox.Show("平差结果保存成功！！");
            }
            else
            {
                MessageBox.Show("文件调用程序打开失败，请重试！");
            }
        }
    }
}
