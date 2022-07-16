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
{//Open Namespace
    public partial class Main : Form
    {//Open Main Class


      #region "Globals"

        //*************************************************
        //Declare Globals
        //*************************************************

        //Data List Pairs
        //-------------------------------------------------
        //Daily
        private PointPairList PreWTList;
        private PointPairList DryZoneList;
        private PointPairList ObsWTList;
        private PointPairList ObsWTList2;
        private PointPairList ObsWTList3;
        private PointPairList RainfallList;
        private PointPairList InfiltrationList;
        private PointPairList PETList;
        private PointPairList AETList;
        private PointPairList DrainageList;
        private PointPairList RunoffList;
        private PointPairList WaterLossList;
        private PointPairList SurfaceStorageList;
        //Yearly
        //private PointPairList YearlyPreWTList;
        //private PointPairList YearlyDryZoneList;
        private PointPairList YearlyRainfallList;
        private PointPairList YearlyInfiltrationList;
        //private PointPairList YearlyPETList;
        private PointPairList YearlyAETList;
        private PointPairList YearlyDrainageList;
        private PointPairList YearlyRunoffList;
        private PointPairList YearlyWaterLossList;
        //private PointPairList YearlySurfaceStorageList;
        //Monthly
        //private PointPairList MonthlyPreWTList;
       // private PointPairList MonthlyDryZoneList;
        private PointPairList MonthlyRainfallList;
        private PointPairList MonthlyInfiltrationList;
        //private PointPairList MonthlyPETList;
        private PointPairList MonthlyAETList;
        private PointPairList MonthlyDrainageList;
        private PointPairList MonthlyRunoffList;
        private PointPairList MonthlyWaterLossList;
        //private PointPairList MonthlySurfaceStorageList;
        //Cumulative
       // private PointPairList CumulativePreWTList;
        //private PointPairList CumulativeDryZoneList;
        private PointPairList CumulativeRainfallList;
        private PointPairList CumulativeInfiltrationList;
        //private PointPairList CumulativePETList;
        private PointPairList CumulativeAETList;
        private PointPairList CumulativeDrainageList;
        private PointPairList CumulativeRunoffList;
        private PointPairList CumulativeWaterLossList;
        //private PointPairList CumulativeSurfaceStorageList;

        //Statistics
        //-------------------------------------------------
        //Group 1
        private PointPairList Variable1aList;
        private PointPairList Variable1bList;
        private PointPairList Variable1YList;
        public double[] Variable1aArray;
        public double[] Variable1bArray;
        private List<double> Variable1aArrayList;
        private List<double> Variable1bArrayList;
        //Group 2
        private PointPairList Variable2aList;
        private PointPairList Variable2bList;
        private PointPairList Variable2YList;
        public double[] Variable2aArray;
        public double[] Variable2bArray;
        private List<double> Variable2aArrayList;
        private List<double> Variable2bArrayList;
        //Group 2
        private PointPairList Variable3aList;
        private PointPairList Variable3bList;
        private PointPairList Variable3YList;
        public double[] Variable3aArray;
        public double[] Variable3bArray;
        private List<double> Variable3aArrayList;
        private List<double> Variable3bArrayList;

        //Type of plot currently displayed
        //-------------------------------------------------
        private string sPlotType;

        //Variables
        //-------------------------------------------------
        private double dFirstDate;

        //Dates in GRH File
        //-------------------------------------------------
        int iStartGRHYear;
        int iStartGRHMonth;
        int iStartGRHDay;
        int iEndGRHYear;
        int iEndGRHMonth;
        int iEndGRHDay;

        //Plots
        //-------------------------------------------------
        //Lines
        //Daily
        private LineItem PreWTCurve;
        private LineItem myCurveObs;
        private LineItem myCurveObs2;
        private LineItem myCurveObs3;
        private LineItem RainfallCurve;
        private LineItem InfiltrationCurve;
        private LineItem PETCurve;
        private LineItem AETCurve;
        private LineItem DrainageCurve;
        private LineItem RunoffCurve;
        private LineItem WaterLossCurve;
        private LineItem SurfaceStorageCurve;
        private LineItem DryZoneCurve;
        //Monthly
        //private LineItem MonthlyPreWTCurve;
        private LineItem MonthlyRainfallCurve;
        private LineItem MonthlyInfiltrationCurve;
        //private LineItem MonthlyPETCurve;
        private LineItem MonthlyAETCurve;
        private LineItem MonthlyDrainageCurve;
        private LineItem MonthlyRunoffCurve;
        private LineItem MonthlyWaterLossCurve;
       // private LineItem MonthlySurfaceStorageCurve;
        //private LineItem MonthlyDryZoneCurve;
        //Cumulative
       // private LineItem CumulativePreWTCurve;
        private LineItem CumulativeRainfallCurve;
        private LineItem CumulativeInfiltrationCurve;
        //private LineItem CumulativePETCurve;
        private LineItem CumulativeAETCurve;
        private LineItem CumulativeDrainageCurve;
        private LineItem CumulativeRunoffCurve;
        private LineItem CumulativeWaterLossCurve;
        //private LineItem CumulativeSurfaceStorageCurve;
        //private LineItem CumulativeDryZoneCurve;
        //Yearly
        //private LineItem YearlyPreWTCurve;
        private LineItem YearlyRainfallCurve;
        private LineItem YearlyInfiltrationCurve;
        //private LineItem YearlyPETCurve;
        private LineItem YearlyAETCurve;
        private LineItem YearlyDrainageCurve;
        private LineItem YearlyRunoffCurve;
        private LineItem YearlyWaterLossCurve;
        //private LineItem YearlySurfaceStorageCurve;
        //private LineItem YearlyDryZoneCurve;

        //Bar
        //Daily
        private BarItem PreWTBar;
        private BarItem myBarObs;
        private BarItem myBarObs2;
        private BarItem myBarObs3;
        private BarItem RainfallBar;
        private BarItem InfiltrationBar;
        private BarItem PETBar;
        private BarItem AETBar;
        private BarItem DrainageBar;
        private BarItem RunoffBar;
        private BarItem WaterLossBar;
        private BarItem SurfaceStorageBar;
        private BarItem DryZoneBar;
        //Monthly
        //private BarItem MonthlyPreWTBar;
        private BarItem MonthlyRainfallBar;
        private BarItem MonthlyInfiltrationBar;
        //private BarItem MonthlyPETBar;
        private BarItem MonthlyAETBar;
        private BarItem MonthlyDrainageBar;
        private BarItem MonthlyRunoffBar;
        private BarItem MonthlyWaterLossBar;
        //private BarItem MonthlySurfaceStorageBar;
       // private BarItem MonthlyDryZoneBar;
        //Cumulative
        //private BarItem CumulativePreWTBar;
        private BarItem CumulativeRainfallBar;
        private BarItem CumulativeInfiltrationBar;
        //private BarItem CumulativePETBar;
        private BarItem CumulativeAETBar;
        private BarItem CumulativeDrainageBar;
        private BarItem CumulativeRunoffBar;
        private BarItem CumulativeWaterLossBar;
        //private BarItem CumulativeSurfaceStorageBar;
        //private BarItem CumulativeDryZoneBar;
        //Yearly
        //private BarItem YearlyPreWTBar;
        private BarItem YearlyRainfallBar;
        private BarItem YearlyInfiltrationBar;
        //private BarItem YearlyPETBar;
        private BarItem YearlyAETBar;
        private BarItem YearlyDrainageBar;
        private BarItem YearlyRunoffBar;
        private BarItem YearlyWaterLossBar;
       // private BarItem YearlySurfaceStorageBar;
        //private BarItem YearlyDryZoneBar;

        //CSV Writer
        //-------------------------------------------------
        private StreamWriter m_CSVWriter;
       
 #endregion   
    
        #region "XML Globals"

        //XML Writer
        //-------------------------------------------------
        string sSettingsCaller;
        string sCancelReload;

        //All Settings Variables
        //-------------------------------------------------

        #endregion


        //*************************************************
        //*************************************************




        public Main()

        #region "Initilaize Form Properties"

        //*************************************************
        //Initilaize Form Properties
        //*************************************************

        {
            InitializeComponent();  

        }

        //*************************************************
        //*************************************************

        #endregion


        #region "Form Load Properties"

        private void Form1_Load(object sender, EventArgs e)
        {


            //Loading frm = new Loading();
            //frm.Show(this);

            // Setup the graph
            CreateGraph(zg1);
            // Size the control to fill the form with a margin
            SetSize();
           //CSV Context Menu
            zg1.ContextMenuBuilder +=
            new ZedGraphControl.ContextMenuBuilderEventHandler(MyContextMenuBuilder);

            //frm.Dispose();


        }

        #endregion


        #region "Main Graphing Section - Reads Data, Creates Arrays, Generates Plot Curves"

        
        private void Scrolling_Setup(ZedGraphControl zgc)
        {
            //This Section Plots Initial Graph Data

            // Get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            #region "Instantiate data points lists"

            // Instantiate data points lists
            PreWTList = new PointPairList();
            DryZoneList = new PointPairList();
            RainfallList = new PointPairList();
            InfiltrationList = new PointPairList();
            PETList = new PointPairList();
            AETList = new PointPairList();
            DrainageList = new PointPairList();
            RunoffList = new PointPairList();
            WaterLossList = new PointPairList();
            SurfaceStorageList = new PointPairList();
            //Yearly
            //YearlyPreWTList = new PointPairList();
            //YearlyDryZoneList = new PointPairList();
            YearlyRainfallList = new PointPairList();
            YearlyInfiltrationList = new PointPairList();
            //YearlyPETList = new PointPairList();
            YearlyAETList = new PointPairList();
            YearlyDrainageList = new PointPairList();
            YearlyRunoffList = new PointPairList();
            YearlyWaterLossList = new PointPairList();
            //YearlySurfaceStorageList = new PointPairList();
            //Monthly
            //MonthlyPreWTList = new PointPairList();
            //MonthlyDryZoneList = new PointPairList();
            MonthlyRainfallList = new PointPairList();
            MonthlyInfiltrationList = new PointPairList();
            //MonthlyPETList = new PointPairList();
            MonthlyAETList = new PointPairList();
            MonthlyDrainageList = new PointPairList();
            MonthlyRunoffList = new PointPairList();
            MonthlyWaterLossList = new PointPairList();
            //MonthlySurfaceStorageList = new PointPairList();
            //Cumulative
            //CumulativePreWTList = new PointPairList();
            //CumulativeDryZoneList = new PointPairList();
            CumulativeRainfallList = new PointPairList();
            CumulativeInfiltrationList = new PointPairList();
            //CumulativePETList = new PointPairList();
            CumulativeAETList = new PointPairList();
            CumulativeDrainageList = new PointPairList();
            CumulativeRunoffList = new PointPairList();
            CumulativeWaterLossList = new PointPairList();
            //CumulativeSurfaceStorageList = new PointPairList();

            #endregion


            #region "Read in data and create lists"

            //*****************************************************************
            //*****************************************************************
            //READING IN DATA

            //Thread.Sleep(2000);
                   
            //Open C:/Info.dat file. This file has full path to raw data files
            StreamReader InfoDat = new StreamReader("C:/DM_Info.dat");
            string sGrdPath = InfoDat.ReadLine();
            string sGrmPath = InfoDat.ReadLine();
            string sGryPath = InfoDat.ReadLine();
            InfoDat.Close();
            
            //1.Read in Daily Data
            // Open the GRD file

            StreamReader inFile = new StreamReader(sGrdPath);

            //Parameters in GRD file, in order, are as follows
            //Year
            //Month
            //Date
            //Rainfall
            //Infiltration
            //AET
            //Drainage
            //Runoff
            //Water Loss
            //Water Table Depth
            //Dry Zone Depth
            //Surface Storage

            //Initialize Leap Year Boolean
            bool leapYear = false;

            //Initialize Cumulative Variables
            double yYear = 0;
            double cRainfall = 0;
            double cInfiltration = 0;
            double cAET = 0;
            double cDrainage = 0;
            double cRunoff = 0;
            double cWaterLoss = 0;


            //Initialize Dates of GRD File
            int iYear = 0;
            int iMonth = 0;
            int iDay = 0;
            iStartGRHYear = 0;
            iStartGRHMonth = 0;
            iStartGRHDay = 0;
            iEndGRHYear = 0;
            iEndGRHMonth = 0;
            iEndGRHDay = 0;

            // Use the comma character to separate GRH items
            char[] sep = { ',' };

            string line;

            // Read one line of data at a time until the end of file
            while ((line = inFile.ReadLine()) != null)
            {
                // Convert each line in to an array of strings
                //Each loop through overwrites previous array
                //Split the items on the line using the , character as delimiter (declared above)
                string[] items = line.Split(sep);
                // If there's less than 2 items, throw an exception
                if (items.Length < 2)
                    throw new Exception("Error: Not enough data points to plot");

                //Declare Variables in GRH file
                double dYear, dMonth, dDay, dRainfall, dInfiltration, dAET, dDrainage;
                double dRunoff, dWaterLoss, dPreWT;
                double dDryZoneDepth, dSurfaceStorage;


                // If the value is missing mark it so. Otherwise, parse it as a double
                if (items[0].Length == 0)
                    dYear = PointPair.Missing;
                else
                    dYear = Double.Parse(items[0]);

                if (items[1].Length == 0)
                    dMonth = PointPair.Missing;
                else
                    dMonth = Double.Parse(items[1]);

                if (items[2].Length == 0)
                    dDay = PointPair.Missing;
                else
                    dDay = Double.Parse(items[2]);

                if (items[3].Length == 0)
                    dRainfall = PointPair.Missing;
                else
                    dRainfall = Double.Parse(items[3]);

                if (items[4].Length == 0)
                    dInfiltration = PointPair.Missing;
                else
                    dInfiltration = Double.Parse(items[4]);
                
                if (items[5].Length == 0)
                    dAET = PointPair.Missing;
                else
                    dAET = Double.Parse(items[5]);

                if (items[6].Length == 0)
                    dDrainage = PointPair.Missing;
                else
                    dDrainage = Double.Parse(items[6]);

                if (items[7].Length == 0)
                    dRunoff = PointPair.Missing;
                else
                    dRunoff = Double.Parse(items[7]);

                if (items[8].Length == 0)
                    dWaterLoss = PointPair.Missing;
                else
                    dWaterLoss = Double.Parse(items[8]);

                if (items[9].Length == 0)
                    dPreWT = PointPair.Missing;
                else
                    dPreWT = Double.Parse(items[9]);

                if (items[10].Length == 0)
                    dDryZoneDepth = PointPair.Missing;
                else
                    dDryZoneDepth = Double.Parse(items[10]);

                if (items[11].Length == 0)
                    dSurfaceStorage = PointPair.Missing;
                else
                    dSurfaceStorage = Double.Parse(items[11]);


                //Convert Date to XDate Format for graphing
                //First convert double to integers
                iYear = Convert.ToInt32(dYear);
                iMonth = Convert.ToInt32(dMonth);
                iDay = Convert.ToInt32(dDay);

                //Check for Leap Year
                //http://www.dotnetspider.com/resources/17593-How-Check-Leap-Year-using-C.aspx
                leapYear = (((iYear % 4) == 0) && ((iYear % 100) != 0) || ((iYear % 400) == 0));

                //Then do Zedgraph XDate
                XDate myXDate = new XDate(iYear, iMonth, iDay);
                Double dDate = myXDate;
                //XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                //Double dDateMonth = myXDateMonth;
                //double dYearlyYear = dYear;

                //Add Daily Values to Daily Lists
                PreWTList.Add(dDate, dPreWT);
                DryZoneList.Add(dDate, dDryZoneDepth);
                RainfallList.Add(dDate, dRainfall);
                InfiltrationList.Add(dDate, dInfiltration);
                AETList.Add(dDate, dAET);
                DrainageList.Add(dDate, dDrainage);
                RunoffList.Add(dDate, dRunoff);
                WaterLossList.Add(dDate, dWaterLoss);
                SurfaceStorageList.Add(dDate, dSurfaceStorage);
              


                //Get starting date of file
                //if (yYear == 0)
                //{
                //    iStartGRHYear = iYear;
                //    iStartGRHMonth = iMonth;
                //    iStartGRHDay = iDay;
                //}

                
                if (yYear == 0)
                {

                    cRainfall = dRainfall;
                    cInfiltration = dInfiltration;
                    cAET = dAET;
                    cDrainage = dDrainage;
                    cRunoff = dRunoff;
                    cWaterLoss = dWaterLoss;

                }

                if (yYear == iYear)
                {
                    cRainfall = cRainfall + dRainfall;
                    cInfiltration = cInfiltration + dInfiltration;
                    cAET = cAET + dAET;
                    cDrainage = cDrainage + dDrainage;
                    cRunoff = cRunoff + dRunoff;
                    cWaterLoss = cWaterLoss + dWaterLoss;

                }


                if (iMonth == 1 && iDay == 1)
                {
                    cRainfall = dRainfall;
                    cInfiltration = dInfiltration;
                    cAET = dAET;
                    cDrainage = dDrainage;
                    cRunoff = dRunoff;
                    cWaterLoss = dWaterLoss;

                }
               

                CumulativeRainfallList.Add(dDate, cRainfall);
                CumulativeInfiltrationList.Add(dDate, cInfiltration);
                CumulativeAETList.Add(dDate, cAET);
                CumulativeDrainageList.Add(dDate, cDrainage);
                CumulativeRunoffList.Add(dDate, cRunoff);
                CumulativeWaterLossList.Add(dDate, cWaterLoss);

            }//Close while read in loop

                //Get end date of GRD file
                //iEndGRHYear = iYear;
                //iEndGRHMonth = iMonth;
                //iEndGRHDay = iDay;

                //Set End Date of visible scale to start date plus 2 years
                //int iGRHMonthVisible = iStartGRHMonth;
                //int iGRHDayVisible = iStartGRHDay;
                //int iGRHYearVisible = iStartGRHYear + 2;


                //Close GRD file
                inFile.Close();

                //Add Start and End date to text boxes under Scale Group
                //this.textStartDate.Text = Convert.ToString(iStartGRHMonth) + "/" + Convert.ToString(iStartGRHDay) + "/" + Convert.ToString(iStartGRHYear);
                //this.textEndDate.Text = Convert.ToString(iGRHMonthVisible) + "/" + Convert.ToString(iStartGRHDay) + "/" + Convert.ToString(iGRHYearVisible);

                //*****************************************************************
                //*****************************************************************

                 //2.Read in Monthly Values
                // Open the GRD file

                StreamReader inFileM = new StreamReader(sGrmPath);

                //Parameters in GRM file, in order, are as follows
                //Year
                //Month
                //Rainfall
                //Infiltration
                //AET
                //Drainage
                //Runoff
                //SEW
                //Dry Days
                //Pump Vol
                //Water Loss

                string lineM;

            // Read one line of data at a time until the end of file
                while ((lineM = inFileM.ReadLine()) != null)
                {
                    // Convert each line in to an array of strings
                    //Each loop through overwrites previous array
                    //Split the items on the line using the , character as delimiter (declared above)
                    string[] itemsM = lineM.Split(sep);
                    // If there's less than 2 items, throw an exception
                    if (itemsM.Length < 2)
                        throw new Exception("Error: Not enough data points to plot");

                    //Declare Variables in GRH file
                    double dYearM, dMonthM, dRainfallM, dInfiltrationM, dAETM, dDrainageM;
                    double dRunoffM, dSEWM, dDryDaysM, dPumpVolM, dWaterLossM;

                    // If the value is missing mark it so. Otherwise, parse it as a double
                    if (itemsM[0].Length == 0)
                        dYearM = PointPair.Missing;
                    else
                        dYearM = Double.Parse(itemsM[0]);

                    if (itemsM[1].Length == 0)
                        dMonthM = PointPair.Missing;
                    else
                        dMonthM = Double.Parse(itemsM[1]);

                    if (itemsM[2].Length == 0)
                        dRainfallM = PointPair.Missing;
                    else
                        dRainfallM = Double.Parse(itemsM[2]);

                    if (itemsM[3].Length == 0)
                        dInfiltrationM = PointPair.Missing;
                    else
                        dInfiltrationM = Double.Parse(itemsM[3]);

                    if (itemsM[4].Length == 0)
                        dAETM = PointPair.Missing;
                    else
                        dAETM = Double.Parse(itemsM[4]);

                    if (itemsM[5].Length == 0)
                        dDrainageM = PointPair.Missing;
                    else
                        dDrainageM = Double.Parse(itemsM[5]);

                    if (itemsM[6].Length == 0)
                        dRunoffM = PointPair.Missing;
                    else
                        dRunoffM = Double.Parse(itemsM[6]);

                    if (itemsM[7].Length == 0)
                        dSEWM = PointPair.Missing;
                    else
                        dSEWM = Double.Parse(itemsM[7]);

                    if (itemsM[8].Length == 0)
                        dDryDaysM = PointPair.Missing;
                    else
                        dDryDaysM = Double.Parse(itemsM[8]);

                    if (itemsM[9].Length == 0)
                        dPumpVolM = PointPair.Missing;
                    else
                        dPumpVolM = Double.Parse(itemsM[9]);

                    if (itemsM[10].Length == 0)
                        dWaterLossM = PointPair.Missing;
                    else
                        dWaterLossM = Double.Parse(itemsM[10]);



                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    iYear = Convert.ToInt32(dYearM);
                    iMonth = Convert.ToInt32(dMonthM);
                    iDay = 15;

                    //Check for Leap Year
                    //http://www.dotnetspider.com/resources/17593-How-Check-Leap-Year-using-C.aspx
                    //leapYear = (((iYear % 4) == 0) && ((iYear % 100) != 0) || ((iYear % 400) == 0));

                    //Then do Zedgraph XDate
                    XDate myXDateM = new XDate(iYear, iMonth, iDay);
                    Double dDateM = myXDateM;
                    //XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                    //Double dDateMonth = myXDateMonth;
                    //double dYearlyYear = dYear;

                    //Add Daily Values to Daily Lists
                    MonthlyRainfallList.Add(dDateM, dRainfallM);
                    MonthlyInfiltrationList.Add(dDateM, dInfiltrationM);
                    MonthlyAETList.Add(dDateM, dAETM);
                    MonthlyDrainageList.Add(dDateM, dDrainageM);
                    MonthlyRunoffList.Add(dDateM, dRunoffM);
                    MonthlyWaterLossList.Add(dDateM, dWaterLossM);
                }

                //Close GRM file
                inFileM.Close();

                //*****************************************************************
                //*****************************************************************

                //2.Read in Yearly Values
                // Open the GRY file

                StreamReader inFileY = new StreamReader(sGryPath);

                //Parameters in GRD file, in order, are as follows
                //Year
                //Rainfall
                //Infiltration
                //AET
                //Drainage
                //Runoff
                //SEW
                //Water Loss
                //Pump Vol
                

                string lineY;

            // Read one line of data at a time until the end of file
            while ((lineY = inFileY.ReadLine()) != null)
            {
                // Convert each line in to an array of strings
                //Each loop through overwrites previous array
                //Split the items on the line using the , character as delimiter (declared above)
                string[] itemsY = lineY.Split(sep);
                // If there's less than 2 items, throw an exception
                if (itemsY.Length < 2)
                    throw new Exception("Error: Not enough data points to plot");

                //Declare Variables in GRH file
                double dYearY, dRainfallY, dInfiltrationY, dAETY, dDrainageY;
                double dRunoffY, dSEWY, dWaterLossY, dPumpVolY;

                // If the value is missing mark it so. Otherwise, parse it as a double
                if (itemsY[0].Length == 0)
                    dYearY = PointPair.Missing;
                else
                    dYearY = Double.Parse(itemsY[0]);

                if (itemsY[1].Length == 0)
                    dRainfallY = PointPair.Missing;
                else
                    dRainfallY = Double.Parse(itemsY[1]);

                if (itemsY[2].Length == 0)
                    dInfiltrationY = PointPair.Missing;
                else
                    dInfiltrationY = Double.Parse(itemsY[2]);

                if (itemsY[3].Length == 0)
                    dAETY = PointPair.Missing;
                else
                    dAETY = Double.Parse(itemsY[3]);

                if (itemsY[4].Length == 0)
                    dDrainageY = PointPair.Missing;
                else
                    dDrainageY = Double.Parse(itemsY[4]);

                if (itemsY[5].Length == 0)
                    dRunoffY = PointPair.Missing;
                else
                    dRunoffY = Double.Parse(itemsY[5]);

                if (itemsY[6].Length == 0)
                    dSEWY = PointPair.Missing;
                else
                    dSEWY = Double.Parse(itemsY[6]);

                if (itemsY[7].Length == 0)
                    dWaterLossY = PointPair.Missing;
                else
                    dWaterLossY = Double.Parse(itemsY[7]);

                if (itemsY[8].Length == 0)
                    dPumpVolY = PointPair.Missing;
                else
                    dPumpVolY = Double.Parse(itemsY[8]);




                //Convert Date to XDate Format for graphing
                //First convert double to integers
                iYear = Convert.ToInt32(dYearY);
                iMonth = 6;
                iDay = 15;

                //Check for Leap Year
                //http://www.dotnetspider.com/resources/17593-How-Check-Leap-Year-using-C.aspx
                //leapYear = (((iYear % 4) == 0) && ((iYear % 100) != 0) || ((iYear % 400) == 0));

                //Then do Zedgraph XDate
                XDate myXDateY = new XDate(iYear, iMonth, iDay);
                Double dDateY = myXDateY;
                //XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                //Double dDateMonth = myXDateMonth;
                //double dYearlyYear = dYear;

                //Add Daily Values to Daily Lists
                YearlyRainfallList.Add(dDateY, dRainfallY);
                YearlyInfiltrationList.Add(dDateY, dInfiltrationY);
                YearlyAETList.Add(dDateY, dAETY);
                YearlyDrainageList.Add(dDateY, dDrainageY);
                YearlyRunoffList.Add(dDateY, dRunoffY);
                YearlyWaterLossList.Add(dDateY, dWaterLossY);

            }

                //Close GRY file
                inFileY.Close();


            //*****************************************************************
            //*****************************************************************

            #endregion



            //*****************************************************************
            //Up to this point all data are read in and point lists generated
            //*****************************************************************



            #region "Curve Creation"
            


           // Plots
            //-------------------------------------------------
            //Daily
            //Lines
            PreWTCurve = myPane.AddCurve("Water Table Depth",
                      PreWTList, Color.Blue, SymbolType.Circle);

            DryZoneCurve = myPane.AddCurve("Dry Zone Depth",
                        DryZoneList, Color.Blue, SymbolType.Circle);

            RainfallCurve = myPane.AddCurve("Rainfall",
                        RainfallList, Color.Orange, SymbolType.Circle);
            
            InfiltrationCurve = myPane.AddCurve("Infiltration",
                        InfiltrationList, Color.Green, SymbolType.Circle);
            
            AETCurve = myPane.AddCurve("Evaporation",
                        AETList, Color.Indigo, SymbolType.Circle);
            
            DrainageCurve = myPane.AddCurve("Drainage",
                        DrainageList, Color.Violet, SymbolType.Circle);
            
            RunoffCurve = myPane.AddCurve("Surface Runoff",
                        RunoffList, Color.Gray, SymbolType.Circle);
            
            WaterLossCurve = myPane.AddCurve("Water Loss",
                        WaterLossList, Color.Yellow, SymbolType.Circle);
            
            SurfaceStorageCurve = myPane.AddCurve("Surface Storage",
                        SurfaceStorageList, Color.Pink, SymbolType.Circle);
            
            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar
            PreWTBar = myPane.AddBar("Water Table Depth",
                        PreWTList, Color.Blue);

            DryZoneBar = myPane.AddBar("Dry Zone Depth",
                        DryZoneList, Color.Blue);

            RainfallBar = myPane.AddBar("Rainfall",
                        RainfallList, Color.Orange);

            InfiltrationBar = myPane.AddBar("Infiltration",
                        InfiltrationList, Color.Green);

            AETBar = myPane.AddBar("Evaporation",
                        AETList, Color.Indigo);

            DrainageBar = myPane.AddBar("Drainage",
                        DrainageList, Color.Violet);

            RunoffBar = myPane.AddBar("Surface Runoff",
                        RunoffList, Color.Gray);

            WaterLossBar = myPane.AddBar("Water Loss",
                        WaterLossList, Color.Yellow);

            SurfaceStorageBar = myPane.AddBar("Surface Storage",
                        SurfaceStorageList, Color.Pink);


            //-------------------------------------------------
            //Monthly
            MonthlyRainfallCurve = myPane.AddCurve("Monthly Rainfall",
                        MonthlyRainfallList, Color.Orange, SymbolType.Circle);

            MonthlyInfiltrationCurve = myPane.AddCurve("Monthly Infiltration",
                        MonthlyInfiltrationList, Color.Green, SymbolType.Circle);

            MonthlyAETCurve = myPane.AddCurve("Monthly Evaporation",
                        MonthlyAETList, Color.Indigo, SymbolType.Circle);

            MonthlyDrainageCurve = myPane.AddCurve("Monthly Drainage",
                        MonthlyDrainageList, Color.Violet, SymbolType.Circle);

            MonthlyRunoffCurve = myPane.AddCurve("Monthly Surface Runoff",
                        MonthlyRunoffList, Color.Gray, SymbolType.Circle);

            MonthlyWaterLossCurve = myPane.AddCurve("Monthly Water Loss",
                        MonthlyWaterLossList, Color.Yellow, SymbolType.Circle);

            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar
            MonthlyRainfallBar = myPane.AddBar("Monthly Rainfall",
                        MonthlyRainfallList, Color.Orange);

            MonthlyInfiltrationBar = myPane.AddBar("Monthly Infiltration",
                        MonthlyInfiltrationList, Color.Green);

            MonthlyAETBar = myPane.AddBar("Monthly Evaporation",
                        MonthlyAETList, Color.Indigo);

            MonthlyDrainageBar = myPane.AddBar("Monthly Drainage",
                        MonthlyDrainageList, Color.Violet);

            MonthlyRunoffBar = myPane.AddBar("Monthly Surface Runoff",
                        MonthlyRunoffList, Color.Gray);

            MonthlyWaterLossBar = myPane.AddBar("Monthly Water Loss",
                        MonthlyWaterLossList, Color.Yellow);


            //-------------------------------------------------
            //Cumulative

            CumulativeRainfallCurve = myPane.AddCurve("Cumulative Rainfall",
                        CumulativeRainfallList, Color.Orange, SymbolType.Circle);

            CumulativeInfiltrationCurve = myPane.AddCurve("Cumulative Infiltration",
                        CumulativeInfiltrationList, Color.Green, SymbolType.Circle);

            CumulativeAETCurve = myPane.AddCurve("Cumulative Evaporation",
                        CumulativeAETList, Color.Indigo, SymbolType.Circle);

            CumulativeDrainageCurve = myPane.AddCurve("Cumulative Drainage",
                        CumulativeDrainageList, Color.Violet, SymbolType.Circle);

            CumulativeRunoffCurve = myPane.AddCurve("Cumulative Surface Runoff",
                        CumulativeRunoffList, Color.Gray, SymbolType.Circle);

            CumulativeWaterLossCurve = myPane.AddCurve("Cumulative Water Loss",
                        CumulativeWaterLossList, Color.Yellow, SymbolType.Circle);

            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar

            CumulativeRainfallBar = myPane.AddBar("Cumulative Rainfall",
                        CumulativeRainfallList, Color.Orange);

            CumulativeInfiltrationBar = myPane.AddBar("Cumulative Infiltration",
                        CumulativeInfiltrationList, Color.Green);

            CumulativeAETBar = myPane.AddBar("Cumulative Evaporation",
                        CumulativeAETList, Color.Indigo);

            CumulativeDrainageBar = myPane.AddBar("Cumulative Drainage",
                        CumulativeDrainageList, Color.Violet);

            CumulativeRunoffBar = myPane.AddBar("Cumulative Surface Runoff",
                        CumulativeRunoffList, Color.Gray);

            CumulativeWaterLossBar = myPane.AddBar("Cumulative Water Loss",
                        CumulativeWaterLossList, Color.Yellow);

            //-------------------------------------------------
            //Yearly

            YearlyRainfallCurve = myPane.AddCurve("Annual Rainfall",
                        YearlyRainfallList, Color.Orange, SymbolType.Circle);

            YearlyInfiltrationCurve = myPane.AddCurve("Annual Infiltration",
                        YearlyInfiltrationList, Color.Green, SymbolType.Circle);

            YearlyAETCurve = myPane.AddCurve("Annual Evaporation",
                        YearlyAETList, Color.Indigo, SymbolType.Circle);

            YearlyDrainageCurve = myPane.AddCurve("Annual Drainage",
                        YearlyDrainageList, Color.Violet, SymbolType.Circle);

            YearlyRunoffCurve = myPane.AddCurve("Annual Surface Runoff",
                        YearlyRunoffList, Color.Gray, SymbolType.Circle);

            YearlyWaterLossCurve = myPane.AddCurve("Annual Water Loss",
                        YearlyWaterLossList, Color.Yellow, SymbolType.Circle);

            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar
            YearlyRainfallBar = myPane.AddBar("Annual Rainfall",
                        YearlyRainfallList, Color.Orange);

            YearlyInfiltrationBar = myPane.AddBar("Annual Infiltration",
                        YearlyInfiltrationList, Color.Green);

            YearlyAETBar = myPane.AddBar("Annual Evaporation",
                        YearlyAETList, Color.Indigo);

            YearlyDrainageBar = myPane.AddBar("Annual Drainage",
                        YearlyDrainageList, Color.Violet);

            YearlyRunoffBar = myPane.AddBar("Annual Surface Runoff",
                        YearlyRunoffList, Color.Gray);

            YearlyWaterLossBar = myPane.AddBar("Annual Water Loss",
                        YearlyWaterLossList, Color.Yellow);





            //*******************************
            //Reading in and setting a color et al
            //*******************************
            //string scolor1 = "Blue";
            //string scolor2 = "Red";
            //System.Drawing.ColorConverter colConvert = new ColorConverter();
            //myPane.YAxis.Scale.FontSpec.FontColor = (System.Drawing.Color)colConvert.ConvertFromString(scolor1);
            //myPane.Y2Axis.Scale.FontSpec.FontColor = (System.Drawing.Color)colConvert.ConvertFromString(scolor2);

            //string sfont1 = "Times New Roman";
            //myPane.Y2Axis.Scale.FontSpec.Family = sfont1;
            //int sfontsize1 = 14;
            //myPane.Y2Axis.Scale.FontSpec.Size = sfontsize1;
            //bool sfontbold = true;
            //myPane.Y2Axis.Scale.FontSpec.IsBold = sfontbold;


            //*******************************
            //*******************************


           // //Line Thickness
           // //-------------------------------------------------

           // //Daily
           // PreWTCurve.Line.Width = 3.0F;
           // DryZoneCurve.Line.Width = 3.0F;
           // RainfallCurve.Line.Width = 3.0F;
           // InfiltrationCurve.Line.Width = 3.0F;
           // AETCurve.Line.Width = 3.0F;
           // DrainageCurve.Line.Width = 3.0F;
           // RunoffCurve.Line.Width = 3.0F;
           // WaterLossCurve.Line.Width = 3.0F;
           // SurfaceStorageCurve.Line.Width = 3.0F;
           // //Monthly

           // MonthlyRainfallCurve.Line.Width = 3.0F;
           // MonthlyInfiltrationCurve.Line.Width = 3.0F;
           // MonthlyAETCurve.Line.Width = 3.0F;
           // MonthlyDrainageCurve.Line.Width = 3.0F;
           // MonthlyRunoffCurve.Line.Width = 3.0F;
           // MonthlyWaterLossCurve.Line.Width = 3.0F;

           // //Cumulative

           // CumulativeRainfallCurve.Line.Width = 3.0F;
           // CumulativeInfiltrationCurve.Line.Width = 3.0F;
           // CumulativeAETCurve.Line.Width = 3.0F;
           // CumulativeDrainageCurve.Line.Width = 3.0F;
           // CumulativeRunoffCurve.Line.Width = 3.0F;
           // CumulativeWaterLossCurve.Line.Width = 3.0F;

           // //Annual

           // YearlyRainfallCurve.Line.Width = 3.0F;
           // YearlyInfiltrationCurve.Line.Width = 3.0F;
           // YearlyAETCurve.Line.Width = 3.0F;
           // YearlyDrainageCurve.Line.Width = 3.0F;
           // YearlyRunoffCurve.Line.Width = 3.0F;
           // YearlyWaterLossCurve.Line.Width = 3.0F;


           // // Increase the symbol sizes, and fill them with solid white
           // //-------------------------------------------------
           // //Daily
           // PreWTCurve.Symbol.Size = 1.0F;
           // PreWTCurve.Symbol.Fill = new Fill(Color.White);

           // DryZoneCurve.Symbol.Size = 3.0F;
           // DryZoneCurve.Symbol.Fill = new Fill(Color.White);

           // RainfallCurve.Symbol.Size = 3.0F;
           // RainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //RainfallCurve.IsY2Axis = true;

           // InfiltrationCurve.Symbol.Size = 3.0F;
           // InfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // //InfiltrationCurve.IsY2Axis = true;

           // AETCurve.Symbol.Size = 3.0F;
           // AETCurve.Symbol.Fill = new Fill(Color.White);
           //// AETCurve.IsY2Axis = true;

           // DrainageCurve.Symbol.Size = 3.0F;
           // DrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //DrainageCurve.IsY2Axis = true;

           // RunoffCurve.Symbol.Size = 3.0F;
           // RunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //RunoffCurve.IsY2Axis = true;

           // WaterLossCurve.Symbol.Size = 3.0F;
           // WaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //WaterLossCurve.IsY2Axis = true;

           // SurfaceStorageCurve.Symbol.Size = 3.0F;
           // SurfaceStorageCurve.Symbol.Fill = new Fill(Color.White);
           // //SurfaceStorageCurve.IsY2Axis = true;

           // //Monthly

           // MonthlyRainfallCurve.Symbol.Size = 3.0F;
           // MonthlyRainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyRainfallCurve.IsY2Axis = true;

           // MonthlyInfiltrationCurve.Symbol.Size = 3.0F;
           // MonthlyInfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // // MonthlyInfiltrationCurve.IsY2Axis = true;

           // MonthlyAETCurve.Symbol.Size = 3.0F;
           // MonthlyAETCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyAETCurve.IsY2Axis = true;

           // MonthlyDrainageCurve.Symbol.Size = 3.0F;
           // MonthlyDrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyDrainageCurve.IsY2Axis = true;

           // MonthlyRunoffCurve.Symbol.Size = 3.0F;
           // MonthlyRunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyRunoffCurve.IsY2Axis = true;

           // MonthlyWaterLossCurve.Symbol.Size = 3.0F;
           // MonthlyWaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyWaterLossCurve.IsY2Axis = true;


           // //Cumulative

           // CumulativeRainfallCurve.Symbol.Size = 3.0F;
           // CumulativeRainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeRainfallCurve.IsY2Axis = true;

           // CumulativeInfiltrationCurve.Symbol.Size = 3.0F;
           // CumulativeInfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeInfiltrationCurve.IsY2Axis = true;

           // CumulativeAETCurve.Symbol.Size = 3.0F;
           // CumulativeAETCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeAETCurve.IsY2Axis = true;

           // CumulativeDrainageCurve.Symbol.Size = 3.0F;
           // CumulativeDrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeDrainageCurve.IsY2Axis = true;

           // CumulativeRunoffCurve.Symbol.Size = 3.0F;
           // CumulativeRunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeRunoffCurve.IsY2Axis = true;

           // CumulativeWaterLossCurve.Symbol.Size = 3.0F;
           // CumulativeWaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeWaterLossCurve.IsY2Axis = true;


           // //Yearly
           // YearlyRainfallCurve.Symbol.Size = 3.0F;
           // YearlyRainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyRainfallCurve.IsY2Axis = true;

           // YearlyInfiltrationCurve.Symbol.Size = 3.0F;
           // YearlyInfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyInfiltrationCurve.IsY2Axis = true;

           // YearlyAETCurve.Symbol.Size = 3.0F;
           // YearlyAETCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyAETCurve.IsY2Axis = true;

           // YearlyDrainageCurve.Symbol.Size = 3.0F;
           // YearlyDrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyDrainageCurve.IsY2Axis = true;

           // YearlyRunoffCurve.Symbol.Size = 3.0F;
           // YearlyRunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyRunoffCurve.IsY2Axis = true;

           // YearlyWaterLossCurve.Symbol.Size = 3.0F;
           // YearlyWaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyWaterLossCurve.IsY2Axis = true;




            // Set the initial viewed range
            //-------------------------------------------------
            //First extract first date of GRH data
            //string sFirstDateList = PreWTList[0].ToString();
            //string[] sRightSide = sFirstDateList.Split('(');
            //string sRightSide2 = sRightSide[1];
            //string[] sSplit = sRightSide2.Split(',');
            //string sFirstDate = sSplit[0];
            //dFirstDate = Convert.ToDouble(sFirstDate);

            //Then set graph to start at the first date with default 2 years showing
            //int iDisplayMonths = 24;

            //this.textLengthTime.Text = Convert.ToString(iDisplayMonths);
            //zgc.GraphPane.XAxis.Scale.Min = dFirstDate;
            //zgc.GraphPane.XAxis.Scale.Max = dFirstDate+735;

            //zgc.GraphPane.XAxis.Scale.Format = 

            //Hide Variables at Startup
            //-------------------------------------------------
            //Lines
            //Daily
            SurfaceStorageCurve.IsVisible = false;
            SurfaceStorageCurve.Label.IsVisible = false;
            DryZoneCurve.IsVisible = false;
            DryZoneCurve.Label.IsVisible = false;
            RainfallCurve.IsVisible = false;
            RainfallCurve.Label.IsVisible = false;
            InfiltrationCurve.IsVisible = false;
            InfiltrationCurve.Label.IsVisible = false;
            AETCurve.IsVisible = false;
            AETCurve.Label.IsVisible = false;
            DrainageCurve.IsVisible = false;
            DrainageCurve.Label.IsVisible = false;
            RunoffCurve.IsVisible = false;
            RunoffCurve.Label.IsVisible = false;
            WaterLossCurve.IsVisible = false;
            WaterLossCurve.Label.IsVisible = false;
            SurfaceStorageCurve.IsVisible = false;
            SurfaceStorageCurve.Label.IsVisible = false;
            //Monthly

            MonthlyRainfallCurve.IsVisible = false;
            MonthlyRainfallCurve.Label.IsVisible = false;
            MonthlyInfiltrationCurve.IsVisible = false;
            MonthlyInfiltrationCurve.Label.IsVisible = false;
            MonthlyAETCurve.IsVisible = false;
            MonthlyAETCurve.Label.IsVisible = false;
            MonthlyDrainageCurve.IsVisible = false;
            MonthlyDrainageCurve.Label.IsVisible = false;
            MonthlyRunoffCurve.IsVisible = false;
            MonthlyRunoffCurve.Label.IsVisible = false;
            MonthlyWaterLossCurve.IsVisible = false;
            MonthlyWaterLossCurve.Label.IsVisible = false;

            //Cumulative
           
            CumulativeRainfallCurve.IsVisible = false;
            CumulativeRainfallCurve.Label.IsVisible = false;
            CumulativeInfiltrationCurve.IsVisible = false;
            CumulativeInfiltrationCurve.Label.IsVisible = false;
            CumulativeAETCurve.IsVisible = false;
            CumulativeAETCurve.Label.IsVisible = false;
            CumulativeDrainageCurve.IsVisible = false;
            CumulativeDrainageCurve.Label.IsVisible = false;
            CumulativeRunoffCurve.IsVisible = false;
            CumulativeRunoffCurve.Label.IsVisible = false;
            CumulativeWaterLossCurve.IsVisible = false;
            CumulativeWaterLossCurve.Label.IsVisible = false;

            //Yearly
           
            YearlyRainfallCurve.IsVisible = false;
            YearlyRainfallCurve.Label.IsVisible = false;
            YearlyInfiltrationCurve.IsVisible = false;
            YearlyInfiltrationCurve.Label.IsVisible = false;
            YearlyAETCurve.IsVisible = false;
            YearlyAETCurve.Label.IsVisible = false;
            YearlyDrainageCurve.IsVisible = false;
            YearlyDrainageCurve.Label.IsVisible = false;
            YearlyRunoffCurve.IsVisible = false;
            YearlyRunoffCurve.Label.IsVisible = false;
            YearlyWaterLossCurve.IsVisible = false;
            YearlyWaterLossCurve.Label.IsVisible = false;

            
            
            //Bars
            //Daily
            PreWTBar.IsVisible = false;
            PreWTBar.Label.IsVisible = false;
            SurfaceStorageBar.IsVisible = false;
            SurfaceStorageBar.Label.IsVisible = false;
            DryZoneBar.IsVisible = false;
            DryZoneBar.Label.IsVisible = false;
            RainfallBar.IsVisible = false;
            RainfallBar.Label.IsVisible = false;
            InfiltrationBar.IsVisible = false;
            InfiltrationBar.Label.IsVisible = false;
            AETBar.IsVisible = false;
            AETBar.Label.IsVisible = false;
            DrainageBar.IsVisible = false;
            DrainageBar.Label.IsVisible = false;
            RunoffBar.IsVisible = false;
            RunoffBar.Label.IsVisible = false;
            WaterLossBar.IsVisible = false;
            WaterLossBar.Label.IsVisible = false;
            SurfaceStorageBar.IsVisible = false;
            SurfaceStorageBar.Label.IsVisible = false;
            //Monthly
           
            MonthlyRainfallBar.IsVisible = false;
            MonthlyRainfallBar.Label.IsVisible = false;
            MonthlyInfiltrationBar.IsVisible = false;
            MonthlyInfiltrationBar.Label.IsVisible = false;
            MonthlyAETBar.IsVisible = false;
            MonthlyAETBar.Label.IsVisible = false;
            MonthlyDrainageBar.IsVisible = false;
            MonthlyDrainageBar.Label.IsVisible = false;
            MonthlyRunoffBar.IsVisible = false;
            MonthlyRunoffBar.Label.IsVisible = false;
            MonthlyWaterLossBar.IsVisible = false;
            MonthlyWaterLossBar.Label.IsVisible = false;

            //Cumulative

            CumulativeRainfallBar.IsVisible = false;
            CumulativeRainfallBar.Label.IsVisible = false;
            CumulativeInfiltrationBar.IsVisible = false;
            CumulativeInfiltrationBar.Label.IsVisible = false;
            CumulativeAETBar.IsVisible = false;
            CumulativeAETBar.Label.IsVisible = false;
            CumulativeDrainageBar.IsVisible = false;
            CumulativeDrainageBar.Label.IsVisible = false;
            CumulativeRunoffBar.IsVisible = false;
            CumulativeRunoffBar.Label.IsVisible = false;
            CumulativeWaterLossBar.IsVisible = false;
            CumulativeWaterLossBar.Label.IsVisible = false;

            //Yearly

            YearlyRainfallBar.IsVisible = false;
            YearlyRainfallBar.Label.IsVisible = false;
            YearlyInfiltrationBar.IsVisible = false;
            YearlyInfiltrationBar.Label.IsVisible = false;
            YearlyAETBar.IsVisible = false;
            YearlyAETBar.Label.IsVisible = false;
            YearlyDrainageBar.IsVisible = false;
            YearlyDrainageBar.Label.IsVisible = false;
            YearlyRunoffBar.IsVisible = false;
            YearlyRunoffBar.Label.IsVisible = false;
            YearlyWaterLossBar.IsVisible = false;
            YearlyWaterLossBar.Label.IsVisible = false;


            // Calculate the Axis Scale Ranges
            zgc.AxisChange();


            #endregion


            #region "Initialize Obs Lists and Plots"

            myCurveObs = myPane.AddCurve("Empty",
                PreWTList,Color.Black);
            myBarObs = myPane.AddBar("Empty",
                PreWTList, Color.Black);
            myCurveObs2 = myPane.AddCurve("Empty",
                PreWTList, Color.Black, SymbolType.Circle);
            myBarObs2 = myPane.AddBar("Empty",
                PreWTList, Color.Black);
            myCurveObs3 = myPane.AddCurve("Empty",
                PreWTList, Color.Black, SymbolType.Circle);
            myBarObs3 = myPane.AddBar("Empty",
                PreWTList, Color.Black);

            myCurveObs.IsVisible = false;
            myCurveObs.Label.IsVisible = false;
            myBarObs.IsVisible = false;
            myBarObs.Label.IsVisible = false;
            myCurveObs2.IsVisible = false;
            myCurveObs2.Label.IsVisible = false;
            myBarObs2.IsVisible = false;
            myBarObs2.Label.IsVisible = false;
            myCurveObs3.IsVisible = false;
            myCurveObs3.Label.IsVisible = false;
            myBarObs3.IsVisible = false;
            myBarObs3.Label.IsVisible = false;


            #endregion


            #region "Load Formatting Scheme"

            //Call Formatting method
            methodLoadFormattingScheme();

            #endregion


            #region "Load Preference 1 dat files"

            //Set path to location of program
            Directory.SetCurrentDirectory(Application.StartupPath);

            //File List 
            string sFilePreference1 = "Graphing/Preference1.dat";
            string sFileHydrology_Prefs1 = "Graphing/Hydrology_Prefs1.dat";
            string sFileObserved_Paths = "Graphing/Observed_Paths.dat";
            string sFileObserved_Prefs1 = "Graphing/Observed_Prefs1.dat";

            //Handle if files do not exists

           if (File.Exists(sFileHydrology_Prefs1))
            { 
                //Read in Hydrology_Prefs1.dat
                //Populate Fields
                methodLoadHydrologyPrefs1();
                //Update if Plot Displayed and Type
                methodDisplayPreWT();
                methodDisplaySurfaceStorage();
                methodDisplayDryZone();
                methodDisplayRainfall();
                methodDisplayInfiltration();
                methodDisplayEvaporation();
                methodDisplayDrainage();
                methodDisplaySurfaceRunoff();
                methodDisplayWaterLoss();
                //Update Axis
                methodChangeAxis();
            }

            if (File.Exists(sFilePreference1))
            {
                //Read in Preference1.dat
                methodLoadPrefs1();
                methodUpdatePlot();
            }


            if (File.Exists(sFileObserved_Paths))
            {
                //Read in Observed_Paths.dat
                methodLoadFilePath();
                //Reset Observed Data Arrays
                if (this.textObsFile.Text != "")
                {
                    methodLoadInObserved1();
                }
                if (this.textObsFile2.Text != "")
                {
                    methodLoadInObserved2();
                }
                if (this.textObsFile3.Text != "")
                {
                    methodLoadInObserved3();
                }

            }

            if (File.Exists(sFileObserved_Prefs1))
            {
                //Read in Observed_Prefs1.dat
                methodLoadObservedPrefs1();
                //Update if Plot Displayed and Type
                methodDisplayObs1();
                methodDisplayObs2();
                methodDisplayObs3();
                //Update Axis
                methodChangeAxis();


            }





            #endregion


            //*****************************************************************
            //*****************************************************************

        }

        #endregion


        #region "Horizontal Scroll Ability in CreateGraph Class"

        private void CreateGraph(ZedGraphControl zgc)
        {
            // show the horizontal scroll bar
            zgc.IsShowHScrollBar = true;

            // automatically set the scrollable range to cover the data range from the curves
            zgc.IsAutoScrollRange = true;
            // Add .1% to scale range
            //zgc.ScrollGrace = 0.001;

            // Horizontal pan and zoom allowed
            zgc.IsEnableHPan = true;
            zgc.IsEnableHZoom = true;

            // Vertical pan and zoom not allowed
            zgc.IsEnableVPan = false;
            zgc.IsEnableVZoom = false;

            // Set the initial viewed range
            //zgc.GraphPane.XAxis.Scale.Min = 0.0;
            //zgc.GraphPane.XAxis.Scale.Max = 750.0;

            Scrolling_Setup(zgc);
        }

        #endregion


        #region "Resize and Setsize and Redraw Classes"

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetSize();
        }


        // SetSize() is separate from Resize() so we can 

        // call it independently from the Form1_Load() method

        // This leaves a 10 px margin around the outside of the control

        // Customize this to fit your needs

        private void SetSize()
        {
            zg1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zg1.Size = new Size(ClientRectangle.Width - 20, 400);


        }

        private void ReDraw()
        {
            // Make sure the Y axis is rescaled to accommodate actual data
            zg1.AxisChange();

            // Force a redraw
            zg1.Invalidate();

        }

        #endregion





        #region "Runtime - Add / Remove Variables to Plot and Clean up Legend"

        private void checkPreWT_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayPreWT();
        }

        private void checkObsWT1_CheckedChanged(object sender, EventArgs e)
        {   
            
            methodDisplayObs1();
            
        }

        private void checkObsWT2_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayObs2();
        }

        private void checkObsWT3_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayObs3();
        }

        private void checkSurfaceStorage_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplaySurfaceStorage();
        }

        private void checkDryZone_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayDryZone();
        }        
        
        private void checkRainfall_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayRainfall();
        }

        private void checkInfiltration_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayInfiltration();
        }

        private void checkEvaporation_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayEvaporation();
        }

        private void checkDrainage_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayDrainage();
        }

        private void checkSurfaceRunoff_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplaySurfaceRunoff();
        }

        private void checkWaterLoss_CheckedChanged(object sender, EventArgs e)
        {
            methodDisplayWaterLoss();
        }


        #endregion


        #region "Yearly Bar Plots - Depracated Menu Option"

        //private void YearlyBarMenu_Click(object sender, EventArgs e)
        //{
        //    //Clear Current Plots and Legend Items
        //    classClearDailyLines();

        //    //Show Requested Plots and legend Items
        //    if (this.checkPreWT.Checked == true)
        //    {
        //        YearlyPreWTBar.IsVisible = true;
        //        YearlyPreWTBar.Label.IsVisible = true;
        //    }
        //    YearlySurfaceStorageBar.IsVisible = false;
        //    YearlySurfaceStorageBar.Label.IsVisible = false;
        //    YearlyDryZoneBar.IsVisible = false;
        //    YearlyDryZoneBar.Label.IsVisible = false;
        //    if (this.checkRainfall.Checked == true)
        //    {
        //        YearlyRainfallBar.IsVisible = true;
        //        YearlyRainfallBar.Label.IsVisible = true;
        //        YearlyRainfallBar.IsY2Axis = true;

        //    }
        //    YearlyInfiltrationBar.IsVisible = false;
        //    YearlyInfiltrationBar.Label.IsVisible = false;
        //    YearlyAETBar.IsVisible = false;
        //    YearlyAETBar.Label.IsVisible = false;
        //    YearlyDrainageBar.IsVisible = false;
        //    YearlyDrainageBar.Label.IsVisible = false;
        //    YearlyRunoffBar.IsVisible = false;
        //    YearlyRunoffBar.Label.IsVisible = false;
        //    YearlyWaterLossBar.IsVisible = false;
        //    YearlyWaterLossBar.Label.IsVisible = false;
        //    YearlySurfaceStorageBar.IsVisible = false;
        //    YearlySurfaceStorageBar.Label.IsVisible = false;


        //    // Calculate the Axis Scale Ranges
        //    zg1.AxisChange();
        //    // Force a redraw
        //    zg1.Invalidate();

        //}//End YearlyBarMenu_Click 



        #endregion


        #region "Open and Graph Observed Files Buttons"


        private void buttonOpenObs1_Click(object sender, EventArgs e)
        {

            classClearListObs1();

            
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                String sFileName = this.openFileDialog1.FileName;

                this.textObsFile.Text = sFileName;
                
            }

            else
            {

                MessageBox.Show("Please select a file");
                //return;
            }


             //This Section Plots Initial Graph Data

            // Get a reference to the GraphPane
            GraphPane myPane = zg1.GraphPane;


            // Make some data points arrays
            ObsWTList = new PointPairList();


            //Load Observed Data to Plot
            // Open the GRH file
            StreamReader inObserved = new StreamReader(this.textObsFile.Text);

            // use the comma character to separate the items
            char[] sep = { '/',',' };

            string line;
            PointPairList list = new PointPairList();

            //Parameters in Observed Water Table File file, in order, are as follows
            //Month/Day/Year in mm/dd/yyyy format
            //Water Table Depth


            // read one line of data at a time until the end of file
            while ((line = inObserved.ReadLine()) != null)
            {
                // split the items on the line using the tab character as delimiter
                string[] items = line.Split(sep);
                // if there's less than 2 items, throw an exception
                if (items.Length < 2)
                    throw new Exception("Error: Not enough items on line");

                //Declare Variables in Observed file
                double dObsYear, dObsMonth, dObsDay, dObsDepthWaterTable;

                // if the value is missing mark it so. Otherwise, parse it as a double
                if (items[0].Length == 0)
                    dObsMonth = PointPair.Missing;
                else
                    dObsMonth = Double.Parse(items[0]);

                if (items[1].Length == 0)
                    dObsDay = PointPair.Missing;
                else
                    dObsDay = Double.Parse(items[1]);

                if (items[2].Length == 0)
                    dObsYear = PointPair.Missing;
                else
                    dObsYear = Double.Parse(items[2]);

                if (items[3].Length == 0)
                    dObsDepthWaterTable = PointPair.Missing;
                else
                    dObsDepthWaterTable = Double.Parse(items[3]);

                

                //Convert Date to XDate Format for graphing
                //First convert double to integers
                int iObsYear = Convert.ToInt32(dObsYear);
                int iObsMonth = Convert.ToInt32(dObsMonth);
                int iObsDay = Convert.ToInt32(dObsDay);

                //Then do Zedgraph XDate
                XDate myObsXDate = new XDate(iObsYear, iObsMonth, iObsDay);
                Double dObsDate = myObsXDate;

                // add the values to the PointPairList

                ObsWTList.Add(dObsDate, dObsDepthWaterTable);

            }

            inObserved.Close();

            // Generate a blue curve with circle
            // symbols, and "Z" in the legend
            //LineItem myCurveObs;
            myCurveObs = myPane.AddCurve("Observed Data File 1",
               ObsWTList, Color.Red, SymbolType.Circle);
            myBarObs = myPane.AddBar("Observed Data File 1",
                ObsWTList, Color.Red);

            // Make both curves thicker
            myCurveObs.Line.Width = 3.0F;

            // Increase the symbol sizes, and fill them with solid white
            myCurveObs.Symbol.Size = 1.0F;
            myCurveObs.Symbol.Fill = new Fill(Color.White);

            // Calculate the Axis Scale Ranges
            zg1.AxisChange();

            // Force a redraw
            zg1.Invalidate();

            //Check Observed Data Check Box
            this.checkObsWT1.Checked = true;


        }

        private void buttonOpenObs2_Click(object sender, EventArgs e)
        {
            if (this.textObsFile2.Text != "")
            {
                //zg1.GraphPane.CurveList.Clear();
                myCurveObs2.Clear();
                myCurveObs2.Label.IsVisible = false;
                myBarObs2.Clear();
                myBarObs2.Label.IsVisible = false;

                // Make sure the Y axis is rescaled to accommodate actual data
                zg1.AxisChange();

                // Force a redraw
                zg1.Invalidate();

            }

            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                String sFileName2 = this.openFileDialog2.FileName;

                this.textObsFile2.Text = sFileName2;

            }

            else
            {

                //MessageBox.Show("Please select a file");
                return;
            }


            //This Section Plots Initial Graph Data

            // Get a reference to the GraphPane
            GraphPane myPane = zg1.GraphPane;


            // Make some data points arrays
            ObsWTList2 = new PointPairList();


            //Load Observed Data to Plot
            // Open the GRH file
            StreamReader inObserved2 = new StreamReader(this.textObsFile2.Text);

            // use the comma character to separate the items
            char[] sep = { '/', ',' };

            string line;
            PointPairList list = new PointPairList();

            //Parameters in Observed Water Table File file, in order, are as follows
            //Month/Day/Year in mm/dd/yyyy format
            //Water Table Depth


            // read one line of data at a time until the end of file
            while ((line = inObserved2.ReadLine()) != null)
            {
                // split the items on the line using the tab character as delimiter
                string[] items = line.Split(sep);
                // if there's less than 2 items, throw an exception
                if (items.Length < 2)
                    throw new Exception("Error: Not enough items on line");

                //Declare Variables in Observed file
                double dObsYear2, dObsMonth2, dObsDay2, dObsDepthWaterTable2;

                // if the value is missing mark it so. Otherwise, parse it as a double
                if (items[0].Length == 0)
                    dObsMonth2 = PointPair.Missing;
                else
                    dObsMonth2 = Double.Parse(items[0]);

                if (items[1].Length == 0)
                    dObsDay2 = PointPair.Missing;
                else
                    dObsDay2 = Double.Parse(items[1]);

                if (items[2].Length == 0)
                    dObsYear2 = PointPair.Missing;
                else
                    dObsYear2 = Double.Parse(items[2]);

                if (items[3].Length == 0)
                    dObsDepthWaterTable2 = PointPair.Missing;
                else
                    dObsDepthWaterTable2 = Double.Parse(items[3]);



                //Convert Date to XDate Format for graphing
                //First convert double to integers
                int iObsYear2 = Convert.ToInt32(dObsYear2);
                int iObsMonth2 = Convert.ToInt32(dObsMonth2);
                int iObsDay2 = Convert.ToInt32(dObsDay2);

                //Then do Zedgraph XDate
                XDate myObsXDate2 = new XDate(iObsYear2, iObsMonth2, iObsDay2);
                Double dObsDate2 = myObsXDate2;

                // add the values to the PointPairList

                ObsWTList2.Add(dObsDate2, dObsDepthWaterTable2);

            }

            inObserved2.Close();

            // Generate a blue curve with circle
            // symbols, and "Z" in the legend
            //LineItem myCurveObs;
            myCurveObs2 = myPane.AddCurve("Observed Date File 2",
               ObsWTList2, Color.Purple, SymbolType.Circle);
            myBarObs2 = myPane.AddBar("Observed Data File 1",
                ObsWTList2, Color.Red);

            // Make both curves thicker
            myCurveObs2.Line.Width = 3.0F;

            // Increase the symbol sizes, and fill them with solid white
            myCurveObs2.Symbol.Size = 3.0F;
            myCurveObs2.Symbol.Fill = new Fill(Color.White);

            // Calculate the Axis Scale Ranges
            zg1.AxisChange();

            // Force a redraw
            zg1.Invalidate();

            //Check Observed Data Check Box
            this.checkObsWT2.Checked = true;


        }

        private void buttonOpenObs3_Click(object sender, EventArgs e)
        {

            if (this.textObsFile3.Text != "")
            {
                //zg1.GraphPane.CurveList.Clear();
                myCurveObs3.Clear();
                myCurveObs3.Label.IsVisible = false;
                myBarObs3.Clear();
                myBarObs3.Label.IsVisible = false;

                // Make sure the Y axis is rescaled to accommodate actual data
                zg1.AxisChange();

                // Force a redraw
                zg1.Invalidate();
            }


            if (this.openFileDialog3.ShowDialog() == DialogResult.OK)
            {

                String sFileName3 = this.openFileDialog3.FileName;

                this.textObsFile3.Text = sFileName3;

            }

            else
            {

                //MessageBox.Show("Please select a file");
                return;
            }


            //This Section Plots Initial Graph Data

            // Get a reference to the GraphPane
            GraphPane myPane = zg1.GraphPane;


            // Make some data points arrays
            ObsWTList3 = new PointPairList();


            //Load Observed Data to Plot
            // Open the GRH file
            StreamReader inObserved3 = new StreamReader(this.textObsFile3.Text);

            // use the comma character to separate the items
            char[] sep = { '/', ',' };

            string line;
            PointPairList list = new PointPairList();

            //Parameters in Observed Water Table File file, in order, are as follows
            //Month/Day/Year in mm/dd/yyyy format
            //Water Table Depth


            // read one line of data at a time until the end of file
            while ((line = inObserved3.ReadLine()) != null)
            {
                // split the items on the line using the tab character as delimiter
                string[] items = line.Split(sep);
                // if there's less than 2 items, throw an exception
                if (items.Length < 2)
                    throw new Exception("Error: Not enough items on line");

                //Declare Variables in Observed file
                double dObsYear3, dObsMonth3, dObsDay3, dObsDepthWaterTable3;

                // if the value is missing mark it so. Otherwise, parse it as a double
                if (items[0].Length == 0)
                    dObsMonth3 = PointPair.Missing;
                else
                    dObsMonth3 = Double.Parse(items[0]);

                if (items[1].Length == 0)
                    dObsDay3 = PointPair.Missing;
                else
                    dObsDay3 = Double.Parse(items[1]);

                if (items[2].Length == 0)
                    dObsYear3 = PointPair.Missing;
                else
                    dObsYear3 = Double.Parse(items[2]);

                if (items[3].Length == 0)
                    dObsDepthWaterTable3 = PointPair.Missing;
                else
                    dObsDepthWaterTable3 = Double.Parse(items[3]);



                //Convert Date to XDate Format for graphing
                //First convert double to integers
                int iObsYear3 = Convert.ToInt32(dObsYear3);
                int iObsMonth3 = Convert.ToInt32(dObsMonth3);
                int iObsDay3 = Convert.ToInt32(dObsDay3);

                //Then do Zedgraph XDate
                XDate myObsXDate3 = new XDate(iObsYear3, iObsMonth3, iObsDay3);
                Double dObsDate3 = myObsXDate3;

                // add the values to the PointPairList

                ObsWTList3.Add(dObsDate3, dObsDepthWaterTable3);

            }

            inObserved3.Close();

            // Generate a blue curve with circle
            // symbols, and "Z" in the legend
            //LineItem myCurveObs;
            myCurveObs3 = myPane.AddCurve("Observed Date File 2",
               ObsWTList3, Color.RoyalBlue, SymbolType.Circle);
            myBarObs3 = myPane.AddBar("Observed Data File 1",
                ObsWTList3, Color.Red);

            // Make both curves thicker
            myCurveObs3.Line.Width = 3.0F;

            // Increase the symbol sizes, and fill them with solid white
            myCurveObs3.Symbol.Size = 3.0F;
            myCurveObs3.Symbol.Fill = new Fill(Color.White);

            // Calculate the Axis Scale Ranges
            zg1.AxisChange();

            // Force a redraw
            zg1.Invalidate();

            //Check Observed Data Check Box
            this.checkObsWT3.Checked = true;


        }


        #endregion


        #region "Observed Data File Clear Buttons"


            private void buttonClearFile1_Click(object sender, EventArgs e)
            {

                if (this.textObsFile.Text != "")
                {

                    //zg1.GraphPane.CurveList.Clear();
                    myCurveObs.Clear();
                    myCurveObs.Label.IsVisible = false;

                    // Make sure the Y axis is rescaled to accommodate actual data
                    zg1.AxisChange();

                    // Force a redraw
                    zg1.Invalidate();

                    //Clear Text box
                    this.textObsFile.Text = "";

                    //Clear Check Boxes
                    this.checkObsWT1.Checked = false;

                    //Reset to Primary Axis
                    //this.radioPrimaryObs1.Checked = true;
                }




            }

            private void buttonClearFile2_Click(object sender, EventArgs e)
            {
                if (this.textObsFile2.Text != "")
                {
                    //zg1.GraphPane.CurveList.Clear();
                    myCurveObs2.Clear();
                    myCurveObs2.Label.IsVisible = false;

                    // Make sure the Y axis is rescaled to accommodate actual data
                    zg1.AxisChange();

                    // Force a redraw
                    zg1.Invalidate();

                    //Clear Text box
                    this.textObsFile2.Text = "";

                    //Clear Check Boxes
                    this.checkObsWT2.Checked = false;

                    //Reset to Primary Axis
                    //this.radioPrimaryObs2.Checked = true;
                }

 
            }

            private void buttonClearFile3_Click(object sender, EventArgs e)
            {
                if (this.textObsFile3.Text != "")
                {
                    //zg1.GraphPane.CurveList.Clear();
                    myCurveObs3.Clear();
                    myCurveObs3.Label.IsVisible = false;

                    // Make sure the Y axis is rescaled to accommodate actual data
                    zg1.AxisChange();

                    // Force a redraw
                    zg1.Invalidate();

                    //Clear Text box
                    this.textObsFile3.Text = "";

                    //Clear Check Boxes
                    this.checkObsWT3.Checked = false;

                    //Reset to Primary Axis
                    //this.radioPrimaryObs3.Checked = true;
                }



            }

            private void buttonClearFileAll_Click(object sender, EventArgs e)
            {

                if (this.textObsFile.Text != "")
                {

                    //zg1.GraphPane.CurveList.Clear();
                    myCurveObs.Clear();
                    myCurveObs.Label.IsVisible = false;

                    // Make sure the Y axis is rescaled to accommodate actual data
                    zg1.AxisChange();

                    // Force a redraw
                    zg1.Invalidate();

                    //Clear Text box
                    this.textObsFile.Text = "";

                    //Clear Check Boxes
                    this.checkObsWT1.Checked = false;

                    //Reset to Primary Axis
                    //this.radioPrimaryObs1.Checked = true;
                }

                if (this.textObsFile2.Text != "")
                {
                    //zg1.GraphPane.CurveList.Clear();
                    myCurveObs2.Clear();
                    myCurveObs2.Label.IsVisible = false;

                    // Make sure the Y axis is rescaled to accommodate actual data
                    zg1.AxisChange();

                    // Force a redraw
                    zg1.Invalidate();

                    //Clear Text box
                    this.textObsFile2.Text = "";

                    //Clear Check Boxes
                    this.checkObsWT2.Checked = false;

                    //Reset to Primary Axis
                    //this.radioPrimaryObs2.Checked = true;
                }

                if (this.textObsFile3.Text != "")
                {
                    //zg1.GraphPane.CurveList.Clear();
                    myCurveObs3.Clear();
                    myCurveObs3.Label.IsVisible = false;

                    // Make sure the Y axis is rescaled to accommodate actual data
                    zg1.AxisChange();

                    // Force a redraw
                    zg1.Invalidate();

                    //Clear Text box
                    this.textObsFile3.Text = "";

                    //Clear Check Boxes
                    this.checkObsWT3.Checked = false;

                    //Reset to Primary Axis
                    //this.radioPrimaryObs3.Checked = true;
                }

            }

            #endregion


        #region "Runtime - Change Axis and Plot Type"  


                     #region "Change Axis"

            private void checkWaterTableDepthSec_CheckedChanged(object sender, EventArgs e)
            {
                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;

                if (checkWaterTableDepthSec.Checked == true)
                {
                    PreWTCurve.IsY2Axis = true;
                    PreWTBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    PreWTCurve.IsY2Axis = false;
                    PreWTBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkDryZoneDepthSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkDryZoneDepthSec.Checked == true)
                {
                    DryZoneCurve.IsY2Axis = true;
                    DryZoneBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    DryZoneCurve.IsY2Axis = false;
                    DryZoneBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkSurfaceStorageSec_CheckedChanged(object sender, EventArgs e)
            {


                if (checkSurfaceStorageSec.Checked == true)
                {
                    SurfaceStorageCurve.IsY2Axis = true;
                    SurfaceStorageBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    SurfaceStorageCurve.IsY2Axis = false;
                    SurfaceStorageBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkRainfallSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkRainfallSec.Checked == true)
                {
                    RainfallCurve.IsY2Axis = true;
                    RainfallBar.IsY2Axis = true;
                    MonthlyRainfallCurve.IsY2Axis = true;
                    MonthlyRainfallBar.IsY2Axis = true;
                    CumulativeRainfallCurve.IsY2Axis = true;
                    CumulativeRainfallBar.IsY2Axis = true;
                    YearlyRainfallCurve.IsY2Axis = true;
                    YearlyRainfallBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    RainfallCurve.IsY2Axis = false;
                    RainfallBar.IsY2Axis = false;
                    MonthlyRainfallCurve.IsY2Axis = false;
                    MonthlyRainfallBar.IsY2Axis = false;
                    CumulativeRainfallCurve.IsY2Axis = false;
                    CumulativeRainfallBar.IsY2Axis = false;
                    YearlyRainfallCurve.IsY2Axis = false;
                    YearlyRainfallBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkInfiltrationSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkInfiltrationSec.Checked == true)
                {
                    InfiltrationCurve.IsY2Axis = true;
                    InfiltrationBar.IsY2Axis = true;
                    MonthlyInfiltrationCurve.IsY2Axis = true;
                    MonthlyInfiltrationBar.IsY2Axis = true;
                    CumulativeInfiltrationCurve.IsY2Axis = true;
                    CumulativeInfiltrationBar.IsY2Axis = true;
                    YearlyInfiltrationCurve.IsY2Axis = true;
                    YearlyInfiltrationBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    InfiltrationCurve.IsY2Axis = false;
                    InfiltrationBar.IsY2Axis = false;
                    MonthlyInfiltrationCurve.IsY2Axis = false;
                    MonthlyInfiltrationBar.IsY2Axis = false;
                    CumulativeInfiltrationCurve.IsY2Axis = false;
                    CumulativeInfiltrationBar.IsY2Axis = false;
                    YearlyInfiltrationCurve.IsY2Axis = false;
                    YearlyInfiltrationBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkEvaporationSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkEvaporationSec.Checked == true)
                {
                    AETCurve.IsY2Axis = true;
                    AETBar.IsY2Axis = true;
                    MonthlyAETCurve.IsY2Axis = true;
                    MonthlyAETBar.IsY2Axis = true;
                    CumulativeAETCurve.IsY2Axis = true;
                    CumulativeAETBar.IsY2Axis = true;
                    YearlyAETCurve.IsY2Axis = true;
                    YearlyAETBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    AETCurve.IsY2Axis = false;
                    AETBar.IsY2Axis = false;
                    MonthlyAETCurve.IsY2Axis = false;
                    MonthlyAETBar.IsY2Axis = false;
                    CumulativeAETCurve.IsY2Axis = false;
                    CumulativeAETBar.IsY2Axis = false;
                    YearlyAETCurve.IsY2Axis = false;
                    YearlyAETBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkDrainageSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkDrainageSec.Checked == true)
                {
                    DrainageCurve.IsY2Axis = true;
                    DrainageBar.IsY2Axis = true;
                    MonthlyDrainageCurve.IsY2Axis = true;
                    MonthlyDrainageBar.IsY2Axis = true;
                    CumulativeDrainageCurve.IsY2Axis = true;
                    CumulativeDrainageBar.IsY2Axis = true;
                    YearlyDrainageCurve.IsY2Axis = true;
                    YearlyDrainageBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    DrainageCurve.IsY2Axis = false;
                    DrainageBar.IsY2Axis = false;
                    MonthlyDrainageCurve.IsY2Axis = false;
                    MonthlyDrainageBar.IsY2Axis = false;
                    CumulativeDrainageCurve.IsY2Axis = false;
                    CumulativeDrainageBar.IsY2Axis = false;
                    YearlyDrainageCurve.IsY2Axis = false;
                    YearlyDrainageBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkSurfaceRunoffSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkSurfaceRunoffSec.Checked == true)
                {
                    RunoffCurve.IsY2Axis = true;
                    RunoffBar.IsY2Axis = true;
                    MonthlyRunoffCurve.IsY2Axis = true;
                    MonthlyRunoffBar.IsY2Axis = true;
                    CumulativeRunoffCurve.IsY2Axis = true;
                    CumulativeRunoffBar.IsY2Axis = true;
                    YearlyRunoffCurve.IsY2Axis = true;
                    YearlyRunoffBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    RunoffCurve.IsY2Axis = false;
                    RunoffBar.IsY2Axis = false;
                    MonthlyRunoffCurve.IsY2Axis = false;
                    MonthlyRunoffBar.IsY2Axis = false;
                    CumulativeRunoffCurve.IsY2Axis = false;
                    CumulativeRunoffBar.IsY2Axis = false;
                    YearlyRunoffCurve.IsY2Axis = false;
                    YearlyRunoffBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkWaterLossSec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkWaterLossSec.Checked == true)
                {
                    WaterLossCurve.IsY2Axis = true;
                    WaterLossBar.IsY2Axis = true;
                    MonthlyWaterLossCurve.IsY2Axis = true;
                    MonthlyWaterLossBar.IsY2Axis = true;
                    CumulativeWaterLossCurve.IsY2Axis = true;
                    CumulativeWaterLossBar.IsY2Axis = true;
                    YearlyWaterLossCurve.IsY2Axis = true;
                    YearlyWaterLossBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    WaterLossCurve.IsY2Axis = false;
                    WaterLossBar.IsY2Axis = false;
                    MonthlyWaterLossCurve.IsY2Axis = false;
                    MonthlyWaterLossBar.IsY2Axis = false;
                    CumulativeWaterLossCurve.IsY2Axis = false;
                    CumulativeWaterLossBar.IsY2Axis = false;
                    YearlyWaterLossCurve.IsY2Axis = false;
                    YearlyWaterLossBar.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkObservedData1Sec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkObservedData1Sec.Checked == true)
                {
                    myCurveObs.IsY2Axis = true;
                    myBarObs.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    myCurveObs.IsY2Axis = false;
                    myBarObs.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkObservedData2Sec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkObservedData2Sec.Checked == true)
                {
                    myCurveObs2.IsY2Axis = true;
                    myBarObs2.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    myCurveObs2.IsY2Axis = false;
                    myBarObs2.IsY2Axis = false;
                    ReDraw();
                }
            }


            private void checkObservedData3Sec_CheckedChanged(object sender, EventArgs e)
            {

                if (checkObservedData3Sec.Checked == true)
                {
                    myCurveObs3.IsY2Axis = true;
                    myBarObs3.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    myCurveObs3.IsY2Axis = false;
                    myBarObs3.IsY2Axis = false;
                    ReDraw();
                }
            }



        #endregion //Hydrology - Change Axis


                     #region "Plot Type"
            //Water Table
            private void comboTypeWaterTableDepth_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearPreWT();

                if (this.checkPreWT.Checked == true)
                {

                    classPreWTType();
                }


            }

            private void comboTypeDryZoneDepth_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearDryZone();

                if (this.checkDryZoneDepth.Checked == true)
                {

                    classDryZoneType();
                }

            }

            private void comboTypeSurfaceStorage_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearSurfaceStorage();

                if (this.checkSurfaceStorage.Checked == true)
                {

                    classSurfaceStorageType();
                }

            }

            private void comboTypeRainfall_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearRainfall();

                if (this.checkRainfall.Checked == true)
                {

                    classRainfallType();
                }
            }

            private void comboTypeInfiltration_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearInfiltration();

                if (this.checkInfiltration.Checked == true)
                {

                    classInfiltrationType();
                }
            }

            private void comboTypeEvaporation_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearEvaporation();

                if (this.checkEvaporation.Checked == true)
                {

                    classEvaporationType();
                }

            }

            private void comboTypeDrainage_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearDrainage();

                if (this.checkDrainage.Checked == true)
                {

                    classDrainageType();
                }
            }

            private void comboTypeSurfaceRunoff_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearSurfaceRunoff();

                if (this.checkSurfaceRunoff.Checked == true)
                {

                    classSurfaceRunoffType();
                }
            }

            private void comboTypeWaterLoss_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearWaterLoss();

                if (this.checkWaterLoss.Checked == true)
                {

                    classWaterLossType();
                }
            }

            private void comboTypeObservedData1_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearObs1();

                if (this.checkObsWT1.Checked == true)
                {

                    classObs1Type();
                }
            }

            private void comboTypeObservedData2_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearObs2();

                if (this.checkObsWT2.Checked == true)
                {

                    classObs2Type();
                }
            }

            private void comboTypeObservedData3_SelectedIndexChanged(object sender, EventArgs e)
            {
                classClearObs3();

                if (this.checkObsWT3.Checked == true)
                {

                    classObs3Type();
                }
            }

            #endregion  


            #endregion //Plot Variables

       
        #region "Runtime - Checkbox Changes - Display and Reverse Axes"

            private void checkReversePrimAxis_CheckedChanged(object sender, EventArgs e)
            {
                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;

                if (this.checkReversePrimAxis.Checked == true)
                {
                    myPane.YAxis.Scale.IsReverse = true;
                    ReDraw();
                }

                else
                {
                    myPane.YAxis.Scale.IsReverse = false;
                    ReDraw();
                }
            }
            private void checkReverseSecAxis_CheckedChanged(object sender, EventArgs e)
            {
                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;

                if (this.checkReverseSecAxis.Checked == true)
                {
                    myPane.Y2Axis.Scale.IsReverse = true;
                    ReDraw();
                }

                else
                {
                    myPane.Y2Axis.Scale.IsReverse = false;
                    ReDraw();
                }
            }

            private void checkDisplayPrimAxis_CheckedChanged(object sender, EventArgs e)
            {
                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;

                if (this.checkDisplayPrimAxis.Checked == true)
                {
                    myPane.YAxis.IsVisible = true;
                    ReDraw();
                }

                else
                {
                    myPane.YAxis.IsVisible = false;
                    ReDraw();
                }
            }

            private void checkDisplaySecAxis_CheckedChanged(object sender, EventArgs e)
            {
                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;

                if (this.checkDisplaySecAxis.Checked == true)
                {
                    myPane.Y2Axis.IsVisible = true;
                    ReDraw();
                }

                else
                {
                    myPane.Y2Axis.IsVisible = false;
                    ReDraw();
                }
            }

            #endregion

        
        #region "Clear Plot Lines and Bars Methods"

            private void classClearDailyLines()
            {
                //Daily
                PreWTCurve.IsVisible = false;
                PreWTCurve.Label.IsVisible = false;
                SurfaceStorageCurve.IsVisible = false;
                SurfaceStorageCurve.Label.IsVisible = false;
                DryZoneCurve.IsVisible = false;
                DryZoneCurve.Label.IsVisible = false;
                RainfallCurve.IsVisible = false;
                RainfallCurve.Label.IsVisible = false;
                InfiltrationCurve.IsVisible = false;
                InfiltrationCurve.Label.IsVisible = false;
                AETCurve.IsVisible = false;
                AETCurve.Label.IsVisible = false;
                DrainageCurve.IsVisible = false;
                DrainageCurve.Label.IsVisible = false;
                RunoffCurve.IsVisible = false;
                RunoffCurve.Label.IsVisible = false;
                WaterLossCurve.IsVisible = false;
                WaterLossCurve.Label.IsVisible = false;
                SurfaceStorageCurve.IsVisible = false;
                SurfaceStorageCurve.Label.IsVisible = false;

                // Force a redraw
                zg1.Invalidate();
                
            }

            private void classCheckSelectedVariables()
            {





            }



            #region "Water Table Plot Type and Clear classes"

            private void classPreWTType()
            {
                if (this.comboTypeWaterTableDepth.SelectedIndex.Equals(0))
                {
                    PreWTCurve.IsVisible = true;
                    PreWTCurve.Label.IsVisible = true;
                    PreWTCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterTableDepth.SelectedIndex.Equals(1))
                {
                    PreWTCurve.IsVisible = true;
                    PreWTCurve.Label.IsVisible = true;
                    PreWTCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeWaterTableDepth.SelectedIndex.Equals(2))
                {
                    PreWTBar.IsVisible = true;
                    PreWTBar.Label.IsVisible = true;
                    ReDraw();
                }
                

            }

            private void classClearPreWT()
            {

                PreWTCurve.IsVisible = false;
                PreWTCurve.Label.IsVisible = false;
                PreWTBar.IsVisible = false;
                PreWTBar.Label.IsVisible = false;

                ReDraw();

            }

            #endregion

            #region "Rainfall Plot Type and Clear classes"

            private void classRainfallType()
            {
                if (this.comboTypeRainfall.SelectedIndex.Equals(0))
                {
                    RainfallCurve.IsVisible = true;
                    RainfallCurve.Label.IsVisible = true;
                    RainfallCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(1))
                {
                    RainfallCurve.IsVisible = true;
                    RainfallCurve.Label.IsVisible = true;
                    RainfallCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(2))
                {
                    RainfallBar.IsVisible = true;
                    RainfallBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(3))
                {
                    MonthlyRainfallCurve.IsVisible = true;
                    MonthlyRainfallCurve.Label.IsVisible = true;
                    MonthlyRainfallCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(4))
                {
                    MonthlyRainfallCurve.IsVisible = true;
                    MonthlyRainfallCurve.Label.IsVisible = true;
                    MonthlyRainfallCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(5))
                {
                    MonthlyRainfallBar.IsVisible = true;
                    MonthlyRainfallBar.Label.IsVisible = true;
                    
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(6))
                {
                    YearlyRainfallCurve.IsVisible = true;
                    YearlyRainfallCurve.Label.IsVisible = true;
                    YearlyRainfallCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(7))
                {
                    YearlyRainfallCurve.IsVisible = true;
                    YearlyRainfallCurve.Label.IsVisible = true;
                    YearlyRainfallCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(8))
                {
                    YearlyRainfallBar.IsVisible = true;
                    YearlyRainfallBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(9))
                {
                    CumulativeRainfallCurve.IsVisible = true;
                    CumulativeRainfallCurve.Label.IsVisible = true;
                    CumulativeRainfallCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(10))
                {
                    CumulativeRainfallCurve.IsVisible = true;
                    CumulativeRainfallCurve.Label.IsVisible = true;
                    CumulativeRainfallCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeRainfall.SelectedIndex.Equals(11))
                {
                    CumulativeRainfallBar.IsVisible = true;
                    CumulativeRainfallBar.Label.IsVisible = true;
                    ReDraw();
                }

            }

            private void classClearRainfall()
            {

                RainfallCurve.IsVisible = false;
                RainfallCurve.Label.IsVisible = false;
                RainfallBar.IsVisible = false;
                RainfallBar.Label.IsVisible = false;
                MonthlyRainfallCurve.IsVisible = false;
                MonthlyRainfallCurve.Label.IsVisible = false;
                MonthlyRainfallBar.IsVisible = false;
                MonthlyRainfallBar.Label.IsVisible = false;
                CumulativeRainfallCurve.IsVisible = false;
                CumulativeRainfallCurve.Label.IsVisible = false;
                CumulativeRainfallBar.IsVisible = false;
                CumulativeRainfallBar.Label.IsVisible = false;
                YearlyRainfallCurve.IsVisible = false;
                YearlyRainfallCurve.Label.IsVisible = false;
                YearlyRainfallBar.IsVisible = false;
                YearlyRainfallBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "SurfaceStorage Plot Type and Clear classes"

            private void classSurfaceStorageType()
            {
                if (this.comboTypeSurfaceStorage.SelectedIndex.Equals(0))
                {
                    SurfaceStorageCurve.IsVisible = true;
                    SurfaceStorageCurve.Label.IsVisible = true;
                    SurfaceStorageCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceStorage.SelectedIndex.Equals(1))
                {
                    SurfaceStorageCurve.IsVisible = true;
                    SurfaceStorageCurve.Label.IsVisible = true;
                    SurfaceStorageCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeSurfaceStorage.SelectedIndex.Equals(2))
                {
                    SurfaceStorageBar.IsVisible = true;
                    SurfaceStorageBar.Label.IsVisible = true;
                    ReDraw();
                }
                

            }

            private void classClearSurfaceStorage()
            {

                SurfaceStorageCurve.IsVisible = false;
                SurfaceStorageCurve.Label.IsVisible = false;
                SurfaceStorageBar.IsVisible = false;
                SurfaceStorageBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "DryZone Plot Type and Clear classes"

            private void classDryZoneType()
            {
                if (this.comboTypeDryZoneDepth.SelectedIndex.Equals(0))
                {
                    DryZoneCurve.IsVisible = true;
                    DryZoneCurve.Label.IsVisible = true;
                    DryZoneCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDryZoneDepth.SelectedIndex.Equals(1))
                {
                    DryZoneCurve.IsVisible = true;
                    DryZoneCurve.Label.IsVisible = true;
                    DryZoneCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeDryZoneDepth.SelectedIndex.Equals(2))
                {
                    DryZoneBar.IsVisible = true;
                    DryZoneBar.Label.IsVisible = true;
                    ReDraw();
                }
                

            }

            private void classClearDryZone()
            {

                DryZoneCurve.IsVisible = false;
                DryZoneCurve.Label.IsVisible = false;
                DryZoneBar.IsVisible = false;
                DryZoneBar.Label.IsVisible = false;

                ReDraw();

            }

            #endregion

            #region "Infiltration Plot Type and Clear classes"

            private void classInfiltrationType()
            {
                if (this.comboTypeInfiltration.SelectedIndex.Equals(0))
                {
                    InfiltrationCurve.IsVisible = true;
                    InfiltrationCurve.Label.IsVisible = true;
                    InfiltrationCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(1))
                {
                    InfiltrationCurve.IsVisible = true;
                    InfiltrationCurve.Label.IsVisible = true;
                    InfiltrationCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(2))
                {
                    InfiltrationBar.IsVisible = true;
                    InfiltrationBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(3))
                {
                    MonthlyInfiltrationCurve.IsVisible = true;
                    MonthlyInfiltrationCurve.Label.IsVisible = true;
                    MonthlyInfiltrationCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(4))
                {
                    MonthlyInfiltrationCurve.IsVisible = true;
                    MonthlyInfiltrationCurve.Label.IsVisible = true;
                    MonthlyInfiltrationCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(5))
                {
                    MonthlyInfiltrationBar.IsVisible = true;
                    MonthlyInfiltrationBar.Label.IsVisible = true;

                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(6))
                {
                    YearlyInfiltrationCurve.IsVisible = true;
                    YearlyInfiltrationCurve.Label.IsVisible = true;
                    YearlyInfiltrationCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(7))
                {
                    YearlyInfiltrationCurve.IsVisible = true;
                    YearlyInfiltrationCurve.Label.IsVisible = true;
                    YearlyInfiltrationCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(8))
                {
                    YearlyInfiltrationBar.IsVisible = true;
                    YearlyInfiltrationBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(9))
                {
                    CumulativeInfiltrationCurve.IsVisible = true;
                    CumulativeInfiltrationCurve.Label.IsVisible = true;
                    CumulativeInfiltrationCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(10))
                {
                    CumulativeInfiltrationCurve.IsVisible = true;
                    CumulativeInfiltrationCurve.Label.IsVisible = true;
                    CumulativeInfiltrationCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeInfiltration.SelectedIndex.Equals(11))
                {
                    CumulativeInfiltrationBar.IsVisible = true;
                    CumulativeInfiltrationBar.Label.IsVisible = true;
                    ReDraw();
                }

            }

            private void classClearInfiltration()
            {

                InfiltrationCurve.IsVisible = false;
                InfiltrationCurve.Label.IsVisible = false;
                InfiltrationBar.IsVisible = false;
                InfiltrationBar.Label.IsVisible = false;
                MonthlyInfiltrationCurve.IsVisible = false;
                MonthlyInfiltrationCurve.Label.IsVisible = false;
                MonthlyInfiltrationBar.IsVisible = false;
                MonthlyInfiltrationBar.Label.IsVisible = false;
                CumulativeInfiltrationCurve.IsVisible = false;
                CumulativeInfiltrationCurve.Label.IsVisible = false;
                CumulativeInfiltrationBar.IsVisible = false;
                CumulativeInfiltrationBar.Label.IsVisible = false;
                YearlyInfiltrationCurve.IsVisible = false;
                YearlyInfiltrationCurve.Label.IsVisible = false;
                YearlyInfiltrationBar.IsVisible = false;
                YearlyInfiltrationBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "Evaporation Plot Type and Clear classes"

            private void classEvaporationType()
            {
                if (this.comboTypeEvaporation.SelectedIndex.Equals(0))
                {
                    AETCurve.IsVisible = true;
                    AETCurve.Label.IsVisible = true;
                    AETCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(1))
                {
                    AETCurve.IsVisible = true;
                    AETCurve.Label.IsVisible = true;
                    AETCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(2))
                {
                    AETBar.IsVisible = true;
                    AETBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(3))
                {
                    MonthlyAETCurve.IsVisible = true;
                    MonthlyAETCurve.Label.IsVisible = true;
                    MonthlyAETCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(4))
                {
                    MonthlyAETCurve.IsVisible = true;
                    MonthlyAETCurve.Label.IsVisible = true;
                    MonthlyAETCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(5))
                {
                    MonthlyAETBar.IsVisible = true;
                    MonthlyAETBar.Label.IsVisible = true;

                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(6))
                {
                    YearlyAETCurve.IsVisible = true;
                    YearlyAETCurve.Label.IsVisible = true;
                    YearlyAETCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(7))
                {
                    YearlyAETCurve.IsVisible = true;
                    YearlyAETCurve.Label.IsVisible = true;
                    YearlyAETCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(8))
                {
                    YearlyAETBar.IsVisible = true;
                    YearlyAETBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(9))
                {
                    CumulativeAETCurve.IsVisible = true;
                    CumulativeAETCurve.Label.IsVisible = true;
                    CumulativeAETCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(10))
                {
                    CumulativeAETCurve.IsVisible = true;
                    CumulativeAETCurve.Label.IsVisible = true;
                    CumulativeAETCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeEvaporation.SelectedIndex.Equals(11))
                {
                    CumulativeAETBar.IsVisible = true;
                    CumulativeAETBar.Label.IsVisible = true;
                    ReDraw();
                }

            }

            private void classClearEvaporation()
            {

                AETCurve.IsVisible = false;
                AETCurve.Label.IsVisible = false;
                AETBar.IsVisible = false;
                AETBar.Label.IsVisible = false;
                MonthlyAETCurve.IsVisible = false;
                MonthlyAETCurve.Label.IsVisible = false;
                MonthlyAETBar.IsVisible = false;
                MonthlyAETBar.Label.IsVisible = false;
                CumulativeAETCurve.IsVisible = false;
                CumulativeAETCurve.Label.IsVisible = false;
                CumulativeAETBar.IsVisible = false;
                CumulativeAETBar.Label.IsVisible = false;
                YearlyAETCurve.IsVisible = false;
                YearlyAETCurve.Label.IsVisible = false;
                YearlyAETBar.IsVisible = false;
                YearlyAETBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "Drainage Plot Type and Clear classes"

            private void classDrainageType()
            {
                if (this.comboTypeDrainage.SelectedIndex.Equals(0))
                {
                    DrainageCurve.IsVisible = true;
                    DrainageCurve.Label.IsVisible = true;
                    DrainageCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(1))
                {
                    DrainageCurve.IsVisible = true;
                    DrainageCurve.Label.IsVisible = true;
                    DrainageCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(2))
                {
                    DrainageBar.IsVisible = true;
                    DrainageBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(3))
                {
                    MonthlyDrainageCurve.IsVisible = true;
                    MonthlyDrainageCurve.Label.IsVisible = true;
                    MonthlyDrainageCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(4))
                {
                    MonthlyDrainageCurve.IsVisible = true;
                    MonthlyDrainageCurve.Label.IsVisible = true;
                    MonthlyDrainageCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(5))
                {
                    MonthlyDrainageBar.IsVisible = true;
                    MonthlyDrainageBar.Label.IsVisible = true;

                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(6))
                {
                    YearlyDrainageCurve.IsVisible = true;
                    YearlyDrainageCurve.Label.IsVisible = true;
                    YearlyDrainageCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(7))
                {
                    YearlyDrainageCurve.IsVisible = true;
                    YearlyDrainageCurve.Label.IsVisible = true;
                    YearlyDrainageCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(8))
                {
                    YearlyDrainageBar.IsVisible = true;
                    YearlyDrainageBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(9))
                {
                    CumulativeDrainageCurve.IsVisible = true;
                    CumulativeDrainageCurve.Label.IsVisible = true;
                    CumulativeDrainageCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(10))
                {
                    CumulativeDrainageCurve.IsVisible = true;
                    CumulativeDrainageCurve.Label.IsVisible = true;
                    CumulativeDrainageCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeDrainage.SelectedIndex.Equals(11))
                {
                    CumulativeDrainageBar.IsVisible = true;
                    CumulativeDrainageBar.Label.IsVisible = true;
                    ReDraw();
                }

            }

            private void classClearDrainage()
            {

                DrainageCurve.IsVisible = false;
                DrainageCurve.Label.IsVisible = false;
                DrainageBar.IsVisible = false;
                DrainageBar.Label.IsVisible = false;
                MonthlyDrainageCurve.IsVisible = false;
                MonthlyDrainageCurve.Label.IsVisible = false;
                MonthlyDrainageBar.IsVisible = false;
                MonthlyDrainageBar.Label.IsVisible = false;
                CumulativeDrainageCurve.IsVisible = false;
                CumulativeDrainageCurve.Label.IsVisible = false;
                CumulativeDrainageBar.IsVisible = false;
                CumulativeDrainageBar.Label.IsVisible = false;
                YearlyDrainageCurve.IsVisible = false;
                YearlyDrainageCurve.Label.IsVisible = false;
                YearlyDrainageBar.IsVisible = false;
                YearlyDrainageBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "WaterLoss Plot Type and Clear classes"

            private void classWaterLossType()
            {
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(0))
                {
                    WaterLossCurve.IsVisible = true;
                    WaterLossCurve.Label.IsVisible = true;
                    WaterLossCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(1))
                {
                    WaterLossCurve.IsVisible = true;
                    WaterLossCurve.Label.IsVisible = true;
                    WaterLossCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(2))
                {
                    WaterLossBar.IsVisible = true;
                    WaterLossBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(3))
                {
                    MonthlyWaterLossCurve.IsVisible = true;
                    MonthlyWaterLossCurve.Label.IsVisible = true;
                    MonthlyWaterLossCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(4))
                {
                    MonthlyWaterLossCurve.IsVisible = true;
                    MonthlyWaterLossCurve.Label.IsVisible = true;
                    MonthlyWaterLossCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(5))
                {
                    MonthlyWaterLossBar.IsVisible = true;
                    MonthlyWaterLossBar.Label.IsVisible = true;

                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(6))
                {
                    YearlyWaterLossCurve.IsVisible = true;
                    YearlyWaterLossCurve.Label.IsVisible = true;
                    YearlyWaterLossCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(7))
                {
                    YearlyWaterLossCurve.IsVisible = true;
                    YearlyWaterLossCurve.Label.IsVisible = true;
                    YearlyWaterLossCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(8))
                {
                    YearlyWaterLossBar.IsVisible = true;
                    YearlyWaterLossBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(9))
                {
                    CumulativeWaterLossCurve.IsVisible = true;
                    CumulativeWaterLossCurve.Label.IsVisible = true;
                    CumulativeWaterLossCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(10))
                {
                    CumulativeWaterLossCurve.IsVisible = true;
                    CumulativeWaterLossCurve.Label.IsVisible = true;
                    CumulativeWaterLossCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeWaterLoss.SelectedIndex.Equals(11))
                {
                    CumulativeWaterLossBar.IsVisible = true;
                    CumulativeWaterLossBar.Label.IsVisible = true;
                    ReDraw();
                }

            }

            private void classClearWaterLoss()
            {

                WaterLossCurve.IsVisible = false;
                WaterLossCurve.Label.IsVisible = false;
                WaterLossBar.IsVisible = false;
                WaterLossBar.Label.IsVisible = false;
                MonthlyWaterLossCurve.IsVisible = false;
                MonthlyWaterLossCurve.Label.IsVisible = false;
                MonthlyWaterLossBar.IsVisible = false;
                MonthlyWaterLossBar.Label.IsVisible = false;
                CumulativeWaterLossCurve.IsVisible = false;
                CumulativeWaterLossCurve.Label.IsVisible = false;
                CumulativeWaterLossBar.IsVisible = false;
                CumulativeWaterLossBar.Label.IsVisible = false;
                YearlyWaterLossCurve.IsVisible = false;
                YearlyWaterLossCurve.Label.IsVisible = false;
                YearlyWaterLossBar.IsVisible = false;
                YearlyWaterLossBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "Surface Runoff Plot Type and Clear classes"

            private void classSurfaceRunoffType()
            {
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(0))
                {
                    RunoffCurve.IsVisible = true;
                    RunoffCurve.Label.IsVisible = true;
                    RunoffCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(1))
                {
                    RunoffCurve.IsVisible = true;
                    RunoffCurve.Label.IsVisible = true;
                    RunoffCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(2))
                {
                    RunoffBar.IsVisible = true;
                    RunoffBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(3))
                {
                    MonthlyRunoffCurve.IsVisible = true;
                    MonthlyRunoffCurve.Label.IsVisible = true;
                    MonthlyRunoffCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(4))
                {
                    MonthlyRunoffCurve.IsVisible = true;
                    MonthlyRunoffCurve.Label.IsVisible = true;
                    MonthlyRunoffCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(5))
                {
                    MonthlyRunoffBar.IsVisible = true;
                    MonthlyRunoffBar.Label.IsVisible = true;

                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(6))
                {
                    YearlyRunoffCurve.IsVisible = true;
                    YearlyRunoffCurve.Label.IsVisible = true;
                    YearlyRunoffCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(7))
                {
                    YearlyRunoffCurve.IsVisible = true;
                    YearlyRunoffCurve.Label.IsVisible = true;
                    YearlyRunoffCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(8))
                {
                    YearlyRunoffBar.IsVisible = true;
                    YearlyRunoffBar.Label.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(9))
                {
                    CumulativeRunoffCurve.IsVisible = true;
                    CumulativeRunoffCurve.Label.IsVisible = true;
                    CumulativeRunoffCurve.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(10))
                {
                    CumulativeRunoffCurve.IsVisible = true;
                    CumulativeRunoffCurve.Label.IsVisible = true;
                    CumulativeRunoffCurve.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeSurfaceRunoff.SelectedIndex.Equals(11))
                {
                    CumulativeRunoffBar.IsVisible = true;
                    CumulativeRunoffBar.Label.IsVisible = true;
                    ReDraw();
                }

            }

            private void classClearSurfaceRunoff()
            {

                RunoffCurve.IsVisible = false;
                RunoffCurve.Label.IsVisible = false;
                RunoffBar.IsVisible = false;
                RunoffBar.Label.IsVisible = false;
                MonthlyRunoffCurve.IsVisible = false;
                MonthlyRunoffCurve.Label.IsVisible = false;
                MonthlyRunoffBar.IsVisible = false;
                MonthlyRunoffBar.Label.IsVisible = false;
                CumulativeRunoffCurve.IsVisible = false;
                CumulativeRunoffCurve.Label.IsVisible = false;
                CumulativeRunoffBar.IsVisible = false;
                CumulativeRunoffBar.Label.IsVisible = false;
                YearlyRunoffCurve.IsVisible = false;
                YearlyRunoffCurve.Label.IsVisible = false;
                YearlyRunoffBar.IsVisible = false;
                YearlyRunoffBar.Label.IsVisible = false;
                ReDraw();

            }

            #endregion

            #region "Observed Data 1 plot type and clearing classes"

            private void classObs1Type()
            {
                if (this.comboTypeObservedData1.SelectedIndex.Equals(0))
                {
                    myCurveObs.IsVisible = true;
                    myCurveObs.Label.IsVisible = true;
                    myCurveObs.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeObservedData1.SelectedIndex.Equals(1))
                {
                    myCurveObs.IsVisible = true;
                    myCurveObs.Label.IsVisible = true;
                    myCurveObs.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeObservedData1.SelectedIndex.Equals(2))
                {
                    myBarObs.IsVisible = true;
                    myBarObs.Label.IsVisible = true;
                    ReDraw();
                }


            }

            private void classClearObs1()
            {

                myCurveObs.IsVisible = false;
                myCurveObs.Label.IsVisible = false;
                myBarObs.IsVisible = false;
                myBarObs.Label.IsVisible = false;
                ReDraw();

            }

            private void classClearListObs1()
            {
                myCurveObs.Clear();
                myCurveObs.Label.IsVisible = false;
                myBarObs.Clear();
                myBarObs.Label.IsVisible = false;
                ReDraw();
            }

            #endregion

            #region "Observed Data 2 plot type and clearing classes"

            private void classObs2Type()
            {
                if (this.comboTypeObservedData2.SelectedIndex.Equals(0))
                {
                    myCurveObs2.IsVisible = true;
                    myCurveObs2.Label.IsVisible = true;
                    myCurveObs2.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeObservedData2.SelectedIndex.Equals(1))
                {
                    myCurveObs2.IsVisible = true;
                    myCurveObs2.Label.IsVisible = true;
                    myCurveObs2.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeObservedData2.SelectedIndex.Equals(2))
                {
                    myBarObs2.IsVisible = true;
                    myBarObs2.Label.IsVisible = true;
                    ReDraw();
                }


            }

            private void classClearObs2()
            {

                myCurveObs2.IsVisible = false;
                myCurveObs2.Label.IsVisible = false;
                myBarObs2.IsVisible = false;
                myBarObs2.Label.IsVisible = false;
                ReDraw();

            }

            private void classClearListObs2()
            {
                myCurveObs2.Clear();
                myCurveObs2.Label.IsVisible = false;
                myBarObs2.Clear();
                myBarObs2.Label.IsVisible = false;
                ReDraw();
            }

            #endregion

            #region "Observed Data 3 plot type and clearing classes"

            private void classObs3Type()
            {
                if (this.comboTypeObservedData3.SelectedIndex.Equals(0))
                {
                    myCurveObs3.IsVisible = true;
                    myCurveObs3.Label.IsVisible = true;
                    myCurveObs3.Line.IsVisible = true;
                    ReDraw();
                }
                if (this.comboTypeObservedData3.SelectedIndex.Equals(1))
                {
                    myCurveObs3.IsVisible = true;
                    myCurveObs3.Label.IsVisible = true;
                    myCurveObs3.Line.IsVisible = false;
                    ReDraw();
                }
                if (this.comboTypeObservedData3.SelectedIndex.Equals(2))
                {
                    myBarObs3.IsVisible = true;
                    myBarObs3.Label.IsVisible = true;
                    ReDraw();
                }


            }

            private void classClearObs3()
            {

                myCurveObs3.IsVisible = false;
                myCurveObs3.Label.IsVisible = false;
                myBarObs3.IsVisible = false;
                myBarObs3.Label.IsVisible = false;
                ReDraw();

            }

            private void classClearListObs3()
            {
                myCurveObs3.Clear();
                myCurveObs3.Label.IsVisible = false;
                myBarObs3.Clear();
                myBarObs3.Label.IsVisible = false;
                ReDraw();
            }

            #endregion

        
        #endregion

        
        
        
        #region "Statistics"

            private void buttonBandTest_Click(object sender, EventArgs e)
            {

                // Draw a box item to highlight a value range
                BoxObj box = new BoxObj(0, 0, 1, 30, Color.Empty,
                        Color.FromArgb(150, Color.LightGreen));
                box.Fill = new Fill(Color.White, Color.FromArgb(200, Color.LightGreen), 45.0F);
                // Use the BehindAxis zorder to draw the highlight beneath the grid lines
                box.ZOrder = ZOrder.E_BehindCurves;
                // Make sure that the boxObj does not extend outside the chart rect if the chart is zoomed
                box.IsClippedToChartRect = true;
                // Use a hybrid coordinate system so the X axis always covers the full x range
                // from chart fraction 0.0 to 1.0
                box.Location.CoordinateFrame = CoordType.XChartFractionYScale;
                 zg1.GraphPane.GraphObjList.Add(box);

                 // Add a text item to label the highlighted range
                 TextObj text = new TextObj("Optimal\nRange", 0.95f, 15, CoordType.AxisXYScale,
                                         AlignH.Right, AlignV.Center);
                 text.FontSpec.Fill.IsVisible = false;
                 text.FontSpec.Border.IsVisible = false;
                 text.FontSpec.IsBold = true;
                 text.FontSpec.IsItalic = true;
                 text.Location.CoordinateFrame = CoordType.XChartFractionYScale;
                 text.IsClippedToChartRect = true;
                 zg1.GraphPane.GraphObjList.Add(text);



                 // Force a redraw
                 zg1.Invalidate();

            }


            #region "In Form Statistical Classes"

            public static void GetCorrelation(double[] x, double[] y, ref double covXY, ref double pearson)
            {
                if (x.Length != y.Length)
                    throw new Exception("Length of sources is different");
                double avgX = GetAverage(x);
                double stdevX = GetStdev(x);
                double avgY = GetAverage(y);
                double stdevY = GetStdev(y);
                int len = x.Length;

                for (int i = 0; i < len; i++)
                    covXY += (x[i] - avgX) * (y[i] - avgY);
                covXY /= len;
                pearson = covXY / (stdevX * stdevY);

            }

            public static double GetVariance(double[] data)
            {
                int len = data.Length;
                // Get average

                double avg = GetAverage(data);

                double sum = 0;
                for (int i = 0; i < data.Length; i++)
                    sum += Math.Pow((data[i] - avg), 2);
                return sum / len;
            }


            /// <summary>

            /// Get standard deviation

            /// </summary>

            public static double GetStdev(double[] data)
            {
                return Math.Sqrt(GetVariance(data));
            }

            public static double GetAverage(double[] data)
            {
                int len = data.Length;
                if (len == 0)
                    throw new Exception("No data");

                double sum = 0;
                for (int i = 0; i < data.Length; i++)
                    sum += data[i];
                return sum / len;
            }


            #endregion


            #region "Calculate Statistics"

            private void buttonCalculateStats_Click(object sender, EventArgs e)
            {
                //If either combo box is empty then bypass stat calcs
                if (this.comboCompare1a.Text != "" && this.comboCompare1b.Text != "")
                {
                  
                // Determine variables selected
                //A
                string sVariable1a = this.comboCompare1a.Text;

                //B
                string sVariable1b = this.comboCompare1b.Text;

                //Possible Selections and associated Lists
                //Water_Table_Depth  -  PreWTList
                //Observed_Data_File_1  -  ObsWTList
                //Observed_Data_File_2  -  ObsWTList2
                //Observed_Data_File_3  -  ObsWTList3
                //Dry_Zone_Depth  - DryZoneList 
                //Surface_Storage  -  SurfaceStorageList
                //Rainfall  - RainfallList 
                //Infiltration  -  InfiltrationList
                //Evaporation  -  EvaporationList
                //Drainage  -  DrainageList
                //Surface_Runoff  -  SurfaceRunoffList
                //Water_Loss  -  WaterLossList

                //Instantiate Lists
                Variable1aList = new PointPairList();
                Variable1bList = new PointPairList();
                Variable1YList = new PointPairList();
                


                //Use Switch to clone appropriate list to variable
                switch (sVariable1a)
                {
                    case "Water_Table_Depth":
                        Variable1aList = PreWTList.Clone();
                        break;
                    case "Observed_Data_File_1":
                        Variable1aList = ObsWTList.Clone();
                        break;
                    case "Observed_Data_File_2":
                        Variable1aList = ObsWTList2.Clone();
                        break;
                    case "Observed_Data_File_3":
                        Variable1aList = ObsWTList3.Clone();
                        break;
                    case "Dry_Zone_Depth":
                        Variable1aList = DryZoneList.Clone();
                        break;
                    case "Surface_Storage":
                        Variable1aList = SurfaceStorageList.Clone();
                        break;
                    case "Rainfall":
                        Variable1aList = RainfallList.Clone();
                        break;
                    case "Infiltration":
                        Variable1aList = InfiltrationList.Clone();
                        break;
                    case "Evaporation":
                        Variable1aList = AETList.Clone();
                        break;
                    case "Drainage":
                        Variable1aList = DrainageList.Clone();
                        break;
                    case "Surface_Runoff":
                        Variable1aList = RunoffList.Clone();
                        break;
                    case "Water_Loss":
                        Variable1aList = WaterLossList.Clone();
                        break;
                    default:
                        break;
                }

                switch (sVariable1b)
                {
                    case "Water_Table_Depth":
                        Variable1bList = PreWTList.Clone();
                        break;
                    case "Observed_Data_File_1":
                        Variable1bList = ObsWTList.Clone();
                        break;
                    case "Observed_Data_File_2":
                        Variable1bList = ObsWTList2.Clone();
                        break;
                    case "Observed_Data_File_3":
                        Variable1bList = ObsWTList3.Clone();
                        break;
                    case "Dry_Zone_Depth":
                        Variable1bList = DryZoneList.Clone();
                        break;
                    case "Surface_Storage":
                        Variable1bList = SurfaceStorageList.Clone();
                        break;
                    case "Rainfall":
                        Variable1bList = RainfallList.Clone();
                        break;
                    case "Infiltration":
                        Variable1bList = InfiltrationList.Clone();
                        break;
                    case "Evaporation":
                        Variable1bList = AETList.Clone();
                        break;
                    case "Drainage":
                        Variable1bList = DrainageList.Clone();
                        break;
                    case "Surface_Runoff":
                        Variable1bList = RunoffList.Clone();
                        break;
                    case "Water_Loss":
                        Variable1bList = WaterLossList.Clone();
                        break;
                    default:
                        break;
                }

                //AAD - Average Absolute Daily Difference
                
                //Declare variables
                double dAADGroup1 = 0;
                double dAbsDiffGroup1 = 0;
                double dCountVariable1a = Convert.ToDouble(Variable1aList.Count);
                double dCountVariable1b = Convert.ToDouble(Variable1bList.Count);

                //Select smallest list to use a sample size
                double dSampleSizeGroup1 = 0;
                if (dCountVariable1a <= dCountVariable1b)
                {
                    dSampleSizeGroup1 = dCountVariable1a;
                }
                if (dCountVariable1a > dCountVariable1b)
                {
                    dSampleSizeGroup1 = dCountVariable1b;
                }

                //Intantiate Y Variable Lists - for R^2 and E calcs
                Variable1aArrayList = new List<double>();
                Variable1bArrayList = new List<double>();

                //Loop through both list matching dates
                for (int i = 1; i <= Variable1aList.Count; i++)
                {
                   for (int j = 1; j <= Variable1bList.Count; j++)
                    {
                        if (Variable1bList[j - 1].X == Variable1aList[i - 1].X)
                        {
                            //Sum Absolute differences
                            dAbsDiffGroup1 = dAbsDiffGroup1 + Math.Abs(Variable1bList[j - 1].Y - Variable1aList[i - 1].Y);
                            //Generate new list with only Y values - for R^2 and E calcs
                            Variable1YList.Add(Variable1aList[i - 1].Y, Variable1bList[j - 1].Y);
                            //Add Y Variables to appropriate List - for R^2 and E calcs
                            Variable1aArrayList.Add(Variable1aList[i - 1].Y);
                            Variable1bArrayList.Add(Variable1bList[j - 1].Y);                      

                            //Stop current loop when values match
                            break;
                        }
                    }
                }

                //Do AAD Calculation
                dAADGroup1 = dAbsDiffGroup1 / dSampleSizeGroup1;
                this.textAAD1.Text = (Convert.ToString(dAADGroup1));

                
                
                //Peasron Coefficient - R^2
                //Variable#YList is the list with Y values having matching dates from selected variables
                //Convert lists to arrays
                double[] Variable1aArray = Variable1aArrayList.ToArray();
                double[] Variable1bArray = Variable1bArrayList.ToArray();

                double dCov = 0;
                double dPearson = 0;

                GetCorrelation(Variable1aArray, Variable1bArray, ref dCov, ref dPearson);

                double dRSquared1 = dPearson * dPearson;

                this.textRSquared1.Text = (Convert.ToString(dRSquared1));


                //Nash-Suttclife Coeffieicnt of Efficiency - E


                
                
                
                return;
                }


                return;//return if no variables selected
            }//End of Calculation Button Click

           


            #endregion
        
        #endregion

      
        #region "Reload Methods"

            public void methodReloadPreferences()
            {
                //Two options here:
                //1. User chose to cancel out of preferences
                //If cancel.dat file states "CANCEL" then do not reload

                sCancelReload = "ERROR";

                FileStream strFilename01 = new FileStream("Graphing/Cancel.dat", FileMode.Open, FileAccess.Read);
                StreamReader stmReader01 = new StreamReader(strFilename01);

                if (File.Exists("Graphing/Cancel.dat"))
                {
                    // Retrieve the value from the file
                    sCancelReload = stmReader01.ReadLine();

                    //Clean up and close file
                    stmReader01.Close();
                }

                if (sCancelReload == "CANCEL")
                {
                    return;
                }

                //2. User made changes and chose to save preferences changes
                //If cancel.dat file states "RELOAD" then reload preference
                if (sCancelReload == "RELOAD")
                {
                    //methodLoadPreferences1();
                    //methodLoadPreferences2();
                    //ReDraw();
                    return;
                }

                //3.Show message box that file not found and no changes made
                if (sCancelReload == "ERROR")
                {
                    MessageBox.Show("Could not determine if changes to Plot Area made.  No changes have occured.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
                

        
            #endregion


        #region "Caller Key File Method"

                //*******************************************************
                //Caller Key File
                //******************************************************* 

                public void methodCallerKey()
                {
                    using (StreamWriter sw5 = new StreamWriter("Graphing/node.dat"))
                    {
                        sw5.WriteLine(sSettingsCaller);

                        //Clean up and close file
                        sw5.Flush();
                        sw5.Close();

                    }//close writer
                }//close method
                #endregion

              
        #region "Format Plot Area Menu Option"

                private void FormatPlotAreaMenu_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeGeneral";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();

                    
                }//close method

                #endregion     
          

        #region "Format Hydrology and Observed Data Buttons"


                private void buttonFormatWaterTableDepth_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeWaterTableDepth";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method


                private void buttonFormatDryZoneDepth_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeDryZoneDepth";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

     

                private void buttonFormatSurfaceStorage_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeSurfaceStorage";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method


                private void buttonFormatRainfall_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeRainfall";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatInfiltration_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeInfiltration";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatEvaporation_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeEvaporation";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatDrainage_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeDrainage";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatSurfaceRunoff_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeSurfaceRunoff";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatWaterLoss_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeWaterLoss";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatObservedData1_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeObserved1";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatObservedData2_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeObserved2";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method

                private void buttonFormatObservedData3_Click(object sender, EventArgs e)
                {
                    //Define what is calling settings form
                    sSettingsCaller = "NodeObserved3";
                    methodCallerKey();

                    //Save Data to dat files
                    //methodSaveToPreferences1();

                    //Start Preference Window
                    methodStartPrefWindow();

                    //Determine If Reloading Preferences
                    methodReloadPreferences();


                }//close method


                #endregion


        #region "Update Scale Button"

            private void buttonResetGraph_Click(object sender, EventArgs e)
            {
                methodUpdatePlot();
            }

            #endregion

         
        #region "Additional Context Menu Items"

        private void MyContextMenuBuilder(ZedGraphControl control,
            ContextMenuStrip menuStrip, Point mousePt,
            ZedGraphControl.ContextMenuObjectState objState)
        {
            // create a new menu item
            ToolStripMenuItem _item = new ToolStripMenuItem();
            // This is the user-defined Tag so you can find this menu item later if necessary
            _item.Name = "Export Data as CSV";
            _item.Tag = "export_data_csv";
            // This is the text that will show up in the menu
            _item.Text = "Export Data as CSV";
            // Add a handler that will respond when that menu item is selected
            _item.Click += new System.EventHandler(ShowSaveAsForExportCSV);
            // Add the menu item to the menu,as 3rd Item
            menuStrip.Items.Insert(2, _item);
        }

        #endregion  


        #region "Help Button"

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region "Close Button"

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion




        #region "Horizontal and Bands"

              private void AddHorizontalLineMenu_Click(object sender, EventArgs e)
                {
                    

                }

            #endregion





        #region "Load Preference Window"

            private void methodStartPrefWindow()
            {
                System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo("Graphing_Preferences.exe");
                psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                System.Diagnostics.Process PrefWindow;
                PrefWindow = System.Diagnostics.Process.Start(psi);
                PrefWindow.WaitForExit();//Waits for program to exit before continuing

            }

        #endregion



        #region "Save to Number 1 DAT file Method"

 

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

                sw3.WriteLine("XAxis-----");
                //Start
                sw3.WriteLine(this.textStartDate.Text);
                //End
                sw3.WriteLine(this.textEndDate.Text);
                    

                sw3.WriteLine("Primary Y Axis-----");

                //Is Displayed
                sw3.WriteLine(Convert.ToString(this.checkDisplayPrimAxis.Checked));
                //Is Reversed
                sw3.WriteLine(Convert.ToString(this.checkReversePrimAxis.Checked));
                //Max
                sw3.WriteLine(this.textMinPrimary.Text);
                //Min
                sw3.WriteLine(this.textMaxPrimary.Text);

                sw3.WriteLine("Secondary--");
                //Is Displayed
                sw3.WriteLine(Convert.ToString(this.checkDisplaySecAxis.Checked));
                //Is Reversed
                sw3.WriteLine(Convert.ToString(this.checkReverseSecAxis.Checked));
                //Max
                sw3.WriteLine(this.textMinSecondary.Text);
                //Min
                sw3.WriteLine(this.textMaxSecondary.Text);


                //Clean up and close file
                sw3.Flush();
                sw3.Close();
                
                }//close writer

            }//close method

  

            public void methodSaveToHydrology_Prefs1()
            {
                //Total Lines
                //46

                using (StreamWriter sw07 = new StreamWriter("Graphing/Hydrology_Prefs1.dat"))
                {
                    sw07.WriteLine("**********************************************");
                    sw07.WriteLine("***************BEGIN**************************");
                    sw07.WriteLine("DRAINMOD Graphing Utility Settings");
                    sw07.WriteLine(">>>Graphing/Hydrology_Prefs1.dat<<<");
                    sw07.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw07.WriteLine("**********************************************");
                    sw07.WriteLine("**********************************************");

                    sw07.WriteLine("Hydrology-------------------------------");

                    sw07.WriteLine("WaterTableDepth-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkPreWT.Checked));
                    //Is on Secondary Axis
                    if (this.checkWaterTableDepthSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }

                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeWaterTableDepth.SelectedItem));


                    sw07.WriteLine("DryZoneDepth-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkDryZoneDepth.Checked));
                    //Is on Secondary Axis
                    if (this.checkDryZoneDepthSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }

                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeDryZoneDepth.SelectedItem));

                    sw07.WriteLine("SurfaceStorage-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkSurfaceStorage.Checked));
                    //Is on Secondary Axis
                    if (this.checkSurfaceStorageSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }

                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeSurfaceStorage.SelectedItem));


                    sw07.WriteLine("Rainfall-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkRainfall.Checked));
                    //Is on Secondary Axis
                    if (this.checkRainfallSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }
        
                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeRainfall.SelectedItem));


                    sw07.WriteLine("Infiltration-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkInfiltration.Checked));
                    //Is on Secondary Axis
                    if (this.checkInfiltrationSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }
                    
                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeInfiltration.SelectedItem));

                    sw07.WriteLine("Evaporation-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkPreWT.Checked));
                    //Is on Secondary Axis
                    if (this.checkWaterTableDepthSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }
                 
                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeWaterTableDepth.SelectedItem));


                    sw07.WriteLine("Drainage-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkEvaporation.Checked));
                    //Is on Secondary Axis
                    if (this.checkEvaporationSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }
                  
                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeEvaporation.SelectedItem));

                    sw07.WriteLine("SurfaceRunoff-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkSurfaceRunoff.Checked));
                    //Is on Secondary Axis
                    if (this.checkSurfaceRunoffSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }
               
                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeSurfaceRunoff.SelectedItem));


                    sw07.WriteLine("WaterLoss-----");
                    //Is Displayed
                    sw07.WriteLine(Convert.ToString(this.checkWaterLoss.Checked));
                    //Is on Secondary Axis
                    if (this.checkWaterLossSec.Checked == true)
                    {
                        sw07.WriteLine("Secondary");
                    }
                    else
                    {
                        sw07.WriteLine("Primary");
                    }
              
                    //Plot Type Index Value
                    sw07.WriteLine(Convert.ToString(this.comboTypeWaterLoss.SelectedItem));



                    //Clean up and close file
                    sw07.Flush();
                    sw07.Close();

                }//close writer

            }//close method


            public void methodObservedFilePath()
            {
                using (StreamWriter sw18 = new StreamWriter("Graphing/Observed_Paths.dat"))
                {

                    sw18.WriteLine(this.textObsFile.Text);
                    sw18.WriteLine(this.textObsFile2.Text);
                    sw18.WriteLine(this.textObsFile3.Text);

                    //Clean up and close file
                    sw18.Flush();
                    sw18.Close();

                }//close writer

            }//close method


            public void methodSaveToObserved_Prefs1()
            {
                //Total Lines
                //28

                using (StreamWriter sw08 = new StreamWriter("Graphing/Observed_Prefs1.dat"))
                {
                    sw08.WriteLine("**********************************************");
                    sw08.WriteLine("***************BEGIN**************************");
                    sw08.WriteLine("DRAINMOD Graphing Utility Settings");
                    sw08.WriteLine(">>>Graphing/Observed_Prefs1.dat<<<");
                    sw08.WriteLine("DO NOT MAKE CHANGES TO THIS FILE");
                    sw08.WriteLine("**********************************************");
                    sw08.WriteLine("**********************************************");


                    sw08.WriteLine("Observed1-----");
                    //Is Displayed
                    sw08.WriteLine(Convert.ToString(this.checkObsWT1.Checked));
                    //Is on Secondary Axis
                    if (this.checkObservedData1Sec.Checked == true)
                    {
                        sw08.WriteLine("Secondary");
                    }
                    else
                    {
                        sw08.WriteLine("Primary");
                    }
                    //Label
                    sw08.WriteLine(this.textObs1Label.Text);
                    //Plot Type Index value
                    sw08.WriteLine(Convert.ToString(this.comboTypeObservedData1.SelectedItem));


                    sw08.WriteLine("Observed2-----");

                    //Is Displayed
                    sw08.WriteLine(Convert.ToString(this.checkObsWT2.Checked));
                    //Is on Secondary Axis
                    if (this.checkObservedData2Sec.Checked == true)
                    {
                        sw08.WriteLine("Secondary");
                    }
                    else
                    {
                        sw08.WriteLine("Primary");
                    }
                    //Label
                    sw08.WriteLine(this.textObs2Label.Text);
                    //Plot Type Index value
                    sw08.WriteLine(Convert.ToString(this.comboTypeObservedData2.SelectedItem));


                    sw08.WriteLine("Observed3-----");

                    //Is Displayed
                    sw08.WriteLine(Convert.ToString(this.checkObsWT3.Checked));
                    //Is on Secondary Axis
                    if (this.checkObservedData3Sec.Checked == true)
                    {
                        sw08.WriteLine("Secondary");
                    }
                    else
                    {
                        sw08.WriteLine("Primary");
                    }
                    //Label
                    sw08.WriteLine(this.textObs3Label.Text);
                    //Plot Type Index value
                    sw08.WriteLine(Convert.ToString(this.comboTypeObservedData3.SelectedItem));


                    //Clean up and close file
                    sw08.Flush();
                    sw08.Close();

                }//close writer

            }//close method

           

            #endregion

   
        #region "Load Number 1 DAT file Method"

            public void methodLoadHydrologyPrefs1()
            {
                //Instantiate reader
                StreamReader stmReader101 = new StreamReader("Graphing/Hydrology_Prefs1.dat");

                stmReader101.ReadLine(); 
                stmReader101.ReadLine();
                stmReader101.ReadLine();
                stmReader101.ReadLine(); 
                stmReader101.ReadLine(); 
                stmReader101.ReadLine();
                stmReader101.ReadLine();

                stmReader101.ReadLine();

                stmReader101.ReadLine();//water table----------------------------
                //Is Displayed
                this.checkPreWT.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                string sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkWaterTableDepthSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkWaterTableDepthSec.Checked = true;
                        break;
                    default:
                        break;
                } 
                //Plot Type Index Value
                this.comboTypeWaterTableDepth.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//DryZoneDepth----------------------------
                //Is Displayed
                this.checkDryZoneDepth.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkDryZoneDepthSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkDryZoneDepthSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value   
                this.comboTypeDryZoneDepth.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//SurfaceStorage----------------------------
                //Is Displayed
                this.checkSurfaceStorage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkSurfaceStorageSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkSurfaceStorageSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeSurfaceStorage.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//Rainfall----------------------------
                //Is Displayed
                this.checkRainfall.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkRainfallSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkRainfallSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeRainfall.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//Infiltration----------------------------
                //Is Displayed
                this.checkInfiltration.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkInfiltrationSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkInfiltrationSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeInfiltration.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//Evaporation----------------------------
                //Is Displayed
                this.checkEvaporation.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkEvaporationSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkEvaporationSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeEvaporation.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//Drainage----------------------------
                //Is Displayed
                this.checkDrainage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkDrainageSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkDrainageSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeDrainage.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//SurfaceRunoff----------------------------
                //Is Displayed
                this.checkSurfaceRunoff.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkSurfaceRunoffSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkSurfaceRunoffSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeSurfaceRunoff.SelectedItem = stmReader101.ReadLine();

                stmReader101.ReadLine();//WaterLoss----------------------------
                //Is Displayed
                this.checkWaterLoss.Checked = Convert.ToBoolean(stmReader101.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader101.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkWaterLossSec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkWaterLossSec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Plot Type Index Value
                this.comboTypeWaterLoss.SelectedItem = stmReader101.ReadLine();

                //Clean up and close file
                stmReader101.Close();  


            }//Close Method 


            public void methodLoadObservedPrefs1()
            {
                //Instantiate reader
                StreamReader stmReader01 = new StreamReader("Graphing/Observed_Prefs1.dat");

                stmReader01.ReadLine();
                stmReader01.ReadLine();
                stmReader01.ReadLine();
                stmReader01.ReadLine();
                stmReader01.ReadLine(); 
                stmReader01.ReadLine();
                stmReader01.ReadLine();


                stmReader01.ReadLine(); //sw3.WriteLine("Observed1-----");
                //Filepath
                //this.textObsFile.Text = stmReader01.ReadLine();

                //Is Displayed
                this.checkObsWT1.Checked = Convert.ToBoolean(stmReader01.ReadLine());

                //Is on Secondary Axis
                string sTempAxis = stmReader01.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkObservedData1Sec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkObservedData1Sec.Checked = true;
                        break;
                    default:
                        break;
                }

                //Label
                this.textObs1Label.Text = stmReader01.ReadLine();

                //Plot Type Index Value
                this.comboTypeObservedData1.SelectedItem = stmReader01.ReadLine();


                stmReader01.ReadLine(); //sw3.WriteLine("Observed2-----");
                //Filepath
                //this.textObsFile2.Text = stmReader01.ReadLine();

                //Is Displayed
                this.checkObsWT2.Checked = Convert.ToBoolean(stmReader01.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader01.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkObservedData2Sec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkObservedData2Sec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Label
                this.textObs2Label.Text = stmReader01.ReadLine();
                //Plot Type Index value
                this.comboTypeObservedData2.SelectedItem = stmReader01.ReadLine();


                stmReader01.ReadLine(); //sw3.WriteLine("Observed3-----");
                //Filepath
                //this.textObsFile3.Text = stmReader01.ReadLine();

                //Is Displayed
                this.checkObsWT3.Checked = Convert.ToBoolean(stmReader01.ReadLine());
                //Is on Secondary Axis
                sTempAxis = stmReader01.ReadLine();
                switch (sTempAxis)
                {
                    case "Primary":
                        this.checkObservedData3Sec.Checked = false;
                        break;
                    case "Secondary":
                        this.checkObservedData3Sec.Checked = true;
                        break;
                    default:
                        break;
                }
                //Label
                this.textObs3Label.Text = stmReader01.ReadLine();
                //Plot Type Index value
                this.comboTypeObservedData3.SelectedItem = stmReader01.ReadLine();



                //Clean up and close file
                stmReader01.Close();              

            } 


            public void methodLoadPrefs1()
            {
                //Instantiate reader
                StreamReader stmReader201 = new StreamReader("Graphing/Preference1.dat");

                stmReader201.ReadLine();
                stmReader201.ReadLine();
                stmReader201.ReadLine();
                stmReader201.ReadLine();
                stmReader201.ReadLine();
                stmReader201.ReadLine();
                stmReader201.ReadLine();

                stmReader201.ReadLine(); //sw3.WriteLine("XAxis-----");
                //Start
                this.textStartDate.Text = stmReader201.ReadLine();
                //End
                this.textEndDate.Text = stmReader201.ReadLine();

                stmReader201.ReadLine(); //sw3.WriteLine("Primary Y--");
                //Is Displayed
                this.checkDisplayPrimAxis.Checked = Convert.ToBoolean(stmReader201.ReadLine());
                //Is Reversed
                this.checkReversePrimAxis.Checked = Convert.ToBoolean(stmReader201.ReadLine());
                //Max
                this.textMinPrimary.Text = stmReader201.ReadLine();
                //Min
                this.textMaxPrimary.Text = stmReader201.ReadLine();

                stmReader201.ReadLine(); //sw3.WriteLine("Secondary Y--");
                //Is Displayed
                this.checkDisplaySecAxis.Checked = Convert.ToBoolean(stmReader201.ReadLine());
                //Is Reversed
                this.checkReverseSecAxis.Checked = Convert.ToBoolean(stmReader201.ReadLine());
                //Max
                this.textMinSecondary.Text = stmReader201.ReadLine();
                //Min
                this.textMaxSecondary.Text = stmReader201.ReadLine();



                //Clean up and close file
                stmReader201.Close();

            }

            public void methodLoadFilePath()
            {
                //Instantiate reader
                StreamReader stmReader301 = new StreamReader("Graphing/Observed_Paths.dat");

                this.textObsFile.Text = stmReader301.ReadLine();
                this.textObsFile2.Text = stmReader301.ReadLine();
                this.textObsFile3.Text = stmReader301.ReadLine();

                //Clean up and close file
                stmReader301.Close();

            }




            #endregion 




        #region "Onload - Display Plots - Includes Handling Plot Types"

            private void methodDisplayPreWT()
            {
                //1.If checked
                if (this.checkPreWT.Checked == true)
                {

                    classPreWTType();

                }

                //2.Unchecked
                if (this.checkPreWT.Checked == false)
                {

                    classClearPreWT();
                }

            }

            private void methodDisplayObs1()
            {

                //First Check to See if Data File 1 is loaded, if not then return out
                if (this.textObsFile.Text == "")
                {
                    return;
                }


                //1.If checked
                if (this.checkObsWT1.Checked == true)
                {
                    classObs1Type(); 
                }

                //2.Unchecked
                if (this.checkObsWT1.Checked == false)
                {
                    classClearObs1();
                }
            }

            private void methodDisplayObs2()
            {
                //First Check to See if Data File 2 is loaded, if not then return out
                if (this.textObsFile2.Text == "")
                {
                    return;
                }


                //1.If checked
                if (this.checkObsWT2.Checked == true)
                {
                    classObs2Type(); 

                }

                //2.Unchecked
                if (this.checkObsWT2.Checked == false)
                {
                    classClearObs2();
                }
            }

            private void methodDisplayObs3()
            {
                //First Check to See if Data File 3 is loaded, if not then return out
                if (this.textObsFile3.Text == "")
                {
                    return;
                }


                //1.If checked
                if (this.checkObsWT3.Checked == true)
                {
                    classObs3Type(); 
                }

                //2.Unchecked
                if (this.checkObsWT3.Checked == false)
                {
                    classClearObs3();
                }
            }

            private void methodDisplaySurfaceStorage()
            {
                //1.If checked
                if (this.checkSurfaceStorage.Checked == true)
                {
                    classSurfaceStorageType();
                }

                //2.Unchecked
                if (this.checkSurfaceStorage.Checked == false)
                {
                    classClearSurfaceStorage();
                }

            }

            private void methodDisplayDryZone()
            {
                //1.If checked
                if (this.checkDryZoneDepth.Checked == true)
                {
                    classDryZoneType();
                }

                //2.Unchecked
                if (this.checkDryZoneDepth.Checked == false)
                {
                    classClearDryZone();
                }
            }

            private void methodDisplayRainfall()
            {
                //1.If checked
                if (this.checkRainfall.Checked == true)
                {
                    classRainfallType();

                }

                //2.Unchecked
                if (this.checkRainfall.Checked == false)
                {
                    classClearRainfall();
                }

            }

            private void methodDisplayInfiltration()
            {
                //1.If checked
                if (this.checkInfiltration.Checked == true)
                {
                    classInfiltrationType();
                }

                //2.Unchecked
                if (this.checkInfiltration.Checked == false)
                {
                    classClearInfiltration();
                }
            }

            private void methodDisplayEvaporation()
            {
                //1.If checked
                if (this.checkEvaporation.Checked == true)
                {
                    classEvaporationType();
                }

                //2.Unchecked
                if (this.checkEvaporation.Checked == false)
                {
                    classClearEvaporation();
                }
            }

            private void methodDisplayDrainage()
            {
                //1.If checked
                if (this.checkDrainage.Checked == true)
                {
                    classDrainageType();
                }

                //2.Unchecked
                if (this.checkDrainage.Checked == false)
                {
                    classClearDrainage();
                }
            }

            private void methodDisplaySurfaceRunoff()
            {
                //1.If checked
                if (this.checkSurfaceRunoff.Checked == true)
                {
                    classSurfaceRunoffType();
                }

                //2.Unchecked
                if (this.checkSurfaceRunoff.Checked == false)
                {
                    classClearSurfaceRunoff();
                }
            }

            private void methodDisplayWaterLoss()
            {
                //1.If checked
                if (this.checkWaterLoss.Checked == true)
                {
                    classWaterLossType();
                }

                //2.Unchecked
                if (this.checkWaterLoss.Checked == false)
                {
                    classClearWaterLoss();
                }
            }



        #endregion

          
        #region "Onload - Change Axis"

            private void methodChangeAxis()
            {
                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;

                if (checkWaterTableDepthSec.Checked == true)
                {
                    PreWTCurve.IsY2Axis = true;
                    PreWTBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    PreWTCurve.IsY2Axis = false;
                    PreWTBar.IsY2Axis = false;
                    ReDraw();
                }
           

                if (checkDryZoneDepthSec.Checked == true)
                {
                    DryZoneCurve.IsY2Axis = true;
                    DryZoneBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    DryZoneCurve.IsY2Axis = false;
                    DryZoneBar.IsY2Axis = false;
                    ReDraw();
                }
            


                if (checkSurfaceStorageSec.Checked == true)
                {
                    SurfaceStorageCurve.IsY2Axis = true;
                    SurfaceStorageBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    SurfaceStorageCurve.IsY2Axis = false;
                    SurfaceStorageBar.IsY2Axis = false;
                    ReDraw();
                }
            

                if (checkRainfallSec.Checked == true)
                {
                    RainfallCurve.IsY2Axis = true;
                    RainfallBar.IsY2Axis = true;
                    MonthlyRainfallCurve.IsY2Axis = true;
                    MonthlyRainfallBar.IsY2Axis = true;
                    CumulativeRainfallCurve.IsY2Axis = true;
                    CumulativeRainfallBar.IsY2Axis = true;
                    YearlyRainfallCurve.IsY2Axis = true;
                    YearlyRainfallBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    RainfallCurve.IsY2Axis = false;
                    RainfallBar.IsY2Axis = false;
                    MonthlyRainfallCurve.IsY2Axis = false;
                    MonthlyRainfallBar.IsY2Axis = false;
                    CumulativeRainfallCurve.IsY2Axis = false;
                    CumulativeRainfallBar.IsY2Axis = false;
                    YearlyRainfallCurve.IsY2Axis = false;
                    YearlyRainfallBar.IsY2Axis = false;
                    ReDraw();
                }
            

                if (checkInfiltrationSec.Checked == true)
                {
                    InfiltrationCurve.IsY2Axis = true;
                    InfiltrationBar.IsY2Axis = true;
                    MonthlyInfiltrationCurve.IsY2Axis = true;
                    MonthlyInfiltrationBar.IsY2Axis = true;
                    CumulativeInfiltrationCurve.IsY2Axis = true;
                    CumulativeInfiltrationBar.IsY2Axis = true;
                    YearlyInfiltrationCurve.IsY2Axis = true;
                    YearlyInfiltrationBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    InfiltrationCurve.IsY2Axis = false;
                    InfiltrationBar.IsY2Axis = false;
                    MonthlyInfiltrationCurve.IsY2Axis = false;
                    MonthlyInfiltrationBar.IsY2Axis = false;
                    CumulativeInfiltrationCurve.IsY2Axis = false;
                    CumulativeInfiltrationBar.IsY2Axis = false;
                    YearlyInfiltrationCurve.IsY2Axis = false;
                    YearlyInfiltrationBar.IsY2Axis = false;
                    ReDraw();
                }
            

                if (checkEvaporationSec.Checked == true)
                {
                    AETCurve.IsY2Axis = true;
                    AETBar.IsY2Axis = true;
                    MonthlyAETCurve.IsY2Axis = true;
                    MonthlyAETBar.IsY2Axis = true;
                    CumulativeAETCurve.IsY2Axis = true;
                    CumulativeAETBar.IsY2Axis = true;
                    YearlyAETCurve.IsY2Axis = true;
                    YearlyAETBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    AETCurve.IsY2Axis = false;
                    AETBar.IsY2Axis = false;
                    MonthlyAETCurve.IsY2Axis = false;
                    MonthlyAETBar.IsY2Axis = false;
                    CumulativeAETCurve.IsY2Axis = false;
                    CumulativeAETBar.IsY2Axis = false;
                    YearlyAETCurve.IsY2Axis = false;
                    YearlyAETBar.IsY2Axis = false;
                    ReDraw();
                }
            

                if (checkDrainageSec.Checked == true)
                {
                    DrainageCurve.IsY2Axis = true;
                    DrainageBar.IsY2Axis = true;
                    MonthlyDrainageCurve.IsY2Axis = true;
                    MonthlyDrainageBar.IsY2Axis = true;
                    CumulativeDrainageCurve.IsY2Axis = true;
                    CumulativeDrainageBar.IsY2Axis = true;
                    YearlyDrainageCurve.IsY2Axis = true;
                    YearlyDrainageBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    DrainageCurve.IsY2Axis = false;
                    DrainageBar.IsY2Axis = false;
                    MonthlyDrainageCurve.IsY2Axis = false;
                    MonthlyDrainageBar.IsY2Axis = false;
                    CumulativeDrainageCurve.IsY2Axis = false;
                    CumulativeDrainageBar.IsY2Axis = false;
                    YearlyDrainageCurve.IsY2Axis = false;
                    YearlyDrainageBar.IsY2Axis = false;
                    ReDraw();
                }
            

                if (checkSurfaceRunoffSec.Checked == true)
                {
                    RunoffCurve.IsY2Axis = true;
                    RunoffBar.IsY2Axis = true;
                    MonthlyRunoffCurve.IsY2Axis = true;
                    MonthlyRunoffBar.IsY2Axis = true;
                    CumulativeRunoffCurve.IsY2Axis = true;
                    CumulativeRunoffBar.IsY2Axis = true;
                    YearlyRunoffCurve.IsY2Axis = true;
                    YearlyRunoffBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    RunoffCurve.IsY2Axis = false;
                    RunoffBar.IsY2Axis = false;
                    MonthlyRunoffCurve.IsY2Axis = false;
                    MonthlyRunoffBar.IsY2Axis = false;
                    CumulativeRunoffCurve.IsY2Axis = false;
                    CumulativeRunoffBar.IsY2Axis = false;
                    YearlyRunoffCurve.IsY2Axis = false;
                    YearlyRunoffBar.IsY2Axis = false;
                    ReDraw();
                }
           

                if (checkWaterLossSec.Checked == true)
                {
                    WaterLossCurve.IsY2Axis = true;
                    WaterLossBar.IsY2Axis = true;
                    MonthlyWaterLossCurve.IsY2Axis = true;
                    MonthlyWaterLossBar.IsY2Axis = true;
                    CumulativeWaterLossCurve.IsY2Axis = true;
                    CumulativeWaterLossBar.IsY2Axis = true;
                    YearlyWaterLossCurve.IsY2Axis = true;
                    YearlyWaterLossBar.IsY2Axis = true;
                    ReDraw();
                }
                else
                {
                    WaterLossCurve.IsY2Axis = false;
                    WaterLossBar.IsY2Axis = false;
                    MonthlyWaterLossCurve.IsY2Axis = false;
                    MonthlyWaterLossBar.IsY2Axis = false;
                    CumulativeWaterLossCurve.IsY2Axis = false;
                    CumulativeWaterLossBar.IsY2Axis = false;
                    YearlyWaterLossCurve.IsY2Axis = false;
                    YearlyWaterLossBar.IsY2Axis = false;
                    ReDraw();
                }
            

                if (this.textObsFile.Text != "" && checkObservedData1Sec.Checked == true)
                {
                    myCurveObs.IsY2Axis = true;
                    myBarObs.IsY2Axis = true;
                    ReDraw();
                }
                if (this.textObsFile.Text != "" && checkObservedData1Sec.Checked == false)
                {
                    myCurveObs.IsY2Axis = false;
                    myBarObs.IsY2Axis = false;
                    ReDraw();
                }


                if (this.textObsFile2.Text != "" && checkObservedData2Sec.Checked == true)
                {
                    myCurveObs2.IsY2Axis = true;
                    myBarObs2.IsY2Axis = true;
                    ReDraw();
                }
                if (this.textObsFile2.Text != "" && checkObservedData2Sec.Checked == false)
                {
                    myCurveObs2.IsY2Axis = false;
                    myBarObs2.IsY2Axis = false;
                    ReDraw();
                }


                if (this.textObsFile3.Text != "" && checkObservedData3Sec.Checked == true)
                {
                    myCurveObs3.IsY2Axis = true;
                    myBarObs3.IsY2Axis = true;
                    ReDraw();
                }
                if (this.textObsFile3.Text != "" && checkObservedData3Sec.Checked == false)
                {
                    myCurveObs3.IsY2Axis = false;
                    myBarObs3.IsY2Axis = false;
                    ReDraw();
                }
            }



            #endregion //Hydrology - Change Axis


        #region "Onload - Reading in Plot Type - Convert to index value"

            private int methodConvertIndex(string sIndexWord)
            {
                int iIndex;

                if (sIndexWord == "DailyLine")
                {
                    return iIndex = 0;
                }
                if (sIndexWord == "DailyBar")
                {
                    return iIndex = 1;
                }

                if (sIndexWord == "DailyScatter")
                {
                    return iIndex = 2;
                }

                if (sIndexWord == "MonthlyLine")
                {
                    return iIndex = 3;
                }

                if (sIndexWord == "MonthlyBar")
                {
                    return iIndex = 4;
                }

                if (sIndexWord == "MonthlyScatter")
                {
                    return iIndex = 5;
                }

                if (sIndexWord == "YearlyLine")
                {
                    return iIndex = 6;
                }

                if (sIndexWord == "YearlyBar")
                {
                    return iIndex = 7;
                }

                if (sIndexWord == "YearlyScatter")
                {
                    return iIndex = 8;
                }

                if (sIndexWord == "CumulativeLine")
                {
                    return iIndex = 9;
                }

                if (sIndexWord == "CumulativeBar")
                {
                    return iIndex = 10;
                }

                if (sIndexWord == "CumulativeScatter")
                {
                    return iIndex = 11;
                }


                return iIndex = 0;
            }

            private int methodConvertIndexObs(string sIndexWord)
            {
                int iIndex;

                if (sIndexWord == "Line")
                {
                    return iIndex = 0;
                }
                if (sIndexWord == "Scatter")
                {
                    return iIndex = 1;
                }
                if (sIndexWord == "Bar")
                {
                    return iIndex = 2;
                }

                return iIndex = 0;
            }


            #endregion  


        #region "Onload - Update Axes Method"

            private void methodUpdatePlot()
            {
                zg1.GraphPane.XAxis.Type = AxisType.Date;
                zg1.GraphPane.XAxis.Scale.Format = "dd-MMM-yy";
                
                //Inialize Variables
                //Use the comma character to separate the items
                char[] sep = { '/' };
                double dtextStartYear, dtextStartMonth, dtextStartDay;
                double dtextEndYear, dtextEndMonth, dtextEndDay;
                double dStartDate, dEndDate;
                double dStartDateMonth, dEndDateMonth;
                //double dScaleMonths;


                //Throw error if there is a start date, no end date and no month limit
                if (this.textStartDate.Text != "" && this.textEndDate.Text == "")
                {
                    MessageBox.Show("If you enter a start date, you must also enter an end date OR a visible month value",
                        "X Axis Scale Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //X Scale Start Date
                if (this.textStartDate.Text != "")
                {
                    // Read in text box and Split the items on the line using the / as delimiter
                    string[] items = this.textStartDate.Text.Split(sep);
                    // If there's less than 3 items, throw an exception
                    if (items.Length < 3)
                        throw new Exception("Error: Incorrect Date Format");

                    // Parse as doubles
                    dtextStartDay = Double.Parse(items[1]);
                    dtextStartMonth = Double.Parse(items[0]);
                    dtextStartYear = Double.Parse(items[2]);

                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    int iStartYear = Convert.ToInt32(dtextStartYear);
                    int iStartMonth = Convert.ToInt32(dtextStartMonth);
                    int iStartDay = Convert.ToInt32(dtextStartDay);


                    //Then do Zedgraph XDate
                    XDate myStartXDate = new XDate(iStartYear, iStartMonth, iStartDay);
                    dStartDate = myStartXDate;
                    XDate myStartXDateMonth = new XDate(iStartYear, iStartMonth, iStartDay);
                    dStartDateMonth = myStartXDateMonth;

                    //Get months
                    //dScaleMonths = Convert.ToDouble(this.textLengthTime.Text);

                    //Set X Scale Start Date
                    zg1.GraphPane.XAxis.Scale.Min = dStartDate;
                    //zg1.GraphPane.XAxis.Scale.Max = dStartDate + (dScaleMonths * 31);

                   
                }

                //X Scale End Date
                if (this.textEndDate.Text != "")
                {
                    // Read in text box and Split the items on the line using the / as delimiter
                    string[] items = this.textEndDate.Text.Split(sep);
                    // If there's less than 3 items, throw an exception
                    if (items.Length < 3)
                        throw new Exception("Error: Incorrect Date Format");

                    // Parse as doubles
                    dtextEndDay = Double.Parse(items[1]);
                    dtextEndMonth = Double.Parse(items[0]);
                    dtextEndYear = Double.Parse(items[2]);

                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    int iEndYear = Convert.ToInt32(dtextEndYear);
                    int iEndMonth = Convert.ToInt32(dtextEndMonth);
                    int iEndDay = Convert.ToInt32(dtextEndDay);


                    //Then do Zedgraph XDate
                    XDate myEndXDate = new XDate(iEndYear, iEndMonth, iEndDay);
                    dEndDate = myEndXDate;
                    XDate myEndXDateMonth = new XDate(iEndYear, iEndMonth, iEndDay);
                    dEndDateMonth = myEndXDateMonth;

                    //Get months
                    //dScaleMonths = Convert.ToDouble(this.textLengthTime.Text);

                    //Set X Scale End Date
                    zg1.GraphPane.XAxis.Scale.Max = dEndDate;

                }


                //Y Axis Scale
                if (this.textMinPrimary.Text != "")
                {
                    zg1.GraphPane.YAxis.Scale.Min = Convert.ToDouble(this.textMinPrimary.Text);
                }
                if (this.textMaxPrimary.Text != "")
                {
                    zg1.GraphPane.YAxis.Scale.Max = Convert.ToDouble(this.textMaxPrimary.Text);
                }
                if (this.textMinSecondary.Text != "")
                {
                    zg1.GraphPane.Y2Axis.Scale.Min = Convert.ToDouble(this.textMinSecondary.Text);
                }
                if (this.textMaxSecondary.Text != "")
                {
                    zg1.GraphPane.Y2Axis.Scale.Max = Convert.ToDouble(this.textMaxSecondary.Text);
                }



                //Scale in Months, but only if no end date specified
                //if (this.textStartDate.Text == "" && this.textEndDate.Text == "")
                //{
                //    //Change visible scale to user defined months
                //    //Get months
                //    dScaleMonths = Convert.ToDouble(this.textLengthTime.Text);


                //    //Reset scale
                //    Scale xScale = zg1.GraphPane.XAxis.Scale;
                //    xScale.Min = dFirstDate;
                //    xScale.Max = dFirstDate + (dScaleMonths * 31);
                //}


                // Make sure the Y axis is rescaled to accommodate actual data
                zg1.AxisChange();

                // Force a redraw
                zg1.Invalidate();


            }

        #endregion


        #region "Onload - Load in Observed Files"

            private void methodLoadInObserved1()
            {

                classClearListObs1();


                //This Section Plots Initial Graph Data

                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;


                // Make some data points arrays
                ObsWTList = new PointPairList();


                //Load Observed Data to Plot
                // Open the GRH file
                StreamReader inObserved = new StreamReader(this.textObsFile.Text);

                // use the comma character to separate the items
                char[] sep = { '/', ',' };

                string line;
                PointPairList list = new PointPairList();

                //Parameters in Observed Water Table File file, in order, are as follows
                //Month/Day/Year in mm/dd/yyyy format
                //Water Table Depth


                // read one line of data at a time until the end of file
                while ((line = inObserved.ReadLine()) != null)
                {
                    // split the items on the line using the tab character as delimiter
                    string[] items = line.Split(sep);
                    // if there's less than 2 items, throw an exception
                    if (items.Length < 2)
                        throw new Exception("Error: Not enough items on line");

                    //Declare Variables in Observed file
                    double dObsYear, dObsMonth, dObsDay, dObsDepthWaterTable;

                    // if the value is missing mark it so. Otherwise, parse it as a double
                    if (items[0].Length == 0)
                        dObsMonth = PointPair.Missing;
                    else
                        dObsMonth = Double.Parse(items[0]);

                    if (items[1].Length == 0)
                        dObsDay = PointPair.Missing;
                    else
                        dObsDay = Double.Parse(items[1]);

                    if (items[2].Length == 0)
                        dObsYear = PointPair.Missing;
                    else
                        dObsYear = Double.Parse(items[2]);

                    if (items[3].Length == 0)
                        dObsDepthWaterTable = PointPair.Missing;
                    else
                        dObsDepthWaterTable = Double.Parse(items[3]);



                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    int iObsYear = Convert.ToInt32(dObsYear);
                    int iObsMonth = Convert.ToInt32(dObsMonth);
                    int iObsDay = Convert.ToInt32(dObsDay);

                    //Then do Zedgraph XDate
                    XDate myObsXDate = new XDate(iObsYear, iObsMonth, iObsDay);
                    Double dObsDate = myObsXDate;

                    // add the values to the PointPairList

                    ObsWTList.Add(dObsDate, dObsDepthWaterTable);

                }

                inObserved.Close();

            }
            
        
            private void methodLoadInObserved2()
            {

                classClearListObs2();


                //This Section Plots Initial Graph Data

                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;


                // Make some data points arrays
                ObsWTList2 = new PointPairList();


                //Load Observed Data to Plot
                // Open the GRH file
                StreamReader inObserved2 = new StreamReader(this.textObsFile2.Text);

                // use the comma character to separate the items
                char[] sep = { '/', ',' };

                string line;
                PointPairList list = new PointPairList();

                //Parameters in Observed Water Table File file, in order, are as follows
                //Month/Day/Year in mm/dd/yyyy format
                //Water Table Depth


                // read one line of data at a time until the end of file
                while ((line = inObserved2.ReadLine()) != null)
                {
                    // split the items on the line using the tab character as delimiter
                    string[] items = line.Split(sep);
                    // if there's less than 2 items, throw an exception
                    if (items.Length < 2)
                        throw new Exception("Error: Not enough items on line");

                    //Declare Variables in Observed file
                    double dObsYear2, dObsMonth2, dObsDay2, dObsDepthWaterTable2;

                    // if the value is missing mark it so. Otherwise, parse it as a double
                    if (items[0].Length == 0)
                        dObsMonth2 = PointPair.Missing;
                    else
                        dObsMonth2 = Double.Parse(items[0]);

                    if (items[1].Length == 0)
                        dObsDay2 = PointPair.Missing;
                    else
                        dObsDay2 = Double.Parse(items[1]);

                    if (items[2].Length == 0)
                        dObsYear2 = PointPair.Missing;
                    else
                        dObsYear2 = Double.Parse(items[2]);

                    if (items[3].Length == 0)
                        dObsDepthWaterTable2 = PointPair.Missing;
                    else
                        dObsDepthWaterTable2 = Double.Parse(items[3]);



                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    int iObsYear2 = Convert.ToInt32(dObsYear2);
                    int iObsMonth2 = Convert.ToInt32(dObsMonth2);
                    int iObsDay2 = Convert.ToInt32(dObsDay2);

                    //Then do Zedgraph XDate
                    XDate myObsXDate2 = new XDate(iObsYear2, iObsMonth2, iObsDay2);
                    Double dObsDate2 = myObsXDate2;

                    // add the values to the PointPairList

                    ObsWTList2.Add(dObsDate2, dObsDepthWaterTable2);

                }

                inObserved2.Close();

            }


            private void methodLoadInObserved3()
            {

                classClearListObs3();


                //This Section Plots Initial Graph Data

                // Get a reference to the GraphPane
                GraphPane myPane = zg1.GraphPane;


                // Make some data points arrays
                ObsWTList3 = new PointPairList();


                //Load Observed Data to Plot
                // Open the GRH file
                StreamReader inObserved3 = new StreamReader(this.textObsFile3.Text);

                // use the comma character to separate the items
                char[] sep = { '/', ',' };

                string line;
                PointPairList list = new PointPairList();

                //Parameters in Observed Water Table File file, in order, are as follows
                //Month/Day/Year in mm/dd/yyyy format
                //Water Table Depth


                // read one line of data at a time until the end of file
                while ((line = inObserved3.ReadLine()) != null)
                {
                    // split the items on the line using the tab character as delimiter
                    string[] items = line.Split(sep);
                    // if there's less than 2 items, throw an exception
                    if (items.Length < 2)
                        throw new Exception("Error: Not enough items on line");

                    //Declare Variables in Observed file
                    double dObsYear3, dObsMonth3, dObsDay3, dObsDepthWaterTable3;

                    // if the value is missing mark it so. Otherwise, parse it as a double
                    if (items[0].Length == 0)
                        dObsMonth3 = PointPair.Missing;
                    else
                        dObsMonth3 = Double.Parse(items[0]);

                    if (items[1].Length == 0)
                        dObsDay3 = PointPair.Missing;
                    else
                        dObsDay3 = Double.Parse(items[1]);

                    if (items[2].Length == 0)
                        dObsYear3 = PointPair.Missing;
                    else
                        dObsYear3 = Double.Parse(items[2]);

                    if (items[3].Length == 0)
                        dObsDepthWaterTable3 = PointPair.Missing;
                    else
                        dObsDepthWaterTable3 = Double.Parse(items[3]);



                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    int iObsYear3 = Convert.ToInt32(dObsYear3);
                    int iObsMonth3 = Convert.ToInt32(dObsMonth3);
                    int iObsDay3 = Convert.ToInt32(dObsDay3);

                    //Then do Zedgraph XDate
                    XDate myObsXDate3 = new XDate(iObsYear3, iObsMonth3, iObsDay3);
                    Double dObsDate3 = myObsXDate3;

                    // add the values to the PointPairList

                    ObsWTList3.Add(dObsDate3, dObsDepthWaterTable3);

                }

                inObserved3.Close();

            }



        #endregion


            #region "Onload - Plot Formatting"

            private void methodLoadFormattingScheme()
            {
                //Set path to location of program
                Directory.SetCurrentDirectory(Application.StartupPath);

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

                //Handle if files do not exists

                    #region "General"

                if (File.Exists(sFileGeneral))
                {
                    //Instantiate reader
                    StreamReader prefs001 = new StreamReader(sFileGeneral);

                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();
                    prefs001.ReadLine();//TITLE---

                    zg1.GraphPane.Title.IsVisible = Convert.ToBoolean(prefs001.ReadLine());//sw4.WriteLine(Convert.ToString(this.checkDisplayLabel.Checked));
                    string sLine1Text = prefs001.ReadLine();
                    string sLine2Text = prefs001.ReadLine();
                    if (sLine2Text == "")
                    {
                        zg1.GraphPane.Title.Text = sLine1Text;
                    }
                    else
                    {
                       zg1.GraphPane.Title.Text = sLine1Text + '\n' + sLine2Text;
                    }
                    zg1.GraphPane.Title.FontSpec.Family = prefs001.ReadLine();//font
                    zg1.GraphPane.Title.FontSpec.Size = Convert.ToInt16(prefs001.ReadLine());//size
                    string sLine1FontStyle = prefs001.ReadLine();
                    switch (sLine1FontStyle)
                    {
                        case "Regular":
                            zg1.GraphPane.Title.FontSpec.IsBold = false;
                            break;
                        case "Bold":
                            zg1.GraphPane.Title.FontSpec.IsBold = true;
                            break;
                        default:
                            break;

                    }
                    zg1.GraphPane.Title.FontSpec.IsItalic = Convert.ToBoolean(prefs001.ReadLine());//italics
                    zg1.GraphPane.Title.FontSpec.IsUnderline = Convert.ToBoolean(prefs001.ReadLine());//underline

                    prefs001.ReadLine();//Legend---
                    zg1.GraphPane.Legend.IsVisible = Convert.ToBoolean(prefs001.ReadLine());
                    string sPosition = prefs001.ReadLine();
                    switch (sPosition)
                    {
                        case "TopLeft":
                            zg1.GraphPane.Legend.Position = ZedGraph.LegendPos.TopFlushLeft;
                            break;
                        case "BottomLeft":
                            zg1.GraphPane.Legend.Position = ZedGraph.LegendPos.BottomFlushLeft;
                            break;
                        case "TopCenter":
                            zg1.GraphPane.Legend.Position = ZedGraph.LegendPos.TopCenter;
                            break;
                        case "BottomCenter":
                            zg1.GraphPane.Legend.Position = ZedGraph.LegendPos.BottomCenter;
                            break;
                        case "Left":
                            zg1.GraphPane.Legend.Position = ZedGraph.LegendPos.Left;
                            break;
                        case "Right":
                            zg1.GraphPane.Legend.Position = ZedGraph.LegendPos.Right;
                            break;
                        default:
                            break;

                    }
                    zg1.GraphPane.Legend.FontSpec.Family = prefs001.ReadLine();//font
                    zg1.GraphPane.Legend.FontSpec.Size = Convert.ToInt32(prefs001.ReadLine());//size
                    string sLine1LegendStyle = prefs001.ReadLine();
                    switch (sLine1LegendStyle)
                    {
                        case "Regular":
                            zg1.GraphPane.Legend.FontSpec.IsBold = false;
                            break;
                        case "Bold":
                            zg1.GraphPane.Legend.FontSpec.IsBold = true;
                            break;
                        default:
                            break;

                    }
                    zg1.GraphPane.Legend.FontSpec.IsItalic = Convert.ToBoolean(prefs001.ReadLine());//italics
                    zg1.GraphPane.Legend.FontSpec.IsUnderline = Convert.ToBoolean(prefs001.ReadLine());//underline

                    prefs001.ReadLine();//Background---

                    System.Drawing.ColorConverter colConvert = new ColorConverter();

                    string sMainpaneColor1 = prefs001.ReadLine();
                    string sMainPaneGradient = prefs001.ReadLine();
                    string sMainpaneColor2 = prefs001.ReadLine();
                    int iMainpaneGradientAngle = Convert.ToInt32(prefs001.ReadLine());
                    if (sMainPaneGradient == "False")
                    {
                        zg1.GraphPane.Fill = new Fill((System.Drawing.Color)colConvert.ConvertFromString(sMainpaneColor1));
                    }
                    else
                    {
                        zg1.GraphPane.Fill = new Fill((System.Drawing.Color)colConvert.ConvertFromString(sMainpaneColor1),
                            (System.Drawing.Color)colConvert.ConvertFromString(sMainpaneColor2), iMainpaneGradientAngle);
                    }


                    string sPlotpaneColor1 = prefs001.ReadLine();
                    string sPlotPaneGradient = prefs001.ReadLine();
                    string sPlotpaneColor2 = prefs001.ReadLine();
                    int iPlotpaneGradientAngle = Convert.ToInt32(prefs001.ReadLine());
                    if (sPlotPaneGradient == "False")
                    {
                        zg1.GraphPane.Chart.Fill = new Fill((System.Drawing.Color)colConvert.ConvertFromString(sPlotpaneColor1));
                    }
                    else
                    {
                        zg1.GraphPane.Chart.Fill = new Fill((System.Drawing.Color)colConvert.ConvertFromString(sPlotpaneColor1),
                            (System.Drawing.Color)colConvert.ConvertFromString(sPlotpaneColor2), iPlotpaneGradientAngle);
                    }


                    prefs001.ReadLine();//Margins---
                    zg1.GraphPane.Margin.Top = Convert.ToInt32(prefs001.ReadLine());
                    zg1.GraphPane.Margin.Bottom = Convert.ToInt32(prefs001.ReadLine());
                    zg1.GraphPane.Margin.Left = Convert.ToInt32(prefs001.ReadLine());
                    zg1.GraphPane.Margin.Right = Convert.ToInt32(prefs001.ReadLine());

                    prefs001.ReadLine();//Border---
                    zg1.GraphPane.Chart.Border.IsVisible = Convert.ToBoolean(prefs001.ReadLine());
                    zg1.GraphPane.Chart.Border.Width = Convert.ToInt32(prefs001.ReadLine());
                    string sBorderColor = prefs001.ReadLine();
                    zg1.GraphPane.Chart.Border.Color =  (System.Drawing.Color)colConvert.ConvertFromString(sBorderColor);


                    //Clean up and close file
                    prefs001.Close();

                #endregion

                    #region "XAxis"

                    if (File.Exists(sFileXAxis))
                    {
                        //Instantiate reader
                        StreamReader prefs002 = new StreamReader(sFileXAxis);

                        prefs002.ReadLine();//X AXIS ------
                        prefs002.ReadLine();//TITLE---

                        zg1.GraphPane.XAxis.Title.IsVisible = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.Title.Text = prefs002.ReadLine();
                        zg1.GraphPane.XAxis.Title.FontSpec.Family = prefs002.ReadLine();//font
                        zg1.GraphPane.XAxis.Title.FontSpec.Size = Convert.ToInt16(prefs002.ReadLine());//size
                        string sXAxisFontStyle = prefs002.ReadLine();
                        switch (sXAxisFontStyle)
                        {
                            case "Regular":
                                zg1.GraphPane.XAxis.Title.FontSpec.IsBold = false;
                                break;
                            case "Bold":
                                zg1.GraphPane.XAxis.Title.FontSpec.IsBold = true;
                                break;
                            default:
                                break;

                        }
                        zg1.GraphPane.XAxis.Title.FontSpec.IsItalic = Convert.ToBoolean(prefs002.ReadLine());//italics
                        zg1.GraphPane.XAxis.Title.FontSpec.IsUnderline = Convert.ToBoolean(prefs002.ReadLine());//underline

                        prefs002.ReadLine();//SCALE---
                        zg1.GraphPane.XAxis.Type = AxisType.Date;
                        zg1.GraphPane.XAxis.Scale.Format = prefs002.ReadLine();
                        zg1.GraphPane.XAxis.Scale.FontSpec.Family = prefs002.ReadLine();//font
                        zg1.GraphPane.XAxis.Scale.FontSpec.Size = Convert.ToInt16(prefs002.ReadLine());//size
                        string sXAxisScaleFontStyle = prefs002.ReadLine();
                        switch (sXAxisScaleFontStyle)
                        {
                            case "Regular":
                                zg1.GraphPane.XAxis.Scale.FontSpec.IsBold = false;
                                break;
                            case "Bold":
                                zg1.GraphPane.XAxis.Scale.FontSpec.IsBold = true;
                                break;
                            default:
                                break;

                        }
                        zg1.GraphPane.XAxis.Scale.FontSpec.IsItalic = Convert.ToBoolean(prefs002.ReadLine());//italics
                        zg1.GraphPane.XAxis.Scale.FontSpec.IsUnderline = Convert.ToBoolean(prefs002.ReadLine());//underline

                        prefs002.ReadLine();//TIC MARKS---
                        zg1.GraphPane.XAxis.MajorTic.IsOpposite = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MajorTic.IsInside = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MajorTic.IsOutside = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MinorTic.IsOpposite = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MinorTic.IsInside = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MinorTic.IsOutside = Convert.ToBoolean(prefs002.ReadLine());

                        prefs002.ReadLine();//Grid Lines---
                        zg1.GraphPane.XAxis.MajorGrid.IsVisible= Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MajorGrid.PenWidth = Convert.ToInt32(prefs002.ReadLine());
                        string sMajorGridColor = prefs002.ReadLine();
                        zg1.GraphPane.XAxis.MajorGrid.Color = (System.Drawing.Color)colConvert.ConvertFromString(sMajorGridColor);


                        zg1.GraphPane.XAxis.MinorGrid.IsVisible = Convert.ToBoolean(prefs002.ReadLine());
                        zg1.GraphPane.XAxis.MinorGrid.PenWidth = Convert.ToInt32(prefs002.ReadLine());
                        string sMinorGridColor = prefs002.ReadLine();
                        zg1.GraphPane.XAxis.MinorGrid.Color = (System.Drawing.Color)colConvert.ConvertFromString(sMinorGridColor);


                        //Clean up and close file
                        prefs002.Close();
                    }

                    else
                    {
                        // Add gridlines to the plot, and make them gray
                        //-------------------------------------------------
                        zg1.GraphPane.XAxis.MajorGrid.IsVisible = true;
                        zg1.GraphPane.XAxis.MinorGrid.IsVisible = false;
                        //zg1.GraphPane.YAxis.MajorGrid.IsVisible = true;
                        //zg1.GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                        zg1.GraphPane.XAxis.MajorGrid.Color = Color.LightGray;
                        //zg1.GraphPane.YAxis.MajorGrid.Color = Color.LightGray;
                        //zg1.GraphPane.Y2Axis.MajorGrid.Color = Color.LightGray;




                        //Use Dates for X Axis and Format Axis
                        //-------------------------------------------------
                        zg1.GraphPane.XAxis.Type = AxisType.Date;
                        zg1.GraphPane.XAxis.Scale.Format = "dd-MMM-yy";
                        //zg1.GraphPane.XAxis.Scale.Format = "MMM";

                        //Reverse Y Axis to Reflect Depths
                        //-------------------------------------------------
                        //zg1.GraphPane.YAxis.Scale.IsReverse = true;

                        //Turn on Secondary Y Axis
                        //-------------------------------------------------
                        //zg1.GraphPane.Y2Axis.IsVisible = false;

                    }

                    #endregion

                    #region "PrimaryYAxis"

                    if (File.Exists(sFilePrimaryYAxis))
                    {
                        //Instantiate reader
                        StreamReader prefs003 = new StreamReader(sFilePrimaryYAxis);

                        prefs003.ReadLine();
                        prefs003.ReadLine();//TITLE---

                        zg1.GraphPane.YAxis.IsVisible = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.Title.Text = prefs003.ReadLine();
                        zg1.GraphPane.YAxis.Title.FontSpec.Family = prefs003.ReadLine();//font
                        zg1.GraphPane.YAxis.Title.FontSpec.Size = Convert.ToInt16(prefs003.ReadLine());//size
                        string sYAxisFontStyle = prefs003.ReadLine();
                        switch (sYAxisFontStyle)
                        {
                            case "Regular":
                                zg1.GraphPane.YAxis.Title.FontSpec.IsBold = false;
                                break;
                            case "Bold":
                                zg1.GraphPane.YAxis.Title.FontSpec.IsBold = true;
                                break;
                            default:
                                break;

                        }
                        zg1.GraphPane.YAxis.Title.FontSpec.IsItalic = Convert.ToBoolean(prefs003.ReadLine());//italics
                        zg1.GraphPane.YAxis.Title.FontSpec.IsUnderline = Convert.ToBoolean(prefs003.ReadLine());//underline

                        prefs003.ReadLine();//SCALE---
                        zg1.GraphPane.YAxis.Scale.FontSpec.Family = prefs003.ReadLine();//font
                        zg1.GraphPane.YAxis.Scale.FontSpec.Size = Convert.ToInt16(prefs003.ReadLine());//size
                        string sYAxisScaleFontStyle = prefs003.ReadLine();
                        switch (sYAxisScaleFontStyle)
                        {
                            case "Regular":
                                zg1.GraphPane.YAxis.Scale.FontSpec.IsBold = false;
                                break;
                            case "Bold":
                                zg1.GraphPane.YAxis.Scale.FontSpec.IsBold = true;
                                break;
                            default:
                                break;

                        }
                        zg1.GraphPane.YAxis.Scale.FontSpec.IsItalic = Convert.ToBoolean(prefs003.ReadLine());//italics
                        zg1.GraphPane.YAxis.Scale.FontSpec.IsUnderline = Convert.ToBoolean(prefs003.ReadLine());//underline

                        prefs003.ReadLine();//TIC MARKS---
                        zg1.GraphPane.YAxis.MajorTic.IsOpposite = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MajorTic.IsInside = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MajorTic.IsOutside = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MinorTic.IsOpposite = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MinorTic.IsInside = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MinorTic.IsOutside = Convert.ToBoolean(prefs003.ReadLine());

                        prefs003.ReadLine();//Grid Lines---
                        zg1.GraphPane.YAxis.MajorGrid.IsVisible = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MajorGrid.PenWidth = Convert.ToInt32(prefs003.ReadLine());
                        string sMajorGridColor = prefs003.ReadLine();
                        zg1.GraphPane.YAxis.MajorGrid.Color = (System.Drawing.Color)colConvert.ConvertFromString(sMajorGridColor);

                        zg1.GraphPane.YAxis.MinorGrid.IsVisible = Convert.ToBoolean(prefs003.ReadLine());
                        zg1.GraphPane.YAxis.MinorGrid.PenWidth = Convert.ToInt32(prefs003.ReadLine());
                        string sMinorGridColor = prefs003.ReadLine();
                        zg1.GraphPane.YAxis.MinorGrid.Color = (System.Drawing.Color)colConvert.ConvertFromString(sMinorGridColor);


                        //Clean up and close file
                        prefs003.Close();
                    }

                    else
                    {
                        // Add gridlines to the plot, and make them gray
                        //-------------------------------------------------
                        zg1.GraphPane.YAxis.MajorGrid.IsVisible = true;
                        zg1.GraphPane.YAxis.MinorGrid.IsVisible = false;
                        //zg1.GraphPane.YAxis.MajorGrid.IsVisible = true;
                        //zg1.GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                        zg1.GraphPane.YAxis.MajorGrid.Color = Color.LightGray;
                        //zg1.GraphPane.YAxis.MajorGrid.Color = Color.LightGray;
                        //zg1.GraphPane.Y2Axis.MajorGrid.Color = Color.LightGray;

                    }

                    #endregion

                    #region "PrimaryYAxis"

                    if (File.Exists(sFileSecondaryYAxis))
                    {
                        //Instantiate reader
                        StreamReader prefs004 = new StreamReader(sFileSecondaryYAxis);

                        prefs004.ReadLine();
                        prefs004.ReadLine();//TITLE---

                        zg1.GraphPane.Y2Axis.IsVisible = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.Title.Text = prefs004.ReadLine();
                        zg1.GraphPane.Y2Axis.Title.FontSpec.Family = prefs004.ReadLine();//font
                        zg1.GraphPane.Y2Axis.Title.FontSpec.Size = Convert.ToInt16(prefs004.ReadLine());//size
                        string sY2AxisFontStyle = prefs004.ReadLine();
                        switch (sY2AxisFontStyle)
                        {
                            case "Regular":
                                zg1.GraphPane.Y2Axis.Title.FontSpec.IsBold = false;
                                break;
                            case "Bold":
                                zg1.GraphPane.Y2Axis.Title.FontSpec.IsBold = true;
                                break;
                            default:
                                break;

                        }
                        zg1.GraphPane.Y2Axis.Title.FontSpec.IsItalic = Convert.ToBoolean(prefs004.ReadLine());//italics
                        zg1.GraphPane.Y2Axis.Title.FontSpec.IsUnderline = Convert.ToBoolean(prefs004.ReadLine());//underline

                        prefs004.ReadLine();//SCALE---
                        zg1.GraphPane.Y2Axis.Scale.FontSpec.Family = prefs004.ReadLine();//font
                        zg1.GraphPane.Y2Axis.Scale.FontSpec.Size = Convert.ToInt16(prefs004.ReadLine());//size
                        string sY2AxisScaleFontStyle = prefs004.ReadLine();
                        switch (sY2AxisScaleFontStyle)
                        {
                            case "Regular":
                                zg1.GraphPane.Y2Axis.Scale.FontSpec.IsBold = false;
                                break;
                            case "Bold":
                                zg1.GraphPane.Y2Axis.Scale.FontSpec.IsBold = true;
                                break;
                            default:
                                break;

                        }
                        zg1.GraphPane.Y2Axis.Scale.FontSpec.IsItalic = Convert.ToBoolean(prefs004.ReadLine());//italics
                        zg1.GraphPane.Y2Axis.Scale.FontSpec.IsUnderline = Convert.ToBoolean(prefs004.ReadLine());//underline

                        prefs004.ReadLine();//TIC MARKS---
                        zg1.GraphPane.Y2Axis.MajorTic.IsOpposite = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MajorTic.IsInside = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MajorTic.IsOutside = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MinorTic.IsOpposite = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MinorTic.IsInside = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MinorTic.IsOutside = Convert.ToBoolean(prefs004.ReadLine());

                        prefs004.ReadLine();//Grid Lines---
                        zg1.GraphPane.Y2Axis.MajorGrid.IsVisible = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MajorGrid.PenWidth = Convert.ToInt32(prefs004.ReadLine());
                        string sMajorGridColor = prefs004.ReadLine();
                        zg1.GraphPane.Y2Axis.MajorGrid.Color = (System.Drawing.Color)colConvert.ConvertFromString(sMajorGridColor);

                        zg1.GraphPane.Y2Axis.MinorGrid.IsVisible = Convert.ToBoolean(prefs004.ReadLine());
                        zg1.GraphPane.Y2Axis.MinorGrid.PenWidth = Convert.ToInt32(prefs004.ReadLine());
                        string sMinorGridColor = prefs004.ReadLine();
                        zg1.GraphPane.Y2Axis.MinorGrid.Color = (System.Drawing.Color)colConvert.ConvertFromString(sMinorGridColor);


                        //Clean up and close file
                        prefs004.Close();
                    }

                    else
                    {
                        // Add gridlines to the plot, and make them gray
                        //-------------------------------------------------
                        zg1.GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                        zg1.GraphPane.Y2Axis.MinorGrid.IsVisible = false;
                        //zg1.GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                        //zg1.GraphPane.Y2Axis.MajorGrid.IsVisible = true;
                        zg1.GraphPane.Y2Axis.MajorGrid.Color = Color.LightGray;
                        //zg1.GraphPane.Y2Axis.MajorGrid.Color = Color.LightGray;
                        //zg1.GraphPane.Y2Axis.MajorGrid.Color = Color.LightGray;

                    }

                    #endregion

                    #region "sFileObservedFile1"

                    if (File.Exists(sFileObservedFile1))
                    {
                        //Instantiate reader
                        StreamReader prefs005 = new StreamReader(sFileObservedFile1);

                        prefs005.ReadLine();
                        prefs005.ReadLine();
                        myCurveObs.Line.IsSmooth = Convert.ToBoolean(prefs005.ReadLine());
                        myCurveObs.Line.Width = Convert.ToInt32(prefs005.ReadLine());
                        string sObsLineColor = prefs005.ReadLine();
                        myCurveObs.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sObsLineColor);
                        myCurveObs.Symbol.IsVisible = Convert.ToBoolean(prefs005.ReadLine());
                        myCurveObs.Symbol.Border.Color = Color.Black;
                        myCurveObs.Symbol.Size = Convert.ToInt32(prefs005.ReadLine());
                        string sObsSymbolType= prefs005.ReadLine();
                        if (sObsSymbolType =="Square")
                        {
                            myCurveObs.Symbol.Type = SymbolType.Square;
                        }
                        if (sObsSymbolType =="Triangle")
                        {
                            myCurveObs.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sObsSymbolType =="Circle")
                        {
                            myCurveObs.Symbol.Type = SymbolType.Circle;
                        }

                        prefs005.ReadLine();
                        string sObsBarColor = prefs005.ReadLine();
                        myBarObs.Color = (System.Drawing.Color)colConvert.ConvertFromString(sObsBarColor);

                        //Clean up and close file
                        prefs005.Close();
                    }

                    #endregion

                    #region "sFileObservedFile2"

                    if (File.Exists(sFileObservedFile2))
                    {
                        //Instantiate reader
                        StreamReader prefs006 = new StreamReader(sFileObservedFile2);

                        prefs006.ReadLine();
                        prefs006.ReadLine();
                        myCurveObs2.Line.IsSmooth = Convert.ToBoolean(prefs006.ReadLine());
                        myCurveObs2.Line.Width = Convert.ToInt32(prefs006.ReadLine());
                        string sObs2LineColor = prefs006.ReadLine();
                        myCurveObs2.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sObs2LineColor);
                        myCurveObs2.Symbol.IsVisible = Convert.ToBoolean(prefs006.ReadLine());
                        myCurveObs2.Symbol.Border.Color = Color.Black;
                        myCurveObs2.Symbol.Size = Convert.ToInt32(prefs006.ReadLine());
                        string sObs2SymbolType = prefs006.ReadLine();
                        if (sObs2SymbolType == "Square")
                        {
                            myCurveObs2.Symbol.Type = SymbolType.Square;
                        }
                        if (sObs2SymbolType == "Triangle")
                        {
                            myCurveObs2.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sObs2SymbolType == "Circle")
                        {
                            myCurveObs2.Symbol.Type = SymbolType.Circle;
                        }

                        prefs006.ReadLine();
                        string sObs2BarColor = prefs006.ReadLine();
                        myBarObs2.Color = (System.Drawing.Color)colConvert.ConvertFromString(sObs2BarColor);

                        //Clean up and close file
                        prefs006.Close();
                    }

                    #endregion

                    #region "sFileObservedFile3"

                    if (File.Exists(sFileObservedFile3))
                    {
                        //Instantiate reader
                        StreamReader prefs007 = new StreamReader(sFileObservedFile3);

                        prefs007.ReadLine();
                        prefs007.ReadLine();
                        myCurveObs3.Line.IsSmooth = Convert.ToBoolean(prefs007.ReadLine());
                        myCurveObs3.Line.Width = Convert.ToInt32(prefs007.ReadLine());
                        string sObs3LineColor = prefs007.ReadLine();
                        myCurveObs3.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sObs3LineColor);
                        myCurveObs3.Symbol.IsVisible = Convert.ToBoolean(prefs007.ReadLine());
                        myCurveObs3.Symbol.Border.Color = Color.Black;
                        myCurveObs3.Symbol.Size = Convert.ToInt32(prefs007.ReadLine());
                        string sObs3SymbolType = prefs007.ReadLine();
                        if (sObs3SymbolType == "Square")
                        {
                            myCurveObs3.Symbol.Type = SymbolType.Square;
                        }
                        if (sObs3SymbolType == "Triangle")
                        {
                            myCurveObs3.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sObs3SymbolType == "Circle")
                        {
                            myCurveObs3.Symbol.Type = SymbolType.Circle;
                        }

                        prefs007.ReadLine();
                        string sObs3BarColor = prefs007.ReadLine();
                        myBarObs3.Color = (System.Drawing.Color)colConvert.ConvertFromString(sObs3BarColor);

                        //Clean up and close file
                        prefs007.Close();
                    }

                    #endregion

                    #region "sFileWaterTable"

                    if (File.Exists(sFileWaterTable))
                    {
                        //Instantiate reader
                        StreamReader prefs008 = new StreamReader(sFileWaterTable);

                        prefs008.ReadLine();
                        prefs008.ReadLine();
                        PreWTCurve.Line.IsSmooth = Convert.ToBoolean(prefs008.ReadLine());
                        PreWTCurve.Line.Width = Convert.ToInt32(prefs008.ReadLine());
                        string sPreWTCurveLineColor = prefs008.ReadLine();
                        PreWTCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sPreWTCurveLineColor);
                        PreWTCurve.Symbol.IsVisible = Convert.ToBoolean(prefs008.ReadLine());
                        PreWTCurve.Symbol.Border.Color = Color.Black;
                        PreWTCurve.Symbol.Size = Convert.ToInt32(prefs008.ReadLine());
                        string sPreWTCurveSymbolType = prefs008.ReadLine();
                        if (sPreWTCurveSymbolType == "Square")
                        {
                            PreWTCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sPreWTCurveSymbolType == "Triangle")
                        {
                            PreWTCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sPreWTCurveSymbolType == "Circle")
                        {
                            PreWTCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs008.ReadLine();
                        string sPreWTBarColor = prefs008.ReadLine();
                        PreWTBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sPreWTBarColor);

                        //Clean up and close file
                        prefs008.Close();
                    }

                    #endregion

                    #region "sFileDryZone"

                    if (File.Exists(sFileDryZone))
                    {
                        //Instantiate reader
                        StreamReader prefs009 = new StreamReader(sFileDryZone);

                        prefs009.ReadLine();
                        prefs009.ReadLine();
                        DryZoneCurve.Line.IsSmooth = Convert.ToBoolean(prefs009.ReadLine());
                        DryZoneCurve.Line.Width = Convert.ToInt32(prefs009.ReadLine());
                        string sDryZoneCurveLineColor = prefs009.ReadLine();
                        DryZoneCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDryZoneCurveLineColor);
                        DryZoneCurve.Symbol.IsVisible = Convert.ToBoolean(prefs009.ReadLine());
                        DryZoneCurve.Symbol.Border.Color = Color.Black;
                        DryZoneCurve.Symbol.Size = Convert.ToInt32(prefs009.ReadLine());
                        string sDryZoneCurveSymbolType = prefs009.ReadLine();
                        if (sDryZoneCurveSymbolType == "Square")
                        {
                            DryZoneCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sDryZoneCurveSymbolType == "Triangle")
                        {
                            DryZoneCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sDryZoneCurveSymbolType == "Circle")
                        {
                            DryZoneCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs009.ReadLine();
                        string sDryZoneBarColor = prefs009.ReadLine();
                        DryZoneBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDryZoneBarColor);

                        //Clean up and close file
                        prefs009.Close();
                    }

                    #endregion

                    #region "sFileSurfaceStorage"

                    if (File.Exists(sFileSurfaceStorage))
                    {
                        //Instantiate reader
                        StreamReader prefs010 = new StreamReader(sFileSurfaceStorage);

                        prefs010.ReadLine();
                        prefs010.ReadLine();
                        SurfaceStorageCurve.Line.IsSmooth = Convert.ToBoolean(prefs010.ReadLine());
                        SurfaceStorageCurve.Line.Width = Convert.ToInt32(prefs010.ReadLine());
                        string sSurfaceStorageCurveLineColor = prefs010.ReadLine();
                        SurfaceStorageCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sSurfaceStorageCurveLineColor);
                        SurfaceStorageCurve.Symbol.IsVisible = Convert.ToBoolean(prefs010.ReadLine());
                        SurfaceStorageCurve.Symbol.Border.Color = Color.Black;
                        SurfaceStorageCurve.Symbol.Size = Convert.ToInt32(prefs010.ReadLine());
                        string sSurfaceStorageCurveSymbolType = prefs010.ReadLine();
                        if (sSurfaceStorageCurveSymbolType == "Square")
                        {
                            SurfaceStorageCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sSurfaceStorageCurveSymbolType == "Triangle")
                        {
                            SurfaceStorageCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sSurfaceStorageCurveSymbolType == "Circle")
                        {
                            SurfaceStorageCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs010.ReadLine();
                        string sSurfaceStorageBarColor = prefs010.ReadLine();
                        SurfaceStorageBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sSurfaceStorageBarColor);

                        //Clean up and close file
                        prefs010.Close();
                    }

                    #endregion

                    #region "sFileDrainage"

                    if (File.Exists(sFileDrainage))
                    {
                        //Instantiate reader
                        StreamReader prefs011 = new StreamReader(sFileDrainage);

                        prefs011.ReadLine();
                        prefs011.ReadLine();
                        bool bDrainageCurve = Convert.ToBoolean(prefs011.ReadLine());
                        DrainageCurve.Line.IsSmooth = bDrainageCurve;
                        MonthlyDrainageCurve.Line.IsSmooth = bDrainageCurve;
                        YearlyDrainageCurve.Line.IsSmooth = bDrainageCurve;
                        CumulativeDrainageCurve.Line.IsSmooth = bDrainageCurve;

                        int iDrainageCurveWidth = Convert.ToInt32(prefs011.ReadLine());
                        DrainageCurve.Line.Width = iDrainageCurveWidth;
                        MonthlyDrainageCurve.Line.Width = iDrainageCurveWidth;
                        YearlyDrainageCurve.Line.Width = iDrainageCurveWidth;
                        CumulativeDrainageCurve.Line.Width = iDrainageCurveWidth;

                        string sDrainageCurveLineColor = prefs011.ReadLine();
                        DrainageCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageCurveLineColor);
                        MonthlyDrainageCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageCurveLineColor);
                        YearlyDrainageCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageCurveLineColor);
                        CumulativeDrainageCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageCurveLineColor);

                        bool bDrainageCurveIsVisisble = Convert.ToBoolean(prefs011.ReadLine());
                        DrainageCurve.Symbol.IsVisible = bDrainageCurveIsVisisble;
                        MonthlyDrainageCurve.Symbol.IsVisible = bDrainageCurveIsVisisble;
                        YearlyDrainageCurve.Symbol.IsVisible = bDrainageCurveIsVisisble;
                        CumulativeDrainageCurve.Symbol.IsVisible = bDrainageCurveIsVisisble;

                        DrainageCurve.Symbol.Border.Color = Color.Black;
                        MonthlyDrainageCurve.Symbol.Border.Color = Color.Black;
                        YearlyDrainageCurve.Symbol.Border.Color = Color.Black;
                        CumulativeDrainageCurve.Symbol.Border.Color = Color.Black;

                        int DrainageCurveSymbolSize = Convert.ToInt32(prefs011.ReadLine());
                        DrainageCurve.Symbol.Size = DrainageCurveSymbolSize;
                        MonthlyDrainageCurve.Symbol.Size = DrainageCurveSymbolSize;
                        YearlyDrainageCurve.Symbol.Size = DrainageCurveSymbolSize;
                        CumulativeDrainageCurve.Symbol.Size = DrainageCurveSymbolSize;

                        string sDrainageCurveSymbolType = prefs011.ReadLine();
                        if (sDrainageCurveSymbolType == "Square")
                        {
                            DrainageCurve.Symbol.Type = SymbolType.Square;
                            MonthlyDrainageCurve.Symbol.Type = SymbolType.Square;
                            YearlyDrainageCurve.Symbol.Type = SymbolType.Square;
                            CumulativeDrainageCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sDrainageCurveSymbolType == "Triangle")
                        {
                            DrainageCurve.Symbol.Type = SymbolType.Triangle;
                            MonthlyDrainageCurve.Symbol.Type = SymbolType.Triangle;
                            YearlyDrainageCurve.Symbol.Type = SymbolType.Triangle;
                            CumulativeDrainageCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sDrainageCurveSymbolType == "Circle")
                        {
                            DrainageCurve.Symbol.Type = SymbolType.Circle;
                            MonthlyDrainageCurve.Symbol.Type = SymbolType.Circle;
                            YearlyDrainageCurve.Symbol.Type = SymbolType.Circle;
                            CumulativeDrainageCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs011.ReadLine();
                        string sDrainageBarColor = prefs011.ReadLine();
                        DrainageBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageBarColor);
                        MonthlyDrainageBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageBarColor);
                        YearlyDrainageBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageBarColor);
                        CumulativeDrainageBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sDrainageBarColor);

                        //Clean up and close file
                        prefs011.Close();
                    }

                    #endregion

                    #region "sFileEvaporation"

                    if (File.Exists(sFileEvaporation))
                    {
                        //Instantiate reader
                        StreamReader prefs012 = new StreamReader(sFileEvaporation);

                        prefs012.ReadLine();
                        prefs012.ReadLine();
                        bool bAETCurve = Convert.ToBoolean(prefs012.ReadLine());
                        AETCurve.Line.IsSmooth = bAETCurve;
                        MonthlyAETCurve.Line.IsSmooth = bAETCurve;
                        YearlyAETCurve.Line.IsSmooth = bAETCurve;
                        CumulativeAETCurve.Line.IsSmooth = bAETCurve;

                        int iAETCurveWidth = Convert.ToInt32(prefs012.ReadLine());
                        AETCurve.Line.Width = iAETCurveWidth;
                        MonthlyAETCurve.Line.Width = iAETCurveWidth;
                        YearlyAETCurve.Line.Width = iAETCurveWidth;
                        CumulativeAETCurve.Line.Width = iAETCurveWidth;

                        string sAETCurveLineColor = prefs012.ReadLine();
                        AETCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETCurveLineColor);
                        MonthlyAETCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETCurveLineColor);
                        YearlyAETCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETCurveLineColor);
                        CumulativeAETCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETCurveLineColor);

                        bool bAETCurveIsVisisble = Convert.ToBoolean(prefs012.ReadLine());
                        AETCurve.Symbol.IsVisible = bAETCurveIsVisisble;
                        MonthlyAETCurve.Symbol.IsVisible = bAETCurveIsVisisble;
                        YearlyAETCurve.Symbol.IsVisible = bAETCurveIsVisisble;
                        CumulativeAETCurve.Symbol.IsVisible = bAETCurveIsVisisble;

                        AETCurve.Symbol.Border.Color = Color.Black;
                        MonthlyAETCurve.Symbol.Border.Color = Color.Black;
                        YearlyAETCurve.Symbol.Border.Color = Color.Black;
                        CumulativeAETCurve.Symbol.Border.Color = Color.Black;

                        int AETCurveSymbolSize = Convert.ToInt32(prefs012.ReadLine());
                        AETCurve.Symbol.Size = AETCurveSymbolSize;
                        MonthlyAETCurve.Symbol.Size = AETCurveSymbolSize;
                        YearlyAETCurve.Symbol.Size = AETCurveSymbolSize;
                        CumulativeAETCurve.Symbol.Size = AETCurveSymbolSize;

                        string sAETCurveSymbolType = prefs012.ReadLine();
                        if (sAETCurveSymbolType == "Square")
                        {
                            AETCurve.Symbol.Type = SymbolType.Square;
                            MonthlyAETCurve.Symbol.Type = SymbolType.Square;
                            YearlyAETCurve.Symbol.Type = SymbolType.Square;
                            CumulativeAETCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sAETCurveSymbolType == "Triangle")
                        {
                            AETCurve.Symbol.Type = SymbolType.Triangle;
                            MonthlyAETCurve.Symbol.Type = SymbolType.Triangle;
                            YearlyAETCurve.Symbol.Type = SymbolType.Triangle;
                            CumulativeAETCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sAETCurveSymbolType == "Circle")
                        {
                            AETCurve.Symbol.Type = SymbolType.Circle;
                            MonthlyAETCurve.Symbol.Type = SymbolType.Circle;
                            YearlyAETCurve.Symbol.Type = SymbolType.Circle;
                            CumulativeAETCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs012.ReadLine();
                        string sAETBarColor = prefs012.ReadLine();
                        AETBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETBarColor);
                        MonthlyAETBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETBarColor);
                        YearlyAETBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETBarColor);
                        CumulativeAETBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sAETBarColor);

                        //Clean up and close file
                        prefs012.Close();
                    }

                    #endregion

                    #region "sFileInfiltration"

                    if (File.Exists(sFileInfiltration))
                    {
                        //Instantiate reader
                        StreamReader prefs013 = new StreamReader(sFileInfiltration);

                        prefs013.ReadLine();
                        prefs013.ReadLine();
                        bool bInfiltrationCurve = Convert.ToBoolean(prefs013.ReadLine());
                        InfiltrationCurve.Line.IsSmooth = bInfiltrationCurve;
                        MonthlyInfiltrationCurve.Line.IsSmooth = bInfiltrationCurve;
                        YearlyInfiltrationCurve.Line.IsSmooth = bInfiltrationCurve;
                        CumulativeInfiltrationCurve.Line.IsSmooth = bInfiltrationCurve;

                        int iInfiltrationCurveWidth = Convert.ToInt32(prefs013.ReadLine());
                        InfiltrationCurve.Line.Width = iInfiltrationCurveWidth;
                        MonthlyInfiltrationCurve.Line.Width = iInfiltrationCurveWidth;
                        YearlyInfiltrationCurve.Line.Width = iInfiltrationCurveWidth;
                        CumulativeInfiltrationCurve.Line.Width = iInfiltrationCurveWidth;

                        string sInfiltrationCurveLineColor = prefs013.ReadLine();
                        InfiltrationCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationCurveLineColor);
                        MonthlyInfiltrationCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationCurveLineColor);
                        YearlyInfiltrationCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationCurveLineColor);
                        CumulativeInfiltrationCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationCurveLineColor);

                        bool bInfiltrationCurveIsVisisble = Convert.ToBoolean(prefs013.ReadLine());
                        InfiltrationCurve.Symbol.IsVisible = bInfiltrationCurveIsVisisble;
                        MonthlyInfiltrationCurve.Symbol.IsVisible = bInfiltrationCurveIsVisisble;
                        YearlyInfiltrationCurve.Symbol.IsVisible = bInfiltrationCurveIsVisisble;
                        CumulativeInfiltrationCurve.Symbol.IsVisible = bInfiltrationCurveIsVisisble;

                        InfiltrationCurve.Symbol.Border.Color = Color.Black;
                        MonthlyInfiltrationCurve.Symbol.Border.Color = Color.Black;
                        YearlyInfiltrationCurve.Symbol.Border.Color = Color.Black;
                        CumulativeInfiltrationCurve.Symbol.Border.Color = Color.Black;

                        int InfiltrationCurveSymbolSize = Convert.ToInt32(prefs013.ReadLine());
                        InfiltrationCurve.Symbol.Size = InfiltrationCurveSymbolSize;
                        MonthlyInfiltrationCurve.Symbol.Size = InfiltrationCurveSymbolSize;
                        YearlyInfiltrationCurve.Symbol.Size = InfiltrationCurveSymbolSize;
                        CumulativeInfiltrationCurve.Symbol.Size = InfiltrationCurveSymbolSize;

                        string sInfiltrationCurveSymbolType = prefs013.ReadLine();
                        if (sInfiltrationCurveSymbolType == "Square")
                        {
                            InfiltrationCurve.Symbol.Type = SymbolType.Square;
                            MonthlyInfiltrationCurve.Symbol.Type = SymbolType.Square;
                            YearlyInfiltrationCurve.Symbol.Type = SymbolType.Square;
                            CumulativeInfiltrationCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sInfiltrationCurveSymbolType == "Triangle")
                        {
                            InfiltrationCurve.Symbol.Type = SymbolType.Triangle;
                            MonthlyInfiltrationCurve.Symbol.Type = SymbolType.Triangle;
                            YearlyInfiltrationCurve.Symbol.Type = SymbolType.Triangle;
                            CumulativeInfiltrationCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sInfiltrationCurveSymbolType == "Circle")
                        {
                            InfiltrationCurve.Symbol.Type = SymbolType.Circle;
                            MonthlyInfiltrationCurve.Symbol.Type = SymbolType.Circle;
                            YearlyInfiltrationCurve.Symbol.Type = SymbolType.Circle;
                            CumulativeInfiltrationCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs013.ReadLine();
                        string sInfiltrationBarColor = prefs013.ReadLine();
                        InfiltrationBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationBarColor);
                        MonthlyInfiltrationBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationBarColor);
                        YearlyInfiltrationBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationBarColor);
                        CumulativeInfiltrationBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sInfiltrationBarColor);

                        //Clean up and close file
                        prefs013.Close();
                    }

                    #endregion

                    #region "sFileSurfaceRunoff"

                    if (File.Exists(sFileSurfaceRunoff))
                    {
                        //Instantiate reader
                        StreamReader prefs014 = new StreamReader(sFileSurfaceRunoff);

                        prefs014.ReadLine();
                        prefs014.ReadLine();
                        bool bRunoffCurve = Convert.ToBoolean(prefs014.ReadLine());
                        RunoffCurve.Line.IsSmooth = bRunoffCurve;
                        MonthlyRunoffCurve.Line.IsSmooth = bRunoffCurve;
                        YearlyRunoffCurve.Line.IsSmooth = bRunoffCurve;
                        CumulativeRunoffCurve.Line.IsSmooth = bRunoffCurve;

                        int iRunoffCurveWidth = Convert.ToInt32(prefs014.ReadLine());
                        RunoffCurve.Line.Width = iRunoffCurveWidth;
                        MonthlyRunoffCurve.Line.Width = iRunoffCurveWidth;
                        YearlyRunoffCurve.Line.Width = iRunoffCurveWidth;
                        CumulativeRunoffCurve.Line.Width = iRunoffCurveWidth;

                        string sRunoffCurveLineColor = prefs014.ReadLine();
                        RunoffCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffCurveLineColor);
                        MonthlyRunoffCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffCurveLineColor);
                        YearlyRunoffCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffCurveLineColor);
                        CumulativeRunoffCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffCurveLineColor);

                        bool bRunoffCurveIsVisisble = Convert.ToBoolean(prefs014.ReadLine());
                        RunoffCurve.Symbol.IsVisible = bRunoffCurveIsVisisble;
                        MonthlyRunoffCurve.Symbol.IsVisible = bRunoffCurveIsVisisble;
                        YearlyRunoffCurve.Symbol.IsVisible = bRunoffCurveIsVisisble;
                        CumulativeRunoffCurve.Symbol.IsVisible = bRunoffCurveIsVisisble;

                        RunoffCurve.Symbol.Border.Color = Color.Black;
                        MonthlyRunoffCurve.Symbol.Border.Color = Color.Black;
                        YearlyRunoffCurve.Symbol.Border.Color = Color.Black;
                        CumulativeRunoffCurve.Symbol.Border.Color = Color.Black;

                        int RunoffCurveSymbolSize = Convert.ToInt32(prefs014.ReadLine());
                        RunoffCurve.Symbol.Size = RunoffCurveSymbolSize;
                        MonthlyRunoffCurve.Symbol.Size = RunoffCurveSymbolSize;
                        YearlyRunoffCurve.Symbol.Size = RunoffCurveSymbolSize;
                        CumulativeRunoffCurve.Symbol.Size = RunoffCurveSymbolSize;

                        string sRunoffCurveSymbolType = prefs014.ReadLine();
                        if (sRunoffCurveSymbolType == "Square")
                        {
                            RunoffCurve.Symbol.Type = SymbolType.Square;
                            MonthlyRunoffCurve.Symbol.Type = SymbolType.Square;
                            YearlyRunoffCurve.Symbol.Type = SymbolType.Square;
                            CumulativeRunoffCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sRunoffCurveSymbolType == "Triangle")
                        {
                            RunoffCurve.Symbol.Type = SymbolType.Triangle;
                            MonthlyRunoffCurve.Symbol.Type = SymbolType.Triangle;
                            YearlyRunoffCurve.Symbol.Type = SymbolType.Triangle;
                            CumulativeRunoffCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sRunoffCurveSymbolType == "Circle")
                        {
                            RunoffCurve.Symbol.Type = SymbolType.Circle;
                            MonthlyRunoffCurve.Symbol.Type = SymbolType.Circle;
                            YearlyRunoffCurve.Symbol.Type = SymbolType.Circle;
                            CumulativeRunoffCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs014.ReadLine();
                        string sRunoffBarColor = prefs014.ReadLine();
                        RunoffBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffBarColor);
                        MonthlyRunoffBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffBarColor);
                        YearlyRunoffBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffBarColor);
                        CumulativeRunoffBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRunoffBarColor);

                        //Clean up and close file
                        prefs014.Close();
                    }

                    #endregion

                    #region "sFileRainfall"

                    if (File.Exists(sFileRainfall))
                    {
                        //Instantiate reader
                        StreamReader prefs015 = new StreamReader(sFileRainfall);

                        prefs015.ReadLine();
                        prefs015.ReadLine();
                        bool bRainfallCurve = Convert.ToBoolean(prefs015.ReadLine());
                        RainfallCurve.Line.IsSmooth = bRainfallCurve;
                        MonthlyRainfallCurve.Line.IsSmooth = bRainfallCurve;
                        YearlyRainfallCurve.Line.IsSmooth = bRainfallCurve;
                        CumulativeRainfallCurve.Line.IsSmooth = bRainfallCurve;

                        int iRainfallCurveWidth = Convert.ToInt32(prefs015.ReadLine());
                        RainfallCurve.Line.Width = iRainfallCurveWidth;
                        MonthlyRainfallCurve.Line.Width = iRainfallCurveWidth;
                        YearlyRainfallCurve.Line.Width = iRainfallCurveWidth;
                        CumulativeRainfallCurve.Line.Width = iRainfallCurveWidth;

                        string sRainfallCurveLineColor = prefs015.ReadLine();
                        RainfallCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallCurveLineColor);
                        MonthlyRainfallCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallCurveLineColor);
                        YearlyRainfallCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallCurveLineColor);
                        CumulativeRainfallCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallCurveLineColor);

                        bool bRainfallCurveIsVisisble = Convert.ToBoolean(prefs015.ReadLine());
                        RainfallCurve.Symbol.IsVisible = bRainfallCurveIsVisisble;
                        MonthlyRainfallCurve.Symbol.IsVisible = bRainfallCurveIsVisisble;
                        YearlyRainfallCurve.Symbol.IsVisible = bRainfallCurveIsVisisble;
                        CumulativeRainfallCurve.Symbol.IsVisible = bRainfallCurveIsVisisble;

                        RainfallCurve.Symbol.Border.Color = Color.Black;
                        MonthlyRainfallCurve.Symbol.Border.Color = Color.Black;
                        YearlyRainfallCurve.Symbol.Border.Color = Color.Black;
                        CumulativeRainfallCurve.Symbol.Border.Color = Color.Black;

                        int RainfallCurveSymbolSize = Convert.ToInt32(prefs015.ReadLine());
                        RainfallCurve.Symbol.Size = RainfallCurveSymbolSize;
                        MonthlyRainfallCurve.Symbol.Size = RainfallCurveSymbolSize;
                        YearlyRainfallCurve.Symbol.Size = RainfallCurveSymbolSize;
                        CumulativeRainfallCurve.Symbol.Size = RainfallCurveSymbolSize;

                        string sRainfallCurveSymbolType = prefs015.ReadLine();
                        if (sRainfallCurveSymbolType == "Square")
                        {
                            RainfallCurve.Symbol.Type = SymbolType.Square;
                            MonthlyRainfallCurve.Symbol.Type = SymbolType.Square;
                            YearlyRainfallCurve.Symbol.Type = SymbolType.Square;
                            CumulativeRainfallCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sRainfallCurveSymbolType == "Triangle")
                        {
                            RainfallCurve.Symbol.Type = SymbolType.Triangle;
                            MonthlyRainfallCurve.Symbol.Type = SymbolType.Triangle;
                            YearlyRainfallCurve.Symbol.Type = SymbolType.Triangle;
                            CumulativeRainfallCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sRainfallCurveSymbolType == "Circle")
                        {
                            RainfallCurve.Symbol.Type = SymbolType.Circle;
                            MonthlyRainfallCurve.Symbol.Type = SymbolType.Circle;
                            YearlyRainfallCurve.Symbol.Type = SymbolType.Circle;
                            CumulativeRainfallCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs015.ReadLine();
                        string sRainfallBarColor = prefs015.ReadLine();
                        RainfallBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallBarColor);
                        MonthlyRainfallBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallBarColor);
                        YearlyRainfallBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallBarColor);
                        CumulativeRainfallBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sRainfallBarColor);

                        //Clean up and close file
                        prefs015.Close();
                    }

                    #endregion

                    #region "sFileWaterLoss"

                    if (File.Exists(sFileWaterLoss))
                    {
                        //Instantiate reader
                        StreamReader prefs016 = new StreamReader(sFileWaterLoss);

                        prefs016.ReadLine();
                        prefs016.ReadLine();
                        bool bWaterLossCurve = Convert.ToBoolean(prefs016.ReadLine());
                        WaterLossCurve.Line.IsSmooth = bWaterLossCurve;
                        MonthlyWaterLossCurve.Line.IsSmooth = bWaterLossCurve;
                        YearlyWaterLossCurve.Line.IsSmooth = bWaterLossCurve;
                        CumulativeWaterLossCurve.Line.IsSmooth = bWaterLossCurve;

                        int iWaterLossCurveWidth = Convert.ToInt32(prefs016.ReadLine());
                        WaterLossCurve.Line.Width = iWaterLossCurveWidth;
                        MonthlyWaterLossCurve.Line.Width = iWaterLossCurveWidth;
                        YearlyWaterLossCurve.Line.Width = iWaterLossCurveWidth;
                        CumulativeWaterLossCurve.Line.Width = iWaterLossCurveWidth;

                        string sWaterLossCurveLineColor = prefs016.ReadLine();
                        WaterLossCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossCurveLineColor);
                        MonthlyWaterLossCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossCurveLineColor);
                        YearlyWaterLossCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossCurveLineColor);
                        CumulativeWaterLossCurve.Line.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossCurveLineColor);

                        bool bWaterLossCurveIsVisisble = Convert.ToBoolean(prefs016.ReadLine());
                        WaterLossCurve.Symbol.IsVisible = bWaterLossCurveIsVisisble;
                        MonthlyWaterLossCurve.Symbol.IsVisible = bWaterLossCurveIsVisisble;
                        YearlyWaterLossCurve.Symbol.IsVisible = bWaterLossCurveIsVisisble;
                        CumulativeWaterLossCurve.Symbol.IsVisible = bWaterLossCurveIsVisisble;

                        WaterLossCurve.Symbol.Border.Color = Color.Black;
                        MonthlyWaterLossCurve.Symbol.Border.Color = Color.Black;
                        YearlyWaterLossCurve.Symbol.Border.Color = Color.Black;
                        CumulativeWaterLossCurve.Symbol.Border.Color = Color.Black;

                        int WaterLossCurveSymbolSize = Convert.ToInt32(prefs016.ReadLine());
                        WaterLossCurve.Symbol.Size = WaterLossCurveSymbolSize;
                        MonthlyWaterLossCurve.Symbol.Size = WaterLossCurveSymbolSize;
                        YearlyWaterLossCurve.Symbol.Size = WaterLossCurveSymbolSize;
                        CumulativeWaterLossCurve.Symbol.Size = WaterLossCurveSymbolSize;

                        string sWaterLossCurveSymbolType = prefs016.ReadLine();
                        if (sWaterLossCurveSymbolType == "Square")
                        {
                            WaterLossCurve.Symbol.Type = SymbolType.Square;
                            MonthlyWaterLossCurve.Symbol.Type = SymbolType.Square;
                            YearlyWaterLossCurve.Symbol.Type = SymbolType.Square;
                            CumulativeWaterLossCurve.Symbol.Type = SymbolType.Square;
                        }
                        if (sWaterLossCurveSymbolType == "Triangle")
                        {
                            WaterLossCurve.Symbol.Type = SymbolType.Triangle;
                            MonthlyWaterLossCurve.Symbol.Type = SymbolType.Triangle;
                            YearlyWaterLossCurve.Symbol.Type = SymbolType.Triangle;
                            CumulativeWaterLossCurve.Symbol.Type = SymbolType.Triangle;
                        }
                        if (sWaterLossCurveSymbolType == "Circle")
                        {
                            WaterLossCurve.Symbol.Type = SymbolType.Circle;
                            MonthlyWaterLossCurve.Symbol.Type = SymbolType.Circle;
                            YearlyWaterLossCurve.Symbol.Type = SymbolType.Circle;
                            CumulativeWaterLossCurve.Symbol.Type = SymbolType.Circle;
                        }

                        prefs016.ReadLine();
                        string sWaterLossBarColor = prefs016.ReadLine();
                        WaterLossBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossBarColor);
                        MonthlyWaterLossBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossBarColor);
                        YearlyWaterLossBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossBarColor);
                        CumulativeWaterLossBar.Color = (System.Drawing.Color)colConvert.ConvertFromString(sWaterLossBarColor);

                        //Clean up and close file
                        prefs016.Close();
                    }

                    #endregion


                    //Observed 1
                    //Observed 2
                    //Observed 3
                    //Water Table
                    //Dry Zone
                    //Surface Storage
                    //Rainfall
                    //Infiltration
                    //Evaporation
                    //Drainage
                    //Runoff
                    //Water Loss

                }

            }//Close Method

            #endregion



            #region "CSV Exporting"

            #region "ShowSaveAsForExportCSV Class"

            private void ShowSaveAsForExportCSV(object sender, System.EventArgs e)
            {
                try
                {
                    //show saveAs CmdDlg
                    saveFileDialog1.Filter = "CSV files (*.csv)|*.csv";
                    saveFileDialog1.ShowDialog();
                    m_CSVWriter = new StreamWriter(saveFileDialog1.FileName);
                    WriteCSVToStream();
                    m_CSVWriter.Close();
                    MessageBox.Show("CSV File Saved", " ZedGraph ", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    m_CSVWriter.Close();
                    MessageBox.Show(ex.ToString());
                }
            }

            #endregion


            #region "WriteCSVToStream Class"
            private void WriteCSVToStream()
            {
                //First line is for Headers., X and Y Axis
                string _xAxisHeader = CheckCSVString(zg1.GraphPane.XAxis.Title.Text);
                string _yAxisHeader = CheckCSVString(zg1.GraphPane.YAxis.Title.Text);
                m_CSVWriter.Write(_xAxisHeader + "," + _yAxisHeader + "\n");

                //subsequent lines are having data
                for (int i = 0; i < PreWTList.Count; i++)
                {
                    m_CSVWriter.Write(PreWTList[i].X + "," + PreWTList[i].Y + "\n");
                }
            }
            #endregion


            #region "CheckCSVString Class"
            private string CheckCSVString(string _string)
            {//Check to see if there are any characters that can disturb the CSV delimeters.
                string _returnString = _string;
                if (_string.IndexOfAny("\",\x0A\x0D".ToCharArray()) > -1)
                {
                    _returnString = "\"" + _string.Replace("\"", "\"\"") + "\"";
                }
                return _returnString;
            }

            #endregion


            #region "MID Class"

            public static string Mid(string param, int startIndex, int length)
            {

                //start at the specified index in the string ang get N number of

                //characters depending on the lenght and assign it to a variable

                string result = param.Substring(startIndex, length);

                //return the result of the operation

                return result;

            }

            #endregion



            #endregion


            #region "Reload Graph Data from New DRAINMOD Run"

            private void reloadDataToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            #endregion

            private void clearTestToolStripMenuItem_Click(object sender, EventArgs e)
            {

                zg1.GraphPane.CurveList.Clear();
                zg1.GraphPane.GraphObjList.Clear();

                // Force a redraw
                zg1.Invalidate();

            }

        private void methodMajorLoad()
        {

            #region "Trial
            // Instantiate data points lists
            PreWTList = new PointPairList();
            DryZoneList = new PointPairList();
            RainfallList = new PointPairList();
            InfiltrationList = new PointPairList();
            PETList = new PointPairList();
            AETList = new PointPairList();
            DrainageList = new PointPairList();
            RunoffList = new PointPairList();
            WaterLossList = new PointPairList();
            SurfaceStorageList = new PointPairList();
            //Yearly
            //YearlyPreWTList = new PointPairList();
            //YearlyDryZoneList = new PointPairList();
            YearlyRainfallList = new PointPairList();
            YearlyInfiltrationList = new PointPairList();
            //YearlyPETList = new PointPairList();
            YearlyAETList = new PointPairList();
            YearlyDrainageList = new PointPairList();
            YearlyRunoffList = new PointPairList();
            YearlyWaterLossList = new PointPairList();
            //YearlySurfaceStorageList = new PointPairList();
            //Monthly
            //MonthlyPreWTList = new PointPairList();
            //MonthlyDryZoneList = new PointPairList();
            MonthlyRainfallList = new PointPairList();
            MonthlyInfiltrationList = new PointPairList();
            //MonthlyPETList = new PointPairList();
            MonthlyAETList = new PointPairList();
            MonthlyDrainageList = new PointPairList();
            MonthlyRunoffList = new PointPairList();
            MonthlyWaterLossList = new PointPairList();
            //MonthlySurfaceStorageList = new PointPairList();
            //Cumulative
            //CumulativePreWTList = new PointPairList();
            //CumulativeDryZoneList = new PointPairList();
            CumulativeRainfallList = new PointPairList();
            CumulativeInfiltrationList = new PointPairList();
            //CumulativePETList = new PointPairList();
            CumulativeAETList = new PointPairList();
            CumulativeDrainageList = new PointPairList();
            CumulativeRunoffList = new PointPairList();
            CumulativeWaterLossList = new PointPairList();
            //CumulativeSurfaceStorageList = new PointPairList();

            #endregion


            #region "Read in data and create lists"

            //*****************************************************************
            //*****************************************************************
            //READING IN DATA

            //Thread.Sleep(2000);
                   
            //Open C:/Info.dat file. This file has full path to raw data files
            StreamReader InfoDat = new StreamReader("C:/DM_Info.dat");
            string sGrdPath = InfoDat.ReadLine();
            string sGrmPath = InfoDat.ReadLine();
            string sGryPath = InfoDat.ReadLine();
            InfoDat.Close();
            
            //1.Read in Daily Data
            // Open the GRD file

            StreamReader inFile = new StreamReader(sGrdPath);

            //Parameters in GRD file, in order, are as follows
            //Year
            //Month
            //Date
            //Rainfall
            //Infiltration
            //AET
            //Drainage
            //Runoff
            //Water Loss
            //Water Table Depth
            //Dry Zone Depth
            //Surface Storage

            //Initialize Leap Year Boolean
            bool leapYear = false;

            //Initialize Cumulative Variables
            double yYear = 0;
            double cRainfall = 0;
            double cInfiltration = 0;
            double cAET = 0;
            double cDrainage = 0;
            double cRunoff = 0;
            double cWaterLoss = 0;


            //Initialize Dates of GRD File
            int iYear = 0;
            int iMonth = 0;
            int iDay = 0;
            iStartGRHYear = 0;
            iStartGRHMonth = 0;
            iStartGRHDay = 0;
            iEndGRHYear = 0;
            iEndGRHMonth = 0;
            iEndGRHDay = 0;

            // Use the comma character to separate GRH items
            char[] sep = { ',' };

            string line;

            // Read one line of data at a time until the end of file
            while ((line = inFile.ReadLine()) != null)
            {
                // Convert each line in to an array of strings
                //Each loop through overwrites previous array
                //Split the items on the line using the , character as delimiter (declared above)
                string[] items = line.Split(sep);
                // If there's less than 2 items, throw an exception
                if (items.Length < 2)
                    throw new Exception("Error: Not enough data points to plot");

                //Declare Variables in GRH file
                double dYear, dMonth, dDay, dRainfall, dInfiltration, dAET, dDrainage;
                double dRunoff, dWaterLoss, dPreWT;
                double dDryZoneDepth, dSurfaceStorage;


                // If the value is missing mark it so. Otherwise, parse it as a double
                if (items[0].Length == 0)
                    dYear = PointPair.Missing;
                else
                    dYear = Double.Parse(items[0]);

                if (items[1].Length == 0)
                    dMonth = PointPair.Missing;
                else
                    dMonth = Double.Parse(items[1]);

                if (items[2].Length == 0)
                    dDay = PointPair.Missing;
                else
                    dDay = Double.Parse(items[2]);

                if (items[3].Length == 0)
                    dRainfall = PointPair.Missing;
                else
                    dRainfall = Double.Parse(items[3]);

                if (items[4].Length == 0)
                    dInfiltration = PointPair.Missing;
                else
                    dInfiltration = Double.Parse(items[4]);
                
                if (items[5].Length == 0)
                    dAET = PointPair.Missing;
                else
                    dAET = Double.Parse(items[5]);

                if (items[6].Length == 0)
                    dDrainage = PointPair.Missing;
                else
                    dDrainage = Double.Parse(items[6]);

                if (items[7].Length == 0)
                    dRunoff = PointPair.Missing;
                else
                    dRunoff = Double.Parse(items[7]);

                if (items[8].Length == 0)
                    dWaterLoss = PointPair.Missing;
                else
                    dWaterLoss = Double.Parse(items[8]);

                if (items[9].Length == 0)
                    dPreWT = PointPair.Missing;
                else
                    dPreWT = Double.Parse(items[9]);

                if (items[10].Length == 0)
                    dDryZoneDepth = PointPair.Missing;
                else
                    dDryZoneDepth = Double.Parse(items[10]);

                if (items[11].Length == 0)
                    dSurfaceStorage = PointPair.Missing;
                else
                    dSurfaceStorage = Double.Parse(items[11]);


                //Convert Date to XDate Format for graphing
                //First convert double to integers
                iYear = Convert.ToInt32(dYear);
                iMonth = Convert.ToInt32(dMonth);
                iDay = Convert.ToInt32(dDay);

                //Check for Leap Year
                //http://www.dotnetspider.com/resources/17593-How-Check-Leap-Year-using-C.aspx
                leapYear = (((iYear % 4) == 0) && ((iYear % 100) != 0) || ((iYear % 400) == 0));

                //Then do Zedgraph XDate
                XDate myXDate = new XDate(iYear, iMonth, iDay);
                Double dDate = myXDate;
                //XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                //Double dDateMonth = myXDateMonth;
                //double dYearlyYear = dYear;

                //Add Daily Values to Daily Lists
                PreWTList.Add(dDate, dPreWT);
                DryZoneList.Add(dDate, dDryZoneDepth);
                RainfallList.Add(dDate, dRainfall);
                InfiltrationList.Add(dDate, dInfiltration);
                AETList.Add(dDate, dAET);
                DrainageList.Add(dDate, dDrainage);
                RunoffList.Add(dDate, dRunoff);
                WaterLossList.Add(dDate, dWaterLoss);
                SurfaceStorageList.Add(dDate, dSurfaceStorage);
              


                //Get starting date of file
                //if (yYear == 0)
                //{
                //    iStartGRHYear = iYear;
                //    iStartGRHMonth = iMonth;
                //    iStartGRHDay = iDay;
                //}

                
                if (yYear == 0)
                {

                    cRainfall = dRainfall;
                    cInfiltration = dInfiltration;
                    cAET = dAET;
                    cDrainage = dDrainage;
                    cRunoff = dRunoff;
                    cWaterLoss = dWaterLoss;

                }

                if (yYear == iYear)
                {
                    cRainfall = cRainfall + dRainfall;
                    cInfiltration = cInfiltration + dInfiltration;
                    cAET = cAET + dAET;
                    cDrainage = cDrainage + dDrainage;
                    cRunoff = cRunoff + dRunoff;
                    cWaterLoss = cWaterLoss + dWaterLoss;

                }


                if (iMonth == 1 && iDay == 1)
                {
                    cRainfall = dRainfall;
                    cInfiltration = dInfiltration;
                    cAET = dAET;
                    cDrainage = dDrainage;
                    cRunoff = dRunoff;
                    cWaterLoss = dWaterLoss;

                }
               

                CumulativeRainfallList.Add(dDate, cRainfall);
                CumulativeInfiltrationList.Add(dDate, cInfiltration);
                CumulativeAETList.Add(dDate, cAET);
                CumulativeDrainageList.Add(dDate, cDrainage);
                CumulativeRunoffList.Add(dDate, cRunoff);
                CumulativeWaterLossList.Add(dDate, cWaterLoss);

            }//Close while read in loop

                //Get end date of GRD file
                //iEndGRHYear = iYear;
                //iEndGRHMonth = iMonth;
                //iEndGRHDay = iDay;

                //Set End Date of visible scale to start date plus 2 years
                //int iGRHMonthVisible = iStartGRHMonth;
                //int iGRHDayVisible = iStartGRHDay;
                //int iGRHYearVisible = iStartGRHYear + 2;


                //Close GRD file
                inFile.Close();

                //Add Start and End date to text boxes under Scale Group
                //this.textStartDate.Text = Convert.ToString(iStartGRHMonth) + "/" + Convert.ToString(iStartGRHDay) + "/" + Convert.ToString(iStartGRHYear);
                //this.textEndDate.Text = Convert.ToString(iGRHMonthVisible) + "/" + Convert.ToString(iStartGRHDay) + "/" + Convert.ToString(iGRHYearVisible);

                //*****************************************************************
                //*****************************************************************

                 //2.Read in Monthly Values
                // Open the GRD file

                StreamReader inFileM = new StreamReader(sGrmPath);

                //Parameters in GRM file, in order, are as follows
                //Year
                //Month
                //Rainfall
                //Infiltration
                //AET
                //Drainage
                //Runoff
                //SEW
                //Dry Days
                //Pump Vol
                //Water Loss

                string lineM;

            // Read one line of data at a time until the end of file
                while ((lineM = inFileM.ReadLine()) != null)
                {
                    // Convert each line in to an array of strings
                    //Each loop through overwrites previous array
                    //Split the items on the line using the , character as delimiter (declared above)
                    string[] itemsM = lineM.Split(sep);
                    // If there's less than 2 items, throw an exception
                    if (itemsM.Length < 2)
                        throw new Exception("Error: Not enough data points to plot");

                    //Declare Variables in GRH file
                    double dYearM, dMonthM, dRainfallM, dInfiltrationM, dAETM, dDrainageM;
                    double dRunoffM, dSEWM, dDryDaysM, dPumpVolM, dWaterLossM;

                    // If the value is missing mark it so. Otherwise, parse it as a double
                    if (itemsM[0].Length == 0)
                        dYearM = PointPair.Missing;
                    else
                        dYearM = Double.Parse(itemsM[0]);

                    if (itemsM[1].Length == 0)
                        dMonthM = PointPair.Missing;
                    else
                        dMonthM = Double.Parse(itemsM[1]);

                    if (itemsM[2].Length == 0)
                        dRainfallM = PointPair.Missing;
                    else
                        dRainfallM = Double.Parse(itemsM[2]);

                    if (itemsM[3].Length == 0)
                        dInfiltrationM = PointPair.Missing;
                    else
                        dInfiltrationM = Double.Parse(itemsM[3]);

                    if (itemsM[4].Length == 0)
                        dAETM = PointPair.Missing;
                    else
                        dAETM = Double.Parse(itemsM[4]);

                    if (itemsM[5].Length == 0)
                        dDrainageM = PointPair.Missing;
                    else
                        dDrainageM = Double.Parse(itemsM[5]);

                    if (itemsM[6].Length == 0)
                        dRunoffM = PointPair.Missing;
                    else
                        dRunoffM = Double.Parse(itemsM[6]);

                    if (itemsM[7].Length == 0)
                        dSEWM = PointPair.Missing;
                    else
                        dSEWM = Double.Parse(itemsM[7]);

                    if (itemsM[8].Length == 0)
                        dDryDaysM = PointPair.Missing;
                    else
                        dDryDaysM = Double.Parse(itemsM[8]);

                    if (itemsM[9].Length == 0)
                        dPumpVolM = PointPair.Missing;
                    else
                        dPumpVolM = Double.Parse(itemsM[9]);

                    if (itemsM[10].Length == 0)
                        dWaterLossM = PointPair.Missing;
                    else
                        dWaterLossM = Double.Parse(itemsM[10]);



                    //Convert Date to XDate Format for graphing
                    //First convert double to integers
                    iYear = Convert.ToInt32(dYearM);
                    iMonth = Convert.ToInt32(dMonthM);
                    iDay = 15;

                    //Check for Leap Year
                    //http://www.dotnetspider.com/resources/17593-How-Check-Leap-Year-using-C.aspx
                    //leapYear = (((iYear % 4) == 0) && ((iYear % 100) != 0) || ((iYear % 400) == 0));

                    //Then do Zedgraph XDate
                    XDate myXDateM = new XDate(iYear, iMonth, iDay);
                    Double dDateM = myXDateM;
                    //XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                    //Double dDateMonth = myXDateMonth;
                    //double dYearlyYear = dYear;

                    //Add Daily Values to Daily Lists
                    MonthlyRainfallList.Add(dDateM, dRainfallM);
                    MonthlyInfiltrationList.Add(dDateM, dInfiltrationM);
                    MonthlyAETList.Add(dDateM, dAETM);
                    MonthlyDrainageList.Add(dDateM, dDrainageM);
                    MonthlyRunoffList.Add(dDateM, dRunoffM);
                    MonthlyWaterLossList.Add(dDateM, dWaterLossM);
                }

                //Close GRM file
                inFileM.Close();

                //*****************************************************************
                //*****************************************************************

                //2.Read in Yearly Values
                // Open the GRY file

                StreamReader inFileY = new StreamReader(sGryPath);

                //Parameters in GRD file, in order, are as follows
                //Year
                //Rainfall
                //Infiltration
                //AET
                //Drainage
                //Runoff
                //SEW
                //Water Loss
                //Pump Vol
                

                string lineY;

            // Read one line of data at a time until the end of file
            while ((lineY = inFileY.ReadLine()) != null)
            {
                // Convert each line in to an array of strings
                //Each loop through overwrites previous array
                //Split the items on the line using the , character as delimiter (declared above)
                string[] itemsY = lineY.Split(sep);
                // If there's less than 2 items, throw an exception
                if (itemsY.Length < 2)
                    throw new Exception("Error: Not enough data points to plot");

                //Declare Variables in GRH file
                double dYearY, dRainfallY, dInfiltrationY, dAETY, dDrainageY;
                double dRunoffY, dSEWY, dWaterLossY, dPumpVolY;

                // If the value is missing mark it so. Otherwise, parse it as a double
                if (itemsY[0].Length == 0)
                    dYearY = PointPair.Missing;
                else
                    dYearY = Double.Parse(itemsY[0]);

                if (itemsY[1].Length == 0)
                    dRainfallY = PointPair.Missing;
                else
                    dRainfallY = Double.Parse(itemsY[1]);

                if (itemsY[2].Length == 0)
                    dInfiltrationY = PointPair.Missing;
                else
                    dInfiltrationY = Double.Parse(itemsY[2]);

                if (itemsY[3].Length == 0)
                    dAETY = PointPair.Missing;
                else
                    dAETY = Double.Parse(itemsY[3]);

                if (itemsY[4].Length == 0)
                    dDrainageY = PointPair.Missing;
                else
                    dDrainageY = Double.Parse(itemsY[4]);

                if (itemsY[5].Length == 0)
                    dRunoffY = PointPair.Missing;
                else
                    dRunoffY = Double.Parse(itemsY[5]);

                if (itemsY[6].Length == 0)
                    dSEWY = PointPair.Missing;
                else
                    dSEWY = Double.Parse(itemsY[6]);

                if (itemsY[7].Length == 0)
                    dWaterLossY = PointPair.Missing;
                else
                    dWaterLossY = Double.Parse(itemsY[7]);

                if (itemsY[8].Length == 0)
                    dPumpVolY = PointPair.Missing;
                else
                    dPumpVolY = Double.Parse(itemsY[8]);




                //Convert Date to XDate Format for graphing
                //First convert double to integers
                iYear = Convert.ToInt32(dYearY);
                iMonth = 6;
                iDay = 15;

                //Check for Leap Year
                //http://www.dotnetspider.com/resources/17593-How-Check-Leap-Year-using-C.aspx
                //leapYear = (((iYear % 4) == 0) && ((iYear % 100) != 0) || ((iYear % 400) == 0));

                //Then do Zedgraph XDate
                XDate myXDateY = new XDate(iYear, iMonth, iDay);
                Double dDateY = myXDateY;
                //XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                //Double dDateMonth = myXDateMonth;
                //double dYearlyYear = dYear;

                //Add Daily Values to Daily Lists
                YearlyRainfallList.Add(dDateY, dRainfallY);
                YearlyInfiltrationList.Add(dDateY, dInfiltrationY);
                YearlyAETList.Add(dDateY, dAETY);
                YearlyDrainageList.Add(dDateY, dDrainageY);
                YearlyRunoffList.Add(dDateY, dRunoffY);
                YearlyWaterLossList.Add(dDateY, dWaterLossY);

            }

                //Close GRY file
                inFileY.Close();


            //*****************************************************************
            //*****************************************************************

            #endregion



            //*****************************************************************
            //Up to this point all data are read in and point lists generated
            //*****************************************************************



            #region "Curve Creation"
            


           // Plots
            //-------------------------------------------------
            //Daily
            //Lines
            PreWTCurve = zg1.GraphPane.AddCurve("Water Table Depth",
                      PreWTList, Color.Blue, SymbolType.Circle);

            DryZoneCurve = zg1.GraphPane.AddCurve("Dry Zone Depth",
                        DryZoneList, Color.Blue, SymbolType.Circle);

            RainfallCurve = zg1.GraphPane.AddCurve("Rainfall",
                        RainfallList, Color.Orange, SymbolType.Circle);
            
            InfiltrationCurve = zg1.GraphPane.AddCurve("Infiltration",
                        InfiltrationList, Color.Green, SymbolType.Circle);
            
            AETCurve = zg1.GraphPane.AddCurve("Evaporation",
                        AETList, Color.Indigo, SymbolType.Circle);
            
            DrainageCurve = zg1.GraphPane.AddCurve("Drainage",
                        DrainageList, Color.Violet, SymbolType.Circle);
            
            RunoffCurve = zg1.GraphPane.AddCurve("Surface Runoff",
                        RunoffList, Color.Gray, SymbolType.Circle);
            
            WaterLossCurve = zg1.GraphPane.AddCurve("Water Loss",
                        WaterLossList, Color.Yellow, SymbolType.Circle);
            
            SurfaceStorageCurve = zg1.GraphPane.AddCurve("Surface Storage",
                        SurfaceStorageList, Color.Pink, SymbolType.Circle);
            
            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar
            PreWTBar = zg1.GraphPane.AddBar("Water Table Depth",
                        PreWTList, Color.Blue);

            DryZoneBar = zg1.GraphPane.AddBar("Dry Zone Depth",
                        DryZoneList, Color.Blue);

            RainfallBar = zg1.GraphPane.AddBar("Rainfall",
                        RainfallList, Color.Orange);

            InfiltrationBar = zg1.GraphPane.AddBar("Infiltration",
                        InfiltrationList, Color.Green);

            AETBar = zg1.GraphPane.AddBar("Evaporation",
                        AETList, Color.Indigo);

            DrainageBar = zg1.GraphPane.AddBar("Drainage",
                        DrainageList, Color.Violet);

            RunoffBar = zg1.GraphPane.AddBar("Surface Runoff",
                        RunoffList, Color.Gray);

            WaterLossBar = zg1.GraphPane.AddBar("Water Loss",
                        WaterLossList, Color.Yellow);

            SurfaceStorageBar = zg1.GraphPane.AddBar("Surface Storage",
                        SurfaceStorageList, Color.Pink);


            //-------------------------------------------------
            //Monthly
            MonthlyRainfallCurve = zg1.GraphPane.AddCurve("Monthly Rainfall",
                        MonthlyRainfallList, Color.Orange, SymbolType.Circle);

            MonthlyInfiltrationCurve = zg1.GraphPane.AddCurve("Monthly Infiltration",
                        MonthlyInfiltrationList, Color.Green, SymbolType.Circle);

            MonthlyAETCurve = zg1.GraphPane.AddCurve("Monthly Evaporation",
                        MonthlyAETList, Color.Indigo, SymbolType.Circle);

            MonthlyDrainageCurve = zg1.GraphPane.AddCurve("Monthly Drainage",
                        MonthlyDrainageList, Color.Violet, SymbolType.Circle);

            MonthlyRunoffCurve = zg1.GraphPane.AddCurve("Monthly Surface Runoff",
                        MonthlyRunoffList, Color.Gray, SymbolType.Circle);

            MonthlyWaterLossCurve = zg1.GraphPane.AddCurve("Monthly Water Loss",
                        MonthlyWaterLossList, Color.Yellow, SymbolType.Circle);

            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar
            MonthlyRainfallBar = zg1.GraphPane.AddBar("Monthly Rainfall",
                        MonthlyRainfallList, Color.Orange);

            MonthlyInfiltrationBar = zg1.GraphPane.AddBar("Monthly Infiltration",
                        MonthlyInfiltrationList, Color.Green);

            MonthlyAETBar = zg1.GraphPane.AddBar("Monthly Evaporation",
                        MonthlyAETList, Color.Indigo);

            MonthlyDrainageBar = zg1.GraphPane.AddBar("Monthly Drainage",
                        MonthlyDrainageList, Color.Violet);

            MonthlyRunoffBar = zg1.GraphPane.AddBar("Monthly Surface Runoff",
                        MonthlyRunoffList, Color.Gray);

            MonthlyWaterLossBar = zg1.GraphPane.AddBar("Monthly Water Loss",
                        MonthlyWaterLossList, Color.Yellow);


            //-------------------------------------------------
            //Cumulative

            CumulativeRainfallCurve = zg1.GraphPane.AddCurve("Cumulative Rainfall",
                        CumulativeRainfallList, Color.Orange, SymbolType.Circle);

            CumulativeInfiltrationCurve = zg1.GraphPane.AddCurve("Cumulative Infiltration",
                        CumulativeInfiltrationList, Color.Green, SymbolType.Circle);

            CumulativeAETCurve = zg1.GraphPane.AddCurve("Cumulative Evaporation",
                        CumulativeAETList, Color.Indigo, SymbolType.Circle);

            CumulativeDrainageCurve = zg1.GraphPane.AddCurve("Cumulative Drainage",
                        CumulativeDrainageList, Color.Violet, SymbolType.Circle);

            CumulativeRunoffCurve = zg1.GraphPane.AddCurve("Cumulative Surface Runoff",
                        CumulativeRunoffList, Color.Gray, SymbolType.Circle);

            CumulativeWaterLossCurve = zg1.GraphPane.AddCurve("Cumulative Water Loss",
                        CumulativeWaterLossList, Color.Yellow, SymbolType.Circle);

            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar

            CumulativeRainfallBar = zg1.GraphPane.AddBar("Cumulative Rainfall",
                        CumulativeRainfallList, Color.Orange);

            CumulativeInfiltrationBar = zg1.GraphPane.AddBar("Cumulative Infiltration",
                        CumulativeInfiltrationList, Color.Green);

            CumulativeAETBar = zg1.GraphPane.AddBar("Cumulative Evaporation",
                        CumulativeAETList, Color.Indigo);

            CumulativeDrainageBar = zg1.GraphPane.AddBar("Cumulative Drainage",
                        CumulativeDrainageList, Color.Violet);

            CumulativeRunoffBar = zg1.GraphPane.AddBar("Cumulative Surface Runoff",
                        CumulativeRunoffList, Color.Gray);

            CumulativeWaterLossBar = zg1.GraphPane.AddBar("Cumulative Water Loss",
                        CumulativeWaterLossList, Color.Yellow);

            //-------------------------------------------------
            //Yearly

            YearlyRainfallCurve = zg1.GraphPane.AddCurve("Annual Rainfall",
                        YearlyRainfallList, Color.Orange, SymbolType.Circle);

            YearlyInfiltrationCurve = zg1.GraphPane.AddCurve("Annual Infiltration",
                        YearlyInfiltrationList, Color.Green, SymbolType.Circle);

            YearlyAETCurve = zg1.GraphPane.AddCurve("Annual Evaporation",
                        YearlyAETList, Color.Indigo, SymbolType.Circle);

            YearlyDrainageCurve = zg1.GraphPane.AddCurve("Annual Drainage",
                        YearlyDrainageList, Color.Violet, SymbolType.Circle);

            YearlyRunoffCurve = zg1.GraphPane.AddCurve("Annual Surface Runoff",
                        YearlyRunoffList, Color.Gray, SymbolType.Circle);

            YearlyWaterLossCurve = zg1.GraphPane.AddCurve("Annual Water Loss",
                        YearlyWaterLossList, Color.Yellow, SymbolType.Circle);

            ////Scatter
            ////To make scatter plot
            //myCurve.Line.IsVisible = false;
            //// Hide the symbol outline
            //myCurve.Symbol.Border.IsVisible = false;
            //// Fill the symbol interior with color
            //myCurve.Symbol.Fill = new Fill(Color.Firebrick);

            //Bar
            YearlyRainfallBar = zg1.GraphPane.AddBar("Annual Rainfall",
                        YearlyRainfallList, Color.Orange);

            YearlyInfiltrationBar = zg1.GraphPane.AddBar("Annual Infiltration",
                        YearlyInfiltrationList, Color.Green);

            YearlyAETBar = zg1.GraphPane.AddBar("Annual Evaporation",
                        YearlyAETList, Color.Indigo);

            YearlyDrainageBar = zg1.GraphPane.AddBar("Annual Drainage",
                        YearlyDrainageList, Color.Violet);

            YearlyRunoffBar = zg1.GraphPane.AddBar("Annual Surface Runoff",
                        YearlyRunoffList, Color.Gray);

            YearlyWaterLossBar = zg1.GraphPane.AddBar("Annual Water Loss",
                        YearlyWaterLossList, Color.Yellow);





            //*******************************
            //Reading in and setting a color et al
            //*******************************
            //string scolor1 = "Blue";
            //string scolor2 = "Red";
            //System.Drawing.ColorConverter colConvert = new ColorConverter();
            //zg1.GraphPane.YAxis.Scale.FontSpec.FontColor = (System.Drawing.Color)colConvert.ConvertFromString(scolor1);
            //zg1.GraphPane.Y2Axis.Scale.FontSpec.FontColor = (System.Drawing.Color)colConvert.ConvertFromString(scolor2);

            //string sfont1 = "Times New Roman";
            //zg1.GraphPane.Y2Axis.Scale.FontSpec.Family = sfont1;
            //int sfontsize1 = 14;
            //zg1.GraphPane.Y2Axis.Scale.FontSpec.Size = sfontsize1;
            //bool sfontbold = true;
            //zg1.GraphPane.Y2Axis.Scale.FontSpec.IsBold = sfontbold;


            //*******************************
            //*******************************


           // //Line Thickness
           // //-------------------------------------------------

           // //Daily
           // PreWTCurve.Line.Width = 3.0F;
           // DryZoneCurve.Line.Width = 3.0F;
           // RainfallCurve.Line.Width = 3.0F;
           // InfiltrationCurve.Line.Width = 3.0F;
           // AETCurve.Line.Width = 3.0F;
           // DrainageCurve.Line.Width = 3.0F;
           // RunoffCurve.Line.Width = 3.0F;
           // WaterLossCurve.Line.Width = 3.0F;
           // SurfaceStorageCurve.Line.Width = 3.0F;
           // //Monthly

           // MonthlyRainfallCurve.Line.Width = 3.0F;
           // MonthlyInfiltrationCurve.Line.Width = 3.0F;
           // MonthlyAETCurve.Line.Width = 3.0F;
           // MonthlyDrainageCurve.Line.Width = 3.0F;
           // MonthlyRunoffCurve.Line.Width = 3.0F;
           // MonthlyWaterLossCurve.Line.Width = 3.0F;

           // //Cumulative

           // CumulativeRainfallCurve.Line.Width = 3.0F;
           // CumulativeInfiltrationCurve.Line.Width = 3.0F;
           // CumulativeAETCurve.Line.Width = 3.0F;
           // CumulativeDrainageCurve.Line.Width = 3.0F;
           // CumulativeRunoffCurve.Line.Width = 3.0F;
           // CumulativeWaterLossCurve.Line.Width = 3.0F;

           // //Annual

           // YearlyRainfallCurve.Line.Width = 3.0F;
           // YearlyInfiltrationCurve.Line.Width = 3.0F;
           // YearlyAETCurve.Line.Width = 3.0F;
           // YearlyDrainageCurve.Line.Width = 3.0F;
           // YearlyRunoffCurve.Line.Width = 3.0F;
           // YearlyWaterLossCurve.Line.Width = 3.0F;


           // // Increase the symbol sizes, and fill them with solid white
           // //-------------------------------------------------
           // //Daily
           // PreWTCurve.Symbol.Size = 1.0F;
           // PreWTCurve.Symbol.Fill = new Fill(Color.White);

           // DryZoneCurve.Symbol.Size = 3.0F;
           // DryZoneCurve.Symbol.Fill = new Fill(Color.White);

           // RainfallCurve.Symbol.Size = 3.0F;
           // RainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //RainfallCurve.IsY2Axis = true;

           // InfiltrationCurve.Symbol.Size = 3.0F;
           // InfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // //InfiltrationCurve.IsY2Axis = true;

           // AETCurve.Symbol.Size = 3.0F;
           // AETCurve.Symbol.Fill = new Fill(Color.White);
           //// AETCurve.IsY2Axis = true;

           // DrainageCurve.Symbol.Size = 3.0F;
           // DrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //DrainageCurve.IsY2Axis = true;

           // RunoffCurve.Symbol.Size = 3.0F;
           // RunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //RunoffCurve.IsY2Axis = true;

           // WaterLossCurve.Symbol.Size = 3.0F;
           // WaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //WaterLossCurve.IsY2Axis = true;

           // SurfaceStorageCurve.Symbol.Size = 3.0F;
           // SurfaceStorageCurve.Symbol.Fill = new Fill(Color.White);
           // //SurfaceStorageCurve.IsY2Axis = true;

           // //Monthly

           // MonthlyRainfallCurve.Symbol.Size = 3.0F;
           // MonthlyRainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyRainfallCurve.IsY2Axis = true;

           // MonthlyInfiltrationCurve.Symbol.Size = 3.0F;
           // MonthlyInfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // // MonthlyInfiltrationCurve.IsY2Axis = true;

           // MonthlyAETCurve.Symbol.Size = 3.0F;
           // MonthlyAETCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyAETCurve.IsY2Axis = true;

           // MonthlyDrainageCurve.Symbol.Size = 3.0F;
           // MonthlyDrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyDrainageCurve.IsY2Axis = true;

           // MonthlyRunoffCurve.Symbol.Size = 3.0F;
           // MonthlyRunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyRunoffCurve.IsY2Axis = true;

           // MonthlyWaterLossCurve.Symbol.Size = 3.0F;
           // MonthlyWaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //MonthlyWaterLossCurve.IsY2Axis = true;


           // //Cumulative

           // CumulativeRainfallCurve.Symbol.Size = 3.0F;
           // CumulativeRainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeRainfallCurve.IsY2Axis = true;

           // CumulativeInfiltrationCurve.Symbol.Size = 3.0F;
           // CumulativeInfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeInfiltrationCurve.IsY2Axis = true;

           // CumulativeAETCurve.Symbol.Size = 3.0F;
           // CumulativeAETCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeAETCurve.IsY2Axis = true;

           // CumulativeDrainageCurve.Symbol.Size = 3.0F;
           // CumulativeDrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeDrainageCurve.IsY2Axis = true;

           // CumulativeRunoffCurve.Symbol.Size = 3.0F;
           // CumulativeRunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeRunoffCurve.IsY2Axis = true;

           // CumulativeWaterLossCurve.Symbol.Size = 3.0F;
           // CumulativeWaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //CumulativeWaterLossCurve.IsY2Axis = true;


           // //Yearly
           // YearlyRainfallCurve.Symbol.Size = 3.0F;
           // YearlyRainfallCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyRainfallCurve.IsY2Axis = true;

           // YearlyInfiltrationCurve.Symbol.Size = 3.0F;
           // YearlyInfiltrationCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyInfiltrationCurve.IsY2Axis = true;

           // YearlyAETCurve.Symbol.Size = 3.0F;
           // YearlyAETCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyAETCurve.IsY2Axis = true;

           // YearlyDrainageCurve.Symbol.Size = 3.0F;
           // YearlyDrainageCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyDrainageCurve.IsY2Axis = true;

           // YearlyRunoffCurve.Symbol.Size = 3.0F;
           // YearlyRunoffCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyRunoffCurve.IsY2Axis = true;

           // YearlyWaterLossCurve.Symbol.Size = 3.0F;
           // YearlyWaterLossCurve.Symbol.Fill = new Fill(Color.White);
           // //YearlyWaterLossCurve.IsY2Axis = true;




            // Set the initial viewed range
            //-------------------------------------------------
            //First extract first date of GRH data
            //string sFirstDateList = PreWTList[0].ToString();
            //string[] sRightSide = sFirstDateList.Split('(');
            //string sRightSide2 = sRightSide[1];
            //string[] sSplit = sRightSide2.Split(',');
            //string sFirstDate = sSplit[0];
            //dFirstDate = Convert.ToDouble(sFirstDate);

            //Then set graph to start at the first date with default 2 years showing
            //int iDisplayMonths = 24;

            //this.textLengthTime.Text = Convert.ToString(iDisplayMonths);
            //zgc.GraphPane.XAxis.Scale.Min = dFirstDate;
            //zgc.GraphPane.XAxis.Scale.Max = dFirstDate+735;

            //zgc.GraphPane.XAxis.Scale.Format = 

            //Hide Variables at Startup
            //-------------------------------------------------
            //Lines
            //Daily
            SurfaceStorageCurve.IsVisible = false;
            SurfaceStorageCurve.Label.IsVisible = false;
            DryZoneCurve.IsVisible = false;
            DryZoneCurve.Label.IsVisible = false;
            RainfallCurve.IsVisible = false;
            RainfallCurve.Label.IsVisible = false;
            InfiltrationCurve.IsVisible = false;
            InfiltrationCurve.Label.IsVisible = false;
            AETCurve.IsVisible = false;
            AETCurve.Label.IsVisible = false;
            DrainageCurve.IsVisible = false;
            DrainageCurve.Label.IsVisible = false;
            RunoffCurve.IsVisible = false;
            RunoffCurve.Label.IsVisible = false;
            WaterLossCurve.IsVisible = false;
            WaterLossCurve.Label.IsVisible = false;
            SurfaceStorageCurve.IsVisible = false;
            SurfaceStorageCurve.Label.IsVisible = false;
            //Monthly

            MonthlyRainfallCurve.IsVisible = false;
            MonthlyRainfallCurve.Label.IsVisible = false;
            MonthlyInfiltrationCurve.IsVisible = false;
            MonthlyInfiltrationCurve.Label.IsVisible = false;
            MonthlyAETCurve.IsVisible = false;
            MonthlyAETCurve.Label.IsVisible = false;
            MonthlyDrainageCurve.IsVisible = false;
            MonthlyDrainageCurve.Label.IsVisible = false;
            MonthlyRunoffCurve.IsVisible = false;
            MonthlyRunoffCurve.Label.IsVisible = false;
            MonthlyWaterLossCurve.IsVisible = false;
            MonthlyWaterLossCurve.Label.IsVisible = false;

            //Cumulative
           
            CumulativeRainfallCurve.IsVisible = false;
            CumulativeRainfallCurve.Label.IsVisible = false;
            CumulativeInfiltrationCurve.IsVisible = false;
            CumulativeInfiltrationCurve.Label.IsVisible = false;
            CumulativeAETCurve.IsVisible = false;
            CumulativeAETCurve.Label.IsVisible = false;
            CumulativeDrainageCurve.IsVisible = false;
            CumulativeDrainageCurve.Label.IsVisible = false;
            CumulativeRunoffCurve.IsVisible = false;
            CumulativeRunoffCurve.Label.IsVisible = false;
            CumulativeWaterLossCurve.IsVisible = false;
            CumulativeWaterLossCurve.Label.IsVisible = false;

            //Yearly
           
            YearlyRainfallCurve.IsVisible = false;
            YearlyRainfallCurve.Label.IsVisible = false;
            YearlyInfiltrationCurve.IsVisible = false;
            YearlyInfiltrationCurve.Label.IsVisible = false;
            YearlyAETCurve.IsVisible = false;
            YearlyAETCurve.Label.IsVisible = false;
            YearlyDrainageCurve.IsVisible = false;
            YearlyDrainageCurve.Label.IsVisible = false;
            YearlyRunoffCurve.IsVisible = false;
            YearlyRunoffCurve.Label.IsVisible = false;
            YearlyWaterLossCurve.IsVisible = false;
            YearlyWaterLossCurve.Label.IsVisible = false;

            
            
            //Bars
            //Daily
            PreWTBar.IsVisible = false;
            PreWTBar.Label.IsVisible = false;
            SurfaceStorageBar.IsVisible = false;
            SurfaceStorageBar.Label.IsVisible = false;
            DryZoneBar.IsVisible = false;
            DryZoneBar.Label.IsVisible = false;
            RainfallBar.IsVisible = false;
            RainfallBar.Label.IsVisible = false;
            InfiltrationBar.IsVisible = false;
            InfiltrationBar.Label.IsVisible = false;
            AETBar.IsVisible = false;
            AETBar.Label.IsVisible = false;
            DrainageBar.IsVisible = false;
            DrainageBar.Label.IsVisible = false;
            RunoffBar.IsVisible = false;
            RunoffBar.Label.IsVisible = false;
            WaterLossBar.IsVisible = false;
            WaterLossBar.Label.IsVisible = false;
            SurfaceStorageBar.IsVisible = false;
            SurfaceStorageBar.Label.IsVisible = false;
            //Monthly
           
            MonthlyRainfallBar.IsVisible = false;
            MonthlyRainfallBar.Label.IsVisible = false;
            MonthlyInfiltrationBar.IsVisible = false;
            MonthlyInfiltrationBar.Label.IsVisible = false;
            MonthlyAETBar.IsVisible = false;
            MonthlyAETBar.Label.IsVisible = false;
            MonthlyDrainageBar.IsVisible = false;
            MonthlyDrainageBar.Label.IsVisible = false;
            MonthlyRunoffBar.IsVisible = false;
            MonthlyRunoffBar.Label.IsVisible = false;
            MonthlyWaterLossBar.IsVisible = false;
            MonthlyWaterLossBar.Label.IsVisible = false;

            //Cumulative

            CumulativeRainfallBar.IsVisible = false;
            CumulativeRainfallBar.Label.IsVisible = false;
            CumulativeInfiltrationBar.IsVisible = false;
            CumulativeInfiltrationBar.Label.IsVisible = false;
            CumulativeAETBar.IsVisible = false;
            CumulativeAETBar.Label.IsVisible = false;
            CumulativeDrainageBar.IsVisible = false;
            CumulativeDrainageBar.Label.IsVisible = false;
            CumulativeRunoffBar.IsVisible = false;
            CumulativeRunoffBar.Label.IsVisible = false;
            CumulativeWaterLossBar.IsVisible = false;
            CumulativeWaterLossBar.Label.IsVisible = false;

            //Yearly

            YearlyRainfallBar.IsVisible = false;
            YearlyRainfallBar.Label.IsVisible = false;
            YearlyInfiltrationBar.IsVisible = false;
            YearlyInfiltrationBar.Label.IsVisible = false;
            YearlyAETBar.IsVisible = false;
            YearlyAETBar.Label.IsVisible = false;
            YearlyDrainageBar.IsVisible = false;
            YearlyDrainageBar.Label.IsVisible = false;
            YearlyRunoffBar.IsVisible = false;
            YearlyRunoffBar.Label.IsVisible = false;
            YearlyWaterLossBar.IsVisible = false;
            YearlyWaterLossBar.Label.IsVisible = false;


            // Calculate the Axis Scale Ranges
            zg1.AxisChange();


            #endregion


            #region "Initialize Obs Lists and Plots"

            myCurveObs = zg1.GraphPane.AddCurve("Empty",
                PreWTList,Color.Black);
            myBarObs = zg1.GraphPane.AddBar("Empty",
                PreWTList, Color.Black);
            myCurveObs2 = zg1.GraphPane.AddCurve("Empty",
                PreWTList, Color.Black, SymbolType.Circle);
            myBarObs2 = zg1.GraphPane.AddBar("Empty",
                PreWTList, Color.Black);
            myCurveObs3 = zg1.GraphPane.AddCurve("Empty",
                PreWTList, Color.Black, SymbolType.Circle);
            myBarObs3 = zg1.GraphPane.AddBar("Empty",
                PreWTList, Color.Black);

            myCurveObs.IsVisible = false;
            myCurveObs.Label.IsVisible = false;
            myBarObs.IsVisible = false;
            myBarObs.Label.IsVisible = false;
            myCurveObs2.IsVisible = false;
            myCurveObs2.Label.IsVisible = false;
            myBarObs2.IsVisible = false;
            myBarObs2.Label.IsVisible = false;
            myCurveObs3.IsVisible = false;
            myCurveObs3.Label.IsVisible = false;
            myBarObs3.IsVisible = false;
            myBarObs3.Label.IsVisible = false;


            #endregion


            #region "Load Formatting Scheme"

            //Call Formatting method
            methodLoadFormattingScheme();

            #endregion


            #region "Load Preference 1 dat files"

            //Set path to location of program
            Directory.SetCurrentDirectory(Application.StartupPath);

            //File List 
            string sFilePreference1 = "Graphing/Preference1.dat";
            string sFileHydrology_Prefs1 = "Graphing/Hydrology_Prefs1.dat";
            string sFileObserved_Paths = "Graphing/Observed_Paths.dat";
            string sFileObserved_Prefs1 = "Graphing/Observed_Prefs1.dat";

            //Handle if files do not exists

           if (File.Exists(sFileHydrology_Prefs1))
            { 
                //Read in Hydrology_Prefs1.dat
                //Populate Fields
                methodLoadHydrologyPrefs1();
                //Update if Plot Displayed and Type
                methodDisplayPreWT();
                methodDisplaySurfaceStorage();
                methodDisplayDryZone();
                methodDisplayRainfall();
                methodDisplayInfiltration();
                methodDisplayEvaporation();
                methodDisplayDrainage();
                methodDisplaySurfaceRunoff();
                methodDisplayWaterLoss();
                //Update Axis
                methodChangeAxis();
            }

            if (File.Exists(sFilePreference1))
            {
                //Read in Preference1.dat
                methodLoadPrefs1();
                methodUpdatePlot();
            }


            if (File.Exists(sFileObserved_Paths))
            {
                //Read in Observed_Paths.dat
                methodLoadFilePath();
                //Reset Observed Data Arrays
                if (this.textObsFile.Text != "")
                {
                    methodLoadInObserved1();
                }
                if (this.textObsFile2.Text != "")
                {
                    methodLoadInObserved2();
                }
                if (this.textObsFile3.Text != "")
                {
                    methodLoadInObserved3();
                }

            }

            if (File.Exists(sFileObserved_Prefs1))
            {
                //Read in Observed_Prefs1.dat
                methodLoadObservedPrefs1();
                //Update if Plot Displayed and Type
                methodDisplayObs1();
                methodDisplayObs2();
                methodDisplayObs3();
                //Update Axis
                methodChangeAxis();


            }







            }

            #endregion

    }//Close Main Class
}//Close Namespace
