namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.placeNumberValueTextBox = new System.Windows.Forms.TextBox();
            this.placeNumberValueLabel = new System.Windows.Forms.Label();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountTexbox = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.createPrizeLabel.CausesValidation = false;
            this.createPrizeLabel.Font = new System.Drawing.Font("Segoe UI Light", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createPrizeLabel.Location = new System.Drawing.Point(54, 27);
            this.createPrizeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(247, 60);
            this.createPrizeLabel.TabIndex = 27;
            this.createPrizeLabel.Text = "Create Prize";
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
            this.createPrizeButton.Location = new System.Drawing.Point(133, 451);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(342, 46);
            this.createPrizeButton.TabIndex = 57;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // placeNumberValueTextBox
            // 
            this.placeNumberValueTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberValueTextBox.Location = new System.Drawing.Point(291, 123);
            this.placeNumberValueTextBox.Name = "placeNumberValueTextBox";
            this.placeNumberValueTextBox.Size = new System.Drawing.Size(302, 47);
            this.placeNumberValueTextBox.TabIndex = 50;
            this.placeNumberValueTextBox.Text = "0";
            this.placeNumberValueTextBox.TextChanged += new System.EventHandler(this.placeNameTextBox_TextChanged);
            // 
            // placeNumberValueLabel
            // 
            this.placeNumberValueLabel.AutoSize = true;
            this.placeNumberValueLabel.BackColor = System.Drawing.SystemColors.Window;
            this.placeNumberValueLabel.CausesValidation = false;
            this.placeNumberValueLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNumberValueLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.placeNumberValueLabel.Location = new System.Drawing.Point(57, 126);
            this.placeNumberValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.placeNumberValueLabel.Name = "placeNumberValueLabel";
            this.placeNumberValueLabel.Size = new System.Drawing.Size(195, 41);
            this.placeNumberValueLabel.TabIndex = 49;
            this.placeNumberValueLabel.Text = "Place Number";
            this.placeNumberValueLabel.Click += new System.EventHandler(this.placeNumberLabel_Click);
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameTextBox.Location = new System.Drawing.Point(291, 187);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(302, 47);
            this.placeNameTextBox.TabIndex = 59;
            this.placeNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.placeNameLabel.CausesValidation = false;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.placeNameLabel.Location = new System.Drawing.Point(57, 193);
            this.placeNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(167, 41);
            this.placeNameLabel.TabIndex = 58;
            this.placeNameLabel.Text = "Place Name";
            this.placeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // prizeAmountTexbox
            // 
            this.prizeAmountTexbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountTexbox.Location = new System.Drawing.Point(291, 251);
            this.prizeAmountTexbox.Name = "prizeAmountTexbox";
            this.prizeAmountTexbox.Size = new System.Drawing.Size(302, 47);
            this.prizeAmountTexbox.TabIndex = 61;
            this.prizeAmountTexbox.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.BackColor = System.Drawing.SystemColors.Window;
            this.prizeAmountLabel.CausesValidation = false;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.prizeAmountLabel.Location = new System.Drawing.Point(57, 257);
            this.prizeAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(189, 41);
            this.prizeAmountLabel.TabIndex = 60;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageTextBox
            // 
            this.prizePercentageTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageTextBox.Location = new System.Drawing.Point(291, 379);
            this.prizePercentageTextBox.Name = "prizePercentageTextBox";
            this.prizePercentageTextBox.Size = new System.Drawing.Size(302, 47);
            this.prizePercentageTextBox.TabIndex = 63;
            this.prizePercentageTextBox.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.BackColor = System.Drawing.SystemColors.Window;
            this.prizePercentageLabel.CausesValidation = false;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.prizePercentageLabel.Location = new System.Drawing.Point(57, 385);
            this.prizePercentageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(225, 41);
            this.prizePercentageLabel.TabIndex = 62;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.orLabel.Location = new System.Drawing.Point(284, 317);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(77, 37);
            this.orLabel.TabIndex = 64;
            this.orLabel.Text = "-OR-";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 547);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageTextBox);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountTexbox);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameTextBox);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.placeNumberValueTextBox);
            this.Controls.Add(this.placeNumberValueLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.TextBox placeNumberValueTextBox;
        private System.Windows.Forms.Label placeNumberValueLabel;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountTexbox;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizePercentageTextBox;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
    }
}