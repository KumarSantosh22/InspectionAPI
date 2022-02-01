# Install EF Tool
dotnet tool install --global dotnet-ef

# Make Migrations
dotnet ef migrations add <name of migration>

# Update in DB
dotnet ef database update
