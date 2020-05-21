using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WODA
{
    public partial class Exceptions : Form
    {
        public Exceptions()
        {
            InitializeComponent();
        }

        private void showMatches_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\WODAClient.txt");
            }
            catch
            {
                MessageBox.Show("File not found");
                return;
            }
            string s = sr.ReadLine();
            while(!sr.EndOfStream)
            {
                s = sr.ReadLine();
                matchesList.Items.Add(s);
            }
            sr.Dispose();
        }
    }
}
