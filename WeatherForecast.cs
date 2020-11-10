using System;

namespace ReactAPI_4Point2
{

    // In-Class API Practice
    // Add a 'Precipitation" property to the WeatherForecast class
    // Add a random generation of 5 precipitation descriptions to the API method. (Similar to the summaries)
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public int Precipitation { get; set; }

        public string PrecipitationSummary { get; set; }
    }
}
