using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalTest1
{
    public partial class Form1 : Form
    {
        //Name: Cameron Nepe
        //ID: 1262199

        //Size of a can of beer in litres
        const double CAN_SIZE = 0.25;
        //Size of a bottle of beer in litres
        const double BOTTLE_SIZE = 0.4;
        //Cost of making a litre of beer
        const decimal BEER_COST = 10.50m;

        //Size of a keg of beer in litres (for bonus task)
        const int KEG_SIZE = 50;
        //Cost of a keg of beer (for bonus task)
        const decimal KEG_COST = 400m;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clear all textboxes and sets the focus to number of cans textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumberOfCans.Text = "";
            textBoxNumberOfBottles.Text = "";
            textBoxBeerForCans.Text = "";
            textBoxBeerForBottles.Text = "";
            textBoxTotalBeer.Text = "";
            textBoxTotalCost.Text = "";
            //Set the focus to number of cans textbox
            textBoxNumberOfCans.Focus();
        }

        /// <summary>
        /// Calculate beer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculateBeer_Click(object sender, EventArgs e)
        {
            // Initiate Variables
            int numberOfCans = 0;
            int numberOfBottles = 0;
            double beerNeededForCans = 0;
            double beerNeededForBottles = 0;
            double totalBeerNeeded = 0;
            decimal totalCost = 0;

            try
            {
                //GET the number of cans ordered 
                numberOfCans = int.Parse(textBoxNumberOfCans.Text);
                Console.WriteLine(numberOfCans);
                //GET the number of bottles ordered
                numberOfBottles = int.Parse(textBoxNumberOfBottles.Text);
                Console.WriteLine(numberOfBottles);

                //CALCULATE the amount of beer needed to fill the cans
                beerNeededForCans = numberOfCans * CAN_SIZE;
                Console.WriteLine(beerNeededForCans);
                //CALCULATE the amount of beer needed to fill the bottles
                beerNeededForBottles = numberOfBottles * BOTTLE_SIZE;
                Console.WriteLine(beerNeededForBottles);
                //CALCULATE the amount of beer needed to fill the bottles
                totalBeerNeeded = beerNeededForCans + beerNeededForBottles;
                Console.WriteLine(totalBeerNeeded);
                //CALCULATE the total cost of the beer required
                totalCost = (decimal)totalBeerNeeded * BEER_COST;
                Console.WriteLine(totalCost);

                //DISPLAY the amount of beer required for cans
                textBoxBeerForCans.Text = beerNeededForCans.ToString();
                //DISPLAY the amount of beer required for bottles
                textBoxBeerForBottles.Text = beerNeededForBottles.ToString();
                //DISPLAY the total amount of beer required
                textBoxTotalBeer.Text = totalBeerNeeded.ToString();
                //DISPLAY the total cost of the beer
                textBoxTotalCost.Text = totalCost.ToString("N3");
            }
            catch (Exception ex)
            {
                //Display Error Message
                MessageBox.Show(ex.Message);
                //Clear all the textboxes and set the focus to number of cans
                textBoxNumberOfCans.Text = "";
                textBoxNumberOfBottles.Text = "";
                textBoxBeerForCans.Text = "";
                textBoxBeerForBottles.Text = "";
                textBoxTotalBeer.Text = "";
                textBoxTotalCost.Text = "";
                //Set the focus to number of cans textbox
                textBoxNumberOfCans.Focus();
            }
        }
    }
}
