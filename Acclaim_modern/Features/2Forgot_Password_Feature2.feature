Feature: 2Forgot_Password_Feature2
	Feature: Forget password,change password scenarios 

@mytag
Scenario:1Fortgot_password
Given The user lands on login page as "https://azdevacclaim.azurewebsites.net/Home/Home.aspx"
And clicks on forgot password? link
And user fills in required fields as below
| site_id | enter_email            |
| Acclaim | acclaim146@gmail.com |
When user clicks button Recover Password
Then a lable should read "Email has been sent to your Email Id." should display on the screen
When user clicks close button on this screen
Then user should go to  the Login page
When user visits its email mentioned email inbox,
Then user should get a link to define new_passowrd
And user again login with new_password should land on the pasge with link "Home"
And switch to other browser window and navigate to "https://www.office.com/login?es=Click&ru=%2F "
And user goes into email conditional to email is logged in
And user fiinds specfic email from the list containing title forgot password
When user clicks on the email 
Then user should able to get the password



