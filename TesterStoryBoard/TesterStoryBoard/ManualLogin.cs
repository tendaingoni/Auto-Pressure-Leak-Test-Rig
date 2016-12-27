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
    public partial class ManualLogin : Form
    {
        public ManualLogin()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
            
        {
           this.Hide();
           SelfTest ss = new SelfTest();
           ss.Show();

        }

        private void ToMainTestbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainTestMode ss = new MainTestMode();
            ss.Show();
        }

        private void Exitbutton2_Click(object sender, EventArgs e)
        {
            Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
