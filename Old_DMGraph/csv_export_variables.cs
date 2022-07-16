using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;//Allows file reading and writing

namespace Graphing_DRAINMOD
{
    public partial class csv_export_variables : Form
    {
        public csv_export_variables()
        {
            InitializeComponent();
        }

        private void csv_export_variables_Load(object sender, EventArgs e)
        {

            methodLoadOptions();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
             using (StreamWriter sw3 = new StreamWriter("Graphing/CSV_Options.dat"))
              {
                  sw3.WriteLine("Cancel");
                  sw3.WriteLine("Daily---------------");
                  sw3.WriteLine(Convert.ToString(this.checkPreWT.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkDryZoneDepth.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkSurfaceStorage.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkRainfall.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkInfiltration.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkEvaporation.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkDrainage.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkSurfaceRunoff.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkWaterLoss.Checked));
                  sw3.WriteLine("Monthly---------------");
                  sw3.WriteLine(Convert.ToString(this.checkMonthlyRainfall.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkMonthlyInfiltration.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkMonthlyEvaporation.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkMonthlyDrainage.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkMonthlyRunoff.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkMonthlyWaterLoss.Checked));
                  sw3.WriteLine("Yearly---------------");
                  sw3.WriteLine(Convert.ToString(this.checkYearlyRainfall.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkYearlyInfiltration.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkYearlyEvaporation.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkYearlyDrainage.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkYearlyRunoff.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkYearlyWaterLoss.Checked));
                  sw3.WriteLine("Cumulative---------------");
                  sw3.WriteLine(Convert.ToString(this.checkCumulativeRainfall.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkCumulativeInfiltration.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkCumulativeExvaporation.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkCumulativeDrainage.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkCumulativeRunoff.Checked));
                  sw3.WriteLine(Convert.ToString(this.checkCumulativeWaterLoss.Checked));


                  //Clean up and close file
                  sw3.Flush();
                  sw3.Close();

              }//close writer

            this.Close();

        } //Close Click method

        private void buttonOK_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw4 = new StreamWriter("Graphing/CSV_Options.dat"))
            {
                sw4.WriteLine("OK");
                sw4.WriteLine("Daily---------------");
                sw4.WriteLine(Convert.ToString(this.checkPreWT.Checked));
                sw4.WriteLine(Convert.ToString(this.checkDryZoneDepth.Checked));
                sw4.WriteLine(Convert.ToString(this.checkSurfaceStorage.Checked));
                sw4.WriteLine(Convert.ToString(this.checkRainfall.Checked));
                sw4.WriteLine(Convert.ToString(this.checkInfiltration.Checked));
                sw4.WriteLine(Convert.ToString(this.checkEvaporation.Checked));
                sw4.WriteLine(Convert.ToString(this.checkDrainage.Checked));
                sw4.WriteLine(Convert.ToString(this.checkSurfaceRunoff.Checked));
                sw4.WriteLine(Convert.ToString(this.checkWaterLoss.Checked));
                sw4.WriteLine("Monthly---------------");
                sw4.WriteLine(Convert.ToString(this.checkMonthlyRainfall.Checked));
                sw4.WriteLine(Convert.ToString(this.checkMonthlyInfiltration.Checked));
                sw4.WriteLine(Convert.ToString(this.checkMonthlyEvaporation.Checked));
                sw4.WriteLine(Convert.ToString(this.checkMonthlyDrainage.Checked));
                sw4.WriteLine(Convert.ToString(this.checkMonthlyRunoff.Checked));
                sw4.WriteLine(Convert.ToString(this.checkMonthlyWaterLoss.Checked));
                sw4.WriteLine("Yearly---------------");
                sw4.WriteLine(Convert.ToString(this.checkYearlyRainfall.Checked));
                sw4.WriteLine(Convert.ToString(this.checkYearlyInfiltration.Checked));
                sw4.WriteLine(Convert.ToString(this.checkYearlyEvaporation.Checked));
                sw4.WriteLine(Convert.ToString(this.checkYearlyDrainage.Checked));
                sw4.WriteLine(Convert.ToString(this.checkYearlyRunoff.Checked));
                sw4.WriteLine(Convert.ToString(this.checkYearlyWaterLoss.Checked));
                sw4.WriteLine("Cumulative---------------");
                sw4.WriteLine(Convert.ToString(this.checkCumulativeRainfall.Checked));
                sw4.WriteLine(Convert.ToString(this.checkCumulativeInfiltration.Checked));
                sw4.WriteLine(Convert.ToString(this.checkCumulativeExvaporation.Checked));
                sw4.WriteLine(Convert.ToString(this.checkCumulativeDrainage.Checked));
                sw4.WriteLine(Convert.ToString(this.checkCumulativeRunoff.Checked));
                sw4.WriteLine(Convert.ToString(this.checkCumulativeWaterLoss.Checked));


                //Clean up and close file
                sw4.Flush();
                sw4.Close();

            }//close writer

            this.Close();
        } //Close Click method

        private void methodLoadOptions()
        {
            //Instantiate reader
            StreamReader stmReader101 = new StreamReader("Graphing/CSV_Options.dat");

            stmReader101.ReadLine();
            stmReader101.ReadLine();   
            this.checkPreWT.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkDryZoneDepth.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkSurfaceStorage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkRainfall.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkInfiltration.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkEvaporation.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkDrainage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkSurfaceRunoff.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkWaterLoss.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            stmReader101.ReadLine();
            this.checkMonthlyRainfall.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkMonthlyInfiltration.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkMonthlyEvaporation.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkMonthlyDrainage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkMonthlyRunoff.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkMonthlyWaterLoss.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            stmReader101.ReadLine();
            this.checkYearlyRainfall.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkYearlyInfiltration.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkYearlyEvaporation.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkYearlyDrainage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkYearlyRunoff.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkYearlyWaterLoss.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            stmReader101.ReadLine();
            this.checkCumulativeRainfall.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkCumulativeInfiltration.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkCumulativeExvaporation.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkCumulativeDrainage.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkCumulativeRunoff.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            this.checkCumulativeWaterLoss.Checked = Convert.ToBoolean(stmReader101.ReadLine());
            
            
            //Clean up and close file
            stmReader101.Close();
            stmReader101.Dispose();


        }//Close Method 




    }   //Close partial class
} //Close namespace
