using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPasswordExtractor
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnRegisteredNumber_Click(object sender, EventArgs e)
        {
            registeredNumber rn = new registeredNumber();
            rn.ShowDialog();
        }

        private void btnNewNumber_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
