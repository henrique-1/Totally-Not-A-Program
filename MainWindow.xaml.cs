using LiveCharts;
using Microsoft.Win32;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Totally_Not_a_Program
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void MainForm_Loaded(object sender, RoutedEventArgs e)
        {
            GdrBtnHome_PreviewMouseLeftButtonDown(null, null);

            if (File.Exists("C:/Program Files/dotnet/dotnet.exe"))
            {
                
            } 
            else
            {
                System.Windows.Forms.MessageBox.Show("Você precisa ter o .NET Core instalado para executar este programa.");
                System.Diagnostics.Process.Start("https://dotnet.microsoft.com/download");
                Process.GetCurrentProcess().Kill();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BtnHelp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void toggleNav()
        {
            gdrBtnHome.Background = Brushes.Transparent;
            gdrSpeedTestBtn.Background = Brushes.Transparent;
            gdrPasswordBtn.Background = Brushes.Transparent;
            usrCtrHome.IsEnabled = false;
            usrCtrSpeedTest.IsEnabled = false;
            usrCtrHome.Visibility = Visibility.Hidden;
            usrCtrSpeedTest.Visibility = Visibility.Hidden;
        }

        private void GdrBtnHome_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            toggleNav();
            usrCtrHome.IsEnabled = true;
            usrCtrHome.Visibility = Visibility.Visible;
            gdrBtnHome.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#D9FDAD"));
        }

        private void GdrSpeedTestBtn_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            toggleNav();
            usrCtrSpeedTest.IsEnabled = true;
            usrCtrSpeedTest.Visibility = Visibility.Visible;
            gdrSpeedTestBtn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#D9FDAD"));
        }

        private void GdrPasswordBtn_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            toggleNav();
            //MainHomeGrid.IsEnabled = true;
            gdrPasswordBtn.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#D9FDAD"));
        }

        private void GdrTopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void BtnMinimize_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ScrbrScroll_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
