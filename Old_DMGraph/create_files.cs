using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;//Allows file reading and writing
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;//Imports Zedgraph Library
using System.Threading;


namespace Graphing_DRAINMOD
{
    class create_files
    {     
        
       //File List 
        string sFileGeneral = "Graphing/General.dat";
        string sFileXAxis = "Graphing/XAxis.dat";
        string sFilePrimaryYAxis = "Graphing/PrimaryYAxis.dat";
        string sFileSecondaryYAxis = "Graphing/SecondaryYAxis.dat";
        string sFileObservedFile1 = "Graphing/ObservedFile1.dat";
        string sFileObservedFile2 = "Graphing/ObservedFile2.dat";
        string sFileObservedFile3 = "Graphing/ObservedFile3.dat";
        string sFileWaterTable = "Graphing/WaterTableDepth.dat";
        string sFileDryZone = "Graphing/DryZoneDepth.dat";
        string sFileDrainage = "Graphing/Drainage.dat";
        string sFileEvaporation = "Graphing/Evaporation.dat";
        string sFileInfiltration = "Graphing/Infiltration.dat";
        string sFileSurfaceStorage = "Graphing/SurfaceStorage.dat";
        string sFileSurfaceRunoff = "Graphing/SurfaceRunoff.dat";
        string sFileRainfall = "Graphing/Rainfall.dat";
        string sFileWaterLoss = "Graphing/WaterLoss.dat";
        string sPreferences1 = "Graphing/Preference1.dat";
        string sHydrology_Prefs1 = "Graphing/Hydrology_Prefs1.dat";
        string sObserved_Prefs1 = "Graphing/Observed_Prefs1.dat";
        string sCSV_Options = "Graphing/CSV_Options.dat";

        string sDaily = "Graphing/StartupD.dat";
        string sMonthly = "Graphing/StartupM.dat";
        string sYearly = "Graphing/StartupY.dat";
    


        public void methodCreateCancelFile()
        {

            using (StreamWriter create001 = new StreamWriter("Graphing/Cancel.dat"))
            {
                create001.WriteLine("CANCEL");

                //Clean up and close file
                create001.Flush();
                create001.Close();

            }//close writer

        }//close Method




        public void methodCreatesFileGeneral()
        {

            using (StreamWriter create002 = new StreamWriter(sFileGeneral))
            {
                create002.WriteLine("**********************************************");
                create002.WriteLine("***************BEGIN**************************");
                create002.WriteLine("DRAINMOD Graphing Utility Settings");
                create002.WriteLine(">>>Graphing/Preference2.dat<<<");
                create002.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                create002.WriteLine("**********************************************");
                create002.WriteLine("**********************************************");
                create002.WriteLine("PLOT AREA-----");
                create002.WriteLine("TITLE---");
                create002.WriteLine("True");
                create002.WriteLine("Title Line 1");
                create002.WriteLine("Line 2");
                create002.WriteLine("Times New Roman");
                create002.WriteLine("12");
                create002.WriteLine("Bold");
                create002.WriteLine("False");
                create002.WriteLine("False");
                create002.WriteLine("LEGEND---");
                create002.WriteLine("True");
                create002.WriteLine("BottomCenter");
                create002.WriteLine("Arial");
                create002.WriteLine("10");
                create002.WriteLine("Regular");
                create002.WriteLine("False");
                create002.WriteLine("False");
                create002.WriteLine("BACKGROUND---");
                create002.WriteLine("White");
                create002.WriteLine("True");
                create002.WriteLine("Silver");
                create002.WriteLine("45");
                create002.WriteLine("White");
                create002.WriteLine("False");
                create002.WriteLine("Silver");
                create002.WriteLine("45");
                create002.WriteLine("MARGINS---");
                create002.WriteLine("10");
                create002.WriteLine("10");
                create002.WriteLine("10");
                create002.WriteLine("10");
                create002.WriteLine("BORDER---");
                create002.WriteLine("True");
                create002.WriteLine("1");
                create002.WriteLine("Black");


                //Clean up and close file
                create002.Flush();
                create002.Close();

            }//close writer

        }//close Method

             
        
        
        public void methodCreatesFileXAxis()
        {

            using (StreamWriter create003 = new StreamWriter(sFileXAxis))
            {


                create003.WriteLine("X AXIS ------");
                create003.WriteLine("TITLE---");
                create003.WriteLine("True");
                create003.WriteLine("x axis label");
                create003.WriteLine("Verdana");
                create003.WriteLine("12");
                create003.WriteLine("Regular");
                create003.WriteLine("False");
                create003.WriteLine("False");
                create003.WriteLine("SCALE---");
                create003.WriteLine("y");
                create003.WriteLine("Arial");
                create003.WriteLine("12");
                create003.WriteLine("Regular");
                create003.WriteLine("False");
                create003.WriteLine("False");
                create003.WriteLine("TIC MARKS---");
                create003.WriteLine("False");
                create003.WriteLine("True");
                create003.WriteLine("True");
                create003.WriteLine("False");
                create003.WriteLine("True");
                create003.WriteLine("True");
                create003.WriteLine("GRID LINES---");
                create003.WriteLine("False");
                create003.WriteLine("1");
                create003.WriteLine("DarkGray");
                create003.WriteLine("True");
                create003.WriteLine("1");
                create003.WriteLine("DarkGray");


                //Clean up and close file
                create003.Flush();
                create003.Close();

            }//close writer

        }//close Method


        public void methodCreatesFilePrimaryY()
        {

            using (StreamWriter create004 = new StreamWriter(sFilePrimaryYAxis))
            {
                create004.WriteLine("PRIMARY Y AXIS-----");
                create004.WriteLine("TITLE---");
                create004.WriteLine("True");
                create004.WriteLine("primary y axis label");
                create004.WriteLine("Verdana");
                create004.WriteLine("12");
                create004.WriteLine("Regular");
                create004.WriteLine("False");
                create004.WriteLine("False");
                create004.WriteLine("SCALE---");
                create004.WriteLine("Arial");
                create004.WriteLine("12");
                create004.WriteLine("Regular");
                create004.WriteLine("False");
                create004.WriteLine("False");
                create004.WriteLine("TIC MARKS---");
                create004.WriteLine("False");
                create004.WriteLine("True");
                create004.WriteLine("True");
                create004.WriteLine("False");
                create004.WriteLine("True");
                create004.WriteLine("True");
                create004.WriteLine("GRID LINES---");
                create004.WriteLine("True");
                create004.WriteLine("1");
                create004.WriteLine("DarkGray");
                create004.WriteLine("True");
                create004.WriteLine("1");
                create004.WriteLine("DarkGray");
                create004.WriteLine("DarkGray");



                //Clean up and close file
                create004.Flush();
                create004.Close();

            }//close writer

        }//close Method


        public void methodCreatesFileSecondaryY()
        {

            using (StreamWriter create005 = new StreamWriter(sFileSecondaryYAxis))
            {
                create005.WriteLine("PRIMARY Y AXIS-----");
                create005.WriteLine("TITLE---");
                create005.WriteLine("True");
                create005.WriteLine("secondary y axis label");
                create005.WriteLine("Verdana");
                create005.WriteLine("12");
                create005.WriteLine("Regular");
                create005.WriteLine("False");
                create005.WriteLine("False");
                create005.WriteLine("SCALE---");
                create005.WriteLine("Arial");
                create005.WriteLine("12");
                create005.WriteLine("Regular");
                create005.WriteLine("False");
                create005.WriteLine("False");
                create005.WriteLine("TIC MARKS---");
                create005.WriteLine("False");
                create005.WriteLine("True");
                create005.WriteLine("True");
                create005.WriteLine("False");
                create005.WriteLine("True");
                create005.WriteLine("True");
                create005.WriteLine("GRID LINES---");
                create005.WriteLine("True");
                create005.WriteLine("1");
                create005.WriteLine("DarkGray");
                create005.WriteLine("True");
                create005.WriteLine("1");
                create005.WriteLine("DarkGray");
                create005.WriteLine("DarkGray");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("True");
                create005.WriteLine("1");
                create005.WriteLine("Black");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");
                create005.WriteLine("");



                //Clean up and close file
                create005.Flush();
                create005.Close();

            }//close writer

        }//close Method

        public void methodCreatesFileObservedFile1()
        {

            using (StreamWriter create006 = new StreamWriter(sFileObservedFile1))
            {

                create006.WriteLine("Observed Data File 1");
                create006.WriteLine("Line Plots-----");
                create006.WriteLine("False");
                create006.WriteLine("1");
                create006.WriteLine("Black");
                create006.WriteLine("True");
                create006.WriteLine("1");
                create006.WriteLine("Square");
                create006.WriteLine("Bar Plots-----");
                create006.WriteLine("Black");

                //Clean up and close file
                create006.Flush();
                create006.Close();

            }//close writer

        }//close Method

        public void methodCreatesFileObservedFile2()
        {

            using (StreamWriter create007 = new StreamWriter(sFileObservedFile2))
            {



                create007.WriteLine("-------");
                create007.WriteLine("Line Plots-----");
                create007.WriteLine("False");
                create007.WriteLine("1");
                create007.WriteLine("Black");
                create007.WriteLine("True");
                create007.WriteLine("1");
                create007.WriteLine("Square");
                create007.WriteLine("Bar Plots-----");
                create007.WriteLine("Black");


                //Clean up and close file
                create007.Flush();
                create007.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileObservedFile3()
        {

            using (StreamWriter create008 = new StreamWriter(sFileObservedFile3))
            {



                create008.WriteLine("-------");
                create008.WriteLine("Line Plots-----");
                create008.WriteLine("False");
                create008.WriteLine("1");
                create008.WriteLine("Black");
                create008.WriteLine("True");
                create008.WriteLine("1");
                create008.WriteLine("Square");
                create008.WriteLine("Bar Plots-----");
                create008.WriteLine("Black");


                //Clean up and close file
                create008.Flush();
                create008.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileWaterTable()
        {

            using (StreamWriter create009 = new StreamWriter(sFileWaterTable))
            {



                create009.WriteLine("-------");
                create009.WriteLine("Line Plots-----");
                create009.WriteLine("False");
                create009.WriteLine("1");
                create009.WriteLine("Black");
                create009.WriteLine("True");
                create009.WriteLine("1");
                create009.WriteLine("Square");
                create009.WriteLine("Bar Plots-----");
                create009.WriteLine("Black");


                //Clean up and close file
                create009.Flush();
                create009.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileDryZone()
        {

            using (StreamWriter create0010 = new StreamWriter(sFileDryZone))
            {



                create0010.WriteLine("-------");
                create0010.WriteLine("Line Plots-----");
                create0010.WriteLine("False");
                create0010.WriteLine("1");
                create0010.WriteLine("Black");
                create0010.WriteLine("True");
                create0010.WriteLine("1");
                create0010.WriteLine("Square");
                create0010.WriteLine("Bar Plots-----");
                create0010.WriteLine("Black");


                //Clean up and close file
                create0010.Flush();
                create0010.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileDrainage()
        {

            using (StreamWriter create0011 = new StreamWriter(sFileDrainage))
            {



                create0011.WriteLine("-------");
                create0011.WriteLine("Line Plots-----");
                create0011.WriteLine("False");
                create0011.WriteLine("1");
                create0011.WriteLine("Black");
                create0011.WriteLine("True");
                create0011.WriteLine("1");
                create0011.WriteLine("Square");
                create0011.WriteLine("Bar Plots-----");
                create0011.WriteLine("Black");


                //Clean up and close file
                create0011.Flush();
                create0011.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileEvaporation()
        {

            using (StreamWriter create0012 = new StreamWriter(sFileEvaporation))
            {



                create0012.WriteLine("-------");
                create0012.WriteLine("Line Plots-----");
                create0012.WriteLine("False");
                create0012.WriteLine("1");
                create0012.WriteLine("Black");
                create0012.WriteLine("True");
                create0012.WriteLine("1");
                create0012.WriteLine("Square");
                create0012.WriteLine("Bar Plots-----");
                create0012.WriteLine("Black");


                //Clean up and close file
                create0012.Flush();
                create0012.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileInfiltration()
        {

            using (StreamWriter create0013 = new StreamWriter(sFileInfiltration))
            {



                create0013.WriteLine("-------");
                create0013.WriteLine("Line Plots-----");
                create0013.WriteLine("False");
                create0013.WriteLine("1");
                create0013.WriteLine("Black");
                create0013.WriteLine("True");
                create0013.WriteLine("1");
                create0013.WriteLine("Square");
                create0013.WriteLine("Bar Plots-----");
                create0013.WriteLine("Black");


                //Clean up and close file
                create0013.Flush();
                create0013.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileSurfaceStorage()
        {

            using (StreamWriter create0014 = new StreamWriter(sFileSurfaceStorage))
            {



                create0014.WriteLine("-------");
                create0014.WriteLine("Line Plots-----");
                create0014.WriteLine("False");
                create0014.WriteLine("1");
                create0014.WriteLine("Black");
                create0014.WriteLine("True");
                create0014.WriteLine("1");
                create0014.WriteLine("Square");
                create0014.WriteLine("Bar Plots-----");
                create0014.WriteLine("Black");


                //Clean up and close file
                create0014.Flush();
                create0014.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileSurfaceRunoff()
        {

            using (StreamWriter create0015 = new StreamWriter(sFileSurfaceRunoff))
            {



                create0015.WriteLine("-------");
                create0015.WriteLine("Line Plots-----");
                create0015.WriteLine("False");
                create0015.WriteLine("1");
                create0015.WriteLine("Black");
                create0015.WriteLine("True");
                create0015.WriteLine("1");
                create0015.WriteLine("Square");
                create0015.WriteLine("Bar Plots-----");
                create0015.WriteLine("Black");


                //Clean up and close file
                create0015.Flush();
                create0015.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileRainfall()
        {

            using (StreamWriter create0016 = new StreamWriter(sFileRainfall))
            {



                create0016.WriteLine("-------");
                create0016.WriteLine("Line Plots-----");
                create0016.WriteLine("False");
                create0016.WriteLine("1");
                create0016.WriteLine("Black");
                create0016.WriteLine("True");
                create0016.WriteLine("1");
                create0016.WriteLine("Square");
                create0016.WriteLine("Bar Plots-----");
                create0016.WriteLine("Black");


                //Clean up and close file
                create0016.Flush();
                create0016.Close();

            }//close writer
        }//close Method


        public void methodCreatesFileWaterLoss()
        {

            using (StreamWriter create0017 = new StreamWriter(sFileWaterLoss))
            {



                create0017.WriteLine("-------");
                create0017.WriteLine("Line Plots-----");
                create0017.WriteLine("False");
                create0017.WriteLine("1");
                create0017.WriteLine("Black");
                create0017.WriteLine("True");
                create0017.WriteLine("1");
                create0017.WriteLine("Square");
                create0017.WriteLine("Bar Plots-----");
                create0017.WriteLine("Black");


                //Clean up and close file
                create0017.Flush();
                create0017.Close();

            }//close writer
        }//close Method



        public void methodCreatesPreferences1()
        {

            using (StreamWriter create0018 = new StreamWriter(sPreferences1))
            {



                create0018.WriteLine("**********************************************");
                create0018.WriteLine("***************BEGIN**************************");
                create0018.WriteLine("DRAINMOD Graphing Utility Settings");
                create0018.WriteLine(">>>Graphing/Preference1.dat<<<");
                create0018.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                create0018.WriteLine("**********************************************");
                create0018.WriteLine("**********************************************");
                create0018.WriteLine("X AXIS -----");
                create0018.WriteLine("1/1/1999");
                create0018.WriteLine("12/31/2000");
                create0018.WriteLine("Primary Y AXIS -----");
                create0018.WriteLine("True");
                create0018.WriteLine("True");
                create0018.WriteLine("0");
                create0018.WriteLine("100");
                create0018.WriteLine("Secondary Y AXIS -----");
                create0018.WriteLine("True");
                create0018.WriteLine("False");
                create0018.WriteLine("0");
                create0018.WriteLine("100");

                //Clean up and close file
                create0018.Flush();
                create0018.Close();

            }//close writer
        }//close Method

        public void methodCreatesHydrology_Prefs1()
        {

            using (StreamWriter create0019 = new StreamWriter(sHydrology_Prefs1))
            {



                create0019.WriteLine("**********************************************");
                create0019.WriteLine("***************BEGIN**************************");
                create0019.WriteLine("DRAINMOD Graphing Utility Settings");
                create0019.WriteLine(">>>Graphing/Hydrology_Prefs1.dat<<<");
                create0019.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                create0019.WriteLine("**********************************************");
                create0019.WriteLine("**********************************************");
                create0019.WriteLine("Hydrology-------------------------------");
                create0019.WriteLine("WATER TABLE DEPTH----------");
                create0019.WriteLine("True");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("DRY ZONE DEPTH----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("SURFACE STORAGE----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("RAINFALL----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("INFILTRATION----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("EVAPORATION----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("DRAINAGE----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("SURFACE RUNOFF----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");
                create0019.WriteLine("WATER LOSS----------");
                create0019.WriteLine("False");
                create0019.WriteLine("Primary");
                create0019.WriteLine("Daily_Line");

                //Clean up and close file
                create0019.Flush();
                create0019.Close();

            }//close writer
        }//close Method


         public void  methodCreatesObserved_Prefs1()
        {

                using (StreamWriter create0020= new StreamWriter(sObserved_Prefs1))
            {

                create0020.WriteLine("**********************************************");
                create0020.WriteLine("***************BEGIN**************************");
                create0020.WriteLine("DRAINMOD Graphing Utility Settings");
                create0020.WriteLine(">>>Graphing/Observed_Prefs1.dat<<<");
                create0020.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                create0020.WriteLine("**********************************************");
                create0020.WriteLine("**********************************************");
                create0020.WriteLine("Observed Data File 1-----");
                create0020.WriteLine("False");
                create0020.WriteLine("Primary");
                create0020.WriteLine("Label Info");
                create0020.WriteLine("Line");
                create0020.WriteLine("Observed Data File 2-----");
                create0020.WriteLine("False");
                create0020.WriteLine("Primary");
                create0020.WriteLine("Label Info");
                create0020.WriteLine("Line");
                create0020.WriteLine("Observed Data File 3-----");
                create0020.WriteLine("False");
                create0020.WriteLine("Primary");
                create0020.WriteLine("Label Info");
                create0020.WriteLine("Line");
                //Clean up and close file
                create0020.Flush();
                create0020.Close();

            }//close writer
        }//close Method


        public void  methodCreateDaily()
        {

            using (StreamWriter create0021 = new StreamWriter(sDaily))
            {

                create0021.WriteLine("  1973,     1,     1,    .76,    .76,    .07,   .80905E-01,   .000,   .081,  41.32,   .000,    .00");
                create0021.WriteLine("  1973,     1,     2,    .79,    .79,    .09,   .95020E-01,   .000,   .095,  32.74,   .000,    .00");
                create0021.WriteLine("  1973,     1,     3,    .76,    .76,    .20,   .12447E+00,   .000,   .124,  26.92,   .000,    .00");
                create0021.WriteLine("  1973,     1,     4,    .00,    .00,    .18,   .12097E+00,   .000,   .121,  30.84,   .000,    .00");
                create0021.WriteLine("  1973,     1,     5,    .00,    .00,    .31,   .10946E+00,   .000,   .109,  36.83,   .000,    .00");
                create0021.WriteLine("  1973,     1,     6,    .51,    .51,    .19,   .11052E+00,   .000,   .111,  33.90,   .000,    .00");
                create0021.WriteLine("  1973,     1,     7,   1.09,   1.09,    .01,   .12221E+00,   .000,   .122,  21.47,   .000,    .00");

                //Clean up and close file
                create0021.Flush();
                create0021.Close();

            }//close writer
        }//close Method

        public void methodCreateMonthly()
        {

            using (StreamWriter create0022 = new StreamWriter(sMonthly))
            {

                create0022.WriteLine(" 1973, 1,   10.19,   10.19,    4.73,    3.85,     .00,      .00,       .00,     .00,   3.85");
                create0022.WriteLine("1973, 2,    9.25,    9.25,    5.88,    4.94,     .00,      .00,       .00,     .00,   4.94");
                create0022.WriteLine("1973, 3,   32.33,   22.91,   13.76,    6.74,    8.62,      .00,       .00,     .00,  15.36");

                //Clean up and close file
                create0022.Flush();
                create0022.Close();

            }//close writer
        }//close Method


        public void methodCreateYearly()
        {

            using (StreamWriter create0022 = new StreamWriter(sYearly))
            {

                create0022.WriteLine("1973,   200.74,   162.78,   110.29,    50.64,   36.37,  455.39,   87.07,     .00");
                create0022.WriteLine("1974,   144.70,   140.51,   102.61,    41.13,    5.79,  190.27,   47.02,     .00");
                create0022.WriteLine("1975,   167.89,   148.35,   105.80,    44.50,   19.55, 1242.30,   64.10,     .00");

                //Clean up and close file
                create0022.Flush();
                create0022.Close();

            }//close writer
        }//close Method


        public void methodCreatesCSV_Options()
        {

            using (StreamWriter create0023 = new StreamWriter(sCSV_Options))
            {

                create0023.WriteLine("Cancel");
                create0023.WriteLine("Daily---------------");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("Monthly---------------");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("Yearly---------------");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("Cumulative---------------");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("True");
                create0023.WriteLine("False");
                create0023.WriteLine("False");
                create0023.WriteLine("False");



                //Clean up and close file
                create0023.Flush();
                create0023.Close();

            }//close writer
        }//close Method








    }//close class
} //close namespace
