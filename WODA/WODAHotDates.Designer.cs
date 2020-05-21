namespace WODA
{
    partial class WODAHotDates
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
            this.hotDatesList = new System.Windows.Forms.ListBox();
            this.resizeArrayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hotDatesList
            // 
            this.hotDatesList.FormattingEnabled = true;
            this.hotDatesList.Location = new System.Drawing.Point(13, 13);
            this.hotDatesList.Name = "hotDatesList";
            this.hotDatesList.Size = new System.Drawing.Size(183, 173);
            this.hotDatesList.TabIndex = 0;
            // 
            // resizeArrayButton
            // 
            this.resizeArrayButton.Location = new System.Drawing.Point(203, 13);
            this.resizeArrayButton.Name = "resizeArrayButton";
            this.resizeArrayButton.Size = new System.Drawing.Size(75, 23);
            this.resizeArrayButton.TabIndex = 1;
            this.resizeArrayButton.Text = "Add items";
            this.resizeArrayButton.UseVisualStyleBackColor = true;
            this.resizeArrayButton.Click += new System.EventHandler(this.resizeArrayButton_Click);
            // 
            // WODAHotDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.resizeArrayButton);
            this.Controls.Add(this.hotDatesList);
            this.Name = "WODAHotDates";
            this.Text = "WODAHotDates";
            this.Load += new System.EventHandler(this.WODAHotDates_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox hotDatesList;
        private System.Windows.Forms.Button resizeArrayButton;
    }
}