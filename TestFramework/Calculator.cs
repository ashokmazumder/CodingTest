using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public static class Calculator
    {
        public static class AdditionPage
        {
            public static string URL = "https://www.calcatraz.com/calculator/api?c=[number][operator][number]";
            public static string pageTitle = "https://www.calcatraz.com/calculator/api?c=[number][operator][number]";

            public static void GetBrowser(string browserName)
            {
                Browser.GetWebBrowser(browserName);
            }

            public static void LoadUrl()
            {
                Browser.LoadUrl(URL);
            }

            public static bool IsAt()
            {
                return Browser.Title == pageTitle;
            }

            public static void AddTwoIntegerNumber(int number1, int number2)
            {
                URL = GenerateUrl.generateUrl(number1, number2);
            }

            public static void AddTwoFloatNum(float number1, float number2)
            {
                URL = GenerateUrl.generateUrl(number1, number2);
            }

            public static string GetResult()
            {
                return Browser.FindResult();
                
            }


            public static void AddTwoDoubleNumber(double number1, double number2)
            {
                URL = GenerateUrl.generateUrl(number1, number2);
            }

            public static void AddTwoString(string string1, string string2)
            {
                URL = GenerateUrl.generateUrl(string1, string2);
            }

            public static void PerformAddWithOneElement(int element)
            {
                URL = GenerateUrl.generateUrl(element);
            }

            public static void AddTwoNumberWhenOperatorMissing(int num1, int num2)
            {
                URL = GenerateUrl.GenerateUrlWithOperatorMissiong(num1, num2);
            }
        }
    }
}
