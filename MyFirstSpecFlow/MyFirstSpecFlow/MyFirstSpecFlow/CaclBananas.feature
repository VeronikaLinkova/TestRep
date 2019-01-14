Feature: CaclBananas
	This is feature to calc bananas
	Which one monkey give to another

@Positive
Scenario: Give one banana
	Given First monkey have 1 banana
	And Second monkey have 0 banana
	When First monkey give 1 banana to second monkey
	Then First monkey have 0 banana and second monkey have 1 banana

@Positive
Scenario: Give ten bananas
	Given First monkey have 10 banana
	And Second monkey have 0 banana
	When First monkey give 10 banana to second monkey
	Then First monkey have 0 banana and second monkey have 10 banana

@Positive
Scenario: Give 50 bananas
	Given First monkey have 100 banana
	And Second monkey have 50 banana
	When First monkey give 50 banana to second monkey
	Then First monkey have 50 banana and second monkey have 100 banana

@Negative
Scenario: Give too many bananas
	Given First monkey have 1 banana
	And Second monkey have 0 banana
	When First monkey give 10 banana to second monkey
	Then have error message 