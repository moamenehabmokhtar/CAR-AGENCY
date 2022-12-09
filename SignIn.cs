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
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignInBT_Click(object sender, EventArgs e)
        {
            CarBrand carBrand = new CarBrand(); 
            carBrand.Show();    
        }
    }
}
