## Project using Code first approach
### Do the following to setup project
* run ```dotnet tool install --global dotnet-ef``` to install dotnet toll global
* run ```dotnet ef migrations add InitialCreate```to generate Migrations folder and init code for database
* run ```dotnet ef database update``` to generate database
* run ```dotnet ef database drop``` to drop database
* run ```ef migrations remove``` to remove all Migrations files