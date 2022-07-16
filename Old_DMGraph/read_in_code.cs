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
            YearlyPreWTList = new PointPairList();
            YearlyDryZoneList = new PointPairList();
            YearlyRainfallList = new PointPairList();
            YearlyInfiltrationList = new PointPairList();
            YearlyPETList = new PointPairList();
            YearlyAETList = new PointPairList();
            YearlyDrainageList = new PointPairList();
            YearlyRunoffList = new PointPairList();
            YearlyWaterLossList = new PointPairList();
            YearlySurfaceStorageList = new PointPairList();
            //Monthly
            MonthlyPreWTList = new PointPairList();
            MonthlyDryZoneList = new PointPairList();
            MonthlyRainfallList = new PointPairList();
            MonthlyInfiltrationList = new PointPairList();
            MonthlyPETList = new PointPairList();
            MonthlyAETList = new PointPairList();
            MonthlyDrainageList = new PointPairList();
            MonthlyRunoffList = new PointPairList();
            MonthlyWaterLossList = new PointPairList();
            MonthlySurfaceStorageList = new PointPairList();
            //Cumulative
            CumulativePreWTList = new PointPairList();
            CumulativeDryZoneList = new PointPairList();
            CumulativeRainfallList = new PointPairList();
            CumulativeInfiltrationList = new PointPairList();
            CumulativePETList = new PointPairList();
            CumulativeAETList = new PointPairList();
            CumulativeDrainageList = new PointPairList();
            CumulativeRunoffList = new PointPairList();
            CumulativeWaterLossList = new PointPairList();
            CumulativeSurfaceStorageList = new PointPairList();

            #endregion


            #region "Read in data and create lists"

            //*****************************************************************
            //*****************************************************************
            //READING IN DATA

                   
            //Open C:/Info.dat file. This file has full path to raw data files
            StreamReader InfoDat = new StreamReader("C:/Info.dat");
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
            //PET
            //AET
            //Drainage
            //Runoff
            //Water Loss
            //Water Table Depth
            //Air Volume
            //Dry Zone Debt
            //Dry Zone Depth
            //Surface Storage

            //Initialize Leap Year Boolean
            bool leapYear = false;

            //Initialize Monthly Variables
            int mMonth = 0;
            double mRainfall = 0;
            double mInfiltration = 0;
            double mPET = 0;
            double mAET = 0;
            double mDrainage = 0;
            double mRunoff = 0;
            double mWaterLoss = 0;
            double mPreWT = 0;
            double mDryZoneDepth = 0;
            double mSurfaceStorage = 0;

            //Initialize Yearly Variables
            int yYear = 0;
            double yRainfall = 0;
            double yInfiltration = 0;
            double yPET = 0;
            double yAET = 0;
            double yDrainage = 0;
            double yRunoff = 0;
            double yWaterLoss = 0;
            double yPreWT = 0;
            double yDryZoneDepth = 0;
            double ySurfaceStorage = 0;

            //Initialize Cumulative Variables
            double cRainfall = 0;
            double cInfiltration = 0;
            double cPET = 0;
            double cAET = 0;
            double cDrainage = 0;
            double cRunoff = 0;
            double cWaterLoss = 0;
            double cPreWT = 0;
            double cDryZoneDepth = 0;
            double cSurfaceStorage = 0;

            //Initialize Dates of GRH File
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
                double dYear, dMonth, dDay, dRainfall, dInfiltration, dPET, dAET, dDrainage;
                double dRunoff, dWaterLoss, dPreWT, dAirVolume, dDryZoneDebt;
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
                    dPET = PointPair.Missing;
                else
                    dPET = Double.Parse(items[5]);

                if (items[6].Length == 0)
                    dAET = PointPair.Missing;
                else
                    dAET = Double.Parse(items[6]);

                if (items[7].Length == 0)
                    dDrainage = PointPair.Missing;
                else
                    dDrainage = Double.Parse(items[7]);

                if (items[8].Length == 0)
                    dRunoff = PointPair.Missing;
                else
                    dRunoff = Double.Parse(items[8]);

                if (items[9].Length == 0)
                    dWaterLoss = PointPair.Missing;
                else
                    dWaterLoss = Double.Parse(items[9]);

                if (items[10].Length == 0)
                    dPreWT = PointPair.Missing;
                else
                    dPreWT = Double.Parse(items[10]);

                if (items[11].Length == 0)
                    dAirVolume = PointPair.Missing;
                else
                    dAirVolume = Double.Parse(items[11]);

                if (items[12].Length == 0)
                    dDryZoneDebt = PointPair.Missing;
                else
                    dDryZoneDebt = Double.Parse(items[12]);

                if (items[13].Length == 0)
                    dDryZoneDepth = PointPair.Missing;
                else
                    dDryZoneDepth = Double.Parse(items[13]);

                if (items[14].Length == 0)
                    dSurfaceStorage = PointPair.Missing;
                else
                    dSurfaceStorage = Double.Parse(items[14]);


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
                XDate myXDateMonth = new XDate(iYear, iMonth, iDay);
                Double dDateMonth = myXDateMonth;
                double dYearlyYear = dYear;

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