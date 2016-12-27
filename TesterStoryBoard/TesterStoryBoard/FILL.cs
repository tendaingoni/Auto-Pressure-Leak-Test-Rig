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
    
    public partial class FILL : Form
    {
        private int progress;

        public FILL()
        {
            InitializeComponent();
        }

        private void FILL_Load(object sender, EventArgs e)
        {
            Filltimer.Enabled = true;
            Filltimer.Interval = 50;
        }

        private void Filltimer_Tick(object sender, EventArgs e)
        {
            progress += 1;
            if (progress >= 100)
            {
                Filltimer.Enabled = false;
                Filltimer.Stop();
                Hide();
                TestInProgress ss = new TestInProgress();
                ss.Show();
            }
            FillprogressBar.Value = progress;
        }

        private void FillprogressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
