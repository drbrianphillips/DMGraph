using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;//Allows file reading and writing
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Graphing_DRAINMOD
{
    public partial class Preferences : Form
    {

        #region "DAT Globals"

        
        #endregion


        public Preferences()
        {
            InitializeComponent();
        }


       

        //Example
        //this.tabControl1.SelectedTab = this.tabHydrology;

        #region "Write to File Methods"

        //*******************************************************
        //Write to File Methods
        //*******************************************************        

        public void methodSaveToPreference1()

            {
                //Total Lines
                //24

                using (StreamWriter sw3 = new StreamWriter("Graphing/Preference1.dat"))
                {
                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("***************BEGIN**************************");
                    sw3.WriteLine("DRAINMOD Graphing Utility Settings");
                    sw3.WriteLine(">>>Graphing/Preference1.dat<<<");
                    sw3.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("**********************************************");

                    //Write Available Plot Area Settings including Axes Options and Values
                    //----------------------------------------------------------------------
                    sw3.WriteLine("Plot-------------------------------");

                    sw3.WriteLine("YAxis-----");

                    sw3.WriteLine("Primary--");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkYAxisPrimaryDisplay.Checked));
                    //Is Reversed
                    sw3.WriteLine(Convert.ToString(this.checkYAxisPrimaryScaleReverse.Checked));
                    //Max
                    sw3.WriteLine(this.textYAxisPrimaryScaleMax.Text);
                    //Min
                    sw3.WriteLine(this.textYAxisPrimaryScaleMin.Text);

                    sw3.WriteLine("Secondary--");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkYAxisSecondaryDisplay.Checked));
                    //Is Reversed
                    sw3.WriteLine(Convert.ToString(this.checkYAxisSecondaryScaleReverse.Checked));
                    //Max
                    sw3.WriteLine(this.textYAxisSecondaryScaleMax.Text);
                    //Min
                    sw3.WriteLine(this.textYAxisSecondaryScaleMin.Text);


                    sw3.WriteLine("XAxis-----");
                    //Start
                    sw3.WriteLine(this.textXAxisScaleStart.Text);
                    //End
                    sw3.WriteLine(this.textXAxisScaleEnd.Text);

                                                       

                    //EXAMPLE XML WRITING
                    //writer.WriteStartElement("DVD");
                    //writer.WriteAttributeString("ID", "1");
                    //write some simple elements
                    //writer.WriteElementString("Title", "Tere");
                    //writer.WriteStartElement("Starring");
                    //writer.WriteElementString("Actor", "Salman Khan");
                    //writer.WriteEndElement();
                    //writer.WriteEndElement();

                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("***************END****************************");


                    //Clean up and close file
                    sw3.Flush();
                    sw3.Close();

                }//close writer

            }//Close Method


        public void methodSaveToPreference2()

            {
                using (StreamWriter sw4 = new StreamWriter("Graphing/Preference2.dat"))
                {
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("***************BEGIN**************************");
                    sw3.WriteLine("DRAINMOD Graphing Utility Settings");
                    sw3.WriteLine(">>>Graphing/Preference2.dat<<<");
                    sw3.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("**********************************************");

                    //-------------------------------------------------------
                    sw4.WriteLine("PLOT AREA");
                    //-------------------------------------------------------

                    //Title,Legend,Background
                    //-------------------------------------------------------

                    sw4.WriteLine("TITLE");

                    //Line 1--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkTitleLine1Display.Checked));
                    //Label
                    sw4.WriteLine(this.textTitleLine1.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1Gap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1Gap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1Font.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1Font.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1FontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1FontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1FontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1FontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1FontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine1FontStyle.SelectedIndex));

                    //Line 2--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkTitleLine2Display.Checked));
                    //Label
                    sw4.WriteLine(this.textTitleLine2.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2Gap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2Gap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2Font.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2Font.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2FontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2FontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2FontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2FontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2FontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboTitleLine2FontStyle.SelectedIndex));

                    sw4.WriteLine("LEGEND");
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkLegendDisplay.Checked));
                    //Alignment
                    sw4.WriteLine(Convert.ToString(this.comboLegendAlignment.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendAlignment.SelectedIndex));
                    //Position
                    sw4.WriteLine(Convert.ToString(this.comboLegendPosition.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendPosition.SelectedIndex));
                    //Fill Color
                    sw4.WriteLine(Convert.ToString(this.comboLegendFillColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendFillColor.SelectedIndex));
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboLegendGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboLegendFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboLegendFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboLegendFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboLegendFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboLegendFontStyle.SelectedIndex));

                    sw4.WriteLine("BACKGROUND");
                    //Main Pane--
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkBackgroundMainPaneGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundMainPaneAngle.SelectedIndex));

                    //Plot Area--
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkBackgroundPlotPaneGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBackgroundPlotPaneAngle.SelectedIndex));

                    //Margins-----
                    //Top
                    sw4.WriteLine(Convert.ToString(this.comboMarginTop.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboMarginTop.SelectedIndex));
                    //Bottom
                    sw4.WriteLine(Convert.ToString(this.comboMarginBottom.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboMarginBottom.SelectedIndex));
                    //Left
                    sw4.WriteLine(Convert.ToString(this.comboMarginLeft.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboMarginLeft.SelectedIndex));
                    //Right
                    sw4.WriteLine(Convert.ToString(this.comboMarginRight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboMarginRight.SelectedIndex));

                    //Border-----
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkBorderDisplay.Checked));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboBorderColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBorderColor.SelectedIndex));
                    //Thickness
                    sw4.WriteLine(Convert.ToString(this.comboBorderThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboBorderThickness.SelectedIndex));

                    //-------------------------------------------------------
                    //-------------------------------------------------------

                    sw4.WriteLine("X AXIS");
                    //-------------------------------------------------------
                    //Title-----
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkXAxisDisplay.Checked));
                    //Label
                    sw4.WriteLine(this.textXAxis.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboXAxisGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisFontStyle.SelectedIndex));

                    //Scale-----
                    //Start Date
                    //sw4.WriteLine(this.textXAxisScaleStart.Text);
                    //End Date
                    //sw4.WriteLine(this.textXAxisScaleEnd.Text);
                    //Format
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFormat.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFormat.SelectedIndex));
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisScaleFontStyle.SelectedIndex));

                    //Tic Marks-----
                    //Major--
                    //Auto Calc Size
                    sw4.WriteLine(Convert.ToString(this.checkXAxisMajorTicAutoCalc.Checked));
                    //Step Size
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicStepSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicStepSize.SelectedIndex));
                    //Height
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicHeight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicHeight.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicWidth.SelectedIndex));
                    //Inside or Outside
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicInside.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicInside.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorTicColor.SelectedIndex));
                    //Minor--
                    //Auto Calc Size
                    sw4.WriteLine(Convert.ToString(this.checkXAxisMajorGridDisplay.Checked));
                    //Step Size
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridStyle.SelectedIndex));
                    //Height
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicHeight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicHeight.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicWidth.SelectedIndex));
                    //Inside or Outside
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicInside.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicInside.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorTicColor.SelectedIndex));

                    //Grid Lines-----
                    //Major--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkXAxisMajorGridDisplay.Checked));
                    //Line Style
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridStyle.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMajorGridColor.SelectedIndex));

                    //Minor--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkXAxisMinorGridDisplay.Checked));
                    //Line Style
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorGridStyle.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorGridWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorGridWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorGridColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboXAxisMinorGridColor.SelectedIndex));

                    //-------------------------------------------------------
                    //-------------------------------------------------------


                    sw4.WriteLine("Y AXIS - Primary");
                    //-------------------------------------------------------
                    //Title-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkYAxisPrimaryDisplay.Checked));
                    //Label
                    sw4.WriteLine(this.textYAxisPrimary.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryFontStyle.SelectedIndex));

                    //Scale-----
                    //Reverse Axis
                    //sw4.WriteLine(Convert.ToString(this.checkYAxisPrimaryScaleReverse.Checked));
                    //Minimum
                    //sw4.WriteLine(this.textYAxisPrimaryScaleMin.Text);
                    //Maximum
                    //sw4.WriteLine(this.textYAxisPrimaryScaleMax.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryScaleFontStyle.SelectedIndex));

                    //Tic Marks-----
                    //Major--
                    //Auto Calc Size
                    sw4.WriteLine(Convert.ToString(this.checkYAxisPrimaryMajorTicAutoCalc.Checked));
                    //Step Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicStepSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicStepSize.SelectedIndex));
                    //Height
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicHeight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicHeight.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicWidth.SelectedIndex));
                    //Inside or Outside
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicInside.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicInside.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorTicColor.SelectedIndex));
                    //Minor--
                    //Auto Calc Size
                    sw4.WriteLine(Convert.ToString(this.checkYAxisPrimaryMinorTicAutoCalc.Checked));
                    //Step Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicStepSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicStepSize.SelectedIndex));
                    //Height
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicHeight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicHeight.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicWidth.SelectedIndex));
                    //Inside or Outside
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicInside.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicInside.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorTicColor.SelectedIndex));

                    //Grid Lines-----
                    //Major--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkYAxisPrimaryMajorGridDisplay.Checked));
                    //Line Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorGridStyle.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorGridWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorGridWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorGridColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMajorGridColor.SelectedIndex));

                    //Minor--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkYAxisPrimaryMinorGridDisplay.Checked));
                    //Line Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorGridStyle.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorGridWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorGridWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorGridColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisPrimaryMinorGridColor.SelectedIndex));

                    //-------------------------------------------------------
                    //-------------------------------------------------------


                    sw4.WriteLine("Y AXIS - Secondary");
                    //-------------------------------------------------------
                    //Title-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkYAxisSecondaryDisplay.Checked));
                    //Label
                    sw4.WriteLine(this.textYAxisSecondary.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryFontStyle.SelectedIndex));

                    //Scale-----
                    //Reverse Axis
                    //sw4.WriteLine(Convert.ToString(this.checkYAxisSecondaryScaleReverse.Checked));
                    //Minimum
                    //sw4.WriteLine(this.textYAxisSecondaryScaleMin.Text);
                    //Maximum
                    //sw4.WriteLine(this.textYAxisSecondaryScaleMax.Text);
                    //Gap
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleGap.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleGap.SelectedIndex));
                    //Font
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFont.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFont.SelectedIndex));
                    //Font Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFontSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFontSize.SelectedIndex));
                    //Font Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFontColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFontColor.SelectedIndex));
                    //Font Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFontStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryScaleFontStyle.SelectedIndex));

                    //Tic Marks-----
                    //Major--
                    //Auto Calc Size
                    sw4.WriteLine(Convert.ToString(this.checkYAxisSecondaryMajorTicAutoCalc.Checked));
                    //Step Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicStepSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicStepSize.SelectedIndex));
                    //Height
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicHeight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicHeight.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicWidth.SelectedIndex));
                    //Inside or Outside
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicInside.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicInside.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorTicColor.SelectedIndex));
                    //Minor--
                    //Auto Calc Size
                    sw4.WriteLine(Convert.ToString(this.checkYAxisSecondaryMinorTicAutoCalc.Checked));
                    //Step Size
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicStepSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicStepSize.SelectedIndex));
                    //Height
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicHeight.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicHeight.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicWidth.SelectedIndex));
                    //Inside or Outside
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicInside.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicInside.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorTicColor.SelectedIndex));

                    //Grid Lines-----
                    //Major--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkYAxisSecondaryMajorGridDisplay.Checked));
                    //Line Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorGridStyle.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorGridWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorGridWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorGridColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMajorGridColor.SelectedIndex));

                    //Minor--
                    //Display
                    sw4.WriteLine(Convert.ToString(this.checkYAxisSecondaryMinorGridDisplay.Checked));
                    //Line Style
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorGridStyle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorGridStyle.SelectedIndex));
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorGridWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorGridWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorGridColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboYAxisSecondaryMinorGridColor.SelectedIndex));

                    //-------------------------------------------------------
                    //-------------------------------------------------------

 
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("***************END****************************");


                    //Clean up and close file
                    sw4.Flush();
                    sw4.Close();

                }//close writer

        }//Close Method

        #endregion


        #region "Key Files"

        //*******************************************************
        //Cancel Key File
        //******************************************************* 
       
        public void methodCancelKey()
        {
            using (StreamWriter sw5 = new StreamWriter("Graphing/Cancel.dat"))
            {
                sw5.WriteLine("CANCEL");

                //Clean up and close file
                sw5.Flush();
                sw5.Close();

            }//close writer
        }//close method

        public void methodReloadKey()
        {
            using (StreamWriter sw6 = new StreamWriter("Graphing/Cancel.dat"))
            {
                sw6.WriteLine("RELOAD");

                //Clean up and close file
                sw6.Flush();
                sw6.Close();

            }//close writer
        }//close method

        #endregion


        #region "Buttons"

        //*******************************************************
        //Button Methods
        //*******************************************************    

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            methodCancelKey();

            this.Close();

        }


        private void buttonCloseAndApply_Click(object sender, EventArgs e)
        {
            methodReloadKey();
            methodSaveToPreference1();
            methodSaveToPreference2();

            this.Close();
        }

        #endregion










    }//Close Main Class
}//Close Namespace
