using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace EliminateWarnings;

public class Person
{
//    public string FirstName { get; init; }
    public required string FirstName { get; init; }
//    public string MiddleName { get; init; }
    public string? MiddleName { get; init; }
//    public string LastName { get; init; }
    public string? LastName { get; init; }


    public override bool Equals(object? obj)
    {
//        var other = obj as Person;
        if (obj is Person other) // Already check nullability
        {
//            return FirstName.Equals(other.FirstName) && MiddleName.Equals(other.MiddleName) && LastName.Equals(other.LastName);
            return string.Equals(FirstName, other.FirstName) && string.Equals(MiddleName, other.MiddleName) && string.Equals(LastName, other.LastName);
        }
    return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FirstName, MiddleName, LastName);
    }


    public override string ToString()
        => $"{FirstName}, {MiddleName}, {LastName}";
}