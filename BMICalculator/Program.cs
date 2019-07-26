using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    /// <summary>
    /// enum that contains list of forms in the application
    /// this is used later as an index to switch between forms
    /// </summary>
    enum FormName
    {
        SPLASH_FORM,
        BMI_FORM
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Dictionary<FormName, Form> Forms;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM,new SplashForm());
            Forms.Add(FormName.BMI_FORM,new BMICalculatorForm());
            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
