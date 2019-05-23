using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.Windows.Tools.Controls;

namespace gVl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Home :Window
    {


        public Home()
        {
            InitializeComponent();
            ComputList();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            SfSkinManager.SetVisualStyle(this, VisualStyles.Saffron);
            setPalette(ChartColorPalette.AutumnBrights);
        }

        private void ZGo_Click(object sender, RoutedEventArgs e)
        {
            ComputList();
        }

        private void ComputList()
        {
            bool ret = double.TryParse(z_from.Text, out double startEnd);
            if (!ret)
                return;
            ret = double.TryParse(z_inc.Text, out double inc);
            if (!ret)
                return;
            ret = double.TryParse(z_to.Text, out double upperLim);
            if (!ret)
                return;

            DataSource.StepByage(startEnd, inc, upperLim);

            //KeyValuePair<double, double> abc = new KeyValuePair<double, double>();
            try
            {
                pg.ItemsSource = DataSource.Plot;

                avgChart0.DataContext = DataSource.Plot;
                avgChart1.DataContext = DataSource.Plot;
                avgChart2.DataContext = DataSource.Plot;
                avgChart3.DataContext = DataSource.Plot;
                avgChart4.DataContext = DataSource.Plot;
                avgChart5.DataContext = DataSource.Plot;
                avgChart6.DataContext = DataSource.Plot;
                avgChart7.DataContext = DataSource.Plot;
            }
            catch(Exception e) { }

        }

        private void zSuffron_Click(object sender, RoutedEventArgs e)
        {
            SfSkinManager.SetVisualStyle(this, VisualStyles.Saffron); ComputList();
        }

        private void zLime_Click(object sender, RoutedEventArgs e)
        {
            SfSkinManager.SetVisualStyle(this, VisualStyles.Lime); ComputList();
        }

        private void zMetro_Click(object sender, RoutedEventArgs e)
        {
            SfSkinManager.SetVisualStyle(this, VisualStyles.Metro); ComputList();
        }


        private void zOffice2016Colorful_Click(object sender, RoutedEventArgs e)
        {
            SfSkinManager.SetVisualStyle(this, VisualStyles.Office2016Colorful); ComputList();
        }

        private void zBlend_Click(object sender, RoutedEventArgs e)
        {
            SfSkinManager.SetVisualStyle(this, VisualStyles.Blend); //ComputList();
        }

        private void zPallet_Cliked(object sender, RoutedEventArgs e)
        {
            ButtonAdv btn = (ButtonAdv)sender;
            string bn = btn.Name;

            if(bn == zAutumnBrights.Name)
            {
                setPalette(ChartColorPalette.AutumnBrights);
            }
            else if(bn == zBlueChrome.Name)
            {
                setPalette(ChartColorPalette.BlueChrome);
            }
            else if(bn == zGreenChrome.Name)
            {
                setPalette(ChartColorPalette.GreenChrome);
            }
                 else if (bn == zPurpleChrome.Name)
            {
                setPalette(ChartColorPalette.PurpleChrome);
            }
                else if (bn == zRedChrome.Name)
            {
                setPalette(ChartColorPalette.RedChrome);
            }
                else if(bn == zLightCandy.Name)
            {
                setPalette(ChartColorPalette.LightCandy);
            }
                else if(bn == zMetro.Name)
            {
                setPalette(ChartColorPalette.Metro);
            }
                else if(bn == zPineapple.Name)
            {
                setPalette(ChartColorPalette.Pineapple);
            }
                else if(bn == zSandyBeach.Name)
            {
                setPalette(ChartColorPalette.SandyBeach);
            }
                else if(bn == zTomotoSpectrum.Name)
            {
                setPalette(ChartColorPalette.TomotoSpectrum);
            }
                else if(bn == zElite.Name)
            {
                setPalette(ChartColorPalette.Elite);
            }
                else if(bn == zFloraHues.Name)
            {
                setPalette(ChartColorPalette.FloraHues);
            }

            
        }

        private void setPalette(ChartColorPalette palette)
        {
            avgChart0.Palette = palette;
            avgChart1.Palette = palette;
            avgChart2.Palette = palette;
            avgChart3.Palette = palette;
            avgChart4.Palette = palette;
            avgChart5.Palette = palette;
            avgChart6.Palette = palette;
            avgChart7.Palette = palette;
        }
    }
}
