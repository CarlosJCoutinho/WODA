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
    public partial class WODAApplicationForm : Form
    {
        
        public WODAApplicationForm()
        {
            InitializeComponent();
        }

        private void applyNowButton_Click(object sender, EventArgs e)
        {
            //this method displays a message when the user clicks the button
            string messageText = string.Empty;
            byte minimumAge = 0;
            byte maximumAge = 0;
            byte ageRange = 0;
            DateTime dob = dateOfBirthPicker.Value;
            int age = 0;
            string ageCategory = string.Empty;
            string yourGender = string.Empty;
            string partnerGender = string.Empty;

            if (checkValueFilledIn(firstNameTextBox, firstNameLabel) == false)
                return;

            if (checkValueFilledIn(lastNameTextBox, lastNameLabel) == false)
                return;

            if (!checkValueFilledIn(yourGenderList, yourGenderLabel))
                return;

            if (!checkValueFilledIn(theirGenderList, theirGenderLabel))
                return;

            age = calculateAge(dob);

            if (age < 18)
            {
                MessageBox.Show("You're too young");
                return;
            }

            ageCategory = calculateAgeCategory(age: age, oldAgeThreshold: 60);

            //yourGender = (yourGenderList.Text == "Male") ? "man" : "woman";
            //partnerGender = (theirGenderList.Text == "Male") ? "man" : "woman";

            yourGender = calculateGender(yourGenderList.Text);
            partnerGender = calculateGender(theirGenderList.Text);

            minimumAge = (byte)minimumAgeSpinner.Value;
            maximumAge = Convert.ToByte(maximumAgeSpinner.Value);

            ageRange = (byte)(maximumAge - minimumAge);

            messageText = "Welcome to WODA " + getFullName();
            messageText += "\nYou are a " + yourGender;
            messageText += "\nYou are looking for a " + partnerGender;
            messageText += "\nYour partner's age range is " + ageRange;
            messageText += "\nYou were born on " + dob.ToString("dddd d MMMM yyyy");
            messageText += "\nYour age is " + age;
            messageText += "\nYour age category is " + ageCategory;

            MessageBox.Show(
                    messageText,
                    "WODA Application",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            //resetApplicationForm();
            showMatches();
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            resetApplicationForm();
        }

        private void resetApplicationForm()
        {
            //clear first and last name text boxes
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();

            //clear text from gender comboboxes
            yourGenderList.ResetText();
            theirGenderList.ResetText();

            //reset age boxes
            minimumAgeSpinner.Value = 18;
            maximumAgeSpinner.Value = 100;

            //reset date of birth to today
            dateOfBirthPicker.Value = DateTime.Today;
        }
        
        private void quitButton_Click(object sender, EventArgs e)
        {
            //form disappear
            this.Visible = false;

            //message appears
            MessageBox.Show("Bye bye " + getFullName());

            //quit application
            Application.Exit();

        }

        private string getFullName()
        {
            return firstNameTextBox.Text + " " + lastNameTextBox.Text;
        }

        private int calculateAge(DateTime dateOfBirth)
        {
            int differenceInYears = DateTime.Today.Year - dateOfBirth.Year;
            DateTime currentBirthday = dateOfBirth.AddYears(differenceInYears);

            if (currentBirthday.Date > DateTime.Today) differenceInYears--;

            return differenceInYears;
        }

        private string calculateAgeCategory(int age,int middleAgeThreshold = 30, int oldAgeThreshold = 55)
        {
            if (age < middleAgeThreshold)
            {
                return "Young";
            }
            else if (age < oldAgeThreshold)
            {
                return "Middle age";
            }
            else
            {
                return "Old";
            }
        }

        private bool checkValueFilledIn(TextBox textBox, Label label)
        {
            if (textBox.Text == string.Empty)
            {
                textBox.BackColor = Color.Pink;
                label.ForeColor = Color.Red;
                textBox.Focus();
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                label.ForeColor = Color.Black;
                return true;
            }
        }

        private bool checkValueFilledIn(ComboBox comboBox, Label label)
        {
            if (comboBox.Text == string.Empty)
            {
                comboBox.BackColor = Color.Pink;
                label.ForeColor = Color.Red;
                comboBox.Focus();
                return false;
            }
            else
            {
                comboBox.BackColor = Color.White;
                label.ForeColor = Color.Black;
                return true;
            }
        }

        private string calculateGender(string gender)
        {
            switch (gender)
            {
                case "Male":
                case "M":
                case "m":
                case "male":
                    return "man";
                case "Female":
                    return "woman";
                default:
                    return "invalid choice";
            }
        }

        private void showMatches()
        {
            WODAMatchesForm matchesForm = new WODAMatchesForm();

            using (StreamReader clientsFile = new StreamReader(@"C:\Users\Andrew.Gould\Desktop\WODAClients.txt"))
            {
                clientsFile.ReadLine();

                while (!clientsFile.EndOfStream)
                {
                    string eachClient = clientsFile.ReadLine();

                    string[] clientDetails = eachClient.Split('\t');

                    string clientGender = clientDetails[3];
                    string clientPartnerGender = clientDetails[4];
                    DateTime clientDOB = Convert.ToDateTime(clientDetails[2]);
                    int clientAge = calculateAge(clientDOB);
                    int yourAge = calculateAge(dateOfBirthPicker.Value);
                    int clientMinimumAge = Convert.ToInt32(clientDetails[5]);
                    int clientMaximumAge = Convert.ToInt32(clientDetails[6]);

                    if (clientGender == theirGenderList.Text && clientPartnerGender == yourGenderList.Text)
                    {
                        if (clientAge >= minimumAgeSpinner.Value && clientAge <= maximumAgeSpinner.Value)
                        {
                            if (yourAge >= clientMinimumAge && yourAge <= clientMaximumAge)
                            {
                                matchesForm.YourMatchesList.Items.Add(
                                    clientDetails[0] + " " + clientDetails[1] + "\t" + clientAge);
                            }
                        }
                    }
                }
            }

            matchesForm.Show();
        }

        private void hotDatesButton_Click(object sender, EventArgs e)
        {
            WODAHotDates hotDatesForm = new WODAHotDates();

            hotDatesForm.Show();
        }

        private void chooseQualitiesButton_Click(object sender, EventArgs e)
        {
            WODAQualities qualitiesForm = new WODAQualities();

            qualitiesForm.Show();

        }
    }
}
