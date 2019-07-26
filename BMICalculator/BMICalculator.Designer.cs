namespace BMICalculator
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.UnitSelectorTableLayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.WeightTextbox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMIDefinitionTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UnitSelectorTableLayoutpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.ForeColor = System.Drawing.Color.Beige;
            this.MetricRadioButton.Location = new System.Drawing.Point(158, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(79, 38);
            this.MetricRadioButton.TabIndex = 0;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.Click += new System.EventHandler(this.Metric_Clicked);
            // 
            // UnitSelectorTableLayoutpanel
            // 
            this.UnitSelectorTableLayoutpanel.BackColor = System.Drawing.Color.DimGray;
            this.UnitSelectorTableLayoutpanel.ColumnCount = 2;
            this.UnitSelectorTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnitSelectorTableLayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnitSelectorTableLayoutpanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.UnitSelectorTableLayoutpanel.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.UnitSelectorTableLayoutpanel.Location = new System.Drawing.Point(-4, 0);
            this.UnitSelectorTableLayoutpanel.Margin = new System.Windows.Forms.Padding(0);
            this.UnitSelectorTableLayoutpanel.Name = "UnitSelectorTableLayoutpanel";
            this.UnitSelectorTableLayoutpanel.RowCount = 1;
            this.UnitSelectorTableLayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UnitSelectorTableLayoutpanel.Size = new System.Drawing.Size(310, 44);
            this.UnitSelectorTableLayoutpanel.TabIndex = 1;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.Beige;
            this.ImperialRadioButton.Location = new System.Drawing.Point(58, 8);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(94, 28);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.Click += new System.EventHandler(this.Imperial_Clicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MessageLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-4, 45);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 131);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeightLabel.Location = new System.Drawing.Point(87, 14);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(65, 24);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Height";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WeightLabel.Location = new System.Drawing.Point(83, 66);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(69, 24);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "Weight";
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HeightTextbox.Location = new System.Drawing.Point(158, 7);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(93, 38);
            this.HeightTextbox.TabIndex = 2;
            this.HeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightTextbox.Click += new System.EventHandler(this.TextBoxClicked);
            this.HeightTextbox.TextChanged += new System.EventHandler(this.CheckCharacter);
            this.HeightTextbox.Leave += new System.EventHandler(this.ValidateHeightTextBox);
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WeightTextbox.Location = new System.Drawing.Point(158, 59);
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.Size = new System.Drawing.Size(93, 38);
            this.WeightTextbox.TabIndex = 3;
            this.WeightTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightTextbox.Click += new System.EventHandler(this.TextBoxClicked);
            this.WeightTextbox.TextChanged += new System.EventHandler(this.CheckCharacter);
            this.WeightTextbox.Leave += new System.EventHandler(this.ValidateWeightTextBox);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.MessageLabel, 2);
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(3, 104);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(304, 27);
            this.MessageLabel.TabIndex = 4;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Beige;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(158, 5);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(137, 42);
            this.CalculateBMIButton.TabIndex = 3;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ResetButton.BackColor = System.Drawing.Color.Beige;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(16, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(136, 42);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMITextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.BMITextBox, 2);
            this.BMITextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BMITextBox.Location = new System.Drawing.Point(3, 55);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(304, 38);
            this.BMITextBox.TabIndex = 4;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMIDefinitionTextbox
            // 
            this.BMIDefinitionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.BMIDefinitionTextbox, 2);
            this.BMIDefinitionTextbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIDefinitionTextbox.Location = new System.Drawing.Point(3, 94);
            this.BMIDefinitionTextbox.Multiline = true;
            this.BMIDefinitionTextbox.Name = "BMIDefinitionTextbox";
            this.BMIDefinitionTextbox.ReadOnly = true;
            this.BMIDefinitionTextbox.Size = new System.Drawing.Size(304, 165);
            this.BMIDefinitionTextbox.TabIndex = 5;
            this.BMIDefinitionTextbox.Text = "\r\n";
            this.BMIDefinitionTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BMIDefinitionTextbox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.CalculateBMIButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BMITextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ResetButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-4, 178);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 262);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UnitSelectorTableLayoutpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BMICalculatorForm_FormClosed);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.UnitSelectorTableLayoutpanel.ResumeLayout(false);
            this.UnitSelectorTableLayoutpanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TableLayoutPanel UnitSelectorTableLayoutpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.TextBox WeightTextbox;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.TextBox BMIDefinitionTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
    }
}

