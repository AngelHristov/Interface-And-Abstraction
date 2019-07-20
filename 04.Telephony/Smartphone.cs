using System.Linq;

namespace _04.Telephony
{
    public class Smartphone : ICaller, IBrowser
    {
        public string CallOtherPhones(string number)
        {
            if (number.All(char.IsDigit))
            {
                return $"Calling... {number}";
            }
            return "Invalid number!";
        }

        public string BrowseWWW(string url)
        {
            if (!url.Any(char.IsDigit))
            {
                return $"Browsing: {url}!";
            }
            return "Invalid URL!";
        }      
    }
}
