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
    public partial class FirstCardSwipeFail : Form
    {
        public FirstCardSwipeFail()
        {
            InitializeComponent();
        }

        private void SwipeCardFailLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ManualLogin ss = new ManualLogin();
            ss.Show();
        }
    }
}
