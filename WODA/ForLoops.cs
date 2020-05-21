using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WODA
{
    public partial class ForLoops : Form
    {
        public ForLoops()
        {
            InitializeComponent();
        }

        private void forLoopsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 3; i <= j; i++, j--)
            {
                MessageBox.Show("i = " + i.ToString() + "\nj = " + j.ToString());
            }
        }
    }
}
