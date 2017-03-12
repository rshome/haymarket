Feature: Bike Advert
	In order to view bikes for sale
	As a Pistonhead User
	I want to view the relevant bike advert

@smoke
Scenario Outline: Display Correct Bike Advert
	Given a user is on the PistonHeads home page
	When the Bikes tab is selected in the advert search widget
	And a bike make of <BikeMake> is selected in the advert search widget
	And a max price of <Price> pounds is selected in the advert search widget
	And the Search button is clicked in the advert search widget
	Then the number of advert search results is greater than 0
	And the make <BikeMake> is selected in the Refine Your Search side panel

	Examples: 
	| BikeMake | Price   |
	| Ducati   | £10,000 |