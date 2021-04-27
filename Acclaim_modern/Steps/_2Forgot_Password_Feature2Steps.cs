using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Acclaim_modern
{
    [Binding]
    public class _2Forgot_Password_Feature2Steps
    {
        SETUP setup = new SETUP();
        [Given(@"The user lands on login page as ""(.*)""")]
        public void GivenTheUserLandsOnLoginPageAs(string url)
        {
            setup.TestMethodLogin(url);
            PropertiesCollection.ngdriver.Manage().Window.Maximize();

        }



        [Given(@"clicks on forgot password\? link")]
        public void GivenClicksOnForgotPasswordLink()
        {
            CustomControls.click(PageObjects.Login_Screen(6), propertytype.CssSelector);
        }

        [Given(@"user fills in required fields as below")]
        public void GivenUserFillsInRequiredFieldsAsBelow(Table Forget_pass)
        {
            implicitwait.ImplicitWait(3);
            dynamic forget_pass = Forget_pass.CreateDynamicInstance();
            CustomControls.Entertext(PageObjects.Login_Screen(1), forget_pass.site_id, propertytype.CssSelector);
            CustomControls.Entertext(PageObjects.Login_Screen(7), forget_pass.enter_email, propertytype.CssSelector);

        }

        [When(@"user clicks button Recover Password")]
        public void WhenUserClicksButtonRecoverPassword()
        {
            CustomControls.click(PageObjects.Login_Screen(8), propertytype.CssSelector);
        }


        [Then(@"a lable should read ""(.*)"" should display on the screen")]
        public void ThenALableShouldReadShouldDisplayOnTheScreen(string label)
        {

            string actual_labele_display = CustomControlGets.GettextfromLabel(PageObjects.Login_Screen(9), propertytype.CssSelector);
            try
            {
                Assertions.assertionequals(label, actual_labele_display);
            }
            catch (Exception e)
            {
                Console.WriteLine("The test failed because expected label is not there");
                throw;



            }
        }
        [Then(@"user should go to  the Login page")]
        public void ThenUserShouldGoToTheLoginPage()
        {

            Globalelements.Actualresult = PropertiesCollection.ngdriver.Url;
            Globalelements.Expectedresult = "https://azdevacclaim.azurewebsites.net/Home/Home.aspx";
            try
            {
                Assertions.assertionequals(Globalelements.Actualresult, Globalelements.Expectedresult);
            }
            catch (Exception)
            {
                Console.WriteLine("The test case failed because user did not land on the login page");
                throw;
            }

        }
        [When(@"user clicks close button on this screen")]
        public void WhenUserClicksCloseButtonOnThisScreen()
        {
            CustomControls.click(PageObjects.Login_Screen(10), propertytype.CssSelector);

        }

        [When(@"user visits its email mentioned email inbox,")]
        public void WhenUserVisitsItsEmailMentionedEmailInbox()
        {

        }

        [Then(@"user should get a link to define new_passowrd")]
        public void ThenUserShouldGetALinkToDefineNew_Passowrd()
        {

        }

        [Then(@"user again login with new_password should land on the pasge with link ""(.*)""")]
        public void ThenUserAgainLoginWithNew_PasswordShouldLandOnThePasgeWithLink(string p0)
        {

        }
        [Then(@"user clicks on ""(.*)""")]
        public void ThenUserClicksOn(string compare)
        {
            string x = "qwrty";

            Assertions.assertionequals(x, compare);
        }




        [Then(@"switch to other browser window and navigate to ""(.*)""")]
        public void ThenSwitchToOtherBrowserWindowAndNavigateTo(string office_url )
        {

            PropertiesCollection.ngdriver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/?tab=rm&ogbl#inbox");

            implicitwait.ImplicitWait(5);
            CustomControls.Entertext("//input[@type='email']", "acclaim146@gmail.com", propertytype.XPath);
            CustomControls.click("//div[@class='VfPpkd-RLmnJb']", propertytype.XPath);
            CustomControls.Entertext("//input[@name='password']", "abdullah@786", propertytype.XPath);
            CustomControls.click("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/button[1]/div[2]", propertytype.XPath);
            implicitwait.ImplicitWait(2);
              
            
        
        }

        [Then(@"user goes into email conditional to email is logged in")]
        public void ThenUserGoesIntoEmailConditionalToEmailIsLoggedIn()
        {

        }

        [Then(@"user fiinds specfic email from the list containing title forgot password")]
        public void ThenUserFiindsSpecficEmailFromTheListContainingTitleForgotPassword()
        {
            CustomControls.click("//div[@class='xT']//span[@class='bqe'][normalize-space()='Forget Password']", propertytype.XPath);


        }
        [When(@"user clicks on the email")]
        public void WhenUserClicksOnTheEmail()
        {

        }

        [Then(@"user should able to get the password")]
        public void ThenUserShouldAbleToGetThePassword()
        {

        }

    }
}
