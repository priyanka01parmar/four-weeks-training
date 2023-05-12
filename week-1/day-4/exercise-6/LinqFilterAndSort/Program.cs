using System;
using System.Collections.Generic;
using System.Linq;
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a list of Person objects with different properties
        List<Person> people = new List<Person>
        {
            new Person { FirstName = "John", LastName = "Doe", Age = 25 },
            new Person { FirstName = "Jane", LastName = "Smith", Age = 20 },
            new Person { FirstName = "Mike", LastName = "Johnson", Age = 30 },
            new Person { FirstName = "Emily", LastName = "Williams", Age = 18 },
            new Person { FirstName = "David", LastName = "Brown", Age = 16 }
        };
        // Use LINQ to filter the list to include only people who are 18 years old or older
        var filteredPeople = people.Where(p => p.Age >= 18)
                                   .OrderBy(p => p.LastName)
                                   .ThenBy(p => p.FirstName);
        // Print the filtered and sorted list of people to the console
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }
}

