using System.Net.Http;

namespace Calculator_Web.Models
{
    public class HitungServiceModel
    {
        public string Url { get; set; } = @"http://localhost:2019";

        public double Penjumlahan(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Penjumlahan/{nilai_1}/{nilai_2}").Result;
                //var hasil = JsonConvert.DeserializeObject<HitungModel>(data.ToString());
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Pengurangan(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Pengurangan/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Perkalian(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Perkalian/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }

        public double Pembagian(double nilai_1, double nilai_2)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetStringAsync(Url + $"Pembagian/{nilai_1}/{nilai_2}").Result;
                double.TryParse(data, out double hasil);

                return hasil;
            }
        }
    }
}
