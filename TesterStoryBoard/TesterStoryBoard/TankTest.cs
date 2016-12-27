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
    public partial class TankTest : Form
    {
        public TankTest()
        {
            InitializeComponent();
        }

        private void TankTest_Load(object sender, EventArgs e)
        {

        }

        private void Backtestbutton_Click(object sender, EventArgs e)
        {
            Hide();
            MainTestMode ss = new MainTestMode();
            ss.Show();
        }

        private void Filltankbutton_Click(object sender, EventArgs e)
        {
            Hide();
            FILL ss = new FILL();
            ss.Show();
        }
    }
}

