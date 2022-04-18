Feature: DotNetFiddle
	As a Tester
	I want to verify items on DotNetFiddle are working as expected
	So that users Run and hide the Options Panel

Background:
	Given a user goes to the DotNetFiddle website

Scenario: 01 Check Output Window After Clicking Run
	When a user clicks the Run button
	Then the output window displays 'Hello World'

Scenario: 02 Check the Options Panel Is Hidden After Clicking Chevron
	When a user clicks the Options Chevron button
	Then the Options Panel should be hidden


