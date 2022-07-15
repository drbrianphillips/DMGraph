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
using ScottPlot.Plottable;
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
            WpfPlot2.Refresh();
        }

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
