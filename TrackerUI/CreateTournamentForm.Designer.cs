namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.Windows.Forms.Label teamPlayersLabel;
            System.Windows.Forms.Label prizeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameTextBox = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeTextBox = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.teamPlayersDeleteSelectedButton = new System.Windows.Forms.Button();
            this.prizeDeleteSelectedButton = new System.Windows.Forms.Button();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            teamPlayersLabel = new System.Windows.Forms.Label();
            prizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamPlayersLabel
            // 
            teamPlayersLabel.AutoSize = true;
            teamPlayersLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            teamPlayersLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            teamPlayersLabel.Location = new System.Drawing.Point(505, 98);
            teamPlayersLabel.Name = "teamPlayersLabel";
            teamPlayersLabel.Size = new System.Drawing.Size(201, 46);
            teamPlayersLabel.TabIndex = 18;
            teamPlayersLabel.Text = "Team Players";
            teamPlayersLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
            // 
            // prizeLabel
            // 
            prizeLabel.AutoSize = true;
            prizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prizeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            prizeLabel.Location = new System.Drawing.Point(505, 381);
            prizeLabel.Name = "prizeLabel";
            prizeLabel.Size = new System.Drawing.Size(102, 46);
            prizeLabel.TabIndex = 20;
            prizeLabel.Text = "Prizes";
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.BackColor = System.Drawing.SystemColors.Window;
            this.createTournamentLabel.CausesValidation = false;
            this.createTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTournamentLabel.Location = new System.Drawing.Point(26, 21);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(377, 60);
            this.createTournamentLabel.TabIndex = 1;
            this.createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameTextBox
            // 
            this.tournamentNameTextBox.Location = new System.Drawing.Point(36, 147);
            this.tournamentNameTextBox.Name = "tournamentNameTextBox";
            this.tournamentNameTextBox.Size = new System.Drawing.Size(358, 43);
            this.tournamentNameTextBox.TabIndex = 2;
            this.tournamentNameTextBox.TextChanged += new System.EventHandler(this.tournamentNameTextBox_TextChanged);
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.entryFeeLabel.CausesValidation = false;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(28, 234);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(152, 46);
            this.entryFeeLabel.TabIndex = 3;
            this.entryFeeLabel.Text = "Entry Fee";
            this.entryFeeLabel.Click += new System.EventHandler(this.entryFeeLabel_Click);
            // 
            // entryFeeTextBox
            // 
            this.entryFeeTextBox.Location = new System.Drawing.Point(186, 234);
            this.entryFeeTextBox.Name = "entryFeeTextBox";
            this.entryFeeTextBox.Size = new System.Drawing.Size(208, 43);
            this.entryFeeTextBox.TabIndex = 4;
            this.entryFeeTextBox.Text = "0";
            this.entryFeeTextBox.TextChanged += new System.EventHandler(this.entryFeeTextBox_TextChanged);
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.BackColor = System.Drawing.SystemColors.Window;
            this.selectTeamLabel.CausesValidation = false;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(28, 325);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(186, 46);
            this.selectTeamLabel.TabIndex = 5;
            this.selectTeamLabel.Text = "Select Team";
            this.selectTeamLabel.Click += new System.EventHandler(this.selectTeamLabel_Click);
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(34, 374);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(360, 45);
            this.selectTeamDropDown.TabIndex = 6;
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.White;
            this.addTeamButton.Location = new System.Drawing.Point(117, 441);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(194, 59);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.White;
            this.createPrizeButton.Location = new System.Drawing.Point(117, 526);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(194, 59);
            this.createPrizeButton.TabIndex = 16;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.Goldenrod;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.White;
            this.createTournamentButton.Location = new System.Drawing.Point(289, 627);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(507, 51);
            this.createTournamentButton.TabIndex = 17;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentPlayersListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 31;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(513, 158);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(283, 188);
            this.tournamentPlayersListBox.TabIndex = 19;
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeListBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 31;
            this.prizeListBox.Location = new System.Drawing.Point(513, 428);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(283, 157);
            this.prizeListBox.TabIndex = 21;
            // 
            // teamPlayersDeleteSelectedButton
            // 
            this.teamPlayersDeleteSelectedButton.BackColor = System.Drawing.Color.Firebrick;
            this.teamPlayersDeleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.teamPlayersDeleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.teamPlayersDeleteSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.teamPlayersDeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamPlayersDeleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamPlayersDeleteSelectedButton.ForeColor = System.Drawing.Color.White;
            this.teamPlayersDeleteSelectedButton.Location = new System.Drawing.Point(826, 217);
            this.teamPlayersDeleteSelectedButton.Name = "teamPlayersDeleteSelectedButton";
            this.teamPlayersDeleteSelectedButton.Size = new System.Drawing.Size(194, 80);
            this.teamPlayersDeleteSelectedButton.TabIndex = 22;
            this.teamPlayersDeleteSelectedButton.Text = "Delete Selected";
            this.teamPlayersDeleteSelectedButton.UseVisualStyleBackColor = false;
            // 
            // prizeDeleteSelectedButton
            // 
            this.prizeDeleteSelectedButton.BackColor = System.Drawing.Color.Firebrick;
            this.prizeDeleteSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.prizeDeleteSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.prizeDeleteSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.prizeDeleteSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prizeDeleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeDeleteSelectedButton.ForeColor = System.Drawing.Color.White;
            this.prizeDeleteSelectedButton.Location = new System.Drawing.Point(826, 464);
            this.prizeDeleteSelectedButton.Name = "prizeDeleteSelectedButton";
            this.prizeDeleteSelectedButton.Size = new System.Drawing.Size(194, 80);
            this.prizeDeleteSelectedButton.TabIndex = 23;
            this.prizeDeleteSelectedButton.Text = "Delete Selected";
            this.prizeDeleteSelectedButton.UseVisualStyleBackColor = false;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tournamentNameLabel.CausesValidation = false;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentNameLabel.Location = new System.Drawing.Point(28, 98);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(283, 46);
            this.tournamentNameLabel.TabIndex = 24;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLink.Location = new System.Drawing.Point(241, 338);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(162, 28);
            this.createNewTeamLink.TabIndex = 25;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New Team";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 705);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.prizeDeleteSelectedButton);
            this.Controls.Add(this.teamPlayersDeleteSelectedButton);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(prizeLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(teamPlayersLabel);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeTextBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameTextBox);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox tournamentNameTextBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeTextBox;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Button teamPlayersDeleteSelectedButton;
        private System.Windows.Forms.Button prizeDeleteSelectedButton;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
    }
}