namespace TestFramework
{
    class GenerateUrl
    {
        public static string generateUrl(int number1, int number2)
        {
            var browseUrl="https://www.calcatraz.com/calculator/api?c=[" +number1+ "][%2B][" +number2+"]";
            return browseUrl;
        }

        public static string generateUrl(float number1, float number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }
        public static string generateUrl(int number1, float number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }

        public static string generateUrl(float number1, int number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }

        public static string generateUrl(double number1, int number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }

        public static string generateUrl(double number1, double number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }

        public static string generateUrl(double number1, float number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }

        public static string generateUrl(string number1, int number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }
        public static string generateUrl(string number1, string number2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][" + number2 + "]";
            return browseUrl;
        }
        public static string generateUrl(int number1)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + number1 + "][%2B][]";
            return browseUrl;
        }

        internal static string GenerateUrlWithOperatorMissiong(int num1, int num2)
        {
            var browseUrl = "https://www.calcatraz.com/calculator/api?c=[" + num1 + "][]["+num2+"]";
            return browseUrl;
        }
    }
}
