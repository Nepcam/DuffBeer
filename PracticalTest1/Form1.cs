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
    }
}
