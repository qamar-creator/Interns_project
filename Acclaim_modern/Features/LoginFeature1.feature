Feature: 1LoginFeature1
	This feature contains scenarios for Login including forgot password, change password

@mytag
Scenario: 1Login with right credentals
	Given The user visits url as "https://azdevacclaim.azurewebsites.net/Home/Home.aspx"
	And user enters site id ,username and password as below
	| site_id | user_id | password   |
	| Acclaim  | qamar.zaman@lelafe.com | Test@111 |
	When user clicks login button
	Then user should land on the page with  link "Home"
And browser should get closed
  
Scenario: 2Login with wrong credentials
Given The user visits url as "https://azdevacclaim.azurewebsites.net/Home/Home.aspx"
And user enters site id ,username and password as below
| site_id | user_id                | password |
| Acclai | qamar.zaman@lelafe.com | Test@11 |
When user clicks login button 
Then user should stay on the same page
 And browser should get closed