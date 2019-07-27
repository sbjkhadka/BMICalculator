using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
/// <summary>
/// Project Name: BMI Calculator
/// Submiteed By: Subarna Bijaya Khadka
/// Student#: 300988937
/// Last Modified: July 26, 2019
/// Version: 1.0
/// This application takes height and weight in Metric or Imperial units and calculates BMI from these data
/// </summary>
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
        public static string InvalidData = "Error: Invalid data";

        //Error Messages related to Character Validation
        public static string DecimalAlreadyExistsError = "Error: Decimal already exists";
        public static string BlankMessage = "";

        //Color Definition
        public static Color OkColor = Color.LightGreen;
        public static Color ErrorColor = Color.Red;
        public static Color DefaultColor = Color.White;

        public static Color UnderWeightColor = Color.Yellow;
        public static Color NormalColor = Color.DarkGreen;
        public static Color OverweightColor = Color.MistyRose;
        public static Color ObeseColor = Color.OrangeRed;
        public static Color MultiLineResultColor = Color.CadetBlue;

        //Label texts
        public static string HeightLabelImperial = "My Height (in)";
        public static string HeightLabelMetric = "My Height (m)";
        public static string WeightLabelImperial = "My Weight (lb)";
        public static string WeightLabelMetric = "My Weight (kg)";

        //BMI Messages
        public static string GenaralMessage = "Your BMI is ";
        public static string Underweight = "\r\nUnderweight\r\n"+GenaralMessage+"Less than 18.5";
        public static string Normal = "\r\nNormal\r\n"+GenaralMessage + "Between 18.5 and 24.9";
        public static string Overweight = "\r\nOverweight\r\n"+GenaralMessage + "Between 25 and 29.9";
        public static string Obese = "\r\nObese\r\n"+GenaralMessage + "beyond 30";

        //Default Message
        public static string DefaultMessage = "\r\nBody mass index (BMI) is a measure of body fat based " +
            "on height and weight that applies to adult men and women.";


        //Current Version
        public static string CurrentVersion = "V1.0";

    }
}
