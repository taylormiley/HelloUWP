using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUWP
{
    public class WeatherModel
    {
        public string Name { get; set; }
        public int Temperature { get; set; }


        public WeatherModel(string name, int temp)
        {
            Name = name;
            Temperature = temp;
        }

        public WeatherModel() { }
    }
}
