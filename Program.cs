using System.Text.Json;

namespace Assignment_10._1
{
    public class Identification
    {
        // Properties
        public string FirstName { get; set; } // First name
        public string LastName { get; set; } // Last name
        public double HeightInCentimeters { get; set; } // Height in centimeters
        public char EyeColor { get; set; } // Eye color (single character)
        public DateTime DateOfBirth { get; set; } // Date of birth


        public Identification(string firstName, string lastName, double height, char eyeColor, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            HeightInCentimeters = height;
            EyeColor = eyeColor;
            DateOfBirth = dateOfBirth;
        }
        public class Program
        {
            static void Main()
            {
                // Create an instance of Identification
                var person = new Identification
                {
                    FirstName = "Peter",
                    LastName = "Parker",
                    HeightInCentimeters = 175.5,
                    EyeColor = 'B',
                    DateOfBirth = new DateTime(1990, 5, 15)
                };

                // Serialize to JSON
                var jsonString = JsonSerializer.Serialize(person);
                Console.WriteLine(jsonString);

                // JSON string (replace with JSON data)
                string jsonString = @"{
                ""FirstName"": ""John"",
                ""LastName"": ""Doe"",
                ""HeightInCentimeters"": 175.5,
                ""EyeColor"": ""B"",
                ""DateOfBirth"": ""1990-05-15T00:00:00""}";

                // Deserialize from JSON
                var deserializedPerson = JsonSerializer.Deserialize<Identification>(jsonString);

                // Use the deserialized object
                Console.WriteLine($"First Name: {deserializedPerson.FirstName}");
                Console.WriteLine($"Last Name: {deserializedPerson.LastName}");
                Console.WriteLine($"Height: {deserializedPerson.HeightInCentimeters} cm");
                Console.WriteLine($"Eye Color: {deserializedPerson.EyeColor}");
                Console.WriteLine($"Date of Birth: {deserializedPerson.DateOfBirth}");
            }

        }

    }

}
