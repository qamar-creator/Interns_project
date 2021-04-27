using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Protractor;

namespace Acclaim_modern
{
    class CustomControls
    {


        // EnterText

        public static void Entertext(string webelementvalue, string value, propertytype elementtype)

        {
            if (elementtype == propertytype.Model)

                PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).SendKeys(value);
            else
            if (elementtype == propertytype.Name)

                PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).SendKeys(value);
            else
            if (elementtype == propertytype.XPath)

                PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).SendKeys(value);
            else
            if (elementtype == propertytype.CssSelector)

                PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).SendKeys(value);
        }


        // click button, checkbox,radio buttion,check boxal

        public static void click(string webelementvalue, propertytype elementtype)

        {
            if (elementtype == propertytype.Model)

                PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).Click();
            else
           if (elementtype == propertytype.Name)

                PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).Click();
            else
           if (elementtype == propertytype.XPath)

                PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).Click();
            else
           if (elementtype == propertytype.CssSelector)

                PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).Click();
            else
           if (elementtype == propertytype.Class)

                PropertiesCollection.ngdriver.FindElement(By.ClassName(webelementvalue)).Click();
            else
           if (elementtype == propertytype.LinkText)

                PropertiesCollection.ngdriver.FindElement(By.LinkText(webelementvalue)).Click();
        }


        //Selecting value from dropdown

        public static void Selectdropdown(string webelementvalue, string Text, propertytype elementtype)
        {
            if (elementtype == propertytype.Id)

                new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Id(webelementvalue))).SelectByText(Text);
            else
           if (elementtype == propertytype.Name)

                new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue))).SelectByText(Text);
            else
           if (elementtype == propertytype.XPath)

                new SelectElement(PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue))).SelectByText(Text);
            else
           if (elementtype == propertytype.CssSelector)

                new SelectElement(PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue))).SelectByText(Text);

        }

    }
}
