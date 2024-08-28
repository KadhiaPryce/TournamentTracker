namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.loadExistingTournamentGroupBox = new System.Windows.Forms.GroupBox();
            this.loadExistingTournamentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tournamentDashboardLabel.CausesValidation = false;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(198, 37);
            this.tournamentDashboardLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(461, 60);
            this.tournamentDashboardLabel.TabIndex = 28;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            this.tournamentDashboardLabel.Click += new System.EventHandler(this.createPrizeLabel_Click);
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(57, 64);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(493, 45);
            this.loadExistingTournamentDropDown.TabIndex = 30;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.White;
            this.loadTournamentButton.Location = new System.Drawing.Point(146, 129);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(304, 49);
            this.loadTournamentButton.TabIndex = 31;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            this.loadTournamentButton.Click += new System.EventHandler(this.loadTournamentButton_Click);
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
            this.createTournamentButton.Location = new System.Drawing.Point(182, 394);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(493, 51);
            this.createTournamentButton.TabIndex = 32;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // loadExistingTournamentGroupBox
            // 
            this.loadExistingTournamentGroupBox.Controls.Add(this.loadExistingTournamentDropDown);
            this.loadExistingTournamentGroupBox.Controls.Add(this.loadTournamentButton);
            this.loadExistingTournamentGroupBox.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentGroupBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingTournamentGroupBox.Location = new System.Drawing.Point(137, 137);
            this.loadExistingTournamentGroupBox.Name = "loadExistingTournamentGroupBox";
            this.loadExistingTournamentGroupBox.Size = new System.Drawing.Size(587, 207);
            this.loadExistingTournamentGroupBox.TabIndex = 33;
            this.loadExistingTournamentGroupBox.TabStop = false;
            this.loadExistingTournamentGroupBox.Text = "Load Existing Tournament";
            this.loadExistingTournamentGroupBox.Enter += new System.EventHandler(this.loadExistingTournamentGroupBox_Enter);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 485);
            this.Controls.Add(this.loadExistingTournamentGroupBox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.loadExistingTournamentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.GroupBox loadExistingTournamentGroupBox;
    }
}