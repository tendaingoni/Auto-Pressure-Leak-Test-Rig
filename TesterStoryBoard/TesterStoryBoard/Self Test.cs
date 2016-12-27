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
    public partial class SelfTest : Form
    {
        public SelfTest()
        {
            InitializeComponent();
        }

        private void Instructions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelfTest_Load(object sender, EventArgs e)
        {

        }

        private void FillButtonSelfTestbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MessageBox.Show("This wont take long. Click OK");
           SelfCheckFillTimeCheck ss = new SelfCheckFillTimeCheck();    // taking too long to fill indicates blanks or serious leak
            ss.Show();
        }
    }
}
