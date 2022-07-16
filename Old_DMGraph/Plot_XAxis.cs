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
    public partial class Plot_XAxis : Form
    {
        public Plot_XAxis()
        {
            InitializeComponent();
        }



        #region "Write to File Methods"

        //*******************************************************
        //Write to File Methods
        //*******************************************************        

        public void methodSaveToPreference1()
        {

            using (StreamWriter sw3 = new StreamWriter("Graphing/Preference1.dat"))
            {

                //Handle Empty Text Boxes
                if (this.textStartMonth.Text == "")
                    this.textStartMonth.Text = "1";
                if (this.textStartDay.Text == "")
                    this.textStartDay.Text = "1";
                if (this.textStartYear.Text == "")
                    this.textStartYear.Text = "1974";
                if (this.textEndMonth.Text == "")
                    this.textEndMonth.Text = "12";
                if (this.textEndDay.Text == "")
                    this.textEndDay.Text = "31";
                if (this.textEndYear.Text == "")
                    this.textEndYear.Text = "1974";


                sw3.WriteLine("**********************************************");
                sw3.WriteLine("***************BEGIN**************************");
                sw3.WriteLine("DRAINMOD Graphing Utility Settings");
                sw3.WriteLine(">>>Graphing/Preference1.dat<<<");
                sw3.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                sw3.WriteLine("**********************************************");
                sw3.WriteLine("**********************************************");
                
                sw3.WriteLine("X AXIS -----");
                //Start
                sw3.WriteLine(this.textStartMonth.Text + "/" + this.textStartDay.Text + "/" + this.textStartYear.Text);
                //End
                sw3.WriteLine(this.textEndMonth.Text + "/" + this.textEndDay.Text + "/" + this.textEndYear.Text); 


                //Clean up and close file
                sw3.Flush();
                sw3.Close();

            }//close writer

        }//Close Method


        public void methodSaveToPreference2()
        {
            //Handle Empty Text Boxes
            if (this.textLabelFontSize.Text == "")
                this.textLabelFontSize.Text = "12";
            if (this.textScaleFontSize.Text == "")
                this.textScaleFontSize.Text = "12";
            if (this.textMajorGridThickness.Text == "")
                this.textMajorGridThickness.Text = "4";
            if (this.textMinorGridThickness.Text == "")
                this.textMinorGridThickness.Text = "4";

            
            using (StreamWriter sw4 = new StreamWriter("Graphing/XAxis.dat"))
            {
                sw4.WriteLine("X AXIS ------");
                //-------------------------------------------------------
                sw4.WriteLine("TITLE---");
                //Display
                sw4.WriteLine(Convert.ToString(this.checkDisplayLabel.Checked));
                //Label
                sw4.WriteLine(this.textLabel.Text);
                //Font
                if (this.radioLabelArial.Checked == true)
                {
                    sw4.WriteLine("Arial");
                }
                if (this.radioLabelVerdana.Checked == true)
                {
                    sw4.WriteLine("Verdana");
                }
                if (this.radioLabelTrebuchet.Checked == true)
                {
                    sw4.WriteLine("Trebuchet");
                }
                if (this.radioLabelTimes.Checked == true)
                {
                    sw4.WriteLine("Times New Roman");
                }
                if (this.radioLabelGeorgia.Checked == true)
                {
                    sw4.WriteLine("Georgia");
                }
                //Font Size
                sw4.WriteLine(this.textLabelFontSize.Text);
                //Font Style
                if (this.radioLabelRegular.Checked == true)
                {
                    sw4.WriteLine("Regular");
                }
                if (this.radioLabelBold.Checked == true)
                {
                    sw4.WriteLine("Bold");
                }
                sw4.WriteLine(Convert.ToString(this.checkLabelItalics.Checked));
                sw4.WriteLine(Convert.ToString(this.checkLabelUnderline.Checked));

                sw4.WriteLine("SCALE---");
                //Format
                if (this.radioScalemmddyyyy.Checked == true)
                {
                    sw4.WriteLine("dd-M-yyyy");
                }
                if (this.radioscaleMonthyyyy.Checked == true)
                {
                    sw4.WriteLine("y");
                }
                if (this.radioScaleddMonthyyyy.Checked == true)
                {
                    sw4.WriteLine("dd-MMM-yyyy");
                }
                if (this.radioScaleddMonth.Checked == true)
                {
                    sw4.WriteLine("dd-MMM");
                }
                if (this.radioScaleYear.Checked == true)
                {
                    sw4.WriteLine("yyyy");
                }
                //Font
                if (this.radioScaleArial.Checked == true)
                {
                    sw4.WriteLine("Arial");
                }
                if (this.radioScaleVerdana.Checked == true)
                {
                    sw4.WriteLine("Verdana");
                }
                if (this.radioScaleTrebuchet.Checked == true)
                {
                    sw4.WriteLine("Trebuchet");
                }
                if (this.radioScaleTimes.Checked == true)
                {
                    sw4.WriteLine("Times New Roman");
                }
                if (this.radioScaleGeorgia.Checked == true)
                {
                    sw4.WriteLine("Georgia");
                }
                //Font Size
                sw4.WriteLine(this.textScaleFontSize.Text);
                //Font Style
                if (this.radioScaleRegular.Checked == true)
                {
                    sw4.WriteLine("Regular");
                }
                if (this.radioScaleBold.Checked == true)
                {
                    sw4.WriteLine("Bold");
                }
                sw4.WriteLine(Convert.ToString(this.checkScaleItalics.Checked));
                sw4.WriteLine(Convert.ToString(this.checkScaleUnderline.Checked));



                sw4.WriteLine("TIC MARKS---");
                //Major--
                //Marks Opposite
                sw4.WriteLine(Convert.ToString(this.checkMajorTicOpposite.Checked));
                //Marks Inside
                sw4.WriteLine(Convert.ToString(this.checkMajorTicInside.Checked)); 
                //Marks Outside
                sw4.WriteLine(Convert.ToString(this.checkMajorTicOutside.Checked)); 

                //Minor--
                //Auto Calc Size
                //Marks Opposite
                sw4.WriteLine(Convert.ToString(this.checkMinorTicOpposite.Checked));
                //Marks Inside
                sw4.WriteLine(Convert.ToString(this.checkMinorTicInside.Checked));
                //Marks Outside
                sw4.WriteLine(Convert.ToString(this.checkMinorTicOutside.Checked)); 


                sw4.WriteLine("GRID LINES---");
                //Major--
                //Display
                sw4.WriteLine(Convert.ToString(this.checkMajorGridDisplay.Checked));
                //Thickness
                sw4.WriteLine(this.textMajorGridThickness.Text);
                //Color
                if (this.radioMajorGridBlack.Checked == true)
                {
                    sw4.WriteLine("Black");
                }
                if (this.radioMajorGridGray.Checked == true)
                {
                    sw4.WriteLine("Gray");
                }
                if (this.radioMajorGridDarkGray.Checked == true)
                {
                    sw4.WriteLine("DarkGray");
                }
                if (this.radioMajorGridLightGray.Checked == true)
                {
                    sw4.WriteLine("LightGray");
                }

                //Minor--
                //Display
                sw4.WriteLine(Convert.ToString(this.checkMinorGridDisplay.Checked));
                //Thickness
                sw4.WriteLine(this.textMinorGridThickness.Text);
                //Color
                if (this.radioMinorGridBlack.Checked == true)
                {
                    sw4.WriteLine("Black");
                }
                if (this.radioMinorGridGray.Checked == true)
                {
                    sw4.WriteLine("Gray");
                }
                if (this.radioMinorGridDarkGray.Checked == true)
                {
                    sw4.WriteLine("DarkGray");
                }
                if (this.radioMinorGridLightGray.Checked == true)
                {
                    sw4.WriteLine("LightGray");
                }

                
                //Clean up and close file
                sw4.Flush();
                sw4.Close();

            }//close writer



        }//Close Method

        #endregion


        #region "Keypress"

        private void textLabelFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textLabelFontSize.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLabelFontSize.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLabelFontSize.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textLabelFontSize.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textLabelFontSize.Text.Length == 1 && Convert.ToDouble(this.textLabelFontSize.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textLabelFontSize.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textScaleFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textScaleFontSize.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textScaleFontSize.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textScaleFontSize.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textScaleFontSize.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textScaleFontSize.Text.Length == 1 && Convert.ToDouble(this.textScaleFontSize.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textScaleFontSize.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textMajorGridThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textMajorGridThickness.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textMajorGridThickness.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textMajorGridThickness.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textMajorGridThickness.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textMajorGridThickness.Text.Length == 1 && Convert.ToDouble(this.textMajorGridThickness.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textMajorGridThickness.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textMinorGridThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textMinorGridThickness.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textMinorGridThickness.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textMinorGridThickness.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textMinorGridThickness.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textMinorGridThickness.Text.Length == 1 && Convert.ToDouble(this.textMinorGridThickness.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textMinorGridThickness.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }


        private void textStartMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textStartMonth.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textStartMonth.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textStartMonth.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textStartMonth.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textStartMonth.Text.Length == 1 && Convert.ToDouble(this.textStartMonth.Text) >= 1 && e.KeyChar > '2') flag = true;
            //if (textStartMonth.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textEndMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textEndMonth.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textEndMonth.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textEndMonth.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textEndMonth.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textEndMonth.Text.Length == 1 && Convert.ToDouble(this.textEndMonth.Text) >= 1 && e.KeyChar > '2') flag = true;
            //if (textEndMonth.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textEndDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textEndDay.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textEndDay.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textEndDay.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textEndDay.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textEndDay.Text.Length == 1 && Convert.ToDouble(this.textEndDay.Text) > 3 && e.KeyChar > '0') flag = true;
            //if (textEndDay.Text.Length == 1 && Convert.ToDouble(this.textEndDay.Text) == 3 && e.KeyChar > '1') flag = true;
            //if (textEndDay.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textStartDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textStartDay.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textStartDay.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textStartDay.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textStartDay.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textStartDay.Text.Length == 1 && Convert.ToDouble(this.textStartDay.Text) > 3 && e.KeyChar > '0') flag = true;
            //if (textStartDay.Text.Length == 1 && Convert.ToDouble(this.textStartDay.Text) == 3 && e.KeyChar > '1') flag = true;
            //if (textStartDay.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textStartYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textStartYear.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textStartYear.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textStartYear.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textStartYear.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textStartYear.Text.Length == 1 && Convert.ToDouble(this.textStartYear.Text) > 3 && e.KeyChar > '0') flag = true;
            //if (textStartYear.Text.Length == 1 && Convert.ToDouble(this.textStartYear.Text) == 3 && e.KeyChar > '1') flag = true;
            //if (textStartYear.Text.Length == 4 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textEndYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textEndYear.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textEndYear.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textEndYear.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textEndYear.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textEndYear.Text.Length == 1 && Convert.ToDouble(this.textEndYear.Text) > 3 && e.KeyChar > '0') flag = true;
            //if (textEndYear.Text.Length == 1 && Convert.ToDouble(this.textEndYear.Text) == 3 && e.KeyChar > '1') flag = true;
            //if (textEndYear.Text.Length == 4 && e.KeyChar >= '0') flag = true;
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
            StreamReader prefs1 = new StreamReader("Graphing/Preference1.dat");

            prefs1.ReadLine();//sw3.WriteLine("**********************************************");
            prefs1.ReadLine();//sw3.WriteLine("***************BEGIN**************************");
            prefs1.ReadLine();//sw3.WriteLine("DRAINMOD Graphing Utility Settings");
            prefs1.ReadLine();//sw3.WriteLine(">>>Graphing/Preference1.dat<<<");
            prefs1.ReadLine();//sw3.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
            prefs1.ReadLine();//sw3.WriteLine("**********************************************");
            prefs1.ReadLine();//sw3.WriteLine("**********************************************");

            prefs1.ReadLine();//sw3.WriteLine("X AXIS -----");

            //Start
            //sw3.WriteLine(this.textStartMonth.Text + "/" + this.textStartDay.Text + "/" + this.textStartYear.Text);
            // Use the comma character to separate GRH items
            char[] sep = { '/' }; 
            string line1;         
            // Read one line of data at a time until the end of file
            line1 = prefs1.ReadLine();
            string[] items = line1.Split(sep);
            this.textStartMonth.Text = items[0];
            this.textStartDay.Text = items[1];
            this.textStartYear.Text = items[2];

            //End
            //sw3.WriteLine(this.textEndMonth.Text + "/" + this.textEndDay.Text + "/" + this.textEndYear.Text);
            // Use the comma character to separate GRH items
            char[] sep2 = { ',' };
            string line2;
            // Read one line of data at a time until the end of file
            line2 = prefs1.ReadLine();
            string[] items2 = line2.Split(sep);
            this.textEndMonth.Text = items2[0];
            this.textEndDay.Text = items2[1];
            this.textEndYear.Text = items2[2];
            
            //-------------------------------------------------------
            //------------------------------------------------------- 

            //Clean up and close file
            prefs1.Close();


        }
        
        
        
        public void methodReadFromPreference2()
        {
            StreamReader prefs = new StreamReader("Graphing/XAxis.dat");

            prefs.ReadLine();//sw4.WriteLine("X AXIS ------");
            //-------------------------------------------------------
            prefs.ReadLine();//sw4.WriteLine("TITLE---");
            //Display
            this.checkDisplayLabel.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkDisplayLabel.Checked));
            //Label
            this.textLabel.Text = prefs.ReadLine();//sw4.WriteLine(this.textLabel.Text);
            //Font
            string sLabelFont = prefs.ReadLine();
            switch (sLabelFont)
            {
                case "Arial":
                    this.radioLabelArial.Checked = true;
                    break;
                case "Verdana":
                    this.radioLabelVerdana.Checked = true;
                    break;
                case "Trebuchet":
                    this.radioLabelTrebuchet.Checked = true;
                    break;
                case "Times New Roman":
                    this.radioLabelTimes.Checked = true;
                    break;
                case "Georgia":
                    this.radioLabelGeorgia.Checked = true;
                    break;
                default:
                    break;

            }
            //Font Size
            this.textLabelFontSize.Text = prefs.ReadLine();//sw4.WriteLine(this.textLabelFontSize.Text);

            //Font Style
            string sLabelFontStyle = prefs.ReadLine();
            switch (sLabelFontStyle)
            {
                case "Regular":
                    this.radioLabelRegular.Checked = true;
                    break;
                case "Bold":
                    this.radioLabelBold.Checked = true;
                    break;
                default:
                    break;

            }

            this.checkLabelItalics.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkLabelItalics.Checked));
            this.checkLabelUnderline.Checked = Convert.ToBoolean(prefs.ReadLine());// sw4.WriteLine(Convert.ToString(this.checkLabelUnderline.Checked));

            prefs.ReadLine();//sw4.WriteLine("SCALE---");
            //Format
            string sScaleDate = prefs.ReadLine();
            switch (sScaleDate)
            {
                case "dd-M-yyyy":
                    this.radioScalemmddyyyy.Checked = true;
                    break;
                case "y":
                    this.radioscaleMonthyyyy.Checked = true;
                    break;
                case "dd-MMM-yyyy":
                    this.radioScaleddMonthyyyy.Checked = true;
                    break;
                case "dd-MMM":
                    this.radioScaleddMonth.Checked = true;
                    break;
                case "yyyy":
                    this.radioScaleYear.Checked = true;
                    break;
                default:
                    break;

            }

            //Font
            string sScaleFont = prefs.ReadLine();
            switch (sScaleFont)
            {
                case "Arial":
                    this.radioScaleArial.Checked = true;
                    break;
                case "Verdana":
                    this.radioScaleVerdana.Checked = true;
                    break;
                case "Trebuchet":
                    this.radioScaleTrebuchet.Checked = true;
                    break;
                case "Times New Roman":
                    this.radioScaleTimes.Checked = true;
                    break;
                case "Georgia":
                    this.radioScaleGeorgia.Checked = true;
                    break;
                default:
                    break;

            }

            //Font Size
            this.textScaleFontSize.Text = prefs.ReadLine();//sw4.WriteLine(this.textScaleFontSize.Text);
            //Font Style
            string sScaleFontStyle = prefs.ReadLine();
            switch (sScaleFontStyle)
            {
                case "Regular":
                    this.radioScaleRegular.Checked = true;
                    break;
                case "Bold":
                    this.radioScaleBold.Checked = true;
                    break;
                default:
                    break;

            }

            this.checkScaleItalics.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkScaleItalics.Checked));
            this.checkScaleUnderline.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkScaleUnderline.Checked));



            prefs.ReadLine();//sw4.WriteLine("TIC MARKS---");
            //Major--
            this.checkMajorTicOpposite.Checked = Convert.ToBoolean(prefs.ReadLine());
            this.checkMajorTicInside.Checked = Convert.ToBoolean(prefs.ReadLine());
            this.checkMajorTicOutside.Checked = Convert.ToBoolean(prefs.ReadLine());

            //Minor--
            //Auto Calc Size
            this.checkMinorTicOpposite.Checked = Convert.ToBoolean(prefs.ReadLine());
            this.checkMinorTicInside.Checked = Convert.ToBoolean(prefs.ReadLine());
            this.checkMinorTicOutside.Checked = Convert.ToBoolean(prefs.ReadLine());

            prefs.ReadLine();//sw4.WriteLine("GRID LINES---");
            //Major--
            //Display
            this.checkMajorGridDisplay.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkMajorGridDisplay.Checked));
           //Thickness
            this.textMajorGridThickness.Text = prefs.ReadLine();//sw4.WriteLine(this.textMajorGridThickness.Text);
            //Color
            string sMajorGridColor = prefs.ReadLine();
            switch (sMajorGridColor)
            {
                case "Black":
                    this.radioMajorGridBlack.Checked = true;
                    break;
                case "Gray":
                    this.radioMajorGridGray.Checked = true;
                    break;
                case "DarkGray":
                    this.radioMajorGridDarkGray.Checked = true;
                    break;
                case "LightGray":
                    this.radioMajorGridLightGray.Checked = true;
                    break;
                default:
                    break;

            }


            //Minor--
            //Display
            this.checkMinorGridDisplay.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkMinorGridDisplay.Checked));
            //Thickness
            this.textMinorGridThickness.Text = prefs.ReadLine();//sw4.WriteLine(this.textMinorGridThickness.Text);
            //Color
            string sMinorGridColor = prefs.ReadLine();
            switch (sMinorGridColor)
            {
                case "Black":
                    this.radioMinorGridBlack.Checked = true;
                    break;
                case "Gray":
                    this.radioMinorGridGray.Checked = true;
                    break;
                case "DarkGray":
                    this.radioMinorGridDarkGray.Checked = true;
                    break;
                case "LightGray":
                    this.radioMinorGridLightGray.Checked = true;
                    break;
                default:
                    break;

            }


            //Clean up and close file
            prefs.Close();





        } //Close Method



        #endregion


    }//close class
}//close namespace
