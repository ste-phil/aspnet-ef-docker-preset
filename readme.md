# **.NET Core** + **ASP.NET Core** + **EF Core** + **Postgres Db** with **Docker** config repo
A repository which holds a minimal configuration for a fast project setup for use in x64 and linux-arm32 (Raspberry PI 3 B+) environments.


## Project structure
The project consists of 3 .NET Core projects
* HomeApp.Server is the ASP.NET Core server which requires the database to access index.html since the database is accessed in the page as an example.
* HomeApp.Persistence is a .NET Core class library which holds the the EF Database context as well as a Repository pattern for access to the context.
* HomeApp.Library is another .NET Core class library which holds all the C# classes used throughout this project.

## Usage
First of all check if you have Docker, .NET Core, ASP.NET Core installed. The .NET Core stuff is convenient to have installed on the dev machine, to directly execute the code without docker, on the deployment machine only docker is required.

Since the ASP.NET Core server (HomeApp.Server) requires a database to operate it is required to start a database first. The **tasks.json** comes with some preloaded scripts for windows to start a postgres-db (start-postgres) container or mssql-db (start-mssql) container. The corresponding tasks also check if the container is already running. 

It is now possible to run the server with access to the database by executing either the "watch" task or by using the ".NET core Launch" lauch option to directly debug the code. The benefit of using the "watch" task is that it automatically recompiles if "non rude" edits(see dotnet doc for definition) have been made, this speeds up the development process alot :).

If you want to deploy your application on your target platform you can execute the "docker publish" task which creates an x64 and arm32 docker image of the code, packs it into a docker manifest and publishes it to https://hub.docker.com to the specified registry in the "settings.json" file. To use these images on the deployment machine simply use the "docker-compose.yml" file on the machine by executing "docker compose pull" in the folder containing this file. This instructs docker to get/update the required images from the specified registries. You have to change the registry in the "docker-compose.yml" file to point to your own registry for it to work. To run the images use "docker compose up". If everything started up correctly you should be able to connect to the server with http://localhost.

## Additional stuff
This repository is supposed to be used inside VS Code.

If somebody else somehow finds that repository and knows how to further improve this example project feel free to let me know :)