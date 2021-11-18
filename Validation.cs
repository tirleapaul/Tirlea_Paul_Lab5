using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Tirlea_Paul_Lab5
{
    class Validation
    {
    }

    //validator pentru camp required
    public class StringNotEmpty : ValidationRule
    {
        //mostenim din clasa ValidationRule
        //suprascriem metoda Validate ce returneaza un ValidationResult
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "")
                return new ValidationResult(false, "String cannot be empty");
            return new ValidationResult(true, null);
        }
    }


    //validator pentru lungime minima a string-ului
    public class StringMinLength : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3)
                return new ValidationResult(false, "String must have at least 3 characters!");
 return new ValidationResult(true, null);
        }
    }

    // trebuie sa mai fac doua validari
    public class StringMaxLength : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length > 10)
                return new ValidationResult(false, "String must have maximum 10 characters!");
            return new ValidationResult(true, null);
        }
    }

    public class StringNotAllowDash : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "-")
                return new ValidationResult(false, "String must have maximum 10 characters!");
            return new ValidationResult(true, null);
        }
    }
}
