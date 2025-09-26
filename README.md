# 📚 Library Management System

A simple **C# console-based Library Management System** that allows you to manage books, borrowers, and loans. This project teaches object-oriented design, CRUD operations, and data persistence with JSON.

---

## 🎯 Goal

Build a console application that:

- Adds, removes, and lists books  
- Registers and manages borrowers  
- Processes borrow and return actions with due dates  
- Tracks book availability  

---

## 📚 Features

- Add and remove books with title, author, genre, and ISBN  
- Register borrowers with name and contact info  
- Borrow and return books with loan tracking  
- List all books and borrowers  
- Persist data to JSON files for books, borrowers, and loans  
- Simple text-based menu interface  

---

## 🗂️ Project Structure

```c#
LibraryManagementSystem/
├─ Program.cs // Entry point and menu
├─ Library.cs // Manages books and borrowers
├─ Book.cs // Book entity
├─ Borrower.cs // Borrower entity
├─ LoanRecord.cs // Represents a book loan transaction
├─ Menu.cs // Handles input menus
├─ data/
│ ├─ books.json // Books data
│ ├─ borrowers.json // Borrowers data
│ ├─ loans.json // Loan records
└─ README.md
```

---

## 🔹 Classes and Responsibilities

### Book

- Represents a single book  
- Stores Title, Author, Genre, ISBN, IsAvailable  
- Can change availability when borrowed or returned  

### Borrower

- Represents a library member  
- Stores Name, ContactInfo, BorrowedBooks  
- Tracks borrowed books  

### LoanRecord

- Tracks a single book loan  
- Stores BookID, BorrowerID, BorrowDate, DueDate, ReturnDate  
- Marks when a book is returned  

### Library

- Core manager for books and borrowers  
- Adds/removes books, registers borrowers  
- Processes borrow/return actions  
- Checks availability  
- Saves/loads data to/from JSON  

### Menu

- Handles user interaction  
- Shows menu options and parses input  
- Calls Library methods based on commands  

---

## 🔹 Data Files Example

**books.json**

```json
[
  {
    "Id": 1,
    "Title": "C# in Depth",
    "Author": "Jon Skeet",
    "Genre": "Programming",
    "IsAvailable": true
  }
]
```

**borrowers.json**

```json
[
  {
    "Id": 1,
    "Name": "Jane Doe",
    "ContactInfo": "jane@example.com",
    "BorrowedBooks": []
  }
]
```

**loans.json**

```json
[
  {
    "BookId": 1,
    "BorrowerId": 1,
    "BorrowDate": "2025-09-14",
    "DueDate": "2025-09-21",
    "ReturnDate": null
  }
]
```

---

## ⚡ Learning Goals

- Model real-world entities using C# classes

- Implement CRUD operations with collections

- Manage relationships between entities (books ↔ borrowers)

- Persist and load data with JSON

- Separate UI logic from business logic

---

## 🚀 Getting Started

1. Create the file structure above.

2. Initialize JSON files with sample data.

3. Implement classes for Book, Borrower, LoanRecord, Library, and Menu.

4. Use menu options to add, borrow, return, and list books and borrowers.

5. Run the project:

```bash
dotnet run
```

---

## 🛠️ Possible Improvements

- Add search and filter options for books

- Track overdue loans and send notifications

- Add categories or genres for filtering

- Implement more detailed borrower reports

- Transition to a GUI or web-based system with ASP.NET
