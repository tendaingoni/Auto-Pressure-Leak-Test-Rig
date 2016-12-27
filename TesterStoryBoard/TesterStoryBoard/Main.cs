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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void OffButton_Click(object sender, EventArgs e)
        {

        }
    }
}
