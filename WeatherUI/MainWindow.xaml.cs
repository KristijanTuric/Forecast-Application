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
                cellTwo.Text = WeatherAPI.cityName + "\n" + WeatherAPI.cityDescription;
                cellOne.Text = WeatherAPI.cityAir;
                cellThree.Text = WeatherAPI.cityWind;

            } catch(Exception)
            {
                cellTwo.Text = "This city was not found";
            }
            
        }

        private async void btn_Forecast_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await WeatherAPI.GetForecast(inputLocation.Text);
                cellOne.Text = WeatherAPI.dayOne;
                cellTwo.Text = WeatherAPI.otherDays[0];
                cellThree.Text = WeatherAPI.otherDays[1];
                cellFour.Text = WeatherAPI.otherDays[2];
                cellFive.Text = WeatherAPI.otherDays[3];
                cellSix.Text = WeatherAPI.otherDays[4];


            } catch(Exception)
            {
                cellTwo.Text = "This city was not found";
            }
            
        }
    }
}
