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
    
    public partial class TestInProgress : Form
    {
        private int progress;

        public TestInProgress()
        {
            InitializeComponent();
        }

        private void SelfTestInProgress_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Fail");
                Hide();
                FaultFindingMode ss = new FaultFindingMode();
                //SavingTestResults ss = new SavingTestResults();
                ss.Show();
               
            }
            progressBar1.Value = progress;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
