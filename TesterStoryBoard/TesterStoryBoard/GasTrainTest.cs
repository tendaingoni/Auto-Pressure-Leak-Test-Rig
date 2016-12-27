using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesterStoryBoard
{
    public partial class GasTrainTest : Form
    {
        public GasTrainTest()
        {
            InitializeComponent();
        }
        private void OutletsclosedcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OutletsclosedcheckBox.Checked == true)
            {
                Fillbutton.Enabled = true;
            }
            if (OutletsclosedcheckBox.Checked == false)
            {
                Fillbutton.Enabled = false;
            }
        }
        private void Fillbutton_Click(object sender, EventArgs e)
        {

            Hide();
            FILL ss = new FILL();
            ss.Show();
        }
        private void Backbutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainTestMode ss = new MainTestMode();
            ss.Show();
        }
        
    }
}
