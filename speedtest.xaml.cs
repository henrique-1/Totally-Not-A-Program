using LiveCharts;
using SpeedTest;
using SpeedTest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;

namespace Totally_Not_a_Program
{
    /// <summary>
    /// Interação lógica para speedtest.xam
    /// </summary>
    public partial class speedtest : UserControl
    {
        private double _value;

        public speedtest()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string externalip = new WebClient().DownloadString("http://icanhazip.com");
                lblIp.Text = externalip;

                Value = 0;
                DataContext = this;
            }
            catch
            {
                string message = "Você está sem conexão com a internet no momento";
                string caption = "Sem conexão com a Internet";
                MessageBoxButton buttons = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Error;
                MessageBox.Show(message, caption, buttons, icon);
            }
            
        }

        public double Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            lblDownloadMbps.Text = "";
            lblUploadMbps.Text = "";
            lblHost.Text = "";
            lblPingMS.Text = "";

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                Process p = new Process();
                p.StartInfo.FileName = @"C:\Program Files\dotnet\dotnet.exe";
                p.StartInfo.Arguments += "\"" + AppDomain.CurrentDomain.BaseDirectory + "SpeedTest.Client.dll\"";

                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;

                p.Start();

                bool found = false;

                while (!p.StandardOutput.EndOfStream)
                {
                    string lineNow = p.StandardOutput.ReadLine();
                    Console.WriteLine(lineNow);

                    if (lineNow.StartsWith("Download speed"))
                    {
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            lblDownloadMbps.Text = lineNow.Split(":"[0])[1].Replace("Mbps", "");
                            gdrSpeedTestAngular.Value =  double.Parse(lblDownloadMbps.Text);
                        }));
                    }

                    if (lineNow.StartsWith("Upload speed"))
                    {
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            lblUploadMbps.Text = lineNow.Split(":"[0])[1].Replace("Mbps", ""); ;
                            gdrSpeedTestAngular.Value = double.Parse(lblUploadMbps.Text);
                        }));
                    }

                    if (lineNow.StartsWith("Best server by latency"))
                    {
                        found = true;
                    }

                    if (lineNow.StartsWith("Hosted by") && found)
                    {
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            string[] separate = lineNow.Split(","[0]);

                            lblHost.Text = separate[0].Substring(10).Split("("[0])[0];
                            lblPingMS.Text = separate[2].Split(":"[0])[1].Replace("ms", "");
                            gdrSpeedTestAngular.Value = double.Parse(lblPingMS.Text);
                        }));
                    }

                    if (lineNow.Contains("Press a key"))
                    {
                        p.Kill();
                        Thread.Sleep(1000);
                        Application.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            gdrSpeedTestAngular.Value = 0;
                        }));
                        break;
                    }
                }
            }).Start();
        }
    }
}
