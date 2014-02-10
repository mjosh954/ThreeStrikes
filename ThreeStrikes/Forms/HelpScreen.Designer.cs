namespace ThreeStrikes.Forms
{
    partial class HelpScreen
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
            this.lblHelpTitle = new System.Windows.Forms.Label();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHelpTitle
            // 
            this.lblHelpTitle.AutoSize = true;
            this.lblHelpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblHelpTitle.Location = new System.Drawing.Point(140, 9);
            this.lblHelpTitle.Name = "lblHelpTitle";
            this.lblHelpTitle.Size = new System.Drawing.Size(159, 31);
            this.lblHelpTitle.TabIndex = 0;
            this.lblHelpTitle.Text = "How to Play";
            // 
            // txtInstructions
            // 
            this.txtInstructions.Enabled = false;
            this.txtInstructions.Location = new System.Drawing.Point(33, 52);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(396, 241);
            this.txtInstructions.TabIndex = 1;
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(458, 325);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblHelpTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelpTitle;
        private System.Windows.Forms.TextBox txtInstructions;
    }
}