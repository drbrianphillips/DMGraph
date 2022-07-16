using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ScottPlot;
using ScottPlot.Drawing;
using ScottPlot.Plottable;
using Color = System.Drawing.Color;
using Palette = ScottPlot.Drawing.Palette;

namespace DMGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Properties
        //Plot Elements
        private readonly ScatterPlot MyScatterPlot;
        Crosshair Crosshair;
        private readonly MarkerPlot HighlightedPoint;
        private int LastHighlightedIndex = -1;
        
        ScatterPlot sinPlot, cosPlot;
        VLine vline1, vline2;
        Label xAxis, yAxis, title;
        
        Label statsX, statsY, statsTitle;
        
        public MainWindow()
        {
            InitializeComponent();
            
            //Plot 1 Example Points
            Random rand = new Random(0);
            int pointCount = 20;
            double[] xs = DataGen.Random(rand, pointCount);
            double[] ys = DataGen.Random(rand, pointCount, multiplier: 1_000);
            MyScatterPlot = WpfPlot.Plot.AddScatterPoints(xs, ys);
            Crosshair = WpfPlot.Plot.AddCrosshair(0, 0);
            // Add a red circle we can move around later as a highlighted point indicator
            HighlightedPoint = WpfPlot.Plot.AddPoint(0, 0);
            HighlightedPoint.Color = System.Drawing.Color.Red;
            HighlightedPoint.MarkerSize = 10;
            HighlightedPoint.MarkerLineWidth = 2;
            HighlightedPoint.MarkerShape = ScottPlot.MarkerShape.filledCircle;
            HighlightedPoint.IsVisible = false;
            WpfPlot.Refresh();
            
            //Plot 2 Example Points
            int pointCount2 = 51;
            double[] dataXs = DataGen.Consecutive(pointCount2);
            double[] dataSin = DataGen.Sin(pointCount2);
            double[] dataCos = DataGen.Cos(pointCount2);
            sinPlot = WpfPlot2.Plot.AddScatter(dataXs, dataSin);
            cosPlot = WpfPlot2.Plot.AddScatter(dataXs, dataCos);
            vline1 = WpfPlot2.Plot.AddVerticalLine(0);
            vline2 = WpfPlot2.Plot.AddVerticalLine(50);
            WpfPlot2.Plot.Title("ScottPlot Quickstart");
            WpfPlot2.Plot.XLabel("Horizontal Axis");
            WpfPlot2.Plot.YLabel("Vertical Axis");
            WpfPlot2.Plot.Palette = Palette.ColorblindFriendly;
            sinPlot.LineColor = Color.Blue;
            sinPlot.MarkerShape = MarkerShape.filledSquare;
            sinPlot.MarkerColor = Color.Magenta;
            sinPlot.LineStyle = LineStyle.Dash;
            sinPlot.LineWidth = 3;
            WpfPlot2.Refresh();
            
            //Plot 3 - Statistics
            double[] ys2 = DataGen.NoisyLinear(null, pointCount: 100, noise: 40);
            double[] xs2 = DataGen.Consecutive(ys2.Length);
            double x1 = xs2[0];
            double x2 = xs2[^1];//same as  = xs2[xs2.Length - 1];
            var model = new ScottPlot.Statistics.LinearRegressionLine(xs2,ys2);
            var stats = new ScottPlot.Statistics.BasicStats(ys2);
            var style = ScottPlot.Style.Seaborn;
            WpfPlot3.Plot.Style(style);
            WpfPlot3.Plot.Title("Linear Regression\n" +
                                $"Y = {model.slope:0.0000}x + {model.offset:0.0}\n" +
                                $"(R² = {model.rSquared:0.0000})\n" +
                                $"Mean = {stats.Mean:0.00}   STD = {stats.StDev:0.000}");
            WpfPlot3.Plot.AddScatter(xs2, ys2, lineWidth: 0);
            var statsPlot = WpfPlot3.Plot.AddLine(model.slope, model.offset, (x1, x2), lineWidth: 2);
            statsPlot.LineColor = Color.Blue;
            statsPlot.MarkerShape = MarkerShape.filledSquare;
            statsPlot.MarkerColor = Color.Magenta;
            statsPlot.LineStyle = LineStyle.Dash;
            statsPlot.LineWidth = 3;
            
            WpfPlot3.Plot.SaveFig("stats_linearRegression.png");
            WpfPlot3.Refresh();
            
            //Plot 4 - Bar Plot
            //double[] values = { 27.3, 23.1, 21.2, 16.1, 6.4, 19.2, 18.7, 17.3, 20.3, 13.1 };
            //var bar = WpfPlot4.Plot.AddBar(values);
            //bar.ShowValuesAboveBars = true;
            //bar.ValueFormatter = customFormatter;
            //bar.Font.Size = 8;
            //WpfPlot4.Plot.SetAxisLimits(yMin: 0);
            //WpfPlot4.Plot.SetAxisLimits(yMax: 50);
            //WpfPlot4.Plot.SetAxisLimitsX(-1,12);
            
            var bar1 = WpfPlot4.Plot.AddBar(new double[] { 10, 13, 15 }, new double[] { 1, 5, 9 });
            //bar1.HatchStyle = Drawing.HatchStyle.StripedUpwardDiagonal;
            bar1.HatchStyle = HatchStyle.StripedDownwardDiagonal;
            bar1.FillColor = Color.Gray;
            bar1.FillColorHatch = Color.Black;
            bar1.Label = "Series 1";
            bar1.ShowValuesAboveBars = true;
            bar1.ValueFormatter = customFormatter;
            bar1.Font.Size = 12;
            
            var bar2 = WpfPlot4.Plot.AddBar(new double[] { 14, 15, 9 }, new double[] { 2, 6, 10 });
            bar2.HatchStyle = HatchStyle.StripedWideDownwardDiagonal;
            bar2.FillColor = Color.DodgerBlue;
            bar2.FillColorHatch = Color.DeepSkyBlue;
            bar2.Label = "Series 2";
            bar2.ShowValuesAboveBars = true;
            bar2.ValueFormatter = customFormatter;
            bar2.Font.Size = 12;
            
            // add a legend to display each labeled bar plot
            WpfPlot4.Plot.Legend(location: Alignment.UpperRight);

            // adjust axis limits so there is no padding below the bar graph
            WpfPlot4.Plot.SetAxisLimits(yMin: 0, yMax: 20);

            WpfPlot4.Plot.SaveFig("bar_pattern.png");
            
            WpfPlot4.Refresh();
            
            //Plot 5 - Date X Axis
//            var plt = new ScottPlot.Plot(600, 400);
//
//            // create data sample data
//            DateTime[] myDates = new DateTime[100];
//            for (int i = 0; i < myDates.Length; i++)
//                myDates[i] = new DateTime(1985, 9, 24).AddDays(7 * i);
//
//          // Convert DateTime[] to double[] before plotting
//            double[] xs = myDates.Select(x => x.ToOADate()).ToArray();
//            double[] ys = DataGen.RandomWalk(myDates.Length);
//            plt.AddScatter(xs, ys);
//
//             // Then tell the axis to display tick labels using a time format
//            plt.XAxis.DateTimeFormat(true);
//
//            plt.SaveFig("ticks_dateTime.png");
            
            
            
        }

        Func<double, string> customFormatter = y => $"Y={y:N2}";
        
        private void WpfPlot_OnMouseMove(object sender, MouseEventArgs e)
        {
            int pixelX = (int)e.MouseDevice.GetPosition(WpfPlot).X;
            int pixelY = (int)e.MouseDevice.GetPosition(WpfPlot).Y;

            (double coordinateX, double coordinateY) = WpfPlot.GetMouseCoordinates();

            XPixelLabel.Content = $"{pixelX:0.000}";
            YPixelLabel.Content = $"{pixelY:0.000}";

            XCoordinateLabel.Content = $"{WpfPlot.Plot.GetCoordinateX(pixelX):0.00000000}";
            YCoordinateLabel.Content = $"{WpfPlot.Plot.GetCoordinateY(pixelY):0.00000000}";

            Crosshair.X = coordinateX;
            Crosshair.Y = coordinateY;
            
            // determine point nearest the cursor
            (double mouseCoordX, double mouseCoordY) = WpfPlot.GetMouseCoordinates();
            double xyRatio = WpfPlot.Plot.XAxis.Dims.PxPerUnit / WpfPlot.Plot.YAxis.Dims.PxPerUnit;
            (double pointX, double pointY, int pointIndex) = MyScatterPlot.GetPointNearest(mouseCoordX, mouseCoordY, xyRatio);
            
            // place the highlight over the point of interest
            HighlightedPoint.X = pointX;
            HighlightedPoint.Y = pointY;
            HighlightedPoint.IsVisible = true;
            
            // render if the highlighted point chnaged
            if (LastHighlightedIndex != pointIndex)
            {
                LastHighlightedIndex = pointIndex;
                WpfPlot.Refresh();
            }

            // update the GUI to describe the highlighted point
            double mouseX = e.GetPosition(this).X;
            double mouseY = e.GetPosition(this).Y;
            label1.Content = $"Highlighted point : X = {pointX:N2} , Y = {pointY:N2}";
            

            WpfPlot.Refresh();
        }
        
        private void WpfPlot_MouseEnter(object sender, MouseEventArgs e)
        {
            MouseTrackLabel.Content = "Mouse ENTERED the plot";
            Crosshair.IsVisible = true;
        }

        private void WpfPlot_MouseLeave(object sender, MouseEventArgs e)
        {
            MouseTrackLabel.Content = "Mouse LEFT the plot";
            XPixelLabel.Content = "--";
            YPixelLabel.Content = "--";
            XCoordinateLabel.Content = "--";
            YCoordinateLabel.Content = "--";

            Crosshair.IsVisible = false;
            WpfPlot.Refresh();
        }
        
        private void SinHide(object sender, RoutedEventArgs e)
        {
            if (WpfPlot2 is null) return;
            sinPlot.IsVisible = false;
            WpfPlot2.Refresh();
        }

        private void SinShow(object sender, RoutedEventArgs e)
        {
            if (WpfPlot2 is null) return;
            sinPlot.IsVisible = true;
            WpfPlot2.Refresh();
        }

        private void CosShow(object sender, RoutedEventArgs e)
        {
            if (WpfPlot2 is null) return;
            cosPlot.IsVisible = true;
            WpfPlot2.Refresh();
        }

        private void CosHide(object sender, RoutedEventArgs e)
        {
            if (WpfPlot2 is null) return;
            cosPlot.IsVisible = false;
            WpfPlot2.Refresh();
        }

        private void LinesShow(object sender, RoutedEventArgs e)
        {
            if (WpfPlot2 is null) return;
            vline1.IsVisible = true;
            vline2.IsVisible = true;
            WpfPlot2.Refresh();
        }

        private void LinesHide(object sender, RoutedEventArgs e)
        {
            if (WpfPlot2 is null) return;
            vline1.IsVisible = false;
            vline2.IsVisible = false;
            WpfPlot2.Refresh();
        }
        
        
        
        
        
    }//Close Class
}//Close NameSpace
