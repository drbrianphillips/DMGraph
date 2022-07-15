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
        Crosshair Crosshair;
        ScatterPlot sinPlot, cosPlot;
        VLine vline1, vline2;
        Label xAxis, yAxis, title;
        
        public MainWindow()
        {
            InitializeComponent();
            //Plot 1 Example Points
            WpfPlot.Plot.AddSignal(DataGen.RandomWalk(null, 100));
            Crosshair = WpfPlot.Plot.AddCrosshair(0, 0);
            WpfPlot.Refresh();
            //Plot 2 Example Points
            int pointCount = 51;
            double[] dataXs = DataGen.Consecutive(pointCount);
            double[] dataSin = DataGen.Sin(pointCount);
            double[] dataCos = DataGen.Cos(pointCount);
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
