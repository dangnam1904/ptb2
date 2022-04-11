using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ptb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kq_Click(object sender, EventArgs e)
        {
            float b=float.Parse(txt_b.Text);
            float c = float.Parse(txt_c.Text);
            float a = float.Parse(txt_a.Text);
            if (txt_a.Text == "0")
            {
              lb_kq1.Text="Kết quả:   " + giai_ptb1.nghiem_ptb1(b,c);
           
              
            }
            else
            {
                lb_kq1.Text = "Kết quả:" + giai_ptb2.nghiem_ptb2(a, b, c);
            }
        }

        private void btn_resfesh_Click(object sender, EventArgs e)
        {
            txt_a.Text= "0";
            txt_b.Text= "0";
            txt_c.Text= "0";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
