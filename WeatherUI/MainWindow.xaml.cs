using ClassLibrary;
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

namespace WeatherUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btn_Find_Click(object sender, RoutedEventArgs e)
        {
            await WeatherAPI.GetWeather(inputLocation.Text);
            txtCity.Text = WeatherAPI.cityName;
            txtAir.Text = WeatherAPI.cityAir;
            txtTemp.Text = WeatherAPI.cityTemperature;
            txtDescription.Text = WeatherAPI.cityDescription;
            txtWind.Text = WeatherAPI.cityWind;
        }
    }
}
