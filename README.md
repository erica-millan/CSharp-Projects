# csharp-Projects

# The Tech Academy Basic C-Sharp Projects

This repository contains some highlighted C# projects completed during The Tech Academy’s Software Boot Camp.

---

## Abstract Class Assignment
C# console app that demonstrates object-oriented concepts including:  
- **Abstraction** – Person being the abstract class that can’t be instantiated  
- **Inheritance** – Employee inherits properties from Person and fulfills the abstract contract  
- **Interfaces** – IQuittable defines Quit() method that implementing classes must provide  
- **Polymorphism** – In Program.cs, an Employee object is referenced as an IQuittable, demonstrating how an object can be treated as its interface type  

---

## StudentCodeFirstApp
C# console application that uses Entity Framework 6 (Code‑First) to create a database and insert a student record.  
The code defines a Student class with StudentId, Name, and Age, creates a StudentContext that inherits from DbContext, uses EF Code‑First to automatically create a database named StudentDataBase, inserts a student into the Students table, and saves the changes.

---

## Anonymous Income Comparison Program
C# console app that compares the annual income of two people based on their hourly rate and hours worked.

---

## Car Insurance Approval Program
C# application that determines whether an applicant qualifies for car insurance based on age, DUI history, and speeding tickets.

---

## Car Insurance MVC Application
ASP.NET Core MVC web app that connects to a SQL Server database and uses Entity Framework Core to manage car insurance data.  
The project shows how an MVC app is set up, how the database connection works, and how routing is configured.  
It uses the MVC structure, connects to a SQL Server database using Entity Framework Core, loads pages through controllers and views, and runs as an ASP.NET Core website.

---

## Server Time App
An ASP.NET Core Razor Pages application that uses the default setup for serving pages, handling routing, and running the site.  
It runs a Razor Pages website, uses HTTPS, serves static files like CSS, JS, and images, handles errors, and maps and loads Razor Pages automatically.

---

## Shipping Quote Application
C# console app that calculates a shipping quote based on a package’s weight and dimensions.
