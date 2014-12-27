using System;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Web;

namespace TestFramework
{
    class GenerateUrl
    {
        internal static string generateUrl(int number1, int number2)
        {
            var browseUrl="https://www.calcatraz.com/calculator/api?c=" +HttpUtility.UrlEncode(number1+"+"+number2);
            return browseUrl;
        }

        internal static string generateUrl(double number1, double number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1 + "+" + number2);
            return browseUrl;
        }

        internal static string generateUrl(int number1, double number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1 + "+" + number2);
            return browseUrl;
        }

        internal static string generateUrl(string number1, string number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1 + "+" + number2);
            return browseUrl;
        }

        internal static string generateUrl(int number1)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1 + "+");
            return browseUrl;
        }

        internal static string GenerateUrlWithOperatorMissiong(int number1, int number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1.ToString() + number2.ToString());
            return browseUrl;
        }

        internal static string generateUrl(int number1, string string1)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1 + "+"+string1);
            return browseUrl;
        }

        internal static string generateUrl(double number1, string string1)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=" + HttpUtility.UrlEncode(number1 + "+" + string1);
            return browseUrl;
        }
    }
}
