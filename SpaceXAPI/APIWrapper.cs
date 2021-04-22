using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SpaceXAPI
{
    public class APIWrapper
    {
        public string url;
        public string response;
        public string rocket;
        public string utcFlight;
        public string name;
        public string date;
        public string details;
        public string flightNumber;
        public string allFlightData;

        HttpClient ApiClient = new HttpClient();
        JArray jsonObject = new JArray();
        public APIWrapper()
        {

        }

        public async Task GetFlightObject()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                url = $"https://api.spacexdata.com/v4/launches/past";

                response = await ApiClient.GetStringAsync(url);
            }

            catch
            {
                
            }
        }

        public async Task GetFlightData(string flightObject, int userFlight)
        {
            jsonObject = JArray.Parse(flightObject);

            int correctedFlightNumber = userFlight - 1;

            flightNumber = jsonObject[correctedFlightNumber]["flight_number"].Value<string>();
            name = jsonObject[correctedFlightNumber]["name"].Value<string>();
            date = jsonObject[correctedFlightNumber]["date_utc"].Value<string>();
            details = jsonObject[correctedFlightNumber]["details"].Value<string>();
            rocket = jsonObject[correctedFlightNumber]["rocket"].Value<string>();

            allFlightData = $"Flight Number: {flightNumber}. Name of rocket: {name}. Time of launch: {date} " +
                $"Details: {details}. Rocket ID: {rocket}";
        }

        public async Task GetNextFlightData(string flightObject, int userFlight)
        {
            JArray jsonObject = JArray.Parse(flightObject);

            flightNumber = jsonObject[userFlight - 1]["flight_number"].Value<string>();
            name = jsonObject[userFlight - 1]["name"].Value<string>();
            date = jsonObject[userFlight - 1]["date_utc"].Value<string>();
            details = jsonObject[userFlight - 1]["details"].Value<string>();
            rocket = jsonObject[userFlight - 1]["rocket"].Value<string>();

            allFlightData = $"Flight Number: {flightNumber}. Name of rocket: {name}. Time of launch: {date} " +
                $"Details: {details}. Rocket ID: {rocket}";
        }

        public async Task GetPreviousFlightData(string flightObject, int userFlight)
        {
            JArray jsonObject = JArray.Parse(flightObject);

            flightNumber = jsonObject[userFlight]["flight_number"].Value<string>();
            name = jsonObject[userFlight]["name"].Value<string>();
            date = jsonObject[userFlight]["date_utc"].Value<string>();
            details = jsonObject[userFlight]["details"].Value<string>();
            rocket = jsonObject[userFlight]["rocket"].Value<string>();

            allFlightData = $"Flight Number: {flightNumber}. Name of rocket: {name}. Time of launch: {date} " +
                $"Details: {details}. Rocket ID: {rocket}";
        }
    }
}
//https://stackoverflow.com/questions/31536082/how-to-return-a-string-from-async
//https://stackoverflow.com/questions/24496816/how-to-search-json-string-for-fields