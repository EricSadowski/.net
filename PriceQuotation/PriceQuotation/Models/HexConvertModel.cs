using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class HexConvertModel
    {
        [Required(ErrorMessage =
                "Please enter decimal to convert to hex")]
        [Range(1, 1000000000, ErrorMessage =
                "amount must be between 1 and a billion")]
        public decimal? Input { get; set; }

        public string? CalculateHex()
        {
            if (Input <= 0)
            {
                return null;
            }

            string hex = string.Empty;
            int intValue = (int)Math.Floor((decimal)Input);

            while (intValue > 0)
            {
                int remainder = intValue % 16;

                if (remainder < 10)
                {
                    hex = remainder.ToString() + hex;
                }
                else
                {
                    char hexDigit = (char)('A' + remainder - 10);
                    hex = hexDigit + hex;
                }

                intValue /= 16;
            }

            return hex;
        }

    }
}
