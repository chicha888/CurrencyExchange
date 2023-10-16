using Newtonsoft.Json;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        List<Currency>? deserialized;
        public Form1()
        {
            InitializeComponent();
            string path = @"D:\VS_Repos\CurrencyExchange\CurrencyExchange\exchange.json";
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
                MessageBox.Show("Введіть правильне число, без сторонніх символів", "Error", MessageBoxButtons.OK);
                return;
            }

            double exchangeRate;
            try
            {
                exchangeRate = GetExchangeRate(fromCurrency, toCurrency);
            }
            catch
            {
                MessageBox.Show("Непередбачувана помилка. Спробуйте ще раз", "Error", MessageBoxButtons.OK);
                return;
            }

            double convertedAmount = amount * exchangeRate;

            Converted_label.Text = $"Converted amount: {convertedAmount} {toCurrency}";
            ConversionRate_label.Text = $"Conversion rate: 1 {fromCurrency} = {exchangeRate} {toCurrency}";
        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            var rateFrom = deserialized.Where(r => r.cc == fromCurrency).Select(r => r.rate).First();
            var rateTo = deserialized.Where(r => r.cc == toCurrency).Select(r => r.rate).First();

            double exchangeRate = rateFrom / rateTo;
            string exchangeRateString = exchangeRate.ToString("0.00000");

            return double.Parse(exchangeRateString);
        }
    }
}