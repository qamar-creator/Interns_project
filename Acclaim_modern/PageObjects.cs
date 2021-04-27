using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace Acclaim_modern
{
    class PageObjects
    {
        static string required_object;

        public static string Login_Screen( int which_object)
        {
            
            string site_id  = "#txtSiteId"; // cssselector for site id
            string user_id = "#txtUserId"; //  cssselector for usser id
            string password = "#txtPassword"; // cssselector for password
            string home = "#ctl00_AdminMenu_MenuInMenu1_btnHome"; // cssselector for home link
            string login_button = "#btnLogin"; // cssselector for login butto
            string forgot_password = "#LinkButton1";//css slector for forgot password
            string enter_email = "#txtEmailAddress";//css selector for enter email
            string recover_pass = "#btrcoverpass";//css selector recoverpassword
            string label = "#lblEmailNotExists";// css selector of label from forgot password
            string close_button = "#btnClose";// cssselector of close button on forgot password
            switch (which_object)
            {
                case 1:
                    required_object= site_id;
                    break;
                case 2:
                    required_object = user_id;
                    break;
                case 3:
                    required_object = password;
                    break;
                case 5:
                    required_object = home;
                    break;
                case 4:
                    required_object = login_button;
                    break;
                case 6:
                    required_object = forgot_password;
                    break;
                case 7:
                    required_object = enter_email;
                    break;
                case 8:
                    required_object = recover_pass;
                    break;
                case 9:
                    required_object = label;
                    break;
                case 10:
                    required_object = close_button;
                    break;
            }

            return required_object;

        }


        public static string discountonproduct(string which_object)
        {

            string Modelfordiscount = "discountPercent";
            string page_heading = "//h3[normalize-space()='Shopping Discount']";

            switch (which_object)
            {
                case "page_heading":

                    return page_heading;
                    break;

                case "discountPercent":
                    return Modelfordiscount;
                    break;


            }


            return required_object;

        }


        public static string savedAmount()
        {

            string ModelsavedAmount = "#savedAmount";
            return ModelsavedAmount;
        }
    }
}
