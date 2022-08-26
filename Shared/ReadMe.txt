Package Manager Console:   dotnet tool install --global dotnet-ef  

nuget packages:
   install Microsoft.EntityFrameworkCore 
   install Microsoft.EntityFrameworkCore.Design
   install Microsoft.EntityFrameworkCore.SqlServer

PM> cd Server
PM> dotnet ef migrations add createInitial   //add migration

PM> dotnet ef migrations remove    //delete migration

PM> dotnet ef database update      //Update database from migration

PM> dotnet ef migrations add ProductSeeding  //Seed data

PM> dotnet ef migrations add categories //add migration

PM> dotnet ef database update //Update database from migration
