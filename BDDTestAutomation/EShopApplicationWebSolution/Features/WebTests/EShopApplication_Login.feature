@ui @owner=kritsha @web @testplan=574712 @testsuite=574715
Feature: Login_EShopApplication
As a user, I want to be able to login to the EShop application

@testcase=574719 @bvt @priority=1 version=1
Scenario: Verify that a registered user is able to login into EShop application
	When user launches EShop application
	And user clicks on "Login" button
	And user enters "Email" and "Password"
	And user clicks on "LOG IN" button
	Then user should be logged-in

@testcase=574720 @priority=2 version=1
Scenario Outline: Verify that the user is unable to login to EShop Application if user is not registered already
	Given the user is not registered to EShop application
	When user launches EShop application
	And user clicks on "Login" button
	And user enters email and password of "<user>"
	And user clicks on "LOG IN" button
	Then the user should not be able to login to the application

	Examples:
		| user         |
		| InvalidUser1 |
		| InvalidUser2 |
		| InvalidUser3 |