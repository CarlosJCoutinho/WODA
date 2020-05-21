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
    public partial class WODAQualities : Form
    {
        List<string> allQualities = new List<string>()
        {
            "Good looks","Wealth","Flash car","Important job","Sense of humour","Generosity","Empathy","Intelligence","Creativity"
        };

        List<string> yourQualitiesList = new List<string>();
        List<string> partnerQualitiesList = new List<string>();

        public WODAQualities()
        {
            InitializeComponent();
        }

        private void WODAQualities_Load(object sender, EventArgs e)
        {
            allQualities.Sort();
            qualities.DataSource = allQualities;
        }

        private void declareList()
        {
            List<string> qualitiesList = new List<string>(9);

            qualitiesList.Add("Good looks");
            qualitiesList.Add("Wealth");
            qualitiesList.Add("Flash car");
            qualitiesList.Add("Important job");
            qualitiesList.Add("Sense of humour");
            qualitiesList.Add("Generosity");
            qualitiesList.Add("Empathy");
            qualitiesList.Add("Intelligence");
            qualitiesList.Add("Creativity");

        }

        private void initialiseList()
        {
            List<string> qualitiesList = new List<string>()
            {
                "Good looks","Wealth","Flash car","Important job"
            };

            qualitiesList.Add("Sense of humour");
            qualitiesList.Add("Generosity");
            qualitiesList.Add("Empathy");
            qualitiesList.Add("Intelligence");
            qualitiesList.Add("Creativity");
        }

        private void addRangeOfitems()
        {
            List<string> qualitiesList = new List<string>()
            {
                "Good looks","Wealth","Flash car","Important job"
            };

            List<string> moreQualities = new List<string>()
            {
                "Sense of humour","Generosity","Empathy","Intelligence","Creativity"
            };

            qualitiesList.AddRange(moreQualities);

            string[] evenMoreQualities = new string[3];
            evenMoreQualities[0] = "test1";
            evenMoreQualities[1] = "test2";
            evenMoreQualities[2] = "test3";

            qualitiesList.AddRange(evenMoreQualities);

        }

        private void initialiseListUsingArray()
        {
            string[] evenMoreQualities = new string[3];
            evenMoreQualities[0] = "test1";
            evenMoreQualities[1] = "test2";
            evenMoreQualities[2] = "test3";

            List<string> testList = new List<string>(evenMoreQualities);

        }

        private void initialiseListUsingList()
        {
            List<string> moreQualities = new List<string>()
            {
                "Sense of humour","Generosity","Empathy","Intelligence","Creativity"
            };

            List<string> testList = new List<string>(moreQualities);

        }

        private void readItemsFromList()
        {
            qualities.Items.Add(allQualities[0]);
            qualities.Items.Add(allQualities[1]);
            qualities.Items.Add(allQualities[2]);
            qualities.Items.Add(allQualities[3]);
            qualities.Items.Add(allQualities[4]);
            qualities.Items.Add(allQualities[5]);
            qualities.Items.Add(allQualities[6]);

        }

        private void whileLoop()
        {
            int i = 0;

            while (i < allQualities.Count)
            {
                qualities.Items.Add(allQualities[i]);
                i++;
            }
        }

        private void forLoop()
        {
            for (int i = 0; i < allQualities.Count; i++)
            {
                qualities.Items.Add(allQualities[i]);
            }
        }

        private void forEachLoop()
        {
            foreach (string quality in allQualities)
            {
                qualities.Items.Add(quality);
            }
        }

        private void populateListboxQuickly()
        {
            //qualities.DataSource = allQualities;

            qualities.Items.AddRange(allQualities.ToArray());

        }

        private void sortListItems()
        {
            allQualities.Sort();
            allQualities.Reverse();

            qualities.DataSource = allQualities;
        }

        private void removeSingleItems()
        {
            allQualities.Remove("Wealth");

            allQualities.Sort();

            allQualities.RemoveAt(0);

            qualities.DataSource = allQualities;
        }

        private void removeMultipleItems()
        {
            allQualities.Sort();
            
            for (int i = allQualities.Count - 1; i >= 0; i--)
            {
                if (allQualities[i].StartsWith("G"))
                {
                    allQualities.RemoveAt(i);
                }
            }

            qualities.DataSource = allQualities;
        }

        private void removeItemsQuickly()
        {
            allQualities.RemoveAll(quality => quality.StartsWith("G"));

            qualities.DataSource = allQualities;
        }

        private void findItemIndex()
        {
            int i = allQualities.IndexOf("Wealth");

            if (i >= 0)
            {
                allQualities[i] = "Health";
            }

            qualities.DataSource = allQualities;
        }

        private void findItemsWithLambda()
        {
            int firstaIndex = allQualities.FindIndex(quality => quality.Contains("a"));
            int lastaIndex = allQualities.FindLastIndex(quality => quality.Contains("a"));

            string firsta = allQualities.Find(quality => quality.Contains("a"));
            string lasta = allQualities.FindLast(quality => quality.Contains("a"));

            qualities.DataSource = allQualities;

            MessageBox.Show(
                "First a = " + firstaIndex.ToString() + " - " + firsta + "\n" +
                "Last a = " + lastaIndex.ToString() + " - " + lasta);

        }

        private void findAllItems()
        {
            List<string> founditems =
                allQualities.FindAll(quality => quality.Contains("a"));

            qualities.DataSource = founditems;

        }

        private void setYourQualities_Click(object sender, EventArgs e)
        {
            yourQualitiesList.Clear();
            yourQualities.DataSource = null;

            foreach (string s in qualities.SelectedItems)
            {
                yourQualitiesList.Add(s);
            }

            yourQualitiesList.Sort();
            yourQualities.DataSource = yourQualitiesList;

        }

        private void setPartnerQualities_Click(object sender, EventArgs e)
        {
            partnerQualitiesList.Clear();
            partnerQualities.DataSource = null;

            foreach (string s in qualities.SelectedItems)
            {
                partnerQualitiesList.Add(s);
            }

            partnerQualitiesList.Sort();
            partnerQualities.DataSource = partnerQualitiesList;
        }

        private void removeYourSelectedQualities_Click(object sender, EventArgs e)
        {
            foreach (string s in yourQualities.SelectedItems)
            {
                yourQualitiesList.Remove(s);
            }

            yourQualities.DataSource = null;
            yourQualities.DataSource = yourQualitiesList;
        }

        private void removePartnerSelectedQualities_Click(object sender, EventArgs e)
        {
            foreach (string s in partnerQualities.SelectedItems)
            {
                partnerQualitiesList.Remove(s);
            }

            partnerQualities.DataSource = null;
            partnerQualities.DataSource = partnerQualitiesList;
        }

        private void addToYourQualities_Click(object sender, EventArgs e)
        {
            foreach (string s in qualities.SelectedItems)
            {
                if (!yourQualitiesList.Contains(s))
                {
                    yourQualitiesList.Add(s);
                }
            }

            yourQualitiesList.Sort();
            yourQualities.DataSource = null;
            yourQualities.DataSource = yourQualitiesList;
        }

        private void addToPartnerQualities_Click(object sender, EventArgs e)
        {
            foreach (string s in qualities.SelectedItems)
            {
                if (!partnerQualitiesList.Contains(s))
                {
                    partnerQualitiesList.Add(s);
                }
            }

            partnerQualitiesList.Sort();
            partnerQualities.DataSource = null;
            partnerQualities.DataSource = partnerQualitiesList;
        }

        private void compareQualities_Click(object sender, EventArgs e)
        {
            List<string> sharedQualitiesList = new List<string>();

            foreach (string s in yourQualitiesList)
            {
                if (partnerQualitiesList.Contains(s))
                {
                    sharedQualitiesList.Add(s);
                }
            }

            string sharedQualities = string.Join("\n", sharedQualitiesList);

            MessageBox.Show("Your shared qualities are\n" + sharedQualities);
        }
    }
}
