# ✈️ AirportManagement

## 🧾 Project Overview
**AirportManagement** is a **C# (.NET 8.0)** project designed to demonstrate key **Object-Oriented Programming (OOP)** principles using an airport management scenario.

The project simulates the management of planes, flights, and passengers while illustrating:
- **Encapsulation**
- **Inheritance**
- **Polymorphism**
- **Class relationships (associations)**

It is composed of two main projects:
- **AM.ApplicationCore** – Class Library containing the domain entities and business logic.  
- **AM.UI.Console** – Console application used for testing and demonstrating functionality.

---

## 🧩 Main Concepts and Features

### ✈️ Plane
- Attributes: `PlaneType`, `Capacity`, `ManufactureDate`
- Relationships: One-to-many with `Flight`  
  → `ICollection<Flight> Flights`

### 🛫 Flight
- Attributes: `FlightDate`, `Destination`, `Departure`, `EstimatedDuration`
- Relationships:
  - Many-to-one with `Plane`
  - Many-to-many with `Passenger`

### 👤 Passenger (Base Class)
- Attributes: `Id`, `FullName`, `Email`, etc.  
- Methods:
  - `CheckProfile(...)` → Demonstrates **method overloading (polymorphism by signature)**  
  - `PassengerType()` → Demonstrates **method overriding (polymorphism by inheritance)**

**Derived Classes:**
- **Staff** – Inherits from `Passenger`
- **Traveller** – Inherits from `Passenger`

---

## 🧠 Object-Oriented Programming Concepts

### 🔒 Encapsulation
All attributes are implemented as **properties** with getters and setters (`get; set;`), ensuring controlled access to class data.

### 🧬 Inheritance
`Staff` and `Traveller` inherit from the base class `Passenger`, sharing common properties and behaviors.

### 🎭 Polymorphism
- **By Signature (Method Overloading):**
  Multiple versions of `CheckProfile()` with different parameter lists.  
- **By Inheritance (Method Overriding):**
  Each subclass redefines `PassengerType()` to extend the parent’s behavior.

### 🔗 Associations
- `Plane` ↔ `Flight` (1–*)
- `Flight` ↔ `Passenger` (*–*)

---

## ⚙️ How to Run the Project

### 🧰 Requirements
- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or Visual Studio Code

### ▶️ Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AirportManagement.git
