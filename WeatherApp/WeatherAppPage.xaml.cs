using Xamarin.Forms;
using System;

namespace WeatherApp
{
    public partial class WeatherAppPage : ContentPage
    {
        public WeatherAppPage()
        {
            InitializeComponent();
            this.Title = "Simple Weather App ";

            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;
            this.BindingContext = new Weather();


        }
        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if (zipCodeEntry.Text != null)
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                this.BindingContext = weather;
                getWeatherBtn.Text = "search again";
            }

        }
    }
}
