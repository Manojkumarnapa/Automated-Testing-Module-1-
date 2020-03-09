Feature: TimeAndMaterial
	In order to manage Time and Materials record
	As a Turn Up portal admin
	I would like to create, edit, view and delete time material records

@automate @p1 @web
Scenario: I'd like to add time using valid details
	Given I have logged in TurnUp portal
	And I navigate to Time and Material page
	Then I should be able to create time record with valid information

@automate @p1 @web
Scenario: I'd like to update an existing time record with update information
	Given I have logged in TurnUp portal
	And I navigate to Time and Material page
	Then I should be able to edit time record with updated information

@manual @mobile @android @p2
Scenario: Time and Material page should be accessable from my mobile device
	Given I have logged in TurnUp portal on my android device
	And I navigate to Time and Material page on my android device
	Then I should be able to view the Time and Material page