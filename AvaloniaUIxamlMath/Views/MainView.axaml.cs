using Avalonia.Controls;
using Avalonia.Interactivity;
using ScottPlot.Avalonia;
using System;
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
            avaPlot1.Plot.XAxis2.Label("Speed versus distance");
        }
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        Debug.WriteLine($"Click! Celsius={celsius.Text}");

        if (Double.TryParse(celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            fahrenheit.Text = F.ToString("0.0");
        }
        else
        {
            celsius.Text = "0";
            fahrenheit.Text = "0";
        }
    }
}
