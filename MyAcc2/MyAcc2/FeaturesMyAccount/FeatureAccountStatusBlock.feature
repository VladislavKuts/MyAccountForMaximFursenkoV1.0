Feature: FeatureAccountStatusBlock
	In order to check my account status
	As a My Account user
	I want to have access to account status page

Background: 
  Given User is log in and account status page is opened

Scenario: Check the display of the selected dates
	When I select account in Account status page
	And I select Start-date
	And I select End-date
	And I click Show Report button
	Then Selected dates matches with showed period before general info
	And Selected dates matches with showed period after general info
