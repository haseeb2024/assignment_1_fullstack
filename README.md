# EdutotsSchools

## Run

Requires the .NET 10 SDK.

&#x20;   dotnet run


Then open the URL printed in the console

## Pages

* `/`          Home (template page, updated with a link to Schools)
* `/schools`   Searchable school list + details panel (the assignment)
* `/counter`   Template Counter page
* `/weather`   Template Weather page
* `/Error`, `/not-found` Template error pages

## Assignment code

* `Models/School.cs` - model with only the 7 required fields
* `Services/SchoolService.cs` - typed HttpClient + JSON deserialization
* `Components/Pages/Schools.razor` - list, search, loading/error states, selection
* `Components/Shared/SchoolCard.razor` - reusable card (`\[Parameter] School`, `EventCallback<School> OnSelect`)
* `Components/Shared/SchoolDetails.razor` - detail panel
* API base URL is configurable in `appsettings.json` (`EdutotsApi:BaseUrl`)

