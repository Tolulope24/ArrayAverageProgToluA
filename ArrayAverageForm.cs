using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayAverageProgToluA
{
    public partial class frmArrayAverage : Form
    {
        // declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverage()
        {
            InitializeComponent();
        }

        private void frmArrayAverage_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // decalre local variables 
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            // Clear Items in List Box
            this.lstArrayList.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // GENERATE A NEW RANDOM NUMBER
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);
                // assign the random numbers to the cell at position counter in the array
                arrayOfNumbers[counter] = randomNumber;
                // add the random number to the list
                this.lstArrayList.Items.Add(randomNumber);
                // refresh the form
                this.Refresh();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double average;
            double sum;
            int counter;

            // calculate the sum of all the values in the array 
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }
            // Calculate the average of the valuse in the array
            average = sum / arrayOfNumbers.Length;
            // display the average in the lable
            this.lblAnswer.Text = "Average: " + average;

        }
    }
}
