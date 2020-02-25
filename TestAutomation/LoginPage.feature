Feature: LoginPage

Scenario: 01. Logging in takes the user to the Secure Area
	Given the Login page has been loaded
	When I log in with with the following details:
		| username | password             |
		| tomsmith | SuperSecretPassword! |
	Then I should be on a page titled 'Secure Area'