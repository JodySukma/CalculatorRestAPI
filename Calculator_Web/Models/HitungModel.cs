
namespace Calculator_Web.Models
{
    public class HitungModel
    {
        public double Angka_1 { get; set; } = 0;
        public double Angka_2 { get; set; } = 0;

        public string Operasi { get; set; } = "+";

        public double Hasil
        {
            get
            {
                if (Operasi == "+")
                    return Angka_1 + Angka_2;
                else if (Operasi == "-")
                    return Angka_1 - Angka_2;
                else if (Operasi == "*")
                    return Angka_1 * Angka_2;
                else
                    return Angka_1 / Angka_2;
            }
        }
    }
}
