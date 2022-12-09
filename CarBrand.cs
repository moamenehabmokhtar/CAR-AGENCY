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
    public partial class CarBrand : UserControl
    {
        public CarBrand()
        {
            InitializeComponent();
        }

        private void MiniBT_Click(object sender, EventArgs e)
        {
            Mini mini = new Mini();
            mini.Show();
        }

        private void BMWBT_Click(object sender, EventArgs e)
        {
            BMW bMW = new BMW();
            bMW.Show();

        }

        private void PeugotBT_Click(object sender, EventArgs e)
        {
            Peugot peugot = new Peugot();
            peugot.Show();
        }
    }
}
