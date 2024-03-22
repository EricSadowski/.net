using System.ComponentModel.DataAnnotations;

namespace BigSales.Models
{
    public class GreaterThanAttribute : ValidationAttribute
    {
        private object compareValue;
        public GreaterThanAttribute(object val) {
            compareValue = val;
        }

        protected override ValidationResult IsValid(object? value,
        ValidationContext ctx)
        {
            if (value is int)
            {
                int intToCheck = (int)value;
                int intToCompare = (int)compareValue;

                if (intToCheck > intToCompare) {
                    return ValidationResult.Success!;
                }
            }
            else if (value is double)
            {
                double doubleToCheck = (double)value;
                double doubleToCompare = (double)compareValue;

                if (doubleToCheck > doubleToCompare)  {
                    return ValidationResult.Success!;
                }
            }
            else if (value is DateTime)
            {
                DateTime dateToCheck = (DateTime)value;
                DateTime dateToCompare = new DateTime();
                DateTime.TryParse(compareValue.ToString(), out dateToCompare);

                if (dateToCheck > dateToCompare) {
                    return ValidationResult.Success!;
                }
            }
            else
            {    /* If property being checked isn't an int, double, or DateTime, don't do anything, just return success.
                   Alternately, could throw an exception in this case to let developer know that they're using the
                   validation attribute incorrectly. Or could expand attribute to check more data types. Or both.
                 */
                return ValidationResult.Success!;
            }

            string msg = base.ErrorMessage ??
                $"{ctx.DisplayName} must be greater than {compareValue?.ToString()}.";
            return new ValidationResult(msg);
        }
    }
}