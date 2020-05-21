namespace WODA
{
    partial class WhileLoops
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
            this.WhileLoopsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhileLoopsButton
            // 
            this.WhileLoopsButton.Location = new System.Drawing.Point(13, 13);
            this.WhileLoopsButton.Name = "WhileLoopsButton";
            this.WhileLoopsButton.Size = new System.Drawing.Size(105, 23);
            this.WhileLoopsButton.TabIndex = 0;
            this.WhileLoopsButton.Text = "Basic While Loop";
            this.WhileLoopsButton.UseVisualStyleBackColor = true;
            this.WhileLoopsButton.Click += new System.EventHandler(this.WhileLoopsButton_Click);
            // 
            // WhileLoops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.WhileLoopsButton);
            this.Name = "WhileLoops";
            this.Text = "WhileLoops";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WhileLoopsButton;
    }
}