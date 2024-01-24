using System;

namespace InheritanceDemo
{
    class Program
    {
        private static void Main(string[] args)
        {
            // People Objects
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            
            person2.DisplayPersonInfo();
            Console.WriteLine(person3.ToString());
            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();
            Console.WriteLine($"{person4.FirstName} {person4.LastName}'s age in 10 years is: {person4.GetAgeInTenYears()}");
            
            // Sets The relationship between the people
            Relation relation = new Relation("Sisterhood");
            relation.ShowRelationShip(person2, person4);
            Relation relation2 = new Relation("Brotherhood");
            relation2.ShowRelationShip(person1, person3);

            // Adds everyone to a list
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            // Calculates the average age
            int totalAge = people.Sum(person => person.Age);
            double averageAge = (double)totalAge / people.Count;
            Console.WriteLine($"Average Age is: {averageAge}");

            // Finds the youngest and oldest of the people in the list
            Person youngest = people.OrderBy(person => person.Age).First();
            Person oldest = people.OrderBy(person => person.Age).Last();
            Console.WriteLine($"The youngest person is: {youngest.FirstName}");
            Console.WriteLine($"The oldest person is {oldest.FirstName}");

            // loops through each person in the list and finds who likes blue
            foreach (Person person in people)
            {
                if (person.FavoriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }

            // loops and finds names that start with M
            foreach (Person person in people)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());
                }   
            }
        }
    }
}