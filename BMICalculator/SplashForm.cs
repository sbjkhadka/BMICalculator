using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Project Name: BMI Calculator
/// Submiteed By: Subarna Bijaya Khadka
/// Student#: 300988937
/// Last Modified: July 26, 2019
/// This application takes height and weight in Metric or Imperial units and calculates BMI from these data
/// </summary>
namespace BMICalculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// called when timer has ticked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(10);
            if (progressBar.Value == 60)
            {
                SplashTimer.Enabled = false;
                Program.Forms[FormName.BMI_FORM].Show();
                Hide();
            }
            
        }
        /// <summary>
        /// Called when splash form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
