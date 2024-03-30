Feature: Log In to Leadexec

Log in flow to leadexec

@LogInFeature
Scenario: Succesfully Login as User
	Given the user navigates to the landing page
	When the user inputs correct credentials to log in
	Then the user should be succesfully logged in

@LogInFeature
Scenario: Unsuccesful Login as User
	Given the user navigates to the landing page
	When the user inputs incorrect credentials to log in
	Then the user should not be succesfully logged in
