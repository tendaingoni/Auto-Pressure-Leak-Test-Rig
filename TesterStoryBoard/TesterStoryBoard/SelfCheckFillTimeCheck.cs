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
    public partial class SelfCheckFillTimeCheck : Form
    {
        public SelfCheckFillTimeCheck()
        {
            InitializeComponent();
        }

        private void LeakWarninglabel1_Click(object sender, EventArgs e)
        {

        }

        private void LeakCheckOKbutton1_Click(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("This will take 10minutes. Click OK");
            TestInProgress ss = new TestInProgress();
            ss.Show();
        }
    }
}
