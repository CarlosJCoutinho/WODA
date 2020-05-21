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
    public partial class WODAMatchesForm : Form
    {
        public WODAMatchesForm()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeSelectedDatesButton_Click(object sender, EventArgs e)
        {
            for (int i = YourMatchesList.SelectedIndices.Count - 1; i >= 0; i--)
            {
                YourMatchesList.Items.RemoveAt(YourMatchesList.SelectedIndices[i]);
            }

            string remainingDates = string.Empty;

            //for (int i = 0; i < YourMatchesList.Items.Count; i++)
            //{
            //    remainingDates += YourMatchesList.Items[i].ToString() + "\n";
            //}

            foreach (string s in YourMatchesList.Items)
            {
                remainingDates += s + "\n";
            }

            MessageBox.Show("Your remaining dates are\n" + remainingDates);
        }
    }
}
