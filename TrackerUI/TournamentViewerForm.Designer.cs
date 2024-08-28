namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.Windows.Forms.Label roundLabel;
            System.Windows.Forms.Label teamOneName;
            System.Windows.Forms.Label teamOneScoreLabel;
            System.Windows.Forms.Label teamTwoName;
            System.Windows.Forms.Label teamTwoScoreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneScoreText = new System.Windows.Forms.TextBox();
            this.teamTwoScoreText = new System.Windows.Forms.TextBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            roundLabel = new System.Windows.Forms.Label();
            teamOneName = new System.Windows.Forms.Label();
            teamOneScoreLabel = new System.Windows.Forms.Label();
            teamTwoName = new System.Windows.Forms.Label();
            teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roundLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            roundLabel.Location = new System.Drawing.Point(38, 149);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new System.Drawing.Size(113, 46);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamOneName.ForeColor = System.Drawing.SystemColors.HotTrack;
            teamOneName.Location = new System.Drawing.Point(567, 247);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new System.Drawing.Size(211, 46);
            teamOneName.TabIndex = 7;
            teamOneName.Text = "<team One>";
            teamOneName.Click += new System.EventHandler(this.teamOneName_Click);
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamOneScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            teamOneScoreLabel.Location = new System.Drawing.Point(525, 305);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new System.Drawing.Size(106, 46);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamTwoName.ForeColor = System.Drawing.SystemColors.HotTrack;
            teamTwoName.Location = new System.Drawing.Point(567, 476);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new System.Drawing.Size(208, 46);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team Two>";
            teamTwoName.Click += new System.EventHandler(this.teamTwoName_Click);
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamTwoScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            teamTwoScoreLabel.Location = new System.Drawing.Point(528, 540);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new System.Drawing.Size(106, 46);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tournamentLabel.CausesValidation = false;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentLabel.Location = new System.Drawing.Point(34, 45);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(255, 60);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament:";
            this.tournamentLabel.Click += new System.EventHandler(this.tournamentLabel_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.BackColor = System.Drawing.SystemColors.Window;
            this.tournamentName.CausesValidation = false;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentName.Location = new System.Drawing.Point(297, 45);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(178, 60);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            this.tournamentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(180, 149);
            this.roundDropDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(277, 45);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(180, 209);
            this.unplayedOnlyCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(169, 32);
            this.unplayedOnlyCheckBox.TabIndex = 5;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchupListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 31;
            this.matchupListBox.Location = new System.Drawing.Point(45, 273);
            this.matchupListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(412, 312);
            this.matchupListBox.TabIndex = 6;
            // 
            // teamOneScoreText
            // 
            this.teamOneScoreText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreText.ForeColor = System.Drawing.Color.Orange;
            this.teamOneScoreText.Location = new System.Drawing.Point(651, 309);
            this.teamOneScoreText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teamOneScoreText.Name = "teamOneScoreText";
            this.teamOneScoreText.Size = new System.Drawing.Size(158, 43);
            this.teamOneScoreText.TabIndex = 9;
            // 
            // teamTwoScoreText
            // 
            this.teamTwoScoreText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreText.ForeColor = System.Drawing.Color.Orange;
            this.teamTwoScoreText.Location = new System.Drawing.Point(651, 540);
            this.teamTwoScoreText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teamTwoScoreText.Name = "teamTwoScoreText";
            this.teamTwoScoreText.Size = new System.Drawing.Size(158, 43);
            this.teamTwoScoreText.TabIndex = 12;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.versusLabel.Location = new System.Drawing.Point(645, 393);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(90, 46);
            this.versusLabel.TabIndex = 13;
            this.versusLabel.Text = "-VS-";
            this.versusLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.LimeGreen;
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.White;
            this.scoreButton.Location = new System.Drawing.Point(838, 393);
            this.scoreButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(135, 53);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "Submit";
            this.scoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 614);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreText);
            this.Controls.Add(teamTwoScoreLabel);
            this.Controls.Add(teamTwoName);
            this.Controls.Add(this.teamOneScoreText);
            this.Controls.Add(teamOneScoreLabel);
            this.Controls.Add(teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.tournamentLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.TextBox teamOneScoreText;
        private System.Windows.Forms.TextBox teamTwoScoreText;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

