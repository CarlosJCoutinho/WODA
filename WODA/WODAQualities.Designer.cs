namespace WODA
{
    partial class WODAQualities
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
            this.qualities = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yourQualities = new System.Windows.Forms.ListBox();
            this.partnerQualities = new System.Windows.Forms.ListBox();
            this.setYourQualities = new System.Windows.Forms.Button();
            this.setPartnerQualities = new System.Windows.Forms.Button();
            this.removeYourSelectedQualities = new System.Windows.Forms.Button();
            this.removePartnerSelectedQualities = new System.Windows.Forms.Button();
            this.addToYourQualities = new System.Windows.Forms.Button();
            this.addToPartnerQualities = new System.Windows.Forms.Button();
            this.compareQualities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qualities
            // 
            this.qualities.FormattingEnabled = true;
            this.qualities.Location = new System.Drawing.Point(307, 16);
            this.qualities.Name = "qualities";
            this.qualities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.qualities.Size = new System.Drawing.Size(139, 147);
            this.qualities.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your qualities";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Partner qualities";
            // 
            // yourQualities
            // 
            this.yourQualities.FormattingEnabled = true;
            this.yourQualities.Location = new System.Drawing.Point(16, 29);
            this.yourQualities.Name = "yourQualities";
            this.yourQualities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.yourQualities.Size = new System.Drawing.Size(120, 134);
            this.yourQualities.TabIndex = 3;
            // 
            // partnerQualities
            // 
            this.partnerQualities.FormattingEnabled = true;
            this.partnerQualities.Location = new System.Drawing.Point(619, 29);
            this.partnerQualities.Name = "partnerQualities";
            this.partnerQualities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.partnerQualities.Size = new System.Drawing.Size(120, 134);
            this.partnerQualities.TabIndex = 4;
            // 
            // setYourQualities
            // 
            this.setYourQualities.Location = new System.Drawing.Point(154, 56);
            this.setYourQualities.Name = "setYourQualities";
            this.setYourQualities.Size = new System.Drawing.Size(128, 23);
            this.setYourQualities.TabIndex = 5;
            this.setYourQualities.Text = "<< Set your qualities";
            this.setYourQualities.UseVisualStyleBackColor = true;
            this.setYourQualities.Click += new System.EventHandler(this.setYourQualities_Click);
            // 
            // setPartnerQualities
            // 
            this.setPartnerQualities.Location = new System.Drawing.Point(466, 56);
            this.setPartnerQualities.Name = "setPartnerQualities";
            this.setPartnerQualities.Size = new System.Drawing.Size(135, 23);
            this.setPartnerQualities.TabIndex = 6;
            this.setPartnerQualities.Text = "Set partner qualities >>";
            this.setPartnerQualities.UseVisualStyleBackColor = true;
            this.setPartnerQualities.Click += new System.EventHandler(this.setPartnerQualities_Click);
            // 
            // removeYourSelectedQualities
            // 
            this.removeYourSelectedQualities.Location = new System.Drawing.Point(16, 170);
            this.removeYourSelectedQualities.Name = "removeYourSelectedQualities";
            this.removeYourSelectedQualities.Size = new System.Drawing.Size(120, 23);
            this.removeYourSelectedQualities.TabIndex = 7;
            this.removeYourSelectedQualities.Text = "Remove selected";
            this.removeYourSelectedQualities.UseVisualStyleBackColor = true;
            this.removeYourSelectedQualities.Click += new System.EventHandler(this.removeYourSelectedQualities_Click);
            // 
            // removePartnerSelectedQualities
            // 
            this.removePartnerSelectedQualities.Location = new System.Drawing.Point(619, 170);
            this.removePartnerSelectedQualities.Name = "removePartnerSelectedQualities";
            this.removePartnerSelectedQualities.Size = new System.Drawing.Size(121, 23);
            this.removePartnerSelectedQualities.TabIndex = 8;
            this.removePartnerSelectedQualities.Text = "Remove selected";
            this.removePartnerSelectedQualities.UseVisualStyleBackColor = true;
            this.removePartnerSelectedQualities.Click += new System.EventHandler(this.removePartnerSelectedQualities_Click);
            // 
            // addToYourQualities
            // 
            this.addToYourQualities.Location = new System.Drawing.Point(154, 86);
            this.addToYourQualities.Name = "addToYourQualities";
            this.addToYourQualities.Size = new System.Drawing.Size(128, 23);
            this.addToYourQualities.TabIndex = 9;
            this.addToYourQualities.Text = "< Add to your qualities";
            this.addToYourQualities.UseVisualStyleBackColor = true;
            this.addToYourQualities.Click += new System.EventHandler(this.addToYourQualities_Click);
            // 
            // addToPartnerQualities
            // 
            this.addToPartnerQualities.Location = new System.Drawing.Point(466, 86);
            this.addToPartnerQualities.Name = "addToPartnerQualities";
            this.addToPartnerQualities.Size = new System.Drawing.Size(135, 23);
            this.addToPartnerQualities.TabIndex = 10;
            this.addToPartnerQualities.Text = "Add to partner qualities >";
            this.addToPartnerQualities.UseVisualStyleBackColor = true;
            this.addToPartnerQualities.Click += new System.EventHandler(this.addToPartnerQualities_Click);
            // 
            // compareQualities
            // 
            this.compareQualities.Location = new System.Drawing.Point(307, 170);
            this.compareQualities.Name = "compareQualities";
            this.compareQualities.Size = new System.Drawing.Size(139, 23);
            this.compareQualities.TabIndex = 11;
            this.compareQualities.Text = "Compare qualities";
            this.compareQualities.UseVisualStyleBackColor = true;
            this.compareQualities.Click += new System.EventHandler(this.compareQualities_Click);
            // 
            // WODAQualities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 262);
            this.Controls.Add(this.compareQualities);
            this.Controls.Add(this.addToPartnerQualities);
            this.Controls.Add(this.addToYourQualities);
            this.Controls.Add(this.removePartnerSelectedQualities);
            this.Controls.Add(this.removeYourSelectedQualities);
            this.Controls.Add(this.setPartnerQualities);
            this.Controls.Add(this.setYourQualities);
            this.Controls.Add(this.partnerQualities);
            this.Controls.Add(this.yourQualities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qualities);
            this.Name = "WODAQualities";
            this.Text = "WODAQualities";
            this.Load += new System.EventHandler(this.WODAQualities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox qualities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox yourQualities;
        private System.Windows.Forms.ListBox partnerQualities;
        private System.Windows.Forms.Button setYourQualities;
        private System.Windows.Forms.Button setPartnerQualities;
        private System.Windows.Forms.Button removeYourSelectedQualities;
        private System.Windows.Forms.Button removePartnerSelectedQualities;
        private System.Windows.Forms.Button addToYourQualities;
        private System.Windows.Forms.Button addToPartnerQualities;
        private System.Windows.Forms.Button compareQualities;
    }
}