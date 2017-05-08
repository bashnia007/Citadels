using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CitadelsApp.ValidationRules
{
    public class EmailValidationRule : ValidationRule
    {
        public string Message { get; set; }
        /// взял Regex отсюда
        /// https://msdn.microsoft.com/en-us/library/01escwtf.aspx
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value != null && 
                Regex.IsMatch((string)value, 
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", 
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, Message);
        }
    }
}
