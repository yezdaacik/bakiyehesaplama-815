using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakiye_hesaplama
{
    public partial class Form1 : Form
    {
        double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
          if (bakiye >= 15)
            {
                bakiye -= 15;
                lblBakiye.Text = Convert.ToString(bakiye);
            }

          else if (bakiye >= 12.20)
            {
                bakiye -= 12.20;
                lblBakiye.Text = Convert.ToString(bakiye);
            }

          else if (bakiye >= 9.60)
            {
                bakiye -= 9.60;
                lblBakiye.Text = Convert.ToString(bakiye);
            }

          else if (bakiye >= 8)
            {
                bakiye-= 8;
                lblBakiye.Text= Convert.ToString(bakiye);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = Convert.ToString(bakiye);
        }
    }
}
