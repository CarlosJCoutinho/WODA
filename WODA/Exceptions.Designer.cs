namespace WODA
{
    partial class Exceptions
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
            this.matchesList = new System.Windows.Forms.ListBox();
            this.showMatches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matchesList
            // 
            this.matchesList.FormattingEnabled = true;
            this.matchesList.Location = new System.Drawing.Point(13, 13);
            this.matchesList.Name = "matchesList";
            this.matchesList.Size = new System.Drawing.Size(317, 238);
            this.matchesList.TabIndex = 0;
            // 
            // showMatches
            // 
            this.showMatches.Location = new System.Drawing.Point(337, 13);
            this.showMatches.Name = "showMatches";
            this.showMatches.Size = new System.Drawing.Size(187, 23);
            this.showMatches.TabIndex = 1;
            this.showMatches.Text = "Show matches";
            this.showMatches.UseVisualStyleBackColor = true;
            this.showMatches.Click += new System.EventHandler(this.showMatches_Click);
            // 
            // Exceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showMatches);
            this.Controls.Add(this.matchesList);
            this.Name = "Exceptions";
            this.Text = "Exceptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox matchesList;
        private System.Windows.Forms.Button showMatches;
    }
}