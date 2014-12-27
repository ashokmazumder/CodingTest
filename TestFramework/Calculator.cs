namespace TestFramework
{
    public static class Calculator
    {
        public static string URL = "https://www.calcatraz.com/calculator/api?c=[number][operator][number]";
        public static string pageTitle = "https://www.calcatraz.com/calculator/api?c=[number][operator][number]";

        public static void GetBrowser(string browserName)
        {
            Browser.GetWebBrowser(browserName);
        }

        public static void LoadUrlToWebBrowser()
        {
            Browser.LoadUrlToWebBrowser(URL);
        }

        public static void CloseBrowser()
        {
            Browser.CloseBrowser();
        }

        public static bool IsAtPage()
        {
            return Browser.Title == pageTitle;
        }

        public static string GetResult()
        {
            return Browser.GetResult();

        }

        public static class AdditionOperation
        {
            
            public static void AddTwoIntegerNumber(int number1, int number2)
            {
                URL = GenerateUrl.generateUrl(number1, number2);
                Browser.LoadUrlToWebBrowser(URL);
            }

            public static void AddTwoDoubleNumber(double number1, double number2)
            {
                URL = GenerateUrl.generateUrl(number1, number2);
                Browser.LoadUrlToWebBrowser(URL);
            }

            public static void AddInterAndDouble(int number1, double number2)
            {
                URL = GenerateUrl.generateUrl(number1, number2);
                Browser.LoadUrlToWebBrowser(URL);
            }

            public static void AddTwoString(string string1, string string2)
            {
                URL = GenerateUrl.generateUrl(string1, string2);
                Browser.LoadUrlToWebBrowser(URL);
            }
            public static void AddIntegerAndString(int number1, string string1)
            {
                URL = GenerateUrl.generateUrl(number1, string1);
                Browser.LoadUrlToWebBrowser(URL);
            }

            public static void PerformAddWithOneElement(int element)
            {
                URL = GenerateUrl.generateUrl(element);
                Browser.LoadUrlToWebBrowser(URL);
            }

            public static void AddTwoNumberWhenOperatorMissing(int num1, int num2)
            {
                URL = GenerateUrl.GenerateUrlWithOperatorMissiong(num1, num2);
                Browser.LoadUrlToWebBrowser(URL);
            }

            public static void AddDoubleAndString(double number1, string string1)
            {
                URL = GenerateUrl.generateUrl(number1, string1);
                Browser.LoadUrlToWebBrowser(URL);
            }
        }
    }
}
