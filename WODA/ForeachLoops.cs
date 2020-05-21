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
    public partial class ForeachLoops : Form
    {
        public ForeachLoops()
        {
            InitializeComponent();
        }

        private void loopOverControlsButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.BackColor = Color.Red;

                if (c is TextBox) return;
            }
        }

        private void loopOverFormsButton_Click(object sender, EventArgs e)
        {
            WODAApplicationForm waf = new WODAApplicationForm();
            WODAMatchesForm wmf = new WODAMatchesForm();

            waf.Show();
            wmf.Show();

            foreach (Form f in Application.OpenForms)
            {
                f.BackColor = Color.Plum;

                foreach (Control c in f.Controls)
                {
                    c.BackColor = Color.Red;

                    if (c is GroupBox)
                    {
                        foreach (Control d in c.Controls)
                        {
                            d.BackColor = Color.Blue;
                        }
                    }
                }
            }
        }

        private void forLoopbutton_Click(object sender, EventArgs e)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control c = this.Controls[i];
                
                c.BackColor = Color.Green;
                
                if (c is TextBox) return;
            }
        }

        private void openCloseFormsButton_Click(object sender, EventArgs e)
        {
            WODAApplicationForm waf = new WODAApplicationForm();
            WODAMatchesForm wmf = new WODAMatchesForm();

            waf.Show();
            wmf.Show();

            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }
        
        private void validateTextBoxesButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox t in this.Controls.OfType<TextBox>())
            {
                if (t.Text == string.Empty)
                {
                    t.BackColor = Color.Red;
                    return;
                }
                else
                {
                    t.BackColor = Color.White;
                }
            }
            MessageBox.Show("Success");
        }
    }
}
