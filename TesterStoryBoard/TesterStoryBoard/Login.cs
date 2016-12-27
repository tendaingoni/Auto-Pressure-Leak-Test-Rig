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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FirstCardSwipeFail ss = new FirstCardSwipeFail();
            ss.Show();
        }


        private void SelfTestDuelinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            //MessageBox.Show("Hello Joe Blogs. Click OK");
           SelfTest ss = new SelfTest();
            ss.Show();
        }

        private void MatchedSwipeToMainTestModelinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
           // MessageBox.Show("Hello Joe Blogs. Click OK");
            MainTestMode ss = new MainTestMode();
            ss.Show();
        }
    }
}
