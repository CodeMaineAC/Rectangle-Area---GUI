using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Rectangle Area Finder GUI
 * 12/15/2020
 * Program to find the area of a rectangle. Demostration of Visual Studio
 * Forms and GUI creation
 */
namespace Rectangle_Area___GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Code that runs when the window loads in. 
         * Auto-created when the form is double clicked on
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            //AreaOutputLabel.Visible = false;
        }

        /*
         * Action for what happens when the button is clicked.
         * Auto generated when a button is double clicked in the
         * design tab.
         */
        private void FindAreaButton_Click(object sender, EventArgs e)
        {
            double sideA = Convert.ToDouble(sideATextBox.Text);
            double sideB = Convert.ToDouble(sideBTextBox.Text);

            double area = sideA * sideB;

            AreaOutputLabel.Text = "The area of the room is \n"
                + Convert.ToString(area) + " square units";

            AreaOutputLabel.Visible = true;
        }
    }
}
