using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A Hashtable in C# is a collection that stores key-value pairs. It is similar to a dictionary but is not type-safe, meaning it can store any object as both key and value.
//The Hashtable class is found in the System.Collections namespace.

//Let's create a simple example to demonstrate how to use a Hashtable in C#. This example will cover adding, removing, and retrieving items, 
//as well as iterating through the Hashtable.

//Scenario: Storing and Managing User Information
//In this example, we will create a Hashtable to store user information, where the user ID (an integer) is the key, and the user name (a string)
//is the value.We will demonstrate basic operations like adding, accessing, modifying, and deleting items in the Hashtable.

namespace NonGenericHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a new Hashtable
            Hashtable users = new Hashtable();

            // Adding key-value pairs to the Hashtable
            users.Add(1, "Alice");
            users.Add(2, "Bob");
            users.Add(3, "Charlie");

            // Display all key-value pairs in the Hashtable
            Console.WriteLine("All users in the Hashtable:");
            foreach (DictionaryEntry entry in users)
            {
                Console.WriteLine($"User ID: {entry.Key}, User Name: {entry.Value}");
            }

            // Accessing an item using a key
            Console.WriteLine("\nAccessing user with ID 2:");
            if (users.ContainsKey(2))
            {
                Console.WriteLine($"User ID: 2, User Name: {users[2]}");
            }
            else
            {
                Console.WriteLine("User ID 2 not found.");
            }

            // Modifying an item in the Hashtable
            Console.WriteLine("\nModifying user with ID 3:");
            if (users.ContainsKey(3))
            {
                users[3] = "Chuck";
                Console.WriteLine($"User ID: 3, New User Name: {users[3]}");
            }

            // Removing an item from the Hashtable
            Console.WriteLine("\nRemoving user with ID 1:");
            if (users.ContainsKey(1))
            {
                users.Remove(1);
                Console.WriteLine("User ID 1 removed.");
            }

            // Display all key-value pairs in the Hashtable after removal
            Console.WriteLine("\nAll users in the Hashtable after removal:");
            foreach (DictionaryEntry entry in users)
            {
                Console.WriteLine($"User ID: {entry.Key}, User Name: {entry.Value}");
            }

            Console.ReadLine();

        }
    }
}
