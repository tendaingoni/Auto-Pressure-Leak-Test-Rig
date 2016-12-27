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
    public partial class WeirTest : Form
    {
        public WeirTest()
        {
            InitializeComponent();
        }

        private void WeirTest_Load(object sender, EventArgs e)
        {

        }

        private void Fillweirbutton_Click(object sender, EventArgs e)
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
/*private void Backbutton_Click(object sender, EventArgs e)
{
    Hide();
    MainTestMode ss = new MainTestMode();
    ss.Show();
}

private void Fillbutton_Click(object sender, EventArgs e)
{
    Hide();
    FILL ss = new FILL();
    ss.Show();
}
    }
}*/