namespace Graphing_DRAINMOD
{
    partial class Water_Table_Pref
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCloseAndApply = new System.Windows.Forms.Button();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.comboWaterTableDepthType = new System.Windows.Forms.ComboBox();
            this.label155 = new System.Windows.Forms.Label();
            this.radioWaterTableDepthSecondary = new System.Windows.Forms.RadioButton();
            this.label134 = new System.Windows.Forms.Label();
            this.radioWaterTableDepthPrimary = new System.Windows.Forms.RadioButton();
            this.label135 = new System.Windows.Forms.Label();
            this.checkWaterTableDepthDisplay = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.checkWaterTableDepthDisplayBarLabel = new System.Windows.Forms.CheckBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.comboWaterTableDepthBarWidth = new System.Windows.Forms.ComboBox();
            this.comboWaterTableDepthBarColor = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboWaterTableDepthSymbolType = new System.Windows.Forms.ComboBox();
            this.checkWaterTableDepthSmoothLine = new System.Windows.Forms.CheckBox();
            this.checkWaterTableDepthFillArea = new System.Windows.Forms.CheckBox();
            this.checkWaterTableDepthDisplaySymbol = new System.Windows.Forms.CheckBox();
            this.label137 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.comboWaterTableDepthGradientAngle = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.checkWaterTableDepthApplyGradient = new System.Windows.Forms.CheckBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.comboWaterTableDepthSymbolSize = new System.Windows.Forms.ComboBox();
            this.comboWaterTableDepthFillColor2 = new System.Windows.Forms.ComboBox();
            this.label88 = new System.Windows.Forms.Label();
            this.comboWaterTableDepthFillColor1 = new System.Windows.Forms.ComboBox();
            this.comboWaterTableDepthLineThickness = new System.Windows.Forms.ComboBox();
            this.comboWaterTableDepthLineColor = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox20.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(451, 413);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCloseAndApply
            // 
            this.buttonCloseAndApply.Location = new System.Drawing.Point(556, 413);
            this.buttonCloseAndApply.Name = "buttonCloseAndApply";
            this.buttonCloseAndApply.Size = new System.Drawing.Size(111, 23);
            this.buttonCloseAndApply.TabIndex = 3;
            this.buttonCloseAndApply.Text = "Close and Apply";
            this.buttonCloseAndApply.UseVisualStyleBackColor = true;
            this.buttonCloseAndApply.Click += new System.EventHandler(this.buttonCloseAndApply_Click);
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.comboWaterTableDepthType);
            this.groupBox20.Controls.Add(this.label155);
            this.groupBox20.Controls.Add(this.radioWaterTableDepthSecondary);
            this.groupBox20.Controls.Add(this.label134);
            this.groupBox20.Controls.Add(this.radioWaterTableDepthPrimary);
            this.groupBox20.Controls.Add(this.label135);
            this.groupBox20.Controls.Add(this.checkWaterTableDepthDisplay);
            this.groupBox20.ForeColor = System.Drawing.Color.Black;
            this.groupBox20.Location = new System.Drawing.Point(27, 25);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(413, 90);
            this.groupBox20.TabIndex = 2;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "General";
            // 
            // comboWaterTableDepthType
            // 
            this.comboWaterTableDepthType.FormattingEnabled = true;
            this.comboWaterTableDepthType.Items.AddRange(new object[] {
            "Daily_Line",
            "Daily_Scatter",
            "Daily_Bar",
            "Monthly_Line",
            "Monthly_Scatter",
            "Monthly_Bar",
            "Yearly_Line",
            "Yearly_Scatter",
            "Yearly_Bar",
            "Cumulative_Line",
            "Cumulative_Scatter",
            "Cumulative_Bar"});
            this.comboWaterTableDepthType.Location = new System.Drawing.Point(260, 50);
            this.comboWaterTableDepthType.Name = "comboWaterTableDepthType";
            this.comboWaterTableDepthType.Size = new System.Drawing.Size(124, 21);
            this.comboWaterTableDepthType.TabIndex = 107;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(307, 26);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(31, 13);
            this.label155.TabIndex = 106;
            this.label155.Text = "Type";
            // 
            // radioWaterTableDepthSecondary
            // 
            this.radioWaterTableDepthSecondary.AutoSize = true;
            this.radioWaterTableDepthSecondary.Location = new System.Drawing.Point(161, 50);
            this.radioWaterTableDepthSecondary.Name = "radioWaterTableDepthSecondary";
            this.radioWaterTableDepthSecondary.Size = new System.Drawing.Size(76, 17);
            this.radioWaterTableDepthSecondary.TabIndex = 105;
            this.radioWaterTableDepthSecondary.TabStop = true;
            this.radioWaterTableDepthSecondary.Text = "Secondary";
            this.radioWaterTableDepthSecondary.UseVisualStyleBackColor = true;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(29, 26);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(41, 13);
            this.label134.TabIndex = 94;
            this.label134.Text = "Display";
            // 
            // radioWaterTableDepthPrimary
            // 
            this.radioWaterTableDepthPrimary.AutoSize = true;
            this.radioWaterTableDepthPrimary.Location = new System.Drawing.Point(96, 50);
            this.radioWaterTableDepthPrimary.Name = "radioWaterTableDepthPrimary";
            this.radioWaterTableDepthPrimary.Size = new System.Drawing.Size(59, 17);
            this.radioWaterTableDepthPrimary.TabIndex = 104;
            this.radioWaterTableDepthPrimary.TabStop = true;
            this.radioWaterTableDepthPrimary.Text = "Primary";
            this.radioWaterTableDepthPrimary.UseVisualStyleBackColor = true;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(139, 26);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(26, 13);
            this.label135.TabIndex = 95;
            this.label135.Text = "Axis";
            // 
            // checkWaterTableDepthDisplay
            // 
            this.checkWaterTableDepthDisplay.AutoSize = true;
            this.checkWaterTableDepthDisplay.Location = new System.Drawing.Point(43, 53);
            this.checkWaterTableDepthDisplay.Name = "checkWaterTableDepthDisplay";
            this.checkWaterTableDepthDisplay.Size = new System.Drawing.Size(15, 14);
            this.checkWaterTableDepthDisplay.TabIndex = 98;
            this.checkWaterTableDepthDisplay.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.checkWaterTableDepthDisplayBarLabel);
            this.groupBox11.Controls.Add(this.label76);
            this.groupBox11.Controls.Add(this.label74);
            this.groupBox11.Controls.Add(this.label75);
            this.groupBox11.Controls.Add(this.comboWaterTableDepthBarWidth);
            this.groupBox11.Controls.Add(this.comboWaterTableDepthBarColor);
            this.groupBox11.ForeColor = System.Drawing.Color.Black;
            this.groupBox11.Location = new System.Drawing.Point(27, 337);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(413, 99);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Bar Plots";
            // 
            // checkWaterTableDepthDisplayBarLabel
            // 
            this.checkWaterTableDepthDisplayBarLabel.AutoSize = true;
            this.checkWaterTableDepthDisplayBarLabel.Location = new System.Drawing.Point(287, 59);
            this.checkWaterTableDepthDisplayBarLabel.Name = "checkWaterTableDepthDisplayBarLabel";
            this.checkWaterTableDepthDisplayBarLabel.Size = new System.Drawing.Size(15, 14);
            this.checkWaterTableDepthDisplayBarLabel.TabIndex = 101;
            this.checkWaterTableDepthDisplayBarLabel.UseVisualStyleBackColor = true;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(248, 29);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(85, 13);
            this.label76.TabIndex = 100;
            this.label76.Text = "Label with Value";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(147, 29);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(31, 13);
            this.label74.TabIndex = 97;
            this.label74.Text = "Color";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(31, 29);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(35, 13);
            this.label75.TabIndex = 96;
            this.label75.Text = "Width";
            // 
            // comboWaterTableDepthBarWidth
            // 
            this.comboWaterTableDepthBarWidth.FormattingEnabled = true;
            this.comboWaterTableDepthBarWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboWaterTableDepthBarWidth.Location = new System.Drawing.Point(23, 57);
            this.comboWaterTableDepthBarWidth.Name = "comboWaterTableDepthBarWidth";
            this.comboWaterTableDepthBarWidth.Size = new System.Drawing.Size(59, 21);
            this.comboWaterTableDepthBarWidth.TabIndex = 94;
            // 
            // comboWaterTableDepthBarColor
            // 
            this.comboWaterTableDepthBarColor.FormattingEnabled = true;
            this.comboWaterTableDepthBarColor.Items.AddRange(new object[] {
            "Aquamarine",
            "Black",
            "Blue",
            "Brown",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkGray",
            "Gold",
            "Gray",
            "Green",
            "Indigo",
            "Ivory",
            "Lavender",
            "LightBlue",
            "LimeGreen",
            "Magenta",
            "Maroon",
            "MidnightBlue",
            "Navy",
            "Olive",
            "Pink",
            "Plum",
            "Purple",
            "Red",
            "RoyalBlue",
            "Silver",
            "SkyBlue",
            "SlateGray",
            "Tan",
            "Turquoise",
            "Violet",
            "White",
            "Yellow"});
            this.comboWaterTableDepthBarColor.Location = new System.Drawing.Point(113, 57);
            this.comboWaterTableDepthBarColor.Name = "comboWaterTableDepthBarColor";
            this.comboWaterTableDepthBarColor.Size = new System.Drawing.Size(124, 21);
            this.comboWaterTableDepthBarColor.TabIndex = 95;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboWaterTableDepthSymbolType);
            this.groupBox10.Controls.Add(this.checkWaterTableDepthSmoothLine);
            this.groupBox10.Controls.Add(this.checkWaterTableDepthFillArea);
            this.groupBox10.Controls.Add(this.checkWaterTableDepthDisplaySymbol);
            this.groupBox10.Controls.Add(this.label137);
            this.groupBox10.Controls.Add(this.label136);
            this.groupBox10.Controls.Add(this.label133);
            this.groupBox10.Controls.Add(this.comboWaterTableDepthGradientAngle);
            this.groupBox10.Controls.Add(this.label84);
            this.groupBox10.Controls.Add(this.label85);
            this.groupBox10.Controls.Add(this.label83);
            this.groupBox10.Controls.Add(this.checkWaterTableDepthApplyGradient);
            this.groupBox10.Controls.Add(this.label82);
            this.groupBox10.Controls.Add(this.label86);
            this.groupBox10.Controls.Add(this.label79);
            this.groupBox10.Controls.Add(this.label87);
            this.groupBox10.Controls.Add(this.comboWaterTableDepthSymbolSize);
            this.groupBox10.Controls.Add(this.comboWaterTableDepthFillColor2);
            this.groupBox10.Controls.Add(this.label88);
            this.groupBox10.Controls.Add(this.comboWaterTableDepthFillColor1);
            this.groupBox10.Controls.Add(this.comboWaterTableDepthLineThickness);
            this.groupBox10.Controls.Add(this.comboWaterTableDepthLineColor);
            this.groupBox10.ForeColor = System.Drawing.Color.Black;
            this.groupBox10.Location = new System.Drawing.Point(27, 133);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(640, 186);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Line Plots";
            // 
            // comboWaterTableDepthSymbolType
            // 
            this.comboWaterTableDepthSymbolType.FormattingEnabled = true;
            this.comboWaterTableDepthSymbolType.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Diamond"});
            this.comboWaterTableDepthSymbolType.Location = new System.Drawing.Point(443, 54);
            this.comboWaterTableDepthSymbolType.Name = "comboWaterTableDepthSymbolType";
            this.comboWaterTableDepthSymbolType.Size = new System.Drawing.Size(80, 21);
            this.comboWaterTableDepthSymbolType.TabIndex = 103;
            // 
            // checkWaterTableDepthSmoothLine
            // 
            this.checkWaterTableDepthSmoothLine.AutoSize = true;
            this.checkWaterTableDepthSmoothLine.Location = new System.Drawing.Point(43, 60);
            this.checkWaterTableDepthSmoothLine.Name = "checkWaterTableDepthSmoothLine";
            this.checkWaterTableDepthSmoothLine.Size = new System.Drawing.Size(15, 14);
            this.checkWaterTableDepthSmoothLine.TabIndex = 102;
            this.checkWaterTableDepthSmoothLine.UseVisualStyleBackColor = true;
            // 
            // checkWaterTableDepthFillArea
            // 
            this.checkWaterTableDepthFillArea.AutoSize = true;
            this.checkWaterTableDepthFillArea.Location = new System.Drawing.Point(43, 140);
            this.checkWaterTableDepthFillArea.Name = "checkWaterTableDepthFillArea";
            this.checkWaterTableDepthFillArea.Size = new System.Drawing.Size(15, 14);
            this.checkWaterTableDepthFillArea.TabIndex = 100;
            this.checkWaterTableDepthFillArea.UseVisualStyleBackColor = true;
            // 
            // checkWaterTableDepthDisplaySymbol
            // 
            this.checkWaterTableDepthDisplaySymbol.AutoSize = true;
            this.checkWaterTableDepthDisplaySymbol.Location = new System.Drawing.Point(385, 58);
            this.checkWaterTableDepthDisplaySymbol.Name = "checkWaterTableDepthDisplaySymbol";
            this.checkWaterTableDepthDisplaySymbol.Size = new System.Drawing.Size(15, 14);
            this.checkWaterTableDepthDisplaySymbol.TabIndex = 99;
            this.checkWaterTableDepthDisplaySymbol.UseVisualStyleBackColor = true;
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.Location = new System.Drawing.Point(20, 29);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(66, 13);
            this.label137.TabIndex = 97;
            this.label137.Text = "Smooth Line";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.Location = new System.Drawing.Point(346, 29);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(78, 13);
            this.label136.TabIndex = 96;
            this.label136.Text = "Display Symbol";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.Location = new System.Drawing.Point(248, 29);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(54, 13);
            this.label133.TabIndex = 93;
            this.label133.Text = "Line Color";
            // 
            // comboWaterTableDepthGradientAngle
            // 
            this.comboWaterTableDepthGradientAngle.FormattingEnabled = true;
            this.comboWaterTableDepthGradientAngle.Items.AddRange(new object[] {
            "45",
            "90"});
            this.comboWaterTableDepthGradientAngle.Location = new System.Drawing.Point(524, 137);
            this.comboWaterTableDepthGradientAngle.Name = "comboWaterTableDepthGradientAngle";
            this.comboWaterTableDepthGradientAngle.Size = new System.Drawing.Size(74, 21);
            this.comboWaterTableDepthGradientAngle.TabIndex = 72;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(119, 29);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(79, 13);
            this.label84.TabIndex = 91;
            this.label84.Text = "Line Thickness";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(521, 110);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(77, 13);
            this.label85.TabIndex = 71;
            this.label85.Text = "Gradient Angle";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(9, 110);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(99, 13);
            this.label83.TabIndex = 90;
            this.label83.Text = "Fill Area Under Line";
            // 
            // checkWaterTableDepthApplyGradient
            // 
            this.checkWaterTableDepthApplyGradient.AutoSize = true;
            this.checkWaterTableDepthApplyGradient.Location = new System.Drawing.Point(287, 140);
            this.checkWaterTableDepthApplyGradient.Name = "checkWaterTableDepthApplyGradient";
            this.checkWaterTableDepthApplyGradient.Size = new System.Drawing.Size(15, 14);
            this.checkWaterTableDepthApplyGradient.TabIndex = 70;
            this.checkWaterTableDepthApplyGradient.UseVisualStyleBackColor = true;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(451, 29);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(68, 13);
            this.label82.TabIndex = 89;
            this.label82.Text = "Symbol Type";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(257, 110);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(76, 13);
            this.label86.TabIndex = 69;
            this.label86.Text = "Apply Gradient";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(545, 29);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(64, 13);
            this.label79.TabIndex = 88;
            this.label79.Text = "Symbol Size";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(351, 110);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(151, 13);
            this.label87.TabIndex = 68;
            this.label87.Text = "Fill Color 2 - If Gradient Applied";
            // 
            // comboWaterTableDepthSymbolSize
            // 
            this.comboWaterTableDepthSymbolSize.FormattingEnabled = true;
            this.comboWaterTableDepthSymbolSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboWaterTableDepthSymbolSize.Location = new System.Drawing.Point(548, 54);
            this.comboWaterTableDepthSymbolSize.Name = "comboWaterTableDepthSymbolSize";
            this.comboWaterTableDepthSymbolSize.Size = new System.Drawing.Size(59, 21);
            this.comboWaterTableDepthSymbolSize.TabIndex = 87;
            // 
            // comboWaterTableDepthFillColor2
            // 
            this.comboWaterTableDepthFillColor2.FormattingEnabled = true;
            this.comboWaterTableDepthFillColor2.Items.AddRange(new object[] {
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Black",
            "Blue",
            "Brown",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkGray",
            "DarkGreen",
            "Gainsboro",
            "Gold",
            "Gray",
            "Green",
            "GreenYellow",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LightBlue",
            "LightSkyBlue",
            "LightSlateGray ",
            "LimeGreen",
            "Magenta",
            "Maroon",
            "MidnightBlue",
            "Navy",
            "Olive",
            "Pink",
            "Plum",
            "Purple",
            "Red",
            "RoyalBlue",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Tan",
            "Teal",
            "Turquoise",
            "Violet",
            "White",
            "Yellow"});
            this.comboWaterTableDepthFillColor2.Location = new System.Drawing.Point(363, 136);
            this.comboWaterTableDepthFillColor2.Name = "comboWaterTableDepthFillColor2";
            this.comboWaterTableDepthFillColor2.Size = new System.Drawing.Size(124, 21);
            this.comboWaterTableDepthFillColor2.TabIndex = 67;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(154, 110);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(55, 13);
            this.label88.TabIndex = 66;
            this.label88.Text = "Fill Color 1";
            // 
            // comboWaterTableDepthFillColor1
            // 
            this.comboWaterTableDepthFillColor1.FormattingEnabled = true;
            this.comboWaterTableDepthFillColor1.Items.AddRange(new object[] {
            "Aquamarine",
            "Black",
            "Blue",
            "Brown",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkGray",
            "Gold",
            "Gray",
            "Green",
            "Indigo",
            "Ivory",
            "Lavender",
            "LightBlue",
            "LimeGreen",
            "Magenta",
            "Maroon",
            "MidnightBlue",
            "Navy",
            "Olive",
            "Pink",
            "Plum",
            "Purple",
            "Red",
            "RoyalBlue",
            "Silver",
            "SkyBlue",
            "SlateGray",
            "Tan",
            "Turquoise",
            "Violet",
            "White",
            "Yellow"});
            this.comboWaterTableDepthFillColor1.Location = new System.Drawing.Point(122, 136);
            this.comboWaterTableDepthFillColor1.Name = "comboWaterTableDepthFillColor1";
            this.comboWaterTableDepthFillColor1.Size = new System.Drawing.Size(124, 21);
            this.comboWaterTableDepthFillColor1.TabIndex = 65;
            // 
            // comboWaterTableDepthLineThickness
            // 
            this.comboWaterTableDepthLineThickness.FormattingEnabled = true;
            this.comboWaterTableDepthLineThickness.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboWaterTableDepthLineThickness.Location = new System.Drawing.Point(122, 54);
            this.comboWaterTableDepthLineThickness.Name = "comboWaterTableDepthLineThickness";
            this.comboWaterTableDepthLineThickness.Size = new System.Drawing.Size(59, 21);
            this.comboWaterTableDepthLineThickness.TabIndex = 80;
            // 
            // comboWaterTableDepthLineColor
            // 
            this.comboWaterTableDepthLineColor.FormattingEnabled = true;
            this.comboWaterTableDepthLineColor.Items.AddRange(new object[] {
            "Aquamarine",
            "Black",
            "Blue",
            "Brown",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkGray",
            "Gold",
            "Gray",
            "Green",
            "Indigo",
            "Ivory",
            "Lavender",
            "LightBlue",
            "LimeGreen",
            "Magenta",
            "Maroon",
            "MidnightBlue",
            "Navy",
            "Olive",
            "Pink",
            "Plum",
            "Purple",
            "Red",
            "RoyalBlue",
            "Silver",
            "SkyBlue",
            "SlateGray",
            "Tan",
            "Turquoise",
            "Violet",
            "White",
            "Yellow"});
            this.comboWaterTableDepthLineColor.Location = new System.Drawing.Point(209, 54);
            this.comboWaterTableDepthLineColor.Name = "comboWaterTableDepthLineColor";
            this.comboWaterTableDepthLineColor.Size = new System.Drawing.Size(124, 21);
            this.comboWaterTableDepthLineColor.TabIndex = 82;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Water_Table_Pref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(689, 485);
            this.Controls.Add(this.groupBox20);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.buttonCloseAndApply);
            this.Controls.Add(this.buttonCancel);
            this.Name = "Water_Table_Pref";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DRAINMOD Graphing Hydrology Preferences";
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCloseAndApply;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboWaterTableDepthSymbolSize;
        private System.Windows.Forms.ComboBox comboWaterTableDepthLineThickness;
        private System.Windows.Forms.ComboBox comboWaterTableDepthLineColor;
        private System.Windows.Forms.ComboBox comboWaterTableDepthGradientAngle;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.CheckBox checkWaterTableDepthApplyGradient;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.ComboBox comboWaterTableDepthFillColor2;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.ComboBox comboWaterTableDepthFillColor1;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.RadioButton radioWaterTableDepthSecondary;
        private System.Windows.Forms.RadioButton radioWaterTableDepthPrimary;
        private System.Windows.Forms.ComboBox comboWaterTableDepthSymbolType;
        private System.Windows.Forms.CheckBox checkWaterTableDepthSmoothLine;
        private System.Windows.Forms.CheckBox checkWaterTableDepthFillArea;
        private System.Windows.Forms.CheckBox checkWaterTableDepthDisplaySymbol;
        private System.Windows.Forms.CheckBox checkWaterTableDepthDisplay;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox checkWaterTableDepthDisplayBarLabel;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox comboWaterTableDepthBarWidth;
        private System.Windows.Forms.ComboBox comboWaterTableDepthBarColor;
        private System.Windows.Forms.ComboBox comboWaterTableDepthType;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label261;
        private System.Windows.Forms.Label label262;
        private System.Windows.Forms.Label label263;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.Label label265;
        private System.Windows.Forms.Label label266;
        private System.Windows.Forms.Label label267;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label268;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox15;

        



    }
}