/*
 * APP NAME: Sharp Mail Order - ORDER FORM
 * AUTHOR NAME: Adam Sinclair
 * AUTHOR ID: 200321984
 * APP CREATION DATE: September 20th 2016
 * APP DESCRIPTION: 
 *    A small form application that takes in employee information, # of hours worked, and the total sales amount.
 *    A Calculate button will determine the amount of sales bonus an employee receives.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Assignment1
{
    public partial class MailSplashScreen : Form
    {

        /// CONSTRUCTOR ---------------------------------------------------------------------------
        public MailSplashScreen()
        {
            InitializeComponent();
        }

        // EVENT HANDLERS -------------------------------------------------------------------------
        private void MailSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void MainSplashScreenTimer_Tick(object sender, EventArgs e)
        {
            // Create new MailOrderForm and display it
            MailOrderForm _mailOrderForm = new MailOrderForm();
            _mailOrderForm.Show();

            // Hide current splash screen and stop the timer
            this.Hide();
            MainSplashScreenTimer.Stop();
        }
    }
}
