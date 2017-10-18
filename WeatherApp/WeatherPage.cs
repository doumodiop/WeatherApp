using System;

using Xamarin.Forms;

namespace WeatherApp
{
    public class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

