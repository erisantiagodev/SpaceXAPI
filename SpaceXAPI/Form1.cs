using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceXAPI
{
    public partial class Form1 : Form
    {
        APIWrapper apiWrapper = new APIWrapper();
        public Form1()
        {
            InitializeComponent();
        }

        private async void flightSearch_Click(object sender, EventArgs e)
        {
            await PrintFlightData();
        }

        public async Task PrintFlightData()
        {
            try
            {
                await apiWrapper.GetFlightObject();
                GetAndPrintData(Convert.ToInt32(flightNumber.Text));
                apiWrapper.GetFlightData(apiWrapper.response, Convert.ToInt32(flightNumber.Text));
            }

            catch
            {
                int flight = Convert.ToInt32(flightNumber.Text);
                if (flight < 0 || flight == 0)
                { MessageBox.Show("Please enter a number greater than zero.", "Error Info"); }
                else if (flight > apiWrapper.numberOfFlights) { MessageBox.Show($"Please enter a number smaller than {apiWrapper.numberOfFlights + 1}.", "Error Info"); }
            }
        }

        public void GetAndPrintData(int userNumber)
        {
            apiWrapper.GetFlightData(apiWrapper.response, userNumber);
            flightNumber.Text = Convert.ToString(userNumber);
            flightData.Text = apiWrapper.allFlightData;
        }

        public async void next_Click(object sender, EventArgs e)
        {
            try
            {
                int userNumber = Convert.ToInt32(flightNumber.Text);
                await apiWrapper.GetFlightObject();
                apiWrapper.GetFlightData(apiWrapper.response, userNumber);

                userNumber++;

                GetAndPrintData(userNumber);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}. Please enter a number smaller than {apiWrapper.numberOfFlights + 1}.", "Error Info:");
            }
        }

        public async void previous_Click(object sender, EventArgs e)
        {
            try
            {
                int userNumber = Convert.ToInt32(flightNumber.Text);
                await apiWrapper.GetFlightObject();

                userNumber--;

                GetAndPrintData(userNumber);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}. Please enter a number greater than zero.", "Error Info:");
            }
        }
    }
}
