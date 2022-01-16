Feature: Time and Material Feature
	Create, Edit, and Delete of Time and Material record.

@mytag
Scenario: Check if user is able to add new Time and Meterial record.
	Given Successfully logged-in on the Turn-Up Portal
	And Navigate to Time and Material Page
	When Creating a new Time and Material record
	Then the new Time and Material record should be added successfully

Scenario Outline: Check if user is able to edit  Time and Meterial record.
	Given Successfully logged-in on the Turn-Up Portal
	And Navigate to Time and Material Page
	When Editing the <description> of a Time and Material record
	Then the Time and Material record <description> should be updated successfully

	Examples: 
	| description    |
	| descriptionOne |
	| descriptionTwo |

