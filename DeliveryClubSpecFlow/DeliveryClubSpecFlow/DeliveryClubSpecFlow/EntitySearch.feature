Feature: EntitySearch
	Delivery club search page
	Checking search results

@Search
@EntityPage
@Positive
Scenario: Empty Search
	Given Opened webpage https://www.delivery-club.ru/
	When I click to entity menu ALL
	Then search results are 
	| Key | Value |
	| Макдоналдс | 1 ₽ |
	| Обед буфет Метрополис | 300 ₽ | 
	| Три правила | 300 ₽ |
