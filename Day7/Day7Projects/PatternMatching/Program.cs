using System;
namespace PatternMatching {
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            object[] items = { "Hello", 42, 3.14, new Person("John", "Doe"), null };

            // i want to go or touch each elelement and do modiifcation to this element 
            //so using for loop i can do but for loop is there which will take only one 
            // type but i can use foreach loop and can use var but for each loop is 
            // read only loop 
            // so i can do patern matching here like this below code 
            foreach (var item in items)
            {
                // Pattern matching using switch expression
                string result = item switch
                {
                    string s => $"String of length {s.Length}: {s}",
                    int i => $"Integer: {i}",
                    double d => $"Double: {d}",
                    Person p => $"Person: {p.FirstName} {p.LastName}",
                    null => "Null value",
                    _ => "Unknown type"
                };

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }

}

