using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Acclaim_modern
{
    public class SETUP
    {

        public static IWebDriver driver;

        public void TestMethodLogin(string url1)
        {
            // driver = new ChromeDriver();
           PropertiesCollection.ngdriver = new ChromeDriver();
            string url = url1;

           // PropertiesCollection.ngdriver = new NgWebDriver(driver);
            PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
        }



        public void TestMethodfillLogin()
        {


             
            CustomControls.Entertext(PageObjects.discountonproduct("discountPercent"),"10", propertytype.Model);
            string acualresultofsavedamount = Calculations.calculatesavedamount("1000", "10");
            Console.WriteLine("The calculated saved amount from test is " + " " + acualresultofsavedamount);
            string savedamount = CustomControlGets.GettextfromLabel(PageObjects.savedAmount(), propertytype.CssSelector);
            Console.WriteLine("The saved ammount refelected from application is" + " " + savedamount);
            Assertions.assertionequals(acualresultofsavedamount, savedamount);
            string Amountafterdiscount = CustomControlGets.Geettextfromtextbox("afterDiscount", propertytype.Model);
            Console.WriteLine("This is the amount to be paidis    " + Amountafterdiscount);



        }

        public void close()

        {

            PropertiesCollection.ngdriver.Close();
            PropertiesCollection.ngdriver.Quit();
        }
    }
}
