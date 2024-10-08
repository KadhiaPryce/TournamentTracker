﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void placeNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameTextBox.Text,
                    placeNumberValueTextBox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTextBox.Text);

                foreach (I_Database_Connection database in GlobalConfiguration.Connections)
                {
                    database.CreatePrize(model);
                }

                placeNameTextBox.Text = " ";
                placeNumberValueTextBox.Text = "0";
                prizeAmountTextBox.Text = "0";
                prizePercentageTextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("Invalid Information has been detected in this form. " +
                    "\nPlease check your entries and try again.");
            }


        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValueTextBox.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(prizePercentageTextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }


            return output;
        }
    }

}
