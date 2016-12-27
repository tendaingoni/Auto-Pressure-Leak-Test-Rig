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
    public partial class SavingTestResults : Form
    { int progress = 0;
        public SavingTestResults()
        {
            InitializeComponent();
            
        }
        private void SavingTestResults_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Interval = 50;
           
            /*Hide();
            MainTestMode ss = new MainTestMode();
            ss.Show();*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                timer2.Enabled = false;
                timer2.Stop();
                Hide();
                MainTestMode ss = new MainTestMode();
                ss.Show();
            }
            progressBar1.Value = progress;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }
                    
    }
}
