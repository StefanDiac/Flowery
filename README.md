# Flowery
A C# .NET desktop application for managing a flower shop. 


This project was created as part of a Windows Application Development class taken during my academic years at ASE Bucharest.

Note - Before running the project, please change the debug path of the project. 

The Application supports adding new flowers to a local SQLite 3 database, then creating orders for clients. Clients can order multiple flowers from the shop, which can either be in a singular bouquet, or group together to be in a basket. Once an order is finished, it is saved locally in the database, and can be viewed in the manager side of the application.

The manager tab allows the user to generate, and print reports, view graphs detailing sales, and so on. 

Flowers can also be added through drag and dropping the name and price ex: Rose, 1.0 on each line of a .txt file.

Known issue - Currently the location of one of the resource images is a string literal of where the project was last saved for testing. This should be changed to something that is relative, rather than absolute, and that will allow users to run the application correctly, regardless of location.
