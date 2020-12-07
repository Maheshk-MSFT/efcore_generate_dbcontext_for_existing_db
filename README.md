# efcore_generate_dbcontext_from_existing_db

For VS 2019, Package manager commands to generate the model class and context: 
==============================================================================
PM> Add-Migrate InitialCreate (generate code) 

PM> Update-Database (Creates the db tables) 

PM> Add-Migration AddEmail (for code update to DB change) 

PM> Update-Database


src: https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=vs 


---
For VS Code
==============
dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet ef migrations add AddBlogCreatedTimestamp

dotnet ef database update


src: https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli 


![mk](https://user-images.githubusercontent.com/61469290/101345809-a1347780-38ad-11eb-88d3-588f9ee4820b.PNG)

![mk1](https://user-images.githubusercontent.com/61469290/101346135-2324a080-38ae-11eb-87de-1ae9c7aef3db.PNG)

