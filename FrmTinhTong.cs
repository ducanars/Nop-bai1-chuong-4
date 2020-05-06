using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1
{
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        private void txtnhapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
(e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void txtnhapb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
(e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void btlTinhTong_Click(object sender, EventArgs e)
        {
            int tong=0;
            int a = Convert.ToInt32(txtnhapa.Text);
            int b = Convert.ToInt32(txtnhapb.Text);
            if (a > b)
                for (int i = b ; i <= a; i++)
                    tong = i + tong;
            if (a < b)
                for (int i = a; i <= b; i++)
                    tong = i + tong;

            lbTong.Text = tong.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnhapa.ResetText();
            txtnhapb.ResetText();
            lbTong.ResetText();
        }
    }
}
