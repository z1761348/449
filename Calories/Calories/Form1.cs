using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void FatCalories()
        {
                const int ConvFat = 9; // unit used to find the fat calories
                int fCalories;
                int tFCal;

                int.TryParse(fatGrams.Text, out fCalories); // making an int
                tFCal = fCalories * ConvFat; // the actual calculation of the number they entered multiplied by 9

            totalFatCalories.Text = tFCal.ToString(); // convert to a string so it will be accepted in the box
        }

        public void CarbCalories()
        {
            const int ConvCarb = 4; //the unit used to find the carb calories
            int CCalories;
            int tCCal;

            int.TryParse(carbGrams.Text, out CCalories); // needed for the below step which multiplies 4 by the carbs
            tCCal = CCalories * ConvCarb;

            totalCarbCalories.Text = tCCal.ToString();

        }

        public void calcButton_Click(object sender, EventArgs e) // ending step to show the calories on the form
        {

            CarbCalories();
            FatCalories();
        }

        private void button1_Click(object sender, EventArgs e) // closes the app
        {
            this.Close();
        }
    }
}
