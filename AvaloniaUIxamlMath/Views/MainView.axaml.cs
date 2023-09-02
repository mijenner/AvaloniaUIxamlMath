using Avalonia.Controls;
using Avalonia.Interactivity;
using ScottPlot.Avalonia;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace AvaloniaUIxamlMath.Views;

public partial class MainView : UserControl
{
    double[] dataX = new double[] { 1, 2, 3, 4, 5 };
    double[] dataY = new double[] { 1, 4, 9, 16, 25 };
    AvaPlot avaPlot1;

    public MainView()
    {
        InitializeComponent();

        avaPlot1 = this.Find<AvaPlot>("AvaPlot1");
        if (avaPlot1 != null)
        {
            avaPlot1.Plot.AddScatter(dataX, dataY);
            avaPlot1.Refresh();
            avaPlot1.Plot.XAxis.Label("Distance [m]");
            avaPlot1.Plot.YAxis.Label("Speed [m/s]");
            avaPlot1.Plot.XAxis2.Label("Speed versus distance with air resistance");
        }

    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Click!");
    }
}
