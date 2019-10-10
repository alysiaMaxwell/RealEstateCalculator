using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Lab_4_1
{
    public partial class realEstateCalculator : Form
    {
            // Class level contants for sales and tax rates 

               private const decimal STATE_SALES_TAX_RATE = 0.06m;
               private const decimal HILLSBORROUGH_SALES_TAX_RATE = 0.01m;
               private const decimal PASCO_SALES_TAX_RATE = 0.00m;
               private const decimal POLK_SALES_TAX_RATE = 0.005m;
               private const decimal RESIDENTIAL_COMMISSION_RATE = 0.06m;
               private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;


             // Class level variables used to calculate totals 

                private decimal propertyPrice = 0m;
                private decimal stateSalesTax = 0m;
                private decimal countySalesTax = 0m;
                private decimal commission = 0m;
                private decimal totalPrice = 0m; 
               

        public realEstateCalculator()
        {
            InitializeComponent();
        }
         
            // Immediately executes when form loads 

        private void realEstateCalculator_Load(object sender, EventArgs e)
        {
            // When the form loads the current date and time will display in the date of sale text box

            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy"); 

        }

                // Save button click event 

        private void saveButton_Click(object sender, EventArgs e)
        {
                // Write Data to external text file 

            try
            {
                StreamWriter outputFile; // Declare stream writer object to write to file 
                outputFile = File.AppendText("Properties.txt"); // Specifies file to write to 

                // Write Data to file 

                outputFile.WriteLine("Date: " + saleDateMaskedTextBox.Text);
                outputFile.WriteLine("Property Price: " + propertyPrice.ToString("C"));
                outputFile.WriteLine("State Sales Tax: " + stateSalesTax.ToString("C"));
                outputFile.WriteLine("County Sales Tax: " + countySalesTax.ToString("C"));
                outputFile.WriteLine("Commission: " + commission.ToString("C"));
                outputFile.WriteLine("Total Price: " + totalPrice.ToString("C"));
                outputFile.WriteLine();  // Blank line to separate properties 
                outputFile.Close();   // Close the file 

                //Displays comfirmation message
                MessageBox.Show("Data successfully saved to file.", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); 


                // Call to method to clear form
                clearForm(); 
            }
            catch (Exception ex)
            {
                // Display error message if there is a problem writing to the file 

                MessageBox.Show(ex.Message);
            }
        }
              
                // Clear button click event 

        private void clearButton_Click(object sender, EventArgs e)
        {
                // Call to clear form method

                   clearForm();
        }
              
                // Exit button click event 

        private void exitButton_Click(object sender, EventArgs e)
        {

                // Close the form 

                   this.Close(); 
        }

                // Residential radio button checked change event 

        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
               // Call to updateTotals method 

                  updateTotals(); 
        }
               // Hillsborough radio button checked change event 

        private void hillsborroughRadioButton_CheckedChanged(object sender, EventArgs e)
        {
               // Call to updateTotals method 

                  updateTotals();
        }

               // Pasco radio button checked change event 

        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {

               // Call to updateTotals method 

                  updateTotals();
        }
             
               // Property price text box event handler 
                
        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {

               // Disable save button until totals updated 

                  saveButton.Enabled = false; 
        }

               // Update property price button 

        private void updatePropertyPriceButton_Click(object sender, EventArgs e)
        {

               // Call to updateTotals method

                  updateTotals();

               // Send focus to the save button 

                  saveButton.Focus(); 
        }

        // Custom method to update totals 

        private void updateTotals()
        {

            // Read the price of property entered by user
            // Try parse handles non-numeric and null values entered 

            if (decimal.TryParse(propertyPriceTextBox.Text, out propertyPrice))
            {

                // Set property price to variable to property price text box 

                propertyPrice = decimal.Parse(propertyPriceTextBox.Text);

                // Calculate state sales tax 

                stateSalesTax = propertyPrice * STATE_SALES_TAX_RATE;

                // Calculate county sales tax based on selected county 

                if (hillsborroughRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBORROUGH_SALES_TAX_RATE;
                }
                else if (pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;
                }
                else if (polkRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * POLK_SALES_TAX_RATE;
                }

                // Calculate commission based on property type

                if (residentialRadioButton.Checked)
                {
                    commission = propertyPrice * RESIDENTIAL_COMMISSION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;
                }

                // Calculate total price 

                totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

                // Format and display calculated numeric values with currency formats

                stateSalesTaxLabel.Text = stateSalesTax.ToString("C");
                countySalesTaxLabel.Text = countySalesTax.ToString("C");
                commissionLabel.Text = commission.ToString("C");
                totalPriceLabel.Text = totalPrice.ToString("C");

                // Verify a price greater than zero has been entered by the user

                if (propertyPrice > 0)
                {
                    // Enable save button
                    saveButton.Enabled = true;
                }

                // if null or non-numeric value is entered for property price

                else
                {
                    // Display error message for incorrect value 

                    MessageBox.Show("You must enter a numeric value for property price." +
                    "\nEnter digits only (no dollar sign) for property price.",
                    "Blank value or non-numeric character entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // Send focus back to property price text box for user to correct data entered 
                    propertyPriceTextBox.Focus();
                }

            }
        }

            // Custom method to clear the form

        private void clearForm()
        {
            // Set form back to the original state 

            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillsborroughRadioButton.Checked = true;
            propertyPriceTextBox.Text = "0.00";
            stateSalesTaxLabel.Text = "0.00";
            countySalesTaxLabel.Text = "0.00";
            commissionLabel.Text = "0.00";
            totalPriceLabel.Text = "0.00";
            saveButton.Enabled = false;    // Disable save button until update method runs 
            propertyPriceTextBox.Focus();  // Send focus back to property price text box 
        }
        
    }


}
