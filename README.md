# Azure form recognizer - prebuilt business card model

prebuilt-businessCard: extracts text and key information from business cards.

Console project following Azure [Quickstart example for invoice model](https://docs.microsoft.com/en-us/azure/applied-ai-services/form-recognizer/quickstarts/try-v3-csharp-sdk#prebuilt-model) and mapping sample and fields for the [business card model](https://docs.microsoft.com/en-us/azure/applied-ai-services/form-recognizer/concept-business-card)

## Field extraction

| Name	| Type |	Description	| Standardized output |
|-------|------|--------------|---------------------|
| ContactNames |	Array of objects |	Contact name	| |
| FirstName |	String |	First (given) name of contact | |	
| LastName |	String |	Last (family) name of contact	| |
| CompanyNames |	Array of strings |	Company name(s)	| |
| Departments |	Array of strings |	Department(s) or organization(s) of contact	| |
| JobTitles |	Array of strings |	Listed Job title(s) of contact	| |
| Emails |	Array of strings |	Contact email address(es)	| |
| Websites |	Array of strings |	Company website(s)	| |
| Addresses |	Array of strings |	Address(es) extracted from business card	| |
| MobilePhones |	Array of phone numbers |	Mobile phone number(s) from business card |	+1 xxx xxx xxxx |
| Faxes |	Array of phone numbers |	Fax phone number(s) from business card |	+1 xxx xxx xxxx |
| WorkPhones |	Array of phone numbers |	Work phone number(s) from business card |	+1 xxx xxx xxxx |
| OtherPhones |	Array of phone numbers |	Other phone number(s) from business card |	+1 xxx xxx xxxx |
