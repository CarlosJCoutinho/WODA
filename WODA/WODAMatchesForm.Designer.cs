namespace WODA
{
    partial class WODAMatchesForm
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
            this.YourMatchesList = new System.Windows.Forms.ListBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.removeSelectedDatesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YourMatchesList
            // 
            this.YourMatchesList.FormattingEnabled = true;
            this.YourMatchesList.Location = new System.Drawing.Point(13, 13);
            this.YourMatchesList.Name = "YourMatchesList";
            this.YourMatchesList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.YourMatchesList.Size = new System.Drawing.Size(297, 212);
            this.YourMatchesList.TabIndex = 0;
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(235, 231);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(75, 23);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Close";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // removeSelectedDatesButton
            // 
            this.removeSelectedDatesButton.Location = new System.Drawing.Point(89, 232);
            this.removeSelectedDatesButton.Name = "removeSelectedDatesButton";
            this.removeSelectedDatesButton.Size = new System.Drawing.Size(140, 23);
            this.removeSelectedDatesButton.TabIndex = 2;
            this.removeSelectedDatesButton.Text = "Remove selected dates";
            this.removeSelectedDatesButton.UseVisualStyleBackColor = true;
            this.removeSelectedDatesButton.Click += new System.EventHandler(this.removeSelectedDatesButton_Click);
            // 
            // WODAMatchesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 262);
            this.Controls.Add(this.removeSelectedDatesButton);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.YourMatchesList);
            this.Name = "WODAMatchesForm";
            this.Text = "WODAMatchesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeForm;
        public System.Windows.Forms.ListBox YourMatchesList;
        private System.Windows.Forms.Button removeSelectedDatesButton;
    }
}