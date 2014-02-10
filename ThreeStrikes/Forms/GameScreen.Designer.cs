namespace ThreeStrikes
{
    partial class GameScreen
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
            this.btnPick = new System.Windows.Forms.Button();
            this.lblPanel0 = new System.Windows.Forms.Label();
            this.lblPanel1 = new System.Windows.Forms.Label();
            this.lblPanel2 = new System.Windows.Forms.Label();
            this.lblPanel3 = new System.Windows.Forms.Label();
            this.lblPanel4 = new System.Windows.Forms.Label();
            this.lblStrikes = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblOnHand = new System.Windows.Forms.Label();
            this.lblStrike = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.lblProbabilityTitle = new System.Windows.Forms.Label();
            this.lblPickingNumber = new System.Windows.Forms.Label();
            this.lblPickStrike = new System.Windows.Forms.Label();
            this.lblPickCorPanel = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // btnPick
            // 
            this.btnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPick.Location = new System.Drawing.Point(281, 378);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(87, 42);
            this.btnPick.TabIndex = 0;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // lblPanel0
            // 
            this.lblPanel0.AutoSize = true;
            this.lblPanel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.lblPanel0.Location = new System.Drawing.Point(98, 119);
            this.lblPanel0.Name = "lblPanel0";
            this.lblPanel0.Size = new System.Drawing.Size(70, 69);
            this.lblPanel0.TabIndex = 1;
            this.lblPanel0.Text = "X";
            // 
            // lblPanel1
            // 
            this.lblPanel1.AutoSize = true;
            this.lblPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.lblPanel1.Location = new System.Drawing.Point(197, 119);
            this.lblPanel1.Name = "lblPanel1";
            this.lblPanel1.Size = new System.Drawing.Size(70, 69);
            this.lblPanel1.TabIndex = 2;
            this.lblPanel1.Text = "X";
            // 
            // lblPanel2
            // 
            this.lblPanel2.AutoSize = true;
            this.lblPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.lblPanel2.Location = new System.Drawing.Point(298, 119);
            this.lblPanel2.Name = "lblPanel2";
            this.lblPanel2.Size = new System.Drawing.Size(70, 69);
            this.lblPanel2.TabIndex = 3;
            this.lblPanel2.Text = "X";
            // 
            // lblPanel3
            // 
            this.lblPanel3.AutoSize = true;
            this.lblPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.lblPanel3.Location = new System.Drawing.Point(403, 119);
            this.lblPanel3.Name = "lblPanel3";
            this.lblPanel3.Size = new System.Drawing.Size(70, 69);
            this.lblPanel3.TabIndex = 4;
            this.lblPanel3.Text = "X";
            // 
            // lblPanel4
            // 
            this.lblPanel4.AutoSize = true;
            this.lblPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.lblPanel4.Location = new System.Drawing.Point(503, 119);
            this.lblPanel4.Name = "lblPanel4";
            this.lblPanel4.Size = new System.Drawing.Size(70, 69);
            this.lblPanel4.TabIndex = 5;
            this.lblPanel4.Text = "X";
            // 
            // lblStrikes
            // 
            this.lblStrikes.AutoSize = true;
            this.lblStrikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblStrikes.Location = new System.Drawing.Point(117, 58);
            this.lblStrikes.Name = "lblStrikes";
            this.lblStrikes.Size = new System.Drawing.Size(106, 31);
            this.lblStrikes.TabIndex = 6;
            this.lblStrikes.Text = "Strikes:";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPrize.Location = new System.Drawing.Point(117, 16);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(84, 31);
            this.lblPrize.TabIndex = 7;
            this.lblPrize.Text = "Prize:";
            // 
            // lblOnHand
            // 
            this.lblOnHand.AutoSize = true;
            this.lblOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblOnHand.Location = new System.Drawing.Point(152, 293);
            this.lblOnHand.Name = "lblOnHand";
            this.lblOnHand.Size = new System.Drawing.Size(137, 31);
            this.lblOnHand.TabIndex = 8;
            this.lblOnHand.Text = "On Hand: ";
            this.lblOnHand.Visible = false;
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblStrike.ForeColor = System.Drawing.Color.Crimson;
            this.lblStrike.Location = new System.Drawing.Point(249, 214);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(166, 63);
            this.lblStrike.TabIndex = 9;
            this.lblStrike.Text = "Strike";
            this.lblStrike.Visible = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1,
            this.rectangleShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(676, 442);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Location = new System.Drawing.Point(103, 112);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(462, 82);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHowToPlay.Location = new System.Drawing.Point(12, 12);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(99, 35);
            this.btnHowToPlay.TabIndex = 11;
            this.btnHowToPlay.Text = "How to Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // lblProbabilityTitle
            // 
            this.lblProbabilityTitle.AutoSize = true;
            this.lblProbabilityTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblProbabilityTitle.Location = new System.Drawing.Point(482, 276);
            this.lblProbabilityTitle.Name = "lblProbabilityTitle";
            this.lblProbabilityTitle.Size = new System.Drawing.Size(162, 31);
            this.lblProbabilityTitle.TabIndex = 12;
            this.lblProbabilityTitle.Text = "Probabilities";
            // 
            // lblPickingNumber
            // 
            this.lblPickingNumber.AutoSize = true;
            this.lblPickingNumber.Location = new System.Drawing.Point(485, 324);
            this.lblPickingNumber.Name = "lblPickingNumber";
            this.lblPickingNumber.Size = new System.Drawing.Size(85, 13);
            this.lblPickingNumber.TabIndex = 13;
            this.lblPickingNumber.Text = "Draw a number: ";
            // 
            // lblPickStrike
            // 
            this.lblPickStrike.AutoSize = true;
            this.lblPickStrike.Location = new System.Drawing.Point(485, 346);
            this.lblPickStrike.Name = "lblPickStrike";
            this.lblPickStrike.Size = new System.Drawing.Size(75, 13);
            this.lblPickStrike.TabIndex = 14;
            this.lblPickStrike.Text = "Draw a strike: ";
            // 
            // lblPickCorPanel
            // 
            this.lblPickCorPanel.AutoSize = true;
            this.lblPickCorPanel.Location = new System.Drawing.Point(485, 368);
            this.lblPickCorPanel.Name = "lblPickCorPanel";
            this.lblPickCorPanel.Size = new System.Drawing.Size(105, 13);
            this.lblPickCorPanel.TabIndex = 15;
            this.lblPickCorPanel.Text = "Select correct panel:";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(479, 274);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(170, 117);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(676, 442);
            this.Controls.Add(this.lblPickCorPanel);
            this.Controls.Add(this.lblPickStrike);
            this.Controls.Add(this.lblPickingNumber);
            this.Controls.Add(this.lblProbabilityTitle);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.lblStrike);
            this.Controls.Add(this.lblOnHand);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblStrikes);
            this.Controls.Add(this.lblPanel4);
            this.Controls.Add(this.lblPanel3);
            this.Controls.Add(this.lblPanel2);
            this.Controls.Add(this.lblPanel1);
            this.Controls.Add(this.lblPanel0);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Label lblPanel0;
        private System.Windows.Forms.Label lblPanel1;
        private System.Windows.Forms.Label lblPanel2;
        private System.Windows.Forms.Label lblPanel3;
        private System.Windows.Forms.Label lblPanel4;
        private System.Windows.Forms.Label lblStrikes;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblOnHand;
        private System.Windows.Forms.Label lblStrike;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.Label lblProbabilityTitle;
        private System.Windows.Forms.Label lblPickingNumber;
        private System.Windows.Forms.Label lblPickStrike;
        private System.Windows.Forms.Label lblPickCorPanel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}