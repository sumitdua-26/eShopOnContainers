@api @owner=kritsha @web @testplan= @testsuite=
Feature: Login_EShopApplication
	As a user, I want to be able to login to the EShop application

@bvt @priority=1
Scenario: Verify that the user is able to get the Catalog Types by calling Catalog API
	Given user wants to get Catalog types through "Catalog Types" API
	When catalog types API is called
	Then the api should return "200" response
	And the user should be able to get catalog types

@bvt @priority=1
Scenario Outline: Verify that the user is able to get the catalog items by calling Catalog API
	Given user wants to get catalog items through "Catalog Items" API
	When the "page index" is "<pageIndex>"
	And the "page size" is "<pageSize>"
	When catalog items API is called
	Then the api should return "200" response
	And the user should be able to get catalog items for the given page

	Examples: 
	| pageIndex | pageSize |
	| 0         | 10       |
	| 1         | 5        |