// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;

Console.WriteLine("Hello, World!");
// Correction CS7036, IDE0017, IDE0090 : utilisation du constructeur adéquat et initialisation simplifiée
Plane plane1 = new(1, 200, new DateTime(2025, 11, 11), Plane.PlaneType.Airbus)
{
    Capacity = 200
};
Console.WriteLine(plane1.ToString());

Passenger passenger = new Passenger
{
    Id = 1,
    FirstName = "Farah",
    LastName = "Derbel",
    EmailAddress = "farah.derbel@esprit.tn",
    PassportNumber = "X1234567",
    BirthDate = new DateTime(1995, 5, 20)
};
passenger.CheckProfile("Farah", "Derbel");
Console.WriteLine(passenger.ToString());
//test optional parameter
Console.WriteLine(passenger.CheckProfile("Farah", "Derbell"));
Staff staff1 = new Staff
{
    Id = 2,
    FirstName = "John",
    LastName = "Doe",
    Function = "Pilot",
    Salary = 75000,
    EmploymentDate = new DateTime(2015, 3, 1)
};

Console.WriteLine(staff1.ToString());

Traveller traveller1 = new Traveller
{
    Nationality = "American",
    HealthInformation = "No known allergies",

};
Console.WriteLine(traveller1.ToString());