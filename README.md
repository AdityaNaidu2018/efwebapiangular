#Overview

| API | Description | Request body |   Respose body |  
|-----------|:-----------:|-----------:|-----------:|    
| GET /api/todo | Get all to-do items | None | Array of to-do items |  
| GET /api/todo/{id} | Get an item by ID | None | To-do item |  
| POST /api/todo | Add a new item | To-do item | To-do item |  
| PUT /api/todo/{id} | Update an existing item | To-do item | None |  
| DELETE /api/todo/{id} | Delete an item | None | None |    

The following diagram shows the basic design of the app.

![design](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api/_static/architecture.png?view=aspnetcore-2.0)

1. The client is whatever consumes the web API (mobile app, browser, etc.). This tutorial doesn't create a client. Postman or curl is used as the client to test the app.
2. A model is an object that represents the data in the app. In this case, the only model is a to-do item. Models are represented as C# classes, also known as Plain Old CLR Object (POCOs).
3. A controller is an object that handles HTTP requests and creates the HTTP response. This app has a single controller.
4. To keep the tutorial simple, the app doesn't use a persistent database. The sample app stores to-do items in an in-memory database.


    #Task 1 -Web API with ASP.NET Core

        Create the project

        Register the database context

        Get to-do items

        Implement the other CRUD operations

        Call the Web API with jQuery

    #Task 2 - ASP.NET Core And Angular 4 Using WEB API

        Working with Angular
            Angular CLI
      
        Working with Angular Files
            Working with Angular Module

 


