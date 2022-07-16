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
    public partial class Observed_Prefs : Form
    {

        #region "DAT Globals"


        #endregion


        //*************************************************
        //*************************************************


        public Observed_Prefs()
        {
            InitializeComponent();
        }



        #region "Write to File Methods"

        //*******************************************************
        //Write to File Methods
        //*******************************************************    

        public void methodSaveToObserved_Prefs1()

            {
                //Total Lines
                //28

                using (StreamWriter sw3 = new StreamWriter("Graphing/Observed_Prefs1.dat"))
                {
                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("***************BEGIN**************************");
                    sw3.WriteLine("DRAINMOD Graphing Utility Settings");
                    sw3.WriteLine(">>>Graphing/Observed_Prefs1.dat<<<");
                    sw3.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("**********************************************");

                    //Write Observed Data Files and Labels
                    //----------------------------------------------------------------------
                    sw3.WriteLine("Observed-------------------------------");

                    sw3.WriteLine("Observed1-----");
                    //Filepath
                    sw3.WriteLine(this.ObservedFile1Filepath.Text);
                    //Label
                    sw3.WriteLine(this.ObservedFile1Label.Text);
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkObservedFile1Display.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(Convert.ToString(this.radioObservedFile1Secondary.Checked));
                    //Plot Type Index value
                    sw3.WriteLine(Convert.ToString(this.comboObservedFile1Type.SelectedIndex));


                    sw3.WriteLine("Observed2-----");
                    //Filepath
                    sw3.WriteLine(this.ObservedFile2Filepath.Text);
                    //Label
                    sw3.WriteLine(this.ObservedFile2Label.Text);
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkObservedFile2Display.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(Convert.ToString(this.radioObservedFile2Secondary.Checked));
                    //Plot Type Index value
                    sw3.WriteLine(Convert.ToString(this.comboObservedFile2Type.SelectedIndex));


                    sw3.WriteLine("Observed3-----");
                    //Filepath
                    sw3.WriteLine(this.ObservedFile3Filepath.Text);
                    //Label
                    sw3.WriteLine(this.ObservedFile3Label.Text);
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkObservedFile3Display.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(Convert.ToString(this.radioObservedFile3Secondary.Checked));
                    //Plot Type Index value
                    sw3.WriteLine(Convert.ToString(this.comboObservedFile3Type.SelectedIndex));


                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("***************END****************************");


                    //Clean up and close file
                    sw3.Flush();
                    sw3.Close();

                }//close writer





            }//Close Method



        private void methodSaveToObserved_Prefs2.dat()

            {
                using (StreamWriter sw4 = new StreamWriter("Graphing/Observed_Prefs2.dat"))
                {
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("***************BEGIN**************************");
                    sw4.WriteLine("DRAINMOD Graphing Utility Settings Graphing/Observed_Prefs2.dat");
                    sw4.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("**********************************************");




                    //-------------------------------------------------------
                    //Observed Data------------------------------------------
                    //-------------------------------------------------------

                    sw4.WriteLine("OBSERVED FILE 1");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkObservedFile1Display.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioObservedFile1Primary.Checked);
                    //sw4.WriteLine(this.radioObservedFile1Secondary.Checked);
                    //File Path
                    //sw4.WriteLine(this.ObservedFile1Filepath.Text);
                    //Label
                    //sw4.WriteLine(this.ObservedFile1Label.Text);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile1SmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1LineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1LineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1LineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1LineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile1DisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1SymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1SymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1SymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1SymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile1FillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1FillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1FillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile1ApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1FillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1FillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1GradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1GradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1BarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1BarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1BarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile1BarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile1DisplayBarLabel.Checked));

                    sw4.WriteLine("OBSERVED FILE 2");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkObservedFile2Display.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioObservedFile2Primary.Checked);
                    //sw4.WriteLine(this.radioObservedFile2Secondary.Checked);
                    //File Path
                    //sw4.WriteLine(this.ObservedFile2Filepath.Text);
                    //Label
                    //sw4.WriteLine(this.ObservedFile2Label.Text);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile2SmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2LineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2LineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2LineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2LineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile2DisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2SymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2SymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2SymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2SymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile2FillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2FillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2FillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile2ApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2FillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2FillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2GradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2GradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2BarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2BarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2BarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile2BarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile2DisplayBarLabel.Checked));

                    sw4.WriteLine("OBSERVED FILE 3");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkObservedFile3Display.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioObservedFile3Primary.Checked);
                    //sw4.WriteLine(this.radioObservedFile3Secondary.Checked);
                    //File Path
                    //sw4.WriteLine(this.ObservedFile3Filepath.Text);
                    //Label
                    //sw4.WriteLine(this.ObservedFile3Label.Text);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile3SmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3LineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3LineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3LineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3LineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile3DisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3SymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3SymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3SymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3SymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile3FillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3FillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3FillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile3ApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3FillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3FillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3GradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3GradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3BarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3BarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3BarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboObservedFile3BarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkObservedFile3DisplayBarLabel.Checked));

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
