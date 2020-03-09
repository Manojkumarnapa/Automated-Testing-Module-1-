Feature: TimeAndMaterial
	In order to manage customers
	As a Turn Up portal admin
	I would like to create, edit, view and delete customer records

@automate @p1 @web
Scenario: I'd like to add customer using valid details
	Given I have log into  TurnUp portal
	And I navigate to customer page
	Then I should be able to create customer record with valid information

@automate @p1 @web
Scenario: I'd like to update an existing time record with update information
	Given I have log into  TurnUp portal
	And I navigate to customer page
	Then I should be able to edit customer record with updated information