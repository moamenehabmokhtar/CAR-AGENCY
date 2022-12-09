using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class BMW : Form
    {
        public BMW()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The BMW X7 is a full-sized luxury sport utility vehicle manufactured by BMW. It is BMW's largest and most expensive SUV in its line-up.The X7 was first announced by BMW in March 2014. It was officially unveiled on October 17, 2018, with pre-orders being taken online. The X7 has been available at dealers since March 2019.", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
