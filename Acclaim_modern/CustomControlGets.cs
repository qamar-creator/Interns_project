using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace Acclaim_modern
{
    class CustomControlGets

    {


        public static string GettextfromLabel(string webelementvalue, propertytype elementtype)
    {
        if (elementtype == propertytype.Model)
            return PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).Text;

        else
            if (elementtype == propertytype.Name)
            return PropertiesCollection.ngdriver.FindElement(NgBy.Binding(webelementvalue)).Text;

        else
            if (elementtype == propertytype.XPath)
            return PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).Text;

        else

        if (elementtype == propertytype.CssSelector)
            return PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).Text;
        else
            return (string.Empty);

    }

    public static string Geettextfromtextbox(string webelementvalue, propertytype elementtype)
    {
        if (elementtype == propertytype.Model)
            return PropertiesCollection.ngdriver.FindElement(NgBy.Model(webelementvalue)).GetAttribute("value");

        else
        if (elementtype == propertytype.Name)
            return PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue)).GetAttribute("value");
        else
         if (elementtype == propertytype.XPath)
            return PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).GetAttribute("value");

        else

         if (elementtype == propertytype.CssSelector)
            return PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).GetAttribute("value");
        else
            return (string.Empty);

    }


    public static string Gettextfromdropdown(string webelementvalue, string elementtype)


    {
        if (elementtype == "id")
            return PropertiesCollection.ngdriver.FindElement(By.Id(webelementvalue)).GetAttribute("value");

        else
           if (elementtype == "Name")
            return new SelectElement(PropertiesCollection.ngdriver.FindElement(By.Name(webelementvalue))).SelectedOption.Text;
        if (elementtype == "XPath")
            return PropertiesCollection.ngdriver.FindElement(By.XPath(webelementvalue)).GetAttribute("value");

        else

        if (elementtype == "CssSelector")
            return PropertiesCollection.ngdriver.FindElement(By.CssSelector(webelementvalue)).GetAttribute("value");
        else
            return (string.Empty);



    }
}
}
