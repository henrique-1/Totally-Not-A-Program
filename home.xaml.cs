using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace Totally_Not_a_Program
{
    /// <summary>
    /// Interação lógica para home.xam
    /// </summary>
    public partial class home : UserControl
    {
        DispatcherTimer Timer99 = new DispatcherTimer();

        public home()
        {
            InitializeComponent();
            Timer99.Tick += Timer99_Tick; // don't freeze the ui
            Timer99.Interval = new TimeSpan(0, 0, 0, 0, 1024);
            Timer99.IsEnabled = true;
        }

        private void UsrctrHome_Loaded(object sender, RoutedEventArgs e)
        {

        }

        //ProcessorTime
        public PerformanceCounter myProcessorCounter =
                new PerformanceCounter("Processor", "% Processor Time", "_Total");
            public Int32 j = 0;

        //RAMTime
            public PerformanceCounter myRAMCounter =
                new PerformanceCounter("Memory", "% Committed Bytes In Use", null);
            public Int32 k = 0;

        //HDDTime
            public PerformanceCounter myHDDCounter =
                new PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total");
            public Int32 l = 0;


        public void Timer99_Tick(System.Object sender, System.EventArgs e)
        {
            l = Convert.ToInt32(myHDDCounter.NextValue());
            k = Convert.ToInt32(myRAMCounter.NextValue());
            j = Convert.ToInt32(myProcessorCounter.NextValue());


            if (j > 100)
            {
                j = 100;
            }

            if (k > 100)
            {
                k = 100;
            }

            if (l > 100)
            {
                l = 100;
            }

            setHDDUsage(l);
            setCPUUsage(j);
            setRAMUsage(k);
        }

        public void setCPUUsage(int percentage)
        {
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#2195F2");

            CPUChart.Series = new SeriesCollection();

            //Series - Each Slice of the pie. 
            PieSeries CPUUsage2 = new PieSeries();
            CPUUsage2.Values = new ChartValues<double> { 100 - percentage };
            CPUUsage2.DataLabels = false;
            CPUUsage2.Opacity = 1;
            CPUUsage2.Fill = Brushes.Transparent;
            CPUUsage2.Stroke = Brushes.Transparent;
            //CPUUsage2.LabelPoint = labelPoint;
            CPUChart.Series.Add(CPUUsage2);

            //Series - Each Slice of the pie. 
            PieSeries CPUUsage = new PieSeries();
            CPUUsage.Values = new ChartValues<double> { percentage };
            CPUUsage.DataLabels = false;
            CPUUsage.Opacity = 0;
            CPUUsage.Fill = brush;
            CPUUsage.Stroke = Brushes.White;
            //CPUUsage.LabelPoint = labelPoint;
            CPUChart.Series.Add(CPUUsage);

            /*CPUUsage2.Values = new ChartValues<double> { percentage };
            CPUUsage.Values = new ChartValues<double> { 100 - percentage };*/
            lblCPUUsageLabel.Content = percentage + "%";
        }

        public void setRAMUsage(int percentage)
        {
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FFF2AF21");

            RAMChart.Series = new SeriesCollection();

            //Series - Each Slice of the pie. 
            PieSeries RAMUsage2 = new PieSeries();
            RAMUsage2.Values = new ChartValues<double> { 100 - percentage };
            RAMUsage2.DataLabels = false;
            RAMUsage2.Opacity = 1;
            RAMUsage2.Fill = Brushes.Transparent;
            RAMUsage2.Stroke = Brushes.Transparent;
            //CPUUsage2.LabelPoint = labelPoint;
            RAMChart.Series.Add(RAMUsage2);

            //Series - Each Slice of the pie. 
            PieSeries RAMUsage = new PieSeries();
            RAMUsage.Values = new ChartValues<double> { percentage };
            RAMUsage.DataLabels = false;
            RAMUsage.Opacity = 0;
            RAMUsage.Fill = brush;
            RAMUsage.Stroke = Brushes.White;
            //CPUUsage.LabelPoint = labelPoint;
            RAMChart.Series.Add(RAMUsage);

            //RAMUsage2.Values = new ChartValues<double> { percentage };
            //RAMUsage.Values = new ChartValues<double> { 100 - percentage };
            lblRAMUsageLabel.Content = percentage + "%";
        }

        public void setHDDUsage(int percentage)
        {
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF21F22A");

            HDDChart.Series = new SeriesCollection();

            //Series - Each Slice of the pie. 
            PieSeries HDDUsage2 = new PieSeries();
            HDDUsage2.Values = new ChartValues<double> { 100 - percentage };
            HDDUsage2.DataLabels = false;
            HDDUsage2.Opacity = 1;
            HDDUsage2.Fill = Brushes.Transparent;
            HDDUsage2.Stroke = Brushes.Transparent;
            //CPUUsage2.LabelPoint = labelPoint;
            HDDChart.Series.Add(HDDUsage2);

            //Series - Each Slice of the pie. 
            PieSeries HDDUsage = new PieSeries();
            HDDUsage.Values = new ChartValues<double> { percentage };
            HDDUsage.DataLabels = false;
            HDDUsage.Opacity = 0;
            HDDUsage.Fill = brush;
            HDDUsage.Stroke = Brushes.White;
            //CPUUsage.LabelPoint = labelPoint;
            HDDChart.Series.Add(HDDUsage);

            //HDDUsage2.Values = new ChartValues<double> { percentage };
            //HDDUsage.Values = new ChartValues<double> { 100 - percentage };
            lblHDDUsageLabel.Content = percentage + "%";
        }
    }
}
