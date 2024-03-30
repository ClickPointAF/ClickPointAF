Feature: LeadReceiver
Workflow to create a Lead Source into a new Campaign

Scenario: Succesfully Login as User
	Given the user navigates to "Welcome" section
	And the user clicks "Create a Lead Source" button
	When the user inputs the following Lead Source data table
		| Name        | Email                    | Country       | Address     | Address2 | City    | State   | ZipCode |
		| Luis Chavez | luis_jorge95@hotmail.com | United States | Greenway Rd |          | Phoenix | Arizona | 85032   |
	And the user inputs the following Campaign data table
		| Name       | Channel   | Lead Type | Price | RequireAuth |
		| Contact Us | Web Leads | Other     | 100   | true        |
	And the user inputs the following Propertie data table
		| DuplicateDays | StandardizeAddress | AppendCity | MobileCheck | GeolocateIP | DeliveryCount | DeliversTo            |
		| 30            | false              | false      | false       | false       | 5             | Any Qualified Clients |
	Then the user validates that the new Lead Source is created
		| Name        | Email                    |
		| Luis Chavez | luis_jorge95@hotmail.com |

