using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Graphing_DRAINMOD
{
    public partial class Plot_WaterLoss : Form
    {
        public Plot_WaterLoss()
        {
            InitializeComponent();
        }
        #region "Write to File Methods"

        //*******************************************************
        //Write to File Methods
        //*******************************************************        

        public void methodSaveToPreference1()
        {

            using (StreamWriter sw3 = new StreamWriter("Graphing/Hydrology_Prefs1.dat",true))
            {


                sw3.WriteLine("WATER LOSS----------");

                //Is Displayed
                sw3.WriteLine(Convert.ToString(this.checkDisplay.Checked));

                //Axis
                if (this.radioPrimary.Checked == true)
                {
                    sw3.WriteLine("Primary");
                }
                if (this.radioSecondary.Checked == true)
                {
                    sw3.WriteLine("Secondary");
                }

                //Plot Type
                if (this.radioDailyLine.Checked == true)
                {
                    sw3.WriteLine("Daily_Line");
                }
                if (this.radioDailyBar.Checked == true)
                {
                    sw3.WriteLine("Daily_Bar");
                }
                if (this.radioDailyScatter.Checked == true)
                {
                    sw3.WriteLine("Daily_Scatter");
                }
                if (this.radioMonthlyLine.Checked == true)
                {
                    sw3.WriteLine("Monthly_Line");
                }
                if (this.radioMonthlyBar.Checked == true)
                {
                    sw3.WriteLine("Monthly_Bar");
                }
                if (this.radioMonthlyScatter.Checked == true)
                {
                    sw3.WriteLine("Monthly_Scatter");
                }
                if (this.radioYearlyLine.Checked == true)
                {
                    sw3.WriteLine("Yearly_Line");
                }
                if (this.radioYearlyBar.Checked == true)
                {
                    sw3.WriteLine("Yearly_Bar");
                }
                if (this.radioYearlyScatter.Checked == true)
                {
                    sw3.WriteLine("Yearly_Scatter");
                }
                if (this.radioCumulativeLine.Checked == true)
                {
                    sw3.WriteLine("Cumulative_Line");
                }
                if (this.radioCumulativeBar.Checked == true)
                {
                    sw3.WriteLine("Cumulative_Bar");
                }
                if (this.radioCumulativeScatter.Checked == true)
                {
                    sw3.WriteLine("Cumulative_Scatter");
                }

                //Clean up and close file
                sw3.Flush();
                sw3.Close();

            }//close writer

        }//Close Method


        public void methodSaveToPreference2()
        {

            //Handle Empty Text Boxes
            if (this.textLineThickness.Text == "")
                this.textLineThickness.Text = "4";
            if (this.textSymbolSize.Text == "")
                this.textSymbolSize.Text = "4";



            using (StreamWriter sw4 = new StreamWriter("Graphing/WaterLoss.dat"))
            {


                sw4.WriteLine("WATER LOSS----------");
                //-------------------------------------------------------
                sw4.WriteLine("Line Plots-----");

                //Smooth Line
                sw4.WriteLine(Convert.ToString(this.checkSmoothLine.Checked));

                //Line Thickness
                sw4.WriteLine(this.textLineThickness.Text);

                //Line Color
                if (this.radioLineBlack.Checked == true)
                {
                    sw4.WriteLine("Black");
                }
                if (this.radioLineBlue.Checked == true)
                {
                    sw4.WriteLine("Blue");
                }
                if (this.radioLineDarkGray.Checked == true)
                {
                    sw4.WriteLine("DarkGray");
                }
                if (this.radioLineGray.Checked == true)
                {
                    sw4.WriteLine("Gray");
                }
                if (this.radioLineGreen.Checked == true)
                {
                    sw4.WriteLine("Green");
                }
                if (this.radioLineLightGray.Checked == true)
                {
                    sw4.WriteLine("LightGray");
                }
                if (this.radioLineOrange.Checked == true)
                {
                    sw4.WriteLine("Orange");
                }
                if (this.radioLinePink.Checked == true)
                {
                    sw4.WriteLine("Pink");
                }
                if (this.radioLinePurple.Checked == true)
                {
                    sw4.WriteLine("Purple");
                }
                if (this.radioLineRed.Checked == true)
                {
                    sw4.WriteLine("Red");
                }
                if (this.radioLineViolet.Checked == true)
                {
                    sw4.WriteLine("Violet");
                }
                if (this.radioLineYellow.Checked == true)
                {
                    sw4.WriteLine("Yellow");
                }

                //Display Symbol
                sw4.WriteLine(Convert.ToString(this.checkDisplaySymbol.Checked));

                //Symbol Size
                sw4.WriteLine(this.textSymbolSize.Text);

                //Symbol Type
                if (this.radioSquare.Checked == true)
                {
                    sw4.WriteLine("Square");
                }
                if (this.radioTriangle.Checked == true)
                {
                    sw4.WriteLine("Triangle");
                }
                if (this.radioCircle.Checked == true)
                {
                    sw4.WriteLine("Circle");
                }


                sw4.WriteLine("Bar Plots-----");



                //Color
                if (this.radioBarBlack.Checked == true)
                {
                    sw4.WriteLine("Black");
                }
                if (this.radioBarBlue.Checked == true)
                {
                    sw4.WriteLine("Blue");
                }
                if (this.radioBarDarkGray.Checked == true)
                {
                    sw4.WriteLine("DarkGray");
                }
                if (this.radioBarGray.Checked == true)
                {
                    sw4.WriteLine("Gray");
                }
                if (this.radioBarGreen.Checked == true)
                {
                    sw4.WriteLine("Green");
                }
                if (this.radioBarLightGray.Checked == true)
                {
                    sw4.WriteLine("LightGray");
                }
                if (this.radioBarOrange.Checked == true)
                {
                    sw4.WriteLine("Orange");
                }
                if (this.radioBarPink.Checked == true)
                {
                    sw4.WriteLine("Pink");
                }
                if (this.radioBarPurple.Checked == true)
                {
                    sw4.WriteLine("Purple");
                }
                if (this.radioBarRed.Checked == true)
                {
                    sw4.WriteLine("Red");
                }
                if (this.radioBarViolet.Checked == true)
                {
                    sw4.WriteLine("Violet");
                }
                if (this.radioBarYellow.Checked == true)
                {
                    sw4.WriteLine("Yellow");
                }




                //Clean up and close file
                sw4.Flush();
                sw4.Close();

            }//close writer



        }//Close Method

        #endregion

        #region "Keypress"

        private void textLineThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textLineThickness.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLineThickness.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLineThickness.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textLineThickness.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textLineThickness.Text.Length == 1 && Convert.ToDouble(this.textLineThickness.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textLineThickness.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textSymbolSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textSymbolSize.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textSymbolSize.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textSymbolSize.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textSymbolSize.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textSymbolSize.Text.Length == 1 && Convert.ToDouble(this.textSymbolSize.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textSymbolSize.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }



        #endregion



        #region "Read from File Methods"

        //*******************************************************
        //Read from File Methods
        //******************************************************* 

        public void methodReadFromPreference1()
        {
            StreamReader prefs1 = new StreamReader("Graphing/Hydrology_Prefs1.dat");

            //Read through Water table info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();

            //Read through Dry zone info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            //Read through surface storage info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            //Read through rainfall info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            //Read through infiltration info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            //Read through evaporation info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            //Read through drainage info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();
            //Read through surface runoff info
            prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine(); prefs1.ReadLine();




            prefs1.ReadLine();//Variable title

            //Is Displayed
            this.checkDisplay.Checked = Convert.ToBoolean(prefs1.ReadLine());//sw3.WriteLine(Convert.ToString(this.checkDisplay.Checked));

            //Axis
            string sAxis = prefs1.ReadLine();
            switch (sAxis)
            {
                case "Primary":
                    this.radioPrimary.Checked = true;
                    break;
                case "Secondary":
                    this.radioSecondary.Checked = true;
                    break;
                default:
                    break;

            }

            //Plot Type
            string sPlotType = prefs1.ReadLine();
            switch (sPlotType)
            {
                case "Daily_Line":
                    this.radioDailyLine.Checked = true;
                    break;
                case "Daily_Bar":
                    this.radioDailyBar.Checked = true;
                    break;
                case "Daily_Scatter":
                    this.radioDailyScatter.Checked = true;
                    break;
                case "Monthly_Line":
                    this.radioMonthlyLine.Checked = true;
                    break;
                case "Monthly_Bar":
                    this.radioMonthlyBar.Checked = true;
                    break;
                case "Monthly_Scatter":
                    this.radioMonthlyScatter.Checked = true;
                    break;
                case "Yearly_Line":
                    this.radioYearlyLine.Checked = true;
                    break;
                case "Yearly_Bar":
                    this.radioYearlyBar.Checked = true;
                    break;
                case "Yearly_Scatter":
                    this.radioYearlyScatter.Checked = true;
                    break;
                case "Cumulative_Line":
                    this.radioCumulativeLine.Checked = true;
                    break;
                case "Cumulative_Bar":
                    this.radioCumulativeBar.Checked = true;
                    break;
                case "Cumulative_Scatter":
                    this.radioCumulativeScatter.Checked = true;
                    break;
                default:
                    break;

            }

            //-------------------------------------------------------
            //------------------------------------------------------- 

            //Clean up and close file
            prefs1.Close();


        }//Close Method


        public void methodReadFromPreference2()
        {
            StreamReader prefs = new StreamReader("Graphing/WaterLoss.dat");


            prefs.ReadLine();//variable title
            //-------------------------------------------------------
            prefs.ReadLine();//sw4.WriteLine("Line Plots-----");

            //Smooth Line
            this.checkSmoothLine.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkSmoothLine.Checked));

            //Line Thickness
            this.textLineThickness.Text = prefs.ReadLine();//sw4.WriteLine(this.textLineThickness.Text);

            //Line Color
            string sLineColor = prefs.ReadLine();
            switch (sLineColor)
            {
                case "Black":
                    this.radioLineBlack.Checked = true;
                    break;
                case "Blue":
                    this.radioLineBlue.Checked = true;
                    break;
                case "DarkGray":
                    this.radioLineDarkGray.Checked = true;
                    break;
                case "Gray":
                    this.radioLineGray.Checked = true;
                    break;
                case "Green":
                    this.radioLineGreen.Checked = true;
                    break;
                case "LightGray":
                    this.radioLineLightGray.Checked = true;
                    break;
                case "Orange":
                    this.radioLineOrange.Checked = true;
                    break;
                case "Pink":
                    this.radioLinePink.Checked = true;
                    break;
                case "Purple":
                    this.radioLinePurple.Checked = true;
                    break;
                case "Red":
                    this.radioLineRed.Checked = true;
                    break;
                case "Violet":
                    this.radioLineViolet.Checked = true;
                    break;
                case "Yellow":
                    this.radioLineYellow.Checked = true;
                    break;
                default:
                    break;

            }

            //Display Symbol
            this.checkDisplaySymbol.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkDisplaySymbol.Checked));

            //Symbol Size
            this.textSymbolSize.Text = prefs.ReadLine();//sw4.WriteLine(this.textSymbolSize.Text);

            //Symbol Type
            string sSymbolType = prefs.ReadLine();
            switch (sSymbolType)
            {
                case "Square":
                    this.radioSquare.Checked = true;
                    break;
                case "Triangle":
                    this.radioTriangle.Checked = true;
                    break;
                case "Circle":
                    this.radioCircle.Checked = true;
                    break;
                default:
                    break;
            }

            prefs.ReadLine(); //sw4.WriteLine("Bar Plots-----");

            //Color
            string sBarColor = prefs.ReadLine();
            switch (sBarColor)
            {
                case "Black":
                    this.radioBarBlack.Checked = true;
                    break;
                case "Blue":
                    this.radioBarBlue.Checked = true;
                    break;
                case "DarkGray":
                    this.radioBarDarkGray.Checked = true;
                    break;
                case "Gray":
                    this.radioBarGray.Checked = true;
                    break;
                case "Green":
                    this.radioBarGreen.Checked = true;
                    break;
                case "LightGray":
                    this.radioBarLightGray.Checked = true;
                    break;
                case "Orange":
                    this.radioBarOrange.Checked = true;
                    break;
                case "Pink":
                    this.radioBarPink.Checked = true;
                    break;
                case "Purple":
                    this.radioBarPurple.Checked = true;
                    break;
                case "Red":
                    this.radioBarRed.Checked = true;
                    break;
                case "Violet":
                    this.radioBarViolet.Checked = true;
                    break;
                case "Yellow":
                    this.radioBarYellow.Checked = true;
                    break;
                default:
                    break;

            }


            //Clean up and close file
            prefs.Close();





        }//Close Method


        #endregion


    }//Close Class
}//Close Namespace
