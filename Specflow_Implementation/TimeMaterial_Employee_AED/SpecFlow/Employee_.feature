Feature: Employee Page
Create, Edit, and Delete of Employee record.

@tag0
Scenario: [Check if user is able to add new Employee record.]
	Given [User is successfully logged-in on the Turn-Up Portal]
	And [Navigate to Employee Page]
	When [Creating a new Employee record]
	Then [the new Employee record should be added successfully]
	Then [close browser]



@tag1
Scenario Outline: [Check if user is able to edit  Employee record.]
	Given [User is successfully logged-in on the Turn-Up Portal]
	And [Navigate to Employee Page]
	When [Editing the '<name>' and '<username>' of an Employee record.]
	Then [the Employee record '<name>' and '<username>' should be updated successfully.]
	Then [close browser]
	Examples: 
	
	| name		| username  |
	| Mark One	| markone	|
	| David Two | davidtwo	|

@tag2
	Scenario: [Check if user is able to delete  Employee record.]
	Given [User is successfully logged-in on the Turn-Up Portal]
	And [Navigate to Employee Page]
	When [Deleting the an Employee record]
	Then [the Employee record should be deleted successfully]
	Then [close browser]

	
