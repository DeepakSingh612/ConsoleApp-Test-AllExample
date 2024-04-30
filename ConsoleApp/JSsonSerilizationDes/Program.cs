using System.Text.Json;
using System;

namespace JSsonSerilizationDes
{
    internal class Program
    {
       public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string StateOfOrigin { get; set; }
            public List<Pet> Pets { get; set; }
        }

       public class Pet
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public double Age { get; set; }
        }

        private static void SerizalizeExample()
        {
            var pets = new List<Pet>
    {
        new Pet { Type = "Cat", Name = "MooMoo", Age = 3.4 },
        new Pet { Type = "Squirrel", Name = "Sandy", Age = 7}
    };
            var person = new Person
            {
                Name = "John",
                Age = 34,
                StateOfOrigin = "England",
                Pets = pets
            };
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            Console.WriteLine(JsonSerializer.Serialize(person, options));
        }
            private static void DeserizalizeExample()
        {
            var jsonPerson = @"{""Name"":""John"",
                        ""Age"":34,
                        ""StateOfOrigin"":""England"",
                        ""Pets"":
                            [{""Type"":""Cat"",""Name"":""MooMoo"",""Age"":3.4},
                            {""Type"":""Squirrel"",""Name"":""Sandy"",""Age"":7}]}";
            var personObject = JsonSerializer.Deserialize<Person>(jsonPerson);
            Console.WriteLine($"Person's name: {personObject.Name}");
            Console.WriteLine($"Person's age: {personObject.Age}");
            Console.WriteLine($"Person's first pet's name: {personObject.Pets.First().Name}");
        }
        static void Main(string[] args)
        {
            SerizalizeExample();
            DeserizalizeExample();
            Console.ReadLine();
        }
    }
}
