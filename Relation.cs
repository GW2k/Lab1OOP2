namespace InheritanceDemo
{
    public class Relation
    {
        private string RelationshipType { get; set; }

        public Relation(string relationshipType)
        {
            RelationshipType = relationshipType;
        }

        public void ShowRelationShip(Person person, Person person2)
        {
            Console.WriteLine($"Relationship between {person.FirstName} and {person2.FirstName} is: {RelationshipType}");
        }
    }
}