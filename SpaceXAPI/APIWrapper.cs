using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

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
                MessageBox.Show("Object not found.");
            }
        }

        public void GetFlightData(string flightObject, int userFlight)
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
    }
}
