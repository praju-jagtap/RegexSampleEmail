using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationEmail
{
    internal class SampleEmailValidation
    {
        public const string EMAIL_REGEX = "^[a-z]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public const string EMAIL_VALID_REGEX = "^[a-z]+[-][0-9]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public const string EMAIL_SAMPLE_REGEX = "^[a-z]+[.][0-9]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public const string EMAIL_TRUE_REGEX = "^[a-z0-9]+[@][a-zA-z]+[.][a-zA-Z]{3}$";
        public const string EMAIL_INVALID_REGEX = "^[a-zA-Z]$";
        public const string EMAIL_FAIL_REGEX = "^[a-z]+[@]+[.][a-zA-Z][.][a-zA-Z]{2,3}$";

        public void Email(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public void Email1(string email)
        {
            Regex regex = new Regex(EMAIL_VALID_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public void Email2(string email)
        {
            Regex regex = new Regex(EMAIL_SAMPLE_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public void Email3(string email)
        {
            Regex regex = new Regex(EMAIL_TRUE_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public void Email4(string email)
        {
            Regex regex = new Regex(EMAIL_INVALID_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public void Email5(string email)
        {
            Regex regex = new Regex(EMAIL_FAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
    }
}
