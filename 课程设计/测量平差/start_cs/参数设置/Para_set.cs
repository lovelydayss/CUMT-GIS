using System;
using System.Windows.Forms;

namespace start_cs
{

    public partial class Para_set : Form
    {
        public Parameter parament;
        public Para_set()
        {
            InitializeComponent();
        }

        private void buttun_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttun_change_Click(object sender, EventArgs e)
        {
            parament.level = TB_network_level.Text.Trim();
            parament.type = TB_network_type.Text.Trim();
            parament.weight = TB_weight.Text.Trim();
            parament.main_error = double.Parse(TB_mean_errors.Text.Trim());
            parament.tolerance = double.Parse(TB_tolerance.Text.Trim());
            parament.precision = int.Parse(TB_precision.Text.Trim());

            this.Close();
        }

        private void Para_set_Load(object sender, EventArgs e)
        {
            TB_network_level.Text = parament.level;
            TB_network_type.Text = parament.type;
            TB_weight.Text = parament.weight;
            TB_mean_errors.Text = parament.main_error.ToString();
            TB_tolerance.Text = parament.main_error.ToString();
            TB_precision.Text = parament.precision.ToString();

        }
    }
}
