Feature: New customer record

A short summary of the feature


Scenario:A. User able to create new customer record in turnup portal
	Given User able to login the turnup portal
	And User able to see the home page and customer page
	When User able to create a new customer record
	Then User able to see new customer record in customer page	

Scenario Outline:B. User able to Edit the the customer record
Given User able to see the customer page
When User able to edit the record <Names><firstname><lastname><GST>
Then User able to see the edit record in customer page

Examples: 
| Names       | firstname | lastname | GST |
| 'Jeshvitha' | 'M'       | 'G'      | 30  |

Scenario:C.User able to delete the customer record
Given User able to see the customer page
When User able to delete the customer record
Then User validate that customer record is deleted.