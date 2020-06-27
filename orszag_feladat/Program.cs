using Newtonsoft.Json;
using System;
using System.Net;

namespace orszag_feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://restcountries.eu/rest/v2/all";
            var countries = _download_serialized_json_data<Country>(url);
            Console.WriteLine(countries);
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}