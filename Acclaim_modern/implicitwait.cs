using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Acclaim_modern
{
    class implicitwait
    {




        /* Wait time is the maximum time to wait to find the element in the DOM,
         * If element is found before wait period, then the next step would be executed.
         */


        public static void ImplicitWait(int sec)
        {
            /*
             * "implicit wait is to tell WebDriver to poll the DOM for a certain amount of 
             * time when trying to find an element or elements if they are not immediately available."
             */

            PropertiesCollection.ngdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
        }

        public static void ajaxWait(int sec)
        {
            PropertiesCollection.ngdriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(sec);
        }
        /*
        public static void WaitUntil(int sec)
        {
            WebDriverWait wait = new WebDriverWait(PropertiesCollection.ngdriver, TimeSpan.FromSeconds(sec));
        }
        */
    }
}

