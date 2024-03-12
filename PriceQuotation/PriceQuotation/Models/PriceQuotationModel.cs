using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage =
                "Please enter subtotal price")]
        [Range(1, 500, ErrorMessage =
                "Monthly investment amount must be between 1 and 500.")]
        public decimal? Subtotal { get; set; }
        [Required(ErrorMessage =
        "Please enter a discount percent")]
        [Range(0, 100, ErrorMessage =
        "Discount Percent rate must be between 1 and 100")]
        public decimal? DiscountPercent { get; set; }

        public decimal? CalculatePrice()
        {
          decimal? DiscountAmount = Subtotal * (DiscountPercent /100);
            return DiscountAmount;


            //int? months = Years * 12;
            //decimal? monthlyInterestRate =
            //YearlyInterestRate / 12 / 100;
            //decimal? futureValue = 0;
            //for (int i = 0; i < months; i++)
            //{
            //    futureValue = (futureValue + MonthlyInvestment) *
            //    (1 + monthlyInterestRate);
            //}
            //return futureValue;
        }
    }
}
