Feature: Lead Source
Workflow to create a Lead Source into a new Campaign

Scenario: Create Lead Source From Welcome Section
	Given the user navigates to "Welcome" section
	And the user clicks on "Create a Lead Source" button
	When the user inputs the following Lead Source data table
		| Name         | Email                | Country       | Address     | Address2 | City    | State   | ZipCode |
		| Jorge Chavez | ljorchavez@gmail.com | United States | Greenway Rd |          | Phoenix | Arizona | 85032   |
	And the user inputs the following Campaign data table
		| Name       | Channel   | Lead Type | Price | RequireAuth |
		| Contact Us | Web Leads | Other     | 100   | true        |
	And the user inputs the following Propertie data table
		| DuplicateDays | StandardizeAddress | AppendCity | MobileCheck | GeolocateIP | DeliveryCount | DeliversTo            |
		| 30            | false              | false      | false       | false       | 5             | Any Qualified Clients |
	Then the user validates that the new Lead Source is created
		| Name         | Email                |
		| Jorge Chavez | ljorchavez@gmail.com |

Scenario: Create Lead Source From Inbound Section
	Given the user navigates to "Lead Source List" section
	And the user clicks on "Create Button" in the "Lead Source Page"
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

