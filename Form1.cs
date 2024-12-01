using Newtonsoft.Json;

namespace Pogoda_1
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> weatherDescriptions = new Dictionary<int, string>
        {
            { 0, "Brak chmur" },
            { 1, "Nieznaczne zachmurzenie" },
            { 2, "Zachmurzenie" },
            { 3, "Zachmurzenie ca�kowite" },
            { 45, "Mg�a" },
            { 48, "Mg�a" },
            { 51, "S�aby deszcz" },
            { 53, "Umiarkowany deszcz" },
            { 55, "Silny deszcz" },
            { 61, "S�aby deszcz" },
            { 63, "Umiarkowany deszcz" },
            { 65, "Silny deszcz" },
            { 80, "Deszcz" },
            { 95, "Burza" },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,weather_code,surface_pressure,wind_speed_10m&hourly=temperature_2m";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            //richTextBox1.Text = json;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            temperatureTextBox.Text = apiResponse.current.temperature_2m.ToString();
            temperatureTextBox.Text += " ";
            temperatureTextBox.Text += apiResponse.current_units.temperature_2m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,weather_code,surface_pressure,wind_speed_10m&hourly=temperature_2m";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            humidityTextBox.Text = apiResponse.current.relative_humidity_2m.ToString();
            humidityTextBox.Text += " ";
            humidityTextBox.Text += apiResponse.current_units.relative_humidity_2m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,weather_code,surface_pressure,wind_speed_10m&hourly=temperature_2m";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            if (weatherDescriptions.TryGetValue(apiResponse.current.weather_code, out string description))
            {
                weatherTextBox.Text = description;
            }
            else
            {
                weatherTextBox.Text = "Nieznany kod pogody";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,weather_code,surface_pressure,wind_speed_10m&hourly=temperature_2m";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            windSpeedTextBox.Text = apiResponse.current.wind_speed_10m.ToString() + " " + "m/s";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&current=temperature_2m,relative_humidity_2m,weather_code,surface_pressure,wind_speed_10m&hourly=temperature_2m";
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            APIResponse apiResponse = JsonConvert.DeserializeObject<APIResponse>(json);
            if (apiResponse.current != null && apiResponse.current.wind_direction_10m != null)
            {
                int windDirection = apiResponse.current.wind_direction_10m;
                string direction = GetWindDirection(windDirection);
                windDirectionTextBox.Text = direction;
            }
            else
            {
                windDirectionTextBox.Text = "Brak danych o kierunku wiatru";
            }
        }

        private string GetWindDirection(int degrees)
        {
            if (degrees >= 337.5 || degrees < 22.5) return "P�noc";
            if (degrees >= 22.5 && degrees < 67.5) return "P�nocny Wsch�d";
            if (degrees >= 67.5 && degrees < 112.5) return "Wsch�d";
            if (degrees >= 112.5 && degrees < 157.5) return "Po�udniowy Wsch�d";
            if (degrees >= 157.5 && degrees < 202.5) return "Po�udnie";
            if (degrees >= 202.5 && degrees < 247.5) return "Po�udniowy Zach�d";
            if (degrees >= 247.5 && degrees < 292.5) return "Zach�d";
            if (degrees >= 292.5 && degrees < 337.5) return "P�nocny Zach�d";
            return "Nieznany kierunek"; 
        }
    }

}
