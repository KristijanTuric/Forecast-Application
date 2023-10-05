using ClassLibrary;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
            // If we can't find the city or the user doesn't enter anything or enters wrong name
            // we catch the exception and display the text
            try
            {
                await WeatherAPI.GetWeather(inputLocation.Text);
                txtCity.Text = WeatherAPI.cityName + "\n" + WeatherAPI.cityDescription;
                txtAir.Text = WeatherAPI.cityAir;
                txtWind.Text = WeatherAPI.cityWind;

                await WeatherAPI.GetForecast(inputLocation.Text);

            } catch(Exception)
            {
                txtCity.Text = "This city was not found";
            }
            
        }
    }
}
