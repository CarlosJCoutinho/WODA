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
    public partial class WODAHotDates : Form
    {
        string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

        public WODAHotDates()
        {
            InitializeComponent();
        }

        private void WODAHotDates_Load(object sender, EventArgs e)
        {
            foreach (string s in hotDates)
            {
                hotDatesList.Items.Add(s);
            }
        }

        private void declareAndPopulateArray()
        {
            string[] hotDates = new string[4];

            hotDates[0] = "Natalie Portman";
            hotDates[1] = "Ryan Gosling";
            hotDates[2] = "Katy Perry";
            hotDates[3] = "Brad Pitt";

        }

        private void declareAndInitialiseArray()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };
        }

        private void populateListBox()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

            hotDatesList.Items.Add(hotDates[0]);
            hotDatesList.Items.Add(hotDates[1]);
            hotDatesList.Items.Add(hotDates[2]);
            hotDatesList.Items.Add(hotDates[3]);

        }

        private void whileLoop()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

            int i = 0;

            while (i <= hotDates.GetUpperBound(0))
            {
                hotDatesList.Items.Add(hotDates[i]);
                i++;
            }
        }

        private void forLoop()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

            for (int i = 0; i <= hotDates.GetUpperBound(0); i++)
            {
                hotDatesList.Items.Add(hotDates[i]);
            }
        }

        private void foreachLoop()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

            Array.Sort(hotDates);
            Array.Reverse(hotDates);

            foreach (string hotDate in hotDates)
            {
                hotDatesList.Items.Add(hotDate);
            }
        }

        private void populateListBoxQuickly()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

            hotDatesList.DataSource = hotDates;
        }

        private void findItemInArray()
        {
            string[] hotDates = new string[4]
            {
                "Natalie Portman","Ryan Gosling","Katy Perry","Brad Pitt"
            };

            int whereIsRyan = Array.IndexOf(hotDates, "Ryan Gosling");

            if (whereIsRyan >= hotDates.GetLowerBound(0))
            {
                hotDates[whereIsRyan] = "Hugh Jackman";
            }

            hotDatesList.DataSource = hotDates;
        }

        private void multiDimensionArrayBasics()
        {
            string[,] hotDates = new string[4,2];

            hotDates[0, 0] = "Natalie Portman";
            hotDates[0, 1] = "Girl";
            hotDates[1, 0] = "Ryan Gosling";
            hotDates[1, 1] = "Boy";
            hotDates[2, 0] = "Katy Perry";
            hotDates[2, 1] = "Girl";
            hotDates[3, 0] = "Brad Pitt";
            hotDates[3, 1] = "Boy";

            hotDatesList.Items.Add(hotDates[0, 0] + " - " + hotDates[0, 1]);
            hotDatesList.Items.Add(hotDates[1, 0] + " - " + hotDates[1, 1]);
            hotDatesList.Items.Add(hotDates[2, 0] + " - " + hotDates[2, 1]);
            hotDatesList.Items.Add(hotDates[3, 0] + " - " + hotDates[3, 1]);
        }

        private void initialiseMultiDimensionArray()
        {
            string[,] hotDates = new string[4, 2]
            {
                {"Natalie Portman", "Girl"},
                {"Ryan Gosling", "Boy"},
                {"Katy Perry", "Girl"},
                {"Brad Pitt", "Boy"}
            };

        }

        private void multiDimensionArrayForEachLoop()
        {
            string[,] hotDates = new string[4, 2]
            {
                {"Natalie Portman", "Girl"},
                {"Ryan Gosling", "Boy"},
                {"Katy Perry", "Girl"},
                {"Brad Pitt", "Boy"}
            };

            foreach (string s in hotDates)
            {
                hotDatesList.Items.Add(s);
            }
        }

        private void multiDimensionArrayForLoop()
        {
            string[,] hotDates = new string[4, 2]
            {
                {"Natalie Portman", "Girl"},
                {"Ryan Gosling", "Boy"},
                {"Katy Perry", "Girl"},
                {"Brad Pitt", "Boy"}
            };

            for (int i = 0; i < hotDates.GetLength(0); i++)
            {
                hotDatesList.Items.Add(hotDates[i, 0] + " - " + hotDates[i, 1]);
            }
        }

        private void multiDimensionArrayNestedForLoop()
        {
            string[,] hotDates = new string[4, 3]
            {
                {"Natalie Portman", "Girl", "Single"},
                {"Ryan Gosling", "Boy", "Single"},
                {"Katy Perry", "Girl", "Dating"},
                {"Brad Pitt", "Boy", "Married"}
            };

            string s;

            for (int i = 0; i < hotDates.GetLength(0); i++)
            {
                s = string.Empty;

                for (int j = 0; j < hotDates.GetLength(1); j++)
                {
                    s += hotDates[i, j] + (j < hotDates.GetUpperBound(1) ? " - " : "");
                }

                //s = s.Substring(0, s.Length - 3);
                hotDatesList.Items.Add(s);
            }
        }

        private void resizeArrayButton_Click(object sender, EventArgs e)
        {
            int currentSize = hotDates.Length;
            int extraElements = 3;

            Array.Resize(ref hotDates, currentSize + extraElements);

            hotDates[currentSize] = "Ryan Reynolds";
            hotDates[currentSize + 1] = "Keira Knightley";
            hotDates[currentSize + 2] = "Emily Blunt";

            Array.Sort(hotDates);

            hotDatesList.Items.Clear();
            hotDatesList.DataSource = hotDates;
        }
    }
}
