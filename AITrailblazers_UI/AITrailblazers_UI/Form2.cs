using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITrailblazers_UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form2Text_TextChanged(object sender, EventArgs e)
        {
            form2Text.Text = "Console Output : User has other loans and unable to service new loan. PAN mismatch on Bank and Income statement. ";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
