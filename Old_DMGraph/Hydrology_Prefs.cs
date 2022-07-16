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
    public partial class Hydrology_Prefs : Form
    {

        #region "DAT Globals"


        #endregion


        //*************************************************
        //*************************************************


        public Hydrology_Prefs()
        {
            InitializeComponent();
        }



        #region "Write to File Methods"

        //*******************************************************
        //Write to File Methods
        //*******************************************************    

        public void methodSaveToHydrology_Prefs1()

            {
                //Total Lines
                //46

                using (StreamWriter sw3 = new StreamWriter("Graphing/Hydrology_Prefs1.dat"))
                {
                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("***************BEGIN**************************");
                    sw3.WriteLine("DRAINMOD Graphing Utility Settings");
                    sw3.WriteLine(">>>Graphing/Hydrology_Prefs1.dat<<<");
                    sw3.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("**********************************************");

                    
                    //Write Available Hydrology Settings
                    //----------------------------------------------------------------------
                    sw3.WriteLine("Hydrology-------------------------------");

                    sw3.WriteLine("WaterTableDepth-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkWaterTableDepthDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioWaterTableDepthSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboWaterTableDepthType.SelectedIndex));


                    sw3.WriteLine("DryZoneDepth-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkDryZoneDepthDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioDryZoneDepthSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboDryZoneDepthType.SelectedIndex));

                    sw3.WriteLine("SurfaceStorage-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkSurfaceStorageDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioSurfaceStorageSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboSurfaceStorageType.SelectedIndex));


                    sw3.WriteLine("Rainfall-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkRainfallDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioRainfallSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboRainfallType.SelectedIndex));


                    sw3.WriteLine("Infiltration-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkInfiltrationDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioInfiltrationSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboInfiltrationType.SelectedIndex));

                    sw3.WriteLine("Evaporation-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkEvaporationDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioEvaporationSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboEvaporationType.SelectedIndex));


                    sw3.WriteLine("Drainage-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkDrainageDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioDrainageSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboDrainageType.SelectedIndex));

                    sw3.WriteLine("SurfaceRunoff-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkSurfaceRunoffDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioSurfaceRunoffSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboSurfaceRunoffType.SelectedIndex));


                    sw3.WriteLine("WaterLoss-----");
                    //Is Displayed
                    sw3.WriteLine(Convert.ToString(this.checkWaterLossDisplay.Checked));
                    //Is on Secondary Axis
                    sw3.WriteLine(this.radioWaterLossSecondary.Checked);
                    //Plot Type Index Value
                    sw3.WriteLine(Convert.ToString(this.comboWaterLossType.SelectedIndex));



                    sw3.WriteLine("**********************************************");
                    sw3.WriteLine("***************END****************************");


                    //Clean up and close file
                    sw3.Flush();
                    sw3.Close();

                }//close writer





            }//Close Method



        public void methodSaveToHydrology_Prefs2()

            {
                using (StreamWriter sw4 = new StreamWriter("Graphing/Hydrology_Prefs2.dat"))
                {
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("***************BEGIN**************************");
                    sw4.WriteLine("DRAINMOD Graphing Utility Settings Graphing/Hydrology_Prefs2.dat");
                    sw4.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw4.WriteLine("**********************************************");
                    sw4.WriteLine("**********************************************");






                    //-------------------------------------------------------
                    //Hydrology Variable-------------------------------------
                    //-------------------------------------------------------

                    sw4.WriteLine("WATER TABLE DEPTH");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkWaterTableDepthDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioWaterTableDepthPrimary.Checked);
                    //sw4.WriteLine(this.radioWaterTableDepthSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkWaterTableDepthSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkWaterTableDepthDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkWaterTableDepthFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkWaterTableDepthApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterTableDepthBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkWaterTableDepthDisplayBarLabel.Checked));

                    sw4.WriteLine("DRY ZONE DEPTH");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkDryZoneDepthDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioDryZoneDepthPrimary.Checked);
                    //sw4.WriteLine(this.radioDryZoneDepthSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkDryZoneDepthSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkDryZoneDepthDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkDryZoneDepthFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkDryZoneDepthApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDryZoneDepthBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkDryZoneDepthDisplayBarLabel.Checked));

                    sw4.WriteLine("SURFACE STORAGE");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkSurfaceStorageDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioSurfaceStoragePrimary.Checked);
                    //sw4.WriteLine(this.radioSurfaceStorageSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceStorageSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceStorageDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceStorageFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceStorageApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceStorageBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceStorageDisplayBarLabel.Checked));

                    sw4.WriteLine("RAINFALL");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkRainfallDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioRainfallPrimary.Checked);
                    //sw4.WriteLine(this.radioRainfallSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkRainfallSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboRainfallLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboRainfallLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkRainfallDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboRainfallSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboRainfallSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkRainfallFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboRainfallFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkRainfallApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboRainfallFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboRainfallGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboRainfallBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboRainfallBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboRainfallBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkRainfallDisplayBarLabel.Checked));

                    sw4.WriteLine("INFILTRATION");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkInfiltrationDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioInfiltrationPrimary.Checked);
                    //sw4.WriteLine(this.radioInfiltrationSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkInfiltrationSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkInfiltrationDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkInfiltrationFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkInfiltrationApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboInfiltrationBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkInfiltrationDisplayBarLabel.Checked));

                    sw4.WriteLine("EVAPORATION");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkEvaporationDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioEvaporationPrimary.Checked);
                    //sw4.WriteLine(this.radioEvaporationSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkEvaporationSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkEvaporationDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkEvaporationFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkEvaporationApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboEvaporationBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkEvaporationDisplayBarLabel.Checked));

                    sw4.WriteLine("DRAINAGE");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkDrainageDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioDrainagePrimary.Checked);
                    //sw4.WriteLine(this.radioDrainageSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkDrainageSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboDrainageLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboDrainageLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkDrainageDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboDrainageSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboDrainageSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkDrainageFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboDrainageFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkDrainageApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboDrainageFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboDrainageGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboDrainageBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboDrainageBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboDrainageBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkDrainageDisplayBarLabel.Checked));

                    sw4.WriteLine("SURFACE RUNOFF");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoffDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioSurfaceRunoffPrimary.Checked);
                    //sw4.WriteLine(this.radioSurfaceRunoffSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoffSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoffDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoffFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoffApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboSurfaceRunoffBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoffDisplayBarLabel.Checked));

                    sw4.WriteLine("WATERLOSS");
                    //-------------------------------------------------------
                    //General-----
                    //Display
                    //sw4.WriteLine(Convert.ToString(this.checkWaterLossDisplay.Checked));
                    //Axis
                    //sw4.WriteLine(this.radioWaterLossPrimary.Checked);
                    //sw4.WriteLine(this.radioWaterLossSecondary.Checked);
                    //Line Plots-----
                    //Smooth Line
                    sw4.WriteLine(Convert.ToString(this.checkWaterLossSmoothLine.Checked));
                    //Line Thickness
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossLineThickness.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossLineThickness.SelectedIndex));
                    //Line Color
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossLineColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossLineColor.SelectedIndex));
                    //Display Symbol
                    sw4.WriteLine(Convert.ToString(this.checkWaterLossDisplaySymbol.Checked));
                    //Symbol Type
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossSymbolType.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossSymbolType.SelectedIndex));
                    //Symbol Size
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossSymbolSize.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossSymbolSize.SelectedIndex));
                    //Fill Area
                    sw4.WriteLine(Convert.ToString(this.checkWaterLossFillArea.Checked));
                    //Fill Color 1
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossFillColor1.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossFillColor1.SelectedIndex));
                    //Apply Gradient
                    sw4.WriteLine(Convert.ToString(this.checkWaterLossApplyGradient.Checked));
                    //Fill Color 2
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossFillColor2.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossFillColor2.SelectedIndex));
                    //Gradient Angle
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossGradientAngle.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossGradientAngle.SelectedIndex));
                    //Bar Plots-----
                    //Width
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossBarWidth.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossBarWidth.SelectedIndex));
                    //Color
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossBarColor.SelectedValue));
                    sw4.WriteLine(Convert.ToString(this.comboWaterLossBarColor.SelectedIndex));
                    //Label with Value
                    sw4.WriteLine(Convert.ToString(this.checkWaterLossDisplayBarLabel.Checked));

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
