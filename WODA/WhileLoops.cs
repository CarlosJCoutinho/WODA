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
    public partial class WhileLoops : Form
    {
        public WhileLoops()
        {
            InitializeComponent();
        }

        private void WhileLoopsButton_Click(object sender, EventArgs e)
        {
            int i = 0;

            while (i < 0)
            {
                if (i == 2)
                {
                    i++;
                    continue;
                }

                MessageBox.Show("i = " + i.ToString());
                i++;
            }
            
        }
    }
}
