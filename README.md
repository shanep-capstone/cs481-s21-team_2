# CS481 - Senior Design Project

[![.NET 5 CI](https://github.com/shanep-capstone/cs481-s21-team_2/actions/workflows/ci.yml/badge.svg)](https://github.com/shanep-capstone/cs481-s21-team_2/actions/workflows/ci.yml)

## Project Epic

### Project : Warehouse management

### Overview


Storage management is part of a lot of businesses but also one of the most complicated tasks to execute, some businesses are doing it manually with pieces of paper or excel file, others businesses bought sometimes expensive software. We would like to create a program that could handle most of the warehouse management functions to help these businesses. 
 
Warehouse management is control of the day-to-day operations of a warehouse such as the *shipping, receiving and put-away and picking of goods*. The program  should maximise the efficiency and effectiveness of operations.

 
**Our first goal** for the project will be to have a warehouse management software which will be stored on on a personal computer or a server, from a main menu you will have access to several basic functions:

1. **File entry**: with a file containing relevant information (items , reference, quantity, locations...) you will enter what is stored in the warehouse. Implement inventory tracking function.

2. **Shipping / receiving command**: to enter any new entry or shipping in the warehouse 

3. **Report**: report could created by for specific item(s) and/or for a specific time period to let the user know the shipping and receiving entries , stock left. Implement Total Transaction Management functionality

4. **file update** : this command will generate/ update a file on the warehouse storage (update file you entered in command 1 after you used command 2). Improve warehouse performance

5. **Shipping support**: to manage the shipping shipment notifications or rearrangement notification

6. **Receiving / handling support**: through wireless devices to scan and generate barcodes can be helped with a quick and easy way of support. Generate barcode reader using java

 
**Our second goal** will be to develop a web application where you could use your warehouse to rent storage space and invoice your customer, or also includes features to have a more complete supply chain management program , these features will help to manage the delivery time, the orders , stock management to store most valuable items using less space or check the turnover of specific items (like food):
 
1. **Invoicing** : adding a feature where you could enter a price per items to know the value of what is stored, the cost of storage per item/ sq foot ( to manage more efficiently your storage space or/and  send invoice to your customer renting part of your warehouse)

2. **Delivery**: adding a feature to know the delivery time per items and the minimum stock level they need, it will generate an alert or pit on the report on command 4 what items need to be reorder.

3. **Enter** what items and how much items you used on a time period ( weekly, monthly) the a report will tell when you will be below you security stock level and when to reorder according to the delivery time. Implement reporting features
 
4. **Improve visibility**: To make planning and forecasting easier for managers, visibility allows users to increase the accuracy of handling their products.

5. **Build the Login page** with authentication for  the web: For security of login, it can be used a platform like a firebase supports a backend as a service.

### Feedback from Shane

This is a great project idea! I have worked in industry on ERP/MRP projects and I know that there are a few small companies in the valley who would jump on an inventory system that just works. I would say if you are starting with a desktop app you should use C# and winforms. It would be the quickest to start with and is really well supported.

I am excited to see the finished project! 




## Tech lab


### C# and .NET Framework

**C#** pronounced as **C sharp** that is a general-purpose, multi-paradigm, object-oriented programming language and was developed by Microsoft. It is a lot similar to Java syntactically and widely used for developing web and desktop applications.

**.Net Framework** is a software development platform developed by Microsoft for building and running Windows applications. .NET Framework is part of the .NET platform, a collection of technologies for building apps for Linux, macOS, Windows, iOS, Android, and more. The . Net framework consists of developer tools, programming languages, and libraries to build desktop and web applications. It is also used to build websites, web services, and games.

We can see these frameworks mainly consist of **Framework Class Libraries** and **Common Language Runtime(CLR)**. CLR is a run-time environment which executes the code written in any .NET programming languages like C#, F#, C++,VB.Net, etc.
 A large number of class libraries are present in the framework. It provides a library of tested, reusable code that developers can call from their own apps. Mainly the applications are divided into three categories which are Window Forms, ASP.NET, ADO.NET. .NET Framework provides running apps including memory management that CLR provides, a common type system, an extensive class library, development frameworks and technologies, language interoperability, version compatibility, side-by-side execution to resolve version conflicts, multi targeting for working on multiple .NET Framework platforms.

**Window Form** is a UI framework for building Windows desktop apps. It provides productive ways to create desktop apps based on the visual designer provided in Visual Studio. **ASP.NET** is a web application framework and can use a featured programming language to build web applications easily. **The ASP.NET core MVC** provides a patterns-based way to build dynamic websites and full control over markup, and supports TDD-friendly development and use the latest web standards. **ADO.NET** is made of a set of classes that are used for connecting to a database, providing access to relational data such as SQL server and XML and retrieving results.

### Java and Spring Framework

The programming language **Java** is one of the most popular as it is easy to run and to write. Java is an object oriented language and is based on an English like syntax with few special characters which make it easy to read and to write but it also contains a huge library which will provide to its users really useful methods.
 
It is a universal language for **2 reasons**, firstly it can run on a personal  terminal ( phone ,computers) or a distributed system and secondly because it is used in a variety of applications : web application, android application ... The language is also really well supported and have a lot of software tools available to program in Java.
 
The **framework Spring** is one of the most popular, it contains different modules you can choose to develop specific programs: core, data access, web ... including also a wide variety of testing tools which is really useful for debugging easily. 

The spring interface is also simpler as you will select the modules you need and will increase the programmer productivity. Spring has a strong ecosystem which can provide a lot of template to develop a wide variety of applications.

As an **open source Java platform**, it provides core support for dependency injection, transaction management that is an important part of RDBMS-oriented enterprise application to ensure integrity and consistency, portable service abstraction, aspect-oriented programming that entails breaking down program logic into distinct parts classed concerns,web apps, data access and more. 

Spring is lightweight and covers most of Java EE(enterprise edition). A **Spring MVC** is used to build web applications and followers the Mode-View-Controller design pattern. A deployment descriptor is required. **String Boot** is a module that allows to build a stand-alone application with minimal or zero configuration. There is no requirement for a deployment.

We will use Spring boot for the standalone part and Spring MVC for the web app part of the project.


## Planning Lab

- [Troy's Plan](planning/Troy Livingston)
- [Troy's Plan](planning/Anna Han)
- [Troy's Plan](planning/Nicolas DUPUIS)
