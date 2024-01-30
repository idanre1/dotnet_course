// var bill = new Person("William Henry", "Gates"); //error

public class Person
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public string FullName => $"{FirstName} {LastName}";
    public Person(string firstName, string lastName)
    => (FirstName, LastName) = (firstName, lastName);
}

