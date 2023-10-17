using Newtonsoft.Json;
using System.Net;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        List<Currency>? deserialized;
        public Form1()
        {
            InitializeComponent();
            string path = @"..\..\exchange.json";
            var readData = new WebClient().DownloadString("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");

            using (var writeData = new StreamWriter(path))
            {
                writeData.Write(readData);
            }

            var jsonData = File.ReadAllText(path);
            deserialized = JsonConvert.DeserializeObject<List<Currency>>(jsonData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromCurrency = ConvertFrom_combobox.Text.ToString().Substring(0, 3);
            string toCurrency = ConvertTo_combobox.Text.ToString().Substring(0, 3);

            double amount;
            if (!double.TryParse(Amount_textbox.Text, out amount))
            {
                MessageBox.Show("Enter the correct number, without extraneous characters", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("Unexpected error. Try again.", "Error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;

            Converted_label.Text = $"Converted amount: {convertedAmount.ToString("0.00000")} {toCurrency}";
            ConversionRate_label.Text = $"Conversion rate: 1 {fromCurrency} = {exchangeRate} {toCurrency}";
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            double rateFrom;
            if (fromCurrency == "UAH")
                rateFrom = 1;
            else
                rateFrom = deserialized.Where(r => r.cc == fromCurrency).Select(r => r.rate).First();

            double rateTo;
            if(toCurrency == "UAH")
                rateTo = 1; 
            else
                rateTo = deserialized.Where(r => r.cc == toCurrency).Select(r => r.rate).First();

            double exchangeRate = rateFrom / rateTo;
            string exchangeRateString = exchangeRate.ToString("0.00000");

            return double.Parse(exchangeRateString);
        }
    }
}
