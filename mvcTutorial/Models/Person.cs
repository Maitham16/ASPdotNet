namespace mvcTutorial.Models
{
    public class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public static Person GetPerson()
        {
            return new Person
            {
                FirstName = "Maitham",
                LastName = "Al-rubaye"
            };
        }
    }
}
