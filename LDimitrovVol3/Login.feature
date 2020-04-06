Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@positive
Scenario: Add two numbers
	Given I am on google.com
	And I have entered aa value in the search text area
	When I press Google Search
	Then I should be redirected to the results page