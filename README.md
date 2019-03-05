För att demot ska funka krävs följande:
1. Lägg till ConnectionString i application.json
2. Migrera och skapa databasen för användare med kommandon:

dotnet ef migrations add Initial

dotnet ef database update

