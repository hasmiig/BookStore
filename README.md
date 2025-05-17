# Hygge Bookstore Management System

**Hygge Bookstore** is a desktop application developed in **C#** using **Windows Forms** and **Microsoft Visual Studio**. It was my **first-ever coding project**, built as a final assignment for my Object-Oriented Programming course. The system simulates a small bookstore selling books, music albums, and coffee products, with support for user authentication, inventory management, and billing.

## Project Overview

The application includes two roles: **Admin** and **Customer**.

### Admin Features

* Add, edit, and delete:

  * Books
  * Music albums
  * Coffee items
* Manage categories
* Create and manage customer accounts
* Track inventory and view order records

### Customer Features

* Log in using membership credentials
* Browse and filter products
* Add or remove items from the cart
* Place orders
* Receive discounts on Sundays and after 20+ orders

## Database

The project uses a local SQL Server database (`BookStoreDB`) with the following key tables:

* `UserTbl`
* `BookTbl`, `MusicTbl`, `CoffeeTbl`
* `CategoryTbl`, `ItemCategoryTbl`, `MusicCategoryTbl`
* `BillTbl`

## User Interface

Built with Windows Forms, the project includes:

* Login form (admin/user switch)
* Admin panel (books, music, coffee, users, inventory)
* Customer billing interface with tabbed views

## Tech Stack

* C#
* .NET Framework (Windows Forms)
* SQL Server
* Microsoft Visual Studio

## Getting Started

1. Clone or download the repository
2. Open the solution file in Visual Studio
3. Ensure SQL Server is running
4. Set up or restore the `BookStoreDB` schema
5. Build and run the application

## Status

This was a beginner-level academic project and an introduction to both programming and software development. It implements core OOP principles, basic UI design, and database integration.

## Author

Hasmig Aintablian
