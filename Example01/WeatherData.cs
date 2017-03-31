using MyExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class WeatherData : EventArgs
    {
        public double Temp { get; set; }

        public double Humidity { get; set; }

        public double Pressure { get; set; }

        private static Random random;

        public WeatherData(double temp, double humidity, double pressure)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        public override bool Equals(object obj)
        {
            if (obj is WeatherData)
            {
                WeatherData other = obj as WeatherData;
                return
                   this.Temp == other.Temp
                && this.Pressure == other.Pressure
                && this.Humidity == other.Humidity;
            }
            else
            {
                return false;
            }
        }

            public static WeatherData Generate()
            {
               if (WeatherData.random == null)   //它是空的嗎?
                 {
                    random = new Random();  //如果他是空的，就會產生1次
                 }

            private double temp = random.NextDouble(15.0, 26.0);

            private double pressure = random.NextDouble(0.95, 1.0);
            private double humidity = random.NextDouble(80, 100);

            return private new WeatherData(temp, pressure, humidity);
           }
    }
}