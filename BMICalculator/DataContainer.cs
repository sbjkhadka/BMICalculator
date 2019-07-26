using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BMICalculator
{
    static class DataContainer
    {
        //Max and Min values of height and weight in imperical and metric system
        public static double MaxHeightImperial = 100; 
        public static double MinHeightImperial = 20;
        public static double MaxHeightMetric = 2.5; 
        public static double MinHeightMetric = 0.5;
        public static double MaxWeightImperial = 450; 
        public static double MinWeightImperial = 45;
        public static double MaxWeightMetric = 200; 
        public static double MinWeightMetric = 20;

        //Error Messages related to textbox validation
        public static string NotANumberError = "Error: Not a Number";
        public static string FieldBlankError = "Error: Field Blank";
        public static string DataOutOfRangeError = "Error: Data out of range";

        //Error Messages related to Character Validation
        public static string DecimalAlreadyExistsError = "Error: Decimal already exists";
        public static string BlankMessage = "";

        //Color Definition
        public static Color OkColor = Color.LightGreen;
        public static Color ErrorColor = Color.Red;
        public static Color DefaultColor = Color.White;

        public static Color UnderWeightColor = Color.Yellow;
        public static Color NormalColor = Color.LimeGreen;
        public static Color OverweightColor = Color.MistyRose;
        public static Color ObeseColor = Color.OrangeRed;

        //Label texts
        public static string HeightLabelImperial = "My Height (in)";
        public static string HeightLabelMetric = "My Height (m)";
        public static string WeightLabelImperial = "My Weight (lb)";
        public static string WeightLabelMetric = "My Weight (kg)";

        //BMI Messages
        public static string GenaralMessage = "Your BMI is ";
        public static string Underweight = "\r\n\r\nUnderweight\r\n"+GenaralMessage+"Less than 18.5";
        public static string Normal = "\r\n\r\nNormal\r\n"+GenaralMessage + "Between 18.5 and 24.9";
        public static string Overweight = "\r\n\r\nOverweight\r\n"+GenaralMessage + "Between 25 and 29.9";
        public static string Obese = "\r\n\r\nObese\r\n"+GenaralMessage + "beyond 30";

    }
}
