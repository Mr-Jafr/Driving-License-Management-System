# Driving License Management System (DVLD)

This project is a **C# application** that simulates a simplified **Driving & Vehicle License Department (DVLD)** system.  
It provides services for issuing, renewing, replacing, and managing driving licenses, along with handling applicants, tests, and user management.  
The project was created as a **student-level exercise** to practice **C#, OOP, databases, and multi-layered architecture**.

---

## ✨ Features
- **License Services**
  - Issue new licenses (by category)
  - Renew expired licenses
  - Replace lost or damaged licenses
  - Issue international driving licenses
  - Unlock suspended licenses
- **Applicants Management**
  - Store applicant personal info (national number, name, DOB, contact, photo, nationality)
  - Prevent duplicate records
- **Requests Management**
  - Submit and track service requests
  - Store request type, status, fees, and linked applicant
- **License Categories**
  - Different license types (motorcycle, car, taxi, bus, truck, etc.)
  - Age restrictions, validity periods, and fees
- **Tests**
  - Medical test (vision check)
  - Theoretical knowledge test
  - Practical driving test
  - Results stored in the system
- **Admin Panel**
  - Manage system users
  - Assign roles and permissions
  - Freeze, edit, or delete users
  - Track system activity logs

---

## 🛠️ Technologies
- **Language:** C#  
- **Framework:** .NET (WinForms or Console)  
- **Database:** SQL Server / LocalDB  
- **Concepts Used:** OOP, 3-tier architecture, ADO.NET  

---

## 🚀 How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/Mr-Jafr/Driving-License-Management-System.git

2. Open the solution in Visual Studio you can find it in the DVLDpresentationLayer folder.

3. Configure the database connection in App.config and in contactsDataAccessLayer.

4. Build and run the project.

---

## 📜 Purpose

This project was created as a training exercise to:

- Practice Object-Oriented Programming (OOP) in C#.

- Work with databases and data persistence.

- Design and simulate a real-world service-based system.