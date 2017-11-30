Feature: RegisterForm
	As a site user, I want to login to the site so that I can use its functionality

@register
Scenario Outline: User Checking the Registeration Form
	Given I have navigated to the site
	When I enter intial <Initial>, FirstName <FirstName> and LastName <LastName>
	When I press register button
	Then I should see application main page
Examples: 
    	| Initial | FirstName   | LastName |
	    | K       | Hello       |   World  |
#	    | A       | Jack        |   Man  |
 