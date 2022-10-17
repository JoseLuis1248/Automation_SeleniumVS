Feature: Home page of google

Background: 
	Given Open "Home" page

@tc:1
Scenario: Write a simple text on search input and click on search button
	When User writes a "Simple Text" on search input
	And User clicks on "Buscar con Google"
	Then Page shows at least "5" results

@tc:2
Scenario: Write a simple text on search input and press Enter key on keyboard
	When User writes a "Simple Text" on search input
	And User press "Enter" key on search input
	Then Page shows at least "5" results

@tc:3
Scenario: Click on search button with no one word on search input
	When User clicks on "Buscar con Google"
	Then Page shows url "Home"

@tc:4
Scenario: Click on i will have luck button
	When User clicks on "Voy a tener suerte"
	Then Page shows url "Doodles"