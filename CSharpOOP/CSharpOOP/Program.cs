﻿using System;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the object using the "new" keyword - generate an instance of a class / blueprint.
            Person person = new Person();
            // The new object has all of the properties that are specified in the class, but they are tied to that object.
            // One object's properties cannot see another object's properties without explicitly passing the values.

            Console.Write("Please enter your first name: ");
            person.FirstName = Console.ReadLine().Trim();

            Console.Write("Please enter your last name: ");
            person.LastName = Console.ReadLine().Trim();

            Console.WriteLine($"Hello, {person.FirstName} {person.LastName}!");
        }
    }
}
