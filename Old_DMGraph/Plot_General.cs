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
    public partial class Plot_General : Form
    {
        public Plot_General()
        {
            InitializeComponent();

        }


        #region "Write to File Methods"

        //*******************************************************
        //Write to File Methods
        //*******************************************************        

        //NO PREFERENCE1.DAT values are located in this form


        public void methodSaveToPreference2()
        {
            using (StreamWriter sw4 = new StreamWriter("Graphing/General.dat"))
            {
                //Handle Empty Text Boxes
                  if (this.textLabelFontSize.Text == "")
                        this.textLabelFontSize.Text = "12";

                  if (this.textMarginTop.Text == "")
                      this.textMarginTop.Text = "4";
                  if (this.textMarginBottom.Text == "")
                      this.textMarginBottom.Text = "4";
                  if (this.textMarginLeft.Text == "")
                      this.textMarginLeft.Text = "4";
                  if (this.textMarginRight.Text == "")
                      this.textMarginRight.Text = "4";
                  if (this.textBorderThickness.Text == "")
                      this.textBorderThickness.Text = "4";
                
                sw4.WriteLine("**********************************************");
                sw4.WriteLine("***************BEGIN**************************");
                sw4.WriteLine("DRAINMOD Graphing Utility Settings");
                sw4.WriteLine(">>>Graphing/Preference2.dat<<<");
                sw4.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                sw4.WriteLine("**********************************************");
                sw4.WriteLine("**********************************************");

                //-------------------------------------------------------
                sw4.WriteLine("PLOT AREA-----");
                //-------------------------------------------------------

                //Title,Legend,Background
                //-------------------------------------------------------

                sw4.WriteLine("TITLE---");

                //Line 1--
                //Display
                sw4.WriteLine(Convert.ToString(this.checkDisplayLabel.Checked));
                //Label
                sw4.WriteLine(this.textLabel.Text);
                sw4.WriteLine(this.textLabelLine2.Text);
                //Font
                    //Error Check
                    if (this.radioLabelArial.Checked != true && this.radioLabelVerdana.Checked != true && this.radioLabelTrebuchet.Checked != true &&
                             this.radioLabelTimes.Checked != true && this.radioLabelGeorgia.Checked != true)
                    {
                        this.radioLabelArial.Checked = true;
                    }
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
                    //Error Check
                    if (this.radioLabelRegular.Checked != true && this.radioLabelBold.Checked != true)
                        {
                            this.radioLabelRegular.Checked = true;
                        }
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

                
                sw4.WriteLine("LEGEND---");
                //Display
                sw4.WriteLine(Convert.ToString(this.checkDisplayLegend.Checked));
                //Position
                if (this.radioLegendPositionTop.Checked == true)
                {
                    sw4.WriteLine("TopLeft");
                }
                if (this.radioLegendPositionBottom.Checked == true)
                {
                    sw4.WriteLine("BottomLeft");
                }
                if (this.radioLegendPositionTopCenter.Checked == true)
                {
                    sw4.WriteLine("TopCenter");
                }
                if (this.radioLegendPositionBottomCenter.Checked == true)
                {
                    sw4.WriteLine("BottomCenter");
                }
                if (this.radioLegendPositionLeft.Checked == true)
                {
                    sw4.WriteLine("Left");
                }
                if (this.radioLegendPositionRight.Checked == true)
                {
                    sw4.WriteLine("Right");
                }
                //Font
                    //Error Check
                    if (this.radioLegendArial.Checked != true && this.radioLegendVerdana.Checked != true && this.radioLegendTrebuchet.Checked != true &&
                             this.radioLegendTimes.Checked != true && this.radioLegendGeorgia.Checked != true)
                    {
                        this.radioLegendArial.Checked = true;
                    }
                if (this.radioLegendArial.Checked == true)
                {
                    sw4.WriteLine("Arial");
                }
                if (this.radioLegendVerdana.Checked == true)
                {
                    sw4.WriteLine("Verdana");
                }
                if (this.radioLegendTrebuchet.Checked == true)
                {
                    sw4.WriteLine("Trebuchet");
                }
                if (this.radioLegendTimes.Checked == true)
                {
                    sw4.WriteLine("Times New Roman");
                }
                if (this.radioLegendGeorgia.Checked == true)
                {
                    sw4.WriteLine("Georgia");
                }
                //Font Size
                sw4.WriteLine(this.textLegendFontSize.Text);

                //Font Style
                    //Error Check
                    if (this.radioLegendRegular.Checked != true && this.radioLegendBold.Checked != true)
                    {
                        this.radioLegendRegular.Checked = true;
                    }
                if (this.radioLegendRegular.Checked == true)
                {
                    sw4.WriteLine("Regular");
                }
                if (this.radioLegendBold.Checked == true)
                {
                    sw4.WriteLine("Bold");
                }
                sw4.WriteLine(Convert.ToString(this.checkLegendItalics.Checked));
                sw4.WriteLine(Convert.ToString(this.checkLegendUnderline.Checked));

                
                
                sw4.WriteLine("BACKGROUND---");
                //Main Pane--
                //Fill Color 1
                sw4.WriteLine(this.comboBackgroundMainPaneFillColor1.SelectedItem);
                //Apply Gradient
                sw4.WriteLine(Convert.ToString(this.checkBackgroundMainPaneGradient.Checked));
                //Fill Color 2
                sw4.WriteLine(this.comboBackgroundMainPaneFillColor2.SelectedItem);
                //Gradient Angle
                    //Error Check
                    if (this.radioBackgroundMainPane45.Checked != true && this.radioBackgroundMainPane90.Checked != true)
                    {
                        this.radioBackgroundMainPane45.Checked = true;
                    }
                if (this.radioBackgroundMainPane45.Checked == true)
                {
                    sw4.WriteLine("45");
                }
                if (this.radioBackgroundMainPane90.Checked == true)
                {
                    sw4.WriteLine("90");
                }

                //Plot Area--
                //Fill Color 1
                sw4.WriteLine(this.comboBackgroundPlotPaneFillColor1.SelectedItem);
                //Apply Gradient
                sw4.WriteLine(Convert.ToString(this.checkBackgroundPlotPaneGradient.Checked));
                //Fill Color 2
                sw4.WriteLine(this.comboBackgroundPlotPaneFillColor2.SelectedItem);
                 //Gradient Angle
                    //Error Check
                    if (this.radioBackgroundPlotPane45.Checked != true && this.radioBackgroundPlotPane90.Checked != true)
                    {
                        this.radioBackgroundPlotPane45.Checked = true;
                    }
                if (this.radioBackgroundPlotPane45.Checked == true)
                {
                    sw4.WriteLine("45");
                }
                if (this.radioBackgroundPlotPane90.Checked == true)
                {
                    sw4.WriteLine("90");
                }

                sw4.WriteLine("MARGINS---");
                //Top
                sw4.WriteLine(this.textMarginTop.Text);
                //Bottom
                sw4.WriteLine(this.textMarginBottom.Text);
                //Left
                sw4.WriteLine(this.textMarginLeft.Text);
                //Right
                sw4.WriteLine(this.textMarginRight.Text);

                sw4.WriteLine("BORDER---");
                //Display
                sw4.WriteLine(Convert.ToString(this.checkDisplayBorder.Checked));
                //Thickness
                sw4.WriteLine(this.textBorderThickness.Text);  
                //Color
                    //Error Check
                    if (this.radioBorderBlack.Checked != true && this.radioBorderGray.Checked != true
                        && this.radioBorderDarkGray.Checked != true && this.radioBorderLightGray.Checked != true)
                    {
                        this.radioBorderBlack.Checked = true;
                    }
                if (this.radioBorderBlack.Checked == true)
                {
                    sw4.WriteLine("Black");
                }
                if (this.radioBorderGray.Checked == true)
                {
                    sw4.WriteLine("Gray");
                }
                if (this.radioBorderDarkGray.Checked == true)
                {
                    sw4.WriteLine("DarkGray");
                }
                if (this.radioBorderLightGray.Checked == true)
                {
                    sw4.WriteLine("LightGray");
                }


                //-------------------------------------------------------
                //-------------------------------------------------------

                
                //Clean up and close file
                sw4.Flush();
                sw4.Close();

            }//close writer



        }



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





        private void textLegendFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textLegendFontSize.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textLegendFontSize.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textLegendFontSize.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textLegendFontSize.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textLegendFontSize.Text.Length == 1 && Convert.ToDouble(this.textLegendFontSize.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textLegendFontSize.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

      



        private void textMarginTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textMarginTop.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textMarginTop.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textMarginTop.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textMarginTop.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textMarginTop.Text.Length == 1 && Convert.ToDouble(this.textMarginTop.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textMarginTop.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textMarginBottom_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textMarginBottom.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textMarginBottom.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textMarginBottom.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textMarginBottom.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textMarginBottom.Text.Length == 1 && Convert.ToDouble(this.textMarginBottom.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textMarginBottom.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textMarginLeft_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textMarginLeft.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textMarginLeft.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textMarginLeft.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textMarginLeft.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textMarginLeft.Text.Length == 1 && Convert.ToDouble(this.textMarginLeft.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textMarginLeft.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textMarginRight_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textMarginRight.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textMarginRight.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textMarginRight.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textMarginRight.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textMarginRight.Text.Length == 1 && Convert.ToDouble(this.textMarginRight.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textMarginRight.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        private void textBorderThickness_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool dot = false;
            bool flag = false;
            if (e.KeyChar == '\b') return;
            if (e.KeyChar == '.') flag = true;
            if (e.KeyChar == '.' & textBorderThickness.Text.IndexOf('.') > 0) dot = true;
            if (e.KeyChar < '-' | e.KeyChar > '9' | dot == true) flag = true;
            if (textBorderThickness.Text.Length > 0 & e.KeyChar == '-') flag = true;
            if (textBorderThickness.Text.Length == 0 & e.KeyChar == '-') flag = true;
            if (textBorderThickness.Text.Length == 0 && e.KeyChar == '0') flag = true;
            //if (textBorderThickness.Text.Length == 1 && Convert.ToDouble(this.textBorderThickness.Text) >= 2 && e.KeyChar > '0') flag = true;
            //if (textBorderThickness.Text.Length == 2 && e.KeyChar >= '0') flag = true;
            if (e.KeyChar == '/') flag = true;
            if (flag == true) e.Handled = true;
        }

        #endregion


        #region "Read from File Methods"

        //*******************************************************
        //Read from File Methods
        //*******************************************************        

        //NO PREFERENCE1.DAT values are located in this form


        public void methodReadFromPreference2()
        {
            StreamReader prefs = new StreamReader("Graphing/General.dat");
            
                prefs.ReadLine();//sw4.WriteLine("**********************************************");
                prefs.ReadLine();//sw4.WriteLine("***************BEGIN**************************");
                prefs.ReadLine();//sw4.WriteLine("DRAINMOD Graphing Utility Settings");
                prefs.ReadLine();//sw4.WriteLine(">>>Graphing/Preference2.dat<<<");
                prefs.ReadLine();//sw4.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                prefs.ReadLine();//sw4.WriteLine("**********************************************");
                prefs.ReadLine();//sw4.WriteLine("**********************************************");

                //-------------------------------------------------------
                prefs.ReadLine();//sw4.WriteLine("PLOT AREA-----");
                //-------------------------------------------------------

                //Title,Legend,Background
                //-------------------------------------------------------

                prefs.ReadLine();//sw4.WriteLine("TITLE---");

                //Line 1--
                //Display
                this.checkDisplayLabel.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkDisplayLabel.Checked));
                //Label
                this.textLabel.Text = prefs.ReadLine();//sw4.WriteLine(this.textLabel.Text);
                //LabelLine2
                this.textLabelLine2.Text = prefs.ReadLine();//sw4.WriteLine(this.textLabelLine2.Text);
                //Font
                string sLine1Font = prefs.ReadLine();
                switch(sLine1Font)
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
                string sLine1FontStyle = prefs.ReadLine();
                switch(sLine1FontStyle)
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

  
                this.checkLabelItalics.Checked = Convert.ToBoolean(prefs.ReadLine());//  sw4.WriteLine(Convert.ToString(this.checkLabelItalics.Checked));
                this.checkLabelUnderline.Checked  = Convert.ToBoolean(prefs.ReadLine());// sw4.WriteLine(Convert.ToString(this.checkLabelUnderline.Checked));

               
                prefs.ReadLine();//sw4.WriteLine("LEGEND---");
                //Display
                this.checkDisplayLegend.Checked = Convert.ToBoolean(prefs.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkDisplayLegend.Checked));

                //Position

                string sPosition = prefs.ReadLine();
                switch (sPosition)
                {   
                    case "TopLeft":
                        this.radioLegendPositionTop.Checked = true;
                        break;
                    case "BottomLeft":
                        this.radioLegendPositionBottom.Checked = true;
                        break;
                    case "TopCenter":
                        this.radioLegendPositionTopCenter.Checked = true;
                        break;
                    case "BottomCenter":
                        this.radioLegendPositionBottomCenter.Checked = true;
                        break;
                    case "Left":
                        this.radioLegendPositionLeft.Checked = true;
                        break;
                    case "Right":
                        this.radioLegendPositionRight.Checked = true;
                        break;
                    default:
                        break;

                }

  
                //Font
                string sLegendFont = prefs.ReadLine();
                switch(sLegendFont)
                {   
                    case "Arial":
                        this.radioLegendArial.Checked = true;
                        break;
                    case "Verdana":
                        this.radioLegendVerdana.Checked = true;
                        break;
                    case "Trebuchet":
                        this.radioLegendTrebuchet.Checked = true;
                        break;
                    case "Times New Roman":
                        this.radioLegendTimes.Checked = true;
                        break;
                    case "Georgia":
                        this.radioLegendGeorgia.Checked = true;
                        break;
                    default:
                        break;

                }
                
                //Font Size
                this.textLegendFontSize.Text = prefs.ReadLine();//sw4.WriteLine(this.textLabelFontSize.Text);
                //Font Style
                string sLegendFontStyle = prefs.ReadLine();
                switch(sLegendFontStyle)
                {   
                    case "Regular":
                        this.radioLegendRegular.Checked = true;
                        break;
                    case "Bold":
                        this.radioLegendBold.Checked = true;
                        break;
                    default:
                        break;

                }
                this.checkLegendItalics.Checked = Convert.ToBoolean(prefs.ReadLine());//  sw4.WriteLine(Convert.ToString(this.checkLabelItalics.Checked));
                this.checkLegendUnderline.Checked  = Convert.ToBoolean(prefs.ReadLine());// sw4.WriteLine(Convert.ToString(this.checkLabelUnderline.Checked));



                prefs.ReadLine();//sw4.WriteLine("BACKGROUND---");
                //Main Pane--
                //Fill Color 1
                this.comboBackgroundMainPaneFillColor1.SelectedItem= prefs.ReadLine();//sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneFillColor1.SelectedIndex));
                //Apply Gradient
                this.checkBackgroundMainPaneGradient.Checked = Convert.ToBoolean(prefs.ReadLine());// sw4.WriteLine(Convert.ToString(this.checkBackgroundMainPaneGradient.Checked));
                //Fill Color 2
                this.comboBackgroundMainPaneFillColor2.SelectedItem = prefs.ReadLine();//sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneFillColor2.SelectedIndex));
                //Gradient Angle
                string sMainAngle =  prefs.ReadLine();
                switch(sMainAngle)
                {   
                    case "45":
                        this.radioBackgroundMainPane45.Checked = true;
                        break;
                    case "90":
                        this.radioBackgroundMainPane90.Checked = true;
                        break;
                    default:
                        break;

                }
  

                //Plot Area--
                //Fill Color 1
                this.comboBackgroundPlotPaneFillColor1.SelectedItem = prefs.ReadLine();//sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneFillColor1.SelectedIndex));
                //Apply Gradient
                this.checkBackgroundPlotPaneGradient.Checked = Convert.ToBoolean(prefs.ReadLine());// sw4.WriteLine(Convert.ToString(this.checkBackgroundPlotPaneGradient.Checked));
                //Fill Color 2
                this.comboBackgroundPlotPaneFillColor2.SelectedItem = prefs.ReadLine();//sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneFillColor2.SelectedIndex));
                //Gradient Angle
                string sPlotAngle =  prefs.ReadLine();
                switch(sPlotAngle)
                {   
                    case "45":
                        this.radioBackgroundPlotPane45.Checked = true;
                        break;
                    case "90":
                        this.radioBackgroundPlotPane90.Checked = true;
                        break;
                    default:
                        break;

                }

                prefs.ReadLine();//sw4.WriteLine("MARGINS---");
                //Top
                this.textMarginTop.Text=  prefs.ReadLine();// sw4.WriteLine(this.textMarginTop.Text);
                //Bottom
                this.textMarginBottom.Text= prefs.ReadLine();// sw4.WriteLine(this.textMarginBottom.Text);
                //Left
                this.textMarginLeft.Text= prefs.ReadLine();// sw4.WriteLine(this.textMarginLeft.Text);
                //Right
                this.textMarginRight.Text= prefs.ReadLine();// sw4.WriteLine(this.textMarginRight.Text);

                prefs.ReadLine();//sw4.WriteLine("BORDER---");
                //Display
                this.checkDisplayBorder.Checked = Convert.ToBoolean(prefs.ReadLine());// sw4.WriteLine(Convert.ToString(this.checkDisplayBorder.Checked));
                //Thickness
                this.textBorderThickness.Text = prefs.ReadLine();//sw4.WriteLine(this.textBorderThickness.Text);
                //Color
                string sBorderColor = prefs.ReadLine();
                switch (sBorderColor)
                {   
                    case "Black":
                        this.radioBorderBlack.Checked = true;
                        break;
                    case "Gray":
                        this.radioBorderGray.Checked = true;
                        break;
                    case "DarkGray":
                        this.radioBorderDarkGray.Checked = true;
                        break;
                    case "LightGray":
                        this.radioBorderLightGray.Checked = true;
                        break;
                    default:
                        break;

                }


                //-------------------------------------------------------
                //-------------------------------------------------------


                //Clean up and close file
                prefs.Close();





        }



        #endregion

    




    }//close class
}//close namespace
