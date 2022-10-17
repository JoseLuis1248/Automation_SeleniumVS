Feature: Cross Browser Example

@tc:5
Scenario Outline: Write a simple text on search input and click on search button
	Given Open "Home" page with browser "<browser>"
	When User writes a "Simple Text" on search input
	And User clicks on "Buscar con Google"
	Then Page shows at least "5" results
	Examples: 
	| browser |
	| Chrome  |
	| Firefox |
	| Edge    |