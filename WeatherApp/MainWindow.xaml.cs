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
using WeatherApp.OpenWeatherMap;
using WeatherApp.OpenWeatherMap.models;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GetData data = new GetData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private double ChangeToCelcius(double kelvin)
        {
            var clec = kelvin - 273.15;
            return Math.Round(clec, 1);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {            
            var response = await data.GetForecastForCity(textBoxCity.Text);
            if (response!=null)
                textBlockResponse.Text = ChangeToCelcius(response.Main.Temp).ToString() + " C";
            else
                textBlockResponse.Text = $"Brak danych na temat miejscowosci: {textBoxCity.Text}";
        }
    }
}
