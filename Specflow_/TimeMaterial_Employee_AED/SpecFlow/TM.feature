Feature: Time and Material Page
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



Scenario: Check if user is able to delete  Time and Material record.
	Given Successfully logged-in on the Turn-Up Portal
	And Navigate to Time and Material Page
	When Deleting the an Employee record
	Then the Employee record should be deleted successfully