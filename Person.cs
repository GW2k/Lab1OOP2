namespace InheritanceDemo
{
    public class Person
    {
        private int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FirstName} {LastName}'s favourite color is: {FavoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            FavoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return Age + 10;
        }

        public override string ToString()
        {
            return
                $"Person Id: {PersonId} " +
                $"{Environment.NewLine}First Name: {FirstName} " +
                $"{Environment.NewLine}Last Name: {LastName} " +
                $"{Environment.NewLine}Favorite Color: {FavoriteColour} " +
                $"{Environment.NewLine}Age: {Age} " +
                $"{Environment.NewLine}Is Working: {IsWorking}";
        } 
    }
}