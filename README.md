# ✈️ AirportManagement

## 🧾 Project Overview
**AirportManagement** is a **C# (.NET 8.0)** project that demonstrates key **Object-Oriented Programming (OOP)** principles through a simplified airport management system.

It simulates the management of **planes, flights, and passengers**, and highlights:
- **Encapsulation**
- **Inheritance**
- **Polymorphism**
- **Class Associations (Relationships)**

This project is organized into two main components:
- **AM.ApplicationCore** – Class Library containing domain entities and business logic.  
- **AM.UI.Console** – Console application used to test and demonstrate the system.

---

## 🧩 Domain Entities

### ✈️ Plane
- **Attributes:** `PlaneId`, `Capacity`, `ManufactureDate`, `PlaneType`
- **Relationships:** One-to-many with `Flight`  
  → `ICollection<Flight> Flights`

### 🛫 Flight
- **Attributes:** `FlightId`, `FlightDate`, `EffectiveArrival`, `EstimatedDuration`, `Departure`, `Destination`
- **Relationships:**
  - Many-to-one with `Plane`
  - Many-to-many with `Passenger`

### 👤 Passenger (Base Class)
- **Attributes:** `Id`, `FirstName`, `LastName`, `EmailAddress`, `BirthDate`, `TelNumber`, `PassportNumber`
- **Methods:**
  - `CheckProfile(...)` → Demonstrates **method overloading (polymorphism by signature)**  
  - `PassengerType()` → Demonstrates **method overriding (polymorphism by inheritance)**

**Derived Classes:**
- **Staff** – Inherits from `Passenger`
  - Attributes: `EmploymentDate`, `Function`, `Salary`
- **Traveller** – Inherits from `Passenger`
  - Attributes: `HealthInformation`, `Nationality`

---

## 🧠 Object-Oriented Programming Concepts

### 🔒 Encapsulation
All class attributes are implemented as **auto-properties** (`get; set;`) to ensure proper access control.

### 🧬 Inheritance
`Staff` and `Traveller` inherit from `Passenger`, allowing code reuse and specialization.

### 🎭 Polymorphism
- **By Signature (Overloading):**  
  Multiple versions of `CheckProfile()` with different parameter lists.
- **By Inheritance (Overriding):**  
  `PassengerType()` is redefined in subclasses to extend the parent’s behavior.

### 🔗 Associations
- `Plane` ↔ `Flight` → (1–*)
- `Flight` ↔ `Passenger` → (*–*)

---

## ⚙️ How to Run the Project

### 🧰 Prerequisites
- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or Visual Studio Code

### ▶️ Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AirportManagement.git
