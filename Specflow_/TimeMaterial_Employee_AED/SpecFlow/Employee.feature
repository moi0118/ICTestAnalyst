Feature: Employee Page
	Create, Edit, and Delete of Employee record.

@mytag
Scenario: Check if user is able to add new Employee record
	Given Successfully logged-in on the Turn-Up Portal
	And Navigate to Employee Page
	When Creating a new Employee record
	Then the new Employee record should be added successfully

@mytag
Scenario: Check if user is able to edit  Employee record
	Given Successfully logged-in on the Turn-Up Portal
	And Navigate to Employee Page
	When Editing the Username of Employee record
	Then the Employee record Username should be updated successfully

@mytag
Scenario: Check if user is able to delete an Employee record.
	Given Successfully logged-in on the Turn-Up Portal
	And Navigate to Employee Page
	When Deleting the an Employee record
	Then the Employee record should be deleted successfully


