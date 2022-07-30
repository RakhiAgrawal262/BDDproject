Feature: Tide
Automate the Tide WebSite

@SingnUpAccount
Scenario: SignUP
	Given I open URL of TideWebSite
	And Click On Register
	When I Click on SignUP Button
	Then Account is Created
	
@LoginAccount
Scenario: Login
    Given I open Tide Website
	And I Open Login Page
	When Enter Login Information
	Then Click on Login Button

@HowTOWashClothes
Scenario: wash clothes
     Given I open Website
	 And Click On How to wash clothes
	 Then Find how to removal stain 

@SelectLocation
Scenario: Select Location
     Given Open Website
	 Then Click On Location

@ShopeProducts
Scenario: Shop Products
     Given Page URL
	 And Click on ShopProducts
	 When shope Product By Rating
	 Then Select Rathing of the Product

@ContectUs
Scenario: ContactUs
     Given Tide URL
	 Then Click on ContactUs

@SearchProduct
Scenario: Search 
      Given open tide url
	  Then Search product

@DoLiveChat
Scenario: Live Chat
        Given website url 
		Then Click on Live Chat

@FindNewProducts
Scenario: New Products
         Given Tide website 
		 And Find Latest News about Products
		 Then Search Latest Articles section

@CouponsAndRewards
Scenario: Coupons And Rewards
         Given open website Url
		 And Open Coupons And Rewards
		 When Save Rewards
		 Then Login Account

