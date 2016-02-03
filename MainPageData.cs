using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;

namespace HelloUWP
{
    class MainPageData : INotifyPropertyChanged
    {
        public string _greeting =  "Hello world";

        public string Greeting
        {
            get { return _greeting; }
            set
            {
                if (value == _greeting)
                    return;

                _greeting = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(Greeting)));
            }
        }

        private WeatherModel _currentWeather =
            new WeatherModel();

        public ObservableCollection<WeatherModel> CurrentWeather { get; set; }

        public MainPageData()
        {
            CurrentWeather = new ObservableCollection<WeatherModel>();
        }

        public async void LoadData()
        {
            _currentWeather = await WeatherRepository.GetCurrentWeatherAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
