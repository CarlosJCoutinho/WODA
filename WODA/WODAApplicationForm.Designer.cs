namespace WODA
{
    partial class WODAApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WODAApplicationForm));
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.applicantDetailsGroup = new System.Windows.Forms.GroupBox();
            this.yourGenderLabel = new System.Windows.Forms.Label();
            this.yourGenderList = new System.Windows.Forms.ComboBox();
            this.theirGenderList = new System.Windows.Forms.ComboBox();
            this.theirGenderLabel = new System.Windows.Forms.Label();
            this.partnerDetailsGroup = new System.Windows.Forms.GroupBox();
            this.maximumAgeLabel = new System.Windows.Forms.Label();
            this.minimumAgeLabel = new System.Windows.Forms.Label();
            this.maximumAgeSpinner = new System.Windows.Forms.NumericUpDown();
            this.minimumAgeSpinner = new System.Windows.Forms.NumericUpDown();
            this.applyNowButton = new System.Windows.Forms.Button();
            this.clearFormButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.hotDatesButton = new System.Windows.Forms.Button();
            this.chooseQualitiesButton = new System.Windows.Forms.Button();
            this.applicantDetailsGroup.SuspendLayout();
            this.partnerDetailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumAgeSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumAgeSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(87, 35);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(87, 70);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.CustomFormat = "";
            this.dateOfBirthPicker.Location = new System.Drawing.Point(87, 105);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(155, 20);
            this.dateOfBirthPicker.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(17, 38);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(17, 73);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last name";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(17, 108);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(65, 13);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Date of birth";
            // 
            // applicantDetailsGroup
            // 
            this.applicantDetailsGroup.Controls.Add(this.yourGenderLabel);
            this.applicantDetailsGroup.Controls.Add(this.yourGenderList);
            this.applicantDetailsGroup.Controls.Add(this.firstNameTextBox);
            this.applicantDetailsGroup.Controls.Add(this.dateOfBirthLabel);
            this.applicantDetailsGroup.Controls.Add(this.lastNameTextBox);
            this.applicantDetailsGroup.Controls.Add(this.lastNameLabel);
            this.applicantDetailsGroup.Controls.Add(this.dateOfBirthPicker);
            this.applicantDetailsGroup.Controls.Add(this.firstNameLabel);
            this.applicantDetailsGroup.Location = new System.Drawing.Point(12, 12);
            this.applicantDetailsGroup.Name = "applicantDetailsGroup";
            this.applicantDetailsGroup.Size = new System.Drawing.Size(260, 187);
            this.applicantDetailsGroup.TabIndex = 6;
            this.applicantDetailsGroup.TabStop = false;
            this.applicantDetailsGroup.Text = "Your Details";
            // 
            // yourGenderLabel
            // 
            this.yourGenderLabel.AutoSize = true;
            this.yourGenderLabel.Location = new System.Drawing.Point(17, 142);
            this.yourGenderLabel.Name = "yourGenderLabel";
            this.yourGenderLabel.Size = new System.Drawing.Size(65, 13);
            this.yourGenderLabel.TabIndex = 8;
            this.yourGenderLabel.Text = "Your gender";
            // 
            // yourGenderList
            // 
            this.yourGenderList.FormattingEnabled = true;
            this.yourGenderList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.yourGenderList.Location = new System.Drawing.Point(87, 142);
            this.yourGenderList.Name = "yourGenderList";
            this.yourGenderList.Size = new System.Drawing.Size(155, 21);
            this.yourGenderList.TabIndex = 6;
            // 
            // theirGenderList
            // 
            this.theirGenderList.FormattingEnabled = true;
            this.theirGenderList.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.theirGenderList.Location = new System.Drawing.Point(100, 34);
            this.theirGenderList.Name = "theirGenderList";
            this.theirGenderList.Size = new System.Drawing.Size(155, 21);
            this.theirGenderList.TabIndex = 7;
            // 
            // theirGenderLabel
            // 
            this.theirGenderLabel.AutoSize = true;
            this.theirGenderLabel.Location = new System.Drawing.Point(22, 37);
            this.theirGenderLabel.Name = "theirGenderLabel";
            this.theirGenderLabel.Size = new System.Drawing.Size(67, 13);
            this.theirGenderLabel.TabIndex = 9;
            this.theirGenderLabel.Text = "Their gender";
            // 
            // partnerDetailsGroup
            // 
            this.partnerDetailsGroup.Controls.Add(this.maximumAgeLabel);
            this.partnerDetailsGroup.Controls.Add(this.minimumAgeLabel);
            this.partnerDetailsGroup.Controls.Add(this.maximumAgeSpinner);
            this.partnerDetailsGroup.Controls.Add(this.minimumAgeSpinner);
            this.partnerDetailsGroup.Controls.Add(this.theirGenderLabel);
            this.partnerDetailsGroup.Controls.Add(this.theirGenderList);
            this.partnerDetailsGroup.Location = new System.Drawing.Point(279, 13);
            this.partnerDetailsGroup.Name = "partnerDetailsGroup";
            this.partnerDetailsGroup.Size = new System.Drawing.Size(276, 186);
            this.partnerDetailsGroup.TabIndex = 7;
            this.partnerDetailsGroup.TabStop = false;
            this.partnerDetailsGroup.Text = "Partner Details";
            // 
            // maximumAgeLabel
            // 
            this.maximumAgeLabel.AutoSize = true;
            this.maximumAgeLabel.Location = new System.Drawing.Point(22, 106);
            this.maximumAgeLabel.Name = "maximumAgeLabel";
            this.maximumAgeLabel.Size = new System.Drawing.Size(72, 13);
            this.maximumAgeLabel.TabIndex = 13;
            this.maximumAgeLabel.Text = "Maximum age";
            // 
            // minimumAgeLabel
            // 
            this.minimumAgeLabel.AutoSize = true;
            this.minimumAgeLabel.Location = new System.Drawing.Point(22, 69);
            this.minimumAgeLabel.Name = "minimumAgeLabel";
            this.minimumAgeLabel.Size = new System.Drawing.Size(69, 13);
            this.minimumAgeLabel.TabIndex = 12;
            this.minimumAgeLabel.Text = "Minimum age";
            // 
            // maximumAgeSpinner
            // 
            this.maximumAgeSpinner.Location = new System.Drawing.Point(100, 104);
            this.maximumAgeSpinner.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.maximumAgeSpinner.Name = "maximumAgeSpinner";
            this.maximumAgeSpinner.Size = new System.Drawing.Size(53, 20);
            this.maximumAgeSpinner.TabIndex = 11;
            this.maximumAgeSpinner.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // minimumAgeSpinner
            // 
            this.minimumAgeSpinner.Location = new System.Drawing.Point(100, 67);
            this.minimumAgeSpinner.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.minimumAgeSpinner.Name = "minimumAgeSpinner";
            this.minimumAgeSpinner.Size = new System.Drawing.Size(53, 20);
            this.minimumAgeSpinner.TabIndex = 10;
            this.minimumAgeSpinner.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // applyNowButton
            // 
            this.applyNowButton.Location = new System.Drawing.Point(459, 215);
            this.applyNowButton.Name = "applyNowButton";
            this.applyNowButton.Size = new System.Drawing.Size(75, 23);
            this.applyNowButton.TabIndex = 8;
            this.applyNowButton.Text = "Apply Now";
            this.applyNowButton.UseVisualStyleBackColor = true;
            this.applyNowButton.Click += new System.EventHandler(this.applyNowButton_Click);
            // 
            // clearFormButton
            // 
            this.clearFormButton.Location = new System.Drawing.Point(378, 215);
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.Size = new System.Drawing.Size(75, 23);
            this.clearFormButton.TabIndex = 9;
            this.clearFormButton.Text = "Clear Form";
            this.clearFormButton.UseVisualStyleBackColor = true;
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(459, 245);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // hotDatesButton
            // 
            this.hotDatesButton.Location = new System.Drawing.Point(13, 215);
            this.hotDatesButton.Name = "hotDatesButton";
            this.hotDatesButton.Size = new System.Drawing.Size(120, 23);
            this.hotDatesButton.TabIndex = 11;
            this.hotDatesButton.Text = "See hottest dates";
            this.hotDatesButton.UseVisualStyleBackColor = true;
            this.hotDatesButton.Click += new System.EventHandler(this.hotDatesButton_Click);
            // 
            // chooseQualitiesButton
            // 
            this.chooseQualitiesButton.Location = new System.Drawing.Point(13, 245);
            this.chooseQualitiesButton.Name = "chooseQualitiesButton";
            this.chooseQualitiesButton.Size = new System.Drawing.Size(120, 23);
            this.chooseQualitiesButton.TabIndex = 12;
            this.chooseQualitiesButton.Text = "Choose qualities";
            this.chooseQualitiesButton.UseVisualStyleBackColor = true;
            this.chooseQualitiesButton.Click += new System.EventHandler(this.chooseQualitiesButton_Click);
            // 
            // WODAApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(568, 285);
            this.Controls.Add(this.chooseQualitiesButton);
            this.Controls.Add(this.hotDatesButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.clearFormButton);
            this.Controls.Add(this.applyNowButton);
            this.Controls.Add(this.partnerDetailsGroup);
            this.Controls.Add(this.applicantDetailsGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WODAApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to WODA";
            this.applicantDetailsGroup.ResumeLayout(false);
            this.applicantDetailsGroup.PerformLayout();
            this.partnerDetailsGroup.ResumeLayout(false);
            this.partnerDetailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumAgeSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumAgeSpinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.GroupBox applicantDetailsGroup;
        private System.Windows.Forms.Label yourGenderLabel;
        private System.Windows.Forms.ComboBox yourGenderList;
        private System.Windows.Forms.ComboBox theirGenderList;
        private System.Windows.Forms.Label theirGenderLabel;
        private System.Windows.Forms.GroupBox partnerDetailsGroup;
        private System.Windows.Forms.Label maximumAgeLabel;
        private System.Windows.Forms.Label minimumAgeLabel;
        private System.Windows.Forms.NumericUpDown maximumAgeSpinner;
        private System.Windows.Forms.NumericUpDown minimumAgeSpinner;
        private System.Windows.Forms.Button applyNowButton;
        private System.Windows.Forms.Button clearFormButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button hotDatesButton;
        private System.Windows.Forms.Button chooseQualitiesButton;
    }
}

