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
/// Version: 1.0
/// This application takes height and weight in Metric or Imperial units and calculates BMI from these data
/// </summary>
namespace BMICalculator
{
    enum Selection
    {
        Metric,
        Imperical
    }
    public partial class BMICalculatorForm : Form
    {
        //fields related to textbox validation
        private Selection _selectedUnit; 
        private bool _HeightStatus;
        private bool _WeightStatus;
        private float _Height;
        private float _Weight;
        //fields related to character validation
        private bool _HasDecimal;
        /// <summary>
        /// Property to handle radio button change
        /// </summary>
        private Selection SelectedUnit
        {
            get
            {
                return _selectedUnit;
            }
            set
            {
                _selectedUnit = value;
                
                if (_selectedUnit == Selection.Metric)
                {
                    HeightLabel.Text = DataContainer.HeightLabelMetric;
                    WeightLabel.Text = DataContainer.WeightLabelMetric;
                    HeightTextbox.MaxLength = 4;
                    WeightTextbox.MaxLength = 5;
                }
                else if (_selectedUnit == Selection.Imperical)
                {
                    HeightLabel.Text = DataContainer.HeightLabelImperial;
                    WeightLabel.Text = DataContainer.WeightLabelImperial;
                    HeightTextbox.MaxLength = 5;
                    WeightTextbox.MaxLength = 5;
                }
            }
        }

        
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Called when the BMI Calculator form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            SelectedUnit = Selection.Metric;
            InitializeValues();
        }

        /// <summary>
        /// Initial values of textboxes, labels and fields
        /// </summary>
        private void InitializeValues()
        {
            //CalculateBMIButton.Enabled = true;
            HeightTextbox.Text = "0";
            WeightTextbox.Text = "0";
            BMITextBox.Enabled = false;
            BMITextBox.Text = DataContainer.BlankMessage;
            BMIDefinitionTextbox.Text = DataContainer.BlankMessage;
            BMITextBox.BackColor = DataContainer.DefaultColor;
            BMIDefinitionTextbox.BackColor = DataContainer.DefaultColor;
            HeightTextbox.BackColor = DataContainer.DefaultColor;
            WeightTextbox.BackColor = DataContainer.DefaultColor;
            MessageLabel.Text = DataContainer.BlankMessage;
            _HeightStatus = false;
            _WeightStatus = false;
            _Height = 0;
            _Weight = 0;
            _HasDecimal = false;
            BMIDefinitionTextbox.Text = DataContainer.DefaultMessage;
            BMIDefinitionTextbox.ForeColor = DataContainer.NormalColor;
        }
        /// <summary>
        /// Called when radio button labelled imperial is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Imperial_Clicked(object sender, EventArgs e)
        {
            if (SelectedUnit == Selection.Imperical) { return; }
            SelectedUnit = Selection.Imperical;
            InitializeValues();
        }
        /// <summary>
        /// Called when Metric radio button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metric_Clicked(object sender, EventArgs e)
        {
            if(SelectedUnit == Selection.Metric) { return; }
            SelectedUnit = Selection.Metric;
            InitializeValues();

        }
        /// <summary>
        /// Height textbox validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateHeightTextBox(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool isItANumber = float.TryParse(textBox.Text,out _Height);
           
            if (textBox.Text == "")
            {
                MessageLabel.Text = DataContainer.FieldBlankError;
                FormatErrorSituation(textBox);
            }
            else if (!isItANumber)
            {
                MessageLabel.Text = DataContainer.NotANumberError;
                FormatErrorSituation(textBox);
            }
            else if (_selectedUnit==Selection.Metric)
            {  
                if (!(_Height > DataContainer.MinHeightMetric && _Height < DataContainer.MaxHeightMetric))
                {
                    MessageLabel.Text = DataContainer.DataOutOfRangeError;
                    FormatErrorSituation(textBox);
                }
                else
                {
                    _HeightStatus = true;
                    RemoveError(textBox);

                }
            }
            else if (_selectedUnit == Selection.Imperical)
            {
                if (!(_Height > DataContainer.MinHeightImperial && _Height < DataContainer.MaxHeightImperial))
                {
                    MessageLabel.Text = DataContainer.DataOutOfRangeError;
                    FormatErrorSituation(textBox);
                }
                else
                {
                    _HeightStatus = true;
                    RemoveError(textBox);
                    
                }
            }  
        }
        /// <summary>
        /// clears error label
        /// </summary>
        /// <param name="textBox"></param>
        private void RemoveError(TextBox textBox)
        {
            textBox.BackColor = DataContainer.OkColor;
            MessageLabel.Text = "";
        }
        /// <summary>
        /// Weight textbox validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateWeightTextBox(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            bool isItANumber = float.TryParse(textBox.Text, out _Weight);

            if (textBox.Text == "")
            {
                MessageLabel.Text = DataContainer.FieldBlankError;
                FormatErrorSituation(textBox);
            }
            else if (!isItANumber)
            {
                MessageLabel.Text = DataContainer.NotANumberError;
                FormatErrorSituation(textBox);
            }
            else if (_selectedUnit == Selection.Metric)
            {
                if (!(_Weight > DataContainer.MinWeightMetric && _Weight < DataContainer.MaxWeightMetric))
                {
                    MessageLabel.Text = DataContainer.DataOutOfRangeError;
                    FormatErrorSituation(textBox);
                }
                else
                {
                    _WeightStatus = true;
                    RemoveError(textBox);

                }
            }
            else if (_selectedUnit == Selection.Imperical)
            {
                if (!(_Weight > DataContainer.MinWeightImperial && _Weight < DataContainer.MaxWeightImperial))
                {
                    MessageLabel.Text = DataContainer.DataOutOfRangeError;
                    FormatErrorSituation(textBox);
                }
                else
                {
                    _WeightStatus = true;
                    RemoveError(textBox);
                }
            }
            //if (_HeightStatus && _WeightStatus)
            //{
            //    CalculateBMIButton.Enabled = true;
            //}
        }
        /// <summary>
        /// Actions taken when some error occurs
        /// </summary>
        /// <param name="textBox"></param>
        private void FormatErrorSituation(TextBox textBox)
        {
            MessageLabel.ForeColor = DataContainer.ErrorColor;
            textBox.BackColor = DataContainer.DefaultColor;
            _WeightStatus = false;
        }
        /// <summary>
        /// Textbox click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxClicked(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.BackColor = DataContainer.DefaultColor;
            textBox.Text = "";
        }
        /// <summary>
        /// Calculate BMI textbox click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            BMITextBox.Text = DataContainer.BlankMessage;
            BMITextBox.BackColor = DataContainer.DefaultColor;
            BMIDefinitionTextbox.Text = DataContainer.BlankMessage;
            BMIDefinitionTextbox.BackColor = DataContainer.DefaultColor;
            if(!(_HeightStatus && _WeightStatus))
            {
                MessageLabel.Text = DataContainer.InvalidData;
                MessageLabel.ForeColor = DataContainer.ErrorColor;
                return;
            }

            double BMI = 0;
            if (_selectedUnit == Selection.Imperical)
            {
                BMI = _Weight * 703 / Math.Pow(_Height, 2);
            }
            else if (_selectedUnit == Selection.Metric)
            {
                BMI = _Weight / Math.Pow(_Height, 2);
            }
            BMITextBox.Text = Math.Round(BMI, 2).ToString();
            if (BMI <= 18.5)
            {
                BMITextBox.BackColor = DataContainer.UnderWeightColor;
                BMIDefinitionTextbox.Text = DataContainer.Underweight;
                BMIDefinitionTextbox.ForeColor = DataContainer.UnderWeightColor;
            }else if(BMI>18.5 && BMI <= 24.9)
            {
                BMITextBox.BackColor = DataContainer.NormalColor;
                BMIDefinitionTextbox.Text = DataContainer.Normal;
                BMIDefinitionTextbox.ForeColor = DataContainer.NormalColor;
            }
            else if (BMI > 24.9 && BMI <= 29.9)
            {
                BMITextBox.BackColor = DataContainer.OverweightColor;
                BMIDefinitionTextbox.Text = DataContainer.Overweight;
                BMIDefinitionTextbox.ForeColor = DataContainer.OverweightColor;
            } else
            {
                BMITextBox.BackColor = DataContainer.ObeseColor;
                BMIDefinitionTextbox.Text = DataContainer.Obese;
                BMIDefinitionTextbox.ForeColor = DataContainer.ObeseColor;
            }
            BMIDefinitionTextbox.BackColor = DataContainer.MultiLineResultColor;
          

        }
        /// <summary>
        /// Reset button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            InitializeValues();
        }
        /// <summary>
        /// Event handler for textbox change event 
        /// vaidation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCharacter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            float Number;
            bool isNumber = float.TryParse(textBox.Text, out Number);
            _HasDecimal=(Number % 1 > 0)?true:false; 
            if (!isNumber && textBox.Text!="" && textBox.Text!=".")
            {
                MessageLabel.Text = DataContainer.NotANumberError;
                HightlightRejectedCharacter(textBox);
            }
            else
            {
                MessageLabel.Text = DataContainer.BlankMessage;
            }
            int currentLength = textBox.Text.Length;
            if (currentLength == 0) { return; }
            string currentCharacter = textBox.Text.Substring(currentLength-1, 1);
            if (currentCharacter == ".")
            {
                if (_HasDecimal)
                {
                    MessageLabel.Text = DataContainer.DecimalAlreadyExistsError;

                    FormatErrorSituation(textBox);
                    HightlightRejectedCharacter(textBox);
                }
                else
                {
                    _HasDecimal = true;
                }
            }
        }
        /// <summary>
        /// Invoked when some illegal chacters are entered in textbox
        /// Only numbers and one decimal is allowed
        /// </summary>
        /// <param name="textBox"></param>
        private static void HightlightRejectedCharacter(TextBox textBox)
        {
            textBox.SelectionStart = textBox.Text.Length - 1;
            textBox.SelectionLength = textBox.Text.Length;
        }
        /// <summary>
        /// Exits from the application when the form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
