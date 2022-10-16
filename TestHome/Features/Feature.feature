Feature: Home page of google

Background: 
	Given Open "Home" page

@tc:1
Scenario: Click on search button with no one word on search input
	When User clicks on "Buscar con Google"
	Then Page shows url "Home"