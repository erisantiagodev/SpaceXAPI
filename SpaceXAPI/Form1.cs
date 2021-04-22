using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceXAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void flightSearch_Click(object sender, EventArgs e)
        {
            try
            {
                await PrintFlightData();
            }

            catch
            {
                flightData.Text = "Loading...";
            }
        }

        public async Task PrintFlightData()
        {
            var apiWrapper = new APIWrapper();
            await apiWrapper.GetFlightObject();

            int userNumber = Convert.ToInt32(flightNumber.Text);
            await apiWrapper.GetFlightData(apiWrapper.response, userNumber);

            try
            {
                flightData.Text = apiWrapper.allFlightData;
            }

            catch
            {
                MessageBox.Show("Please load the flight data.");
            }

        }

        public async void next_Click(object sender, EventArgs e)
        {
            var apiWrapper = new APIWrapper();
            int userNumber = Convert.ToInt32(flightNumber.Text);
            await apiWrapper.GetFlightObject();

            userNumber++;

            apiWrapper.GetNextFlightData(apiWrapper.response, userNumber);
            flightNumber.Text = Convert.ToString(userNumber);

            try
            {
                flightData.Text = apiWrapper.allFlightData;
            }

            catch
            {
                MessageBox.Show("Please load the flight data.");
            }
        }

        public async void previous_Click(object sender, EventArgs e)
        {
            var apiWrapper = new APIWrapper();
            int userNumber = Convert.ToInt32(flightNumber.Text);
            await apiWrapper.GetFlightObject();

            userNumber--;

            apiWrapper.GetNextFlightData(apiWrapper.response, userNumber);
            flightNumber.Text = Convert.ToString(userNumber);

            try
            {
                flightData.Text = apiWrapper.allFlightData;
            }

            catch
            {
                MessageBox.Show("Please load the flight data.");
            }
        }
    }
}
