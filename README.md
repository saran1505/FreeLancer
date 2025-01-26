# FreeLancer
FreeLance

This is a simple user management API implemented in C# using ASP.NET Core. It provides basic CRUD (Create, Read, Update, Delete) operations for managing user data.

Table of Contents
Features
Technology and Explaination
Getting Started
Prerequisites
Installation
Usage
Running the Application
Endpoints
Features
Retrieve a list of users
Retrieve a user by ID
Insert a new user
Update user data
Delete a user
Technology & Explaination
.Net core api, entity framework,Mssql server 2019.
Model validation
Swagger used for view and test purpose.
used Exception handling in Usercontroller.
Created Interface IUser for insert, update,getlist, delete methods.
added interface into middleware and injected interface into Usercontroller constructor method.
Used attribute route in UserController
Created Userrepository to bind data between model and database.
Getting Started
Prerequisites
.NET SDK
Installation
Clone the repository:

git clone (https://github.com/saran1505/FreeLancer.git)
2.Navigate to the project directory:

bash: cd UserApi

3.Restore dependencies: bash: dotnet restore
