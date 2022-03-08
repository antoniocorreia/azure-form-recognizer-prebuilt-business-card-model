using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;

string endpoint = "<your-endpoint>";
string apiKey = "<your-apiKey>";
AzureKeyCredential credential = new AzureKeyCredential(apiKey);
DocumentAnalysisClient client = new DocumentAnalysisClient(new Uri(endpoint), credential);

// sample business card document

Uri businessCardUri = new Uri("https://raw.githubusercontent.com/Azure-Samples/cognitive-services-REST-api-samples/master/curl/form-recognizer/businessCard.png");

AnalyzeDocumentOperation operation = await client.StartAnalyzeDocumentFromUriAsync("prebuilt-businessCard", businessCardUri);

await operation.WaitForCompletionAsync();

AnalyzeResult result = operation.Value;

for (int i = 0; i < result.Documents.Count; i++)
{
    Console.WriteLine($"Document {i}:");

    AnalyzedDocument document = result.Documents[i];

    if (document.Fields.TryGetValue("Locale", out DocumentField? localeField))
    {
        if (localeField.ValueType == DocumentFieldType.String)
        {
            string locale = localeField.AsString();
            Console.WriteLine($"Locale: '{locale}', with confidence {localeField.Confidence}");
        }
    }

    if (document.Fields.TryGetValue("ContactNames", out DocumentField? contactNamesField))
    {
        if (contactNamesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in contactNamesField.AsList())
            {
                Console.WriteLine("Contact Name:");
                if (itemField.ValueType == DocumentFieldType.Dictionary)
                {
                    IReadOnlyDictionary<string, DocumentField> itemFields = itemField.AsDictionary();

                    if (itemFields.TryGetValue("FirstName", out DocumentField? firstNameField))
                    {
                        if (firstNameField.ValueType == DocumentFieldType.String)
                        {
                            string firstName = firstNameField.AsString();

                            Console.WriteLine($"  FirstName: '{firstName}', with confidence {firstNameField.Confidence}");
                        }
                    }

                    if (itemFields.TryGetValue("LastName", out DocumentField? lastNameField))
                    {
                        if (lastNameField.ValueType == DocumentFieldType.String)
                        {
                            string lastName = lastNameField.AsString();

                            Console.WriteLine($"  LastName: '{lastName}', with confidence {lastNameField.Confidence}");
                        }
                    }
                }
            }
        }
    }


    if (document.Fields.TryGetValue("CompanyNames", out DocumentField? companyNamesField))
    {
        if (companyNamesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in companyNamesField.AsList())
            {
                
                if (itemField.ValueType == DocumentFieldType.String)
                {
                    string companyName = itemField.AsString();
                    Console.WriteLine($"Company name: '{companyName}', with confidence {itemField.Confidence}");

                }
            }
        }
    }


    if (document.Fields.TryGetValue("Departments", out DocumentField? departmentsField))
    {
        if (departmentsField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in departmentsField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.String)
                {
                    string departmentName = itemField.AsString();
                    Console.WriteLine($"Department name: '{departmentName}', with confidence {itemField.Confidence}");

                }
            }
        }
    }


    if (document.Fields.TryGetValue("JobTitles", out DocumentField? jobTitlesField))
    {
        if (jobTitlesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in jobTitlesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.String)
                {
                    string jobTitle = itemField.AsString();
                    Console.WriteLine($"Job Title: '{jobTitle}', with confidence {itemField.Confidence}");

                }
            }
        }
    }


    if (document.Fields.TryGetValue("Emails", out DocumentField? emailsField))
    {
        if (emailsField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in emailsField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.String)
                {
                    string email = itemField.AsString();
                    Console.WriteLine($"Email: '{email}', with confidence {itemField.Confidence}");

                }
            }
        }
    }

    if (document.Fields.TryGetValue("Websites", out DocumentField? websitesField))
    {
        if (websitesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in websitesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.String)
                {
                    string website = itemField.AsString();
                    Console.WriteLine($"Website: '{website}', with confidence {itemField.Confidence}");

                }
            }
        }
    }


    if (document.Fields.TryGetValue("Addresses", out DocumentField? addressesField))
    {
        if (addressesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in addressesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.String)
                {
                    string addrs = itemField.AsString();
                    Console.WriteLine($"Address: '{addrs}', with confidence {itemField.Confidence}");

                }
            }
        }
    }

    if (document.Fields.TryGetValue("MobilePhones", out DocumentField? mobilePhonesField))
    {
        if (mobilePhonesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in mobilePhonesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.PhoneNumber)
                {
                    string phoneNumber = itemField.Content;
                    Console.WriteLine($"Phone Number: '{phoneNumber}'. with confidence {itemField.Confidence}");

                }
            }
        }
    }

    if (document.Fields.TryGetValue("Faxes", out DocumentField? faxesField))
    {
        if (faxesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in faxesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.PhoneNumber)
                {
                    string faxNumber = itemField.Content;
                    Console.WriteLine($"Fax Number: '{faxNumber}'. with confidence {itemField.Confidence}");

                }
            }
        }
    }


    if (document.Fields.TryGetValue("WorkPhones", out DocumentField? workPhonesField))
    {
        if (workPhonesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in workPhonesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.PhoneNumber)
                {
                    string workPhone = itemField.Content;
                    Console.WriteLine($"Work Phone: '{workPhone}'. with confidence {itemField.Confidence}");

                }
            }
        }
    }

    if (document.Fields.TryGetValue("OtherPhones", out DocumentField? otherPhonesField))
    {
        if (otherPhonesField.ValueType == DocumentFieldType.List)
        {
            foreach (DocumentField itemField in otherPhonesField.AsList())
            {

                if (itemField.ValueType == DocumentFieldType.PhoneNumber)
                {
                    string otherPhoneNumber = itemField.Content;
                    Console.WriteLine($"Other Number: '{otherPhoneNumber}'. with confidence {itemField.Confidence}");

                }
            }
        }
    }

}