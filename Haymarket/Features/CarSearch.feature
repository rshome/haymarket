Feature: Car Search
	In order to view cars for sale
	As a Pistonhead User
	I want to narrow my search down

@smoke
Scenario Outline: Search for BMWs
	Given a user is on the PistonHeads home page
	When a make of <make> is selected in the advert search widget
	And a model of <model> is selected in the advert search widget
	And the Search button is clicked in the advert search widget
	Then the number of advert search results is greater than 0

	Examples: 
	| make | model    |
	| BMW  | 2 Series |	 	

