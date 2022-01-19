Feature: Time and Material Page
	Create, Edit, and Delete of Time and Material record.

@tag0
 Scenario:  [Check if user is able to add new Time and Meterial record.]
	Given [Successfully logged-in on the Turn-Up Portal]
	And [Navigate to Time and Material Page]
	When [Creating a new Time and Material record] 
	Then [the new Time and Material record should be added successfully]
	Then [close the browser]

@tag1
Scenario Outline: [Check if user is able to edit  Time and Meterial record.]
	Given [Successfully logged-in on the Turn-Up Portal.]
	And [Navigate to Time and Material Page.]
	When [Editing the '<description>' and '<code>' of a Time and Material record.]
	Then [the Time and Material record '<description>' and '<code>' should be updated successfully.]
	Then [close the browser]
	Examples: 
	
	| description    | code    |
	| descriptionOne | codeOne |
	| descriptionTwo | codeTwo |

@tag2
	Scenario: [Check if user is able to delete  Time and Material record.]
	Given [Successfully logged-in on the Turn-Up Portal]
	And [Navigate to Time and Material Page]
	When [Deleting a Time and Material record]
	Then [the Time and Material record should be deleted successfully]
	Then [close the browser]

	
