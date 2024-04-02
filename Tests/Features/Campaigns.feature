Feature: Campaigns
Workflow to edit campaign

@CreateCampaignWithLead @DeleteLead
Scenario: Edit Price of a Campaign
	Given the user navigates to "Campaigns" section
	When the user double clicks the recently created campaign
	And the user changes the price to "random"

