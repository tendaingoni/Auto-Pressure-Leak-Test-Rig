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
    public partial class MainTestMode : Form
    {
        public MainTestMode()
        {
            InitializeComponent();
        }

        private void MainTestMode_Load(object sender, EventArgs e)
        {
            SelectTestradioButton1.Checked = true;
        }

        private void SelectTestradioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SelfTestradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (SelfTestradioButton2.Checked == true)
            {
                MessageBox.Show("Are you sure you want to test the Machine? !! ");
                Hide();
                SelfTest ss = new SelfTest();
                ss.Show();
            }
        }

        private void WeirtestradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to test the Weir? !! ");
            Hide();
            WeirTest ss = new WeirTest();
            ss.Show();
        }
        private void TanktestradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to test the Tank? !! ");
            Hide();
            WeirTest ss = new WeirTest();
            ss.Show();
        }
        private void GastraintestradioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to test the Gas train? !! ");
            Hide();
            WeirTest ss = new WeirTest();
            ss.Show();
        }

        private void AlipidotestradioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (AlipidotestradioButton3.Checked == true)
            {
                MessageBox.Show("Sorry This is not in use");
                return;

            }
            
            }

        private void FullMachineTestradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FullMachineTestradioButton.Checked == true)
            {
                MessageBox.Show("Sorry This is not in use");
                return;

            }
        }
    }

}
